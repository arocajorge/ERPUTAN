using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Roles
{
    public class ro_periodo_Data
    {
        string mensaje = "";
        public ro_periodo_Info _PeriodoInfo = new ro_periodo_Info();

        public List<ro_periodo_Info> Get_periodos(int idcompany)
        {
                List<ro_periodo_Info> lM = new List<ro_periodo_Info>();
            try
            {
                EntitiesRoles OEPeriodo = new EntitiesRoles();

                var selectPeriodo = from C in OEPeriodo.ro_periodo
                                    where C.IdEmpresa == idcompany
                                   
                                    select C;

                
                foreach (var item in selectPeriodo)
                {
                    ro_periodo_Info Cbt = new ro_periodo_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.pe_anio = Convert.ToInt32(item.pe_anio);
                    Cbt.pe_mes = Convert.ToInt32(item.pe_mes);
                    Cbt.pe_FechaIni = Convert.ToDateTime(item.pe_FechaIni.ToShortDateString());
                    Cbt.pe_FechaFin = Convert.ToDateTime(item.pe_FechaFin.ToShortDateString());
                    Cbt.pe_Descripcion = item.pe_FechaIni.ToShortDateString() + " al " + item.pe_FechaFin.ToShortDateString();
                    Cbt.pe_estado = item.pe_estado;
                    Cbt.MotivoAnulacion = item.MotivoAnulacion;
                    lM.Add(Cbt);                    

                }
                return (lM);
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
        public List<ro_periodo_Info> Get_periodos_disponibles(int idcompany)
        {
            List<ro_periodo_Info> lM = new List<ro_periodo_Info>();
            try
            {
                EntitiesRoles OEPeriodo = new EntitiesRoles();

                var selectPeriodo = from C in OEPeriodo.ro_periodo_x_ro_Nomina_TipoLiquiDisponibles
                                    where C.IdEmpresa == idcompany

                                    select C;


                foreach (var item in selectPeriodo)
                {
                    ro_periodo_Info Cbt = new ro_periodo_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.pe_anio = Convert.ToInt32(item.pe_anio);
                    Cbt.pe_mes = Convert.ToInt32(item.pe_mes);
                    Cbt.pe_FechaIni = Convert.ToDateTime(item.pe_FechaIni.ToShortDateString());
                    Cbt.pe_FechaFin = Convert.ToDateTime(item.pe_FechaFin.ToShortDateString());
                    Cbt.pe_Descripcion = item.pe_FechaIni.ToShortDateString() + " al " + item.pe_FechaFin.ToShortDateString();
                    Cbt.pe_estado = item.pe_estado;
                    Cbt.MotivoAnulacion = item.MotivoAnulacion;
                    lM.Add(Cbt);

                }
                return (lM);
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


        public List<ro_periodo_Info> ObtenerPeriodo(int idcompany, int IdPeriodo)
        {
            List<ro_periodo_Info> lM = new List<ro_periodo_Info>();
            try
            {
                EntitiesRoles OEPeriodo = new EntitiesRoles();

                var selectPeriodo = from C in OEPeriodo.ro_periodo
                                    where C.IdEmpresa == idcompany
                                    && C.IdPeriodo==IdPeriodo
                                    select C;


                foreach (var item in selectPeriodo)
                {
                    ro_periodo_Info Cbt = new ro_periodo_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.pe_anio = Convert.ToInt32(item.pe_anio);
                    Cbt.pe_mes = Convert.ToInt32(item.pe_mes);
                    Cbt.pe_FechaIni = Convert.ToDateTime(item.pe_FechaIni.ToShortDateString());
                    Cbt.pe_FechaFin = Convert.ToDateTime(item.pe_FechaFin.ToShortDateString());
                    Cbt.pe_Descripcion = item.pe_FechaIni.ToShortDateString() + " - " + item.pe_FechaFin.ToShortDateString();
                    Cbt.pe_estado = item.pe_estado;
                    Cbt.MotivoAnulacion = item.MotivoAnulacion;
                    lM.Add(Cbt);

                }
                return (lM);
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

      
        public Boolean ModificarDB(ro_periodo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_periodo.First(minfo => minfo.IdPeriodo == info.IdPeriodo && minfo.IdEmpresa == info.IdEmpresa);
                    contact.IdEmpresa = info.IdEmpresa;
                    contact.IdPeriodo = info.IdPeriodo;
                    contact.pe_FechaIni = info.pe_FechaIni;
                    contact.pe_FechaFin = info.pe_FechaFin;
                    contact.pe_estado = info.pe_estado;
                    contact.MotivoAnulacion = "";
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

        public Boolean GrabarDB(ro_periodo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {                                       
                       var que = from C in context.ro_periodo
                              where C.IdPeriodo == info.IdPeriodo
                              select C;
                    if (que.Count() == 0)
                    {
                        var address = new ro_periodo();

                        info.IdPeriodo = getId(info.IdEmpresa);
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdPeriodo = info.IdPeriodo;
                        address.pe_FechaIni = Convert.ToDateTime(info.pe_FechaIni.ToShortDateString());
                        address.pe_FechaFin = Convert.ToDateTime(info.pe_FechaFin.ToShortDateString());
                        address.pe_anio = Convert.ToInt32(info.pe_anio);
                        address.pe_mes = Convert.ToByte(info.pe_mes);
                        address.pe_estado = info.pe_estado;                       
                        
                        context.ro_periodo.Add(address);

                        context.SaveChanges();
                    }
                    else
                    {
                       
                        msg = "Error en el ingreso; código Existente";
                        return false;
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

      

        public Boolean AnularDB(ro_periodo_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_periodo.FirstOrDefault(dinfo => dinfo.IdPeriodo == Info.IdPeriodo && dinfo.IdEmpresa == Info.IdEmpresa);

                    contact.pe_estado = "I";

                    contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    contact.FechaHoraAnul = Info.FechaHoraAnul;
                    contact.MotivoAnulacion = Info.MotivoAnulacion;
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

        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_periodo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_periodo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdPeriodo).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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

        public Boolean ExistePeriodo(int idempresa, DateTime Finicia, DateTime Ffin)
        {
            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_periodo
                             where A.IdEmpresa == idempresa &&
                             A.pe_FechaIni == Finicia &&
                             A.pe_FechaFin == Ffin
                             select A;

                foreach (var item in select)
                {
                    Existe = true;
                }

                return Existe;

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

        public Boolean GuardarPeriodos(List<ro_periodo_Info> Lst, ref string mensaje)
        { try
            {

                using (EntitiesRoles Context = new EntitiesRoles())
                {
    
                foreach (var Item in Lst){
                   
                        ro_periodo Periodo = new ro_periodo();

                        Periodo.IdEmpresa = Item.IdEmpresa;
                        Periodo.IdPeriodo = Item.IdPeriodo;      
                        Periodo.pe_anio = Item.pe_anio;
                        Periodo.pe_mes = Item.pe_mes;
                        Periodo.pe_FechaIni = Convert.ToDateTime(Item.pe_FechaIni.ToShortDateString());
//                        Periodo.pe_FechaFin = Convert.ToDateTime(Item.pe_FechaFin.ToShortDateString());
                        Periodo.pe_FechaFin = Item.pe_FechaFin.AddHours(23).AddMinutes(59);
 
                        Periodo.pe_estado = Item.pe_estado;
                        

                        Context.ro_periodo.Add(Periodo);
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

       

    }
}
