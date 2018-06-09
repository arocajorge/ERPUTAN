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
    public class Af_Depreciacion_x_cta_cbtecble_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public Boolean GuardarDB(Af_Depreciacion_x_cta_cbtecble_Info infoCbteCble)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var Address = new Af_Depreciacion_x_cta_cbtecble();
                    Address.IdEmpresa = infoCbteCble.IdEmpresa;
                    Address.IdDepreciacion = infoCbteCble.IdDepreciacion;
                    Address.IdTipoDepreciacion = infoCbteCble.IdTipoDepreciacion;
                    Address.ct_IdEmpresa = infoCbteCble.ct_IdEmpresa;
                    Address.ct_IdTipoCbte = infoCbteCble.ct_IdTipoCbte;
                    Address.ct_IdCbteCble = infoCbteCble.ct_IdCbteCble;

                    Context.Af_Depreciacion_x_cta_cbtecble.Add(Address);
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

        public Af_Depreciacion_x_cta_cbtecble_Info Get_Info_Af_Depreciacion_x_cta_cbtecble(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {
                Af_Depreciacion_x_cta_cbtecble_Info infoDepre = new Af_Depreciacion_x_cta_cbtecble_Info();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_Depreciacion_x_cta_cbtecble
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdDepreciacion == IdDepreciacion && q.IdTipoDepreciacion == IdTipoDepreciacion
                                 select q;

                    foreach (var item in select)
                    {
                        infoDepre.IdEmpresa = item.IdEmpresa;
                        infoDepre.IdDepreciacion = item.IdDepreciacion;
                        infoDepre.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        infoDepre.ct_IdEmpresa = item.ct_IdEmpresa;
                        infoDepre.ct_IdTipoCbte = item.ct_IdTipoCbte;
                        infoDepre.ct_IdCbteCble = item.ct_IdCbteCble;
                    }
                }
                return infoDepre;
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
