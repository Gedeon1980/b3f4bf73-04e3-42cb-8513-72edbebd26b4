using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.Util
{
    public class Response<T>
    {
        public T OpertionResul { get; set; }
        public List<string> Error { get; set; }
        public bool IsValid { get; set; }

    }
}
