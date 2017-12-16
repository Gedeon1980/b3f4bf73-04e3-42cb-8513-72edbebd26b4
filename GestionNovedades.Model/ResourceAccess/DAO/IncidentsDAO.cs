// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IncidentsDAO.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the IncidentsDAO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.ResourceAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The incidents dao.
    /// </summary>
    public class IncidentsDao
    {
        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="incident">
        /// The incident.
        /// </param>
        /// <returns>
        /// The <see cref="Guid"/>.
        /// </returns>
        internal Guid Insert(Incidents incident)
        {
            using (GioContext context = new GioContext())
            {
                context.Incidents.Add(incident);
                context.SaveChanges();
                return incident.IncidentId;
            }
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="incident">
        /// The incident.
        /// </param>
        internal void Update(Incidents incident)
        {
            using (GioContext context = new GioContext())
            {
                var incidentBd = context.Incidents.FirstOrDefault(p => p.IncidentId == incident.IncidentId);
                {
                    if (incidentBd != null)
                    {
                        incidentBd.IncidentMoved = incident.IncidentMoved;
                        incidentBd.IncidentSolved = incident.IncidentSolved;
                        incidentBd.IncidentStart = incident.IncidentStart;
                        context.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="incident">
        /// The incident.
        /// </param>
        internal void Delete(Incidents incident)
        {
            using (GioContext context = new GioContext())
            {
                context.Incidents.Remove(incident);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The get incidents.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        internal List<Incidents> GetIncidents()
        {
            using (GioContext context = new GioContext())
            {
                return context.Incidents.ToList();
            }
        }

        /// <summary>
        /// The get incidents.
        /// </summary>
        /// <param name="incidentId">
        /// The incident id.
        /// </param>
        /// <returns>
        /// The <see cref="Incidents"/>.
        /// </returns>
        internal Incidents GetIncidents(Guid incidentId)
        {
            using (GioContext context = new GioContext())
            {
                return context.Incidents.FirstOrDefault(p => p.IncidentId == incidentId);
            }
        }
    }
}
