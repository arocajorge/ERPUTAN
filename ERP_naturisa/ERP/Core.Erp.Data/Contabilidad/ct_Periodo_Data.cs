using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Contabilidad
{
    public class ct_Periodo_Data
    {

        string mensaje = "";
       
        public ct_Periodo_Info Get_Info_PeriodoAnterior(int IdEmpresa, int IdPeriodoActual,ref string MensajeError)
        {
            try
            {
                ct_Periodo_Info Cbt = new ct_Periodo_Info();

                using (EntitiesDBConta entity = new EntitiesDBConta())
                {

                    var selectPeriodo = from per in entity.vwct_periodo
                                        where per.IdPeriodo < IdPeriodoActual
                                        && per.IdEmpresa == IdEmpresa
                                        orderby per.IdPeriodo descending
                                        select per;


                    foreach (var item in selectPeriodo)
                    {

                        Cbt.IdEmpresa = item.IdEmpresa;
                        Cbt.IdPeriodo = item.IdPeriodo;
                        Cbt.IdanioFiscal = item.IdanioFiscal;
                        Cbt.pe_mes = item.pe_mes;
                        Cbt.pe_FechaIni = item.pe_FechaIni;
                        Cbt.pe_FechaFin = item.pe_FechaFin;
                        Cbt.pe_cerrado = item.pe_cerrado;
                        Cbt.pe_estado = item.pe_estado;
                        Cbt.nom_periodo = item.smes +" - "+ item.IdanioFiscal.ToString();
                        break;
                    }

                }

                return (Cbt);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Periodo_Info> Get_List_Periodo(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                List<ct_Periodo_Info> lM = new List<ct_Periodo_Info>();
                EntitiesDBConta OEPeriodo = new EntitiesDBConta();
                var selectPeriodo = from C in OEPeriodo.vwct_periodo
                                          where C.IdEmpresa == IdEmpresa
                                       select C;
                foreach (var item in selectPeriodo)
                {
                    ct_Periodo_Info Cbt = new ct_Periodo_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.nom_periodo = item.smes + " - " + item.IdanioFiscal.ToString();
                    Cbt.IdanioFiscal = item.IdanioFiscal;
                    Cbt.pe_mes = item.pe_mes;
                    Cbt.pe_FechaIni = item.pe_FechaIni;
                    Cbt.pe_FechaFin = item.pe_FechaFin;
                    Cbt.pe_cerrado = item.pe_cerrado;
                    Cbt.pe_estado = item.pe_estado;
                    Cbt.smes = item.smes;
                    lM.Add(Cbt);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public ct_Periodo_Info Get_Info_Periodo(int IdEmpresa, DateTime fecha, ref string MensajeError)
        {
            try
            {
               string  fechas ;
               fechas = fecha.ToShortDateString();
               DateTime fechaI;
               fechaI = Convert.ToDateTime(fechas);

               ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();


                EntitiesDBConta OEPeriodo = new EntitiesDBConta();
                var selectPeriodo = from C in OEPeriodo.ct_periodo
                                    where C.IdEmpresa == IdEmpresa && (C.pe_FechaIni <= fechaI && C.pe_FechaFin >= fechaI)
                                    select C;
                if (selectPeriodo.ToList().Count > 0)
                {
                    foreach (var item in selectPeriodo)
                    {
                        _PeriodoInfo.IdEmpresa = item.IdEmpresa;
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.IdanioFiscal = item.IdanioFiscal;
                        _PeriodoInfo.pe_mes = item.pe_mes;
                        _PeriodoInfo.pe_cerrado = item.pe_cerrado;
                        _PeriodoInfo.pe_estado = item.pe_estado;
                        _PeriodoInfo.pe_FechaFin = item.pe_FechaFin;
                        _PeriodoInfo.pe_FechaIni = item.pe_FechaIni;
                    }
                    return _PeriodoInfo;
                }
                else
                    return new ct_Periodo_Info();               
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Periodo_Info Get_Info_Periodo(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {

                ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();


                EntitiesDBConta OEPeriodo = new EntitiesDBConta();
                var selectPeriodo = from C in OEPeriodo.vwct_periodo
                                    where C.IdEmpresa == IdEmpresa
                                    && C.IdPeriodo == IdPeriodo
                                    select C;
                if (selectPeriodo.ToList().Count > 0)
                {
                    foreach (var item in selectPeriodo)
                    {
                        _PeriodoInfo.IdEmpresa = item.IdEmpresa;
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.IdanioFiscal = item.IdanioFiscal;
                        _PeriodoInfo.pe_mes = item.pe_mes;
                        _PeriodoInfo.pe_cerrado = item.pe_cerrado;
                        _PeriodoInfo.pe_estado = item.pe_estado;
                        _PeriodoInfo.pe_FechaFin = item.pe_FechaFin;
                        _PeriodoInfo.pe_FechaIni = item.pe_FechaIni;
                        _PeriodoInfo.nom_periodo = item.smes + " - " + item.IdanioFiscal.ToString();
                    }
                    return _PeriodoInfo;
                }
                else
                    return new ct_Periodo_Info();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Periodo_Info Get_Info_Ultimo_periodo_mayorizado(int IdEmpresa, ref string MensajeError)
        {
            try
            {

                ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();

                ct_Periodo_Info PeriodoAnterior = new ct_Periodo_Info();



                EntitiesDBConta OEPeriodo = new EntitiesDBConta();
                var selectPeriodo = from C in OEPeriodo.ct_periodo
                                    where C.IdEmpresa == IdEmpresa
                                    orderby C.IdEmpresa,C.IdPeriodo descending
                                    select C ;
                                    
                if (selectPeriodo.ToList().Count > 0)
                {
                    foreach (var item in selectPeriodo)
                    {
                        if (_PeriodoInfo.pe_cerrado == "N")
                        {

                            if (PeriodoAnterior.IdEmpresa > 0)
                            {
                                _PeriodoInfo.IdEmpresa = PeriodoAnterior.IdEmpresa;
                                _PeriodoInfo.IdPeriodo = PeriodoAnterior.IdPeriodo;
                                _PeriodoInfo.IdanioFiscal = PeriodoAnterior.IdanioFiscal;
                                _PeriodoInfo.pe_mes = PeriodoAnterior.pe_mes;
                                _PeriodoInfo.pe_cerrado = PeriodoAnterior.pe_cerrado;
                                _PeriodoInfo.pe_estado = PeriodoAnterior.pe_estado;
                                _PeriodoInfo.pe_FechaFin = PeriodoAnterior.pe_FechaFin;
                                _PeriodoInfo.pe_FechaIni = PeriodoAnterior.pe_FechaIni;
                            }
                            else
                            {
                                _PeriodoInfo.IdEmpresa = item.IdEmpresa;
                                _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                                _PeriodoInfo.IdanioFiscal = item.IdanioFiscal;
                                _PeriodoInfo.pe_mes = item.pe_mes;
                                _PeriodoInfo.pe_cerrado = item.pe_cerrado;
                                _PeriodoInfo.pe_estado = item.pe_estado;
                                _PeriodoInfo.pe_FechaFin = item.pe_FechaFin;
                                _PeriodoInfo.pe_FechaIni = item.pe_FechaIni;
                            }



                            break;
                        }


                        PeriodoAnterior = new ct_Periodo_Info();
                        PeriodoAnterior.IdEmpresa = item.IdEmpresa;
                        PeriodoAnterior.IdPeriodo = item.IdPeriodo;
                        PeriodoAnterior.IdanioFiscal = item.IdanioFiscal;
                        PeriodoAnterior.pe_mes = item.pe_mes;
                        PeriodoAnterior.pe_cerrado = item.pe_cerrado;
                        PeriodoAnterior.pe_estado = item.pe_estado;
                        PeriodoAnterior.pe_FechaFin = item.pe_FechaFin;
                        PeriodoAnterior.pe_FechaIni = item.pe_FechaIni;
                        
                    }
                    return _PeriodoInfo;
                }
                else
                    return new ct_Periodo_Info();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Periodo_Esta_Cerrado(int IdEmpresa, DateTime fecha, ref string MensajeError)
        {
           try 
	        {	 
                EntitiesDBConta reg = new EntitiesDBConta();
                var q = from Periodo in reg.ct_periodo
                        where Periodo.IdEmpresa == IdEmpresa && (Periodo.pe_FechaIni<= fecha && Periodo.pe_FechaFin>= fecha ) 
                        && Periodo.pe_cerrado == "S"
                        select Periodo;

                return (q.ToList().Count > 0) ? true : false;  
	        }
	        catch (Exception ex)
	        {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
	        }
        }

        public Boolean ModificarDB(ct_Periodo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_periodo.FirstOrDefault(minfo => minfo.IdPeriodo== info.IdPeriodo && minfo.IdEmpresa==info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdPeriodo = info.IdPeriodo;
                        contact.IdanioFiscal = info.IdanioFiscal;
                        contact.pe_mes = Convert.ToByte(info.pe_mes);
                        contact.pe_FechaIni = info.pe_FechaIni;
                        contact.pe_FechaFin = info.pe_FechaFin;
                        contact.pe_estado = info.pe_estado;
                        contact.pe_cerrado = info.pe_cerrado;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_CierreDB(int IdEmpresa, int IdPeriodo,string sCerrado,ref string MensajeError)
        {
            try
            {
                
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_periodo.FirstOrDefault(minfo => minfo.IdPeriodo == IdPeriodo && minfo.IdEmpresa == IdEmpresa);
                    if (contact != null)
                    {
                        contact.pe_cerrado = sCerrado;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(ct_Periodo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_periodo
                            where per.IdPeriodo == info.IdPeriodo && per.IdEmpresa==info.IdEmpresa
                            select per;

                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_periodo();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdPeriodo = Convert.ToInt32( info.IdPeriodo);
                        address.IdanioFiscal =Convert.ToInt32( info.IdanioFiscal);
                        address.pe_mes = Convert.ToByte(info.pe_mes);
                        address.pe_FechaIni =Convert.ToDateTime( info.pe_FechaIni.ToShortDateString());
                        address.pe_FechaFin = Convert.ToDateTime( info.pe_FechaFin.ToShortDateString());
                        address.pe_estado = info.pe_estado;
                        address.pe_cerrado = info.pe_cerrado;
                        context.ct_periodo.Add(address);
                        context.SaveChanges();
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(ct_Periodo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_periodo.FirstOrDefault(dinfo => dinfo.IdPeriodo== info.IdPeriodo);

                    if (contact != null)
                    {
                        contact.pe_estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Periodo_Data()
        {
            
        }
    }
}

