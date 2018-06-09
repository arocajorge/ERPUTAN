using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Parametros_Data
    {
        string mensaje = "";

        public Boolean ModificarDB(Af_Parametros_Info info)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    EntitiesActivoFijo param = new EntitiesActivoFijo();
                    var selectBaParam = (from C in param.Af_Parametros
                                         where C.IdEmpresa == info.IdEmpresa
                                         select C).Count();

                    if (selectBaParam == 0)
                    {
                        Af_Parametros addressG = new Af_Parametros();
                        addressG.IdEmpresa = info.IdEmpresa;
                        addressG.IdCtaCble_Activo = info.IdCtaCble_Activo;
                        addressG.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                        addressG.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;
                        addressG.IdTipoCbte = info.IdTipoCbte;
                        addressG.IdTipoCbteBaja = info.IdTipoCbteBaja;
                        addressG.IdTipoCbteMejora = info.IdTipoCbteMejora;
                        addressG.IdTipoCbteRetiro = info.IdTipoCbteRetiro;
                        addressG.IdTipoCbteVenta = info.IdTipoCbteVenta;
                        addressG.FormaContabiliza = info.FormaContabiliza;
                        addressG.IdTipoCbteMejora_Anulacion = info.IdTipoCbteMejora_Anulacion;
                        addressG.IdTipoCbteBaja_Anulacion = info.IdTipoCbteBaja_Anulacion;
                        addressG.IdTipoCbteVenta_Anulacion = info.IdTipoCbteVenta_Anulacion;
                        addressG.IdTipoCbteRetiro_Anulacion = info.IdTipoCbteRetiro_Anulacion;
                        addressG.IdTipoCbteDep_Acum_Anulacion = info.IdTipoCbteDep_Acum_Anulacion;
                        context.Af_Parametros.Add(addressG);
                        context.SaveChanges();
                    }
                    else
                    {
                        var contact = context.Af_Parametros.FirstOrDefault(para => para.IdEmpresa == info.IdEmpresa);
                        if (contact != null)
                        {
                            contact.IdEmpresa = info.IdEmpresa;
                            contact.IdCtaCble_Activo = info.IdCtaCble_Activo;
                            contact.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                            contact.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;
                            contact.IdTipoCbte = info.IdTipoCbte;
                            contact.IdTipoCbteBaja = info.IdTipoCbteBaja;
                            contact.IdTipoCbteMejora = info.IdTipoCbteMejora;
                            contact.IdTipoCbteRetiro = info.IdTipoCbteRetiro;
                            contact.IdTipoCbteVenta = info.IdTipoCbteVenta;
                            contact.FormaContabiliza = info.FormaContabiliza;
                            contact.IdTipoCbteMejora_Anulacion = info.IdTipoCbteMejora_Anulacion;
                            contact.IdTipoCbteBaja_Anulacion = info.IdTipoCbteBaja_Anulacion;
                            contact.IdTipoCbteVenta_Anulacion = info.IdTipoCbteVenta_Anulacion;
                            contact.IdTipoCbteRetiro_Anulacion = info.IdTipoCbteRetiro_Anulacion;
                            contact.IdTipoCbteDep_Acum_Anulacion = info.IdTipoCbteDep_Acum_Anulacion;
                            context.SaveChanges();
                        }
                    }
                }
                return true;
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

        public Af_Parametros_Info Get_Info_Parametros(int IdEmpresa)
        {
            try
            {
                Af_Parametros_Info Cbt = new Af_Parametros_Info();
                EntitiesActivoFijo param = new EntitiesActivoFijo();
                var selectBaParam = from C in param.Af_Parametros
                                    where C.IdEmpresa == IdEmpresa
                                    select C;

                foreach (var item in selectBaParam)
                {
                    Cbt.IdEmpresa = IdEmpresa;
                    Cbt.IdTipoCbte = item.IdTipoCbte;
                    Cbt.IdTipoCbteBaja = item.IdTipoCbteBaja;
                    Cbt.IdTipoCbteMejora = item.IdTipoCbteMejora;
                    Cbt.IdTipoCbteRetiro = item.IdTipoCbteRetiro;
                    Cbt.IdTipoCbteVenta = item.IdTipoCbteVenta;
                    Cbt.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    Cbt.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    Cbt.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;
                    Cbt.FormaContabiliza = item.FormaContabiliza;
                    Cbt.IdTipoCbteMejora_Anulacion = item.IdTipoCbteMejora_Anulacion;
                    Cbt.IdTipoCbteBaja_Anulacion = item.IdTipoCbteBaja_Anulacion;
                    Cbt.IdTipoCbteVenta_Anulacion = item.IdTipoCbteVenta_Anulacion;
                    Cbt.IdTipoCbteRetiro_Anulacion = item.IdTipoCbteRetiro_Anulacion;
                    Cbt.IdTipoCbteDep_Acum_Anulacion = item.IdTipoCbteDep_Acum_Anulacion;
                }
                return (Cbt);
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
    }
}
