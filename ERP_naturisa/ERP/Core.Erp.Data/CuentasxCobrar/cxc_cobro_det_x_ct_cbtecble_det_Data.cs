using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
   public class cxc_cobro_det_x_ct_cbtecble_det_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(cxc_cobro_det_x_ct_cbtecble_det_Info info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {

                    var addressG = new cxc_cobro_det_x_ct_cbtecble_det();

                    addressG.IdEmpresa_cb = info.IdEmpresa_cb;
                    addressG.IdSucursal_cb = info.IdSucursal_cb;
                    addressG.IdCobro_cb = info.IdCobro_cb;
                    addressG.secuencial_cb = info.secuencial_cb;

                    addressG.IdEmpresa_ct = info.IdEmpresa_ct;
                    addressG.IdTipoCbte_ct = info.IdTipoCbte_ct;
                    addressG.IdCbteCble_ct = info.IdCbteCble_ct;
                    addressG.secuencia_ct = info.secuencia_ct;

                    addressG.secuencia_reg = info.secuencia_reg = GetId(info.IdEmpresa_cb, info.IdSucursal_cb, info.IdCobro_cb, info.secuencial_cb);
                    addressG.observacion = info.observacion;



                    context.cxc_cobro_det_x_ct_cbtecble_det.Add(addressG);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public int GetId(int IdEmpresa, int IdSucursal, decimal IdCobro_cb, int secuencial_cb)
        {
            int Id = 0;
            try
            {
                EntitiesCuentas_x_Cobrar contex = new EntitiesCuentas_x_Cobrar();


                var selecte = contex.cxc_cobro_det_x_ct_cbtecble_det.Count(q => q.IdEmpresa_cb == IdEmpresa
                    && q.IdSucursal_cb == IdSucursal && q.IdCobro_cb == IdCobro_cb && q.secuencial_cb == secuencial_cb);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.cxc_cobro_det_x_ct_cbtecble_det
                                     where q.IdEmpresa_cb == IdEmpresa
                                     && q.IdSucursal_cb == IdSucursal
                                     && q.IdCobro_cb == IdCobro_cb
                                     && q.secuencial_cb == secuencial_cb
                                     select q.secuencia_reg).Max();


                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


    }
}
