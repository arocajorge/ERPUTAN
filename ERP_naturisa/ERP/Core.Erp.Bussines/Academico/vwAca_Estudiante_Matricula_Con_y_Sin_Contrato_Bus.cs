using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
using System.ComponentModel;

namespace Core.Erp.Business.Academico
{
    public class vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Bus
    {

        private vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Data Odata = new vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public BindingList<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(int IdInstitucion)
        {
            try
            {
                BindingList<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> lista = new BindingList<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info>();
                lista = Odata.Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(IdInstitucion);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiante_Matricula_Con_y_Sin_Contrato", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }
        public List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(int IdInstitucion, int IdSede)
        {
            try
            {
                List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> lista = new List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info>();
                lista = Odata.Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(IdInstitucion, IdSede);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiante_Matricula_Con_y_Sin_Contrato", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }
        public List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(int IdInstitucion, int IdSede, int IdJornada)
        {
            try
            {
                List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> lista = new List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info>();
                lista = Odata.Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(IdInstitucion, IdSede, IdJornada);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiante_Matricula_Con_y_Sin_Contrato", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }

        public List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(int IdInstitucion, int IdSede, int IdJornada, int IdSeccion)
        {
            try
            {
                List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> lista = new List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info>();
                lista = Odata.Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(IdInstitucion, IdSede, IdJornada, IdSeccion);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiante_Matricula_Con_y_Sin_Contrato", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }

    }
}
