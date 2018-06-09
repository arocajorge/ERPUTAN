using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.General
{
    public class tb_banco_procesos_bancarios_tipo_Data
    {
        public List<tb_banco_procesos_bancarios_tipo_Info> Get_list_procesos()
        {
            try
            {
                List<tb_banco_procesos_bancarios_tipo_Info> Lista = new List<tb_banco_procesos_bancarios_tipo_Info>();

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.tb_banco_procesos_bancarios_tipo
                              select q;

                    foreach (var item in lst)
                    {
                        tb_banco_procesos_bancarios_tipo_Info info = new tb_banco_procesos_bancarios_tipo_Info();
                        info.IdProceso_bancario_tipo = item.IdProceso_bancario_tipo;
                        info.Iniciales_Archivo = item.Iniciales_Archivo;
                        info.nom_proceso_bancario = item.nom_proceso_bancario;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(tb_banco_procesos_bancarios_tipo_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.tb_banco_procesos_bancarios_tipo
                              where q.IdProceso_bancario_tipo == Info.IdProceso_bancario_tipo
                              select q;

                    if (lst.Count() == 0)
                    {
                        tb_banco_procesos_bancarios_tipo contact = new tb_banco_procesos_bancarios_tipo();

                        contact.IdProceso_bancario_tipo = Info.IdProceso_bancario_tipo;
                        contact.Iniciales_Archivo = Info.Iniciales_Archivo;
                        contact.nom_proceso_bancario = Info.nom_proceso_bancario;

                        Context.tb_banco_procesos_bancarios_tipo.Add(contact);
                        Context.SaveChanges();

                        mensaje = "Grabación ok..";
                    }
                    else
                    {
                        mensaje = "El Id Tipo de proceso ya se encuentra en base.";
                        return false;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(tb_banco_procesos_bancarios_tipo_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    tb_banco_procesos_bancarios_tipo contact = Context.tb_banco_procesos_bancarios_tipo.FirstOrDefault(q => q.IdProceso_bancario_tipo == Info.IdProceso_bancario_tipo);
                    if (contact != null)
                    {
                        contact.Iniciales_Archivo = Info.Iniciales_Archivo;
                        contact.nom_proceso_bancario = Info.nom_proceso_bancario;

                        Context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
