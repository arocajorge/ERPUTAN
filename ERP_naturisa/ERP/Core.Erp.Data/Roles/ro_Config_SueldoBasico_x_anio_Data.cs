using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Config_SueldoBasico_x_anio_Data
    {
        string mensaje = "";
        public List<ro_Config_SueldoBasico_x_anio_Info> TraerDatos()
        {
            List<ro_Config_SueldoBasico_x_anio_Info> ListaRetornar = new List<ro_Config_SueldoBasico_x_anio_Info>();
            try
            {
                EntitiesRoles oEnt = new EntitiesRoles();
                IQueryable<ro_Config_SueldoBasico_x_anio_Info> Consulta =
                                                        from C in oEnt.ro_Config_SueldoBasico_x_anio 
                                                        select new ro_Config_SueldoBasico_x_anio_Info
                                                        {
                                                            sb_anio = C.sb_anio,
                                                            sb_valor = C.sb_valor

                                                        };
                ListaRetornar = Consulta.ToList();
                return ListaRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Eliminar(int IdEmpresa)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    string query = "delete from ro_Config_SueldoBasico_x_anio";

                    Context.Database.ExecuteSqlCommand(query);

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Grabar(List<ro_Config_SueldoBasico_x_anio_Info> ListaGrabar)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    foreach (var item in ListaGrabar)
                    {
                        var contact = new ro_Config_SueldoBasico_x_anio();
                        contact.sb_anio = item.sb_anio;
                        contact.sb_valor = item.sb_valor;
                        contact.IdUsuario = item.IdUsuario;
                        contact.Fecha_Transac = item.Fecha_Transac;
                        contact.nom_pc = item.nom_pc;
                        contact.ip = item.ip;

                        context.ro_Config_SueldoBasico_x_anio.Add(contact);
                        context.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
