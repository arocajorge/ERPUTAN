using Core.Erp.Data.General;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Academico
{
    public class Aca_Parametros_Data
    {
        public bool GuardarDB(Aca_Parametros_Info info)
        {
            try
            {
                using (Entities_Academico Context = new Entities_Academico())
                {
                    Aca_Parametros Entity = Context.Aca_Parametros.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdInstitucion == info.IdInstitucion);

                    if (Entity == null)
                    {
                        Entity = new Aca_Parametros();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdInstitucion = info.IdInstitucion;
                        Entity.IdSucursal_fact = info.IdSucursal_fact;
                        Entity.IdBodega_fact = info.IdBodega_fact;
                        Entity.IdPuntoVta_fact = info.IdPuntoVta_fact;
                        Entity.IdCaja_fact = info.IdCaja_fact;
                        Context.Aca_Parametros.Add(Entity);
                        Context.SaveChanges();
                    }
                    else
                    {
                        Entity.IdSucursal_fact = info.IdSucursal_fact;
                        Entity.IdBodega_fact = info.IdBodega_fact;
                        Entity.IdPuntoVta_fact = info.IdPuntoVta_fact;
                        Entity.IdCaja_fact = info.IdCaja_fact;
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public Aca_Parametros_Info Get_info_parametros(int IdEmpresa, int IdInstitucion)
        {
            try
            {
                Aca_Parametros_Info info = new Aca_Parametros_Info();

                using (Entities_Academico Context = new Entities_Academico())
                {
                    var lst = from q in Context.Aca_Parametros
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdInstitucion = item.IdInstitucion;
                        info.IdSucursal_fact = item.IdSucursal_fact;
                        info.IdBodega_fact = item.IdBodega_fact;
                        info.IdPuntoVta_fact = item.IdPuntoVta_fact;
                        info.IdCaja_fact = item.IdCaja_fact;
                    }
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

    }
}
