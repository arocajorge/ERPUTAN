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
  public class Aca_PeriodoLectivo_Data
    {
      string mensaje = "";
        public Aca_PeriodoLectivo_Data() { }

        #region "Get"
        public List<Aca_PeriodoLectivo_Info> Get_List_Anio_Lectivo(int IdInstitucion)
        {
            List<Aca_PeriodoLectivo_Info> lstPeriodoLectivo = new List<Aca_PeriodoLectivo_Info>();
            Aca_PeriodoLectivo_Info infoPeriodo;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var PeriodoLectivo = from a in Base.Aca_periodo
                                         where a.IdInstitucion == IdInstitucion
                                      select a;

                    foreach (var item in PeriodoLectivo)
                    {
                        infoPeriodo = new Aca_PeriodoLectivo_Info();
                        infoPeriodo.IdInstitucion = item.IdInstitucion;
                        //infoPeriodo.IdPeriodoLectivo = item.IdPeriodoLectivo;
                        //infoPeriodo.Descripcion = item.Descripcion;
                        //infoPeriodo.FechaInicio = item.FechaInicio;
                        //infoPeriodo.FechaFin = item.FechaFin;
                        //infoPeriodo.Estado = item.Estado;
                        lstPeriodoLectivo.Add(infoPeriodo);
                    }
                }
                return lstPeriodoLectivo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la exceopción controlada a la proxima capa
                throw new Exception(ex.ToString());
            }
        }
        #endregion


        #region "Insertar, Actualizar, Eliminar"
        public bool Grabar(Aca_PeriodoLectivo_Info info,ref string mensaje) {
            try
            {
                using (EntitiesCAHAcademico Base=new EntitiesCAHAcademico())
                {
                    Aca_Periodo_Lectivo address = new Aca_Periodo_Lectivo();
                    address.IdInstitucion = info.IdInstitucion;
                    address.IdPeriodoLectivo = info.IdPeriodoLectivo;
                    address.Descripcion = info.Descripcion;
                    address.FechaInicio = info.FechaInicio;
                    address.FechaFin = info.FechaFin;
                    address.Estado = "A";
                    address.FechaCreacion = info.FechaCreacion;
                    address.UsuarioCreacion = info.UsuarioCreacion;
                    Base.Aca_Periodo_Lectivo.Add(address);
                    Base.SaveChanges();
                    mensaje = "Se ha producido ingresar un nuevo periodo lectivo exitosamente ";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }            
        }

        public bool Actualizar(Aca_PeriodoLectivo_Info info,ref string mensaje) {
            try
            {
                using (EntitiesCAHAcademico Base=new EntitiesCAHAcademico())
                {
                    var anioLectivo = Base.Aca_Periodo_Lectivo.FirstOrDefault(o => o.IdInstitucion == info.IdInstitucion && o.IdPeriodoLectivo == info.IdPeriodoLectivo);
                    if (anioLectivo != null)
                    {
                        anioLectivo.Descripcion = info.Descripcion;
                        anioLectivo.FechaInicio = info.FechaInicio;
                        anioLectivo.FechaFin = info.FechaFin;
                        anioLectivo.FechaModificacion = info.FechaModificacion;
                        anioLectivo.UsuarioModificacion = info.UsuarioModificacion;
                        Base.SaveChanges();
                        mensaje = "Se ha producido actualizar el periodo lectivo exitosamente ";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(Aca_PeriodoLectivo_Info info,ref string mensaje) {
            try
            {
                using (EntitiesCAHAcademico context = new EntitiesCAHAcademico())
                {
                    var address = context.Aca_Periodo_Lectivo.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdPeriodoLectivo == info.IdPeriodoLectivo);
                    if (address != null)
                    {
                        address.Estado = "I";
                        address.FechaAnulacion = DateTime.Now;
                        address.UsuarioAnulacion = info.UsuarioAnulacion;
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        mensaje = "Se ha procedido anular el periodo leactivo: " + info.IdPeriodoLectivo.ToString() + " exitosamente.";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
