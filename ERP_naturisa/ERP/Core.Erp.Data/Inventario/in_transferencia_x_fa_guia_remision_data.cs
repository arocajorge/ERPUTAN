using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_transferencia_x_fa_guia_remision_data
    {
        string mensaje = "";

        public Boolean GuardarDB(in_transferencia_x_fa_guia_remision_Info Info)
	    {
		try
		{
			List<in_transferencia_x_fa_guia_remision_Info> Lst = new List<in_transferencia_x_fa_guia_remision_Info>() ;
			using(EntitiesInventario Context= new EntitiesInventario())
			{
				
				var Address = new in_transferencia_x_fa_guia_remision();

				Address.IdEmpresa= Info.IdEmpresa;
				Address.IdSucursalOrigen= Info.IdSucursalOrigen;
				Address.IdBodegaOrigen= Info.IdBodegaOrigen;
				Address.IdTransferencia= Info.IdTransferencia;
				Address.IdEmpresa_Guia= Info.IdEmpresa_Guia;
				Address.IdSucursal_Guia= Info.IdSucursal_Guia;
				Address.IdBodega_Guia= Info.IdBodega_Guia;
				Address.IdGuiaRemision= Info.IdGuiaRemision;
				Address.Obser= Info.Obser;

                Context.in_transferencia_x_fa_guia_remision.Add(Address);
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
            throw new Exception(mensaje);
        }
	}

        public in_transferencia_x_fa_guia_remision_Info Get_Info_transferencia_x_fa_guia_remision(int IdEmpresa, int IdSucursalOrigen, int IdBodegaOrigen, decimal IdTransferencia)
	{
			EntitiesInventario oEnti= new EntitiesInventario();
		try
		{
			in_transferencia_x_fa_guia_remision_Info Info = new in_transferencia_x_fa_guia_remision_Info() ;
			var Objeto = oEnti.in_transferencia_x_fa_guia_remision.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdSucursalOrigen == IdSucursalOrigen && var.IdBodegaOrigen== IdBodegaOrigen && var.IdTransferencia == IdTransferencia);
            if (Objeto != null)
            {
                Info.IdEmpresa = Objeto.IdEmpresa;
                Info.IdSucursalOrigen = Objeto.IdSucursalOrigen;
                Info.IdBodegaOrigen = Objeto.IdBodegaOrigen;
                Info.IdTransferencia = Objeto.IdTransferencia;
                Info.IdEmpresa_Guia = Objeto.IdEmpresa_Guia;
                Info.IdSucursal_Guia = Objeto.IdSucursal_Guia;
                Info.IdBodega_Guia = Objeto.IdBodega_Guia;
                Info.IdGuiaRemision = Objeto.IdGuiaRemision;
                
                Info.Obser = Objeto.Obser;
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
            Console.WriteLine("Error :" + ex.Message);
            throw new Exception(mensaje);
        }
		
	}

        public Boolean VerificacionAsociacionGuiaVStransferencia(int IdEmpresa_Guia, int IdSucursal_Guia, int IdBodega_Guia, decimal IdGuiaRemision) 
        {
            try
            {
                using (EntitiesInventario oen = new EntitiesInventario())
                {
                    in_transferencia_x_fa_guia_remision cus = new in_transferencia_x_fa_guia_remision();
                    IQueryable<in_transferencia_x_fa_guia_remision> Consulta = from q in oen.in_transferencia_x_fa_guia_remision
                                                                               where q.IdGuiaRemision == IdGuiaRemision && q.IdEmpresa_Guia == IdEmpresa_Guia 
                                                                               && q.IdSucursal_Guia == IdSucursal_Guia && q.IdBodega_Guia == IdBodega_Guia
                                                                               select q;

                    if (Consulta.Count() == 0)
                        return true;
                    else
                        return false;
                }
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
    }
}
