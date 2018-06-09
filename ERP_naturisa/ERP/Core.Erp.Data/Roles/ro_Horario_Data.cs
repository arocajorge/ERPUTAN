using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

//version 23/12/2013 

namespace Core.Erp.Data.Roles
{
   public class ro_Horario_Data
   {
        string mensaje = "";

        public decimal GetIdHorario(int idempresa)
        {
            try
            {
                decimal Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_horario
                        //  where C.IdEmpresa == idempresa //&& C.IdEmpleado == idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ro_horario
                                   where t.IdEmpresa == idempresa 
                                   select t.IdHorario).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
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

        public Boolean GuardarDB(ro_Horario_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    ro_horario infoHorario = new ro_horario();

                    infoHorario.IdEmpresa = Item.IdEmpresa;
                    infoHorario.IdHorario = Id = GetIdHorario(Item.IdEmpresa);
                    infoHorario.HoraIni = Item.HoraIni;
                    infoHorario.HoraFin = Item.HoraFin;
                    infoHorario.ToleranciaEnt = Item.ToleranciaEnt;
                    infoHorario.ToleranciaSal = Item.ToleranciaSal;
                    infoHorario.InicioEntrada = Item.InicioEntrada;
                    infoHorario.FinalEntrada = Item.FinalEntrada;
                    infoHorario.InicioSal = Item.InicioSal;
                    infoHorario.FinalSalida = Item.FinalSalida;
                    infoHorario.SalLunch = Item.SalLunch;
                    infoHorario.RegLunch = Item.RegLunch;
                    infoHorario.IdUsuario = Item.IdUsuario;
                    infoHorario.Fecha_Transac = DateTime.Now;
                    infoHorario.MinLunch = Item.Min_Almuerzo;
                    //infoHorario.TotalHoras = Item.TotalHoras;
                    infoHorario.Tolerancia_Hora = Item.Tolerancia_Hora;
                    infoHorario.Tolerancia_Minuto = Item.Tolerancia_Minuto;
                    infoHorario.Estado = Item.Estado;
                    infoHorario.Descripcion = Item.Descripcion;
                    

                    Context.ro_horario.Add(infoHorario);
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

        public Boolean ModificarDB(ro_Horario_Info Info, string msj)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_horario.First(var => var.IdEmpresa == Info.IdEmpresa && var.IdHorario == Info.IdHorario);

                    contact.HoraIni = Info.HoraIni;
                    contact.HoraFin = Info.HoraFin;
                    contact.ToleranciaEnt = Info.ToleranciaEnt;
                    contact.ToleranciaSal = Info.ToleranciaSal;
                    contact.InicioEntrada = Info.InicioEntrada;
                    contact.FinalEntrada = Info.FinalEntrada;
                    contact.InicioSal = Info.InicioSal;
                    contact.FinalSalida = Info.FinalSalida;
                    contact.SalLunch = Info.SalLunch;
                    contact.RegLunch = Info.RegLunch;
                    contact.MinLunch = Info.Min_Almuerzo;
                    contact.Descripcion = Info.Descripcion;
                    contact.Estado = Info.Estado;
                    contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    contact.Fecha_UltMod = DateTime.Now;
                    contact.MotiAnula = "";
                    contact.Tolerancia_Minuto = Info.Tolerancia_Minuto;
                    contact.Tolerancia_Hora = Info.Tolerancia_Hora;
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

        public Boolean AnularDB(ro_Horario_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_horario.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdHorario== info.IdHorario );
                    contact.MotiAnula = info.MotiAnula;
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = info.Fecha_UltAnu;
                    contact.Estado = "I";
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

    


   

        public List<ro_Horario_Info> Get_List_Horario(int IdEmpresa, decimal IdHorario)
        {
             List<ro_Horario_Info> lista = new List<ro_Horario_Info>();
            try
            {

                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    string Query = "select * from ro_horario where IdEmpresa =" + IdEmpresa + "  and IdHorario = '" + IdHorario + "' ";
                    lista = Context.Database.SqlQuery<ro_Horario_Info>(Query).ToList();
                }
                return lista;
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

        public List<ro_Horario_Info> Get_List_Horario(int IdEmpresa)
        {
             List<ro_Horario_Info> lista = new List<ro_Horario_Info>();
            try
            {


                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Consulta = from q in Context.ro_horario
                                   where q.IdEmpresa == IdEmpresa
                                   select q;
                    if (Consulta.Count() == 0)
                    {
                        return new List<ro_Horario_Info>();
                    }
                    foreach (var item in Consulta)
                    {
                        ro_Horario_Info info = new ro_Horario_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdHorario = item.IdHorario;

                        info.HoraIni = item.HoraIni;
                        info.HoraFin = item.HoraFin;
                        info.ToleranciaEnt = Convert.ToInt32(item.ToleranciaEnt);
                        info.ToleranciaSal = Convert.ToInt32(item.ToleranciaSal);
                        info.InicioEntrada = item.InicioEntrada;
                        info.FinalEntrada = item.FinalEntrada;
                        info.InicioSal = item.InicioSal;
                        info.FinalSalida = item.FinalSalida;
                        info.SalLunch = item.SalLunch;
                        info.RegLunch = item.RegLunch;
                        info.Min_Almuerzo = Convert.ToInt32(item.MinLunch);                        
                        info.Descripcion = item.Descripcion;
                        info.MotiAnula = item.MotiAnula;
                        info.Estado = item.Estado;
                        info.Tolerancia_Hora = item.Tolerancia_Hora;

                        info.Tolerancia_Minuto = item.Tolerancia_Minuto;
                        lista.Add(info);
                    }
                }
                return lista;

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
