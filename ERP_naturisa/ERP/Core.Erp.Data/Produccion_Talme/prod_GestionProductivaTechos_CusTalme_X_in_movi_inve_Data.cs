using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Data
    {
        string mensaje = "";

        public List<prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info> Get_List_GestionProductivaTechos_CusTalme_X_in_movi_inv(int IdEmpresa, decimal IdGestionProd) 
        {
                List<prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info> lista = new List<prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info>();
                EntitiesProduccion oen= new EntitiesProduccion();
            try
            {

                string Query = "select * from prod_GestionProductivaTechos_CusTalme_X_in_movi_inve where IdGestionProductiva = "+IdGestionProd+" and IdEmpresa = "+IdEmpresa;
                var Consulta = oen.Database.SqlQuery<prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info>(Query);
                lista = Consulta.ToList();
                
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


        public Boolean GuardarDB(prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info Info, ref string Men) 
        {
            try
            {
                using (EntitiesProduccion Context = new EntitiesProduccion()) 
                {
                    var Address = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve();

                    Address.IdBodega = Info.IdBodega;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdGestionProductiva = Info.IdGestionProductiva;
                    Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    Address.IdNumMovi = Info.IdNumMovi;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.prod_IdEmpresa = Info.prod_IdEmpresa;
                    Address.sec = null;

                    Context.prod_GestionProductivaTechos_CusTalme_X_in_movi_inve.Add(Address);
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
    }
}
