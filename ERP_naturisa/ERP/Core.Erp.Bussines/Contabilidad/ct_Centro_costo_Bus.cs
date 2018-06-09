using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Contabilidad
{
    public class ct_Centro_costo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Centro_costo_Data data = new ct_Centro_costo_Data();

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo(int IdEmpresa,ref string MensajeError)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_x_cliente(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo_x_cliente(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo_x_cliente", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_x_cliente_Consulta(int IdEmpresa)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo_x_cliente_Consulta(IdEmpresa);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo_x_cliente_Consulta", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }
       
        public List<ct_Centro_costo_Info> Get_list_Centro_costo_x_IdCuentas_Padre(int IdEmpresa, string IdCuenta_Padre, ref string MensajeError)
        {
            try
            {
                return data.Get_list_Centro_costo_x_IdCuentas_Padre(IdEmpresa, IdCuenta_Padre, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Centro_costo_x_IdCuentas_Padre", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }
        
        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_de_movimiento(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo_cuentas_de_Movimiento(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo_cuentas_de_Movimiento", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_padre(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo_cuentas_padre(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo_cuentas_padre", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public string Get_IdCentroCosto(int IdEmpresa, ct_Centro_costo_Info idCentro_Costo_padre, ref string MensajeError)
        {
            try
            {
                decimal idCta = 0;
                string MiNumConCeros = "";
              
                List<ct_Centro_costo_nivel_Info> listaNivel = new List<ct_Centro_costo_nivel_Info>();
                List<ct_Centro_costo_Info> listaCta = new List<ct_Centro_costo_Info>();
                ct_Centro_costo_nivel_Data Nive_D = new ct_Centro_costo_nivel_Data();

                listaNivel = Nive_D.Get_Info_Centro_Costo_nivel(IdEmpresa);
                listaCta = data.Get_list_Centro_Costo(IdEmpresa, ref MensajeError);


                //int digitosPadre = (from cta in listaNivel where cta.IdNivel == idCentro_Costo_padre.IdNivel select cta.ni_digitos).ToList().First();
                int digitosHijo = (from cta in listaNivel where cta.IdNivel == idCentro_Costo_padre.IdNivel + 1 select cta.ni_digitos).ToList().FirstOrDefault();


                var NumCtaHija_Ulti = (from cta in listaCta
                                       where cta.IdCentroCostoPadre == idCentro_Costo_padre.IdCentroCosto 
                                       select cta.IdCentroCosto).Max();

                string NumCtaHija_Ultima_sinPadre = "";

                if (NumCtaHija_Ulti == null)
                {
                    NumCtaHija_Ultima_sinPadre = "0";
                }
                else
                {
                    NumCtaHija_Ultima_sinPadre = Convert.ToString(NumCtaHija_Ulti.Substring(NumCtaHija_Ulti.Length - digitosHijo, digitosHijo));
                }

                string validaNumCtaHijo = "";
                string val = "9";


                for (int i = 0; i < digitosHijo; i++)
                {
                    validaNumCtaHijo = val + validaNumCtaHijo;
                }

                idCta = Convert.ToDecimal(NumCtaHija_Ultima_sinPadre) + 1;

                if (validaNumCtaHijo != "")
                {
                    if (idCta > Convert.ToDecimal(validaNumCtaHijo))
                        return "";
                    else
                    {
                        MiNumConCeros = "000000000000" + idCta;
                        MiNumConCeros = MiNumConCeros.Remove(0, MiNumConCeros.Length - digitosHijo);
                    }
                }
                
                return MiNumConCeros;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_IdCentroCosto", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public string Get_IdCentroCosto_x_Raiz(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                return data.Get_IdCentroCosto_x_Raiz(IdEmpresa,ref MensajeError);
                
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_IdCentroCosto", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean VerificaNivel(int idnivel, int idempresa, ref string MensajeError)
        {
            try
            {
                return data.VerificaNivel(idnivel, idempresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificaNivel", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean ModificarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                return data.ModificarDB(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean AnularDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                return data.AnularDB(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                if (info.IdCentroCosto == "")
                {
                    ct_Centro_costo_Info InfoCentro_costo_padre = new ct_Centro_costo_Info();

                    if (InfoCentro_costo_padre.IdCentroCosto != null)
                    {
                        info.IdCentroCosto = Get_IdCentroCosto(info.IdEmpresa, InfoCentro_costo_padre, ref MensajeError);
                    }
                    else// este caso es por q es raiz no tiene padre 
                    { 
                        info.IdCentroCosto = Get_IdCentroCosto_x_Raiz(info.IdEmpresa, ref MensajeError);
                    }
                }

                return data.GrabarDB(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }
        
        public ct_Centro_costo_Bus()
        {
            
        }
    }
}
