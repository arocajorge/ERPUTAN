using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Inventario
{
   public class in_Guia_x_traspaso_bodega_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public string NumGuia { get; set; }
        public int? IdSucursal_Partida { get; set; }
        public int? IdSucursal_Llegada { get; set; }
        public string Direc_sucu_Partida { get; set; }
        public string Direc_sucu_Llegada { get; set; }
        public decimal? IdTransportista { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fecha_Traslado { get; set; }
        public DateTime Fecha_llegada { get; set; }
        public string  IdMotivo_Traslado { get; set; }
        public string Estado { get; set; }

        public Nullable<System.TimeSpan> Hora_Traslado { get; set; }
        public Nullable<System.TimeSpan> Hora_Llegada { get; set; }


        //campos auditoria
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }

        // campos de la vista vwin_Guia_x_traspaso_bodega
        public string Su_Descripcion { get; set; }
        public string Su_Descripcion_Llegada { get; set; }


        public List<in_Guia_x_traspaso_bodega_det_Info> list_detalle_Guia { get; set; }
        public List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> list_detalle_Guia_Sin_OC { get; set; }
        public List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Lista_Detalle_Transferencia { get; set; }

        public string CodDocumentoTipo { get; set; }
        public string IdEstablecimiento { get; set; }
        public string IdPuntoEmision { get; set; }
        public string NumDocumento_Guia { get; set; }
        public bool Es_electronica { get; set; }


        public tb_sis_Documento_Tipo_Talonario_Info Info_Talonario { get; set; }


       public string ced_transportista { get; set; }
       public string nom_transportista { get; set; }
       public string nom_Motivo_Traslado { get; set; }
       public string cod_estable_llegada { get; set; }
       public string cod_estable_partida { get; set; }
       public string razon_social_empresa { get; set; }
       public string nom_comercial_empresa { get; set; }
       public string contrib_especial_empresa { get; set; }
       public string obligado_conta_empresa { get; set; }
       public string ruc_empresa { get; set; }
       public string nom_empresa { get; set; }
       public string direc_empresa { get; set; }
       public string Placa { get; set; }

        

       public in_Guia_x_traspaso_bodega_Info()
       {

           list_detalle_Guia = new List<in_Guia_x_traspaso_bodega_det_Info>();
           list_detalle_Guia_Sin_OC = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();
           Lista_Detalle_Transferencia = new List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info>();
           Info_Talonario = new tb_sis_Documento_Tipo_Talonario_Info();
       }
    }
}
