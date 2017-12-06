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
//// Ne pas oublier d'installer le connecteur .Net pour MySQl qui se trouve dans ProjOXFORD-G2\ProjOXFORD-G2\Ressources\

namespace ProjOXFORD_G2
{
    /// <summary> Classe qui va permettre la récupération des identifiants liés à la photo prise. </summary>
    /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
    public static class TraitementBdd
    {
        /// <summary> Membre privé contenant les informations de connexion à la base de données. Le @ sert
        /// à prendre la chaîne de caractères telle quelle. </summary>
        private const string CNX = @"Server=mysql-simubac.alwaysdata.net; Port=3306; Database=simubac_oxford; Uid=simubac; Pwd=aDemantA;";  // private const string CNX = @"Server=mysql-oxfordbonaparte.alwaysdata.net; Port=3306; Database=oxfordbonaparte_db; Uid=148178; Pwd=ToRYolOU;";

        /// <summary> Déclaration d'un objet de la classe MysqlConnection. Va être utilisé pour gérer la
        /// connexion à la base de données MySQL. </summary>
        private static MySqlConnection _connexion;

        /// <summary> Membre privé qui va contenir la requête. </summary>
        private static string _requete;

        /// <summary> Déclaration d'un objet de la classe MySqlCommand. Permet d'exécuter une requête,
        /// récupérer le résultat de la requête, et d'exécuter une procédure stockée. </summary>
        private static MySqlCommand _cmd;

        /// <summary> Méthode de connexion à la base de données. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        /// <exception cref="Exception"> Erreur de connexion à la base de données MySQL. </exception>
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

        /// <summary> Méthode publique de fermeture de la connexion à la base de données MySQL. Va
        /// permettre de libérer les ressources de la base de données après une requête. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        public static void FermerConnexion()
        {
            if (_connexion.State != ConnectionState.Closed)
            {
                _connexion.Dispose();
                _connexion.Close();
            }
        }

        /// <summary> Méthode permettant de renvoyer une erreur. Ecrite pour éviter la réécriture de code. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        /// <exception cref="Exception"> Thrown when an exception error condition occurs. </exception>
        /// <param name="ex"> Exception qui sera retournée. </param>
        /// <returns> Erreur d'exécution de la requête. </returns>
        public static Exception RenvoyerErreur(Exception ex)
        {
            FermerConnexion();
            throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
        }

        /// <summary> Méthode de récupération de la photo. Destinée à l'affichage. </summary>
        /// <remarks> Almarean, 22/11/2017. </remarks>
        public static void RecupPhoto()
        {
            _requete = @"SELECT value FROM photos;";
            try
            {
                OuvrirConnexion();
                _cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                var scalar = _cmd.ExecuteScalar();  // Permet de stocker le résultat de la requête quand elle renvoie une valeur unitaire.
                Console.WriteLine("Requête effectuée.");
                FermerConnexion();
            }
            catch (Exception ex)
            {
                RenvoyerErreur(ex);
            }
        }

        /// <summary> Méthode de récupération des informations de l'utilisateur. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        /// <exception cref="Exception"> Thrown when an exception error condition occurs. </exception>
        /// <param name="faceId"> Face ID de la personne dont on veut récupérer les informations. </param>
        /// <returns> Un jeu d'enregistrement concernant la personne à qui appartient le faceid. </returns>
        public static string RecupInfosUser(string faceId)
        {
            _requete = @"SELECT photo, nom, prenom, type, birth, sexe, status, email FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceid;";
            try
            {
                OuvrirConnexion();
                string nom = string.Empty;
                string prenom = string.Empty;
                _cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                _cmd.Parameters.AddWithValue("@faceid", faceId);   // La valeur du paramètre sera la valeur retournée par la méthode qui ira chercher la valeur du FaceID dans le fichier JSON.
                var reader = _cmd.ExecuteReader();  // Permet de stocker le résultat de la requête quand elle retourne plusieurs valeurs.
                while (reader.Read())
                {
                    nom = reader.GetString(1);
                    prenom = reader.GetString(2);
                }
                //// Ecriture du nom et du prénom en respectant les majuscules.
                string infosAffichees = nom.ToUpper() + " " + ReconnaissanceFaciale.PrenomToUpperFirstCase(prenom);
                FermerConnexion();
                return infosAffichees;
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary> Méthode permettant de récupérer le mot de passe enregistré en BDD avec celui saisi
        /// dasn le formulaire. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        /// <exception cref="Exception"> La requête n'a pu aboutir. </exception>
        /// <param name="faceId"> Face ID de la personne dont on veut récupérer le mot de passe. </param>
        /// <returns> Le mot de passe récupéré en base de données. </returns>
        public static int RecupMdp(string faceId)
        {
            _requete = @"SELECT code FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceId;";
            try
            {
                OuvrirConnexion();
                _cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                _cmd.Parameters.AddWithValue("@faceId", faceId);
                var scalar = _cmd.ExecuteScalar();
                FermerConnexion();
                return Convert.ToInt32(scalar);
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary> Récupère l'identifiant de l'utilisateur en fonction de son face ID. </summary>
        /// <remarks> Thomas LAURE, 06/12/2017. </remarks>
        /// <exception cref="Exception"> Thrown when an exception error condition occurs. </exception>
        /// <param name="faceId"> Face ID de la personne dont on veut récupérer l'identifiant. </param>
        /// <returns> L'identifiant de la personne liée au face ID en paramètre. </returns>
        public static int RecupIdUtilisateur(string faceId)
        {
            _requete = @"SELECT users.id FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceId;";
            try
            {
                OuvrirConnexion();
                _cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                _cmd.Parameters.AddWithValue("@faceId", faceId);
                var scalar = _cmd.ExecuteScalar();
                FermerConnexion();
                return Convert.ToInt32(scalar);
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }

        /// <summary> Méthode qui insert un événement dans la table Events en base de données. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        /// <param name="utilisateur"> Utilisateur ayant déclenché l'événement. </param>
        /// <param name="categorie">   Catégorie de l'événement. </param>
        /// <param name="valeur">      Valeur de l'événement. </param>
        public static void CreerEvent(int utilisateur, int categorie, string valeur)
        {
            _requete = @"INSERT INTO events(user, category, date, value) VALUES (@utilisateur, @categorie, @date, @valeur);";
            //// La date sera un timestamp qui contiendra le nombre de secondes depuis le 01/01/1970.
            int timestamp = Convert.ToInt32(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            try
            {
                OuvrirConnexion();
                _cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                _cmd.Parameters.AddWithValue("@utilisateur", utilisateur);
                _cmd.Parameters.AddWithValue("@categorie", categorie);
                _cmd.Parameters.AddWithValue("@date", timestamp);
                _cmd.Parameters.AddWithValue("@valeur", valeur);
                var nb = _cmd.ExecuteNonQuery();
                FermerConnexion();
            }
            catch (Exception ex)
            {
                RenvoyerErreur(ex);
            }
        }

        /// <summary> L'événement créé en base de données sera de la catégorie Erreur. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        /// <param name="utilisateur"> ID de l'utilisateur ayant déclenché l'erreur. </param>
        /// <param name="valeur">      Valeur de l'erreur. </param>
        public static void EventErreur(int utilisateur, string valeur)
        {
            try
            {
                CreerEvent(utilisateur, 1, valeur);
            }
            catch (Exception ex)
            {
                RenvoyerErreur(ex);
            }
        }

        /// <summary> L'événement créé en base de données sera de la catégorie Information. </summary>
        /// <remarks> Thomas LAURE, 22/11/2017. </remarks>
        /// <param name="utilisateur"> ID de l'utilisateur ayant déclenché la remontée d'information. </param>
        /// <param name="valeur">      Valeur de l'information. </param>
        public static void EventInfo(int utilisateur, string valeur)
        {
            try
            {
                CreerEvent(utilisateur, 2, valeur);
            }
            catch (Exception ex)
            {
                RenvoyerErreur(ex);
            }
        }

        /// <summary> L'événement créé en base de données sera de type Succès. </summary>
        /// <remarks> Thomas LAURE, 29/11/2017. </remarks>
        /// <param name="utilisateur"> ID de l'utilisateur ayant déclenché l'événement de ce type. </param>
        /// <param name="valeur">      Valeur de l'événement. </param>
        public static void EventSucces(int utilisateur, string valeur)
        {
            try
            {
                CreerEvent(utilisateur, 4, valeur);
            }
            catch (Exception ex)
            {
                RenvoyerErreur(ex);
            }
        }

        /// <summary>
        /// Méthode qui permet de récuperer le statut d'une personne.
        /// </summary>
        /// <param name="faceId">The face identifier.</param>
        /// <returns> Le statut du visiteur si celui-ci est enregistré, ou -1 si l'accès est révoqué.</returns>
        /// <exception cref="Exception">La requête n'a pu aboutir.\n" + ex.Message</exception>
        public static int RecupStatus(string faceId)
        {
            _requete = @"SELECT status FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceId;";
            try
            {
                OuvrirConnexion();
                _cmd = new MySqlCommand(_requete, _connexion)
                {
                    CommandType = CommandType.Text
                };
                _cmd.Parameters.AddWithValue("@faceId", faceId);
                var scalar = _cmd.ExecuteScalar();
                FermerConnexion();
                if (scalar is null)
                {
                    return -1;
                }

                return Convert.ToInt32(scalar);
            }
            catch (Exception ex)
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.\n" + ex.Message);
            }
        }
    }
}