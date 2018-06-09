using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico;

namespace Core.Erp.Data.Academico
{
    public class Aca_Periodo_Data
    {
        #region Variables
        string mensaje = "";
        public Aca_Periodo_Info _PeriodoInfo = new Aca_Periodo_Info();
        public Aca_Anio_Lectivo_Info Info_Anio = new Aca_Anio_Lectivo_Info();
        #endregion

        public int getId(int IdInstitucion, int Anio, int mes)
        {
            try
            {
                int Id;
                Entities_Academico OEEmpleado = new Entities_Academico();
                var select = from q in OEEmpleado.Aca_periodo
                             where q.IdInstitucion == IdInstitucion
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = ((Anio) *100 + mes);
                }
                else
                {
                    Id = ((Anio) * 100 + mes);
                    //var select_em = (from q in OEEmpleado.Aca_periodo
                    //                 where q.IdInstitucion == IdInstitucion
                    //                 select q.IdPeriodo).Max();
                    //Id = Convert.ToInt32(select_em.ToString()) + 1;
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

        public List<Aca_Periodo_Info> Get_List_Periodo(int IdInstitucion)
        {
            List<Aca_Periodo_Info> lM = new List<Aca_Periodo_Info>();
            try
            {
                Entities_Academico Aca_Periodo = new Entities_Academico();

                var selectPeriodo = from C in Aca_Periodo.Aca_periodo
                                    where C.IdInstitucion == IdInstitucion

                                    select C;


                foreach (var item in selectPeriodo)
                {
                    Aca_Periodo_Info Cbt = new Aca_Periodo_Info();

                    Cbt.IdInstitucion = item.IdInstitucion;
                    Cbt.IdAnioLectivo = item.IdAnioLectivo;
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

        public List<Aca_Periodo_Info> Get_List_Periodo(int IdInstitucion, int IdPeriodo)
        {
            List<Aca_Periodo_Info> lM = new List<Aca_Periodo_Info>();
            try
            {
                Entities_Academico OEPeriodo = new Entities_Academico();

                var selectPeriodo = from C in OEPeriodo.Aca_periodo
                                    where C.IdInstitucion == IdInstitucion
                                    && C.IdPeriodo == IdPeriodo
                                    select C;


                foreach (var item in selectPeriodo)
                {
                    Aca_Periodo_Info Cbt = new Aca_Periodo_Info();

                    Cbt.IdInstitucion = item.IdInstitucion;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.IdAnioLectivo = item.IdAnioLectivo;
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

        public List<Aca_Periodo_Info> Get_List_Periodo_x_AnioLectivo(int IdInstitucion, int IdAnioLectivo)
        {
            List<Aca_Periodo_Info> lM = new List<Aca_Periodo_Info>();
            try
            {
                Entities_Academico OEPeriodo = new Entities_Academico();

                var selectPeriodo = from C in OEPeriodo.Aca_periodo
                                    where C.IdInstitucion == IdInstitucion
                                    && C.IdAnioLectivo == IdAnioLectivo
                                    //&& C.est_apertura=="A"
                                    select C;


                foreach (var item in selectPeriodo)
                {
                    Aca_Periodo_Info Cbt = new Aca_Periodo_Info();

                    Cbt.IdInstitucion = item.IdInstitucion;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.IdAnioLectivo = item.IdAnioLectivo;
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
        //public List<Aca_Periodo_Info> Get_List_PeriodoActivo_x_AnioLectivo(int IdInstitucion, string IdAnioLectivo)
        public List<Aca_Periodo_Info> Get_List_PeriodoActivo_x_AnioLectivo(int IdInstitucion, int IdAnioLectivo)
        {
            List<Aca_Periodo_Info> lM = new List<Aca_Periodo_Info>();
            try
            {
                Entities_Academico OEPeriodo = new Entities_Academico();

                var selectPeriodo = from C in OEPeriodo.Aca_periodo
                                    where C.IdInstitucion == IdInstitucion
                                    && C.IdAnioLectivo == IdAnioLectivo
                                    && C.est_apertura == "A"
                                    select C;


                foreach (var item in selectPeriodo)
                {
                    Aca_Periodo_Info Cbt = new Aca_Periodo_Info();

                    Cbt.IdInstitucion = item.IdInstitucion;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.IdAnioLectivo = item.IdAnioLectivo;
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

        public List<Aca_Periodo_Info> Get_List_Periodo_Pre(int IdInstitucion)
        {
            List<Aca_Periodo_Info> lM = new List<Aca_Periodo_Info>();

            try
            {
                Entities_Academico OEPeriodo = new Entities_Academico();

                var selectPeriodo = from C in OEPeriodo.Aca_periodo
                                    group C by new
                                    {
                                        C.pe_anio,
                                        C.IdInstitucion
                                    } into grouping
                                    select new { grouping.Key, grouping.Key.pe_anio };
                foreach (var item in selectPeriodo)
                {
                    Aca_Periodo_Info Cbt = new Aca_Periodo_Info();
                    Cbt.IdInstitucion = item.Key.IdInstitucion;
                    Cbt.pe_anio = Convert.ToInt32(item.pe_anio);

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

        public Boolean ExistePeriodo(int IdInstitucion, int IdPeriodo)
        {
            try
            {
                Boolean Existe = false;
                Entities_Academico context = new Entities_Academico();

                var select = from A in context.Aca_periodo
                             where A.IdInstitucion == IdInstitucion 
                             && A.IdPeriodo == IdPeriodo
                             
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
        
        public Boolean GrabarDB(Aca_Periodo_Info Info, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var que = from C in context.Aca_periodo
                              where C.IdPeriodo == Info.IdPeriodo
                              select C;
                    if (que.Count() == 0)
                    {
                        var address = new Aca_periodo();                        
                        //Info.IdPeriodo = getId(Info.IdInstitucion, Info.pe_anio, Info.pe_mes);
                        address.IdInstitucion = Info.IdInstitucion;
                        address.IdPeriodo = Info.IdPeriodo;
                        address.IdAnioLectivo = Info.IdAnioLectivo;
                        address.pe_FechaIni = Convert.ToDateTime(Info.pe_FechaIni);
                        address.pe_FechaFin = Convert.ToDateTime(Info.pe_FechaFin);
                        address.pe_anio = Convert.ToInt32(Info.pe_anio);
                        address.pe_mes = Convert.ToByte(Info.pe_mes);
                        address.pe_estado = Info.pe_estado;

                        context.Aca_periodo.Add(address);

                        context.SaveChanges();
                    }
                    else
                    {
                        msg = "Error en el ingreso; Periodo  Existente";
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

        public Boolean ModificarDB(Aca_Periodo_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (Entities_Academico context = new Entities_Academico())
                {
                    var contact = context.Aca_periodo.FirstOrDefault(minfo => minfo.IdPeriodo == Info.IdPeriodo &&
                                                                    minfo.IdInstitucion == Info.IdInstitucion &&
                                                                    minfo.IdAnioLectivo == Info.IdAnioLectivo);
                    if (contact != null)
                    {
                        contact.IdInstitucion = Info.IdInstitucion;
                        contact.IdPeriodo = Info.IdPeriodo;
                        contact.IdAnioLectivo = Info.IdAnioLectivo;
                        contact.pe_FechaIni = Info.pe_FechaIni;
                        contact.pe_FechaFin = Info.pe_FechaFin;
                        contact.pe_estado = Info.pe_estado;
                        contact.Fecha_UltMod = Info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;

                        contact.MotivoAnulacion = "";
                        contact.est_apertura = Info.est_apertura;

                        context.SaveChanges();
                        resultado = true;
                    }
                    else
                        msg = "No se pudo modificar, ya que la consulta regreso vacia";
                }
                return resultado;
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

        public Boolean AnularDB(Aca_Periodo_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (Entities_Academico context = new Entities_Academico())
                {
                    var contact = context.Aca_periodo.FirstOrDefault(dinfo => dinfo.IdPeriodo == Info.IdPeriodo && dinfo.IdInstitucion == Info.IdInstitucion);

                    if (contact != null)
                    {
                        contact.pe_estado = "I";

                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.FechaHoraAnul = DateTime.Now; ;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        context.SaveChanges();
                        resultado = true;
                    }
                    else
                        msg = "No se pudo Anular, ya que la consulta regreso vacia";
                }
                return resultado;

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

        public Boolean GrabarDB_Periodos(List<Aca_Periodo_Info> Lst, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Context = new Entities_Academico())
                {
                    
                    foreach (var Item in Lst)
                    {
                        var que = from C in Context.Aca_periodo
                                  where C.IdPeriodo == Item.IdPeriodo
                                  select C;
                        if (que.Count() == 0)
                        {

                            Aca_periodo Periodo = new Aca_periodo();
                            Periodo.IdInstitucion = Item.IdInstitucion;
                            Periodo.IdPeriodo = Item.IdPeriodo;
                            Periodo.IdAnioLectivo = Item.IdAnioLectivo;
                            Periodo.pe_anio = Item.pe_anio;
                            Periodo.pe_mes = Item.pe_mes;
                            Periodo.pe_FechaIni = Item.pe_FechaIni;
                            Periodo.pe_FechaFin = Item.pe_FechaFin;
                            Periodo.pe_estado = Item.pe_estado;
                            Periodo.est_apertura = Item.est_apertura;

                            Context.Aca_periodo.Add(Periodo);
                            Context.SaveChanges();
                        }
                        else
                        {
                            mensaje = "Error en el ingreso; Periodo Existente";
                            return false;
                        }
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

        /// <summary>
        /// Prog: Pedro Salinas
        /// Creación: 03-02-2016
        /// </summary>
    }
}
