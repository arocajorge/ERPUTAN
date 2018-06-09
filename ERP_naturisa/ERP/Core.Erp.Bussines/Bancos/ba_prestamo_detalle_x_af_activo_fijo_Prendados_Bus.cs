using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
namespace Core.Erp.Business.Bancos
{
  public  class ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus
    {
        ba_prestamo_detalle_x_af_activo_fijo_Prendados_Data data = new ba_prestamo_detalle_x_af_activo_fijo_Prendados_Data();

        public bool GrabarDB(List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info> lista)
        {
            try
            {
                return data.GrabarDB(lista);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus) };
            
            }
        }
        public bool EliminarDB(int IdEmpresa, int IdPrestamo)
        {
            try
            {
            return data.EliminarDB(IdEmpresa,IdPrestamo);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus) };
            
            }
        }


        public List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info> Get_list_activos_prendados(int Idempresa, int IdPrestamo)
        {
            try
            {
                return data.Get_list_activos_prendados(Idempresa, IdPrestamo);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus) };

            }
        }
    }
}
