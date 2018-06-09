using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Data.Caja;
using Core.Erp.Info.Caja;

namespace Core.Erp.Business.Caja
{
    public class Caj_Talonario_Recibo_Bus
    {
        #region Declaración de variables

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Caj_Talonario_Recibo_Data data = new Caj_Talonario_Recibo_Data();
        string mensaje = "";

        #endregion

        public List<Caj_Talonario_Recibo_Info> Get_List_Recibo(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Recibo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Recibo", ex.Message), ex) { EntityType = typeof(Caj_Talonario_Recibo_Bus) };
            }
        }

        public string Get_Num_ultimo_Recibo(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdTipo_Docu, ref string MensajeError)//opin 2017/03/23
        {
            try
            {
                return data.Get_Num_ultimo_Recibo(IdEmpresa, IdSucursal, IdPuntoVta, IdTipo_Docu ,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Num_ultimo_Recibo", ex.Message), ex) { EntityType = typeof(Caj_Talonario_Recibo_Bus) };
            }
        }

        public Boolean GuardarDB(Caj_Talonario_Recibo_Info Info, ref string MensajeError)
        {
            try
            {
                return data.GuardarDB(Info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Caj_Talonario_Recibo_Bus) };
            }
        }

        public Boolean ModificarDB(Caj_Talonario_Recibo_Info Info, ref string MensajeError)
        {
            try
            {
                return data.ModificarDB(Info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Caj_Talonario_Recibo_Bus) };
            }
        }

        public Boolean AnularDB(Caj_Talonario_Recibo_Info Info, ref string MensajeError)
        {
            try
            {
                return data.AnularDB(Info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Caj_Talonario_Recibo_Bus) };
            }
        }


        public Caj_Talonario_Recibo_Info Get_Ultimo_Recibo_No_Usado(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdTipo_Docu, ref string MensajeError)//opin 2017/03/23
        {
            try
            {
                return data.Get_Ultimo_Recibo_No_Usado(IdEmpresa, IdSucursal, IdPuntoVta, IdTipo_Docu, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Ultimo_Recibo_No_Usado", ex.Message), ex) { EntityType = typeof(Caj_Talonario_Recibo_Bus) };
            }
        }

        public string Get_Num_Recibo_optenido(int IdRecibo, ref string MensajeError)//opin 2017/03/24
        {
            try
            {
                return data.Get_Num_Recibo_optenido(IdRecibo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Num_Recibo_optenido", ex.Message), ex) { EntityType = typeof(Caj_Talonario_Recibo_Bus) };
            }
        }
    }
}
