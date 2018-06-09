using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public class Aca_Pre_Facturacion_Info
   {
       public int IdInstitucion { get; set; }
       public decimal IdPreFacturacion { get; set; }
       public int IdInstitucion_contrato { get; set; }
       public int IdPeriodo { get; set; }
       public System.DateTime fecha_prefacturacion { get; set; }
       public int IdEmpresa_fact { get; set; }
       public int IdSucursal_fact { get; set; }
       public int IdBodega_fact { get; set; }
       public Nullable<decimal> IdCbteVta { get; set; }
       public int IdPtoVta_fact { get; set; }
       public string cod_PuntoVta_fact { get; set; }
       public string Su_CodigoEstablecimiento { get; set; }

       public int IdCaja_fact { get; set; }
       public System.DateTime vt_fecha_fact { get; set; }
       public int vt_plazo_fact { get; set; }
       public System.DateTime vt_fech_venc { get; set; }
       public string observacion_fact { get; set; }
       public string Estado_Pre_factutacion_Cat { get; set; }


       // vista
       public string Descripcion { get; set; }
       public System.DateTime pe_FechaIni { get; set; }
       public System.DateTime pe_FechaFin { get; set; }
       public string pe_estado { get; set; }

       //public string IdAnioLectivo { get; set; }
       public int IdAnioLectivo { get; set; }
       public int IdSede { get; set; }

       public string Ruc { get; set; }
       public string codInstitucion { get; set; }
       public string Nombre { get; set; }
    }
}
