using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;


namespace Core.Erp.Business.Bancos
{
    public class ba_Talonario_cheques_x_banco_Bus
    {
        string mensaje = "";
        ba_Talonario_cheques_x_banco_Data Odata = new ba_Talonario_cheques_x_banco_Data();
         tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
         cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
         

        public ba_Talonario_cheques_x_banco_Bus ()
	    {
           
	    }

        public decimal GetSecuencia(int IdEmpresa)
        {
            try
            {
                return Odata.GetSecuencia(IdEmpresa);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetSecuencia", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }
        }

        public List<ba_Talonario_cheques_x_banco_Info> Get_List_Talonario_cheques_x_banco(int IdEmpresa, ref string mensajeErrorOut)
        {
            try
            {
                return Odata.Get_List_Talonario_cheques_x_banco(IdEmpresa,ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Talonario_cheques_x_banco", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };

            }
        }

        public List<ba_Talonario_cheques_x_banco_Info> Get_List_Talonario_cheques_x_banco(int IdEmpresa, int IdBanco, ref string mensajeErrorOut)
        {
            try
            {
                return Odata.Get_List_Talonario_cheques_x_banco(IdEmpresa, IdBanco,ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Talonario_cheques_x_banco", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };

            }
        }

        public Boolean Get_Info_Cheq_existe(int IdEmpresa, int IdBanco, string NumCheque, ref string Mensaje)
        {
            try
            {
                return Odata.Get_Info_Cheq_existe(IdEmpresa, IdBanco, NumCheque, ref Mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Talonario_cheques_x_banco", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }
        }

        public ba_Talonario_cheques_x_banco_Info Get_Info_Ultimo_cheq_no_usuado(int IdEmpresa, int idbanco, ref string MensajeErrorOut)
        {
            try
            {
                return Odata.Get_Info_Ultimo_cheq_no_usuado(IdEmpresa,idbanco, ref MensajeErrorOut);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Ultimo_cheq_no_usuado", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }
        }


        public ba_Talonario_cheques_x_banco_Info Get_Info_Ultimo_cheq_banco(int IdEmpresa, int idbanco, ref string MensajeErrorOut)
        {
            try
            {
                return Odata.Get_Info_Ultimo_cheq_banco(IdEmpresa, idbanco, ref MensajeErrorOut);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Ultimo_cheq_banco", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }
        }

        public Boolean GrabarDB(ba_Talonario_cheques_x_banco_Info Info, ref string msg)
        {
            try
            {              
                return Odata.GrabarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }
        }

        public Boolean ModificarDB(ba_Talonario_cheques_x_banco_Info Info, string numcheq, ref string msg)
        {

            try
            {               
                return Odata.ModificarDB(Info,numcheq, ref msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }
        }

        public Boolean AnularDB(ba_Talonario_cheques_x_banco_Info Info, ref string msg)
        {
            try
            {
                Info.IdUsuario_Anu = param.IdUsuario;
                Info.FechaAnulacion = param.GetDateServer();
                
                return Odata.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }

        }

        public Boolean Usar(ba_Cbte_Ban_Info CbteBan_I,  string  Num_cheque, ref string msg)
        {
            try
            {
                return Odata.Modificar_CbteCble(CbteBan_I, Num_cheque, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Usar", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }

        }

    }
}
