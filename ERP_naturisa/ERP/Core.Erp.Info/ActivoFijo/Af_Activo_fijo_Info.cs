using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Activo_fijo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string CodActivoFijo { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string Af_Nombre { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public int IdSucursal { get; set; }
        public string IdCatalogo_Marca { get; set; }
        public string IdCatalogo_Modelo { get; set; }
        public string Af_NumSerie { get; set; }
        public string IdCatalogo_Color { get; set; }
        public string IdTipoCatalogo_Ubicacion { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public System.DateTime Af_fecha_ini_depre { get; set; }
        public System.DateTime Af_fecha_fin_depre { get; set; }
        public double Af_Costo_historico { get; set; }
        public double Af_costo_compra { get; set; }
        public Nullable<double> Af_Depreciacion_acum { get; set; }
        public int Af_Vida_Util { get; set; }
        public int Af_Meses_depreciar { get; set; }
        public double Af_porcentaje_deprec { get; set; }
        public string Af_observacion { get; set; }
        public string Af_NumPlaca { get; set; }
        public Nullable<int> Af_Anio_fabrica { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
        public byte[] Af_foto { get; set; }
        public string Af_DescripcionCorta { get; set; }
        public string IdPeriodoDeprec { get; set; }
        public string Af_Codigo_Parte { get; set; }
        public string Af_Codigo_Barra { get; set; }
        public string Af_DescripcionTecnica { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public Nullable<System.DateTime> Af_FechaPoliza { get; set; }
        public Nullable<double> Af_ValorPoliza { get; set; }
        public Nullable<double> Af_ValorVenta { get; set; }
        public string Af_NumPoliza { get; set; }
        public Nullable<System.DateTime> Af_Fecha_Venta { get; set; }
        public Nullable<System.DateTime> Af_Fecha_Vencimiento { get; set; }
        public Nullable<System.DateTime> Af_Fecha_Retiro { get; set; }
        public string Estado_Proceso { get; set; }
        public Nullable<double> Af_ValorSalvamento { get; set; }
        public Nullable<double> Af_ValorResidual { get; set; }
        public Nullable<int> IdEmpresa_oc { get; set; }
        public Nullable<int> IdSucursal_oc { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<int> Secuencia_oc { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string numDocumento { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public Nullable<double> Costo_uni { get; set; }
        public Nullable<double> SubTotal { get; set; }
        public Nullable<double> valor_Iva { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Af_NumSerie_Motor { get; set; }
        public string Af_NumSerie_Chasis { get; set; }
        public Nullable<int> IdCategoriaAF { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<decimal> IdEncargado { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public Nullable<int> IdGrupoActivoFijo { get; set; }
        public Nullable<System.DateTime> Af_fecha_vigencia_desde { get; set; }
        public Nullable<double> Af_valor_asegurado { get; set; }
        public Nullable<double> Af_valor_asegurado_extra { get; set; }
        public Nullable<double> Af_valor_prima { get; set; }
        public string Af_Capacidad { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public List<Af_Activo_fijo_x_Af_Activo_fijo_Info> lista_Activo_relacionados { get; set; }
        public Boolean Seleccionado { get; set; }
        //campos vista
        public string nom_Categoria { get; set; }
        public string nom_encargado { get; set; }
        public string nom_Color { get; set; }
        public string nom_UnidadFact { get; set; }
        public string nom_Cliente { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_Centro_costo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Nullable<Boolean> Es_carroceria { get; set; }
        public Nullable<int> Num_empleado_relacionado { get; set; }

        public List< Af_Activo_fijo_CtasCbles_Info> ListAf_Activo_fijo_CtasCbles { get; set; }
        
        public Af_Activo_fijo_Info() 
        {
            ListAf_Activo_fijo_CtasCbles = new List<Af_Activo_fijo_CtasCbles_Info>();
        }


    }
}
