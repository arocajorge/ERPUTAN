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
    public class Aca_curso_x_Aca_Rubro_Data
    {
        public List<Aca_curso_x_Aca_Rubro_Info> Get_List_Rubros_x_Curso(int IdCurso, ref string mensaje)
        {
            try
            {
                List<Aca_curso_x_Aca_Rubro_Info> lista = new List<Aca_curso_x_Aca_Rubro_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.Aca_curso_x_Aca_Rubro
                                  where c.IdCurso==IdCurso
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            Aca_curso_x_Aca_Rubro_Info RubrosInfo = new Aca_curso_x_Aca_Rubro_Info();
                            RubrosInfo.IdCurso = item.IdCurso;
                            RubrosInfo.IdRubro = item.IdRubro;
                            RubrosInfo.observacion = item.observacion;
                            lista.Add(RubrosInfo);
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

        public Boolean GuardarDB(List<Aca_curso_x_Aca_Rubro_Info> List_Info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                foreach (var item in List_Info)
                {
                  resultado=  GuardarDB(item, ref mensaje);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean GuardarDB(Aca_curso_x_Aca_Rubro_Info Info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    Aca_curso_x_Aca_Rubro _Info = new Aca_curso_x_Aca_Rubro();
                    _Info.IdCurso = Info.IdCurso;
                    _Info.IdRubro = Info.IdRubro;
                    _Info.observacion = (Info.observacion == null) ? "" : Info.observacion;
                    Base.Aca_curso_x_Aca_Rubro.Add(_Info);
                    Base.SaveChanges();
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
        }

        public Boolean EliminarDB(int IdCurso, ref string mensaje)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var Consulta = context.Database.ExecuteSqlCommand("delete from Aca_curso_x_Aca_Rubro where IdCurso= " + IdCurso + "");
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
