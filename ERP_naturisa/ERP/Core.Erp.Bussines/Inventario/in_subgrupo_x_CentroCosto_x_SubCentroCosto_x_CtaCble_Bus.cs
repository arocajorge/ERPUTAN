using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();


        in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Data Odata = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Data();

        public List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Get_List_Info_in_subgrupo(int IdEmpresa)
        {
            try
            {
                return Odata.Get_List_Info_in_subgrupo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Info_in_subgrupo", ex.Message), ex) { EntityType = typeof(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus) };
            }
        }

        public List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Get_List_Info_in_subgrupo_no_parametrizados(int IdEmpresa)
        {
            try
            {
                return Odata.Get_List_Info_in_subgrupo_no_parametrizados(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Info_in_subgrupo_no_parametrizados", ex.Message), ex) { EntityType = typeof(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus) };
            }
        }

        public in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info Get_Info_in_subgrupo(int IdEmpresa,
            string IdCategoria, int IdLinea, int IdGrupo, int IdSubGrupo,
           string IdCentroCosto, string IdSubCentroCosto)
        {
            try
            {
                return Odata.Get_Info_in_subgrupo(IdEmpresa, IdCategoria, IdLinea, IdGrupo, IdSubGrupo, IdCentroCosto, IdSubCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarAjusteFisico", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }
        }

        public Boolean GrabarDB(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
        {
            try
            {
                return Odata.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarAjusteFisico", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }

        }

        public Boolean ModificarDB(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
        {
            try
            {
                return Odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarAjusteFisico", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }
        }

        public bool Existe_en_base(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
        {
            try
            {
                return Odata.Existe_en_base(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarAjusteFisico", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }
        }

        /// <summary>
        /// Función para actualizar registros desde la pantalla de consulta
        /// </summary>
        public bool ActualizarDB(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
        {
            try
            {
                bool res = false;

                if (Existe_en_base(info))
                    res = Odata.ModificarDB(info);
                else
                    res = Odata.GrabarDB(info);

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarAjusteFisico", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }
        }
    }
}
