using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
   public  class prod_CompraChatarra_CusTalme_x__in_movi_inven_Data
    {
       string mensaje = "";
    
    public Boolean GuardarDB(prod_CompraChatarra_CusTalme_x__in_movi_inven_Info Info)
	{
		try
		{
			List<prod_CompraChatarra_CusTalme_x__in_movi_inven_Info> Lst = new List<prod_CompraChatarra_CusTalme_x__in_movi_inven_Info>() ;
			using(EntitiesProduccion Context= new EntitiesProduccion())
			{
				var Address = new prod_CompraChatarra_CusTalme_x__in_movi_inven();

				Address.IdEmpresa= Info.IdEmpresa;
				Address.IdLiquidacion= Info.IdLiquidacion;
				Address.mv_IdEmpresa= Info.mv_IdEmpresa;
				Address.mv_IdSucursal= Info.mv_IdSucursal;
				Address.mv_IdBodega= Info.mv_IdBodega;
				Address.mv_IdMovi_inven_tipo= Info.mv_IdMovi_inven_tipo;
				Address.mv_IdNumMovi= Info.mv_IdNumMovi;
				Address.None= Info.None;

                Context.prod_CompraChatarra_CusTalme_x__in_movi_inven.Add(Address);
				Context.SaveChanges();
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


    public List<prod_CompraChatarra_CusTalme_x__in_movi_inven_Info> Get_List_CompraChatarra_CusTalme_x__in_movi_inve()
	{
			List<prod_CompraChatarra_CusTalme_x__in_movi_inven_Info> Lst = new List<prod_CompraChatarra_CusTalme_x__in_movi_inven_Info>() ;
			EntitiesProduccion oEnti= new EntitiesProduccion();
		try
		{
			var Query = from q in oEnti.prod_CompraChatarra_CusTalme_x__in_movi_inven
				select q;
			 foreach (var item in Query)
			{
				prod_CompraChatarra_CusTalme_x__in_movi_inven_Info Obj = new prod_CompraChatarra_CusTalme_x__in_movi_inven_Info() ;
					Obj.IdEmpresa= item.IdEmpresa;
					Obj.IdLiquidacion= item.IdLiquidacion;
					Obj.mv_IdEmpresa= item.mv_IdEmpresa;
					Obj.mv_IdSucursal= item.mv_IdSucursal;
					Obj.mv_IdBodega= item.mv_IdBodega;
					Obj.mv_IdMovi_inven_tipo= item.mv_IdMovi_inven_tipo;
					Obj.mv_IdNumMovi= item.mv_IdNumMovi;
					Obj.None= item.None;
				Lst.Add(Obj);
		}
			return Lst;
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


    public prod_CompraChatarra_CusTalme_x__in_movi_inven_Info Get_Info_CompraChatarra_CusTalme_x__in_movi_inve(int IdEmpresa, decimal IdLiquidacion)
	{
		EntitiesProduccion oEnti= new EntitiesProduccion();
		prod_CompraChatarra_CusTalme_x__in_movi_inven_Info Info = new prod_CompraChatarra_CusTalme_x__in_movi_inven_Info() ;
		try
		{
			 var Objeto = oEnti.prod_CompraChatarra_CusTalme_x__in_movi_inven.First(var => var.IdEmpresa == IdEmpresa && var.IdLiquidacion == IdLiquidacion);
					Info.IdEmpresa= Objeto.IdEmpresa;
					Info.IdLiquidacion= Objeto.IdLiquidacion;
					Info.mv_IdEmpresa= Objeto.mv_IdEmpresa;
					Info.mv_IdSucursal= Objeto.mv_IdSucursal;
					Info.mv_IdBodega= Objeto.mv_IdBodega;
					Info.mv_IdMovi_inven_tipo= Objeto.mv_IdMovi_inven_tipo;
					Info.mv_IdNumMovi= Objeto.mv_IdNumMovi;
					Info.None= Objeto.None;
				return Info;
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
