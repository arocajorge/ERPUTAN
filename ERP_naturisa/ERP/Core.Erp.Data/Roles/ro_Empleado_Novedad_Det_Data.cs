

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
// haac 16/01/2014
using System.Data;

namespace Core.Erp.Data.Roles
{
    public class ro_Empleado_Novedad_Det_Data
    {
        int Sec_Novedad = 0;
        string mensaje = "";
        List<ro_Empleado_Novedad_Det_Info> lista = new List<ro_Empleado_Novedad_Det_Info>();

        public Boolean GrabarDB(ro_Empleado_Novedad_Det_Info ro_info, ref string mensaje)
        {
            try
            {
               
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    EntitiesRoles EDB = new EntitiesRoles();

                    var address = new ro_empleado_novedad_det();

                        address.IdEmpresa = ro_info.IdEmpresa;
                        address.IdNovedad = ro_info.IdNovedad;
                        address.IdEmpleado = ro_info.IdEmpleado;
                        address.Secuencia = ro_info.Secuencia;
                        address.FechaPago = ro_info.FechaPago;
                        address.Valor = ro_info.Valor;
                        address.EstadoCobro = "PEN";
                        address.Estado = "A";
                        address.Observacion = ro_info.Observacion;
                        address.IdRubro = ro_info.IdRubro;
                        address.IdCalendario = ro_info.IdCalendario;
                        address.Num_Horas = ro_info.NumHoras;
                        address.IdNomina_tipo = ro_info.IdNomina;
                        address.IdNomina_Tipo_Liq = ro_info.IdNominaLiqui;
                        context.ro_empleado_novedad_det.Add(address);
                        context.SaveChanges();

                        mensaje = "Se ha procedido a grabar la información exitosamente...";

                    return true;
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

        public int getSecuencia(int idempresa, decimal idNovedad, decimal idEmpleado)
        {
            try
            {

                int Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_empleado_novedad_det
                        where C.IdEmpresa == idempresa && C.IdNovedad==idNovedad && C.IdEmpleado ==idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in OECbtecble.ro_empleado_novedad_det
                                   where t.IdEmpresa == idempresa && t.IdNovedad == idNovedad
                                   select t.Secuencia).Max();
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

        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det(int IdEmpresa, decimal IdEmpleado, decimal idNovedad, decimal Secuencia)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Det_Info>();


                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwro_Empleado_Novedades
                              where A.IdEmpresa == IdEmpresa
                              && A.IdEmpleado==IdEmpleado
                              && A.IdNovedad==idNovedad
                              && A.IdTransaccion==Secuencia
                              select A;

                foreach (var item in sresult){
                    ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();                    

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad=item.IdNovedad;
                    Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Reg.IdRubro = item.IdRubro;                    
                    Reg.EstadoCobro = (item.EstadoCobro).Trim();                    
                    Reg.ru_tipo = (item.ru_tipo=="I")?"Ingreso":"Egreso";
                    Reg.FechaPago=item.FechaPago;
                    Reg.Valor=item.Valor;
                    Reg.Observacion=item.Observacion;
                    Reg.Secuencia = item.IdTransaccion;
                    if (Reg.NumHoras != null)
                    {
                        Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                    }

                    Reg.Estado = item.Estado_det;
                    lista.Add(Reg);
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

        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det_x_Rubro(int idEmpresa, decimal idTransaccion, string idRubro)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Det_Info>();

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = (from a in ORol.vwro_Empleado_Novedades
                               where a.IdEmpresa == idEmpresa && a.IdRubro == idRubro && a.IdTransaccion == idTransaccion
                              select a);
                              //where A.IdEmpresa == IdEmpresa && A.IdRubro  == idrubro && A.IdNovedad == idNovedad
                              //where A.IdEmpresa == IdEmpresa && A.IdEmpleado == idEmpleado && A.IdNovedad == idNovedad

                foreach (var item in sresult)
                {
                    ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Reg.IdRubro = item.IdRubro;
                    Reg.FechaPago = item.FechaPago;
                    Reg.Valor = item.Valor;
                    Reg.Observacion = item.Observacion;
                    Reg.Estado = item.Estado_det;
                    Reg.EstadoCab = item.Estado;

                    Reg.EstadoCobro = item.EstadoCobro;                 
                    
                    Reg.em_codigo = item.em_codigo;
                    Reg.em_nombre = item.pe_nombreCompleto.Trim();
                    Reg.em_cedula = item.pe_cedulaRuc.Trim();
                    if (Reg.NumHoras != null)
                    {
                        Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                    }

                    lista.Add(Reg);
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
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Novedad_det_x_Periodo(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, DateTime fechaInicio, DateTime fechaFinal, ref string msg)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Det_Info>();

                EntitiesRoles db = new EntitiesRoles();

                var datos = (from a in db.vwro_Empleado_Novedades
                               where a.IdEmpresa == idEmpresa && a.IdEmpleado==idEmpleado
                               && a.IdNomina_Tipo==idNominaTipo && a.IdNomina_TipoLiqui==idNominaTipoLiqui
                               && (a.FechaPago>=fechaInicio && a.FechaPago<=fechaFinal)
                               
                               select a);

                foreach (var item in datos)
                {
                    ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Reg.IdRubro = item.IdRubro;
                    Reg.FechaPago = item.FechaPago;
                    Reg.Valor = item.Valor;
                    Reg.Observacion = item.Observacion;
                    Reg.Estado = item.Estado_det;
                    Reg.EstadoCab = item.Estado;

                    Reg.EstadoCobro = item.EstadoCobro;

                    Reg.em_codigo = item.em_codigo;
                    Reg.em_nombre = item.pe_nombreCompleto.Trim();
                    Reg.em_cedula = item.pe_cedulaRuc.Trim();

                    if (Reg.NumHoras != null)
                    {
                        Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                    }
                    lista.Add(Reg);
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
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det_x_Periodo(int IdEmpresa, decimal IdEmpleado, int idNominaTipo, int idNominaTipoLiqui, string idRubro, DateTime fechaInicio, DateTime fechaFinal, ref string msg)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Det_Info>();

                EntitiesRoles db = new EntitiesRoles();

                var datos = (from a in db.vwro_Empleado_Novedades
                             join b in db.ro_nomina_tipo_liqui_orden on a.IdRubro equals b.IdRubro
                             where a.IdEmpresa == IdEmpresa && a.IdEmpleado == IdEmpleado
                             && a.IdNomina_Tipo == idNominaTipo && a.IdNomina_TipoLiqui == idNominaTipoLiqui && a.IdRubro == idRubro
                             && (a.FechaPago >= fechaInicio && a.FechaPago <= fechaFinal)
                             select a);

                foreach (var item in datos)
                {
                    ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Reg.IdRubro = item.IdRubro;
                    Reg.FechaPago = item.FechaPago;
                    Reg.Valor = item.Valor;
                    Reg.Observacion = item.Observacion;
                    Reg.Estado = item.Estado_det;
                    Reg.EstadoCab = item.Estado;

                    Reg.EstadoCobro = item.EstadoCobro;

                    Reg.em_codigo = item.em_codigo;
                    Reg.em_nombre = item.pe_nombreCompleto.Trim();
                    Reg.em_cedula = item.pe_cedulaRuc.Trim();
                    if (Reg.NumHoras != null)
                    {
                        Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                    }

                    lista.Add(Reg);
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
        public List<ro_Empleado_Novedad_Det_Info> ProcesarDataTableAInfo_Prestamo_Quirografario(DataTable ds, int idempresa, DateTime fecha, ref string msg)
        {
            List<ro_Empleado_Novedad_Det_Info> lista = new List<ro_Empleado_Novedad_Det_Info>();

            try
            {

                Sec_Novedad = 0;

                ro_Empleado_Data dataEmp = new ro_Empleado_Data();

                //VERIFICA QUE EL EMPLEADO ESTE ACTIVO Y NO LIQUIDADO
                List<ro_Empleado_Info> lstTodosEmp = dataEmp.Get_List_Empleado_(idempresa).Where(v => v.em_estado == "A" && v.em_status != "EST_LIQ").ToList();

                DateTime fecha_Excel = new DateTime();
                fecha_Excel = fecha;

                //VALIDAR QUE TENGA MAS DE 6 COLUMNAS
                if (ds.Columns.Count >= 4)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    foreach (DataRow row in ds.Rows)
                    {
                        Sec_Novedad = Sec_Novedad + 1;
                        ro_Empleado_Novedad_Det_Info info = new ro_Empleado_Novedad_Det_Info();

                        //RECORRE C/U DE LAS COLUMNAS
                        for (int col = 0; col < ds.Columns.Count + 1; col++)
                        {
                            //OBTIENE EL NOMBRE DEL EMPLEADO DEL ARCHIVO DE EXCEL
                            string nombreEmpleado = Convert.ToString(row[2]).Trim();
                            //  string cedula = Convert.ToString(row[1]).Trim();

                            switch (col)
                            {
                                case 0://OBTIENE LA CEDULA
                                    string codigo = Convert.ToString(row[col]).Trim();

                                    if (codigo.Length == 9)
                                        codigo = "0" + codigo;


                                    ro_Empleado_Info emp = new ro_Empleado_Info();
                                    try
                                    {
                                        emp = lstTodosEmp.First(var => var.InfoPersona.pe_cedulaRuc == codigo);
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
                                        info.em_codigo = emp.em_codigo;
                                        // info.InfoNovedadDet.em_codigo = emp.em_codigo;
                                        info.em_nombre = emp.InfoPersona.pe_nombreCompleto;
                                        // info.InfoNovedadDet.em_nombre = emp.InfoPersona.pe_nombreCompleto;
                                        info.FechaPago = fecha_Excel;

                                        //  info.InfoNovedadDet.FechaPago = fecha_Excel;
                                        info.EstadoCobro = "PEN";

                                        //  info.InfoNovedadDet.EstadoCobro = "PEN";
                                        info.Estado = "A";
                                        // info.InfoNovedadDet.Estado = "A";
                                        // info.existeerror = "N";
                                    }
                                    else
                                    {
                                        info.IdEmpleado = 0;
                                        info.em_cedula = codigo;
                                        // info.InfoNovedadDet.em_cedula = "ERROR";

                                        info.em_codigo = "";
                                        // info.InfoNovedadDet.em_codigo = "Empleado no existe en la Base.";


                                        info.em_nombre = nombreEmpleado;
                                        // info.InfoNovedadDet.em_nombre = "Verifique por favor.";


                                        info.FechaPago = fecha_Excel;
                                        //info.InfoNovedadDet.FechaPago = fecha_Excel;

                                        info.EstadoCobro = "";
                                        // info.InfoNovedadDet.EstadoCobro = "";

                                        info.Estado = "I";
                                        // info.InfoNovedadDet.Estado = "";

                                        info.existeerror = "ERROR";
                                        // info.InfoNovedadDet.existeerror = "ERROR";

                                        info.Observacion = "Empleado no existe en la Base... revise por favor.   ";

                                    }

                                    break;
                                case 2://OBTIENE LA OBSERVACION

                                    string prestamo = Convert.ToString(row[col]);
                                    info.Observacion = info.Observacion + prestamo;
                                    // info.InfoNovedadDet.Observacion = info.InfoNovedadDet.Observacion + prestamo;
                                    break;

                                case 3:
                                    string valor_Excel = Convert.ToString(row[col]);
                                    double valor = Convert.ToDouble(valor_Excel);
                                    info.Valor = valor;
                                    // info.InfoNovedadDet.Valor = valor;

                                    break;

                                default:
                                    break;
                            }
                        }
                        info.Secuencia = Sec_Novedad;
                        lista.Add(info);
                    }
                }
                else
                {
                    msg = "Por favor verifique que el archivo tenga el formato correcto.\r Son 7 columnas.";
                    lista = new List<ro_Empleado_Novedad_Det_Info>();
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



        public List<ro_Empleado_Novedad_Det_Info> Get_List_Novedad_x_Nomina(int idEmpresa, decimal idEmpleado, int idNomina, int idNominaLiqui, string idRubro, DateTime fechaIni, DateTime fechaFin, ref string msg)
        {
            try
            {
                List<ro_Empleado_Novedad_Det_Info> listado = new List<ro_Empleado_Novedad_Det_Info>();


                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var sresult = from a in db.vwro_Empleado_Novedades
                                  where a.IdEmpresa == idEmpresa && a.IdEmpleado == idEmpleado
                                  && ((a.FechaPago >= fechaIni) && (a.FechaPago <= fechaFin))
                                  && a.IdNomina_Tipo == idNomina && a.IdNomina_TipoLiqui == idNominaLiqui
                                  && a.IdRubro == idRubro
                                  && a.Estado_det == "A"
                                  select a;

                    foreach (var item in sresult)
                    {
                        ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                        Reg.IdEmpresa = item.IdEmpresa;
                        Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                        Reg.IdNomina = item.IdNomina_Tipo;
                        Reg.IdNominaLiqui = item.IdNomina_TipoLiqui;
                        Reg.IdNovedad = item.IdNovedad;
                        Reg.IdRubro = item.IdRubro;
                        Reg.EstadoCobro = (item.EstadoCobro).Trim();
                        Reg.Fecha = Convert.ToDateTime(item.Fecha);
                        Reg.Valor = item.Valor;
                        Reg.Observacion = item.Observacion;
                        Reg.Secuencia = item.IdTransaccion;
                        Reg.Estado = item.Estado_det;
                        if (Reg.NumHoras != null)
                        {
                            Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                        }
                        listado.Add(Reg);
                    }

                }
                return listado;
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


        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det_x_RubroPendiente(int IdEmpresa, decimal IdEmpleado, DateTime fechaIni, ref string msg)
        {
            try
            {
                DateTime Finicio = Convert.ToDateTime(fechaIni.ToShortDateString());
                List<ro_Empleado_Novedad_Det_Info> listado = new List<ro_Empleado_Novedad_Det_Info>();


                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var sresult = from a in db.vwro_Empleado_Novedades
                                  where a.IdEmpresa == IdEmpresa && a.IdEmpleado == IdEmpleado
                                      //&& ((a.FechaPago >= fechaIni) && (a.FechaPago <= fechaFin))
                                  && a.FechaPago >= Finicio
                                  && a.EstadoCobro == "PEN"
                                  select a;

                    foreach (var item in sresult)
                    {
                        ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                        Reg.IdEmpresa = item.IdEmpresa;
                        Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                        Reg.IdNomina = item.IdNomina_Tipo;
                        Reg.IdNominaLiqui = item.IdNomina_TipoLiqui;
                        Reg.IdNovedad = item.IdNovedad;
                        Reg.IdRubro = item.IdRubro;
                        Reg.EstadoCobro = (item.EstadoCobro).Trim();
                        Reg.Fecha = Convert.ToDateTime(item.Fecha);
                        Reg.Valor = item.Valor;
                        Reg.Observacion = item.Observacion;
                        Reg.Secuencia = item.IdTransaccion;
                        Reg.Estado = item.Estado;
                        if (Reg.NumHoras != null)
                        {
                            Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                        }
                        Reg.ru_tipo = item.ru_tipo;
                        Reg.ru_descripcion = item.ru_descripcion;
                        listado.Add(Reg);
                    }

                }
                return listado;
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



        public ro_Empleado_Novedad_Det_Info Get_Info_Novedad_det(int idEmpresa, decimal idEmpleado, string idRubro, DateTime fecha, ref string msg)
        {
            try
            {
                ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.ro_empleado_novedad_det
                            where a.IdEmpresa == idEmpresa && a.IdEmpleado == idEmpleado
                            && a.IdRubro == idRubro && a.FechaPago == fecha
                            select a;

                foreach (var item in datos)
                {
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Reg.Secuencia = item.Secuencia;
                    Reg.IdRubro = item.IdRubro;
                    Reg.EstadoCobro = (item.EstadoCobro).Trim();
                    Reg.FechaPago = item.FechaPago;
                    Reg.Valor = item.Valor;
                    Reg.Observacion = item.Observacion;
                    Reg.Estado = item.Estado;
                    Reg.EstadoCobro = item.EstadoCobro;
                    if (Reg.NumHoras != null)
                    {
                        Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                    }
                }
                return Reg;
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


        public List<ro_Empleado_Novedad_Det_Info> Get_List_Novedad_x_Periodo(int idEmpresa, int idNomina, int idNominaLiqui, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<ro_Empleado_Novedad_Det_Info> listado = new List<ro_Empleado_Novedad_Det_Info>();


                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var sresult = from a in db.vwro_Empleado_Novedades
                                  where a.IdEmpresa == idEmpresa
                                  && ((a.FechaPago >= fechaIni)
                                  && (a.FechaPago <= fechaFin))
                                  && a.IdNomina_Tipo == idNomina
                                  && a.IdNomina_TipoLiqui == idNominaLiqui
                                  && a.Estado_det == "A"
                                  && a.EstadoCobro == "PEN"
                                  select a;

                    foreach (var item in sresult)
                    {
                        ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                        Reg.IdEmpresa = item.IdEmpresa;
                        Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                        Reg.IdNomina = item.IdNomina_Tipo;
                        Reg.IdNominaLiqui = item.IdNomina_TipoLiqui;
                        Reg.IdNovedad = item.IdNovedad;
                        Reg.IdRubro = item.IdRubro;
                        Reg.EstadoCobro = (item.EstadoCobro).Trim();
                        Reg.Fecha = Convert.ToDateTime(item.Fecha);
                        Reg.Valor = item.Valor;
                        Reg.Observacion = item.Observacion;
                        Reg.Secuencia = item.IdTransaccion;
                        Reg.Estado = item.Estado_det;
                        if (Reg.NumHoras != null)
                        {
                            Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                        }
                        listado.Add(Reg);
                    }

                }
                return listado;
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



        public decimal get_Valor_Novedad_Periodo(int idEmpresa, int idNomina, int idNominaLiqui, int IdEmpleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                decimal valor = 0;

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var sresult = from a in db.vwro_Empleado_Novedades
                                  where a.IdEmpresa == idEmpresa
                                  && ((a.FechaPago >= fechaIni)
                                  && (a.FechaPago <= fechaFin))
                                  && a.IdNomina_Tipo == idNomina
                                  && a.IdNomina_TipoLiqui == idNominaLiqui
                                  && a.Estado_det == "A"
                                  && a.EstadoCobro == "PEN"
                                  && a.IdEmpleado == IdEmpleado
                                  select a;

                    if (sresult.Count() > 0)
                    {
                        valor = (decimal)sresult.Sum(v => v.Valor);
                    }

                }
                return valor;
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

















        public Boolean ModificarDB(ro_Empleado_Novedad_Det_Info prI, ref string mensaje)
        {
            try
            {                
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado_novedad_det.First(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && 
                        VProdu.IdNovedad == prI.IdNovedad && VProdu.IdEmpleado == prI.IdEmpleado && VProdu.Secuencia==prI.Secuencia);

                    contact.IdRubro = prI.IdRubro;
                    contact.FechaPago = prI.FechaPago;
                    contact.Valor = prI.Valor;
                    contact.EstadoCobro = prI.EstadoCobro;
                    contact.Estado = prI.Estado;
                    contact.Observacion = prI.Observacion;
                    contact.Num_Horas = prI.NumHoras;
                    contact.IdNomina_tipo = prI.IdNominaLiqui;
                    contact.IdNomina_Tipo_Liq = prI.IdNominaLiqui;
                    context.SaveChanges();

                    mensaje = "Se ha procedido a actualizar la información exitosamente...";
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
                mensaje = "Error al grabar" + ex.InnerException;
                return false;
            }
        }
        public Boolean ModificarEstadoCobroDB(int IdEmpresa, int idNominaTipo, int idNominaTipoLiqui, DateTime pe_FechaIni, DateTime pe_FechaFin)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand(" update ro_empleado_novedad_det set EstadoCobro='CAN'" +
                                                    " from vwro_Empleado_Novedades C" +
                                                    " where  C.IdEmpresa='" + IdEmpresa + "' and C.IdNomina_Tipo='" + idNominaTipo + "' and C.IdNomina_TipoLiqui='" + idNominaTipoLiqui + "' and D.FechaPago between '" + pe_FechaIni + "' and '" + pe_FechaFin + "'");
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








        public Boolean EliminarDB(ro_Empleado_Novedad_Det_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var S = context.Database.ExecuteSqlCommand("Delete from dbo.ro_empleado_novedad_det where IdEmpresa =" + prI.IdEmpresa + "AND IdNovedad =" + prI.IdNovedad + "AND IdEmpleado =" + prI.IdEmpleado+ "AND secuencia ="+prI.Secuencia );
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
        public Boolean EliminarDB(int IdEmpresa, decimal IdNovedad, decimal IdEmpleado, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var S = context.Database.ExecuteSqlCommand("Delete from dbo.ro_empleado_novedad_det where IdEmpresa =" + IdEmpresa + "AND IdNovedad =" + IdNovedad + "AND IdEmpleado =" + IdEmpleado);
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
                mensaje = "Error al grabar" + ex.InnerException;
                return false;
            }
        }        
        public Boolean EliminarDB(int IdEmpresa, decimal IdNovedad, decimal IdEmpleado, string IdRubro, ref string mensaje)
        {
            try{
                using (EntitiesRoles context = new EntitiesRoles()){
                    var S = context.Database.ExecuteSqlCommand("Delete from dbo.ro_empleado_novedad_det where IdEmpresa =" + IdEmpresa + "AND IdNovedad =" + IdNovedad + "AND IdEmpleado =" + IdEmpleado + " AND IdRubro = " + IdRubro);
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
        public Boolean EliminarDB(int idEmpresa, decimal idEmpleado, decimal idNovedad, int secuencia, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_novedad_det where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNovedad=" + idNovedad.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       + " AND Secuencia=" + secuencia.ToString()
                        //+ " AND IdRubro=" + idRubro.ToString()
                        // + " AND Fechapago=" + fecha.ToString()
                       );
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
        public Boolean EliminarDB(int idEmpresa,int IdNomina_Tipo, decimal idEmpleado, decimal idNovedad)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_novedad_det where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNovedad=" + idNovedad.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()                       
                       );
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


        public Boolean AnularDB(ro_Empleado_Novedad_Det_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado_novedad_det.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdNovedad == info.IdNovedad && minfo.IdRubro == info.IdRubro && minfo.IdEmpleado == info.IdEmpleado && minfo.Secuencia==info.Secuencia);
                    contact.Estado = "I";
                    contact.Observacion = info.Observacion;
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
        public Boolean AnularDB(decimal IdEmpresa, string IdCalendario, string IdRubro, decimal IdEmpleado, decimal IdNovedad, decimal Secuancia)
        {
            try
            {





                using (EntitiesRoles context = new EntitiesRoles())
                {



                    var contact = context.ro_empleado_novedad_det.First(v => v.IdEmpresa == IdEmpresa && v.IdCalendario == IdCalendario && v.IdRubro == IdRubro && v.IdEmpleado == IdEmpleado && v.IdNovedad == IdNovedad && v.Secuencia == Secuancia);
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

       
        
       

        #region NOVEDADES POR PROCESOS FJ


        public Boolean ModificarDB_POR_ID_CALENDARIO(ro_Empleado_Novedad_Det_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado_novedad_det.First(v => v.IdEmpresa == info.IdEmpresa &&
                                                                             v.IdEmpleado == info.IdEmpleado 
                                                                             && v.IdCalendario == info.IdCalendario 
                                                                             && v.IdRubro == info.IdRubro);

                    contact.IdRubro = info.IdRubro;
                    contact.FechaPago = info.FechaPago;
                    contact.Valor = info.Valor;
                    contact.EstadoCobro = info.EstadoCobro;
                    contact.Estado = info.Estado;
                    contact.Observacion = info.Observacion;
                    contact.Num_Horas = info.NumHoras;
                    context.SaveChanges();

                    mensaje = "Se ha procedido a actualizar la información exitosamente...";
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
                mensaje = "Error al grabar" + ex.InnerException;
                return false;
            }
        }
        public ro_Empleado_Novedad_Det_Info get_si_existe_novedad(int idEmpresa, decimal idEmpleado, string idRubro, string idcalendario)
        {
            try
            {
                ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.ro_empleado_novedad_det
                            where a.IdEmpresa == idEmpresa 
                                    && a.IdEmpleado == idEmpleado
                                    && a.IdRubro == idRubro 
                                    && a.IdCalendario == idcalendario
                            select a;

                foreach (var item in datos)
                {
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = Convert.ToDecimal(item.IdEmpleado);
                    Reg.Secuencia = item.Secuencia;
                    Reg.IdRubro = item.IdRubro;
                    Reg.EstadoCobro = (item.EstadoCobro).Trim();
                    Reg.FechaPago = item.FechaPago;
                    Reg.Valor = item.Valor;
                    Reg.Observacion = item.Observacion;
                    Reg.Estado = item.Estado;
                    Reg.EstadoCobro = item.EstadoCobro;
                    if (Reg.NumHoras != null)
                    {
                        Reg.NumHoras = Convert.ToDouble(item.Num_Horas);
                    }
                }
                return Reg;
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
        public double Get_valor_rebaja_Desahucio(int idEmpresa, decimal idEmpleado, string idRubro)
        {
            try
            {
                ro_Empleado_Novedad_Det_Info Reg = new ro_Empleado_Novedad_Det_Info();

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.ro_empleado_novedad_det
                            where a.IdEmpresa == idEmpresa
                            && a.IdEmpleado == idEmpleado
                            && a.IdRubro == idRubro
                            && a.EstadoCobro=="PEN"
                            &&a.Estado=="A"
                            select a;
                if (datos.Count() > 0)
                    return datos.FirstOrDefault().Valor;
                else
                    return 0;

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



        #endregion
    }
}
