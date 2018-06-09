using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_EtapaProduccion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdProcesoProductivo { get; set; }
        public int IdEtapa { get; set; }
        public string NombreEtapa { get; set; }
        public double PorcentajeEtapa { get; set; }
        public int Posicion { get; set; }

        //para la función de EtapaMaxObra
        public string obra { get; set; }

        public prd_EtapaProduccion_Info() { }
    }
}
