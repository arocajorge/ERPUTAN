using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Info.Compras_Edehsa
{
    public class com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int mv_Secuencia { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public Nullable<decimal> secmax { get; set; }
        public string CodigoBarra { get; set; }

        //Para presentar en la consulta de Pre-asignacion
        public string Obra { get; set; }

        public string mv_tipo_movi { get; set; }
        public double dm_cantidad { get; set; }
        public string dm_observacion { get; set; }
        public string CodObra_preasignada { get; set; }
        public double Det_Kg { get; set; }
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
        public string IdEstadoAprob { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string IdCategoria { get; set; }
        public double longitud { get; set; }
        public double espesor { get; set; }
        public double ancho { get; set; }
        public double alto { get; set; }

        public bool pre_asignar { get; set; }
        //Se usa en la consulta del formulario (MP Disponible para Preasignar), 
        // para seleccionar los materiales a liberar 
        public bool liberar { get; set; }
        public Bitmap Ico { get; set; }


        public com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info() { }
    }
}
