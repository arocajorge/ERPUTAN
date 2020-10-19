using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{

    public class tb_sis_reporte_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(tb_sis_reporte_Info Info)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {

                    var Address = new tb_sis_reporte();

                    Address.CodReporte = Info.CodReporte;
                    Address.Nombre = Info.Nombre;
                    Address.NombreCorto = Info.NombreCorto;
                    Address.Modulo = Info.Modulo;
                    Address.VistaRpt = Info.VistaRpt;
                    Address.Formulario = Info.Formulario;
                    Address.Orden = Info.Orden;
                    Address.Estado = Info.Estado;
                    Address.se_Muestra_Admin_Reporte = Info.se_Muestra_Admin_Reporte;
                    Address.Observacion = Info.Observacion;
                    Address.imagen = Info.imgByt;
                    Address.nom_Asembly = Info.nom_Asembly;
                    Address.VersionActual = Info.VersionActual;
                    Address.Tipo_Balance = Info.Tipo_Balance;
                    Address.SQuery = Info.SQuery;
                    Address.Class_NomReporte = Info.Class_NomReporte;
                    Address.Class_Info = Info.Class_Info;
                    Address.Class_Data = Info.Class_Data;
                    Address.Class_Bus = Info.Class_Bus;
                    Address.Store_proce_rpt = Info.Store_proce_rpt;

                    Context.tb_sis_reporte.Add(Address);
                    Context.SaveChanges();
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


        public List<tb_sis_reporte_Info> Get_List_reporte()
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_reporte
                                                        select q;

                foreach (var item in Query)
                {
                    tb_sis_reporte_Info Obj = new tb_sis_reporte_Info();
                    Obj.CodReporte = item.CodReporte;
                    Obj.Nombre = item.Nombre;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.Modulo = item.Modulo;
                    Obj.VistaRpt = item.VistaRpt;
                    Obj.Formulario = item.Formulario;
                    Obj.Orden = item.Orden;
                    Obj.Class_NomReporte = item.Class_NomReporte;
                    Obj.Observacion = item.Observacion;
                    Obj.imgByt = item.imagen;
                    Obj.imagen = Funciones.ArrayAImage(item.imagen);
                    Obj.nom_Asembly = item.nom_Asembly;
                    Obj.VersionActual = Convert.ToInt32(item.VersionActual);
                    Obj.Estado = item.Estado;
                    Obj.se_Muestra_Admin_Reporte = Convert.ToBoolean(item.se_Muestra_Admin_Reporte);

                    Obj.Tipo_Balance = item.Tipo_Balance;
                    Obj.SQuery = item.SQuery;

                    Obj.Class_Info = item.Class_Info;
                    Obj.Class_Bus = item.Class_Bus;
                    Obj.Class_Data = item.Class_Data;
                    Obj.Store_proce_rpt = item.Store_proce_rpt;

                    Obj.Disenio_reporte = item.Disenio_reporte;
                    Obj.Se_Muestra_Icono = true;
                   


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

        public List<tb_sis_reporte_Info> Get_List_reporte(Boolean _se_Muestra_Admin_Reporte)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_reporte
                            where q.se_Muestra_Admin_Reporte == _se_Muestra_Admin_Reporte
                            select q;

                foreach (var item in Query)
                {
                    tb_sis_reporte_Info Obj = new tb_sis_reporte_Info();
                    Obj.CodReporte = item.CodReporte;
                    Obj.Nombre = item.Nombre;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.Modulo = item.Modulo;
                    Obj.VistaRpt = item.VistaRpt;
                    Obj.Formulario = item.Formulario;
                    Obj.Orden = item.Orden;
                    Obj.Class_NomReporte = item.Class_NomReporte;
                    Obj.Observacion = item.Observacion;
                    Obj.imgByt = item.imagen;
                    Obj.imagen = Funciones.ArrayAImage(item.imagen);
                    Obj.nom_Asembly = item.nom_Asembly;
                    Obj.VersionActual = Convert.ToInt32(item.VersionActual);
                    Obj.Estado = item.Estado;
                    Obj.se_Muestra_Admin_Reporte = Convert.ToBoolean(item.se_Muestra_Admin_Reporte);

                    Obj.Tipo_Balance = item.Tipo_Balance;
                    Obj.SQuery = item.SQuery;

                    Obj.Class_Info = item.Class_Info;
                    Obj.Class_Bus = item.Class_Bus;
                    Obj.Class_Data = item.Class_Data;
                    Obj.Store_proce_rpt = item.Store_proce_rpt;

                    Obj.Disenio_reporte = item.Disenio_reporte;

                    Obj.Se_Muestra_Icono = true;



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

        public List<tb_sis_reporte_Info> Get_List_reporte_x_Modulo(List<tb_modulo_Info> lstModulo, string IdUsuario)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string Incluida = "";
                    foreach (var item in lstModulo)
                    {
                        Incluida += string.IsNullOrEmpty(Incluida) ? ("'" + item.CodModulo + "'") : (",'" + item.CodModulo + "'");
                    }
                    string query = "select b.CodReporte, b.Nombre, b.NombreCorto, b.Modulo, b.VistaRpt, b.Formulario, b.Orden,"
                                + " b.Class_NomReporte, b.Observacion, b.nom_Asembly, b.Tipo_Balance, b.Estado, b.se_Muestra_Admin_Reporte, "
                                +" b.VersionActual, b.SQuery, b.Class_Info, b.Class_Bus, b.Class_Data, b.Store_proce_rpt, b.Disenio_reporte"
                                +" from seg_usuario_x_tb_sis_reporte as a inner join"
                                +" tb_sis_reporte as b on a.CodReporte = b.CodReporte"
                                +" where b.Estado = 'A' AND B.se_Muestra_Admin_Reporte = 1 AND B.Modulo IN ("+Incluida+") AND A.IdUsuario = '"+IdUsuario+"'";
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lst.Add(new tb_sis_reporte_Info
                        {
                            CodReporte = Convert.ToString(reader["CodReporte"]),
                            Nombre = Convert.ToString(reader["Nombre"]),
                            NombreCorto = Convert.ToString(reader["NombreCorto"]),
                            Modulo = Convert.ToString(reader["Modulo"]),
                            VistaRpt = Convert.ToString(reader["VistaRpt"]),
                            Formulario = Convert.ToString(reader["Formulario"]),
                            Orden = Convert.ToInt32(reader["Orden"]),
                            Class_NomReporte = Convert.ToString(reader["Class_NomReporte"]),
                            Observacion = Convert.ToString(reader["Observacion"]),
                            nom_Asembly = Convert.ToString(reader["nom_Asembly"]),
                            Tipo_Balance = Convert.ToString(reader["Tipo_Balance"]),
                            Estado = Convert.ToString(reader["Estado"]),
                            se_Muestra_Admin_Reporte = Convert.ToBoolean(Convert.ToString(reader["se_Muestra_Admin_Reporte"])),
                            VersionActual = Convert.ToInt32(Convert.ToString(reader["VersionActual"])),
                            SQuery = Convert.ToString(reader["SQuery"]),
                            Class_Info = Convert.ToString(reader["Class_Info"]),
                            Class_Bus = Convert.ToString(reader["Class_Bus"]),
                            Class_Data = Convert.ToString(reader["Class_Data"]),
                            Store_proce_rpt = Convert.ToString(reader["Store_proce_rpt"])
                        });
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

        public List<tb_sis_reporte_Info> Get_List_reporte(string CodModulo, string Tipo)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_reporte
                            where q.Modulo == CodModulo && q.Tipo_Balance == Tipo
                            select q;

                foreach (var item in Query)
                {
                    tb_sis_reporte_Info Obj = new tb_sis_reporte_Info();
                    Obj.CodReporte = item.CodReporte;
                    Obj.Nombre = item.Nombre;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.Modulo = item.Modulo;
                    Obj.VistaRpt = item.VistaRpt;
                    Obj.Formulario = item.Formulario;
                    Obj.Orden = item.Orden;
                    Obj.Class_NomReporte = item.Class_NomReporte;
                    Obj.Observacion = item.Observacion;
                    Obj.imgByt = item.imagen;
                    Obj.imagen = Funciones.ArrayAImage(item.imagen);
                    Obj.nom_Asembly = item.nom_Asembly;
                    Obj.Tipo_Balance = item.Tipo_Balance;
                    Obj.VersionActual = Convert.ToInt32(item.VersionActual);
                    Obj.Estado = item.Estado;
                    Obj.se_Muestra_Admin_Reporte = Convert.ToBoolean(item.se_Muestra_Admin_Reporte);
                    Obj.Class_Info = item.Class_Info;
                    Obj.Class_Bus = item.Class_Bus;
                    Obj.Class_Data = item.Class_Data;


                    Obj.Store_proce_rpt = item.Store_proce_rpt;
                    Obj.Disenio_reporte = item.Disenio_reporte;



                    Obj.SQuery = item.SQuery;
                    Obj.Se_Muestra_Icono = true;
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
                return new List<tb_sis_reporte_Info>(); 
            }
        }
    
        public string Get_Numero(string CodModulo)
        {
            try
            {
                string num = "";
                EntitiesGeneral oEnti = new EntitiesGeneral();

                var c = oEnti.Database.SqlQuery<int>("select max(substring(CodReporte,LEN(CodReporte)-2,3) )+1 from tb_sis_reporte where Modulo='" + CodModulo + "' ");
                try
                {
                    var c2 = c.First();
                    if (c2 == null)
                        num = "001";
                    else if (Convert.ToDecimal(c2) < 10)
                        num = "00" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 99)
                        num = "0" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 999)
                        num = Convert.ToString(c2);
                    else
                        num = null;
                }
                catch (Exception)
                {
                    return "001";
                }
                return num;
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

        public tb_sis_reporte_Info Get_Info_reporte(string CodReporte)
        {
            EntitiesGeneral oEnti = new EntitiesGeneral();
            try
            {
                tb_sis_reporte_Info Info = new tb_sis_reporte_Info();
                var Objeto = oEnti.tb_sis_reporte.FirstOrDefault(var => var.CodReporte == CodReporte);
                if (Objeto != null)
                {
                    Info.CodReporte = Objeto.CodReporte;
                    Info.Nombre = Objeto.Nombre;
                    Info.NombreCorto = Objeto.NombreCorto;
                    Info.Modulo = Objeto.Modulo;
                    Info.VistaRpt = Objeto.VistaRpt;
                    Info.Formulario = Objeto.Formulario;
                    Info.Orden = Objeto.Orden;
                    Info.Class_NomReporte = Objeto.Class_NomReporte;
                    Info.Observacion = Objeto.Observacion;
                    Info.imgByt = Objeto.imagen;
                    Info.imagen = Funciones.ArrayAImage(Objeto.imagen);
                    Info.VersionActual = Convert.ToInt32(Objeto.VersionActual);
                    Info.Estado = Objeto.Estado;
                    Info.se_Muestra_Admin_Reporte = Convert.ToBoolean(Objeto.se_Muestra_Admin_Reporte);

                    Info.Tipo_Balance = Objeto.Tipo_Balance;
                    Info.nom_Asembly = Objeto.nom_Asembly;
                    Info.SQuery = Objeto.SQuery;

                    Info.Class_Info = Objeto.Class_Info;
                    Info.Class_Bus = Objeto.Class_Bus;
                    Info.Class_Data = Objeto.Class_Data;

                    Info.Store_proce_rpt = Objeto.Store_proce_rpt;
                    Info.Se_Muestra_Icono = true;
                }

                return Info;
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

        public Boolean ModificarDB(tb_sis_reporte_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sis_reporte.FirstOrDefault(minfo => minfo.CodReporte == info.CodReporte);
                    if (contact != null)
                    {
                        contact.Nombre = info.Nombre;
                        contact.NombreCorto = info.NombreCorto;
                        contact.Modulo = info.Modulo;
                        contact.VistaRpt = info.VistaRpt;
                        contact.Formulario = info.Formulario;
                        contact.Orden = info.Orden;
                        contact.Class_NomReporte = info.Class_NomReporte;
                        contact.Observacion = info.Observacion;
                        contact.imagen = info.imgByt;
                        contact.nom_Asembly = info.nom_Asembly;
                        contact.VersionActual = Convert.ToInt32(info.VersionActual);
                        contact.Estado = info.Estado;
                        contact.se_Muestra_Admin_Reporte = Convert.ToBoolean(info.se_Muestra_Admin_Reporte);
                        contact.Tipo_Balance = info.Tipo_Balance;
                        contact.SQuery = info.SQuery;
                        contact.Class_Info = info.Class_Info;
                        contact.Class_Bus = info.Class_Bus;
                        contact.Class_Data = info.Class_Data;
                        contact.Store_proce_rpt = info.Store_proce_rpt;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_Disenio(tb_sis_reporte_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sis_reporte.FirstOrDefault(minfo => minfo.CodReporte == info.CodReporte);
                    if (contact != null)
                    {
                        contact.Disenio_reporte = info.Disenio_reporte;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VericarExisteIdString(string codigo, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                string scodigo;

                scodigo = codigo.Trim();
                mensaje = "";
                Existe = false;

                EntitiesGeneral B = new EntitiesGeneral();

                var select_ = from t in B.tb_sis_reporte
                              where t.CodReporte == scodigo
                              select t;

                foreach (var item in select_)
                {
                    mensaje = mensaje + " " + item.Nombre;
                    Existe = true;
                }

                return Existe;
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

        public DataTable Get_DataSet_SQL(string sqlQuerry)
        {
            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;
                SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connString);
                DataTable ds = new DataTable();
                da.Fill(ds);
                return ds;
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

        public DataTable Get_DataTable_Tabla(string nombreTabla)
        {
            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;
                string sql = "Select COLUMN_NAME,DATA_TYPE From INFORMATION_SCHEMA.columns where table_name ='" + nombreTabla + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, connString);
                DataTable ds = new DataTable();
                da.Fill(ds);
                return ds;
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

        public Boolean CrearTabla(int IdEmpresa, string usuario, DateTime Fecha_Transaccion, string nomPc, string nombre_Tabla, string query)
        {

            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;

                SqlCommand cmd = new SqlCommand();
                SqlConnection cc = new SqlConnection(connString);

                string qr = "SELECT cast(" + IdEmpresa + " as int) as IdEmpresa_SP, cast('" + usuario + "' as varchar(20)) as IdUsuario_SP,cast('" + Fecha_Transaccion + "' as datetime) as Fecha_Transac,cast('" + nomPc + "' as varchar(20)) as nom_pc ,* INTO " + nombre_Tabla + " FROM (" + query + ") as pr";
                cmd.Connection = cc;
                cc.Open();
                cmd.CommandText = qr;
                cmd.ExecuteNonQuery();

                cc.Close();
                cmd.Dispose();
                cc.Dispose();

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


        public Boolean Execute_SQL( string query)
        {

            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;

                SqlCommand cmd = new SqlCommand();
                SqlConnection cc = new SqlConnection(connString);

                
                cmd.Connection = cc;
                cc.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                cc.Close();
                cmd.Dispose();
                cc.Dispose();

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

        public List<String> Get_List_Tablas()
        {
            try
            {
                List<String> lst = new List<String>();
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;
                string sql = "Select table_name From INFORMATION_SCHEMA.Tables order by table_name";
                SqlDataAdapter da = new SqlDataAdapter(sql, connString);
                DataTable ds = new DataTable();
                da.Fill(ds);
                foreach (DataRow row in ds.Rows)
                {
                    foreach (DataColumn column in ds.Columns)
                    {
                        lst.Add((String)row[column]);
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

        public tb_sis_reporte_Data() { }
    }
}

