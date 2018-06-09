using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
   public class ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Data
    {
        string mensaje = "";
        public List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info> Get_List( int IdEmpresa)
        {
            List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info> lista = new List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info>();
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var _sel = from q in context.ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar
                               where q.IdEmpresa ==IdEmpresa
                               select q;

                    foreach (var item in _sel)
                    {
                        ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info info = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNomina = item.IdNomina;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdCtaCble = item.IdCtaCble;
                        lista.Add(info);
                    }
                    return lista;
                }
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
                    string query = "delete  ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar where IdEmpresa='" + IdEmpresa + "'";

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

        public Boolean Grabar(List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info> ListaGrabar)
        {
            try
            {

                Eliminar(ListaGrabar.FirstOrDefault().IdEmpresa);
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    foreach (var item in ListaGrabar)
                    {
                        var contact = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar();
                        contact.IdEmpresa = item.IdEmpresa;
                        contact.IdNomina = item.IdNomina;
                        contact.IdNominaTipo = item.IdNominaTipo;
                        contact.IdCtaCble = item.IdCtaCble;
                        context.ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar.Add(contact);
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


        public ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info Get_Info(int IdEmpresa, int IdNomina, int IdNominaTipo)
        {

            ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info info = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info();
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var _sel = from q in context.ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar
                               where q.IdEmpresa == IdEmpresa
                               select q;

                    foreach (var item in _sel)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNomina = item.IdNomina;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdCtaCble = item.IdCtaCble;
                    }
                    return info;
                }
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
