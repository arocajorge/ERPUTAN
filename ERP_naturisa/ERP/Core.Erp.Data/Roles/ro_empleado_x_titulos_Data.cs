using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_empleado_x_titulos_Data
    {
        string mensaje = "";
        public Boolean GrabarDB(ro_empleado_x_titulos_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_empleado_x_titulos();

                    int idtitulo = getId(Info.IdEmpresa, Info.IdEmpleado);
                                        
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdEmpleado = Info.IdEmpleado;
                    Address.Secuencia = idtitulo;
                    Address.fecha = Info.fecha;
                    Address.IdInstitucion = Info.IdInstitucion;
                    Address.IdTitulo = Info.IdTitulo;
                    Address.Observacion = Info.Observacion;

                    Context.ro_empleado_x_titulos.Add(Address);
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

        public List<ro_empleado_x_titulos_Info> Get_List_empleado_x_titulos(int IdEmpresa)
        {
                List<ro_empleado_x_titulos_Info> Lst = new List<ro_empleado_x_titulos_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {

                var Query = from q in oEnti.ro_empleado_x_titulos
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in Query)
                {
                    ro_empleado_x_titulos_Info Obj = new ro_empleado_x_titulos_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.Secuencia = item.Secuencia;
                    Obj.fecha = item.fecha;
                    Obj.IdInstitucion = item.IdInstitucion;
                    Obj.IdTitulo = item.IdTitulo;
                    Obj.Observacion = item.Observacion;

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

        public List<ro_empleado_x_titulos_Info> Get_List_empleado_x_titulos(int IdEmpresa, decimal IdEmpleado)
        {
            List<ro_empleado_x_titulos_Info> lst = new List<ro_empleado_x_titulos_Info>();
            EntitiesRoles oEnti = new EntitiesRoles();
            try
            {                
                var Objeto = from T in oEnti.ro_empleado_x_titulos
                    where T.IdEmpresa == IdEmpresa && T.IdEmpleado == IdEmpleado
                    select T;

                foreach (var item in Objeto)
                {
                    ro_empleado_x_titulos_Info Info = new ro_empleado_x_titulos_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdEmpleado = item.IdEmpleado;
                    Info.Secuencia = item.Secuencia;
                    Info.fecha = item.fecha;
                    Info.IdInstitucion = item.IdInstitucion;
                    Info.IdTitulo = item.IdTitulo;
                    Info.Observacion = item.Observacion;
                    
                    lst.Add(Info);

                }    
               

                    return lst;
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

        public Boolean ModificarDB(ro_empleado_x_titulos_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_empleado_x_titulos.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdEmpleado == info.IdEmpleado);

                    contact.fecha = info.fecha;
                    contact.IdInstitucion = info.IdInstitucion;
                    contact.IdTitulo = info.IdTitulo;
                    contact.Observacion = info.Observacion;

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

        public Boolean AnularDB(ro_empleado_x_titulos_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_empleado_x_titulos.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdEmpleado == info.IdEmpleado);
                    contact.Observacion = "I";
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

        public int getId(int Idempresa, decimal idempleado)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_empleado_x_titulos
                             where q.IdEmpleado == idempleado && q.IdEmpresa == Idempresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_empleado_x_titulos
                                     select q.Secuencia).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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

        public Boolean getExiste(ro_empleado_x_titulos_Info info)
        {

            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_empleado_x_titulos
                             where A.IdEmpresa == info.IdEmpresa && A.IdEmpleado == info.IdEmpleado
                             && A.Secuencia == info.Secuencia
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


        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_titulos where IdEmpresa =" + idEmpresa.ToString()
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
