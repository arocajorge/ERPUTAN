using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Academico
{
    public class Aca_Contrato_x_Estudiante_x_det_Excepcion_Data
    {
        #region "Get"

        public int GetId()
        {
            int Id = 0;
            try
            {
                Entities_Academico Base = new Entities_Academico();
                int select = (from q in Base.Aca_Contrato_x_Estudiante_det_Excepcion   
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Base.Aca_Contrato_x_Estudiante_det_Excepcion
                                     select q.IdExepcion).Max();
                    Id = Convert.ToInt32(select_as.ToString()) + 1;

                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> Get_List_Rubros_Contrato(Aca_Contrato_x_Estudiante_Info InfoContrato)
        {
            List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> lstExcepcionEstudiante = new List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info>();
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var vaspirante = from a in Base.vwAca_Contrato_x_Estudiante_x_Rubro
                                     where a.IdInstitucion == InfoContrato.IdInstitucion &&
                                     a.IdContrato == InfoContrato.IdContrato &&
                                     a.IdMatricula == InfoContrato.IdMatricula &&
                                     a.IdEstudiante == InfoContrato.IdEstudiante &&
                                     a.IdParalelo == InfoContrato.IdParalelo
                                     where a.est_apertura_periodo == "A"
                                     select a;

                    foreach (var item in vaspirante)
                    {
                        Aca_Contrato_x_Estudiante_x_det_Excepcion_Info info = new Aca_Contrato_x_Estudiante_x_det_Excepcion_Info();
                        info.IdInstitucion = item.IdInstitucion;
                        info.IdContrato = item.IdContrato;
                        info.IdRubro = item.IdRubro;
                        info.IdInstitucion_Per = item.IdInstitucion_Per;
                        info.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                        info.IdPeriodo_Per = item.IdPeriodo_Per;
                        info.ValorRubro = Convert.ToDouble(item.Valor);
                        info.Descripcion_Rubro = item.Descripcion_rubro;
                        info.ValorExepcion = 0;

                        lstExcepcionEstudiante.Add(info);
                    }

                }
                return lstExcepcionEstudiante;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                throw new Exception(ex.InnerException.ToString());
            }

        }
        #endregion

    }
}
