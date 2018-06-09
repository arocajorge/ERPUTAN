using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Academico
{
    public class Aca_Contrato_x_Estudiante_det_Data
    {
        string mensaje = "";
       
        public List<Aca_Contrato_x_Estudiante_det_Info> Get_Lista_Contrato_x_Estudiante_det(int IdInstitucion, decimal IdContrato)
        {
            List<Aca_Contrato_x_Estudiante_det_Info> lista = new List<Aca_Contrato_x_Estudiante_det_Info>();
            Aca_Contrato_x_Estudiante_det_Info Contrato_x_EstudianteInfo;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var vContrato_x_Estudiante = from c in Base.vwAca_Contrato_x_Estudiante_x_Rubro
                                                 where c.IdInstitucion == IdInstitucion && c.IdContrato == IdContrato
                                                 select c;

                    foreach (var item in vContrato_x_Estudiante)
                    {
                        Contrato_x_EstudianteInfo = new Aca_Contrato_x_Estudiante_det_Info();
                        Contrato_x_EstudianteInfo.IdInstitucion = item.IdInstitucion;
                        Contrato_x_EstudianteInfo.IdContrato = item.IdContrato;
                        //Contrato_x_EstudianteInfo.secuencia = item.secuencia;
                        Contrato_x_EstudianteInfo.IdRubro = item.IdRubro;
                        Contrato_x_EstudianteInfo.Descripcion_rubro = item.Descripcion_rubro;
                        Contrato_x_EstudianteInfo.IdInstitucion_Per = item.IdInstitucion_Per;
                        Contrato_x_EstudianteInfo.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                        Contrato_x_EstudianteInfo.IdPeriodo_Per = item.IdPeriodo_Per;

                        Contrato_x_EstudianteInfo.FechaCreacion = item.FechaCreacion;
                        Contrato_x_EstudianteInfo.FechaModificacion = item.FechaModificacion;
                        Contrato_x_EstudianteInfo.FechaAnulacion = item.FechaAnulacion;
                        Contrato_x_EstudianteInfo.UsuarioCreacion = item.UsuarioCreacion;
                        Contrato_x_EstudianteInfo.UsuarioModificacion = item.UsuarioModificacion;
                        Contrato_x_EstudianteInfo.UsuarioAnulacion = item.UsuarioAnulacion;
                        Contrato_x_EstudianteInfo.MotivoAnulacion = item.MotivoAnulacion;

                        Contrato_x_EstudianteInfo.Valor = item.Valor;

                        //Contrato_x_EstudianteInfo.Se_Cobra = item.Se_Cobra;
                        Contrato_x_EstudianteInfo.estado_rubro_contrato = item.estado_rubro_contrato;



                        lista.Add(Contrato_x_EstudianteInfo);
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
        

        public bool GrabarDB(List<Aca_Contrato_x_Estudiante_det_Info> LstInfo)
        {
             try
            {
                int sec = 0;
                foreach (var item in LstInfo)
                {
                    sec = sec + 1;
                    //List<Aca_Contrato_x_Estudiante_det_Info> Lst = new List<Aca_Contrato_x_Estudiante_det_Info>();

                    using (Entities_Academico Base = new Entities_Academico())
                    {
                        Aca_Contrato_x_Estudiante_det Contrato_x_Estudiante = new Aca_Contrato_x_Estudiante_det();
                        Contrato_x_Estudiante.IdInstitucion = item.IdInstitucion;
                        Contrato_x_Estudiante.IdContrato = item.IdContrato;
                        //Contrato_x_Estudiante.secuencia = sec;
                        Contrato_x_Estudiante.IdRubro = item.IdRubro;
                        Contrato_x_Estudiante.IdInstitucion_Per = item.IdInstitucion_Per;
                        Contrato_x_Estudiante.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                        Contrato_x_Estudiante.IdPeriodo_Per = item.IdPeriodo_Per;

                        Contrato_x_Estudiante.FechaCreacion = item.FechaCreacion;
                        ////Contrato_x_Estudiante.FechaModificacion = item.FechaModificacion;
                        ////Contrato_x_Estudiante.FechaAnulacion = item.FechaAnulacion;
                        Contrato_x_Estudiante.UsuarioCreacion = item.UsuarioCreacion;
                        ////Contrato_x_Estudiante.UsuarioModificacion = item.UsuarioModificacion;
                        ////Contrato_x_Estudiante.UsuarioAnulacion = item.UsuarioAnulacion;
                        ////Contrato_x_Estudiante.MotivoAnulacion = item.MotivoAnulacion;

                        Contrato_x_Estudiante.Observacion = item.Observacion;
                        //Contrato_x_Estudiante.Se_Cobra = item.Se_Cobra;
                        //Contrato_x_Estudiante.Se_Cobra = true;

                        //Contrato_x_Estudiante.UsuarioCreacion = info.UsuarioCreacion;
                        //Contrato_x_Estudiante.UsuarioModificacion = info.UsuarioModificacion;
                        Contrato_x_Estudiante.estado = true;

                        Base.Aca_Contrato_x_Estudiante_det.Add(Contrato_x_Estudiante);
                        
                        Base.SaveChanges();
                        ///msg = "Se ha procedido a grabar el Contrato_x_Estudiante #: " + IdContrato_x_Estudiante.ToString() + " exitosamente.";
                    }
                }
                return true;
             }
            //catch (Exception ex)
            //{
            //    string arreglo = ToString();
            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
            //                        "", "", "", "", DateTime.Now);
            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            //    mensaje = ex.InnerException + " " + ex.Message;
            //    throw new Exception(ex.InnerException.ToString());
            //}
             catch (DbEntityValidationException ex)
             {
                 string arreglo = ToString();
                 foreach (var item in ex.EntityValidationErrors)
                 {
                     foreach (var item_validaciones in item.ValidationErrors)
                     {
                         mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                     }
                 }
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                 throw new Exception(mensaje);
             }
        }

        public bool ActualizarDB(Aca_Contrato_x_Estudiante_det_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var vSeccion = Base.Aca_Contrato_x_Estudiante_det.FirstOrDefault(j => j.IdInstitucion == info.IdInstitucion && j.IdContrato == info.IdContrato && j.IdRubro == info.IdRubro && j.IdInstitucion_Per == info.IdInstitucion_Per && j.IdAnioLectivo_Per == info.IdAnioLectivo_Per && j.IdPeriodo_Per == info.IdPeriodo_Per);
                    if (vSeccion != null)
                    {
                        //vSeccion.IdSede = info.IdSede;

                        vSeccion.estado = info.estado_rubro_contrato;
                        vSeccion.FechaModificacion = DateTime.Now;
                        vSeccion.UsuarioModificacion = info.UsuarioModificacion;

                        Base.SaveChanges();
                        mensaje = "Se ha procedido actualizar el Contrato_x_Estudiante #: " + info.IdContrato.ToString() + " exitosamente.";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean AnularDB(Aca_Contrato_x_Estudiante_det_Info info, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var address = context.Aca_Contrato_x_Estudiante_det.FirstOrDefault(a => a.IdContrato == info.IdContrato);
                    if (address != null)
                    {
                        address.estado = false;
                        address.FechaAnulacion = DateTime.Now;
                        address.UsuarioAnulacion = info.UsuarioAnulacion;
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        msg = "Se ha procedido anular Contrato_x_Estudiante #: " + info.IdContrato.ToString() + " exitosamente.";
                    }
                    return true;
                }
            }
            catch (Exception ex)
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
    }
}
