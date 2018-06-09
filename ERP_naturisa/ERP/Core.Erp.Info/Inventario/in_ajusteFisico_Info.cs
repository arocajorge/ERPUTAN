using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Info.Inventario
{
    public class in_ajusteFisico_Info 

    { 
        

        public int IdEmpresa { get; set; }
        public decimal IdAjusteFisico { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }

        public int IdMovi_inven_tipo_Ing { get; set; }
        public decimal ? IdNumMovi_Ing { get; set; }
        public int  IdMovi_inven_tipo_Egr { get; set; }
        public decimal ? IdNumMovi_Egr { get; set; }

        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public string bo_descripcion { get; set; }
        public string su_Descripcion { get; set; }
        public string DescripcionIngreso { get; set; }
        public string DescripcionEngreso { get; set; }
        public string IdUsuarioAnulacion { get; set; }
        public string  motivo_anula { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuario { get; set; }
        public string Nombre_Estado { get; set; }
        public List<in_AjusteFisico_Detalle_Info> list_det_AjusteFisico { get; set; }

        public in_ajusteFisico_Info() 
        {
            list_det_AjusteFisico = new List<in_AjusteFisico_Detalle_Info>();
        }

        public string IdEstadoAprobacion { get; set; }
    }
}
