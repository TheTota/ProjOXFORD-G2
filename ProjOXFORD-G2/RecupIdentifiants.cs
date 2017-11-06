////-----------------------------------------------------------------------
//// <copyright file="RecupIdentifiants.cs" company="SIO">
////     Copyright (c) SIO. All rights reserved.
//// </copyright>
//// <author>Thomas LAURE</author>
////-----------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using MySql.Data.MySqlClient;  // Librairie de connexion à MySQL ajoutée en référence.

//namespace ProjOXFORDG2
//{
//    /// <summary>
//    /// Classe qui va permettre la récupération des identifiants liés à la photo prise.
//    /// </summary>
//    public class RecupIdentifiants
//    {
//        /// <summary>
//        /// Membre privé contenant les informations de connexion à la base de données.
//        /// Le @ sert à prendre la chaîne de caractères telle quelle.
//        /// </summary>
//        private const string CNX = @"Server=127.0.0.1; Port=3306; Database=oxford; Uid=root; Pwd=;";

//        /// <summary>
//        /// Membre privé qui va contenir la requête.
//        /// </summary>
//        private string _requete;

//        /// <summary>
//        /// Déclaration d'un objet de la classe MysqlConnection.
//        /// Va être utilisé pour gérer la connexion à la base de données MySQL.
//        /// </summary>
//        private static MySqlConnection _connexion;

//        /// <summary>
//        /// Méthode de connexion à la base de données.
//        /// </summary>
//        public static void OuvrirConnexion()
//        {
//            try
//            {
//                _connexion = new MySqlConnection(CNX);
//                if (_connexion.State == ConnectionState.Closed)
//                {
//                    _connexion.Open();
//                }
//            }
//            catch
//            {
//                throw new Exception("Erreur de connexion à la base de données MySQL.");
//            }
//        }

//        /// <summary>
//        /// Méthode publique de fermeture de la connexion à la base de données MySQL.
//        /// </summary>
//        public static void FermerConnexion()
//        {
//            if (_connexion.State != ConnectionState.Closed)
//            {
//                _connexion.Dispose();
//                _connexion.Close();
//            }
//        }

//        public void Comparer()
//        {

//        }

<<<<<<< Updated upstream
                // Définition de la requête SQL
                MySqlCommand cmd = new MySqlCommand(requete, _connexion);
                cmd.CommandType = CommandType.Text;

                // Execution de la requête SQL et récuparation du datareader
                var resultReader = cmd.ExecuteReader();

                // Récupération des valeurs et création d'une liste de FaceId (sous forme de chaine)
                List<string> lesFaceId = new List<string>();
                if (resultReader.HasRows)
                {
                    while (resultReader.Read())
                    {
                        lesFaceId.Add(resultReader.GetString(0));
                    }
                }

                // Fermeture de la connexion
                FermerConnexion();

                // On retourne le résultat de la requête
                return lesFaceId;
            }
            catch
            {
                FermerConnexion();
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
                FermerConnexion();
            }
            catch
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le code de l'utilisateur dans la base de données.
        /// Ce mot de passe sera destiné à être comparé avec celui saisi dans le formulaire afin d'identifier l'utilisateur.
        /// </summary>
        /// <returns>Le code de l'utilisateur.</returns>
        /// <exception cref="Exception">La requête n'a pu aboutir.</exception>
        public int RecupPwd(int id)
        {
            this._requete = @"SELECT code FROM users WHERE id = @id;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(this._requete, _connexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                var scalar = cmd.ExecuteScalar();
                Console.WriteLine("Requête effectuée.");
                FermerConnexion();
                return Convert.ToInt32(scalar);
            }
            catch
            {
                FermerConnexion();
                throw new Exception("La requête n'a pu aboutir.");
            }
        }
    }
}
=======
//        public void RecupInfosUser()
//        {
//            this._requete = @"SELECT photo, nom, prenom, type, birth, sexe, status, email FROM users INNER JOIN photos ON users.photo = photos.id WHERE faceid = @faceid;";
//            try
//            {
//                MySqlCommand cmd = new MySqlCommand(this._requete, _connexion);
//                cmd.CommandType = CommandType.Text;
//                Console.WriteLine("Requête effectuée.");
//            }
//            catch
//            {
//                throw new Exception("La requête n'a pu aboutir.");
//            }
//        }
//    }
//}
>>>>>>> Stashed changes
