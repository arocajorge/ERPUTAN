using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_ProgramaProd_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_ProgramaProd_Data odata = new prod_ProgramaProd_Data();

        public Boolean GuardarDB(ref prod_ProgramaProd_Info Info)
        {
            try
            {
                return odata.GuardarDB(ref  Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_ProgramaProd_Bus) };

            }

        }

        public List<prod_ProgramaProd_Info> ConsultaGeneral( int Idempresa)
        {
            try
            {
                return odata.ConsultaGeneral(Idempresa);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error Consulta General .." + ex.Message;
                return new List<prod_ProgramaProd_Info>();
            }

        }
        public List<prod_ProgramaProd_Info> ConsultaGeneral(int Idempresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return odata.ConsultaGeneral(Idempresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error Consulta General .." + ex.Message;
                return new List<prod_ProgramaProd_Info>();
            }

        }


        public prod_ProgramaProd_Info ObtenerObjeto(int IdEmpresa, int IdPrograma)
        {
            try
            {
                return odata.ObtenerObjeto(IdEmpresa, IdPrograma);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Objeto .." + ex.Message;
                return new prod_ProgramaProd_Info();
            }

        }

        public Boolean ModificarDB(prod_ProgramaProd_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Modificar .." + ex.Message;
                return false;
            }

        }
        public Boolean VerificarExiste(prod_ProgramaProd_Info info, ref string msg)
        {
            try
            {
                return odata.VerificarExiste(info, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Verificar .." + ex.Message;
                return false;
            }

        }

        public Boolean AnularDB(prod_ProgramaProd_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Anular .." + ex.Message;
                return false;
            }

        }

        public int getId(int IdEmpresa, int IdPrograma)
        {
            try
            {
                prod_ProgramaProd_Data data = new prod_ProgramaProd_Data();
                return data.getId(IdEmpresa, IdPrograma);

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener .." + ex.Message;
                return 0;

            }
        }

    }
}
