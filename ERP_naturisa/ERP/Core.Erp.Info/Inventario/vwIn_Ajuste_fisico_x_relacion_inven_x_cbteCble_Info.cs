using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Core.Erp.Info.Inventario
{
    public class vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }	
        public string cm_observacion { get; set; }
        public DateTime cm_fecha { get; set; }
        public int ? IdTipoCbte { get; set; }
        public decimal ? IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public DateTime ? cb_Fecha { get; set; }	
        public double  ? cb_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public decimal IdAjusteFisico { get; set; }
        public string Su_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public string tc_TipoCbte { get; set; }

        public Bitmap Icono_btn_buscar_diario { get; set; }
        public Bitmap Icono_btn_buscar_MoviInven { get; set; }
        

        public vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info()
        {


        }

    }
}
