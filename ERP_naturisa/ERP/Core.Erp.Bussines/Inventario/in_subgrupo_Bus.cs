using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using System.Data;


namespace Core.Erp.Business.Inventario
{
    public class in_subgrupo_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        in_subgrupo_data oDat = new in_subgrupo_data();

        public Boolean GrabarDB(in_subgrupo_info info, ref int IdSubGrupo, ref string msg)
        {
            try
            {
                Boolean res = true;
                if (Validar_objeto_SubGrupo(info, ref msg))
                {

                    return oDat.GrabarDB(info, ref IdSubGrupo, ref msg);
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_subgrupo_Bus) };

                throw new Exception(mensaje);
            }

        }

        public Boolean ModificarDB(in_subgrupo_info info, ref string msg)
        {

            try
            {
                return oDat.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_subgrupo_Bus) };

            }
        }

        public Boolean AnularDB(in_subgrupo_info info, ref string msg)
        {
            try
            {
                return oDat.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_subgrupo_Bus) };

            }
        }

        public Boolean Validar_objeto_SubGrupo(in_subgrupo_info Info, ref string msg)
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

                if (Info.IdLinea == 0 || Info.IdLinea == null)
                {
                    msg = "Seleccione la Linea";
                    return false;
                }

                if (Info.IdGrupo == 0 || Info.IdGrupo == null)
                {
                    msg = "Seleccione el Grupo";
                    return false;
                }

                if (Info.nom_subgrupo == "" || Info.nom_subgrupo == null)
                {
                    msg = "Ingrese la descripción";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto_SubGrupo", ex.Message), ex) { EntityType = typeof(in_subgrupo_Bus) };

            }

        }

        public List<in_subgrupo_info> ObtenerListSubGrupo(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo)
        {
            try
            {
                return oDat.Get_List_in_subgrupo(IdEmpresa, IdCategoria, IdLinea, IdGrupo);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListSubGrupo", ex.Message), ex) { EntityType = typeof(in_subgrupo_Bus) };

            }

        }

        public in_subgrupo_info ObtenerInfoSubGrupo(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo, int IdSubGrupo)
        {
            try
            {
                return oDat.Get_Info_in_subgrupo(IdEmpresa, IdCategoria, IdLinea, IdGrupo, IdSubGrupo);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerInfoSubGrupo", ex.Message), ex) { EntityType = typeof(in_subgrupo_Bus) };

            }

        }

        public List<in_subgrupo_info> ConsultaGeneralSubGrupo(int IdEmpresa)
        {

            try
            {
                return oDat.Get_List_in_subgrupo(IdEmpresa);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralSubGrupo", ex.Message), ex) { EntityType = typeof(in_subgrupo_Bus) };

            }
        }

        public List<in_subgrupo_info> ProcesarDataTablein_subgrupo_info(DataTable ds, int IdEmpresa, ref string MensajeError)
        {
            List<in_subgrupo_info> lista = new List<in_subgrupo_info>();
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MENOS DE 6 COLUMNAS
                if (ds.Columns.Count <= 6)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            in_subgrupo_info info = new in_subgrupo_info();

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
                                        info.IdGrupo = Convert.ToInt32(row[col]);
                                        break;
                                    case 3://Codigo
                                        info.IdSubgrupo = Convert.ToInt32(row[col]);
                                        break;
                                    case 4://Codigo
                                        info.nom_subgrupo = Convert.ToString(row[col]);
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
                        lista = new List<in_subgrupo_info>();
                    }
                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 2 columnas.";
                    lista = new List<in_subgrupo_info>();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTablein_subgrupo_info", ex.Message), ex) { EntityType = typeof(in_subgrupo_info) };
            }
            return lista;
        }
    }
}
