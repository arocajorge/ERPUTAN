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
    public class in_grupo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        in_grupo_data oDat = new in_grupo_data();

        public Boolean GrabarDB(in_grupo_info info, ref int IdGrupo, ref string msg)
        {
            try
            {

                Boolean res = true;
                if (Validar_objeto_Grupo(info, ref msg))
                {

                    return oDat.GrabarDB(info, ref IdGrupo, ref  msg);
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_grupo_Bus) };

            }
        }

        public Boolean Validar_objeto_Grupo(in_grupo_info Info, ref string msg)
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

                if (Info.nom_grupo == "" || Info.nom_grupo == null)
                {
                    msg = "Ingrese la descripción";
                    return false;
                }

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto_Grupo", ex.Message), ex) { EntityType = typeof(in_grupo_Bus) };


            }

        }

        public Boolean ModificarDB(in_grupo_info info, ref string msg)
        {
            try
            {
                return oDat.ModificarDB(info, ref  msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_grupo_Bus) };

            }
        }

        public Boolean AnularDB(in_grupo_info info, ref string msg)
        {
            try
            {
                return oDat.AnularDB(info, ref  msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_grupo_Bus) };

            }
        }

        public List<in_grupo_info> Get_List_Grupo(int IdEmpresa, string IdCategoria, int IdLinea)
        {
            try
            {
                return oDat.Get_List_Grupo(IdEmpresa, IdCategoria, IdLinea);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListGrupo", ex.Message), ex) { EntityType = typeof(in_grupo_Bus) };


            }

        }

        public List<in_grupo_info> Get_List_Grupo(int IdEmpresa)
        {
            try
            {
                return oDat.Get_List_Grupo(IdEmpresa);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralGrupo", ex.Message), ex) { EntityType = typeof(in_grupo_Bus) };


            }
        }

        public List<in_grupo_info> ProcesarDataTablein_grupo_info(DataTable ds, int IdEmpresa, ref string MensajeError)
        {
            List<in_grupo_info> lista = new List<in_grupo_info>();
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MENOS DE 5 COLUMNAS
                if (ds.Columns.Count <= 5)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            in_grupo_info info = new in_grupo_info();

                            info.IdEmpresa = IdEmpresa;
                            info.Estado = "A";

                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0://IdCategoria
                                        info.IdCategoria = Convert.ToString(row[col]);
                                        break;
                                    case 1://IdLinea
                                        info.IdLinea = Convert.ToInt32(row[col]);
                                        break;
                                    case 2://IdGrupo
                                        info.IdGrupo = Convert.ToInt32(row[col]);
                                        break;
                                    case 3://NombreGrupo
                                        info.nom_grupo = Convert.ToString(row[col]);
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
                        lista = new List<in_grupo_info>();
                    }
                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 2 columnas.";
                    lista = new List<in_grupo_info>();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTablein_grupo_info", ex.Message), ex) { EntityType = typeof(in_grupo_info) };
            }
            return lista;
        }

        public int Get_IdGrupo(int IdEmpresa, string IdCategoria, int IdLinea, string Nom_Linea)
        {
            try
            {
                return oDat.Get_IdGrupo(IdEmpresa, IdCategoria, IdLinea, Nom_Linea);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListGrupo", ex.Message), ex) { EntityType = typeof(in_grupo_Bus) };


            }
        }
    }
}
