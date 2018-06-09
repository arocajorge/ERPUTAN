/*CLASE: ro_CargaFamiliar_Data
 *MODIFICADA POR: ALBERTO MENA
 *FECHA: 24-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//Hector Ayauca Cepeda 03/02/2014
///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Data.Roles
{
    public class ro_CargaFamiliar_Data
    {
        int C=0;
        string mensaje = "";
        //obtener la lista de Cargas familiares
        public List<ro_CargaFamiliar_Info> Get_List_CargaFamiliar(int idempresa, int IdEmpleado)
        {
                List<ro_CargaFamiliar_Info> lM = new List<ro_CargaFamiliar_Info>();
            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_cargaFamiliar
                             where A.IdEmpresa == idempresa && A.IdEmpleado==IdEmpleado
                             select A;

                foreach (var item in select)
                {
                    ro_CargaFamiliar_Info info = new ro_CargaFamiliar_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdCargaFamiliar = item.IdCargaFamiliar;
                    info.Nombres = item.Nombres;
                    info.TipoFamiliar = item.TipoFamiliar;
                    //info.Sexo = (item.Sexo=="M")?"Masculino":"Femenino";
                    info.Sexo = item.Sexo;
                    info.Cedula = item.Cedula;
                    info.FechaNacimiento = item.FechaNacimiento;
                    info.Estado = (item.Estado == "A") ?true  : false;

                    lM.Add(info);
                }
                return (lM);
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

        public Boolean ModificarBD(ro_CargaFamiliar_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_cargaFamiliar.First(obj => obj.IdCargaFamiliar == info.IdCargaFamiliar);

                    contact.Nombres = info.Nombres;
                    contact.Sexo = info.Sexo;
                    contact.TipoFamiliar = info.TipoFamiliar;
                    contact.FechaNacimiento = info.FechaNacimiento;
                    contact.FechaDefucion = info.FechaDefucion;
                    contact.Estado = (info.Estado == true) ? "A" : "I";

                    context.SaveChanges();
                    msg = "Se ha procedido actualizar el registro del familiar #: " + info.IdCargaFamiliar.ToString() + " exitosamente";
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

        //obtener id de Carga Familiar
        public int getId()
        {
            try
            {

                int Id;
                EntitiesRoles OECargaFamiliar = new EntitiesRoles();
                var select = from q in OECargaFamiliar.ro_cargaFamiliar
                             select q;

                if (select.Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_fa = (from q in OECargaFamiliar.ro_cargaFamiliar
                                    select q.IdCargaFamiliar).Max();
                    Id = Convert.ToInt32(select_fa.ToString()) + 1;
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

        //grabar Carga Familiar
        public Boolean GrabarBD(ro_CargaFamiliar_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                        var address = new ro_cargaFamiliar();

                        int idCF = getId();

                        address.IdEmpresa = Info.IdEmpresa;
                        address.IdEmpleado = Info.IdEmpleado;
                        address.IdCargaFamiliar = idCF;
                        address.Cedula = Info.Cedula;
                        address.FechaNacimiento = Info.FechaNacimiento;
                        address.Estado = "A";
                        address.Nombres = Info.Nombres;
                        address.Sexo = Info.Sexo;
                        address.TipoFamiliar = Info.TipoFamiliar;
                        address.FechaDefucion = Info.FechaDefucion;
                        context.ro_cargaFamiliar.Add(address);
                        context.SaveChanges();

                        
                    }

                    msg = "Se ha procedido a grabar las cargas familiares del empleado  #: " + Info.IdEmpleado.ToString() + " exitosamente.";
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

        public Boolean AnularDB(ro_CargaFamiliar_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_cargaFamiliar.First(obj => obj.IdCargaFamiliar == info.IdCargaFamiliar);
                    contact.Estado = (info.Estado == true) ? "A" : "I";
                    context.SaveChanges();
                    msg = "Se ha procedido anular el ID del familiar #: " + info.IdCargaFamiliar.ToString() + " exitosamente";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                return false;
            }
        }

        public Boolean EliminarDB(List<ro_CargaFamiliar_Info> ListInfo,int IdEmpresa, int idEmpleado)
        {
            try
            {
                
                //var contact = ro_cargaFamiliar.Createro_carga_familiar(0,0,0,"","","","","");
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    context.Database.ExecuteSqlCommand("DELETE FROM ro_cargaFamiliar WHERE IdEmpresa ="+IdEmpresa+" AND IdEmpleado =  "+idEmpleado);
                    //foreach (var item in ListInfo)
                    //{
                    //    var address = context.ro_cargaFamiliar.First(A => A.IdEmpresa == IdEmpresa && A.IdEmpleado == idEmpleado);
                    //    address.IdEmpresa = IdEmpresa;
                    //    address.IdEmpleado = idEmpleado;
                    //    address.IdCargaFamiliar = address.IdCargaFamiliar;
                    //    address.Nombres = item.Nombres;
                    //    address.FechaNacimiento = item.FechaNacimiento;
                    //    address.Sexo = item.Sexo;
                    //    address.TipoFamiliar = item.TipoFamiliar;
                    //    address.Estado = (item.Estado==true)?"A":"I";

                    //    contact = address;
                    //    context.Remove(contact);
                    //    context.SaveChanges();
                    //}
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

        public Boolean getExiste(ro_CargaFamiliar_Info info)
        {

            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_cargaFamiliar
                             where A.IdEmpresa == info.IdEmpresa && A.IdEmpleado == info.IdEmpleado
                             && A.IdCargaFamiliar == info.IdCargaFamiliar
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

        public List<ro_CargaFamiliar_Info> Get_List_CargaFamiliar_x_Hijo(int idempresa, decimal IdEmpleado)
        {
                List<ro_CargaFamiliar_Info> lM = new List<ro_CargaFamiliar_Info>();
            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.vwRo_CargaFamiliar_X_Catalogo
                             where A.IdEmpresa == idempresa && A.IdEmpleado == IdEmpleado
                             && (A.TipoFamiliar == "T_CFA03" || A.TipoFamiliar == "HIJA")
                             && A.Estado == "A"
                             select A;

                foreach (var item in select)
                {
                    ro_CargaFamiliar_Info info = new ro_CargaFamiliar_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdCargaFamiliar = item.IdCargaFamiliar;
                    info.Nombres = item.Nombres;
                    info.TipoFamiliar = item.TipoFamiliar;
                    info.Parentezco = item.ca_descripcion;
                    //info.Sexo = (item.Sexo == "M") ? "Masculino" : "Femenino";
                    info.Sexo = item.Sexo;
                    info.Cedula = item.Cedula;
                    info.FechaNacimiento = item.FechaNacimiento;
                    info.Estado = (item.Estado == "A") ? true : false;

                    lM.Add(info);
                }
                return (lM);
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

        public List<ro_CargaFamiliar_Info> Get_List_CargaFamiliar_x_Conyugue(int idempresa, decimal IdEmpleado)
        {
                List<ro_CargaFamiliar_Info> lM = new List<ro_CargaFamiliar_Info>();
            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.vwRo_CargaFamiliar_X_Catalogo
                             where A.IdEmpresa == idempresa && A.IdEmpleado == IdEmpleado
                             && A.TipoFamiliar == "T_CFA04"
                             && A.Estado == "A"
                             select A;

                foreach (var item in select)
                {
                    ro_CargaFamiliar_Info info = new ro_CargaFamiliar_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdCargaFamiliar = item.IdCargaFamiliar;
                    info.Nombres = item.Nombres;
                    info.TipoFamiliar = item.TipoFamiliar;
                    info.Parentezco = item.ca_descripcion;
                    //info.Sexo = (item.Sexo == "M") ? "Masculino" : "Femenino";
                    info.Sexo = item.Sexo;
                    info.Cedula = item.Cedula;
                    info.FechaNacimiento = item.FechaNacimiento;
                    info.Estado = (item.Estado == "A") ? true : false;

                    lM.Add(info);
                }
                return (lM);
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

        public List<ro_CargaFamiliar_Info> Get_List_CargaFamiliar_x_Discapacitado(int idempresa, decimal IdEmpleado)
        {
                List<ro_CargaFamiliar_Info> lM = new List<ro_CargaFamiliar_Info>();
            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.vwRo_CargaFamiliar_X_Catalogo
                             where A.IdEmpresa == idempresa && A.IdEmpleado == IdEmpleado
                             && A.TipoFamiliar == "T_CFA05"
                             && A.Estado == "A"
                             select A;

                foreach (var item in select)
                {
                    ro_CargaFamiliar_Info info = new ro_CargaFamiliar_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdCargaFamiliar = item.IdCargaFamiliar;
                    info.Nombres = item.Nombres;
                    info.TipoFamiliar = item.TipoFamiliar;
                    info.Parentezco = item.ca_descripcion;
                    //info.Sexo = (item.Sexo == "M") ? "Masculino" : "Femenino";
                    info.Sexo = item.Sexo;
                    info.Cedula = item.Cedula;
                    info.FechaNacimiento = item.FechaNacimiento;
                    info.Estado = (item.Estado == "A") ? true : false;

                    lM.Add(info);
                }
                return (lM);
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

        public Boolean EliminarDB(ro_CargaFamiliar_Info Info)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    //context.ExecuteFunction("DELETE FROM ro_cargaFamiliar WHERE IdEmpresa =" + Info.IdEmpresa + " and IdEmpleado = " + Info.IdEmpleado+ " and IdCargaFamiliar = " + Info.IdCargaFamiliar);
                    context.Database.ExecuteSqlCommand("DELETE FROM ro_cargaFamiliar WHERE IdEmpresa =" + Info.IdEmpresa + " and IdEmpleado = " + Info.IdEmpleado + " and IdCargaFamiliar = " + Info.IdCargaFamiliar);
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
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_cargaFamiliar where IdEmpresa =" + idEmpresa.ToString()
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
