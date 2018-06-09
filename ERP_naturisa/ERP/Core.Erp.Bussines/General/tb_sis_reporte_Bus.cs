using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_reporte_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        tb_sis_reporte_Data data = new tb_sis_reporte_Data();


        public List<tb_sis_reporte_Info> Get_List_reporte(string CodModulo, string Tipo)
        {
            try
            {
                return data.Get_List_reporte(CodModulo, Tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
            }
            
        }

        public DataTable Get_DataSet_SQL(string sqlQuerry)
        {
            try
            {
                return data.Get_DataSet_SQL(sqlQuerry); 
             }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
            }
        }

        public DataTable Get_DataTable_Tabla(string nombreTabla)
        {
            try
            {
                return data.Get_DataTable_Tabla(nombreTabla);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
            }
        }

        public List<String> Get_List_Tablas()
        {
            try
            {
                return data.Get_List_Tablas();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
            }
        }

        public Boolean CrearTabla(int IdEmpresa, string usuario, DateTime Fecha_Transaccion, string nomPc, string nombre_Tabla, string query)
        {
            try
            {
                return data.CrearTabla(IdEmpresa,usuario,Fecha_Transaccion,nomPc,nombre_Tabla,query);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
            }
        }

       
        public Boolean GuardarDB(tb_sis_reporte_Info Info)
        {
            try
            {
                    return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
           
            }

        }

        public Boolean VericarExisteIdString(string codigo, ref string mensaje)
        {
            try
            {
               return data.VericarExisteIdString(codigo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarExisteIdString", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
           
            }

        }


        public List<tb_sis_reporte_Info> Get_List_reporte(Boolean _se_Muestra_Admin_Reporte)
        {
            try
            {
                return data.Get_List_reporte(_se_Muestra_Admin_Reporte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };

            }
        
        }
        
        public List<tb_sis_reporte_Info> Get_list_sis_reporte()
        {
            try
            {
                 return data.Get_List_reporte();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
           
            }

        }

        public List<tb_sis_reporte_Info> Get_list_sis_reporte(List<tb_modulo_Info> lstModulo)
        {
            try
            {
                 return data.Get_List_reporte_x_Modulo(lstModulo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaRptXModulo", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
           
            }

        }

        public tb_sis_reporte_Info Get_Info_sis_reporte(string CodReporte)
        {
            try
            {
                  return data.Get_Info_reporte(CodReporte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
           
            }

        }

        public Boolean ModificarDB_Disenio(tb_sis_reporte_Info info)
        {
            try
            {
                return data.ModificarDB_Disenio(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };

            }

        }

        public Boolean ModificarDB(tb_sis_reporte_Info info)
        {
            try
            {
              return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
           
            }

        }

        public string Get_Numero(string CodModulo)
        {
            try
            {
                 return data.Get_Numero(CodModulo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerNumero", ex.Message), ex) { EntityType = typeof(tb_sis_reporte_Bus) };
           
            }

        }


        public Boolean Execute_SQL(string query)
        {
            return data.Execute_SQL(query);
        
        }

        public tb_sis_reporte_Bus(){}
    }
}
