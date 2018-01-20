// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Response.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the Response type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Util
{
    using System.Collections.Generic;

    /// <summary>
    /// The response.
    /// </summary>
    /// <typeparam name="T">
    /// The entity type
    /// </typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Gets or sets the operation result.
        /// </summary>
        public T OperationResult { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        public IEnumerable<string> Error { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is valid.
        /// </summary>
        public bool IsValid { get; set; }
    }
}
