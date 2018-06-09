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
    public class Aca_Anio_Lectivo_Data
    {

        string mensaje = "";
        public Aca_Anio_Lectivo_Data() { }

        #region "Get"
        //public string Get_IdAnio_Lectivo_Activo(int IdInstitucion)
        public int Get_IdAnio_Lectivo_Activo(int IdInstitucion)
        {
            //string IdAnio_Lectivo_Activo = "";
            int IdAnio_Lectivo_Activo = 0;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var select = (from q in Base.Aca_Anio_Lectivo
                                  where q.IdInstitucion == IdInstitucion && q.Estado == "A"
                                  select new 
                                  {
                                      IdAnioLectivo = q.IdAnioLectivo
                                  });
                   
                    if (select == null)
                    {
                        IdAnio_Lectivo_Activo = 0;
                    }
                    else
                    {

                        IdAnio_Lectivo_Activo = select.FirstOrDefault().IdAnioLectivo;
                    }
                    return IdAnio_Lectivo_Activo;
                }
                
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

        public List<Aca_Anio_Lectivo_Info> Get_List_Anio_Lectivo(int IdInstitucion)
        {
            List<Aca_Anio_Lectivo_Info> lstPeriodoLectivo = new List<Aca_Anio_Lectivo_Info>();
            Aca_Anio_Lectivo_Info infoAca_Anio_Lectivo;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var PeriodoLectivo = from a in Base.Aca_Anio_Lectivo 
                                         where a.IdInstitucion == IdInstitucion && a.Estado == "A"
                                      select a;

                    foreach (var item in PeriodoLectivo)
                    {
                        infoAca_Anio_Lectivo = new Aca_Anio_Lectivo_Info();
                        infoAca_Anio_Lectivo.IdInstitucion = item.IdInstitucion;
                        infoAca_Anio_Lectivo.IdAnioLectivo = item.IdAnioLectivo;

                        infoAca_Anio_Lectivo.Descripcion = item.Descripcion;
                        infoAca_Anio_Lectivo.FechaInicio = item.FechaInicio;
                        infoAca_Anio_Lectivo.FechaFin = item.FechaFin;
                        infoAca_Anio_Lectivo.Estado = item.Estado;
                        lstPeriodoLectivo.Add(infoAca_Anio_Lectivo);
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
        public bool Grabar(Aca_Anio_Lectivo_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base=new Entities_Academico())
                {
                    Aca_Anio_Lectivo address = new Aca_Anio_Lectivo();
                    address.IdInstitucion = info.IdInstitucion;
                    address.IdAnioLectivo = info.IdAnioLectivo;
                    address.Descripcion = info.Descripcion;
                    address.FechaInicio = info.FechaInicio;
                    address.FechaFin = info.FechaFin;
                    address.Estado = "A";
                    address.FechaCreacion = info.FechaCreacion;
                    address.UsuarioCreacion = info.UsuarioCreacion;
                    Base.Aca_Anio_Lectivo.Add(address);
                    Base.SaveChanges();
                    mensaje = "Se ha procedido ingresar un nuevo periodo lectivo exitosamente ";
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

        public bool Actualizar(Aca_Anio_Lectivo_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base=new Entities_Academico())
                {
                    var anioLectivo = Base.Aca_Anio_Lectivo.FirstOrDefault(o => o.IdInstitucion == info.IdInstitucion && o.IdAnioLectivo == info.IdAnioLectivo);
                    if (anioLectivo != null)
                    {
                        anioLectivo.Descripcion = info.Descripcion;
                        anioLectivo.FechaInicio = info.FechaInicio;
                        anioLectivo.FechaFin = info.FechaFin;
                        anioLectivo.Estado = info.Estado;
                        anioLectivo.FechaModificacion = info.FechaModificacion;
                        anioLectivo.UsuarioModificacion = info.UsuarioModificacion;
                        Base.SaveChanges();
                        mensaje = "Se ha procedido actualizar el periodo lectivo exitosamente ";
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

        public bool AnularDB(Aca_Anio_Lectivo_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var address = context.Aca_Anio_Lectivo.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdAnioLectivo == info.IdAnioLectivo);
                    if (address != null)
                    {
                        address.Estado = "I";
                        address.FechaAnulacion = DateTime.Now;
                        address.UsuarioAnulacion = info.UsuarioAnulacion;
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        mensaje = "Se ha procedido anular el periodo leactivo: " + info.IdAnioLectivo.ToString() + " exitosamente.";
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
