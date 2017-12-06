//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc DELAUNAY</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjOXFORD_G2WinForm
{
    /// <summary> A program. </summary>
    /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
    public static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Identification1());
            //// Application.Run(new IdentificationMDP());
            //// Application.Run(new IdentificationVisuel());
        }
    }
}
