using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Data
    {

        string mensaje = "";
        public Boolean GuardarDB(List<cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Info> LstInfo, ref string msg)
        {
            try
            {
                int sec = 0;

                foreach (var item in LstInfo)
                {
                    using (EntitiesCuentasxPagar OECxP = new EntitiesCuentasxPagar())
                    {
                        sec = sec + 1;

                        var Address = new cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados();

                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdAprobacion = item.IdAprobacion;
                        Address.Secuencia = sec;
                        Address.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa_Ing_Egr_Inv;
                        Address.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                        Address.IdMovi_inven_tipo_Ing_Egr_Inv = item.IdMovi_inven_tipo_Ing_Egr_Inv;
                        Address.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                        Address.Secuencia_Ing_Egr_Inv = item.Secuencia_Ing_Egr_Inv;
                        Address.Cantidad = item.Cantidad;
                        Address.Costo_uni = item.Costo_uni;
                        Address.Descuento = item.Descuento;
                        Address.SubTotal = item.SubTotal;
                        Address.PorIva = item.PorIva;
                        Address.valor_Iva = item.valor_Iva;
                        Address.Total = item.Total;
                        Address.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                        Address.IdCtaCble_IVA = item.IdCtaCble_IVA;
                        Address.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo_x_Gasto_x_cxp;
                        Address.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;

                        OECxP.cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados.Add(Address);
                        OECxP.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
   
   }
}
