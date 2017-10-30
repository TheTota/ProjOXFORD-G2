//-----------------------------------------------------------------------
// <copyright file="RecupIdentifiants.cs" company="SIO">
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
    public class RecupIdentifiants
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
        private string _requete;

        /// <summary>
        /// Méthode de connexion à la base de données.
        /// </summary>
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
            catch
            {
                throw new Exception("Erreur de connexion à la base de données MySQL.");
            }
        }

        /// <summary>
        /// Méthode publique de fermeture de la connexion à la base de données MySQL.
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
        /// Méthode statique permettant d'exécuter la requete SQL 
        /// enregistrée dans la variable requete.
        /// Permet d'éviter la duplication de code.
        /// </summary>
        /// <param name="requete">Requête enregistrée.</param>
        /// <exception cref="Exception">La requête n'a pu aboutir.</exception>
        //public static void ExecuterRequete(string requete)
        //{
        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand(requete, _connexion);
        //        cmd.CommandType = CommandType.Text;
        //        Console.WriteLine("Requête effectuée.");
        //    }
        //    catch
        //    {
        //        throw new Exception("La requête n'a pu aboutir.");
        //    }
        //}

        /// <summary>
        /// Méthode de récupération de la photo.
        /// Destinée à l'affichage.
        /// </summary>
        public void RecupPhoto()
        {
            this._requete = @"SELECT value FROM photos;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(this._requete, _connexion);
                cmd.CommandType = CommandType.Text;
                var scalar = cmd.ExecuteScalar();  // Permet de stocker le résultat de la requête quand elle renvoie une valeur unitaire.
                Console.WriteLine("Requête effectuée.");
                // ExecuterRequete(this._requete);
            }
            catch
            {
                throw new Exception("La requête n'a pu aboutir.");
            }
        }

        /// <summary>
        /// Méthode de récupération des informations de l'utilisateur.
        /// </summary>
        public void RecupInfosUser()
        {
            this._requete = @"SELECT photo, nom, prenom, type, birth, sexe, status, email FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceid;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(this._requete, _connexion);
                cmd.Parameters.AddWithValue("@faceid", "");   // La valeur du paramètre sera la valeur retournée par la méthode qui ira chercher la valeur du FaceID dans le fichier JSON.
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();  // Permet de stocker le résultat de la requête quand elle retourne plusieurs valeurs.
                Console.WriteLine("Requête effectuée.");
                // ExecuterRequete(this._requete);
            }
            catch
            {
                throw new Exception("La requête n'a pu aboutir.");
            }
        }
    }
}
