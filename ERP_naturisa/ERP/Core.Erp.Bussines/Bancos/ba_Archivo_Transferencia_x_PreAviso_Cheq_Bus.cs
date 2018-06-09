using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;

namespace Core.Erp.Business.Bancos
{
   public class ba_Archivo_Transferencia_x_PreAviso_Cheq_Bus
    {


        string mensaje = "";

        ba_Archivo_Transferencia_x_PreAviso_Cheq_Data Odata = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Data();


        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Get_List_Archivo_transferencia()
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();
                lista = Odata.Get_List_Archivo_transferencia();
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Get_List_Archivo_transferencia(int IdEmpresa, DateTime FechaInicio, DateTime Fecha_Fin)
        {
            try
            {

                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();
                Lista = Odata.Get_List_Archivo_transferencia(IdEmpresa, FechaInicio, Fecha_Fin);

                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Get_List_Archivo_transferencia(int IdEmpresa, DateTime fechaIni, 
            DateTime fechaFin, int idBancoIni, int idBancoFin)
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();
                Lista = Odata.Get_List_Archivo_transferencia(IdEmpresa, fechaIni, fechaFin, idBancoIni, idBancoFin);
                
                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Get_Info_Archivo_Transferencia(int idEmpresa, decimal idArchivo)
        {
            try
            {
                ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Info = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();
                Info = Odata.Get_Info_Archivo_Transferencia(idEmpresa, idArchivo);

                return Info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Get_Info_Archivo_transferencia(int idEmpresa, decimal idArchivo, int idBanco)
        {
            try
            {
                ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Info = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();
                Info = Odata.Get_Info_Archivo_transferencia(idEmpresa, idArchivo, idBanco);
                return Info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool GrabarDB(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info, ref decimal IdArchivo)
        {
            try
            {
               
                    return true;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool ModificarDB(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info)
        {
            try
            {
                    return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool Actualizar_Archivo(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info)
        {
            try
            {
                
                    return true;

                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool AnularDB(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info)
        {
            try
            {
                
                    return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }


        public byte[] Get_Archivo(int idEmpresa, decimal idArchivo)
        {
            try
            {

                return Odata.Get_Archivo(idEmpresa, idArchivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

    }
}
