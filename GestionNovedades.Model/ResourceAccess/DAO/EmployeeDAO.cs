// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeDAO.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the EmployeeDAO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GestionNovedades.Model.ResourceAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The employee dao.
    /// </summary>
    public class EmployeeDao
    {
        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        /// <returns>
        /// The <see cref="Guid"/>.
        /// </returns>
        internal Guid Insert(Employee employee)
        {
            using (GioContext context = new GioContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return employee.EmployeeId;
            }
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        internal void Update(Employee employee)
        {
            using (GioContext context = new GioContext())
            {
                var employeeBd = context.Employees.FirstOrDefault(p => p.EmployeeId == employee.EmployeeId);
                if (employeeBd != null)
                {
                    employeeBd.EmployeeIdentification = employee.EmployeeIdentification;
                    employeeBd.EmployeeName = employee.EmployeeName;
                    employeeBd.EmployeeRoleId = employeeBd.EmployeeRoleId;
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        internal void Delete(Employee employee)
        {
            using (GioContext context = new GioContext())
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The get employees.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        internal List<Employee> GetEmployees()
        {
            using (GioContext context = new GioContext())
            {
                return context.Employees.ToList();
            }
        }

        /// <summary>
        /// The get employee.
        /// </summary>
        /// <param name="employedId">
        /// The employed id.
        /// </param>
        /// <returns>
        /// The <see cref="Employee"/>.
        /// </returns>
        internal Employee GetEmployee(Guid employedId)
        {
            using (GioContext context = new GioContext())
            {
                return context.Employees.FirstOrDefault(p => p.EmployeeId == employedId);
            }
        }
    }
}
