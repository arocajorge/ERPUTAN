using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Nomina_Tipo_Data
    {
        string mensaje = "";
        public ro_Nomina_Tipo_Info Get_Info_Nomina_Tipo(int IdEmpresa, int IdTipo)
        {
            try
            {
                EntitiesRoles oEnti = new EntitiesRoles();

                ro_Nomina_Tipo_Info info = new ro_Nomina_Tipo_Info();

                var tipo = oEnti.ro_Nomina_Tipo.First(
                    var => var.IdEmpresa == IdEmpresa
                        && var.IdNomina_Tipo == IdTipo
                        );

                info.IdEmpresa = tipo.IdEmpresa;
                info.IdNomina_Tipo = tipo.IdNomina_Tipo;
                info.Descripcion = tipo.Descripcion;
                info.Estado = tipo.Estado;
                info.FechaTransac = tipo.FechaTransac;

                return info;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<ro_Nomina_Tipo_Info> Get_List_Nomina_Tipo(int IdEmpresa)
        { 
            List<ro_Nomina_Tipo_Info> Lista= new List<ro_Nomina_Tipo_Info>();
            try
            {
              
                using (EntitiesRoles oEnti = new EntitiesRoles())
                {
                    var registros = from C in oEnti.ro_Nomina_Tipo
                                    where  C.IdEmpresa==IdEmpresa 
                                        select C;
                    foreach (var tipo in registros)
                    {
                        ro_Nomina_Tipo_Info info = new ro_Nomina_Tipo_Info();

                        info.IdEmpresa = tipo.IdEmpresa;
                        info.IdNomina_Tipo = tipo.IdNomina_Tipo;
                        info.Descripcion = tipo.Descripcion;
                        info.Estado = tipo.Estado;
                        info.FechaTransac = tipo.FechaTransac;
                        info.IdUsuario = tipo.IdUsuario;
                        info.MotivoAnu = tipo.MotivoAnu;
                        Lista.Add(info);

                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean GrabarDB(ro_Nomina_Tipo_Info Info, ref int idtipo, ref  string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var address = new ro_Nomina_Tipo();

                    idtipo = getID(Info.IdEmpresa, ref msg);
                    address.IdEmpresa = Info.IdEmpresa;
                    address.IdNomina_Tipo = Info.IdNomina_Tipo = idtipo;
                    address.Descripcion = Info.Descripcion;
                    address.Estado = "A";
                    address.FechaTransac = Info.FechaTransac;
                    address.IdUsuario = Info.IdUsuario;
                    context.ro_Nomina_Tipo.Add(address);
                    context.SaveChanges();
                
                }
                msg = "Se ha grabado correctamente el registro#"+Info.IdNomina_Tipo+" de Tipo de Nomina";
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
            
        
        }

        public Boolean AnularDB(ro_Nomina_Tipo_Info Info, ref  string msg) 
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Nomina_Tipo.First(
                        var => var.IdEmpresa == Info.IdEmpresa
                            && var.IdNomina_Tipo == Info.IdNomina_Tipo
                            );

                    contact.IdUsuarioAnu = Info.IdUsuarioAnu;
                    contact.FechaAnu = Info.FechaAnu;
                    contact.MotivoAnu = Info.MotivoAnu;
                    contact.Estado = "I";
                    contact.Descripcion = Info.Descripcion;
                    context.SaveChanges();


                } msg = "Se ha anulado correctamente el registro#" + Info.IdNomina_Tipo + " de Tipo de Nomina";
                return true;

            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
            
        
        }

        public Boolean ModificaDB(ro_Nomina_Tipo_Info Info,  ref  string msg)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Nomina_Tipo.First(
                        var => var.IdEmpresa == Info.IdEmpresa
                            && var.IdNomina_Tipo == Info.IdNomina_Tipo
                            );
                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdNomina_Tipo = Info.IdNomina_Tipo;
                    contact.Descripcion = Info.Descripcion;
                    contact.Estado = Info.Estado;
                    contact.FechaUltModi = Info.FechaUltModi;
                    contact.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                    contact.MotivoAnu = "";
                    context.SaveChanges();



                } msg = "Se ha modificado correctamente el registro#"+Info.IdNomina_Tipo+" de Tipo de Nomina";
                return true;

            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
            
        }

        public int getID(int idempresa, ref string msg)
        {
            try
            {int idNomina=0;

                EntitiesRoles oEnt = new EntitiesRoles();

                var select = (from C in oEnt.ro_Nomina_Tipo
                             where C.IdEmpresa == idempresa
                             select C.IdNomina_Tipo);
                if (select.Count() ==0)
                {
                    idNomina=1; 
                }
                else
                {
               var select_  =(from C in oEnt.ro_Nomina_Tipo
                             where C.IdEmpresa == idempresa
                             select C.IdNomina_Tipo).Count()+1;

                   idNomina = select_;
                }
                return idNomina;

            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
