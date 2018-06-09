using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.Compras
{
    public class com_ListadoMateriales_Det_Info
    {
        public int IdEmpresa { get; set; }
        
        public decimal IdOrdenTaller { get; set; }
        //por la OT
        public int ot_IdSucursal { get; set; }
        
        public string CodObra { get; set; }
        public decimal IdListadoMateriales { get; set; }
        public int IdDetalle { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo{ get; set; }
        public string pr_descripcion { get; set; }
        public double Unidades { get; set; }
        public double Det_Kg { get; set; }
       
        public string lm_IdEstadoAprobado { get; set; }


        // campos para la Generacion de Orden de Compras
        public int IdDetTrans { get; set; }
        public decimal? IdProveedor { get; set; }
        public string Motivo { get; set; }
        public string mr_codigo { get; set; }
        public string mr_descripcion { get; set; }
        public string ea_codigo { get; set; }
        public string ea_descripcion { get; set; }
        public string ot_codigo { get; set; }
        public string ob_descripcion { get; set; }
        public string prov_descripcion { get; set; }
        public string obra { get; set; }
        public string producto { get; set; }

        //longitud para el calculo de materiales OS.
        //public double pr_largo { get; set; }
        public Nullable<double> pr_largo { get; set; }
        public Nullable<double> largo_total { get; set; }
        public Nullable<double> largo_restante { get; set; }
        public Nullable<double> largo_pieza_entera { get; set; }
        public Nullable<int> cantidad_pieza_entera { get; set; }
        public Nullable<double> largo_pieza_complementaria { get; set; }
        public Nullable<double> cantidad_pieza_complementaria { get; set; }
        public Nullable<double> cantidad_total_pieza_complementaria { get; set; }
        public Nullable<double> largo_despunte1 { get; set; }
        public Nullable<double> cantidad_despunte1 { get; set; }
        public Nullable<bool> es_despunte_usable1 { get; set; }
        public Nullable<double> largo_despunte2 { get; set; }
        public Nullable<double> cantidad_despunte2 { get; set; }
        public Nullable<bool> es_despunte_usable2 { get; set; }


        public DateTime FechaRequer { get; set; }
        public decimal IdTransaccion { get; set; }
        public int sec { get; set; }
        public Boolean chk { get; set; }
        public double precio { get; set; }
        public string go_IdEstadoAprob { get; set; }
        public string solicitante { get; set; }

        
        public int? oc_idempresa { get; set; }
        public decimal? IdOrdencompra { get; set; }
        public int oc_iddetalle { get; set; }
        public int oc_idsucursal { get; set; }


        public Bitmap Ico { get; set; }
        

        public  com_ListadoMateriales_Det_Info(){}
    }
}
