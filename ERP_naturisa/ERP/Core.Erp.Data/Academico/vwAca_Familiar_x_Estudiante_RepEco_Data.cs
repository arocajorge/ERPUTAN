using Core.Erp.Data.General;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Academico
{
    public class vwAca_Familiar_x_Estudiante_RepEco_Data
    {
        string MensajeError = "";
        public List<vwAca_Familiar_x_Estudiante_RepEco_Info> Get_List_RepresentateEconomico_x_Estudiante(int IdInstitucion, decimal IdEstudiente)
        {
            List<vwAca_Familiar_x_Estudiante_RepEco_Info> lM = new List<vwAca_Familiar_x_Estudiante_RepEco_Info>();
            try
            {
                 Entities_Academico conexion = new Entities_Academico();
                var Select = (from a in conexion.vwAca_Familiar_x_Estudiante_RepEco
                             where a.IdInstitucion == IdInstitucion && a.IdEstudiante == IdEstudiente
                             select a);
                if (Select != null)
                {
                    foreach (var item in Select)
                    {
                        vwAca_Familiar_x_Estudiante_RepEco_Info Info = new vwAca_Familiar_x_Estudiante_RepEco_Info();
                        Info.IdFamiliar = item.IdFamiliar;
                        Info.IdPersona = item.IdPersona;
                        Info.Nombre = item.Nombre;
                        Info.Apellido = item.Apellido;
                        Info.IdParentesco_cat = item.IdParentesco_cat;
                        lM.Add(Info);
                    }
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }

        }
    }
}
