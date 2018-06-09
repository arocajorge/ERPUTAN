using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_egreso_d_Suministro_Data
    {
        string mensaje = "";

       public  decimal GetIdEgreso(int IdEmpresa, int IdSucursa, int IdBodega) 
        {
            try
            {
                decimal Id = 0;
                using (EntitiesInventario oent = new EntitiesInventario())
                {
                    var select = from q in oent.in_egreso_d_Suministro
                                 where q.IdEmpresa == IdEmpresa && q.IdSucursa == IdSucursa && q.IdBodega == IdBodega
                                 select q;
                    if (select.ToList().Count < 1)
                    {
                        Id = 1;
                    }
                    else
                    {

                        var select_pv = (from q in oent.in_egreso_d_Suministro
                                         where q.IdEmpresa == IdEmpresa && q.IdSucursa == IdSucursa && q.IdBodega == IdBodega
                                         select q).Max();
                        Id = Convert.ToDecimal(select_pv.ToString()) + 1;
                    }
                    return Id;
                }
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

        public Boolean GuardarDB(in_egreso_d_Suministro_Info Info)
	    {
		    try
		    {
			    List<in_egreso_d_Suministro_Info> Lst = new List<in_egreso_d_Suministro_Info>() ;
			    using(EntitiesInventario Context= new EntitiesInventario())
			    {
				    var Address = new in_egreso_d_Suministro();

				    Address.IdEmpresa= Info.IdEmpresa;
				    Address.IdSucursa= Info.IdSucursa;
				    Address.IdBodega= Info.IdBodega;
                    Address.IdEgresoSumin = GetIdEgreso(Info.IdEmpresa, Info.IdSucursa, Info.IdBodega);
				    Address.IdGasto= Info.IdGasto;
				    Address.IdCentroDeCosto= Info.IdCentroDeCosto;
				    Address.IdProducto= Info.IdProducto;
				    Address.Cantidad= Info.Cantidad;
				    Address.Precio= Info.Precio;
				    Address.Subtotal= Info.Subtotal;
				    Address.observacion= Info.observacion;
				    Address.IdUsuario= Info.IdUsuario;
				    Address.Fecha_Transa= Info.Fecha_Transa;
				    Address.IdUsuarioUltModi= Info.IdUsuarioUltModi;
				    Address.FechaUltModi= Info.FechaUltModi;
				    Address.IdUsuarioAnula= Info.IdUsuarioAnula;
				    Address.FechaAnula= Info.FechaAnula;
				    Address.Estado= "A";

                    Context.in_egreso_d_Suministro.Add(Address);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
	    }

        public in_egreso_d_Suministro_Info Get_Info_egreso_d_Suministro(int IdEmpresa, int IdSucursa, int IdBodega, decimal IdEgresoSumin)
	    {
			EntitiesInventario oEnti= new EntitiesInventario();
		    try
		    {
                in_egreso_d_Suministro_Info Info = new in_egreso_d_Suministro_Info() ;
			    var Objeto = oEnti.in_egreso_d_Suministro.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdSucursa == IdSucursa && var.IdBodega == IdBodega && var.IdEgresoSumin == IdEgresoSumin);
                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdSucursa = Objeto.IdSucursa;
                    Info.IdBodega = Objeto.IdBodega;
                    Info.IdEgresoSumin = Objeto.IdEgresoSumin;
                    Info.IdGasto = Objeto.IdGasto;
                    Info.IdCentroDeCosto = Objeto.IdCentroDeCosto;
                    Info.IdProducto = Objeto.IdProducto;
                    Info.Cantidad = Objeto.Cantidad;
                    Info.Precio = Objeto.Precio;
                    Info.Subtotal = Objeto.Subtotal;
                    Info.observacion = Objeto.observacion;
                    Info.IdUsuario = Objeto.IdUsuario;
                    Info.Fecha_Transa = Objeto.Fecha_Transa;
                    Info.IdUsuarioUltModi = Objeto.IdUsuarioUltModi;
                    Info.FechaUltModi = Objeto.FechaUltModi;
                    Info.IdUsuarioAnula = Objeto.IdUsuarioAnula;
                    Info.FechaAnula = Objeto.FechaAnula;
                    Info.Estado = Objeto.Estado;
                }
				return Info;
		    }
            catch (Exception ex) 
            {
                Console.WriteLine("Error :" + ex.Message);
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
	    }
    }
}
