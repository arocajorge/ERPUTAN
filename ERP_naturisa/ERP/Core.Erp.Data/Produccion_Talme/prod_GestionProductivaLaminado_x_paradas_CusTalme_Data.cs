using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_GestionProductivaLaminado_x_paradas_CusTalme_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info> LST, ref string mensaje) 
        {
            try
            {
                int c = 1;
                foreach (var item in LST)
                {
                    using (EntitiesProduccion Context = new EntitiesProduccion())
                    {
                        var Address = new prod_GestionProductivaLaminado_x_paradas_CusTalme();
                        Address.causa = item.causa;
                        Address.Descripcion = item.Descripcion;
                        Address.HoraFin = item.HoraFin;
                        Address.HoraIni = item.HoraIni;
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdGestionProductiva = item.IdGestionProductiva;
                        Address.IdTipoParada = item.IdTipoParada;
                        Address.Secuencia = c;
                        c++;

                        Context.prod_GestionProductivaLaminado_x_paradas_CusTalme.Add(Address);
                        Context.SaveChanges();
                        Context.Dispose();
                    }

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


        public List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info> Get_List_GestionProductivaLaminado_x_paradas_CusTalme(int IdEmpresa, Decimal IdGestion) 
        {
            List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info> lista = new List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info>();
                EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {

                string Query ="select * from prod_GestionProductivaLaminado_x_paradas_CusTalme where IdEmpresa = "+IdEmpresa+" and IdGestionProductiva = "+IdGestion;
                var Consulta = oEnti.Database.SqlQuery<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info>(Query);
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
    }
}
