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

// Librairie de connexion à MySQL ajoutée en référence.
using MySql.Data.MySqlClient;

namespace ProjOXFORDG2
{
    /// <summary>
    /// Classe qui va permettre la récupération des identifiants liés à la photo prise.
    /// </summary>
    public class RecupIdentifiants
    {
        /// <summary>
        /// Membre privé contenant les informations de connexion à la base de données.
        /// </summary>
        private const string CNX = "database=testOxford; server=localhost; user id=root; pwd=";

        /// <summary>
        /// Méthode de connexion à la base de données.
        /// </summary>
        public static void MysqlConnect()
        {
            MySqlConnection connexion = new MySqlConnection(CNX);

            try
            {
                connexion.Open();
            }
            catch (MySqlException)
            {
                throw;
            }
        }
    }
}
