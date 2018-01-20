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
        /// The resource manager.
        /// </summary>
        private readonly ResourceManager resourceManager;

        /// <summary>
        /// Prevents a default instance of the <see cref="GestionNovedadesConfig"/> class from being created.
        /// </summary>
        private GestionNovedadesConfig()
        {
            this.resourceManager = new ResourceManager("GestionNovedades.Model.Util.Languages", typeof(GestionNovedadesConfig).Assembly);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(ConfigurationManager.AppSettings["DefaultCultrure"]);
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static GestionNovedadesConfig Instance => instance ?? (instance = new GestionNovedadesConfig());

        /// <summary>
        /// The get locale string.
        /// </summary>
        /// <param name="keyString">
        /// The key string.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetLocaleString(string keyString) 
        {
            return this.resourceManager.GetString(keyString);
        }
    }
}
