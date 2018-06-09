using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles
{
    public class ro_Departamento_Data
    {
        string mensaje = "";

        public List<ro_Departamento_Info> Get_List_Departamento(int IdEmpresa)
        {
                List<ro_Departamento_Info> lM = new List<ro_Departamento_Info>();
            try
            {

                EntitiesRoles OEPRoles_Dpto = new EntitiesRoles();

                var select_pv = from A in OEPRoles_Dpto.ro_Departamento
                                where A.IdEmpresa == IdEmpresa 
                                select A;

                foreach (var item in select_pv)
                {
                    ro_Departamento_Info info = new ro_Departamento_Info();
                    
                  
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdDepartamentoPadre = item.IdDepartamentoPadre;
                    info.de_descripcion = item.de_descripcion.Trim();

                    info.de_descripcion2 = "[" +item.IdDepartamento + "]-" +item.de_descripcion.Trim();


                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod = item.Fecha_UltMod;
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu = item.Fecha_UltAnu;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.Estado = item.Estado;
                    info.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    info.MotiAnula = item.MotiAnula;
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

        public List<ro_Departamento_Info> Get_List_Departamento(int IdEmpresa, int IdDivision, int IdArea)
        {
            List<ro_Departamento_Info> lM = new List<ro_Departamento_Info>();
            try
            {

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.vwRo_Departamento_X_Area
                                where a.IdEmpresa == IdEmpresa
                                && a.IdDivision==IdDivision
                                && a.IdArea==IdArea
                                select a;

                foreach (var item in datos)
                {
                    ro_Departamento_Info info = new ro_Departamento_Info();


                    info.IdEmpresa = item.IdEmpresa;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdDepartamentoPadre = item.IdDepartamentoPadre;
                    info.de_descripcion = item.de_descripcion.Trim();
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod = item.Fecha_UltMod;
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu = item.Fecha_UltAnu;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.Estado = item.Estado;
                    info.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    info.MotiAnula = item.MotiAnula;
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

        public Boolean GetExiste(ro_Departamento_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_Departamento
                                where a.IdEmpresa == info.IdEmpresa && a.IdDepartamento == info.IdDepartamento
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
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

        public Boolean ModificarDB(ro_Departamento_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Departamento.First(obj => obj.IdDepartamento==info.IdDepartamento && obj.IdEmpresa == info.IdEmpresa);
                  
                // contact.IdEmpresa = info.IdEmpresa;
                    contact.de_descripcion = info.de_descripcion;
                    contact.IdDepartamentoPadre = info.IdDepartamentoPadre;
                    contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contact.Fecha_UltMod = info.Fecha_UltMod;
                    contact.nom_pc = info.nom_pc;
                    contact.ip = info.ip;
                    contact.Estado = info.Estado;
                    contact.MotiAnula = "";
                    context.SaveChanges();
                    msg = "Se ha procedido actualizar el registro del Dpto # : " + info.IdDepartamento.ToString() + " exitosamente";
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

        public Boolean GrabarDB(ro_Departamento_Info ro_info, ref int Id,ref string mensaje)
        {
            try
            {
               
                using (EntitiesRoles context = new EntitiesRoles())
                { 
                            
                    EntitiesRoles EDB = new EntitiesRoles();
                 
                    var Q = from per in EDB.ro_Departamento
                            where per.IdDepartamento == ro_info.IdDepartamento
                            && per.IdEmpresa == ro_info.IdEmpresa
                            select per;

                    if (Q.ToList().Count == 0)
                    {                      
                    var address = new ro_Departamento();               
                    if (ro_info.IdDepartamentoPadre == 0 )
                    {
                        address.IdDepartamentoPadre = null;
                    }
                    else
                    {
                        address.IdDepartamentoPadre = ro_info.IdDepartamentoPadre;
                    }

                    address.IdEmpresa = ro_info.IdEmpresa;
                    address.IdDepartamento = ro_info.IdDepartamento = Id = getId(ro_info.IdEmpresa);
                    address.IdDepartamentoPadre = ro_info.IdDepartamentoPadre;
                    address.de_descripcion = ro_info.de_descripcion;
                    address.nom_pc = ro_info.nom_pc;
                    address.IdUsuario = (ro_info.IdUsuario == null) ? "" : ro_info.IdUsuario;
                    address.ip = ro_info.ip;
                    address.Fecha_Transac =Convert.ToDateTime(ro_info.Fecha_Transac);
                    address.MotiAnula = ro_info.MotiAnula;
                    address.Estado = ro_info.Estado;
                                    
                    context.ro_Departamento.Add(address);
                    context.SaveChanges();

                    mensaje = "Se ha procedido a guardar el Dpto..# : " + ro_info.IdDepartamento.ToString() + " exitosamente";

                    }
                    else
                        return false;
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

        public Boolean AnularDB(ro_Departamento_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Departamento.First(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdDepartamento == Info.IdDepartamento);

                    contact.Estado = "I";
                    contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                    contact.MotiAnula = Info.MotiAnula;
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

        public ro_Departamento_Info Get_Info_Departamento(int IdEmpresa, int IdDepartamento)
        {
                 ro_Departamento_Info InfoDep = new ro_Departamento_Info();
            try
            {
       
                EntitiesRoles ERol = new EntitiesRoles();
                var select = from D in ERol.ro_Departamento
                             where D.IdEmpresa == IdEmpresa && D.IdDepartamento == IdDepartamento
                             select D;

                foreach (var item in select)
                {
                    InfoDep.IdEmpresa = item.IdEmpresa;
                    InfoDep.IdDepartamento = item.IdDepartamento;
                    InfoDep.de_descripcion = item.de_descripcion;
                    InfoDep.IdUsuario = item.IdUsuario;
                    InfoDep.Fecha_Transac = item.Fecha_Transac;
                    InfoDep.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    InfoDep.Fecha_UltMod = item.Fecha_UltMod;
                    InfoDep.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    InfoDep.Fecha_UltAnu = item.Fecha_UltAnu;
                    InfoDep.nom_pc = item.nom_pc;
                    InfoDep.ip = item.ip;
                    InfoDep.Estado = item.Estado;                    
                }
                return InfoDep;
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

        public ro_Departamento_Data() { }

        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {

                EntitiesRoles contex = new EntitiesRoles();
                var selecte = contex.ro_Departamento.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.ro_Departamento
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdDepartamento).Max();
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
    }
}
