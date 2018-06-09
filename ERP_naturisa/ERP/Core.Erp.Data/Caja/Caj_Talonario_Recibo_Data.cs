using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Caja;

namespace Core.Erp.Data.Caja
{
    public class Caj_Talonario_Recibo_Data
    {
        string mensaje = "";
        string MensajeError = "";

        public List<Caj_Talonario_Recibo_Info> Get_List_Recibo(int IdEmpresa)
        {
            try
            {
                List<Caj_Talonario_Recibo_Info> lm = new List<Caj_Talonario_Recibo_Info>();
                EntitiesCaja OECaja = new EntitiesCaja();
                var q = from A in OECaja.vwCaj_Talonario_Recibo
                        where A.IdEmpresa == IdEmpresa
                        select A;
                foreach (var contact in q)
                {
                    Caj_Talonario_Recibo_Info Info = new Caj_Talonario_Recibo_Info();

                    Info.IdEmpresa = contact.IdEmpresa;
                    Info.IdRecibo = contact.IdRecibo;
                    Info.IdSucursal = contact.IdSucursal;
                    Info.IdPuntoVta = contact.IdPuntoVta;
                    Info.Num_Recibo = contact.Num_Recibo;
                    Info.Usado = contact.Usado;
                    Info.Estado = contact.Estado;
                    Info.Su_Descripcion = contact.Su_Descripcion;
                    Info.nom_PuntoVta = contact.nom_PuntoVta;
                    Info.Su_CodigoEstablecimiento = contact.Su_CodigoEstablecimiento;
                    Info.cod_PuntoVta = contact.cod_PuntoVta;

                    lm.Add(Info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                decimal Id;
                EntitiesCaja base_ = new EntitiesCaja();

                var q = from C in base_.Caj_Talonario_Recibo
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from Q in base_.Caj_Talonario_Recibo
                                   where Q.IdEmpresa == IdEmpresa
                                   select Q.IdRecibo).Max();
                    Id = select_ + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Num_ultimo_Recibo(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdTipo_Docu, ref string MensajeError)//opin 2017/03/23
        {
            try
            {
                string Num_Recibo="";

                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var select_ = (from q in context.Caj_Talonario_Recibo
                                   where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta && q.IdTipo_Docu_cat == IdTipo_Docu 
                                   select q.Num_Recibo).Max();
                    Num_Recibo = Convert.ToString(Convert.ToInt32(select_) + 1).PadLeft(9, '0');
                    return Num_Recibo;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(Caj_Talonario_Recibo_Info Info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var address = new Caj_Talonario_Recibo();

                    address.IdEmpresa = Info.IdEmpresa;
                    address.IdRecibo = GetId(Info.IdEmpresa, ref MensajeError);
                    address.IdSucursal = Info.IdSucursal;
                    address.IdPuntoVta = Info.IdPuntoVta;
                    address.Num_Recibo = Info.Num_Recibo;
                    address.Usado = Info.Usado;
                    address.Estado = Info.Estado;
                    address.IdUsuario = Info.IdUsuario;
                    address.Fecha_Transac = Info.Fecha_Transac;
                    address.nom_pc = Info.nom_pc;
                    address.ip = Info.ip;
                    address.IdUsuario_Responsable = Info.IdUsuario_Responsable;
                    address.IdTipo_Docu_cat = Info.IdTipo_Docu_cat; //opin 2017/03/23
                    context.Caj_Talonario_Recibo.Add(address);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(Caj_Talonario_Recibo_Info Info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var contact = context.Caj_Talonario_Recibo.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdRecibo == Info.IdRecibo);

                    if (contact != null)
                    {
                        //contact.IdSucursal = Info.IdSucursal;
                        //contact.IdPuntoVta = Info.IdPuntoVta;
                        //contact.Num_Recibo = Info.Num_Recibo;
                        contact.Usado = Info.Usado;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = Info.Fecha_UltMod;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(Caj_Talonario_Recibo_Info Info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var contact = context.Caj_Talonario_Recibo.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdRecibo == Info.IdRecibo);

                    if (contact != null)
                    {
                        contact.Estado = Info.Estado;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.MotivoAnu = Info.MotivoAnu;

                        context.SaveChanges();
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Caj_Talonario_Recibo_Info Get_Ultimo_Recibo_No_Usado(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdTipo_Docu, ref string MensajeError)//opin 2017/03/23
        {
            try
            {
              
                Caj_Talonario_Recibo_Info Info = new Caj_Talonario_Recibo_Info();
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var querry = (from q in context.Caj_Talonario_Recibo
                                  where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta && q.IdTipo_Docu_cat == IdTipo_Docu
                                  && q.Usado == false
                                  select q).FirstOrDefault();
                    if (querry != null)
                    {
                        Info.IdEmpresa = querry.IdEmpresa;
                        Info.IdRecibo = querry.IdRecibo;
                        Info.Num_Recibo = querry.Num_Recibo;
                        Info.Usado = querry.Usado;
                    }
                    return Info ;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public string Get_Num_Recibo_optenido(int IdRecibo, ref string MensajeError)//opin 2017/03/24
        {
            try
            {
                string Num_Recibo = "";
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var select_ = (from q in context.Caj_Talonario_Recibo
                                   where q.IdRecibo == IdRecibo 
                                   select q.Num_Recibo).Max();
                    Num_Recibo = Convert.ToString(Convert.ToInt32(select_)).PadLeft(9, '0');
                    return Num_Recibo;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        //public Boolean Documento_talonario_esta_Usado(Caj_Talonario_Recibo_Info Info, ref string mensajeError, ref string mensajeDocumentoDupli)
        //{
        //    try
        //    {
        //        List<Caj_Talonario_Recibo_Info> lm = new List<Caj_Talonario_Recibo_Info>();
        //        EntitiesGeneral OEGeneral = new EntitiesGeneral();
        //        var q = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
        //                 where A.IdEmpresa == Info.IdEmpresa
        //                 && A.PuntoEmision == Info.PuntoEmision
        //                 && A.CodDocumentoTipo == Info.CodDocumentoTipo
        //                 && A.Establecimiento == Info.Establecimiento
        //                 && A.NumDocumento == Info.NumDocumento
        //                 && A.Usado == true
        //                 select A);

        //        if (q.Count() != 0)
        //        {
        //            mensajeDocumentoDupli = "El numero de documento ya se encuentra en uso";
        //            return true;
        //        }
        //        else
        //        {
        //            mensajeDocumentoDupli = "";
        //            return false;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
        //        mensajeError = ex.ToString() + " " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}

        //public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_Doc_disponible(int IdEmpresa, string puntoemision, string establecimiento, string tipodoc, bool Es_Documento_Electronico)
        //{
        //    try
        //    {

        //        List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();

        //        EntitiesGeneral OEGeneral = new EntitiesGeneral();
        //        var querry = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
        //                      where A.IdEmpresa == IdEmpresa
        //                      && A.CodDocumentoTipo == tipodoc
        //                      && A.Establecimiento == establecimiento
        //                      && A.PuntoEmision == puntoemision
        //                      && A.es_Documento_Electronico == Es_Documento_Electronico
        //                      && A.Usado == false
        //                      select A);

        //        foreach (var contact in querry)
        //        {
        //            tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

        //            Info.IdEmpresa = contact.IdEmpresa;
        //            Info.IdSucursal = contact.IdSucursal;
        //            Info.CodDocumentoTipo = contact.CodDocumentoTipo;
        //            Info.Establecimiento = contact.Establecimiento;
        //            Info.Estado = contact.Estado;
        //            Info.FechaCaducidad = contact.FechaCaducidad;
        //            Info.NumAutorizacion = contact.NumAutorizacion;
        //            Info.NumDocumento = contact.NumDocumento;
        //            Info.PuntoEmision = contact.PuntoEmision;
        //            Info.Usado = contact.Usado;
        //            Info.es_Documento_electronico = Convert.ToBoolean(contact.es_Documento_Electronico);
        //            lm.Add(Info);
        //        }

        //        return lm;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
        //        throw new Exception(ex.ToString());
        //    }
        //}

        //public Boolean Modificar_Estado_Usado(int IdEmpresa, string CodDocumentoTipo, string Establecimiento, string PuntoEmision, string NumDocumento, ref string mensajeError)
        //{
        //    try
        //    {

        //        using (EntitiesGeneral Context = new EntitiesGeneral())
        //        {
        //            var Address = Context.tb_sis_Documento_Tipo_Talonario.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa && cot.CodDocumentoTipo == CodDocumentoTipo && cot.Establecimiento == Establecimiento && cot.PuntoEmision == PuntoEmision && cot.NumDocumento == NumDocumento);
        //            if (Address != null)
        //            {
        //                Address.Usado = true;
        //                Context.SaveChanges();
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
        //        mensajeError = ex.ToString() + " " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}
    }
}