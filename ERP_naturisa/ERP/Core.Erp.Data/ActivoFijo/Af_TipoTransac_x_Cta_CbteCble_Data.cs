using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_TipoTransac_x_Cta_CbteCble_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public Boolean GuardarTran_x_CbteCble(Af_TipoTransac_x_Cta_CbteCble_Info InfoTran_x_Cta, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var Address = new Af_TipoTransac_x_Cta_CbteCble();
                    Address.IdEmpresa = InfoTran_x_Cta.IdEmpresa;
                    Address.IdTipTransActivoFijo = InfoTran_x_Cta.IdTipTransActivoFijo;
                    Address.IdCatalogo = InfoTran_x_Cta.IdCatalogo;
                    Address.ct_IdEmpresa = InfoTran_x_Cta.ct_IdEmpresa;
                    Address.ct_IdCbteCble = InfoTran_x_Cta.ct_IdCbteCble;
                    Address.ct_IdTipoCbte = InfoTran_x_Cta.ct_IdTipoCbte;

                    Context.Af_TipoTransac_x_Cta_CbteCble.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Af_TipoTransac_x_Cta_CbteCble_Info Get_Info_Transac_x_CtaCble(int IdEmpresa, decimal IdTipoTran, string IdCatalogo)
        {
            try
            {
                Af_TipoTransac_x_Cta_CbteCble_Info info = new Af_TipoTransac_x_Cta_CbteCble_Info();
                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_TipoTransac_x_Cta_CbteCble
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdTipTransActivoFijo == IdTipoTran && q.IdCatalogo == IdCatalogo
                                 select q;

                    foreach (var item in select)
                    {                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipTransActivoFijo = item.IdTipTransActivoFijo;
                        info.IdCatalogo = item.IdCatalogo;
                        info.ct_IdEmpresa = item.ct_IdEmpresa;
                        info.ct_IdCbteCble = item.ct_IdCbteCble;
                        info.ct_IdTipoCbte = item.ct_IdTipoCbte;
                    }                    
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
