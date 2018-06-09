using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;


namespace Core.Erp.Info.Inventario
{
    public class in_rpt_TransferenciaInventario_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int IdSucursalDest { get; set; }
        public int IdBodegaDest { get; set; }
        public string tr_Observacion { get; set; }
        public DateTime tr_fecha { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public int IdMovi_inven_tipo_SucuOrig { get; set; }
        public decimal IdNumMovi_SucOrig { get; set; }
        public int IdMovi_inven_tipo_SucuDest { get; set; }
        public decimal IdNumMovi_SucDest { get; set; }
        public DateTime? tr_fechaAnulacion { get; set; }
        public string tr_userAnulo { get; set; }


        public string Bodega_Origen { get; set; }
        public string Bodega_Destino { get; set; }
        public string Sucursal_Origen { get; set; }
        public string Sucursal_Destino { get; set; }

        public string MotivoAnu { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public tb_Empresa_Info infoempresa { get; set; }
        public int stockanterior { get; set; }
        public List<in_producto_x_tb_bodega_Info> listadetalles { get; set; }

        public in_rpt_TransferenciaInventario_Info(){}

    }
}
