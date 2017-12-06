// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyDAO.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the CompanyDAO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.ResourceAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The company dao.
    /// </summary>
    public class CompanyDao
    {
        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <returns>
        /// The <see cref="Guid"/>.
        /// </returns>
        internal Guid Insert(Company company)
        {
            using (GioContext context = new GioContext())
            {
                context.Companies.Add(company);
                context.SaveChanges();
                return company.CompanyId;
            }

        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        internal void Update(Company company)
        {
            using (GioContext context = new GioContext())
            {
                var companiaBd = context.Companies.FirstOrDefault(p => p.CompanyId == company.CompanyId);
                if (companiaBd != null)
                {
                    companiaBd.CompanyName = company.CompanyName;
                    context.SaveChanges();
                }
            }                            
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        internal void Delete(Company company)
        {
            using (GioContext context = new GioContext())
            {
                context.Companies.Remove(company);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The get company.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        internal List<Company> GetCompany()
        {
            using (GioContext context = new GioContext())
            {
                return context.Companies.ToList();
            }
        }

        /// <summary>
        /// The get company.
        /// </summary>
        /// <param name="companyId">
        /// The company id.
        /// </param>
        /// <returns>
        /// The <see cref="Company"/>.
        /// </returns>
        internal Company GetCompany(Guid companyId)
        {
            using (GioContext context = new GioContext())
            {
                return context.Companies.FirstOrDefault(p => p.CompanyId == companyId);
            }
        }
    }
}
