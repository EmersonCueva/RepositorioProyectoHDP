using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{

//    CREATE TABLE detallesLaborales(
//    idDetalleLaboral INT PRIMARY KEY IDENTITY,
//    fechaIngreso VARCHAR(50),
//    fechaRenuncia DATETIME,
//    tipoContrato VARCHAR(100),
//    fechaEmision DATETIME DEFAULT GETDATE(),
//    activoDetalle BIT DEFAULT 1
//);

    public class detallesLaborales
    {
        public int idDetalleLaboral { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaRenuncia { get; set; }
        public string tipoContrato { get; set; }
        public bool activoDetalle { get; set; }
    }
}
