namespace GestionNovedades.Test
{
    using System;

    using GestionNovedades.Model.Entidades;
    using GestionNovedades.Model.Services.Facades;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The entity manager test.
    /// </summary>
    [TestClass]
    public class EntityManagerTest
    {
        /// <summary>
        /// The success insert role.
        /// </summary>
        [TestMethod]
        public void SuccessInsertRole()
        {
            try
            {
                Role role = new Role() { RoleDescription = "Administratror" };
                var response = new EntityManagerFacade().InsertRole(role);
                Assert.IsTrue(response.IsValid);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// The error insert role.
        /// </summary>
        [TestMethod]
        public void ErrorInsertRole()
        {
            try
            {
                Role role = new Role() { RoleDescription = string.Empty };
                var response = new EntityManagerFacade().InsertRole(role);
                Assert.IsFalse(response.IsValid);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
