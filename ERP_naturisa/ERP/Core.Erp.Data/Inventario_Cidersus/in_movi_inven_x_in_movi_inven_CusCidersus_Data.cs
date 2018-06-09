using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario_Cidersus
{
    public class in_movi_inven_x_in_movi_inven_CusCidersus_Data
    {
        string mensaje = "";

        public Boolean GuardarTIMovim_EgresoConsumo(in_movi_inve_detalle_x_Producto_CusCider_Info Info)
        {
            try
            {
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var Address = new in_movi_inve_detalle_x_Producto_CusCider();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    Address.IdNumMovi = Info.IdNumMovi;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    Address.IdNumMovi = Info.IdNumMovi;
                    Address.ot_CodObra = Info.ot_CodObra;
                    Address.ot_IdOrdenTaller = Info.ot_IdOrdenTaller;
                    Context.in_movi_inve_detalle_x_Producto_CusCider.Add(Address);
                    Context.SaveChanges();
                }
                return true;
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

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaTIMovim_EgresoConsumo(in_movi_inve_Info MovimientoPrinc)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                            where (q.IdEmpresa == MovimientoPrinc.IdEmpresa 
                            && q.IdSucursal == MovimientoPrinc.IdSucursal 
                            && q.IdMovi_inven_tipo == MovimientoPrinc.IdMovi_inven_tipo
                            && q.IdBodega == MovimientoPrinc.IdBodega
                            && q.IdNumMovi == MovimientoPrinc.IdNumMovi)

                            select q;
                foreach (var item in Query)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Lst.Add(Obj);
                }
                return Lst;
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
