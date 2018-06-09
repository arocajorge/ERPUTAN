using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.Academico;
using Core.Erp.Data.Facturacion_CAH;
using Core.Erp.Info.Factuarcion_CAH;


namespace Core.Erp.Data.Facturacion_CAH
{
    public class fa_notaCredDeb_aca_Data
    {
        #region "Insertar, Actualizar, Eliminar"
        public bool Grabar(fa_notaCredDeb_aca_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    fa_notaCredDeb_aca address = new fa_notaCredDeb_aca();
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdBodega = info.IdBodega;
                    address.IdNotaCredDeb = info.IdNotaCredDeb;
                    address.IdInstitucion = info.IdInstitucion;
                    address.IdEstudiante = info.IdEstudiante;
                    //address.IdTipoNota = info.IdTipoNota;
                    address.Observaciones = "";
                    //address.estado = info.estado;
                    Base.fa_notaCredDeb_aca.Add(address);
                    Base.SaveChanges();
                    mensaje = "Se registro la asociacion de la Nota de Credito con el Estudiante";


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

        public bool Actualizar(fa_notaCredDeb_aca_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var address = Base.fa_notaCredDeb_aca.FirstOrDefault(o => o.IdInstitucion == info.IdInstitucion && o.IdNotaCredDeb == info.IdNotaCredDeb);
                    if (address != null)
                    {
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdSucursal = info.IdSucursal;
                        address.IdBodega = info.IdBodega;
                        address.IdNotaCredDeb = info.IdNotaCredDeb;
                        address.IdInstitucion = info.IdInstitucion;
                        address.IdEstudiante = info.IdEstudiante;
                        //address.IdTipoNota = info.IdTipoNota;
                        address.Observaciones = info.Observaciones;

                        //address.estado = info.estado;
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

        public bool AnularDB(fa_notaCredDeb_aca_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var address = Base.fa_notaCredDeb_aca.FirstOrDefault(o => o.IdInstitucion == info.IdInstitucion && o.IdNotaCredDeb == info.IdNotaCredDeb);
                    if (address != null)
                    {

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


        public List<fa_notaCredDeb_aca_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNotaCredDeb, ref string mensaje)
        {
            try
            {
                List<fa_notaCredDeb_aca_Info> lista = new List<fa_notaCredDeb_aca_Info>();


                using (Entities_Academico Context = new Entities_Academico())
                {

                    var contact = from q in Context.vwACA_fa_notaCredDeb
                                  // where q.IdInstitucion == IdInstitucion
                                  //&& q.IdPreFacturacion == IdPrefacturacion

                                  select q;

                    foreach (var item in contact)
                    {
                        fa_notaCredDeb_aca_Info address = new fa_notaCredDeb_aca_Info();
                        address.IdInstitucion = item.IdInstitucion;
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdBodega = item.IdBodega;
                        address.IdNotaCredDeb = item.IdNota;
                        address.IdInstitucion = item.IdInstitucion;
                        address.IdTipoNota = item.IdTipoNota;
                        address.IdEstudiante = item.IdEstudiante;
                        address.Observaciones = item.Observaciones;
                        //address.estado = item.Estado;

                        lista.Add(address);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public fa_notaCredDeb_aca_Info Get_Info(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNotaCredDeb)
        {
            try
            {
                List<fa_notaCredDeb_aca_Info> lista = new List<fa_notaCredDeb_aca_Info>();
                fa_notaCredDeb_aca_Info address = new fa_notaCredDeb_aca_Info();

                using (Entities_Academico Context = new Entities_Academico())
                {
                    vwACA_fa_notaCredDeb vwNota = Context.vwACA_fa_notaCredDeb.FirstOrDefault(v => v.IdEmpresa==IdEmpresa 
                                                                                            && v.IdSucursal == IdSucursal
                                                                                            && v.IdBodega == IdBodega
                                                                                            && v.IdNota == IdNotaCredDeb
                                                                                            );

                    if (vwNota != null)
                    {
                        address.IdInstitucion = vwNota.IdInstitucion;
                        address.IdEmpresa = vwNota.IdEmpresa;
                        address.IdSucursal = vwNota.IdSucursal;
                        address.IdBodega = vwNota.IdBodega;
                        address.IdNotaCredDeb = vwNota.IdNota;
                        address.IdInstitucion = vwNota.IdInstitucion;
                        address.IdEstudiante = vwNota.IdEstudiante;
                        address.Observaciones = vwNota.Observaciones;
                    }
                }
                return address;
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
