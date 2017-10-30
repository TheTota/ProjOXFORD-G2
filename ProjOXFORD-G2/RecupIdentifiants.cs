//-----------------------------------------------------------------------
// <copyright file="RecupIdentifiants.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Thomas LAURE</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        /// Membre privé qui va contenir la requête.
        /// </summary>
        private string _requete;

        /// <summary>
        /// Déclaration d'un objet de la classe MysqlConnection.
        /// Va être utilisé pour gérer la connexion à la base de données MySQL.
        /// </summary>
        private static MySqlConnection _connexion;

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
        /// Méthode de récupération de la photo.
        /// Destinée à l'affichage.
        /// </summary>
        public void RecupPhoto()
        {
            this._requete = @"SELECT value FROM photos;";
            ExecuterCommande(this._requete);
        }

        /// <summary>
        /// Méthode de récupération des informations de l'utilisateur.
        /// </summary>
        public void RecupInfosUser()
        {
            this._requete = @"SELECT photo, nom, prenom, type, birth, sexe, status, email FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceid;";
            ExecuterCommande(this._requete);
        }

        /// <summary>
        /// Méthode statique permettant d'exécuter la commande SQL 
        /// enregistrée dans la variable requete.
        /// Permet d'éviter la duplication de code.
        /// </summary>
        /// <param name="requete">Requête enregistrée.</param>
        /// <exception cref="Exception">La requête n'a pu aboutir.</exception>
        public static void ExecuterCommande(string requete)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(requete, _connexion);
                cmd.CommandType = CommandType.Text;
                Console.WriteLine("Requête effectuée.");
            }
            catch
            {
                throw new Exception("La requête n'a pu aboutir.");
            }
        }
    }
}
