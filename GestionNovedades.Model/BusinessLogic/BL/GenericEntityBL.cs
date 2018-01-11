using GestionNovedades.Model.BusinessLogic.BL.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.BusinessLogic.BL
{
    internal class GenericEntityBL<T>
    {
        public void Insert (T entity)
        {
            var validationResult = EntityValidatorFactory.GetValidator(entity).Validate(entity);            
            
            // Valido
            //Grabo en BD (Ver pagina)
            //Creo response y retorno
        }


    }
}
