using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_codigo_SRI_Info
    {

        public int IdCodigo_SRI { get; set; }
        public string codigoSRI { get; set; }
        public string co_codigoBase { get; set; }
        public string co_descripcion { get; set; }
        public double  co_porRetencion { get; set; }
        public string co_estado { get; set; }
        public DateTime co_f_vigente_desde { get; set; }
        public DateTime co_f_vigente_hasta { get; set; }
        public string IdTipoSRI { get; set; }

        public int MyProperty { get; set; }

        public string IdCtaCble { get; set; }
        
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string descriConcate { get; set; }

        public string MotivoAnulacion { get; set; }
        public string FechaVigente { get; set; }
        public double BaseImponible { get; set; }
        public double MontoRetencion { get; set; }
        public string Tipo { get; set; }


        public string FecValiDesde { get; set; }
        public string FecValiHasta { get; set; }

        public string co_descripcion2 { get; set; }

        //Parametro para editar el campo en la retención
        public bool Modificable { get; set; }

        public cp_codigo_SRI_Info() { }
    }
}
