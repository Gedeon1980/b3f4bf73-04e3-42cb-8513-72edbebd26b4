// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GiUnitOfWork.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   The unit of work.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.ResourceAccess.DAL
{
    using System;
    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The unit of work.
    /// </summary>
    internal class GiUnitOfWork : IDisposable
    {
        /// <summary>
        /// The context.
        /// </summary>
        private readonly GioContext context = new GioContext();

        /// <summary>
        /// The disposed.
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// The company repository.
        /// </summary>
        private GenericRepository<Company> companyRepository;

        /// <summary>
        /// The employee repository.
        /// </summary>
        private GenericRepository<Employee> employeeRepository;

        /// <summary>
        /// The incident repository.
        /// </summary>
        private GenericRepository<Incidents> incidentRepository;

        /// <summary>
        /// The role repository.
        /// </summary>
        private GenericRepository<Role> roleRepository;

        /// <summary>
        /// The settled repository.
        /// </summary>
        private GenericRepository<Settled> settledRepository;

        /// <summary>
        /// The team repository.
        /// </summary>
        private GenericRepository<Team> teamRepository;

        /// <summary>
        /// Gets the company repository.
        /// </summary>
        public GenericRepository<Company> CompanyRepository => this.companyRepository
                                                    ?? (this.companyRepository = new GenericRepository<Company>(this.context));

        /// <summary>
        /// Gets the employee repository.
        /// </summary>
        public GenericRepository<Employee> EmployeeRepository => this.employeeRepository
                                                                 ?? (this.employeeRepository = new GenericRepository<Employee>(this.context));

        /// <summary>
        /// Gets the incident repository.
        /// </summary>
        public GenericRepository<Incidents> IncidentRepository => this.incidentRepository
                                                                ?? (this.incidentRepository = new GenericRepository<Incidents>(this.context));

        /// <summary>
        /// Gets the role repository.
        /// </summary>
        public GenericRepository<Role> RoleRepository => this.roleRepository
            ?? (this.roleRepository = new GenericRepository<Role>(this.context));

        /// <summary>
        /// Gets the settled repository.
        /// </summary>
        public GenericRepository<Settled> SettledRepository => this.settledRepository
            ?? (this.settledRepository = new GenericRepository<Settled>(this.context));

        /// <summary>
        /// Gets the team repository.
        /// </summary>
        public GenericRepository<Team> TeamRepository => this.teamRepository
            ?? (this.teamRepository = new GenericRepository<Team>(this.context));

        /// <summary>
        /// The get repository.
        /// </summary>
        /// <typeparam name="T">
        /// The entity type
        /// </typeparam>
        /// <returns>
        /// The <see cref="GenericRepository{T}"/>.
        /// </returns>
        public GenericRepository<T> GetRepository<T>() where T : class
        {
            if (typeof(T) == typeof(Role))
            {
                return this.RoleRepository as GenericRepository<T>;
            }

            if (typeof(T) == typeof(Settled))
            {
                return this.SettledRepository as GenericRepository<T>;
            }

            if (typeof(T) == typeof(Team))
            {
                return this.TeamRepository as GenericRepository<T>;
            }

            ////TODO: COMPLETAR REPOSITORIOS FALTANTES

            return null;
        }

        /// <summary>
        /// The save.
        /// </summary>
        public void Save()
        {
            this.context.SaveChanges();
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                this.context.Dispose();
            }

            this.disposed = true;
        }
    }
}
