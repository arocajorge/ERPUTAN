using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_cbtecble_Plantilla_Data
    {
        string mensaje = "";

        public List<ct_cbtecble_Plantilla_Info> Get_list_Plantilla(int IdEmpresa)
        {
            try
            {
                List<ct_cbtecble_Plantilla_Info> lM = new List<ct_cbtecble_Plantilla_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from C in OECbtecble_Info.ct_cbtecble_Plantilla 
                                     where C.IdEmpresa == IdEmpresa
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    ct_cbtecble_Plantilla_Info Pla_I = new ct_cbtecble_Plantilla_Info();
                    Pla_I.IdEmpresa = item.IdEmpresa;
                    Pla_I.IdTipoCbte = item.IdTipoCbte;
                    Pla_I.IdPlantilla = item.IdPlantilla;
                    Pla_I.cb_Fecha = Convert.ToDateTime(item.cb_Fecha);
                    Pla_I.cb_Observacion = item.cb_Observacion;
                    Pla_I.cb_Estado = item.cb_Estado;
                    Pla_I.IdUsuario = item.IdUsuario;
                    Pla_I.IdUsuarioAnu = item.IdUsuarioAnu;
                    Pla_I.cb_MotivoAnu = item.cb_MotivoAnu;
                    Pla_I.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    Pla_I.cb_FechaAnu = Convert.ToDateTime(item.cb_FechaAnu);
                    Pla_I.cb_FechaTransac = Convert.ToDateTime(item.cb_FechaTransac);
                    Pla_I.cb_FechaUltModi = Convert.ToDateTime(item.cb_FechaUltModi);
                    lM.Add(Pla_I);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_cbtecble_Plantilla_Info Get_Info_Plantilla(int IdEmpresa,int IdTipoCbte,decimal IdPlantilla)
        {
            try
            {
                ct_cbtecble_Plantilla_Info Pla_I = new ct_cbtecble_Plantilla_Info();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from C in OECbtecble_Info.ct_cbtecble_Plantilla
                                     where C.IdEmpresa == IdEmpresa && C.IdTipoCbte == IdTipoCbte && C.IdPlantilla==IdPlantilla
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    
                    Pla_I.IdEmpresa = item.IdEmpresa;
                    Pla_I.IdTipoCbte = item.IdTipoCbte;
                    Pla_I.IdPlantilla = item.IdPlantilla;
                    Pla_I.cb_Fecha = Convert.ToDateTime( item.cb_Fecha);
                    Pla_I.cb_Observacion = item.cb_Observacion;
                    Pla_I.cb_Estado = item.cb_Estado;
                    Pla_I.IdUsuario = item.IdUsuario;
                    Pla_I.IdUsuarioAnu = item.IdUsuarioAnu;
                    Pla_I.cb_MotivoAnu = item.cb_MotivoAnu;
                    Pla_I.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    Pla_I.cb_FechaAnu = Convert.ToDateTime(item.cb_FechaAnu);
                    Pla_I.cb_FechaTransac = Convert.ToDateTime(item.cb_FechaTransac);
                    Pla_I.cb_FechaUltModi = Convert.ToDateTime(item.cb_FechaUltModi);
                    
                    ct_cbtecble_Plantilla_det_Data data=new ct_cbtecble_Plantilla_det_Data();

                    Pla_I.LstDet = data.Get_list_Planilla_det( IdEmpresa, IdTipoCbte, IdPlantilla);
                   
                }
                return (Pla_I);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal Get_IdPlantilla(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesDBConta OECbtecble = new EntitiesDBConta();
                var select = from q in OECbtecble.ct_cbtecble_Plantilla
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id= 1;
                }
                else
                {
                    var select_ = (from q in OECbtecble.ct_cbtecble_Plantilla
                                          where q.IdEmpresa == IdEmpresa
                                          select q.IdPlantilla).Max();
                    Id = Convert.ToDecimal(select_.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_cbtecble_Plantilla_Info Pla_I)
        {
            try
            {
                List<ct_cbtecble_Plantilla_det_Info> listadetalle = new List<ct_cbtecble_Plantilla_det_Info>();
                listadetalle = Pla_I.LstDet;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble_Plantilla.FirstOrDefault(v => v.IdEmpresa == Pla_I.IdEmpresa 
                        && v.IdTipoCbte == Pla_I.IdTipoCbte && v.IdPlantilla == Pla_I.IdPlantilla);

                    if (contact != null)
                    {

                        contact.cb_Estado = Pla_I.cb_Estado;
                        contact.IdPlantilla = Pla_I.IdPlantilla;
                        contact.IdUsuarioUltModi = (Pla_I.IdUsuarioUltModi != "") ? Pla_I.IdUsuarioUltModi : Pla_I.IdUsuario;
                        contact.cb_Fecha = Pla_I.cb_Fecha;
                        contact.cb_FechaUltModi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        contact.cb_Observacion = Pla_I.cb_Observacion;
                        context.SaveChanges();


                        ct_cbtecble_Plantilla_det_Data _Pla_Det_Data = new ct_cbtecble_Plantilla_det_Data();

                        int count = 0;
                        if (_Pla_Det_Data.EliminarDB(Pla_I.IdEmpresa, Pla_I.IdTipoCbte, Pla_I.IdPlantilla))
                        {
                            ct_cbtecble_Plantilla_det_Data data = new ct_cbtecble_Plantilla_det_Data();
                            foreach (var reg in listadetalle)
                            {
                                reg.IdEmpresa = Pla_I.IdEmpresa;
                                reg.IdTipoCbte = Pla_I.IdTipoCbte;
                                reg.IdPlantilla = Pla_I.IdPlantilla;
                                //reg.secuencia = count++;
                                data.GrabarDB(reg);
                            }
                        }
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
       
        public Boolean GrabarDB(ct_cbtecble_Plantilla_Info Info, ref decimal ID, ref string msg)
        {
            try
            {
                int IdSecuencia = 0;
                ID = Get_IdPlantilla(Info.IdEmpresa);
                Info.IdPlantilla = ID;
                ct_Cbtecble_tipo_Data data = new ct_Cbtecble_tipo_Data();
                string codigo_CbteCble;

                if (data.Get_Codigo_x_CbtCble_tipo(Info.IdEmpresa, Info.IdTipoCbte, ref msg) == null)  
                {
                    msg = "ID Tipo Comprobante no existe";
                    return false;
                }
                
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();

                    var Q = from tbCbteCble in EDB.ct_cbtecble_Plantilla
                            where tbCbteCble.IdEmpresa  == Info.IdEmpresa 
                            && tbCbteCble.IdTipoCbte == Info.IdTipoCbte
                            && tbCbteCble.IdPlantilla == Info.IdPlantilla
                            select tbCbteCble;

                    if (Q.ToList().Count == 0)
                    {                       
                        var address = new ct_cbtecble_Plantilla();

                        address.IdPlantilla = ID;
                        address.IdEmpresa = Info.IdEmpresa;
                        address.IdTipoCbte = Info.IdTipoCbte;
                        address.cb_Fecha = Info.cb_Fecha;
                        address.cb_Observacion = Info.cb_Observacion;
                        address.cb_Estado = Info.cb_Estado;
                        address.IdUsuario = Info.IdUsuario;
                        address.IdUsuarioUltModi = Info.IdUsuario;
                        address.cb_FechaTransac = Info.cb_FechaTransac;
                        address.cb_FechaUltModi = Info.cb_FechaTransac;

                        context.ct_cbtecble_Plantilla.Add(address);
                        context.SaveChanges();

                        ct_cbtecble_Plantilla_det_Data PlaDet_Data = new ct_cbtecble_Plantilla_det_Data();
                        foreach (var item in Info.LstDet)
                        {
                            item.IdPlantilla  = ID;
                            item.IdEmpresa = Info.IdEmpresa;
                            item.IdPlantilla = Info.IdPlantilla;
                            item.IdTipoCbte = Info.IdTipoCbte;
                            PlaDet_Data.GrabarDB(item);
                        }
                        msg = "Se ha procedido a generar el la Plantilla #: " + ID.ToString() + " para el tipo de comprobante #: " + Info.IdTipoCbte + " exitosamente.";
                    }
                    else
                    {
                        msg = "No se pudo guardar la Plantilla debido a que el id de Plantilla existe";
                        return false;
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
                mensaje = ex.ToString();

                msg = "Mensaje de error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(ct_cbtecble_Plantilla_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble_Plantilla.FirstOrDefault(tb => tb.IdEmpresa == info.IdEmpresa && tb.IdTipoCbte == info.IdTipoCbte && tb.IdPlantilla == info.IdPlantilla);
                    if (contact != null)
                    {
                        contact.cb_Estado = "I";
                        contact.IdUsuarioAnu = info.IdUsuarioAnu;
                        contact.cb_MotivoAnu = info.cb_MotivoAnu;
                        contact.cb_Observacion = "*** ANULADO *** - " + info.cb_Observacion;
                        contact.cb_FechaAnu = DateTime.Now;
                        context.SaveChanges();

                        ct_cbtecble_Plantilla_det_Data PLa_Data = new ct_cbtecble_Plantilla_det_Data();
                        List<ct_cbtecble_Plantilla_det_Info> Lista_detalle = new List<ct_cbtecble_Plantilla_det_Info>();
                        Lista_detalle = PLa_Data.Get_list_Planilla_det(info.IdEmpresa, info.IdTipoCbte, info.IdPlantilla);

                        foreach (var item in Lista_detalle)
                        {
                            item.dc_Observacion = "***ANULADO*** - " + item.dc_Observacion;
                            PLa_Data.ModificarDB(item);
                        }
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

        public ct_cbtecble_Plantilla_Data()
        {
        }
    }
}
