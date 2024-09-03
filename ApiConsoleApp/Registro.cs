using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsoleApp
{
    public class Registro
    {
        public string showReporteDescarga { get; set; }
        public string perTributario { get; set; }
        public string numTicket { get; set; }
        public string fecCargaImportacion { get; set; }
        public string fecInicioProceso { get; set; }
        public string codProceso { get; set; }
        public string desProceso { get; set; }
        public string codEstadoProceso { get; set; }
        public string desEstadoProceso { get; set; }
        public string nomArchivoImportacion { get; set; }
        public DetalleTicket detalleTicket { get; set; }
        public object archivoReporte { get; set; }


    }
}
