using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_turno_Data
    {
        string mensaje = "";

        public List<ro_turno_Info> Get_List_Turno(int idempresa) 
        {
            List<ro_turno_Info> listresultado = new List<ro_turno_Info>();
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    string Query = "select * from ro_turno where IdEmpresa =" + idempresa;
                    listresultado = Context.Database.SqlQuery<ro_turno_Info>(Query).ToList();
                }
                return listresultado;
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

        public List<ro_turno_Info> Get_List_Turno(int IdEmpresa, decimal idTurno)
        {
             List<ro_turno_Info> lista = new List<ro_turno_Info>();
            try
            {

                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    string Query = "select * from ro_turno where IdEmpresa =" + IdEmpresa + "  and IdTurno = '" + idTurno + "' ";
                    lista = Context.Database.SqlQuery<ro_turno_Info>(Query).ToList();
                }
                return lista;
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

        public decimal GetIdTurno(int idempresa)
        {
            try
            {
                decimal Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_turno
                        where C.IdEmpresa == idempresa //&& C.IdEmpleado == idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ro_turno
                                   where t.IdEmpresa == idempresa 
                                   select t.IdTurno).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
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

        public Boolean GuardarDB(ro_turno_Info Item, ref decimal Id, ref string mensaje)
        {
            Boolean result = false;
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                   ro_turno  Turno = new ro_turno ();
                   ro_turno_x_tb_dia_Data datadetalle = new ro_turno_x_tb_dia_Data();
                   Turno.IdEmpresa = Item.IdEmpresa; Id = GetIdTurno(Item.IdEmpresa);
                   Turno.IdTurno = Id;
                   Turno.Estado = "A";
                   Turno.tu_descripcion = Item.tu_descripcion ;
                   Turno.Fecha_Transac = DateTime.Now;
                   Turno.IdUsuario = Item.IdUsuario;
                   Turno.es_jornada_desfasada = Item.es_jornada_desfasada;
                   Context.ro_turno.Add(Turno);
                   Context.SaveChanges();
                   result =  datadetalle.GuardarDetalleTurno(Item.Detalle, Id, ref mensaje);
                }

                return result;    
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

        public Boolean ModificarDB(ro_turno_Info Info, string msj)
        {
            Boolean result = false;
            try
            {
                ro_turno_x_tb_dia_Data datadetalle = new ro_turno_x_tb_dia_Data();

                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_turno.First(var => var.IdEmpresa == Info.IdEmpresa && var.IdTurno == Info.IdTurno);

                    contact.tu_descripcion = Info.tu_descripcion;
                    contact.es_jornada_desfasada = Info.es_jornada_desfasada;
                    contact.Estado = Info.Estado;
                    contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    contact.Fecha_UltMod = Info.Fecha_UltMod;
                    contact.MotiAnula = "";
                    context.SaveChanges();

                    if (datadetalle.EliminarDetalleTurno(Info.IdEmpresa, Info.IdTurno, ref msj))
                        if (datadetalle.GuardarDetalleTurno(Info.Detalle, Info.IdTurno, ref msj)) result = true;
                }
                return result;
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

        public Boolean AnularDB(ro_turno_Info Info, ref string msj)
        {
            try
            {
                ro_turno_x_tb_dia_Data datadetalle = new ro_turno_x_tb_dia_Data();

                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_turno.First(var => var.IdEmpresa == Info.IdEmpresa && var.IdTurno == Info.IdTurno);
                    
                    contact.Estado = "I";
                    contact.Fecha_UltAnu = DateTime.Now;
                    contact.MotiAnula = Info.MotiAnula;
                    contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    context.SaveChanges();
                }
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

    }
}
