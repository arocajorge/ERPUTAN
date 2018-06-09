using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
//v22102013
namespace Core.Erp.Info.Inventario
{
    public class in_movi_inve_Info
    {

        public in_movi_inve_Info()
        {
            listmovi_inve_detalle_Info = new List<in_movi_inve_detalle_Info>();
        
        }

        public int IdEmpresa { get; set; }
        public  int IdSucursal { get; set; }
        public  int IdBodega{ get; set; }
        public  int IdMovi_inven_tipo{ get; set; }
        public  decimal IdNumMovi { get; set; }
        public  string cm_tipo { get; set; }
        public  string cm_observacion { get; set; }
        public  System.DateTime cm_fecha { get; set; }
        public  Nullable<int> IdCbteCble_Tipo { get; set; }
        public  Nullable<decimal> IdCbteCble { get; set; }
        public  string IdCtaCble { get; set; }
        public  int cm_anio { get; set; }
        public  int cm_mes { get; set; }
        public  string IdUsuario { get; set; }
        public  Nullable<System.DateTime> Fecha_Transac { get; set; }
        public  string IdUsuarioUltModi { get; set; }
        public  Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public  string IdusuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public  string nom_pc { get; set; }
        public  string ip { get; set; }
        public  string Estado {get;set;}
        public string NomSucursal { get; set; }
        public string NomBodega { get; set; }
        public string NomTipoMovi { get; set; }
        public string CodTipoMovi { get; set; }
        public string NemoTipoMovi { get; set; }
        public string CodMoviInven { get; set; }
        public byte[] logo { get; set; }
        public string CodNomTipoMovi { get; set; }
        public Nullable<decimal> IdProvedor { get; set; }
        public string prov_nombre { get; set; }
        public string NumDocumentoRelacionado { get; set; }
        public string NumFactura { get; set; }
        public Bitmap IconImprimir { get; set; }
        public string IdEstadoDespacho_cat { get; set; }
        public int ? IdEmpresa_x_Anu { get; set; }
        public int ? IdSucursal_x_Anu { get; set; }
        public int ? IdBodega_x_Anu { get; set; }
        public int ? IdMovi_inven_tipo_x_Anu { get; set; }
        public decimal ? IdNumMovi_x_Anu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_EstadoDespacho { get; set; }
        public Nullable<int> IdMotivo_inv { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public decimal num_Trans { get; set; }
        public List<in_movi_inve_detalle_Info> listmovi_inve_detalle_Info { get; set; }
        public Nullable<System.DateTime> Fecha_despacho { get; set; }

        #region "Properties para ingresos a bodega por OC"

        public decimal IdOrdenCompra { get; set; }
        public string IdCentroCosto { get; set; }
        public string ReferenciaOC { get; set; }
        public double oc_total { get; set; }
        public double? oc_PesoTotal { get; set; }
        public string oc_observacion { get; set; }
        public string oc_NumDocumento { get; set; }
        public DateTime? co_fecha_aprobacion { get; set; }
        public string EstadoRecepcion { get; set; }

        #endregion

        #region Properties para vista vwin_movi_inve_x_Ing_Ordencompra_local

        public string nom_sucursal { get; set; }
        public string cod_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public string cod_bodega { get; set; }
        public string tipo_movi_inven { get; set; }
        public string nom_proveedor { get; set; }     
        public DateTime oc_fecha { get; set; }
        #endregion

        #region Properties para llevar los id del ing/egr de Inven para poder enviarlo a conta
        public int IdEmpresa_Ing_Egr { get; set; }
        public int IdSucursal_Ing_Egr { get; set; }
        public Nullable<int> IdBodega_Ing_Egr { get; set; }
        public int IdMovi_inven_tipo_Ing_Egr { get; set; }
        public decimal IdNumMovi_Ing_Egr { get; set; }
        #endregion

        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        

        public bool Checked { get; set; }
        # region
        public string Idobra { get; set; }
        public int IdordenTaller { get; set; }
#endregion;

        public System.Drawing.Bitmap Icono { get; set; }
    }
}
