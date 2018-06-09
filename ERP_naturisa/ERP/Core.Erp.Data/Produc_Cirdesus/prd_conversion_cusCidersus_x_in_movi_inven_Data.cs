using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_conversion_cusCidersus_x_in_movi_inven_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(prd_conversion_cusCidersus_x_in_movi_inven_Info Info)
        {
            try
            {
                List<prd_conversion_cusCidersus_x_in_movi_inven_Info> Lst = new List<prd_conversion_cusCidersus_x_in_movi_inven_Info>();
                using(EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                  
                    var Address = new prd_conversion_cusCidersus_x_in_movi_inven();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    Address.IdNumMovi = Info.IdNumMovi;
                    Address.cv_IdEmpresa = Info.cv_IdEmpresa;
                    Address.cv_IdConversion = Info.cv_IdConversion;

                    Context.prd_conversion_cusCidersus_x_in_movi_inven.Add(Address);
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


        public List<prd_conversion_cusCidersus_x_in_movi_inven_Info> Get_List_conversion_cusCidersus_x_in_movi_inven(int IdEmpresa, decimal IdConversion) 
        {
            try
            {
                List<prd_conversion_cusCidersus_x_in_movi_inven_Info> lista = new List<prd_conversion_cusCidersus_x_in_movi_inven_Info>();

                using (EntitiesProduccion_Cidersus oEnt = new EntitiesProduccion_Cidersus())
                {
                    string Querty = "select * from prd_conversion_cusCidersus_x_in_movi_inven where cv_IdEmpresa = "+IdEmpresa+" and cv_IdConversion = "+IdConversion;


                    var Consulta = oEnt.Database.SqlQuery<prd_conversion_cusCidersus_x_in_movi_inven_Info>(Querty);

                    lista = Consulta.ToList();
                }
                return lista;
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
