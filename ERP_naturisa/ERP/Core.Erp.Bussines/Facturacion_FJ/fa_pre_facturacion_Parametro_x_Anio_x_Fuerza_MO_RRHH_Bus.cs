using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion_FJ
{
   public class fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Bus
    {
       fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data data = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data();
        public bool Guardar(List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> lista)
        {
            try
            {
                return data.Guardar(lista);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_Parametro_Bus) };
           
            }
        }
        public List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> Get_List_marge_ganacia_RRHH(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_Fin, int IdFuerza)
        {
            try
            {
                return data.Get_List_marge_ganacia_RRHH(IdEmpresa, Fecha_Inicio, Fecha_Fin, IdFuerza);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_Parametro_Bus) };
           
               
            }
        }


        public List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> Get_List_marge_ganacia_RRHH(int IdEmpresa, int IdFuerza)
        {
            try
            {
                return data.Get_List_marge_ganacia_RRHH(IdEmpresa, IdFuerza);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_Parametro_Bus) };


            }
        }

        public fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info Get_List_Get_Info_marge_ganacia_RRHH(int IdEmpresa, int Anio,int Mes)
        {
            try
            {
                return data.Get_Info_marge_ganacia_RRHH(IdEmpresa, Anio, Mes);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_Parametro_Bus) };


            }
        }


    }
}
