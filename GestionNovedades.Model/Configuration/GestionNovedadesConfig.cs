// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GestionNovedadesConfig.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the GestionNovedadesConfig type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Configuration
{
    using System.Configuration;
    using System.Globalization;
    using System.Resources;
    using System.Threading;

    using GestionNovedades.Model.Util.Languages;

    /// <summary>
    /// The gestion novedades config.
    /// </summary>
    internal class GestionNovedadesConfig
    {
        /// <summary>
        /// The instance.
        /// </summary>
        private static GestionNovedadesConfig instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="GestionNovedadesConfig"/> class from being created.
        /// </summary>
        private GestionNovedadesConfig()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(ConfigurationManager.AppSettings["DefaultCultrure"]);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ConfigurationManager.AppSettings["DefaultCultrure"]);
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static GestionNovedadesConfig Instance => instance ?? (instance = new GestionNovedadesConfig());

        /// <summary>
        /// The get string.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetLocaleString(string key)
        {
            return Lang.ResourceManager.GetString(key);
        }
    }
}
