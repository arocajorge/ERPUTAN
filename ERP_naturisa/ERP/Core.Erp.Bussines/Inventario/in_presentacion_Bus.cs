using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

using System.Data;


namespace Core.Erp.Business.Inventario
{
   public class in_presentacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_presentacion_Data oData = new in_presentacion_Data();


        public List<in_presentacion_Info> Get_List_presentacion(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_presentacion(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxTipoCatalogo", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public Boolean EliminarDB(in_presentacion_Info info)
        {
            try
            {
                return oData.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public Boolean GuardarDB(in_presentacion_Info info, ref string msg)
        {
            try
            {
                return oData.GuardarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public Boolean ModificarDB(in_presentacion_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public List<in_presentacion_Info> ProcesarDataTablein_Presentacion_Info(DataTable ds, int IdEmpresa, ref string MensajeError)
        {
            List<in_presentacion_Info> lista = new List<in_presentacion_Info>();
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 2 COLUMNAS
                if (ds.Columns.Count <= 3)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            in_presentacion_Info info = new in_presentacion_Info();

                            info.IdEmpresa = IdEmpresa;
                            info.estado = "A";


                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0://IdProducto
                                        info.IdPresentacion = Convert.ToString(row[col]);
                                        break;
                                    case 1://Codigo
                                        info.nom_presentacion= Convert.ToString(row[col]);
                                        break;
                                    

                                    default:
                                        break;
                                }
                            }


                            lista.Add(info);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<in_presentacion_Info>();
                    }

                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 2 columnas.";
                    lista = new List<in_presentacion_Info>();
                }
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTablein_Producto_Info", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
            return lista;
        }

    }
}
