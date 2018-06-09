using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class tbPRO_CUS_CID_Rpt005_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string empresa { get; set; }
        public string cliente { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string IdUnidadMedida { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaIniTras { get; set; }
        public DateTime FechaFinTras { get; set; }
        public string PuntoPartida { get; set; }
        public string PuntoLLegada { get; set; }
        public string Placa { get; set; }
        public string Chofer { get; set; }
        public string TipoTransporte { get; set; }
        public string producto { get; set; }
        public string CodigoBarraMaestro { get; set; }
        public double? cantidad { get; set; }
        public double? pesoxcant { get; set; }
        public double? pesototal { get; set; }
        public string fechainicio { get; set; }
        public string fechafin { get; set; }
        public string fechaemision { get; set; }
        public string pesoxprod { get; set; }
        public decimal peso { get; set; }
        public decimal precio { get; set; }
        public string ot { get; set; }
        public string det_observacion { get; set; }
        public string obra { get; set; }
        public string NumDespacho { get; set; }
        public string NumFactura { get; set; }
        public string NumGuia { get; set; }
        public decimal  IdDespacho { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public tbPRO_CUS_CID_Rpt005_Info()
        {

        }
    }
}
