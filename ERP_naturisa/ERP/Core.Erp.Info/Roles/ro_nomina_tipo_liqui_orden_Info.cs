/*CLASE: ro_nomina_tipo_liqui_orden_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_nomina_tipo_liqui_orden_Info
    {
            public int IdEmpresa { get; set; }
            public int IdNominaTipo { get; set; }
            public int IdNominaTipoLiqui { get; set; }
            public int Orden { get; set; }
            public string IdRubro { get; set; }
            public string Descripcion { get; set; }
            public string Formula { get; set; }
            public Boolean? EsVisible { get; set; }
            public DateTime FechaIngresa { get; set; }
            public string UsuarioIngresa { get; set; }
            public Nullable<DateTime> FechaModifica { get; set; }
            public string UsuarioModifica { get; set; }

            //DATOS DE LA ADICIONALES PARA USAR EN LA VISTA
            public string ru_codRolGen { get; set; }
            public string ru_descripcion { get; set; }
            public string ru_tipo { get; set; }
            public string ru_estado { get; set; }
            public Boolean?  rub_concep { get; set; }
            public int? rub_tipcal { get; set; }
            public string rub_formul { get; set; }
            public decimal? rub_valfij { get; set; }
            public Boolean? rub_guarda_rol { get; set; }


            public ro_nomina_tipo_liqui_orden_Info() { 
            
            }


    }
}
