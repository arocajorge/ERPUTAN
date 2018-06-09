using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Caja
{
    public class caj_Caja_Movimiento_Tipo_Data
    {

        public List<caj_Caja_Movimiento_Tipo_Info> Get_list_Caja_Movimiento_Tipo(ref string MensajeError)
        {
                List<caj_Caja_Movimiento_Tipo_Info> lM = new List<caj_Caja_Movimiento_Tipo_Info>();
                EntitiesCaja db = new EntitiesCaja();
            try
            {
                var select_ = from T in db.vwcaj_Caja_Movimiento_Tipo
//                              where T.IdEmpresa == IdEmpresa 
                              select T;


                foreach (var item in select_)
                {
                    caj_Caja_Movimiento_Tipo_Info dat = new caj_Caja_Movimiento_Tipo_Info();

                    dat.IdEmpresa=item.IdEmpresa;
                    dat.IdTipoMovi= item.IdTipoMovi;
                    dat.tm_descripcion = item.tm_descripcion;
                    dat.Estado = item.Estado;
                    dat.tm_Signo = item.tm_Signo;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.pc_clave_corta = item.pc_clave_corta;
                    dat.pc_Cuenta = item.pc_Cuenta;
                    dat.IngEgr = (item.tm_Signo == "+") ? "Ingreso" : "Egreso";
                    dat.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    dat.SeDeposita = item.SeDeposita;

                    lM.Add(dat);
                }
                return (lM);
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

        public List<caj_Caja_Movimiento_Tipo_Info> Get_list_Caja_Movimiento_Tipo(int IdEmpresa,Cl_Enumeradores.eTipo_Ing_Egr eTipo,  ref string MensajeError)
        {
            List<caj_Caja_Movimiento_Tipo_Info> lM = new List<caj_Caja_Movimiento_Tipo_Info>();
            EntitiesCaja db = new EntitiesCaja();
            try
            {
                string SSigno=(eTipo==Cl_Enumeradores.eTipo_Ing_Egr.INGRESOS)?"+":"-";


                var select_ = from T in db.vwcaj_Caja_Movimiento_Tipo
                              where T.IdEmpresa == IdEmpresa 
                              && T.tm_Signo == SSigno
                              select T;


                foreach (var item in select_)
                {
                    caj_Caja_Movimiento_Tipo_Info dat = new caj_Caja_Movimiento_Tipo_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipoMovi = item.IdTipoMovi;
                    dat.tm_descripcion = item.tm_descripcion;
                    dat.Estado = item.Estado;
                    dat.tm_Signo = item.tm_Signo;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.IngEgr = (item.tm_Signo == "+") ? "Ingreso" : "Egreso";
                    dat.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    dat.SeDeposita = item.SeDeposita;

                    lM.Add(dat);
                }
                return (lM);
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

        public List<caj_Caja_Movimiento_Tipo_Info> Get_list_Caja_Movimiento_Tipo(int IdEmpresa, ref string MensajeError)
        {
            List<caj_Caja_Movimiento_Tipo_Info> lM = new List<caj_Caja_Movimiento_Tipo_Info>();
            EntitiesCaja db = new EntitiesCaja();
            try
            {
               
                var select_ = from T in db.vwcaj_Caja_Movimiento_Tipo
                              where T.IdEmpresa == IdEmpresa
                              select T;


                foreach (var item in select_)
                {
                    caj_Caja_Movimiento_Tipo_Info dat = new caj_Caja_Movimiento_Tipo_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipoMovi = item.IdTipoMovi;
                    dat.tm_descripcion = item.tm_descripcion;
                    dat.Estado = item.Estado;
                    dat.tm_Signo = item.tm_Signo;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.pc_Cuenta = item.pc_Cuenta;
                    dat.pc_clave_corta = item.pc_clave_corta;
                    dat.IngEgr = (item.tm_Signo == "+") ? "Ingreso" : "Egreso";
                    dat.SEstado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    dat.SeDeposita = item.SeDeposita;

                    lM.Add(dat);
                }
                return (lM);
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

        public caj_Caja_Movimiento_Tipo_Info Get_Info_Movimiento_Tipo(int IdTipoMovi, int IdEmpresa, ref string MensajeError)
        {
                caj_Caja_Movimiento_Tipo_Info dat = new caj_Caja_Movimiento_Tipo_Info();
                EntitiesCaja db = new EntitiesCaja();
            try
            {

                var select_ = from T in db.vwcaj_Caja_Movimiento_Tipo 
                              where T.IdTipoMovi == IdTipoMovi 
                              && T.IdEmpresa==IdEmpresa 
                              select T;

                foreach (var info in select_)
                {
                    dat.IdTipoMovi = info.IdTipoMovi;
                    dat.tm_descripcion = info.tm_descripcion;
                    dat.Estado = info.Estado;
                    dat.tm_Signo = info.tm_Signo;
                    dat.IdCtaCble = info.IdCtaCble;
                    dat.SeDeposita = info.SeDeposita;
                }
                return dat;
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

        public Boolean GrabarDB(caj_Caja_Movimiento_Tipo_Info Info, ref int id, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    EntitiesCaja EDB = new EntitiesCaja();

                    var address = new caj_Caja_Movimiento_Tipo();
                    id = GetId( ref  MensajeError);
                    address.IdTipoMovi = Info.IdTipoMovi = id;
                    address.tm_descripcion	= Info.tm_descripcion;
                    address.Estado= Info.Estado;
                    address.tm_Signo= Info.tm_Signo;
                    address.IdUsuario= Info.IdUsuario;
                    address.Fecha_Transac= Info.Fecha_Transac;
                    address.nom_pc = Info.nom_pc;
                    address.ip	= Info.ip;
                    address.SeDeposita = Info.SeDeposita;
                    address.IdEmpresa = Info.IdEmpresa;
                    context.caj_Caja_Movimiento_Tipo.Add(address);
                    
                    context.SaveChanges();

                    if (Info.IdCtaCble != null && Info.IdCtaCble != "")
                    {
                        caj_Caja_Movimiento_Tipo_x_CtaCble_Data tipXcta_D = new caj_Caja_Movimiento_Tipo_x_CtaCble_Data();
                        caj_Caja_Movimiento_Tipo_x_CtaCble_Info tipXcta_I = new caj_Caja_Movimiento_Tipo_x_CtaCble_Info();
                        tipXcta_I.IdCtaCble = Info.IdCtaCble;
                        tipXcta_I.IdEmpresa = Info.IdEmpresa == null ? 1 : Convert.ToInt32(Info.IdEmpresa);
                        tipXcta_I.IdTipoMovi = Info.IdTipoMovi;

                        tipXcta_D.GrabarDB(tipXcta_I);
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

        public Boolean ModificarDB(caj_Caja_Movimiento_Tipo_Info Info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var contact = context.caj_Caja_Movimiento_Tipo.First(minfo => minfo.IdTipoMovi  == Info.IdTipoMovi);

                    contact.tm_descripcion = Info.tm_descripcion;
                    contact.Estado = Info.Estado;
                    contact.tm_Signo = Info.tm_Signo;
                    contact.SeDeposita = Info.SeDeposita;
                    contact.IdEmpresa = Info.IdEmpresa;
                     
                    contact.Fecha_UltMod = Info.Fecha_UltMod;
                    contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;

                    context.SaveChanges();

                    if (Info.IdCtaCble != null && Info.IdCtaCble != "")
                    {
                        caj_Caja_Movimiento_Tipo_x_CtaCble_Data tipXcta_D = new caj_Caja_Movimiento_Tipo_x_CtaCble_Data();
                        caj_Caja_Movimiento_Tipo_x_CtaCble_Info tipXcta_I = new caj_Caja_Movimiento_Tipo_x_CtaCble_Info();
                        tipXcta_I.IdCtaCble = Info.IdCtaCble;
                        tipXcta_I.IdEmpresa = Info.IdEmpresa == null ? 1 : Convert.ToInt32(Info.IdEmpresa);
                        tipXcta_I.IdTipoMovi = Info.IdTipoMovi;

                        tipXcta_D.ModificarDB(tipXcta_I);
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

        public Boolean AnularDB(caj_Caja_Movimiento_Tipo_Info Info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var contact = context.caj_Caja_Movimiento_Tipo.FirstOrDefault(minfo => minfo.IdTipoMovi == Info.IdTipoMovi);

                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
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

        public int GetId( ref string MensajeError)
        {
            try
            {
                int Id;
                EntitiesCaja base_ = new EntitiesCaja();

                var q = from C in base_.caj_Caja_Movimiento_Tipo 
                        select C;

                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from CajMoviTip in base_.caj_Caja_Movimiento_Tipo
                                   select CajMoviTip.IdTipoMovi).Max();
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

        public caj_Caja_Movimiento_Tipo_Data(){}
    }
}
