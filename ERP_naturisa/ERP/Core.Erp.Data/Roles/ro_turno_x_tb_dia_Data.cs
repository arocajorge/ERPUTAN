using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_turno_x_tb_dia_Data
    {
        string mensaje = "";
        public List<ro_turno_x_tb_dia_Info> Get_List_turno_x_tb_dia(int IdEmpresa, decimal IdTurno)
        { 
            List<ro_turno_x_tb_dia_Info> ListaResultante = new List<ro_turno_x_tb_dia_Info>();
            
            try
            {
                 //List<ro_prestamo_detalle_Info> Lst = new List<ro_prestamo_detalle_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                   IQueryable<ro_turno_x_tb_dia_Info> Consulta = from q in Context.vwro_turno_x_tb_dia 
                                                                    where q.IdEmpresa == IdEmpresa && q.IdTurno == IdTurno
                                                                  select new ro_turno_x_tb_dia_Info
                                                                    {
                                                                       Activo = q.Activo,
                                                                       idDia  = q.idDia,
                                                                       IdEmpresa = q.IdEmpresa,
                                                                       IdTurno = q.IdTurno, Dia = q.sdia
                                                                         
                                                                    };
                    ListaResultante = Consulta.ToList();
                }
                return ListaResultante;
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
        public List<ro_turno_x_tb_dia_Info> Get_List_turno_x_tb_dia(int IdEmpresa)
        {
            List<ro_turno_x_tb_dia_Info> ListaResultante = new List<ro_turno_x_tb_dia_Info>();

            try
            {
                //List<ro_prestamo_detalle_Info> Lst = new List<ro_prestamo_detalle_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    IQueryable<ro_turno_x_tb_dia_Info> Consulta = from q in Context.vwro_turno_x_tb_dia
                                                                  where q.IdEmpresa == IdEmpresa
                                                                  select new ro_turno_x_tb_dia_Info
                                                                  {
                                                                      Activo = q.Activo,
                                                                      idDia = q.idDia,
                                                                      IdEmpresa = q.IdEmpresa,
                                                                      IdTurno = q.IdTurno,
                                                                      Dia = q.sdia

                                                                  };
                    ListaResultante = Consulta.ToList();
                }
                return ListaResultante;
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

        public Boolean GuardarDetalleTurno(List<ro_turno_x_tb_dia_Info> Lst, decimal Id, ref string mensaje)
        {
            try
            {
                foreach (var Item in Lst)
                {
                    using (EntitiesRoles Context = new EntitiesRoles())
                    {
                        ro_turno_x_tb_dia Info = new ro_turno_x_tb_dia();

                        Info.IdEmpresa = Item.IdEmpresa;
                        Info.IdTurno = Id;
                        Info.idDia =Item.idDia;
                        Info.Activo = Item.Activo;

                        Context.ro_turno_x_tb_dia.Add(Info);
                        Context.SaveChanges();
                    }
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
               
        public Boolean EliminarDetalleTurno(int IdEmpresa, decimal idTurno, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    //string dateIni = FechaIni.ToString("yyyy/MM/dd");
                    //string dateFin = FechaFin.ToString("yyyy/MM/dd");
                    string Query = "delete from ro_turno_x_tb_dia where IdEmpresa =" + IdEmpresa + "  and IdTurno = '" + idTurno + "' ";
                    Context.Database.ExecuteSqlCommand(Query);
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
