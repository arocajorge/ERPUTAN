using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_ModeloProduccion_x_Producto_CusTal_Data
    {
        string mensaje = "";
        	public Boolean GuardarDB(prod_ModeloProduccion_x_Producto_CusTal_Info Info, ref String Mensaje)
	        {
		        try
		        {
			        List<prod_ModeloProduccion_x_Producto_CusTal_Info> Lst = new List<prod_ModeloProduccion_x_Producto_CusTal_Info>() ;
			        using(EntitiesProduccion Context= new EntitiesProduccion())
			        {
				        var Address = new prod_ModeloProduccion_x_Producto_CusTal();

				        Address.IdEmpresa= Info.IdEmpresa;
				        Address.IdModeloProd= Info.IdModeloProd;
				        Address.IdProducto= Info.IdProducto;
				        Address.Tipo= Info.Tipo;

                        Context.prod_ModeloProduccion_x_Producto_CusTal.Add(Address);
				        Context.SaveChanges();
                        Mensaje = "Guardado Ok";
			        }
		        return true;
		        }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    mensaje = ex.ToString() + " " + ex.Message;
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(ex.ToString());
                }
	        }

            public Boolean Borrar (int IdEmpresa, int IdModeloProduccion, Decimal IdProducto)
            {
                try
                {
                    using (EntitiesProduccion context = new EntitiesProduccion())
                    {
                        var contact = context.prod_ModeloProduccion_x_Producto_CusTal.First(obj => obj.IdEmpresa == IdEmpresa && obj.IdModeloProd == IdModeloProduccion && obj.IdProducto== IdProducto);
                        context.prod_ModeloProduccion_x_Producto_CusTal.Remove(contact);
                        context.SaveChanges();
                        context.Dispose();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    mensaje = ex.ToString() + " " + ex.Message;
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(ex.ToString());
                }
            }

            public List<prod_ModeloProduccion_x_Producto_CusTal_Info> ConsultarXModeloDeProduccion(int IdEmpresa, int IdModeloProd) 
            {

                try
                {
                    EntitiesProduccion Oent = new EntitiesProduccion();
                    string Query = "select * from prod_ModeloProduccion_x_Producto_CusTal where idEmpresa = "+IdEmpresa+" and IdModeloProd = "+IdModeloProd;
                    return Oent.Database.SqlQuery<prod_ModeloProduccion_x_Producto_CusTal_Info>(Query).ToList();
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    mensaje = ex.ToString() + " " + ex.Message;
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(ex.ToString());
                }
            }
    }
}
