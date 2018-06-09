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
  public  class vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Data
    {
      string mensaje = "";
      public List<vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info> Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para(int idEmpresa, int IdInstitucion) {
          List<vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info> lista = new List<vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info>();
          vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info infoVista;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vista = from v in Base.vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para
                              where v.IdInstitucion == IdInstitucion && v.Estado=="A"
                              orderby v.Nivel
                              select v;
                  foreach (var item in vista)
                  {
                      infoVista = new vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info();
                      infoVista.IdInstitucion = item.IdInstitucion;
                      infoVista.ID = item.Id;
                      infoVista.IdPadre = item.IdPadre;
                      infoVista.Nombre = item.Nombre;
                      infoVista.Estado = item.Estado;
                      infoVista.Nivel = item.Nivel;
                      infoVista.IdInstitucion = item.IdInstitucion;
                      infoVista.IdSede = item.IdSede;
                      infoVista.IdJornada = item.IdJornada;
                      infoVista.IdSeccion = item.IdSeccion;
                      infoVista.IdCurso = item.IdCurso;
                      infoVista.IdParalelo = item.IdParalelo;
                      switch (item.Nivel)
                      {
                          case 1: infoVista.Tipo = "Institucion"; break;
                          case 2: infoVista.Tipo = "Sede"; break;
                          case 3: infoVista.Tipo = "Jornada"; break;
                          case 4: infoVista.Tipo = "Seccion"; break;
                          case 5: infoVista.Tipo = "Curso"; break;
                          case 6: infoVista.Tipo = "Paralelo"; break;
                      }
                      lista.Add(infoVista);                      
                  }                  
              }
              return lista;
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
