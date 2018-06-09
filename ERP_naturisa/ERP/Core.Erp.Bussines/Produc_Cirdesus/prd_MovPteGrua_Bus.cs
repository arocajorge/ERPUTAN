using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_MovPteGrua_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_MovPteGrua_Data Data = new prd_MovPteGrua_Data();

        public List<prd_MovPteGrua_Info> ObtenerListaPteGrua(int idempresa, ref string msg)
        {
            try
            {
                return Data.ObtenerListaPteGrua(idempresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaPteGrua", ex.Message), ex) { EntityType = typeof(prd_MovPteGrua_Bus) };
               
            }

        }

        public List<prd_MovPteGrua_Info> ListadoMovimientos(int IdPuenteGrua, int IdOperaor, DateTime Fdesde, DateTime Fhasta,ref string msg)
        {
            try
            {
                return Data.ListadoMovimientos(IdPuenteGrua, IdOperaor, Fdesde, Fhasta, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListadoMovimientos", ex.Message), ex) { EntityType = typeof(prd_MovPteGrua_Bus) };
               
            }

        }
        public Boolean GrabarDB(prd_MovPteGrua_Info Info, List<prd_MovPteGrua_Det_Info> Det, ref string msg, ref decimal idgenerada)
        {
            try
            {
                return Data.GrabarDB(Info, ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(prd_MovPteGrua_Bus) };
               
            }
        }

        public List<vwprd_MovPteGruaSaldo_Info> MovPteGruaSaldo(int et_idempresa, int et_idprocesoprod, int et_idetapa, decimal ot_idordentaller, string ot_codobra)
        {
            try
            {
                return Data.MovPteGruaSaldo(et_idempresa,  et_idprocesoprod,  et_idetapa, ot_idordentaller,  ot_codobra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "MovPteGruaSaldo", ex.Message), ex) { EntityType = typeof(prd_MovPteGrua_Bus) };
               
            }
        }

    }
}

