using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info Info) 
        {
            try
            {
               using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    var Address = new prod_GestionProductivaAcero_CusTalme_x_in_movi_inven();

                    Address.gp_IdEmpresa = Info.gp_IdEmpresa;
                    Address.gp_IdSucursal = Info.gp_IdSucursal;
                    Address.gp_IdGestionAceria = Info.gp_IdGestionAceria;
                    Address.mv_IdEmpresa = Info.mv_IdEmpresa;
                    Address.mv_IdSucursal = Info.mv_IdSucursal;
                    Address.mv_IdBodega = Info.mv_IdBodega;
                    Address.mv_IdMovi_inven_tipo = Info.mv_IdMovi_inven_tipo;
                    Address.mv_IdNumMovi = Info.mv_IdNumMovi;

                    Context.prod_GestionProductivaAcero_CusTalme_x_in_movi_inven.Add(Address);
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

        public List<prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info> Get_List_GestionProductivaAcero_CusTalme_x_in_movi_inve(int IdEmpresa, int IdSucursal, Decimal IdgestionAceria) 
        {
                 List<prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info> lista = new List<prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info>();
            try
            {
                 using (EntitiesProduccion Oent = new EntitiesProduccion())
                 {
                     string Query = "select * from prod_GestionProductivaAcero_CusTalme_x_in_movi_inven "+
                                        "where gp_IdEmpresa = "+IdEmpresa+" and gp_IdSucursal = "+IdSucursal+"	and gp_IdGestionAceria = "+IdgestionAceria;

                     lista = Oent.Database.SqlQuery<prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info>(Query).ToList();
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
