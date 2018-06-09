using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;
using System.Data;

namespace Core.Erp.Business.Inventario
{

    public class in_linea_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_linea_data odata = new in_linea_data();
        string mensaje = "";

        public Boolean GrabarDB(in_linea_info info, ref int IdLinea, ref string msg)
        {

            try
            {

                Boolean res = true;
                if (Validar_objeto_Linea(info, ref msg))
                {

                    return odata.GrabarDB(info, ref IdLinea, ref msg);
                }
                else
                {
                    res = false;

                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_linea_Bus) };

            }
        }

        public Boolean Validar_objeto_Linea(in_linea_info Info, ref string msg)
        {

            try
            {

                if (Info.IdEmpresa == 0 || Info.IdEmpresa == null)
                {
                    msg = "las variable está en cero... IdEmpresa == 0 ";
                    return false;
                }
                if (Info.IdCategoria == "" || Info.IdCategoria == null)
                {
                    msg = "Seleccione la Categoría";
                    return false;
                }
                if (Info.nom_linea == "" || Info.nom_linea == null)
                {
                    msg = "Ingrese la descripción";
                    return false;
                }

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto_Linea", ex.Message), ex) { EntityType = typeof(in_linea_Bus) };


            }

        }

        public Boolean ModificarDB(in_linea_info info, ref string msg)
        {

            try
            {
                return odata.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_linea_Bus) };


            }
        }

        public Boolean AnularDB(in_linea_info info, ref string msg)
        {

            try
            {
                return odata.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_linea_Bus) };

            }
        }

        public List<in_linea_info> Get_List_Linea(int IdEmpresa, string idcategoria)
        {
            try
            {
                return odata.Get_List_Linea(IdEmpresa, idcategoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListLinea", ex.Message), ex) { EntityType = typeof(in_linea_Bus) };

            }

        }
        
        public List<in_linea_info> Get_List_Linea(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Linea(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListLinea", ex.Message), ex) { EntityType = typeof(in_linea_Bus) };

            }

        }

        public List<in_linea_info> ConsultaGeneralLinea(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Linea(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralLinea", ex.Message), ex) { EntityType = typeof(in_linea_Bus) };

            }
        }

        public List<in_linea_info> ProcesarDataTablein_linea_info(DataTable ds, int IdEmpresa, ref string MensajeError)
        {
            List<in_linea_info> lista = new List<in_linea_info>();
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MENOS DE 4 COLUMNAS
                if (ds.Columns.Count <= 4)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            in_linea_info info = new in_linea_info();

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
                                        info.IdLinea = Convert.ToInt32(row[col]);
                                        break;
                                    case 2://Codigo
                                        info.nom_linea = Convert.ToString(row[col]);
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
                        lista = new List<in_linea_info>();
                    }
                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 2 columnas.";
                    lista = new List<in_linea_info>();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTablein_linea_info", ex.Message), ex) { EntityType = typeof(in_linea_info) };
            }
            return lista;
        }

        public int Get_IdLinea(int IdEmpresa, string IdCategoria, string Nom_Linea)
        {
            try
            {
                return odata.Get_IdLinea(IdEmpresa, IdCategoria, Nom_Linea);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(in_categorias_bus) };
            }
        }
    }
}
