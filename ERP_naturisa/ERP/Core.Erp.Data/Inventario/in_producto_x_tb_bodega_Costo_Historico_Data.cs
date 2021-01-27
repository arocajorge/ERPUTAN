using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;

namespace Core.Erp.Data.Inventario
{
    public class in_producto_x_tb_bodega_Costo_Historico_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public Boolean GuardarDB(in_producto_x_tb_bodega_Costo_Historico_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var Address = new in_producto_x_tb_bodega_Costo_Historico();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdBodega = Convert.ToInt32(Info.IdBodega);
                    Address.IdProducto = Info.IdProducto;
                    Address.IdFecha = Info.IdFecha;
                    Address.Secuencia = Info.Secuencia = GetSecuencia(Info);
                    Address.fecha = Convert.ToDateTime(Info.fecha.ToShortDateString());
                    Address.costo = Info.costo;
                    Address.Stock_a_la_fecha = Info.Stock_a_la_fecha;
                    if (Info.Observacion == null || Info.Observacion=="")
                    {
                        Address.Observacion = ".";
                    }
                    else
                    {
                        Address.Observacion = Info.Observacion;//.Substring(1, 25);
                    }
                    Address.fecha_trans = DateTime.Now;
                    Context.in_producto_x_tb_bodega_Costo_Historico.Add(Address);
                    Context.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(in_producto_x_tb_bodega_Costo_Historico_Info info)
        {
            using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "update in_producto_x_tb_bodega_Costo_Historico set costo = "+info.costo.ToString()+" where IdEmpresa = "+info.IdEmpresa.ToString()+" and IdSucursal = "+info.IdSucursal.ToString()+" and IdBodega = "+info.IdBodega.ToString()+" and IdProducto = "+info.IdProducto.ToString()+" and IdFecha = "+info.IdFecha.ToString()+" and Secuencia = "+info.Secuencia;
                command.ExecuteNonQuery();
            }
            return true;
        }

        public int GetSecuencia(in_producto_x_tb_bodega_Costo_Historico_Info Info)
        {
            try
            {
                int Id;
                EntitiesInventario entInve = new EntitiesInventario();
                var select = (from q in entInve.in_producto_x_tb_bodega_Costo_Historico
                              where q.IdEmpresa == Info.IdEmpresa
                              && q.IdSucursal == Info.IdSucursal 
                              && q.IdBodega == Info.IdBodega 
                              && q.IdProducto == Info.IdProducto
                              && q.IdFecha == Info.IdFecha
                              select q.Secuencia).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in entInve.in_producto_x_tb_bodega_Costo_Historico
                                        where q.IdEmpresa == Info.IdEmpresa
                                          && q.IdSucursal == Info.IdSucursal
                                          && q.IdBodega == Info.IdBodega 
                                          && q.IdProducto == Info.IdProducto
                                          && q.IdFecha == Info.IdFecha
                                        select q.Secuencia).Max();
                    Id = Convert.ToInt32(select_IdCXC.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public in_producto_x_tb_bodega_Costo_Historico_Info Get_UltimoCosto_x_Producto_Bodega(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha)
        {
            try
            {
                in_producto_x_tb_bodega_Costo_Historico_Info Info = new in_producto_x_tb_bodega_Costo_Historico_Info();
                int IdFechaMax = 0;
                int SecuenciaMax = 0;
                EntitiesInventario entInve = new EntitiesInventario();

                Fecha = Fecha.Date;

                var select = (from q in entInve.in_producto_x_tb_bodega_Costo_Historico
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega 
                              && q.IdProducto == IdProducto
                              && q.fecha <= Fecha
                              select q);

                

                if (select.Count() == 0)
                {
                    Info = new in_producto_x_tb_bodega_Costo_Historico_Info();
                }
                else
                {
                    IdFechaMax = select.Max(q => q.IdFecha);

                    SecuenciaMax = select.Where(q => q.IdEmpresa == IdEmpresa
                                          && q.IdSucursal == IdSucursal
                                          && q.IdBodega == IdBodega && q.IdProducto == IdProducto
                                          && q.IdFecha == IdFechaMax).Max(q => q.Secuencia);

                    Info = Get_Producto_Bodega_Historico(IdEmpresa, IdSucursal, IdBodega, IdProducto, IdFechaMax, SecuenciaMax);
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public in_producto_x_tb_bodega_Costo_Historico_Info Get_Producto_Bodega_Historico(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, int IdFecha, int Secuencia)
        {
            try
            {
                in_producto_x_tb_bodega_Costo_Historico_Info Info = new in_producto_x_tb_bodega_Costo_Historico_Info();
                                
                using (EntitiesInventario entInve = new EntitiesInventario())
                {
                    var select = (from q in entInve.in_producto_x_tb_bodega_Costo_Historico
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdSucursal == IdSucursal
                                  && q.IdBodega == IdBodega && q.IdProducto == IdProducto
                                  && q.IdFecha == IdFecha && q.Secuencia == Secuencia
                                  select q);

                    foreach (var item in select)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdBodega = item.IdBodega;
                        Info.IdProducto = item.IdProducto;
                        Info.IdFecha = item.IdFecha;
                        Info.Secuencia = item.Secuencia;
                        Info.fecha = item.fecha;
                        Info.costo = item.costo;
                        Info.Stock_a_la_fecha = item.Stock_a_la_fecha;
                        Info.Observacion = item.Observacion;
                    }
                }              

             
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool Proceso_recosteo_y_correccion_contable_inv(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, DateTime Fecha_fin, int Decimales)
        {
            try
            {
                List<in_producto_x_tb_bodega_Costo_Historico_Info> Lista = new List<in_producto_x_tb_bodega_Costo_Historico_Info>();

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Context.SetCommandTimeOut(10000);

                    Context.spSys_Inv_Recosteo_Inventario_x_rango_fechas(IdEmpresa, IdSucursal, IdBodega, Fecha_ini, Fecha_fin, Decimales);                   
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Proceso_recosteo_y_correccion_contable_inv(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha_ini, int Decimales)
        {
            try
            {
                List<in_producto_x_tb_bodega_Costo_Historico_Info> Lista = new List<in_producto_x_tb_bodega_Costo_Historico_Info>();

                Fecha_ini = Fecha_ini.Date;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Context.SetCommandTimeOut(10000);

                    Context.spSys_Inv_Recosteo_Inventario_x_producto(IdEmpresa, IdSucursal, IdBodega, IdProducto, Fecha_ini,  Decimales);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_producto_x_tb_bodega_Costo_Historico_Info> Proceso_recosteo_y_correccion_contable_inv(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, int Decimales)
        {
            try
            {
                List<in_producto_x_tb_bodega_Costo_Historico_Info> Lista = new List<in_producto_x_tb_bodega_Costo_Historico_Info>();
                Fecha_ini = Fecha_ini.Date;
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Context.SetCommandTimeOut(10000);

                    Context.spSys_Inv_Recosteo_Inventario(IdEmpresa, IdSucursal, IdBodega, Fecha_ini, Decimales);
                    var lst = from q in Context.vwin_producto_x_tb_bodega_Costo_Historico
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega
                              && q.fecha >= Fecha_ini 
                              select q;

                    foreach (var item in lst)
                    {
                        in_producto_x_tb_bodega_Costo_Historico_Info info = new in_producto_x_tb_bodega_Costo_Historico_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdProducto = item.IdProducto;
                        info.IdFecha = item.IdFecha;
                        info.Secuencia = item.Secuencia;
                        info.fecha = item.fecha;
                        info.costo = item.costo;
                        info.Stock_a_la_fecha = item.Stock_a_la_fecha;
                        info.Observacion = item.Observacion;
                        info.fecha_trans = item.fecha_trans;

                        info.cod_sucursal = item.cod_sucursal;
                        info.nom_sucursal = "[" + item.cod_sucursal + "] " + item.nom_sucursal;
                        info.cod_bodega = item.cod_bodega;
                        info.nom_bodega = "[" + item.cod_bodega + "]" + item.nom_bodega;
                        info.cod_producto = item.cod_producto;
                        info.nom_producto = "[" + item.cod_producto + "]" + item.nom_producto;

                        Lista.Add(info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_producto_x_tb_bodega_Costo_Historico_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            List<in_producto_x_tb_bodega_Costo_Historico_Info> Lista = new List<in_producto_x_tb_bodega_Costo_Historico_Info>();

            using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select IdEmpresa,IdSucursal,IdBodega,IdProducto,IdFecha,Secuencia,fecha,costo,Stock_a_la_fecha,Observacion,fecha_trans from in_producto_x_tb_bodega_Costo_Historico where IdEmpresa = " + IdEmpresa.ToString() + " and IdSucursal = " + IdSucursal.ToString() + " and IdBodega = " + IdBodega.ToString() + " and IdProducto = " + IdProducto.ToString();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lista.Add(new in_producto_x_tb_bodega_Costo_Historico_Info
                    {
                        IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                        IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                        IdBodega = Convert.ToInt32(reader["IdBodega"]),
                        IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                        IdFecha = Convert.ToInt32(reader["IdFecha"]),
                        Secuencia = Convert.ToInt32(reader["Secuencia"]),
                        fecha = Convert.ToDateTime(reader["fecha"]),
                        costo = Convert.ToDouble(reader["costo"]),
                        Stock_a_la_fecha = Convert.ToDouble(reader["Stock_a_la_fecha"]),
                        Observacion = Convert.ToString(reader["Observacion"]),
                        fecha_trans = reader["fecha_trans"] == DBNull.Value ? null : (DateTime?)(reader["fecha_trans"])
                    });
                }
                reader.Close();
            }

            return Lista;
        }
    }
}
