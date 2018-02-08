// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.POC
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using System.Threading;

    using GestionNovedades.POC.GestionNovedadesClient;
    using GestionNovedades.POC.Languages;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("es-CO");
            Console.WriteLine($@"Cambio de lenguaje {Lang.LanguageTest}");
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            Console.WriteLine($@"Cambio de lenguaje {Lang.LanguageTest}");


            //// Test Soap 
            var client = new EntityManagerFacadeClient();
            var role = new Role()
            {
                RoleDescription = String.Empty,
                RoleId = Guid.NewGuid()
            };
            var response = client.InsertRole(role);

            Console.ReadKey();
        }
    }
}
