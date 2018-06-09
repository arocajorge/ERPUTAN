using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
  public  class tb_sis_impuesto_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_impuesto_Data oData = new tb_sis_impuesto_Data();


        /// <summary>
        ///     
        /// </summary>
        /// <param name="IdTipoImpuesto"> ENVIAR ---->  IVA O ICE</param>
        /// <returns></returns>
        public List<tb_sis_impuesto_Info> Get_List_impuesto(string IdTipoImpuesto)
        {
            try
            {
                return oData.Get_List_impuesto(IdTipoImpuesto);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public List<tb_sis_impuesto_Info> Get_List_impuesto()
        {
            try
            {
                return oData.Get_List_impuesto();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="IdTipoImpuesto"> ENVIAR ---->  IVA O ICE </param>
      /// <returns></returns>
        public List<tb_sis_impuesto_Info> Get_List_impuesto_para_Compras(string IdTipoImpuesto)
        {
            try
            {
                return oData.Get_List_impuesto_para_Compras(IdTipoImpuesto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public List<tb_sis_impuesto_Info> Get_List_impuesto_x_CtaCble(int IdEmpresa, string IdTipoImpuesto)
        {
            try
            {
                return oData.Get_List_impuesto_x_CtaCble(IdEmpresa,IdTipoImpuesto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }



        public List<tb_sis_impuesto_Info> Get_List_impuesto_para_Ventas(string IdTipoImpuesto)
        {
            try
            {
                return oData.Get_List_impuesto_para_Ventas(IdTipoImpuesto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public Boolean GrabarDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                bool res=false;

                res=oData.GrabarDB(Info, ref msg);

                if (res)
                {
                    tb_sis_Impuesto_x_ctacble_Data Bus_impu_x_cta = new tb_sis_Impuesto_x_ctacble_Data();
                    
                    Bus_impu_x_cta.GrabarDB(Info.Info_sis_Impuesto_x_ctacble,ref msg);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public Boolean ActualizarDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {

                bool res=false;

                res=oData.ActualizarDB(Info, ref msg);

             if (res)
                {
                    tb_sis_Impuesto_x_ctacble_Data Bus_impu_x_cta = new tb_sis_Impuesto_x_ctacble_Data();
                    Bus_impu_x_cta.DeleteDB(Info.Info_sis_Impuesto_x_ctacble.IdEmpresa_cta, Info.IdCod_Impuesto);
                    Bus_impu_x_cta.GrabarDB(Info.Info_sis_Impuesto_x_ctacble,ref msg);
                }


                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public Boolean AnulaDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                return oData.AnulaDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }


        public tb_sis_impuesto_Info Get_Info_impuesto(string IdCod_Impuesto)
        {

            try
            {
                return oData.Get_Info_impuesto(IdCod_Impuesto);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }
    }
}
