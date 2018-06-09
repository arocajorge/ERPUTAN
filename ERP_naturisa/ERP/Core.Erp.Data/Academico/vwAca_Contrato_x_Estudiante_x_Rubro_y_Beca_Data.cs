using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Academico
{
    public class vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Data
    {

        public List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info> Get_List_Contrato_x_Estudiante_x_Rubro_y_Beca(int IdInstitucion, decimal IdContrato,int IdAnioLectivo, int IdPeriodo)
        {
            try
            {

                List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info> lista = new List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca
                                  where c.IdInstitucion == IdInstitucion &&
                                        c.IdContrato == IdContrato &&
                                        c.IdAnioLectivo_Per == IdAnioLectivo &&
                                        c.IdPeriodo_Per == IdPeriodo
                                        orderby c.Valor descending
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info cursoInfo = new vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info();
                            cursoInfo.IdInstitucion = item.IdInstitucion;
                            cursoInfo.IdContrato = item.IdContrato;
                            cursoInfo.IdEstudiante = item.IdEstudiante;
                            cursoInfo.IdInstitucion_Per = item.IdInstitucion_Per;
                            cursoInfo.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                            cursoInfo.IdPeriodo_Per = item.IdPeriodo_Per;
                            cursoInfo.Descripcion_rubro = item.Descripcion_rubro;
                            cursoInfo.Valor = item.Valor;

                            lista.Add(cursoInfo);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                //mensaje = ex.ToString() + " " + ex.Message;
                //oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

    }
}
