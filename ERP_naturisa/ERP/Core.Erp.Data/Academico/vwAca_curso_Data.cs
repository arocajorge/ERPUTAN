using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Data.Academico;


namespace Core.Erp.Data.Academico
{
    public class vwAca_curso_Data
    {

        public List<vwAca_curso_Info> Get_List_Curso(ref string mensaje)
        {
            try
            {
               
                
                List<vwAca_curso_Info> lista = new List<vwAca_curso_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context= from c in Base.vwAca_curso
                                 select c;
                    if(context!=null)
                    {
                        foreach (var item in context)
	                    {
		                    vwAca_curso_Info cursoInfo= new vwAca_curso_Info();
                            cursoInfo.IdCurso = item.IdCurso;
                            cursoInfo.IdSeccion = item.IdSeccion;
                            cursoInfo.CodCurso = item.CodCurso;
                            cursoInfo.CodAlternoCur = item.CodAlternoCur;
                            cursoInfo.Descripcion_cur = item.Descripcion_cur;
                            cursoInfo.Estado = item.estado;
                            cursoInfo.Descripcion_secc = item.Descripcion_secc;
                            cursoInfo.Descripcion_Jor = item.Descripcion_Jor;
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
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
