using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class in_movi_inven_X_imp_OrdCompraExterna_Data
    {
        string mensaje = "";
        public in_movi_inven_X_imp_OrdCompraExterna_Info Get_Info_movi_inven_X_imp_OrdCompraExterna(int in_IdEmpresa, int in_IdSucursal, int in_IdBodega, int in_IdMovi_inven_tipo, decimal in_IdNumMovi)
	        {
			    EntitiesInventario oEnti= new EntitiesInventario();
		        try
		        {
				    in_movi_inven_X_imp_OrdCompraExterna_Info Info = new in_movi_inven_X_imp_OrdCompraExterna_Info() ;
			        var Objeto = oEnti.in_movi_inven_X_imp_OrdCompraExterna.FirstOrDefault(var =>  var.in_IdEmpresa ==in_IdEmpresa && var.in_IdSucursal == in_IdSucursal && var.in_IdBodega == in_IdBodega&& var.in_IdNumMovi== in_IdNumMovi);
                    if (Objeto != null)
                    {
                        Info.imp_IdEmpresa = Objeto.imp_IdEmpresa;
                        Info.imp_IdSucursal = Objeto.imp_IdSucursal;
                        Info.imp_IdOrdenCompraExt = Objeto.imp_IdOrdenCompraExt;
                        Info.in_IdEmpresa = Objeto.in_IdEmpresa;
                        Info.in_IdSucursal = Objeto.in_IdSucursal;
                        Info.in_IdBodega = Objeto.in_IdBodega;
                        Info.in_IdMovi_inven_tipo = Objeto.in_IdMovi_inven_tipo;
                        Info.in_IdNumMovi = Objeto.in_IdNumMovi;
                    }
				    return Info;
			    }
		        catch (Exception ex) 
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    throw new Exception(mensaje);
                }
	        }

            public Boolean EliminarDB(int imp_IdEmpresa, int imp_IdSucursal, decimal imp_IdOrdenCompraExt, int in_IdEmpresa, int in_IdSucursal, int in_IdBodega, int in_IdMovi_inven_tipo, decimal in_IdNumMovi) 
            {
                try
                {
                    using (EntitiesInventario oEnt = new EntitiesInventario()) 
                    {
                        string qry = "delete from in_movi_inven_X_imp_OrdCompraExterna where imp_IdEmpresa = " + imp_IdEmpresa + " and imp_IdSucursal = " + imp_IdSucursal + " and imp_IdOrdenCompraExt  = " + imp_IdOrdenCompraExt + " and in_IdEmpresa  = " + in_IdEmpresa + " and in_IdSucursal  = " + in_IdSucursal + " and in_IdBodega  = " + in_IdBodega + " and in_IdMovi_inven_tipo  = " + in_IdMovi_inven_tipo + " and in_IdNumMovi = "+in_IdNumMovi ;
                        var asa =oEnt.Database.ExecuteSqlCommand(qry);
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
                    throw new Exception(mensaje);
                }
            }

            public Boolean Guardar(int imp_IdEmpresa, int imp_IdSucursal, decimal imp_IdOrdenCompraExt, int in_IdEmpresa, int in_IdSucursal, int in_IdBodega, int in_IdMovi_inven_tipo, decimal in_IdNumMovi) 
            {
                try
                {
                    using (EntitiesInventario context = new EntitiesInventario()) 
                    {
                        var Address = new in_movi_inven_X_imp_OrdCompraExterna();

                        Address.imp_IdEmpresa = imp_IdEmpresa;
                        Address.imp_IdSucursal = imp_IdSucursal;
                        Address.imp_IdOrdenCompraExt = imp_IdOrdenCompraExt;
                        Address.in_IdEmpresa = in_IdEmpresa;
                        Address.in_IdSucursal = in_IdSucursal;
                        Address.in_IdBodega = in_IdBodega;
                        Address.in_IdMovi_inven_tipo = in_IdMovi_inven_tipo;
                        Address.in_IdNumMovi = in_IdNumMovi;
                        context.in_movi_inven_X_imp_OrdCompraExterna.Add(Address);
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
                    mensaje = ex.ToString();
                    throw new Exception(mensaje);
                }
            }


    }
}
