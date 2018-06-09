using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Empleado_TipoNomina_Data
    {
        string mensaje = "";
        public Boolean GrabarDB(ro_Empleado_TipoNomina_Info Info, ref string msg)
        {
            try
            {
                List<ro_Empleado_TipoNomina_Info> Lst = new List<ro_Empleado_TipoNomina_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_empleado_x_ro_tipoNomina();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdEmpleado = Info.IdEmpleado;
                    Address.IdTipoNomina = Info.IdNomina_Tipo;
                    Address.observacion = "";

                    Context.ro_empleado_x_ro_tipoNomina.Add(Address);
                    
                    Context.SaveChanges();

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

        public List<ro_Empleado_TipoNomina_Info> Get_List_Empleado_TipoNomina(int IdEmpresa)
        {
          List<ro_Empleado_TipoNomina_Info> Lst = new List<ro_Empleado_TipoNomina_Info>();
            try
            {
                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_empleado_x_ro_tipoNomina
                            where q.IdEmpresa == IdEmpresa

                            select q;

                foreach (var item in Query)
                {
                    ro_Empleado_TipoNomina_Info Obj = new ro_Empleado_TipoNomina_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.IdNomina_Tipo = item.IdTipoNomina;

                    Lst.Add(Obj);

                }
                return Lst;
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


        public List<ro_Empleado_TipoNomina_Info> Get_List_Empleado_TipoNomina_x_IdEmpleado(int IdEmpresa, decimal IdEmpleado)
        {
              List<ro_Empleado_TipoNomina_Info> Lst = new List<ro_Empleado_TipoNomina_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.vwRo_Empleado_TipoNomina
                           where q.IdEmpresa == IdEmpresa && q.IdEmpleado==IdEmpleado
              
                            select q;

                foreach (var item in Query)
                {
                    ro_Empleado_TipoNomina_Info Obj = new ro_Empleado_TipoNomina_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.IdNomina_Tipo = item.IdTipoNomina;
                    Obj.Descripcion = item.Descripcion;
                    

                    Lst.Add(Obj);

                }
                return Lst;
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

        public ro_Empleado_TipoNomina_Info Get_Info_Empleado_TipoNomina(int IdEmpresa, decimal IdEmpleado)
        {
            ro_Empleado_TipoNomina_Info Info = new ro_Empleado_TipoNomina_Info();
            EntitiesRoles oEnti = new EntitiesRoles();
            try
            {
                var Objeto = oEnti.ro_empleado_x_ro_tipoNomina.First(var => var.IdEmpresa == IdEmpresa && var.IdEmpleado == IdEmpleado);
                Info.IdEmpresa = Objeto.IdEmpresa;
                Info.IdEmpleado = Objeto.IdEmpleado;
                Info.IdNomina_Tipo = Objeto.IdTipoNomina;

                return Info;
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

        public Boolean ModificarDB(ro_Empleado_TipoNomina_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado_x_ro_tipoNomina.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdEmpleado==info.IdEmpleado);

                    contact.IdEmpresa = info.IdEmpresa;
                    contact.IdEmpleado = info.IdEmpleado;
                    contact.IdTipoNomina = info.IdNomina_Tipo;

                    context.SaveChanges();

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

        public Boolean ExisteNomina(int idempresa, decimal idempleado, int IdNomina)
        {

            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_empleado_x_ro_tipoNomina
                             where A.IdEmpresa == idempresa && A.IdEmpleado == idempleado
                             && A.IdTipoNomina == IdNomina
                             select A;

                foreach (var item in select)
                {
                    Existe = true;
                }

                return Existe;

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

        public Boolean EliminarDB(ro_Empleado_TipoNomina_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado_x_ro_tipoNomina.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdEmpleado == info.IdEmpleado && minfo.IdTipoNomina == info.IdNomina_Tipo);

                    context.ro_empleado_x_ro_tipoNomina.Remove(contact);
                    context.SaveChanges();
                    context.Dispose();

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

        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_ro_tipoNomina where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                   );
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
