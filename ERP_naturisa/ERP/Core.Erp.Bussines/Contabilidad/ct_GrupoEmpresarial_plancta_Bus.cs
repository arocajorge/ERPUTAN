using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_GrupoEmpresarial_plancta_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_GrupoEmpresarial_plancta_Data data = new ct_GrupoEmpresarial_plancta_Data();

        public Boolean GrabarDB(ct_GrupoEmpresarial_plancta_Info Info)
        {
            try
            {
              return data.GrabarDB(Info); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }

        public List<ct_GrupoEmpresarial_plancta_Info> Get_list_GrupoEmpresarial_plancta()
        {
            try
            {
                 return data.Get_list_GrupoEmpresarial_plancta();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_GrupoEmpresarial_plancta", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }
  
        }
        
        public Boolean ModificarDB(ct_GrupoEmpresarial_plancta_Info info)
        {
            try
            {
             return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }
        
        public Boolean EliminarDB(ct_GrupoEmpresarial_plancta_Info info)
        {
            try
            {
                return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }

        public ct_GrupoEmpresarial_plancta_Info Get_Info_GrupoEmpresarial_plancta(string IdCuenta_gr)
        {
            try
            {
                 return data.Get_Info_GrupoEmpresarial_plancta(IdCuenta_gr);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_GrupoEmpresarial_plancta", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }
        
        public string Get_IdCta(string IdCtaCble_padre, int IdNivelCta_padre, ref int MaxLen)
        {
            try
            {
                decimal idCta = 0;
                string MiNumConCeros = "";

                List<ct_GrupoEmpresarial_plancta_nivel_Info> listaNivel = new List<ct_GrupoEmpresarial_plancta_nivel_Info>();
                List<ct_GrupoEmpresarial_plancta_Info> listaCta = new List<ct_GrupoEmpresarial_plancta_Info>();
                ct_GrupoEmpresarial_plancta_nivel_Data Nive_D = new ct_GrupoEmpresarial_plancta_nivel_Data();

                listaNivel = Nive_D.Get_list_GrupoEmpresarial_plancta_nivel();
                listaCta = data.Get_list_GrupoEmpresarial_plancta();


                int digitosPadre = (from cta in listaNivel where cta.IdNivelCta_gr == IdNivelCta_padre select cta.nv_NumDigitos_gr).ToList().First();

                int digitosHijo = (from cta in listaNivel where cta.IdNivelCta_gr == IdNivelCta_padre + 1 select cta.nv_NumDigitos_gr).ToList().First();
                MaxLen = digitosHijo;

                var NumCtaHija_Ulti = (from cta in listaCta where cta.IdCuentaPadre_gr == IdCtaCble_padre select cta.IdCuenta_gr).Max();

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

                if (idCta > Convert.ToDecimal(validaNumCtaHijo))
                    return "";
                else
                {
                    MiNumConCeros = "000000000000" + idCta;
                    MiNumConCeros = MiNumConCeros.Remove(0, MiNumConCeros.Length - digitosHijo);
                }

                return MiNumConCeros;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_IdCta", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }
        }
        
        public ct_GrupoEmpresarial_plancta_Bus()
        {
           
        }
    }
}
