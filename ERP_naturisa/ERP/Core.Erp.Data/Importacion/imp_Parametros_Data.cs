using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Importacion
{
    public class imp_Parametros_Data
    {
        string mensaje = "";
        public imp_Parametros_Info Get_Info_Parametros(int IdEmpresa)
        {
            try
            {
                EntitiesImportacion Imp = new EntitiesImportacion();
                imp_Parametros_Info obj = new imp_Parametros_Info();
                var item = Imp.imp_Parametros.FirstOrDefault(q => q.IdEmpresa == IdEmpresa);
                if (item != null)
                {
                    obj.IdTipoCbte_DiarioFob = Convert.ToInt32((item.IdTipoCbte_DiarioFob == null) ? 0 : item.IdTipoCbte_DiarioFob);
                    obj.IdTipoCbte_DiarioFob_Anul = Convert.ToInt32((item.IdTipoCbte_DiarioFob_Anul == null) ? 0 : item.IdTipoCbte_DiarioFob_Anul);
                    obj.IdTipoCbte_DiarioLiquidacion = Convert.ToInt32((item.IdTipoCbte_DiarioLiquidacion == null) ? 0 : item.IdTipoCbte_DiarioLiquidacion);
                    obj.IdTipoCbte_DiarioLiquidacion_Anul = Convert.ToInt32((item.IdTipoCbte_DiarioLiquidacion_Anul == null) ? 0 : item.IdTipoCbte_DiarioLiquidacion_Anul);
                    obj.IdCtaCble_para_Importaciones = item.IdCtaCble_para_Importaciones;
                }
                return obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB( imp_Parametros_Info Info) 
        {
            try
            {
                try
                {
                    using (EntitiesImportacion Context = new EntitiesImportacion()) 
                    {

                        var contact = Context.imp_Parametros.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa);
                        if (contact != null)
                        {
                            contact.IdTipoCbte_DiarioFob = Info.IdTipoCbte_DiarioFob;
                            contact.IdTipoCbte_DiarioFob_Anul = Info.IdTipoCbte_DiarioFob_Anul;
                            contact.IdTipoCbte_DiarioLiquidacion = Info.IdTipoCbte_DiarioLiquidacion;
                            contact.IdTipoCbte_DiarioLiquidacion_Anul = Info.IdTipoCbte_DiarioLiquidacion_Anul;
                            contact.IdCtaCble_para_Importaciones = Info.IdCtaCble_para_Importaciones;
                            Context.SaveChanges();
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
                    mensaje = ex.ToString() + " " + ex.Message;

                    if (ex.Message.ToString() == "Sequence contains no elements")
                    {
                        using (EntitiesImportacion Context = new EntitiesImportacion())
                        {
                            var address = new imp_Parametros();
                            address.IdEmpresa = Info.IdEmpresa;
                            address.IdTipoCbte_DiarioFob = Info.IdTipoCbte_DiarioFob;
                            address.IdTipoCbte_DiarioFob_Anul = Info.IdTipoCbte_DiarioFob_Anul;
                            address.IdTipoCbte_DiarioLiquidacion = Info.IdTipoCbte_DiarioLiquidacion;
                            address.IdTipoCbte_DiarioLiquidacion_Anul = Info.IdTipoCbte_DiarioLiquidacion_Anul;
                            address.IdCtaCble_para_Importaciones = Info.IdCtaCble_para_Importaciones;
                            Context.imp_Parametros.Add(address);
                            Context.SaveChanges();
                        }
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
