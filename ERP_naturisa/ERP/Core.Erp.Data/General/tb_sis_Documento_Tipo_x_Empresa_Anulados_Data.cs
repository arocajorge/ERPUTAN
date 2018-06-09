using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.General
{
    public class tb_sis_Documento_Tipo_x_Empresa_Anulados_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Info)
        {
            try
            {
                List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> Lst = new List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info>();
                using(EntitiesGeneral Context = new EntitiesGeneral())
                {
                   
                    var Address = new tb_sis_Documento_Tipo_x_Empresa_Anulados();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.codDocumentoTipo = Info.codDocumentoTipo;
                    Address.IdTipoDocAnu = get_ID(Info.IdEmpresa);
                    Address.Fecha = Info.Fecha;
                    Address.Serie1 = Info.Serie1;
                    Address.Serie2 = Info.Serie2;
                    Address.Documento = Info.Documento;
                    //Address.DocumentoFin = Info.DocumentoFin;
                    Address.Autorizacion = Info.Autorizacion;
                    Address.IdMotivoAnu = Info.IdMotivoAnu;
                    Address.MotivoAnu = Info.MotivoAnu;
                   
                  
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                  
                    Address.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Address.Fecha_UltAnu = Info.Fecha_UltAnu;

                    Context.tb_sis_Documento_Tipo_x_Empresa_Anulados.Add(Address);
                    Context.SaveChanges();
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

        public decimal get_ID(int IdEmpresa)
        {
            try
            {
                decimal Id = 0;

                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_Documento_Tipo_x_Empresa_Anulados
                            where q.IdEmpresa==IdEmpresa 
                            select q;
                if (Query.ToList().Count == 0)
                    Id= 1;

                else
                {
                    var Query_ = (from q in oEnti.tb_sis_Documento_Tipo_x_Empresa_Anulados
                                where q.IdEmpresa == IdEmpresa
                                select q.IdTipoDocAnu).Max();
                    Id = Convert.ToDecimal(Query_) + 1;
                }
                return Id;
            }
            catch(Exception ex)
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

        public List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> Lst = new List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.vwtb_sis_Documento_Tipo_x_Empresa_Anulados
                            where q.IdEmpresa==IdEmpresa 
                            select q;
                foreach (var item in Query)
                {
                    tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Obj = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.codDocumentoTipo = item.CodDocumentoTipo;
                    //Obj.IdTipoDocAnu = item.IdTipoDocAnu;
                    Obj.Fecha = item.fecha;
                    Obj.Serie1 = item.serie1;
                    Obj.Serie2 = item.serie2;
                    Obj.Documento = item.NumRetencion;
                    //Obj.Autorizacion = item.Autorizacion;
                    //Obj.IdMotivoAnu = item.IdMotivoAnu;
                    //Obj.MotivoAnu = item.MotivoAnu;

                    Obj.Serie = item.serie1 + "-" + item.serie2;
                    Obj.Docu_IniFin = item.NumRetencion;
                    //Obj.nom_DocuTipo = item.Descripcion;
                    //Obj.nom_MotivoAnu = item.ca_descripcion;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch(Exception ex)
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
                   
        public List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> ConsultaPorMesAnio(int IdEmpresa, int anio, int mes)
        {
            try
            {
                #region Antiguo
                /*
                List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> Lst = new List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_Documento_Tipo_x_Empresa_Anulados
                            where q.IdEmpresa == IdEmpresa && q.Fecha.Year == anio && q.Fecha.Month == mes
                            select q;
                foreach (var item in Query)
                {
                    tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Obj = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.codDocumentoTipo = item.codDocumentoTipo;
                    Obj.IdTipoDocAnu = item.IdTipoDocAnu;
                    Obj.Fecha = item.Fecha;
                    Obj.Serie1 = item.Serie1;
                    Obj.Serie2 = item.Serie2;
                    //Obj.DocumentoIni = item.DocumentoInicio;
                    //Obj.DocumentoFin = item.DocumentoFin;
                    Obj.Autorizacion = item.Autorizacion;
                    Obj.IdMotivoAnu = item.IdMotivoAnu;
                    Obj.MotivoAnu = item.MotivoAnu;
                    Obj.nom_pc = item.nom_pc;
                    Obj.ip = item.ip;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.Fecha_UltAnu = item.Fecha_UltAnu;
                    Lst.Add(Obj);
                }

                EntitiesCuentasxPagar oEnti_cxp = new EntitiesCuentasxPagar();


                //Retenciones
                var Query_ret = from q in oEnti_cxp.cp_retencion                                
                             where q.IdEmpresa == IdEmpresa
                             && q.fecha.Year == anio
                             && q.fecha.Month == mes
                             && q.Estado == "I"
                             select q;

                foreach (var item in Query_ret)
                {
                    tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Obj = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.codDocumentoTipo = "07";
                    Obj.IdTipoDocAnu = 0;
                    Obj.Fecha = item.fecha;
                    Obj.Serie1 = item.serie1;
                    Obj.Serie2 = item.serie2;
                    Obj.Documento = item.NumRetencion;
                    Obj.Docu_IniFin = item.NumRetencion;
                    Obj.DocumentoFin = item.NumRetencion;
                    Obj.Autorizacion = item.NAutorizacion;
                    Obj.IdMotivoAnu = 0;
                    Obj.MotivoAnu = item.MotivoAnulacion;
                    Obj.nom_pc = item.nom_pc;
                    Obj.ip = item.ip;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.Fecha_UltAnu = item.Fecha_UltAnu;

                    Lst.Add(Obj);
                }




                EntitiesFacturacion oEnti_fact = new EntitiesFacturacion();

                //ventas de cliente

                var Query_vta = from q in oEnti_fact.fa_factura
                             where q.IdEmpresa == IdEmpresa
                             && q.vt_fecha.Year == anio
                             && q.vt_fecha.Month == mes
                             && q.Estado=="I"
                             select q;

                foreach (var item in Query_vta)
                {
                    tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Obj = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.codDocumentoTipo = "18";
                    Obj.IdTipoDocAnu = 0;
                    Obj.Fecha = item.vt_fecha;
                    Obj.Serie1 = item.vt_serie1;
                    Obj.Serie2 = item.vt_serie2;
                    Obj.Documento = item.vt_NumFactura;
                    Obj.Docu_IniFin = item.vt_NumFactura;
                    Obj.DocumentoFin = item.vt_NumFactura;
                    Obj.Autorizacion = item.vt_autorizacion;
                    Obj.IdMotivoAnu = 0;
                    Obj.MotivoAnu = item.MotivoAnulacion;
                    Obj.nom_pc = item.nom_pc;
                    Obj.ip = item.ip;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.Fecha_UltAnu = item.Fecha_UltAnu;

                    Lst.Add(Obj);
                }

                //notas debito y credito faturacion

                var Query_Nota_deb_cred = from q in oEnti_fact.fa_notaCreDeb
                                where q.IdEmpresa == IdEmpresa
                                && q.no_fecha.Year == anio
                                && q.no_fecha.Month == mes
                                && q.Estado == "I"
                                && q.NaturalezaNota == "SRI"
                                select q;

                foreach (var item in Query_Nota_deb_cred)
                {
                    tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Obj = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.codDocumentoTipo = (item.CreDeb == "C") ? "04" : "05";
                    Obj.IdTipoDocAnu = 0;
                    Obj.Fecha = item.no_fecha;
                    Obj.Serie1 = item.Serie1;
                    Obj.Serie2 = item.Serie2;
                    Obj.Documento = item.NumNota_Impresa;
                    Obj.Docu_IniFin = item.NumNota_Impresa;
                    Obj.DocumentoFin = item.NumNota_Impresa;
                    Obj.Autorizacion = item.NumAutorizacion;
                    Obj.IdMotivoAnu = 0;
                    Obj.MotivoAnu = item.MotiAnula;
                    Obj.nom_pc = item.nom_pc;
                    Obj.ip = item.ip;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.Fecha_UltAnu = item.Fecha_UltAnu;

                    Lst.Add(Obj);
                }
                 * */
                #endregion

                List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> Lst = new List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.vwtb_sis_Documento_Tipo_x_Empresa_Anulados
                            where q.IdEmpresa == IdEmpresa && q.anio == anio && q.mes == mes
                            select q;
                foreach (var item in Query)
                {
                    tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Obj = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.codDocumentoTipo = item.CodDocumentoTipo;
                    //Obj.IdTipoDocAnu = item.IdTipoDocAnu;
                    Obj.Fecha = item.fecha;
                    Obj.Serie1 = item.serie1;
                    Obj.Serie2 = item.serie2;
                    Obj.Docu_IniFin = item.Documento_ini;
                    Obj.DocumentoFin = item.Documento_fin;
                    Obj.Documento = item.NumRetencion;
                    Obj.Autorizacion = item.NumAutorizacion;
                    //Obj.IdMotivoAnu = item.IdMotivoAnu;
                    //Obj.MotivoAnu = item.MotivoAnu;
                    //Obj.nom_pc = item.nom_pc;
                    //Obj.ip = item.ip;
                    //Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    //Obj.Fecha_UltAnu = item.Fecha_UltAnu;
                    Lst.Add(Obj);
                }




                return Lst;
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


        public bool ValidaSiEstaAnulado(int IdEmpresa, string TipoDoc, string serie1, string serie2, string Doc)
        {
            try
            {
                using(EntitiesGeneral enty=new EntitiesGeneral())
	            {
                    var query = from q in enty.tb_sis_Documento_Tipo_x_Empresa_Anulados
                                where q.IdEmpresa == IdEmpresa
                                && q.codDocumentoTipo==TipoDoc
                                && q.Serie1 == serie1 
                                && q.Serie2 == serie2
                                && q.Documento.Contains(Doc)
                                select q;
                    if (query != null)
                    {
                        if (query.ToList().Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_Documento_Tipo_x_Empresa_Anulados_Data(){}
    }
}
