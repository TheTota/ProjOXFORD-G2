//-----------------------------------------------------------------------
// <copyright file="TraitementBdd.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Thomas LAURE</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // Librairie de connexion à MySQL ajoutée en référence.

namespace ProjOXFORD_G2
{
    /// <summary>
    /// Classe qui va permettre la récupération des identifiants liés à la photo prise.
    /// </summary>
    public class TraitementBdd
    {
        /// <summary>
        /// Membre privé contenant les informations de connexion à la base de données.
        /// Le @ sert à prendre la chaîne de caractères telle quelle.
        /// </summary>
        private const string CNX = @"Server=127.0.0.1; Port=3306; Database=oxford; Uid=root; Pwd=;";

        /// <summary>
        /// Déclaration d'un objet de la classe MysqlConnection.
        /// Va être utilisé pour gérer la connexion à la base de données MySQL.
        /// </summary>
        private static MySqlConnection _connexion;

        /// <summary>
        /// Membre privé qui va contenir la requête.
        /// </summary>
        private static string _requete;

        /// <summary>
        /// Méthode de connexion à la base de données.
        /// </summary>
        /// <exception cref="Exception">Erreur de connexion à la base de données MySQL.</exception>
        public static void OuvrirConnexion()
        {
            try
            {
                _connexion = new MySqlConnection(CNX);
                if (_connexion.State == ConnectionState.Closed)
                {
                    _connexion.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur de connexion à la base de données MySQL.\n" + ex.Message);
            }
        }

        /// <summary>
        /// Méthode publique de fermeture de la connexion à la base de données MySQL.
        /// Va permettre de libérer les ressources de la base de données après une requête.
        /// </summary>
        public static void FermerConnexion()
        {
            if (_connexion.State != ConnectionState.Closed)
            {
                _connexion.Dispose();
                _connexion.Close();
            }
        }

        /// <summary>
        /// Méthode de récupération de la photo.
        /// Destinée à l'affichage
        /// </summary>
        /// <exception cref="Exception">La requête n'a pu aboutir.</exception>
        public static void RecupPhoto()
        {
            _requete = @"SELECT value FROM photos;";
            try
            {
                OuvrirConnexion();
                MySqlCommand cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                var scalar = cmd.ExecuteScalar();  // Permet de stocker le résultat de la requête quand elle renvoie une valeur unitaire.
                Console.WriteLine("Requête effectuée.");
                FermerConnexion();
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary>
        /// Méthode de récupération des informations de l'utilisateur.
        /// </summary>
        public static void RecupInfosUser()
        {
            _requete = @"SELECT photo, nom, prenom, type, birth, sexe, status, email FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceid;";
            try
            {
                OuvrirConnexion();
                MySqlCommand cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@faceid", string.Empty);   // La valeur du paramètre sera la valeur retournée par la méthode qui ira chercher la valeur du FaceID dans le fichier JSON.
                var reader = cmd.ExecuteReader();  // Permet de stocker le résultat de la requête quand elle retourne plusieurs valeurs.
                Console.WriteLine("Requête effectuée.");
                FermerConnexion();
                return reader;
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le code de l'utilisateur dans la base de données.
        /// Ce mot de passe sera destiné à être comparé avec celui saisi dans le formulaire afin d'identifier l'utilisateur.
        /// </summary>
        /// <param name="id">Identifiant du propriétaire du code.</param>
        /// <returns>Le code de l'utilisateur.</returns>
        /// <exception cref="Exception">La requête n'a pu aboutir.</exception>
        public static int RecupPwd(int id)
        {
            _requete = @"SELECT code FROM users WHERE id = @id;";
            try
            {
                OuvrirConnexion();
                MySqlCommand cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@id", id);
                var scalar = cmd.ExecuteScalar();
                Console.WriteLine("Requête effectuée.");
                FermerConnexion();
                return Convert.ToInt32(scalar);
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de comparer deux mots de passe, mdp1 et mdp2.
        /// </summary>
        /// <param name="mdp1">Mot de passe saisi par l'utilisateur.</param>
        /// <param name="mdp2">Mot de passe stocké en base de données.</param>
        /// <returns>True s'il y a correpondance, sinon retourne False.</returns>
        public static bool ComparePsw(int mdp1, int mdp2)
        {
            if (mdp1 == mdp2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode qui insert un événement dans la table Events en base de données.
        /// </summary>
        /// <param name="utilisateur">Utilisateur ayant déclenché l'événement.</param>
        /// <param name="categorie">Catégorie de l'événement.</param>
        /// <param name="valeur">Valeur de l'événement.</param>
        /// <exception cref="Exception">La requête n'a pu aboutir.</exception>
        public static void CreerEvent(int utilisateur, int categorie, string valeur)
        {
            _requete = @"INSERT INTO events(user, category, date, value) VALUES (@utilisateur, @categorie, @date, @valeur);";
            //// La date sera un timestamp qui contiendra le nombre de secondes depuis le 01/01/1970.
            int timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            try
            {
                OuvrirConnexion();
                MySqlCommand cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@utilisateur", utilisateur);
                cmd.Parameters.AddWithValue("@categorie", categorie);
                cmd.Parameters.AddWithValue("@date", timestamp);
                cmd.Parameters.AddWithValue("@valeur", valeur);
                cmd.ExecuteNonQuery();
                FermerConnexion();
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary>
        /// L'événement créé en base de données sera de la catégorie Erreur.
        /// </summary>
        /// <param name="utilisateur">ID de l'utilisateur ayant déclenché l'erreur.</param>
        /// <param name="valeur">Valeur de l'erreur.</param>
        /// <exception cref="Exception">La requête n'a pu aboutir.\n" + ex.Message</exception>
        public static void EventErreur(int utilisateur, string valeur)
        {
            try
            {
                CreerEvent(utilisateur, 1, valeur);
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary>
        /// L'événement créé en base de données sera de la catégorie Information.
        /// </summary>
        /// <param name="utilisateur">ID de l'utilisateur ayant déclenché la remontée d'information.</param>
        /// <param name="valeur">Valeur de l'information.</param>
        /// <exception cref="Exception">La requête n'a pu aboutir.\n" + ex.Message</exception>
        public static void EventInfo(int utilisateur, string valeur)
        {
            _requete = @"INSERT INTO events(user, category, date, value) VALUES (@utilisateur, @categorie, @date, @valeur);";
            try
            {
                CreerEvent(utilisateur, 2, valeur);
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary>
        /// L'événement créé en base de données sera de type Administration.
        /// </summary>
        /// <param name="utilisateur">ID de l'utilisateur ayant déclenché l'événement de ce type.</param>
        /// <param name="valeur">Valeur de l'événement.</param>
        /// <exception cref="Exception">La requête n'a pu aboutir.\n" + ex.Message</exception>
        public static void EventAdmin(int utilisateur, string valeur)
        {
            try
            {
                CreerEvent(utilisateur, 3, valeur);
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }
    }
}