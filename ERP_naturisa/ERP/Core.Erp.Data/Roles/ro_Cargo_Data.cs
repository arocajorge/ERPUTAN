
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Cargo_Data
    {
        string mensaje = "";
        public List<ro_Cargo_Info> Get_List_Cargo(int idempresa)
        {
                List<ro_Cargo_Info> LstCargo = new List<ro_Cargo_Info>();
            try
            {
                EntitiesRoles EORoles = new EntitiesRoles();
                var select = from C in EORoles.ro_cargo 
                             where C.IdEmpresa == idempresa
                           
                             select C;
                foreach (var item in select)
                {

                    ro_Cargo_Info Cargo = new ro_Cargo_Info();
                    Cargo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    Cargo.IdCargo = Convert.ToInt32(item.IdCargo);
                    Cargo.ca_descripcion = item.ca_descripcion;
                    Cargo.IdUsuario = item.IdUsuario;
                    Cargo.Fecha_Transac = item.Fecha_Transac;
                    Cargo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Cargo.Fecha_UltMod = item.Fecha_UltMod;
                    Cargo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Cargo.Fecha_UltAnu = item.Fecha_UltAnu;
                    Cargo.nom_pc = item.nom_pc;
                    Cargo.ip = item.ip;
                    Cargo.Estado = item.Estado;
                    Cargo.MotivoAnulacion = item.MotivoAnulacion;
                    LstCargo.Add(Cargo);
                }                
                return LstCargo;

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

        public List<ro_Cargo_Info> Get_List_Cargo(int idempresa, int IdDepart)
        {
                List<ro_Cargo_Info> LstCargo = new List<ro_Cargo_Info>();
            try
            {
               
                EntitiesRoles EORoles = new EntitiesRoles();
                var select = from C in EORoles.ro_cargo
                             where C.IdEmpresa == idempresa
                             select C;
                foreach (var item in select)
                {
                    ro_Cargo_Info Cargo = new ro_Cargo_Info();

                    Cargo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    Cargo.IdCargo = Convert.ToInt32(item.IdCargo);
                    Cargo.ca_descripcion = item.ca_descripcion;
                 
                    Cargo.IdUsuario = item.IdUsuario;
                    Cargo.Fecha_Transac = item.Fecha_Transac;
                    Cargo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Cargo.Fecha_UltMod = item.Fecha_UltMod;
                    Cargo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Cargo.Fecha_UltAnu = item.Fecha_UltAnu;
                    Cargo.nom_pc = item.nom_pc;
                    Cargo.ip = item.ip;
                    Cargo.Estado = item.Estado;
                    Cargo.MotivoAnulacion = item.MotivoAnulacion;
                    LstCargo.Add(Cargo);
                }
                return LstCargo;

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

        public ro_Cargo_Info Get_Info_Cargo(int idempresa, int IdDepart, int IdTipoCargo)
        {
                ro_Cargo_Info Cargo = new ro_Cargo_Info();
                EntitiesRoles EORoles = new EntitiesRoles();
            try
            {

                var select = from C in EORoles.ro_cargo
                             where C.IdEmpresa == idempresa
                             select C;
                foreach (var item in select)
                {
                   

                    Cargo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    Cargo.IdCargo = Convert.ToInt32(item.IdCargo);
                    Cargo.ca_descripcion = item.ca_descripcion;
                    Cargo.IdUsuario = item.IdUsuario;
                    Cargo.Fecha_Transac = item.Fecha_Transac;
                    Cargo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Cargo.Fecha_UltMod = item.Fecha_UltMod;
                    Cargo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Cargo.Fecha_UltAnu = item.Fecha_UltAnu;
                    Cargo.nom_pc = item.nom_pc;
                    Cargo.ip = item.ip;
                    Cargo.Estado = item.Estado;
                }

                return Cargo;
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

        public ro_Cargo_Info Get_Info_Cargo(int idempresa, int IdCargo)
        {
            ro_Cargo_Info Cargo = new ro_Cargo_Info();
            EntitiesRoles EORoles = new EntitiesRoles();
            try
            {

                var select = from C in EORoles.ro_cargo
                             where C.IdEmpresa == idempresa
                             && C.IdCargo == IdCargo
                             select C;
                foreach (var item in select)
                {


                    Cargo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    Cargo.IdCargo = Convert.ToInt32(item.IdCargo);
                    Cargo.ca_descripcion = item.ca_descripcion;
                    Cargo.IdUsuario = item.IdUsuario;
                    Cargo.Fecha_Transac = item.Fecha_Transac;
                    Cargo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Cargo.Fecha_UltMod = item.Fecha_UltMod;
                    Cargo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Cargo.Fecha_UltAnu = item.Fecha_UltAnu;
                    Cargo.nom_pc = item.nom_pc;
                    Cargo.ip = item.ip;
                    Cargo.Estado = item.Estado;
                }
                return Cargo;
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

        public Boolean GrabarDB(ro_Cargo_Info InfoCargo, ref int IdCargo, ref string msg)
        {
            try
            {
               using (EntitiesRoles context = new EntitiesRoles())
                {                 
                   
                        ro_cargo address = new ro_cargo();

                        address.IdCargo = InfoCargo.IdCargo = IdCargo = GetId(InfoCargo.IdEmpresa);
                        address.IdEmpresa = InfoCargo.IdEmpresa;
                        address.IdCargo = IdCargo;
                        address.ca_descripcion = InfoCargo.ca_descripcion;

                        address.IdUsuario = InfoCargo.IdUsuario == null ? "" : InfoCargo.IdUsuario;
                        address.Fecha_Transac = (DateTime)InfoCargo.Fecha_Transac;

                        address.nom_pc = InfoCargo.nom_pc;
                        address.ip = InfoCargo.ip;
                        address.Estado = "A";

                        context.ro_cargo.Add(address);
                        context.SaveChanges();
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

        public int GetId(int idEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles db = new EntitiesRoles();

                var selecte = db.ro_cargo.Count(q => q.IdEmpresa == idEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_cargo
                                     where q.IdEmpresa == idEmpresa
                                     select q.IdCargo).Max();
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

        public Boolean ModificarDB(ro_Cargo_Info info, ref  string msg)
        {

            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                    {
                        var contact = context.ro_cargo.First(obj => obj.IdCargo == info.IdCargo &&
                             obj.IdEmpresa == info.IdEmpresa);

                           
                            contact.ca_descripcion = info.ca_descripcion;
                            contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                            contact.Fecha_UltMod = info.Fecha_UltMod;
                           
                            contact.nom_pc = info.nom_pc;
                            contact.ip = info.ip;
                            contact.Estado = info.Estado;
                            contact.MotivoAnulacion = "";

                        context.SaveChanges();
                        msg = "Se ha procedido a modificar el registro del cargo # : " + info.IdCargo.ToString() + " exitosamente";
                        
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

        public Boolean EliminarDB(ro_Cargo_Info info, ref  string msg)
        {
            try
            {
                EntitiesRoles OERoles = new EntitiesRoles();
                var select = from q in OERoles.ro_cargo
                             where q.IdCargo == info.IdCargo &&
                             q.IdEmpresa == info.IdEmpresa

                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesRoles context = new EntitiesRoles())
                    {
                        var contact = context.ro_cargo.First(obj => obj.IdCargo == info.IdCargo &&
                             obj.IdEmpresa == info.IdEmpresa);
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro del Cargo #: " + info.IdCargo.ToString() + " exitosamente";
                    }

                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Cargo #: " + info.IdCargo.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
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

        public Boolean GetExiste(ro_Cargo_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_cargo
                                where a.IdEmpresa == info.IdEmpresa && a.IdCargo==info.IdCargo
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
    }
}
