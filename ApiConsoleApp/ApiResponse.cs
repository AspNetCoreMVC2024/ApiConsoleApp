using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsoleApp
{
    public class ApiResponse
    {

        public Paginacion paginacion { get; set; }
        public List<Registro> registros { get; set; }

    }
}
