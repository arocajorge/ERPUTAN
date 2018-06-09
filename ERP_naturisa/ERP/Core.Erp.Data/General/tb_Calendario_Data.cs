using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;



namespace Core.Erp.Data.General
{
    public class tb_Calendario_Data
    {
        string mensaje="";
        public List<tb_Calendario_Info> Get_List_Calendario()
        {
        
                List<tb_Calendario_Info> Lst = new List<tb_Calendario_Info>();
                
            try
            {
               EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_Calendario
                            select q;
                foreach (var item in Query)
                {
                    tb_Calendario_Info Obj = new tb_Calendario_Info();
                    Obj.IdCalendario = item.IdCalendario;
                    Obj.fecha = item.fecha;
                    Obj.NombreFecha = item.NombreFecha;
                    Obj.NombreCortoFecha = item.NombreCortoFecha;
                    Obj.dia_x_semana = item.dia_x_semana;
                    Obj.dia_x_mes = item.dia_x_mes;
                    Obj.Inicial_del_Dia = item.Inicial_del_Dia;
                    Obj.NombreDia = item.NombreDia;
                    Obj.Mes_x_anio = item.Mes_x_anio;
                    Obj.NombreMes = item.NombreMes;
                    Obj.IdMes = item.IdMes;
                    Obj.NombreCortoMes = item.NombreCortoMes;
                    Obj.AnioFiscal = item.AnioFiscal;
                    Obj.Semana_x_anio = item.Semana_x_anio;
                    Obj.NombreSemana = item.NombreSemana;
                    Obj.IdSemana = item.IdSemana;
                    Obj.Trimestre_x_Anio = item.Trimestre_x_Anio;
                    Obj.NombreTrimestre = item.NombreTrimestre;
                    Obj.IdTrimestre = item.IdTrimestre;
                    Obj.IdPeriodo = item.IdPeriodo;
                    Obj.EsFeriado = item.EsFeriado;
                    Lst.Add(Obj);
                }
                return Lst;    
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_Calendario_Info> Get_List_Calendario_x_rango_fechas(DateTime Fecha_Ini, DateTime Fecha_Fin)
        {

            List<tb_Calendario_Info> Lst = new List<tb_Calendario_Info>();

            try
            {
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_Calendario
                            where Fecha_Ini<=q.fecha && q.fecha <= Fecha_Fin
                            select q;
                foreach (var item in Query)
                {
                    tb_Calendario_Info Obj = new tb_Calendario_Info();
                    Obj.IdCalendario = item.IdCalendario;
                    Obj.fecha = item.fecha;
                    Obj.NombreFecha = item.NombreFecha;
                    Obj.NombreCortoFecha = item.NombreCortoFecha;
                    Obj.dia_x_semana = item.dia_x_semana;
                    Obj.dia_x_mes = item.dia_x_mes;
                    Obj.Inicial_del_Dia = item.Inicial_del_Dia;
                    Obj.NombreDia = item.NombreDia;
                    Obj.Mes_x_anio = item.Mes_x_anio;
                    Obj.NombreMes = item.NombreMes;
                    Obj.IdMes = item.IdMes;
                    Obj.NombreCortoMes = item.NombreCortoMes;
                    Obj.AnioFiscal = item.AnioFiscal;
                    Obj.Semana_x_anio = item.Semana_x_anio;
                    Obj.NombreSemana = item.NombreSemana;
                    Obj.IdSemana = item.IdSemana;
                    Obj.Trimestre_x_Anio = item.Trimestre_x_Anio;
                    Obj.NombreTrimestre = item.NombreTrimestre;
                    Obj.IdTrimestre = item.IdTrimestre;
                    Obj.IdPeriodo = item.IdPeriodo;
                    Obj.EsFeriado = item.EsFeriado;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Calendario_Info Get_Info_Calendario(DateTime fecha)
        {
            fecha = Convert.ToDateTime(fecha.ToShortDateString());
            tb_Calendario_Info info = new tb_Calendario_Info();
            try
            {
                EntitiesGeneral oEnti = new EntitiesGeneral();
                tb_Calendario_Info Obj = new tb_Calendario_Info();
                var item = oEnti.tb_Calendario.FirstOrDefault(A => A.fecha == fecha);
                if (item != null)
                {
                    Obj.IdCalendario = item.IdCalendario;
                    Obj.fecha = item.fecha;
                    Obj.NombreFecha = item.NombreFecha;
                    Obj.NombreCortoFecha = item.NombreCortoFecha;
                    Obj.dia_x_semana = item.dia_x_semana;
                    Obj.dia_x_mes = item.dia_x_mes;
                    Obj.Inicial_del_Dia = item.Inicial_del_Dia;
                    Obj.NombreDia = item.NombreDia;
                    Obj.Mes_x_anio = item.Mes_x_anio;
                    Obj.NombreMes = item.NombreMes;
                    Obj.IdMes = item.IdMes;
                    Obj.NombreCortoMes = item.NombreCortoMes;
                    Obj.AnioFiscal = item.AnioFiscal;
                    Obj.Semana_x_anio = item.Semana_x_anio;
                    Obj.NombreSemana = item.NombreSemana;
                    Obj.IdSemana = item.IdSemana;
                    Obj.Trimestre_x_Anio = item.Trimestre_x_Anio;
                    Obj.NombreTrimestre = item.NombreTrimestre;
                    Obj.IdTrimestre = item.IdTrimestre;
                    Obj.IdPeriodo = item.IdPeriodo;
                    Obj.EsFeriado = item.EsFeriado;
                }
                return Obj;
            }
            catch (Exception ex ) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_Calendario_Info> Get_List_DiasSinFeriadoNiSabadosNiDomingos(DateTime FechaInicial, int CantidadDiasaObtener) 
        {

            try
            {
                List<tb_Calendario_Info> lst = new List<tb_Calendario_Info>();
                using (EntitiesGeneral Entity = new EntitiesGeneral())
                {
                    ObjectResult<spSys_ObtenerFecha_SinFeriadoTampocoSabDom_Result> consulta   = Entity.spSys_ObtenerFecha_SinFeriadoTampocoSabDom(FechaInicial, CantidadDiasaObtener) ;

                    

                    foreach (var item in consulta)
                    {
                        tb_Calendario_Info Obj = new tb_Calendario_Info();
                        Obj.IdCalendario = item.IdCalendario;
                        Obj.fecha = item.fecha;
                        Obj.NombreFecha = item.NombreFecha;
                        Obj.NombreCortoFecha = item.NombreCortoFecha;
                        Obj.dia_x_semana = item.dia_x_semana;
                        Obj.dia_x_mes = item.dia_x_mes;
                        Obj.Inicial_del_Dia = item.Inicial_del_Dia;
                        Obj.NombreDia = item.NombreDia;
                        Obj.Mes_x_anio = item.Mes_x_anio;
                        Obj.NombreMes = item.NombreMes;
                        Obj.IdMes = item.IdMes;
                        Obj.NombreCortoMes = item.NombreCortoMes;
                        Obj.AnioFiscal = item.AnioFiscal;
                        Obj.Semana_x_anio = item.Semana_x_anio;
                        Obj.NombreSemana = item.NombreSemana;
                        Obj.IdSemana = item.IdSemana;
                        Obj.Trimestre_x_Anio = item.Trimestre_x_Anio;
                        Obj.NombreTrimestre = item.NombreTrimestre;
                        Obj.IdTrimestre = item.IdTrimestre;
                        Obj.IdPeriodo = item.IdPeriodo;
                        Obj.EsFeriado = item.EsFeriado;
                        lst.Add(Obj);
                    }
                    
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_Calendario_Info> Get_List_Calendario_Feriado()
        {
            try
            {
                List<tb_Calendario_Info> Lst = new List<tb_Calendario_Info>();
                using (EntitiesGeneral dbGeneral = new EntitiesGeneral())
                {
                    var Fer = from q in dbGeneral.tb_Calendario
                              where q.EsFeriado == "S"
                              orderby q.IdCalendario ascending
                              select q;
                    foreach (var item in Fer)
                    {
                        tb_Calendario_Info Obj = new tb_Calendario_Info();
                        Obj.IdCalendario = item.IdCalendario;
                        Obj.fecha = item.fecha;
                        Obj.NombreFecha = item.NombreFecha;
                        Obj.NombreCortoFecha = item.NombreCortoFecha;
                        Obj.dia_x_semana = item.dia_x_semana;
                        Obj.dia_x_mes = item.dia_x_mes;
                        Obj.Inicial_del_Dia = item.Inicial_del_Dia;
                        Obj.NombreDia = item.NombreDia;
                        Obj.Mes_x_anio = item.Mes_x_anio;
                        Obj.NombreMes = item.NombreMes;
                        Obj.IdMes = item.IdMes;
                        Obj.NombreCortoMes = item.NombreCortoMes;
                        Obj.AnioFiscal = item.AnioFiscal;
                        Obj.Semana_x_anio = item.Semana_x_anio;
                        Obj.NombreSemana = item.NombreSemana;
                        Obj.IdSemana = item.IdSemana;
                        Obj.Trimestre_x_Anio = item.Trimestre_x_Anio;
                        Obj.NombreTrimestre = item.NombreTrimestre;
                        Obj.IdTrimestre = item.IdTrimestre;
                        Obj.IdPeriodo = item.IdPeriodo;
                        Obj.EsFeriado = item.EsFeriado;
                        Obj.Descripcion = item.Descripcion;
                        Lst.Add(Obj);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public int ConsultaMaxMin(int i) {
            try
            {
                int a = 0;
                using (EntitiesGeneral Gene = new EntitiesGeneral())
                {
                    if (i ==1)
                    {
                        tb_Calendario_Info info = new tb_Calendario_Info();
                        var Numero1 = (from q in Gene.tb_Calendario
                                       select q.AnioFiscal).Max();
                        a = Convert.ToInt32(Numero1);
                    }
                    else
                    {
                        var Numero2 = (from q in Gene.tb_Calendario
                                       select q.AnioFiscal).Min();
                        a = Convert.ToInt32(Numero2);
                    }                                                       
                }
                return a;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_Calendario_Info> Get_List_Calendario_Feriado_x_anio(int anio) {
            try
            {
                using (EntitiesGeneral Gene = new EntitiesGeneral())
                {
                    List<tb_Calendario_Info> Lst = new List<tb_Calendario_Info>();
                    var Cons = from q in Gene.tb_Calendario
                               where q.AnioFiscal == anio && q.EsFeriado == "S"
                               select q;
                    foreach (var item in Cons)
                    {
                        tb_Calendario_Info Obj = new tb_Calendario_Info();
                        Obj.IdCalendario = item.IdCalendario;
                        Obj.fecha = item.fecha;
                        Obj.NombreFecha = item.NombreFecha;
                        Obj.NombreCortoFecha = item.NombreCortoFecha;
                        Obj.dia_x_semana = item.dia_x_semana;
                        Obj.dia_x_mes = item.dia_x_mes;
                        Obj.Inicial_del_Dia = item.Inicial_del_Dia;
                        Obj.NombreDia = item.NombreDia;
                        Obj.Mes_x_anio = item.Mes_x_anio;
                        Obj.NombreMes = item.NombreMes;
                        Obj.IdMes = item.IdMes;
                        Obj.NombreCortoMes = item.NombreCortoMes;
                        Obj.AnioFiscal = item.AnioFiscal;
                        Obj.Semana_x_anio = item.Semana_x_anio;
                        Obj.NombreSemana = item.NombreSemana;
                        Obj.IdSemana = item.IdSemana;
                        Obj.Trimestre_x_Anio = item.Trimestre_x_Anio;
                        Obj.NombreTrimestre = item.NombreTrimestre;
                        Obj.IdTrimestre = item.IdTrimestre;
                        Obj.IdPeriodo = item.IdPeriodo;
                        Obj.EsFeriado = item.EsFeriado;
                        Obj.Descripcion = item.Descripcion;
                        Lst.Add(Obj);
                    }
                    return Lst;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
       
        
        public Boolean Get_Existe_IdCalendario(int IdCalendario) {

            bool a = false; 
            try
            {               
                using (EntitiesGeneral dbGeneral = new EntitiesGeneral())
                {
                    var Fer = from q in dbGeneral.tb_Calendario                             
                              select q;
                    foreach (var item in Fer)
                    {                                               
                        if (IdCalendario == item.IdCalendario) {
                            a = true;
                        }
                    }
                }
                return a;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Get_ExisteFeriado(int IdCalendario)
        {
            bool b = false;
            try
            {
               
                using (EntitiesGeneral dbGeneral = new EntitiesGeneral())
                {
                    var Fer = from q in dbGeneral.tb_Calendario
                              select q;
                    foreach (var item in Fer)
                    {
                        if (IdCalendario == item.IdCalendario && item.EsFeriado == "N")
                        {
                            b = true;
                        }
                    }
                }
                return b;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(tb_Calendario_Info info)
        {
            try
            {
                using (EntitiesGeneral dbGene = new EntitiesGeneral())
                {
                    tb_Calendario Calendario = new tb_Calendario();
                    Calendario.IdCalendario = info.IdCalendario;
                    Calendario.fecha = info.fecha;
                    Calendario.NombreFecha = info.NombreFecha;
                    Calendario.NombreCortoFecha = info.NombreCortoFecha;
                    Calendario.dia_x_semana = info.dia_x_semana;
                    Calendario.dia_x_mes = info.dia_x_mes;
                    Calendario.Inicial_del_Dia = info.Inicial_del_Dia;
                    Calendario.NombreDia = info.NombreDia;
                    Calendario.Mes_x_anio = info.Mes_x_anio;
                    Calendario.NombreMes = info.NombreMes;
                    Calendario.IdMes = info.IdMes;
                    Calendario.NombreCortoMes = info.NombreCortoMes;
                    Calendario.AnioFiscal = info.AnioFiscal;
                    Calendario.Semana_x_anio = info.Semana_x_anio;
                    Calendario.NombreSemana = info.NombreSemana;
                    Calendario.IdSemana = info.IdSemana;
                    Calendario.Trimestre_x_Anio = info.Trimestre_x_Anio;
                    Calendario.NombreTrimestre = info.NombreTrimestre;
                    Calendario.IdTrimestre = info.IdTrimestre;
                    Calendario.IdPeriodo = info.IdPeriodo;
                    Calendario.EsFeriado = info.EsFeriado;
                    Calendario.Descripcion = info.Descripcion;

                    dbGene.tb_Calendario.Add(Calendario);
                    dbGene.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_Calendario_Info info)
        {
            try
            {
                if (EliminarDB(info)==true)
                {                   
                    GrabarDB(info);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(tb_Calendario_Info info)
        {
            try
            {
                using (EntitiesGeneral dbGene = new EntitiesGeneral())
                {
                    tb_Calendario Calendario = dbGene.tb_Calendario.FirstOrDefault(v => v.IdCalendario == info.IdCalendario);
                    if (Calendario != null)
                    {
                        dbGene.tb_Calendario.Remove(Calendario);
                        dbGene.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(tb_Calendario_Info info) {
            try
            {
                if (EliminarDB(info) == true)
                {
                    using (EntitiesGeneral dbGene = new EntitiesGeneral())
                    {
                        tb_Calendario Calendario = new tb_Calendario();
                        Calendario.IdCalendario = info.IdCalendario;
                        Calendario.fecha = info.fecha;
                        Calendario.NombreFecha = info.NombreFecha;
                        Calendario.NombreCortoFecha = info.NombreCortoFecha;
                        Calendario.dia_x_semana = info.dia_x_semana;
                        Calendario.dia_x_mes = info.dia_x_mes;
                        Calendario.Inicial_del_Dia = info.Inicial_del_Dia;
                        Calendario.NombreDia = info.NombreDia;
                        Calendario.Mes_x_anio = info.Mes_x_anio;
                        Calendario.NombreMes = info.NombreMes;
                        Calendario.IdMes = info.IdMes;
                        Calendario.NombreCortoMes = info.NombreCortoMes;
                        Calendario.AnioFiscal = info.AnioFiscal;
                        Calendario.Semana_x_anio = info.Semana_x_anio;
                        Calendario.NombreSemana = info.NombreSemana;
                        Calendario.IdSemana = info.IdSemana;
                        Calendario.Trimestre_x_Anio = info.Trimestre_x_Anio;
                        Calendario.NombreTrimestre = info.NombreTrimestre;
                        Calendario.IdTrimestre = info.IdTrimestre;
                        Calendario.IdPeriodo = info.IdPeriodo;
                        Calendario.EsFeriado = "N";

                        dbGene.tb_Calendario.Add(Calendario);
                        dbGene.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarFeriadoDescripcion(List<tb_Calendario_Info> info) {
            try
            {
                using(EntitiesGeneral Gene = new EntitiesGeneral())
	            {
		           foreach (var item in info)
                        {
                            var encontro = from q in Gene.tb_Calendario
                                           where q.IdCalendario ==item.IdCalendario && q.EsFeriado == item.EsFeriado
                                           select q;
                            int j = 0;   
                            foreach (var i in encontro)
                            {
                                j = i.IdCalendario;
                            }
                            if (j != 0)
                            {
                                tb_Calendario_Info Calendario = new tb_Calendario_Info();
                                Calendario.IdCalendario = item.IdCalendario;
                                Calendario.fecha = item.fecha;
                                Calendario.NombreFecha = item.NombreFecha;
                                Calendario.NombreCortoFecha = item.NombreCortoFecha;
                                Calendario.dia_x_semana = item.dia_x_semana;
                                Calendario.dia_x_mes = item.dia_x_mes;
                                Calendario.Inicial_del_Dia = item.Inicial_del_Dia;
                                Calendario.NombreDia = item.NombreDia;
                                Calendario.Mes_x_anio = item.Mes_x_anio;
                                Calendario.NombreMes = item.NombreMes;
                                Calendario.IdMes = item.IdMes;
                                Calendario.NombreCortoMes = item.NombreCortoMes;
                                Calendario.AnioFiscal = item.AnioFiscal;
                                Calendario.Semana_x_anio = item.Semana_x_anio;
                                Calendario.NombreSemana = item.NombreSemana;
                                Calendario.IdSemana = item.IdSemana;
                                Calendario.Trimestre_x_Anio = item.Trimestre_x_Anio;
                                Calendario.NombreTrimestre = item.NombreTrimestre;
                                Calendario.IdTrimestre = item.IdTrimestre;
                                Calendario.IdPeriodo = item.IdPeriodo;
                                //Calendario.EsFeriado = item.EsFeriado;
                                Calendario.EsFeriado = "S";
                                Calendario.Descripcion = item.Descripcion;

                                EliminarDB(Calendario);                                
                                GrabarDB(Calendario);                                
                            }                    
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public List<tb_Calendario_Info> Get_List_Calendario_Agrupado_x_anio() {
            try
            {
                List<tb_Calendario_Info> Lst = new List<tb_Calendario_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_Calendario
                            group q by new
                            {                                
                                q.AnioFiscal
                            }
                                into g
                                orderby g.Key.AnioFiscal ascending
                                select new { AnioFiscal = g.Key.AnioFiscal };
                foreach (var item in Query)
                {
                    tb_Calendario_Info Obj = new tb_Calendario_Info();                   
                    Obj.AnioFiscal = item.AnioFiscal;                    
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
