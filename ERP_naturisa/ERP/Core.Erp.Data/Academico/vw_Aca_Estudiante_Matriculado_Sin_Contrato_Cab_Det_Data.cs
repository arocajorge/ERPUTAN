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
    public class vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Data
    {

        public List<vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info> Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle(int IdInstitucion)
        {
            try
            {

                List<vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info> lista = new List<vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det
                                  where c.IdInstitucion == IdInstitucion
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info Matri_x_Est_Sin_Contrato_Cab_Det_Info = new vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det_Info();

                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdInstitucion = item.IdInstitucion;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdSede = item.IdSede;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdParalelo = item.IdParalelo;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdCurso = item.IdCurso;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdSeccion = item.IdSeccion;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdJornada = item.IdJornada;
                            //Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdAnioLectivo = item.IdAnioLectivo;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdMatricula = item.IdMatricula;      
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdEstudiante = item.IdEstudiante;

                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdRubro = (int)item.IdRubro;
                            //Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdInstitucion_per = (int)item.IdInstitucion_per;
                            //Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdAnioLectivo_Rubro_x_Periodo = (int)item.IdAnioLectivo_Rubro_x_Periodo;
                            //Matri_x_Est_Sin_Contrato_Cab_Det_Info.IdPeriodo_Per = (int)item.IdPeriodo_Per;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.pe_nombre = item.pe_nombre;
                            Matri_x_Est_Sin_Contrato_Cab_Det_Info.pe_apellido = item.pe_apellido;
               
                            lista.Add(Matri_x_Est_Sin_Contrato_Cab_Det_Info);
                        }
                    }
                }
                return lista;
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
    }
}
