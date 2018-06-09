using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;
using System.Data;

// Version 1.0 23/04/2013  15:05:00
namespace Core.Erp.Business.Inventario
{
    public class in_categorias_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_categorias_data cd = new in_categorias_data();
        public List<in_categorias_Info> Get_List_categorias(int IdEmpresa)
        {
            try
            {
                return cd.Get_List_categorias(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_listCategoria", ex.Message), ex) { EntityType = typeof(in_categorias_bus) };
            }
        }

        public Boolean GrabarDB(int IdEmpresa, in_categorias_Info info, ref string msg)
        {
            try
            {
                return cd.GrabarDB(IdEmpresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_categorias_bus) };

            }
        }

        public Boolean ModificarDB(int IdEmpresa, in_categorias_Info info, ref string msg)
        {
            try
            {
                return cd.ModificarDB(IdEmpresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_categorias_bus) };

            }
        }

        public Boolean AnularDB(in_categorias_Info info, ref string msg)
        {
            try
            {
                return cd.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_categorias_bus) };

            }
        }

        public in_categorias_Info Get_Info_categorias(int IdEmpresa, string IdCategoria)
        {
            try
            {
                return cd.Get_Info_categorias(IdEmpresa, IdCategoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(in_categorias_bus) };

            }

        }

        public string Get_IdCategoria(int IdEmpresa, string Nom_Categoria)
        {
            try
            {
                return cd.Get_IdCategoria(IdEmpresa, Nom_Categoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(in_categorias_bus) };
            }
        }

        public List<in_categorias_Info> ProcesarDataTablein_categorias_Info(DataTable ds, int IdEmpresa, ref string MensajeError)
        {
            List<in_categorias_Info> lista = new List<in_categorias_Info>();
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MENOS DE 3 COLUMNAS
                if (ds.Columns.Count <= 4)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            in_categorias_Info info = new in_categorias_Info();

                            info.IdEmpresa = IdEmpresa;
                            info.Estado = "A";

                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0://IdProducto
                                        info.IdCategoria = Convert.ToString(row[col]);
                                        break;
                                    case 1://Codigo
                                        info.ca_Categoria = Convert.ToString(row[col]);
                                        break;
                                    case 2:
                                        info.cod_categoria = Convert.ToString(row[col]);
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
                        lista = new List<in_categorias_Info>();
                    }
                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 3 columnas y el archivo tiene: " + ds.Columns.Count.ToString() +" columnas";
                    lista = new List<in_categorias_Info>();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTablein_categorias_Info", ex.Message), ex) { EntityType = typeof(in_categorias_Info) };
            }
            return lista;
        }
    }
}
