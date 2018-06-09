
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using System.Data.OleDb;
namespace Core.Erp.Data.Roles
{
    public class ro_marcaciones_x_empleado_Data
    {
        string mensaje = "";
        
        public List<ro_marcaciones_x_empleado_Info> ProcesarDataTableAInfo_x_TipEquipo(DataTable ds, int tipo, int IdEmpresa, ref string msg)
        {
            List<ro_marcaciones_x_empleado_Info> lista = new List<ro_marcaciones_x_empleado_Info>();

            try
            {

                ro_Empleado_Data dataEmp = new ro_Empleado_Data();
                ro_marcaciones_Equipo_x_TipoMarcacion_Data dataM = new ro_marcaciones_Equipo_x_TipoMarcacion_Data();
                var lstTodosEmp = dataEmp.Get_List_Empleado_(IdEmpresa);
                var lstTipMar_x_Eq = dataM.Get_List_marcaciones_Equipo_x_TipoMarcacion(tipo);

                if (tipo == 1)
                {
                    if (ds.Columns.Count > 3)
                    {

                        foreach (DataRow row in ds.Rows)
                        {
                            ro_marcaciones_x_empleado_Info info = new ro_marcaciones_x_empleado_Info();
                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0:
                                        string codigo = Convert.ToString(row[col]);
                                        ro_Empleado_Info emp = new ro_Empleado_Info();
                                        try
                                        {
                                            emp = lstTodosEmp.First(var => var.Codigo_Biometrico == codigo);
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                        }                                       

                                        if (emp.IdEmpleado != 0)
                                        {
                                            info.IdEmpleado = emp.IdEmpleado;
                                            info.NomCompleto = emp.InfoPersona.pe_nombreCompleto;
                                            info.Codigo_Biometrico = codigo;
                                            info.em_codigo = emp.em_codigo;
                                            info.existeerror = "N";
                                        }
                                        else
                                        {
                                            info.Codigo_Biometrico = codigo;
                                            info.IdEmpleado = 0;
                                            info.NomCompleto = "Empleado no existe en la Base.";
                                            info.em_codigo = "Verifique por favor.";
                                            info.existeerror = "FEmp,";
                                        }
                                        break;
                                    case 1:
                                        string fecha = Convert.ToString(row[col]);
                                        DateTime dt ;

                                        if (DateTime.TryParse(fecha, out dt))
                                        {
                                            info.es_fechaRegistro = Convert.ToDateTime(fecha);
                                        }
                                        else { info.es_fechaRegistro = dt; 
                                            info.existeerror = info.existeerror + "FFec,"; }

                                        break;
                                    case 2:
                                        string hora = Convert.ToString(row[col]);
                                        DateTime ho = DateTime.Now;
                                        TimeSpan horaa;
                                        try
                                        {
                                            ho = Convert.ToDateTime(hora);
                                            horaa = ho.TimeOfDay;
                                            info.es_Hora = horaa;
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                            info.es_Hora = TimeSpan.Zero;
                                            info.existeerror = info.existeerror + "FHor,";
                                        }
                                        break;
                                    case 3:
                                        string tipomarc = Convert.ToString(row[col]);

                                        try
                                        {
                                            info.IdTipoMarcaciones = lstTipMar_x_Eq.First(var => var.IdTipoMarcaciones_Biometrico == tipomarc).IdTipoMarcaciones_sys;

                                            if (tipomarc == "C/In" || tipomarc == "C/Out")
                                            {
                                                info.IdTipoMarcaciones_Biometrico = tipomarc;

                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                             info.IdTipoMarcaciones = "";
                                            info.existeerror = info.existeerror + "FTip";
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            lista.Add(info);
                        }                       
                    }
                    else
                    {
                        msg = "Por favor verifique que el archivo tenga el formato correcto.\r Son 5 columnas.";
                     
                        lista = new List<ro_marcaciones_x_empleado_Info>();
                    
                    }
                }
                if (tipo == 2)
                    {
                    if (ds.Columns.Count >=4)
                    {

                        foreach (DataRow row in ds.Rows)
                        {
                            ro_marcaciones_x_empleado_Info Marca_Entrada = new ro_marcaciones_x_empleado_Info();
                            ro_marcaciones_x_empleado_Info Marca_Salida= new ro_marcaciones_x_empleado_Info();

                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0: 
                                        string codigo = Convert.ToString(row[col]);
                                        ro_Empleado_Info emp = new ro_Empleado_Info();
                                        try
                                        {
                                            emp = lstTodosEmp.First(var => var.Codigo_Biometrico == codigo);
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                        }                                       

                                        if (emp.IdEmpleado != 0)
                                        {
                                            Marca_Entrada.IdEmpleado = emp.IdEmpleado;
                                            Marca_Entrada.NomCompleto = emp.InfoPersona.pe_nombreCompleto;
                                            Marca_Entrada.Codigo_Biometrico = codigo;
                                            Marca_Entrada.em_codigo = emp.em_codigo;
                                            Marca_Entrada.existeerror = "N";


                                            Marca_Salida.IdEmpleado = emp.IdEmpleado;
                                            Marca_Salida.NomCompleto = emp.InfoPersona.pe_nombreCompleto;
                                            Marca_Salida.Codigo_Biometrico = codigo;
                                            Marca_Salida.em_codigo = emp.em_codigo;
                                            Marca_Salida.existeerror = "N";
                                        }
                                        else
                                        {
                                            Marca_Entrada.Codigo_Biometrico = codigo;
                                            Marca_Entrada.IdEmpleado = 0;
                                            Marca_Entrada.NomCompleto = "Empleado no existe en la Base.";
                                            Marca_Entrada.em_codigo = "Verifique por favor.";
                                            Marca_Entrada.existeerror = "FEmp,";


                                            Marca_Salida.Codigo_Biometrico = codigo;
                                            Marca_Salida.IdEmpleado = 0;
                                            Marca_Salida.NomCompleto = "Empleado no existe en la Base.";
                                            Marca_Salida.em_codigo = "Verifique por favor.";
                                            Marca_Salida.existeerror = "FEmp,";
                                        }
                                        break;
                                    case 1:                                  

                                        break;
                                         case 2: 
                                        string fecha = Convert.ToString(row[col]);
                                         DateTime dt ;

                                        if (DateTime.TryParse(fecha, out dt))
                                        {
                                            Marca_Entrada.es_fechaRegistro = Convert.ToDateTime(fecha);
                                            Marca_Salida.es_fechaRegistro = Convert.ToDateTime(fecha);
                                        }
                                        else 
                                        { 
                                             Marca_Entrada.es_fechaRegistro = dt;
                                             Marca_Salida.es_fechaRegistro = dt;
                                            Marca_Entrada.existeerror = Marca_Entrada.existeerror + "FFec,"; 
                                            Marca_Salida.existeerror = Marca_Salida.existeerror + "FFec,"; 
                                        }

                                        break;
                                    case 3:   
                                        string horaE = Convert.ToString(row[col]);
                                        DateTime hoE = DateTime.Now;
                                        TimeSpan horaaE;
                                        try
                                        {
                                            hoE = Convert.ToDateTime(horaE);
                                            horaaE = hoE.TimeOfDay;
                                             Marca_Entrada.es_Hora = horaaE;
                                             Marca_Entrada.IdTipoMarcaciones = "IN";
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                            Marca_Entrada.es_Hora = TimeSpan.Zero;
                                            Marca_Entrada.existeerror = Marca_Entrada.existeerror + "FHor,";
                                        }
                                        break;
                                    case 4: 
                                       
                                         string horaS = Convert.ToString(row[col]);
                                        DateTime hoS = DateTime.Now;
                                        TimeSpan horaaS;
                                        try
                                        {
                                            hoS = Convert.ToDateTime(horaS);
                                            horaaS = hoS.TimeOfDay;
                                             Marca_Salida.es_Hora = horaaS;
                                             Marca_Salida.IdTipoMarcaciones = "OUT";
                                             
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                            Marca_Salida.es_Hora = TimeSpan.Zero;
                                            Marca_Salida.existeerror = Marca_Entrada.existeerror + "FHor,";
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            lista.Add(Marca_Entrada);
                            lista.Add(Marca_Salida);
                        }
                    }
                    else
                    {
                        msg = "Por favor verifique que el archivo tenga el formato correcto.\r Son 4 columnas.";
                        lista = new List<ro_marcaciones_x_empleado_Info>();
                    }
                    }
                if (tipo == 3)
                {
                    if (ds.Columns.Count > 6)
                    {

                        foreach (DataRow row in ds.Rows)
                        {
                            ro_marcaciones_x_empleado_Info info = new ro_marcaciones_x_empleado_Info();
                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0:
                                        string codigo = Convert.ToString(row[col]);
                                        ro_Empleado_Info emp = new ro_Empleado_Info();
                                        try
                                        {
                                            emp = lstTodosEmp.First(var => var.Codigo_Biometrico == codigo);
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                        }

                                        if (emp.IdEmpleado != 0)
                                        {
                                            info.IdEmpleado = emp.IdEmpleado;
                                            info.NomCompleto = emp.InfoPersona.pe_nombreCompleto;
                                            info.Codigo_Biometrico = codigo;
                                            info.em_codigo = emp.em_codigo;
                                            info.existeerror = "N";
                                        }
                                        else
                                        {
                                            info.Codigo_Biometrico = codigo;
                                            info.IdEmpleado = 0;
                                            info.NomCompleto = "Empleado no existe en la Base.";
                                            info.em_codigo = "Verifique por favor.";
                                            info.existeerror = "FEmp,";
                                        }
                                        break;
                                    case 5:
                                        string fecha = Convert.ToString(row[col]);
                                        DateTime dt;

                                        if (DateTime.TryParse(fecha, out dt))
                                        {
                                            info.es_fechaRegistro = Convert.ToDateTime(fecha);
                                        }
                                        else
                                        {
                                            info.es_fechaRegistro = dt;
                                            info.existeerror = info.existeerror + "FFec,";
                                        }

                                        break;
                                    case 4:
                                        string hora = Convert.ToString(row[col]);
                                        DateTime ho = DateTime.Now;
                                        TimeSpan horaa;
                                        try
                                        {
                                            ho = Convert.ToDateTime(hora);
                                            horaa = ho.TimeOfDay;
                                            info.es_Hora = horaa;
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                            info.es_Hora = TimeSpan.Zero;
                                            info.existeerror = info.existeerror + "FHor,";
                                        }
                                        break;

                                    case 6:
                                        string tipomarc = Convert.ToString(row[col]);

                                        try
                                        {
                                            info.IdTipoMarcaciones = lstTipMar_x_Eq.First(var => var.IdTipoMarcaciones_Biometrico == tipomarc).IdTipoMarcaciones_sys;

                                            if (tipomarc == "M/Ent" || tipomarc == "M/Sal")
                                            {
                                                info.IdTipoMarcaciones_Biometrico = tipomarc;

                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            string arreglo = ToString();
                                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                            mensaje = ex.InnerException + " " + ex.Message;
                                            info.IdTipoMarcaciones = "";
                                            info.existeerror = info.existeerror + "FTip";
                                        }             
                                        break;
                                    default:
                                        break;
                                }
                            }
                            lista.Add(info);
                        }                    
                    }
                    else
                    {
                        msg = "Por favor verifique que el archivo tenga el formato correcto.\r Son 7 columnas.";
                        lista = new List<ro_marcaciones_x_empleado_Info>();
                    }
                }       
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                lista = new List<ro_marcaciones_x_empleado_Info>();
            }
            return lista;
        }

        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado(List<ro_marcaciones_x_empleado_Info> Listado)
        {
            List<ro_marcaciones_x_empleado_Info> resultado = new List<ro_marcaciones_x_empleado_Info>();
            ro_marcaciones_x_empleado_Info temp = new ro_marcaciones_x_empleado_Info();
            try
            {
                foreach (var item in Listado)
                {
                    temp = new ro_marcaciones_x_empleado_Info();
                }
                resultado = Listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                resultado = new List<ro_marcaciones_x_empleado_Info>();

            } return resultado; 
        
        }

        public ro_marcaciones_x_empleado_Info Get_Info_marcaciones_x_empleado(int IdEmpresa, decimal IdEmpleado, string IdTipoMar, DateTime Fecha)
        {
           ro_marcaciones_x_empleado_Info resultado = new ro_marcaciones_x_empleado_Info();
            try
            {
                EntitiesRoles oEnt = new EntitiesRoles();
                DateTime fecha = Convert.ToDateTime(Fecha.ToShortDateString());
                DateTime fechafin = fecha.AddDays(1);
                var resul = oEnt.ro_marcaciones_x_empleado.First(var => var.IdTipoMarcaciones == IdTipoMar
                    && var.IdEmpresa == IdEmpresa && var.IdEmpleado == IdEmpleado 
                    && (var.es_fechaRegistro< fechafin && var.es_fechaRegistro >= fecha));
                if (resul != null)
                {
                    resultado.IdEmpresa = resul.IdEmpresa;
                    resultado.IdEmpleado = resul.IdEmpleado;
                    resultado.IdTipoMarcaciones = resul.IdTipoMarcaciones;
                    resultado.es_Hora  =  (resul.es_Hora== null)?TimeSpan.Zero:(TimeSpan)resul.es_Hora;
                
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                resultado  = new ro_marcaciones_x_empleado_Info();

            } return resultado; 
        
        }
    

        public Boolean GrabarDB(List<ro_marcaciones_x_empleado_Info> ListaGrabar,int IdEmpresa,int IdPeriodo)          
        {
            bool resultado = false;
            ro_marcaciones_Equipo_Info info = new ro_marcaciones_Equipo_Info();
            List<ro_marcaciones_x_empleado> lista_add = new List<ro_marcaciones_x_empleado>();
            try
            {
                int sec = 0;
                using (EntitiesRoles oEnt1 = new EntitiesRoles())
                {

                    EntitiesRoles oEnt = new EntitiesRoles();

                    foreach (var item in ListaGrabar)
                    {
                        DateTime fecha =Convert.ToDateTime( item.es_fechaRegistro);
                        sec = sec + 1;
                        //Console.WriteLine(c);
                        ro_marcaciones_x_empleado Info = new ro_marcaciones_x_empleado();

                        Info.IdEmpresa = Convert.ToByte(item.IdEmpresa);
                        Info.IdRegistro = fecha.Day.ToString().PadLeft(2, '0') + "-" + fecha.Month.ToString().PadLeft(2, '0') + "-" + fecha.Year + "-" + item.IdTipoMarcaciones + "-" + item.IdEmpleado ;
                        Info.IdEmpleado = item.IdEmpleado;
                        Info.IdPeriodo = IdPeriodo;
                        Info.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        Info.secuencia = GetId(item.IdEmpresa, item.IdEmpleado, item.IdTipoMarcaciones);
                        Info.es_Hora = item.es_Hora;
                        Info.es_fechaRegistro = item.es_fechaRegistro;
                        Info.es_anio = item.es_anio;
                        Info.es_mes = Convert.ToByte(item.es_mes);
                        Info.es_semana = Convert.ToByte(item.es_semana);
                        Info.es_dia = Convert.ToByte(item.es_dia);
                        Info.es_sdia = item.es_sdia;
                        Info.es_idDia = Convert.ToByte(item.es_idDia);
                        Info.es_EsActualizacion = item.es_EsActualizacion;

                        Info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Estado = item.Estado;
                        Info.Observacion = item.Observacion;
                        Info.Fecha_Transac = item.Fecha_Transac;
                        oEnt.ro_marcaciones_x_empleado.Add(Info);
                        try
                        {
                            oEnt.SaveChanges();

                        }
                        catch (Exception exe)
                        {
                            
                        }




                        info.FechaUltimaImportacionMarcaiones = item.FechaUltimoCorte;
                        info.IdEquipoMar = item.IdEquipo;
                    }
                    oEnt.Dispose();

                    //



                }

                resultado = true;

              //  ro_marcaciones_Equipo_Data Data = new ro_marcaciones_Equipo_Data();
               // info.FechaUltimaImportacionMarcaiones = DateTime.Now;
             //   Data.ActualizaUltimaFechaCorte(info);

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                resultado = false;
            } return resultado;

           
        }




        public Boolean GrabarDB(List<ro_marcaciones_x_empleado_Info> ListaGrabar, int IdEmpresa)
        {
            bool resultado = false;
            ro_marcaciones_Equipo_Info info = new ro_marcaciones_Equipo_Info();
            try
            {
                int sec = 0;
                using (EntitiesRoles oEnt1 = new EntitiesRoles())
                {

                    EntitiesRoles oEnt = new EntitiesRoles();

                    foreach (var item in ListaGrabar)
                    {
                        sec = sec + 1;
                        //Console.WriteLine(c);
                        ro_marcaciones_x_empleado Info = new ro_marcaciones_x_empleado();

                        Info.IdEmpresa = Convert.ToByte(item.IdEmpresa);
                        Info.IdRegistro = item.es_dia + "/" + item.es_mes + "/" + item.es_anio + "-" + item.IdTipoMarcaciones + "-" + item.IdEmpleado + "-" + sec;
                        Info.IdEmpleado = item.IdEmpleado;
                        Info.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        Info.secuencia = GetId(item.IdEmpresa, item.IdEmpleado, item.IdTipoMarcaciones);
                        Info.es_Hora = item.es_Hora;
                        Info.es_fechaRegistro = item.es_fechaRegistro;
                        Info.es_anio = item.es_anio;
                        Info.es_mes = Convert.ToByte(item.es_mes);
                        Info.es_semana = Convert.ToByte(item.es_semana);
                        Info.es_dia = Convert.ToByte(item.es_dia);
                        Info.es_sdia = item.es_sdia;
                        Info.es_idDia = Convert.ToByte(item.es_idDia);
                        Info.es_EsActualizacion = item.es_EsActualizacion;

                        Info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Estado = item.Estado;
                        Info.Observacion = item.Observacion;
                        Info.Fecha_Transac = item.Fecha_Transac;
                        oEnt.ro_marcaciones_x_empleado.Add(Info);
                        oEnt.SaveChanges();
                        info.FechaUltimaImportacionMarcaiones = item.FechaUltimoCorte;
                        info.IdEquipoMar = item.IdEquipo;
                    }
                    oEnt.Dispose();

                }

                resultado = true;

                ro_marcaciones_Equipo_Data Data = new ro_marcaciones_Equipo_Data();
                // info.FechaUltimaImportacionMarcaiones = DateTime.Now;
                Data.ActualizaUltimaFechaCorte(info);

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                resultado = false;
            } return resultado;


        }

        public Boolean GrabarDB(List<ro_marcaciones_x_empleado_Info> ListaGrabar)
        {
            bool resultado = false;
            ro_marcaciones_Equipo_Info info = new ro_marcaciones_Equipo_Info();
            try
            {
                int sec = 0;
                using (EntitiesRoles oEnt1 = new EntitiesRoles())
                {

                    EntitiesRoles oEnt = new EntitiesRoles();

                    foreach (var item in ListaGrabar)
                    {
                        sec = sec + 1;
                        //Console.WriteLine(c);
                        ro_marcaciones_x_empleado Info = new ro_marcaciones_x_empleado();

                        Info.IdEmpresa = item.IdEmpresa; ;
                        Info.IdRegistro = item.IdRegistro;
                        Info.IdEmpleado = item.IdEmpleado;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        Info.secuencia = GetId(item.IdEmpresa, item.IdEmpleado, item.IdTipoMarcaciones);
                        Info.es_Hora = item.es_Hora;
                        Info.es_fechaRegistro = item.es_fechaRegistro;
                        Info.es_anio = item.es_anio;
                        Info.es_mes = Convert.ToByte(item.es_mes);
                        Info.es_semana = Convert.ToByte(item.es_semana);
                        Info.es_dia = Convert.ToByte(item.es_dia);
                        Info.es_sdia = item.es_sdia;
                        Info.es_idDia = Convert.ToByte(item.es_idDia);
                        Info.es_EsActualizacion = item.es_EsActualizacion;

                        Info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Estado = item.Estado;
                        Info.Observacion = item.Observacion;
                        Info.Fecha_Transac = item.Fecha_Transac;
                        oEnt.ro_marcaciones_x_empleado.Add(Info);
                        oEnt.SaveChanges();
                        info.FechaUltimaImportacionMarcaiones = item.FechaUltimoCorte;
                        info.IdEquipoMar = item.IdEquipo;
                    }
                    oEnt.Dispose();

                }

                resultado = true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                resultado = false;
            } return resultado;


        }
      

        
        private decimal GetId(int IdEmpresa, decimal IdEmpleado, string IdTipoMarcaciones)
        {
            decimal id = 1;
            try
            {
                EntitiesRoles Oen = new EntitiesRoles();
                var q = from C in Oen.ro_marcaciones_x_empleado
                        where C.IdEmpresa == IdEmpresa
                        && C.IdEmpleado == IdEmpleado
                        && C.IdTipoMarcaciones == IdTipoMarcaciones
                        select C;
                if (q.ToList().Count > 0)
                {
                    var max = (from C in Oen.ro_marcaciones_x_empleado
                               where C.IdEmpresa == IdEmpresa
                               && C.IdEmpleado == IdEmpleado
                               && C.IdTipoMarcaciones == IdTipoMarcaciones
                               select C.secuencia).Max();
                    id = Convert.ToDecimal(max.ToString()) + 1;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return 0;                
            }
        return id;
        }

        public decimal GetIdSecuencia(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_marcaciones_x_empleado
                       
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ro_marcaciones_x_empleado
                                   where t.IdEmpresa == IdEmpresa
                                   select t.secuencia).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return 0;
            }
        }

        public Boolean GrabarDB(ro_marcaciones_x_empleado_Info Item, ref string IdRegistro, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    ro_marcaciones_x_empleado infoMarcacion = new ro_marcaciones_x_empleado();

                    infoMarcacion.IdRegistro = Item.es_dia + "/" + Item.es_mes + "/" + Item.es_anio + "-" + Item.IdTipoMarcaciones + "-" + Item.IdEmpleado + "-" + GetIdSecuencia(Item.IdEmpresa);
                    infoMarcacion.IdEmpresa = Item.IdEmpresa;
                    infoMarcacion.IdEmpleado = Item.IdEmpleado;
                    infoMarcacion.IdPeriodo = Item.IdPeriodo;

                    infoMarcacion.IdTipoMarcaciones = Item.IdTipoMarcaciones;

                    infoMarcacion.es_Hora = Item.es_Hora;
                    infoMarcacion.es_fechaRegistro = Item.es_fechaRegistro;
                    infoMarcacion.Fecha_Transac = Item.Fecha_Transac;
                    infoMarcacion.es_anio = Item.es_anio;
                    infoMarcacion.es_mes = Item.es_mes;
                    infoMarcacion.es_semana = Item.es_semana;
                    infoMarcacion.es_dia = Item.es_dia;
                    infoMarcacion.es_sdia = Item.es_sdia;
                    infoMarcacion.es_idDia = Item.es_idDia;
                    infoMarcacion.es_EsActualizacion = "N";
                    infoMarcacion.IdUsuario = Item.IdUsuario;
                    infoMarcacion.Estado = Item.Estado;
                    infoMarcacion.Observacion = Item.Observacion;
                    Context.ro_marcaciones_x_empleado.Add(infoMarcacion);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return false;
            }
        }

        public Boolean ModificarDB(ro_marcaciones_x_empleado_Info Info, string msj)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_marcaciones_x_empleado.First(var => var.IdEmpresa == Info.IdEmpresa && var.IdTipoMarcaciones == Info.IdTipoMarcaciones
                        && var.IdEmpleado== Info.IdEmpleado  && var.IdRegistro==Info.IdRegistro);

                    contact.IdEmpleado = Info.IdEmpleado;
                    contact.IdTipoMarcaciones = Info.IdTipoMarcaciones;
                    contact.es_Hora = Info.es_Hora;
                    contact.es_fechaRegistro = Info.es_fechaRegistro;
                    contact.IdPeriodo = Info.IdPeriodo;
                    contact.es_anio = Info.es_anio;
                    contact.es_mes = Info.es_mes;
                    contact.es_semana = Info.es_semana;
                    contact.es_dia = Info.es_dia;
                    contact.es_sdia = Info.es_sdia;
                    contact.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                    contact.Fecha_UltMod = Info.Fecha_UltMod;
                    contact.Observacion = Info.Observacion;
                     context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return false;
            }
        }

        public Boolean EliminarDB(string IdRegistro, int IdEmpresa)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                   var contact = context.ro_marcaciones_x_empleado.First(var => var.IdEmpresa == IdEmpresa && var.IdRegistro == IdRegistro);
                    context.ro_marcaciones_x_empleado.Remove(contact);
                    context.SaveChanges();
               }
                return true;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return false;
            }

        }

        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {

            try
            {

                List<ro_marcaciones_x_empleado_Info> Lst = new List<ro_marcaciones_x_empleado_Info>();


                using (EntitiesRoles oen = new EntitiesRoles())
                {
                    FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                    FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                    var Query = from q in oen.vwro_marcaciones_x_empleado
                                where q.IdEmpresa == IdEmpresa && q.es_fechaRegistro >= FechaIni && q.es_fechaRegistro <= FechaFin
                                select q;
                    foreach (var item in Query)
                    {
                        ro_marcaciones_x_empleado_Info  Obj = new ro_marcaciones_x_empleado_Info ();                     
                        Obj.IdEmpresa = item.IdEmpresa;
                        Obj.IdRegistro= item.IdRegistro;
                        Obj.em_codigo = item.em_codigo;
                        Obj.IdEmpleado = item.IdEmpleado;
                        Obj.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        Obj.secuencia = item.secuencia;
                        Obj.es_Hora = item.es_Hora;
                        Obj.es_fechaRegistro = item.es_fechaRegistro;
                        Obj.es_anio = item.es_anio;
                        Obj.es_mes = item.es_mes;
                        Obj.es_semana = item.es_semana;
                        Obj.es_dia = item.es_dia;
                        Obj.es_sdia=item.es_sdia;
                        Obj.es_idDia=item.es_idDia;
                        Obj.es_EsActualizacion = item.es_EsActualizacion;
                        Obj.NomCompleto = item.pe_apellido + " " + item.pe_nombre ;
                        Obj.cedula = item.pe_cedulaRuc;
                        Obj.Observacion = item.Observacion;
                        Obj.Motivo_Anu = item.Motivo_Anu;
                        Lst.Add(Obj);
                    }



                    return Lst;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<ro_marcaciones_x_empleado_Info>();
            }
        }

        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado(int IdEmpresa, decimal IdEmpleado, DateTime Fecha_Ini, DateTime Fecha_Fin)
        {

            try
            {

                List<ro_marcaciones_x_empleado_Info> Lst = new List<ro_marcaciones_x_empleado_Info>();


                using (EntitiesRoles oen = new EntitiesRoles())
                {
                    Fecha_Ini = Convert.ToDateTime(Fecha_Ini.ToShortDateString());
                    Fecha_Fin = Convert.ToDateTime(Fecha_Fin.ToShortDateString());

                    var Query = from q in oen.vwro_marcaciones_x_empleado
                                where q.IdEmpresa == IdEmpresa && q.IdEmpleado == IdEmpleado
                                && q.es_fechaRegistro >= Fecha_Ini
                                && q.es_fechaRegistro <= Fecha_Fin
                                orderby q.es_fechaRegistro, q.es_Hora ascending
                                select q;


                    foreach (var item in Query)
                    {
                        ro_marcaciones_x_empleado_Info Obj = new ro_marcaciones_x_empleado_Info();


                        Obj.IdEmpresa = item.IdEmpresa;
                        Obj.IdRegistro = item.IdRegistro;
                        Obj.IdEmpleado = item.IdEmpleado;
                        Obj.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        Obj.secuencia = item.secuencia;
                        Obj.es_Hora = item.es_Hora;
                        Obj.es_fechaRegistro = item.es_fechaRegistro;
                        Obj.es_anio = item.es_anio;
                        Obj.es_mes = item.es_mes;
                        Obj.es_semana = item.es_semana;
                        Obj.es_dia = item.es_dia;
                        Obj.es_sdia = item.es_sdia;
                        Obj.es_idDia = item.es_idDia;
                        Obj.es_EsActualizacion = item.es_EsActualizacion;
                        Obj.NomCompleto = item.nom_compl_empleado;


                        Lst.Add(Obj);
                    }



                    return Lst;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<ro_marcaciones_x_empleado_Info>();
            }
        }

        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado(DateTime Fecha_inicio, DateTime Fecha_fin, string Ocon)
        {
            try
            {
                int HH=0 ;
                int MM  =0;
                int SSG =0;

                DateTime FechaInicio =Convert.ToDateTime( Fecha_inicio.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(Fecha_fin.ToShortDateString());
                FechaFin = new DateTime(Fecha_fin.Year, Fecha_fin.Month, Fecha_fin.Day, 23, 59, 0);
                
                List<ro_marcaciones_x_empleado_Info> Lista = new List<ro_marcaciones_x_empleado_Info>();

                ro_marcaciones_x_empleado_Info InfoMarcaciones = null;
                string sql = "select U.USERID AS IDUSUARIO, U.SSN AS CEDULA,U.NAME AS NOMBRES, M.CHECKTIME AS HORA_INGRESO " +
                    "from USERINFO U,CHECKINOUT M " +
                    "where u.USERID=M.USERID and  M.CHECKTIME   BETWEEN '" + FechaInicio + "'and '" + FechaFin + "' ";
                SqlConnection conexion = new SqlConnection(Ocon);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(1) == false)
                    {
                        InfoMarcaciones = new ro_marcaciones_x_empleado_Info();
                        InfoMarcaciones.cedula = reader.GetString(1);
                        InfoMarcaciones.NomCompleto = reader.GetString(2);
                        InfoMarcaciones.es_fechaRegistro = reader.GetDateTime(3);
                        DateTime HoraIngres = reader.GetDateTime(3);
                        //hora de ingreso
                        HH = reader.GetDateTime(3).Hour;
                        MM = reader.GetDateTime(3).Minute;
                        SSG = reader.GetDateTime(3).Second;
                        if (HH < 12)
                        {
                            InfoMarcaciones.HMarcacion = new TimeSpan(HH, MM, SSG);
                            InfoMarcaciones.IdTipoMarcaciones = "IN";
                            InfoMarcaciones.IdTipoMarcaciones_Biometrico = "C/In";
                        }
                        else
                        {
                            InfoMarcaciones.HMarcacion = new TimeSpan(HH, MM, SSG);
                            InfoMarcaciones.IdTipoMarcaciones = "OUT";
                            InfoMarcaciones.IdTipoMarcaciones_Biometrico = "C/Out";

                        }
                        InfoMarcaciones.check = true;
                        Lista.Add(InfoMarcaciones);
                    }
                }
                reader.Close();
                conexion.Close();

                return Lista;

            }
            catch (Exception ex)
            {
                
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<ro_marcaciones_x_empleado_Info>();
            }
        }


        public List<ro_marcaciones_x_empleado_Info> Get_List_marcaciones_x_empleado_Graf(DateTime Fecha_inicio, DateTime Fecha_fin, string Ocon)
        {
            try
            {
                int HH = 0;
                int MM = 0;
                int SSG = 0;

                DateTime FechaInicio = Convert.ToDateTime(Fecha_inicio.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(Fecha_fin.ToShortDateString());
                FechaFin = new DateTime(Fecha_fin.Year, Fecha_fin.Month, Fecha_fin.Day, 23, 59, 0);

                List<ro_marcaciones_x_empleado_Info> Lista = new List<ro_marcaciones_x_empleado_Info>();

                ro_marcaciones_x_empleado_Info InfoMarcaciones = null;
                string sql = "select U.USERID AS IDUSUARIO, U.SSN AS CEDULA,U.NAME AS NOMBRES, M.CHECKTIME AS HORA_INGRESO " +
                    "from USERINFO U,CHECKINOUT M " +
                "where u.USERID=M.USERID and  M.CHECKTIME   BETWEEN " + "#" + FechaInicio.ToString().Substring(0, 10) + "#" + " and " + "#" + FechaFin.ToString().Substring(0, 10) + "#" + " ";
                OleDbConnection conexion = new OleDbConnection(Ocon);
                conexion.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        InfoMarcaciones = new ro_marcaciones_x_empleado_Info();
                       // InfoMarcaciones.cedula = reader.GetString(1);
                        InfoMarcaciones.NomCompleto = reader.GetString(2);
                        InfoMarcaciones.es_fechaRegistro = reader.GetDateTime(3);
                        DateTime HoraIngres = reader.GetDateTime(3);
                        //hora de ingreso
                        HH = reader.GetDateTime(3).Hour;
                        MM = reader.GetDateTime(3).Minute;
                        SSG = reader.GetDateTime(3).Second;
                        if (HH < 12)
                        {
                            InfoMarcaciones.HMarcacion = new TimeSpan(HH, MM, SSG);
                            InfoMarcaciones.IdTipoMarcaciones = "IN";
                            InfoMarcaciones.IdTipoMarcaciones_Biometrico = "C/In";
                        }
                        else
                        {
                            InfoMarcaciones.HMarcacion = new TimeSpan(HH, MM, SSG);
                            InfoMarcaciones.IdTipoMarcaciones = "OUT";
                            InfoMarcaciones.IdTipoMarcaciones_Biometrico = "C/Out";

                        }
                        InfoMarcaciones.check = true;
                        Lista.Add(InfoMarcaciones);
                    }
                }
                reader.Close();
                conexion.Close();

                return Lista;

            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<ro_marcaciones_x_empleado_Info>();
            }
        }
   
    // grabar marcaciones de trangandia ingresada desde el sistema 

        public Boolean GrabarDB(ro_marcaciones_x_empleado_Info item)
        {
            bool resultado = false;
            try
            {
                using (EntitiesRoles oEnt1 = new EntitiesRoles())
                {

                    EntitiesRoles oEnt = new EntitiesRoles();

                 
                        ro_marcaciones_x_empleado Info = new ro_marcaciones_x_empleado();

                        Info.IdEmpresa = Convert.ToByte(item.IdEmpresa);
                        Info.IdRegistro = item.IdRegistro;
                        Info.IdEmpleado = item.IdEmpleado;
                        Info.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.secuencia =item.secuencia;
                        Info.es_Hora = item.es_Hora;
                        Info.es_fechaRegistro = item.es_fechaRegistro;
                        Info.es_anio = item.es_anio;
                        Info.es_mes = Convert.ToByte(item.es_mes);
                        Info.es_semana = Convert.ToByte(item.es_semana);
                        Info.es_dia = Convert.ToByte(item.es_dia);
                        Info.es_sdia = item.es_sdia;
                        Info.es_idDia = Convert.ToByte(item.es_idDia);
                        Info.es_EsActualizacion = item.es_EsActualizacion;

                        Info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Estado = item.Estado;
                        Info.Observacion = item.Observacion;
                        Info.Fecha_Transac = item.Fecha_Transac;
                        oEnt.ro_marcaciones_x_empleado.Add(Info);
                        oEnt.SaveChanges();
                      
                    
                    oEnt.Dispose();

                }

                resultado = true;

               

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                resultado = false;
            } return resultado;


        }


    }
}
