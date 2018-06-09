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
  public  class Aca_ficha_medica_Data
    {
      public Aca_ficha_medica_Info Get_ficha_medica(decimal IdEstudiante,int IdInstitucion) {
          Aca_ficha_medica_Info infoFicha = new Aca_ficha_medica_Info();
          try
          {
              using (Entities_Academico db = new Entities_Academico()) {

                  var fichaMed = from C in  db.Aca_ficha_medica
                                 where C.IdInstitucion == IdInstitucion 
                                 && C.IdEstudiante==IdEstudiante
                                 select C;

                  foreach (var item in fichaMed)
                  {
                      infoFicha.IdInstitucion = item.IdInstitucion;
                      infoFicha.IdEstudiante = item.IdEstudiante;
                      infoFicha.MedicaContraIndic = item.Medica_contraIndic;
                      infoFicha.OtrasIndicacionesMedicas = item.Otras_Indicaciones_medicas;
                      infoFicha.SeguroMedico = item.Seguro_medico;
                      infoFicha.GrupoSanguineoCatalogo = item.Grupo_Sanguineo_cat;
                  }
              }

              return infoFicha;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string msg = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msg = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
              msg = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public bool ActualizarDB(Aca_ficha_medica_Info fichaInfo,ref string msg) {
          try {

              using (Entities_Academico context = new Entities_Academico())
              {
                  var fichaMedica = context.Aca_ficha_medica.FirstOrDefault(obj => obj.IdInstitucion == fichaInfo.IdInstitucion && obj.IdEstudiante == fichaInfo.IdEstudiante);
                  if (fichaMedica != null)
                  {
                      fichaMedica.Medica_contraIndic = fichaInfo.MedicaContraIndic;
                      fichaMedica.Otras_Indicaciones_medicas = fichaInfo.OtrasIndicacionesMedicas;
                      fichaMedica.Seguro_medico = fichaInfo.SeguroMedico;
                      fichaMedica.Grupo_Sanguineo_cat = fichaInfo.GrupoSanguineoCatalogo;

                      context.SaveChanges();
                  }
              }
              return true;
          }
          catch(Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msg = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
              msg = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }      
      }

      public Boolean GrabarDB(Aca_ficha_medica_Info fichaInfo,ref string msg) 
      { 
          try
          {
            using (Entities_Academico Base=new Entities_Academico()){
                Aca_ficha_medica addressFicha=new Aca_ficha_medica();
                addressFicha.IdInstitucion = fichaInfo.IdInstitucion;
                addressFicha.IdEstudiante=fichaInfo.IdEstudiante;
                addressFicha.Grupo_Sanguineo_cat=fichaInfo.GrupoSanguineoCatalogo;
                addressFicha.Seguro_medico=fichaInfo.SeguroMedico;
                addressFicha.Medica_contraIndic=fichaInfo.MedicaContraIndic;
                addressFicha.Otras_Indicaciones_medicas=fichaInfo.OtrasIndicacionesMedicas;   
                Base.Aca_ficha_medica.Add(addressFicha);
                Base.SaveChanges();
            }     
            return true;
          }
          catch(Exception ex)
          {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
          }
      }
    }
}
