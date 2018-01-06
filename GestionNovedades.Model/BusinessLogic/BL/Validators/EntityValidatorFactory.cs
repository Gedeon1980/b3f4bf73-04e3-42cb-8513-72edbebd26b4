using GestionNovedades.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class EntityValidatorFactory
    {
        public static EntityValidator<T> GetValidator<T> (T entity)
        {
            if (entity.GetType() == typeof(Role))
                return new RoleValidator();
            return null;
        }
    }
}
