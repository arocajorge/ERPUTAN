using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_Parametro_Data
    {
        string mensaje = "";
        public prod_Parametro_Info ConsultaGeneral(int IdEmpresa )
        {
            try
            {
                EntitiesProduccion oEnti = new EntitiesProduccion();
                var item = oEnti.prod_Parametro.First(var => var.IdEmpresa == IdEmpresa);
                prod_Parametro_Info Obj = new prod_Parametro_Info();
                Obj.IdEmpresa = item.IdEmpresa;
                Obj.IdSucursal_IngxProduc = item.IdSucursal_IngxProduc;
                Obj.IdBodega_IngxProduc = item.IdBodega_IngxProduc;
                Obj.IdMovi_inven_tipo_x_IngxProduc_ProdTermi = item.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
                Obj.IdMovi_inven_tipo_x_EgrxProduc_MatPri = item.IdMovi_inven_tipo_x_EgrxProduc_MatPri;
                Obj.IdCargo_JefeTurno = item.IdCargo_JefeTurno;
                Obj.IdBodega_EgrxMateriaPrima = item.IdBodega_EgrxMateriaPrima;
                Obj.IdSucursal_EgrxMateriaPrima=item.IdSucursal_EgrxMateriaPrima;
                Obj.IdMovi_inven_tipo_x_IngCompraChatarra = item.IdMovi_inven_tipo_x_IngCompraChatarra;
                Obj.IdMovi_inven_tipo_x_IngXProdAceriaProdTerm = item.IdMovi_inven_tipo_x_IngXProdAceriaProdTerm;
                Obj.IdProducto_ChatarraIngreso = item.IdProducto_ChatarraIngreso;
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
