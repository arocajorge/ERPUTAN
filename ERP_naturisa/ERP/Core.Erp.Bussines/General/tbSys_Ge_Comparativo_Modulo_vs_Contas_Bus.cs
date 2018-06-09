using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Business.General
{
  public  class tbSys_Ge_Comparativo_Modulo_vs_Contas_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";


        public List<tbSys_Ge_Comparativo_Modulo_vs_Contas_Info> Get_List_Comparativo_Modulo_vs_Contas(int IdEmpresa, DateTime Fecha_Ini, DateTime Fecha_Fin)
        {

            try
            {
                tbSys_Ge_Comparativo_Modulo_vs_Contas_Data data = new tbSys_Ge_Comparativo_Modulo_vs_Contas_Data();
                return data.Get_List_Comparativo_Modulo_vs_Contas(IdEmpresa, Fecha_Ini, Fecha_Fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_Tipo", ex.Message), ex) { EntityType = typeof(tbSys_Ge_Comparativo_Modulo_vs_Contas_Bus) };

            }

        }
    }
}
