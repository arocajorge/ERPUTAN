using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Bancos;

namespace Core.Erp.Data.Bancos
{
    public class ba_Talonario_cheques_x_banco_Data
    {
        string mensaje = "";

        public List<ba_Talonario_cheques_x_banco_Info> Get_List_Talonario_cheques_x_banco(int IdEmpresa, ref string MensajeErrorOut)
        {
            try
            {
                List<ba_Talonario_cheques_x_banco_Info> lista = new List<ba_Talonario_cheques_x_banco_Info>();                
                EntitiesBanco OEBanco = new EntitiesBanco();
                var selectTalonario = from C in OEBanco.ba_Talonario_cheques_x_banco
                                      join E in OEBanco.ba_Banco_Cuenta on
                                      new { C.IdBanco , C.IdEmpresa} equals new { E.IdBanco , E.IdEmpresa}
                                      where C.IdEmpresa == IdEmpresa
                                  
                                      select new
                                      {
                                          C.IdBanco,
                                          C.IdEmpresa,
                                          C.IdCbteCble_cbtecble_Usado,
                                          C.IdEmpresa_cbtecble_Usado,
                                          C.IdTipoCbte_cbtecble_Usado,
                                          C.Fecha_uso,
                                          C.FechaAnulacion,
                                          C.IdUsuario_Anu,
                                          C.Num_cheque,
                                          C.secuencia,
                                          C.Usado,
                                          C.Estado,
                                          E.ba_descripcion
                                      };

                foreach (var item in selectTalonario)
                {
                    ba_Talonario_cheques_x_banco_Info talCh = new ba_Talonario_cheques_x_banco_Info();

                    talCh.IdEmpresa = item.IdEmpresa;
                    talCh.Estado = item.Estado;
                    talCh.IdBanco = item.IdBanco;
                    talCh.ba_descripcion=item.ba_descripcion;
                    talCh.IdCbteCble_cbtecble_Usado = item.IdCbteCble_cbtecble_Usado;
                    talCh.IdEmpresa_cbtecble_Usado = item.IdEmpresa_cbtecble_Usado;
                    talCh.IdTipoCbte_cbtecble_Usado = item.IdTipoCbte_cbtecble_Usado;
                    talCh.Num_cheque = item.Num_cheque;
                    talCh.secuencia = item.secuencia;
                    talCh.Fecha_uso = item.Fecha_uso;
                    talCh.FechaAnulacion = item.FechaAnulacion;
                    talCh.Usado = item.Usado;
                    talCh.S_Usado = (item.Usado == true) ? "SI" : "NO";

                    lista.Add(talCh);
                }
                return lista;
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

        public List<ba_Talonario_cheques_x_banco_Info> Get_List_Talonario_cheques_x_banco(int IdEmpresa, int IdBanco, ref string MensajeErrorOut)
        {
            try
            {

                List<ba_Talonario_cheques_x_banco_Info> lista = new List<ba_Talonario_cheques_x_banco_Info>();
                EntitiesBanco OEBanco = new EntitiesBanco();
                var selectTalonario = from C in OEBanco.ba_Talonario_cheques_x_banco
                                      join E in OEBanco.ba_Banco_Cuenta on
                                      new { C.IdBanco, C.IdEmpresa } equals new { E.IdBanco, E.IdEmpresa }
                                      where C.IdBanco==IdBanco && C.IdEmpresa==IdEmpresa

                                      select new
                                      {

                                          C.IdBanco,
                                          C.IdEmpresa,
                                          C.IdCbteCble_cbtecble_Usado,
                                          C.IdEmpresa_cbtecble_Usado,
                                          C.IdTipoCbte_cbtecble_Usado,
                                          C.Num_cheque,
                                          C.secuencia,
                                          C.Usado,
                                          C.Estado,
                                          E.ba_descripcion


                                      };

                foreach (var item in selectTalonario)
                {
                    ba_Talonario_cheques_x_banco_Info talCh = new ba_Talonario_cheques_x_banco_Info();

                    talCh.IdEmpresa = item.IdEmpresa;
                    talCh.Estado = item.Estado;
                    talCh.IdBanco = item.IdBanco;
                    talCh.IdCbteCble_cbtecble_Usado = item.IdCbteCble_cbtecble_Usado;
                    talCh.IdEmpresa_cbtecble_Usado = item.IdEmpresa_cbtecble_Usado;
                    talCh.IdTipoCbte_cbtecble_Usado = item.IdTipoCbte_cbtecble_Usado;
                    talCh.Num_cheque = item.Num_cheque;
                    talCh.secuencia = item.secuencia;
                    talCh.Usado = item.Usado;
                    talCh.S_Usado = (item.Usado == true) ? "SI" : "NO";


                    lista.Add(talCh);
                }
                return lista;
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

        public ba_Talonario_cheques_x_banco_Info Get_Info_Ultimo_cheq_no_usuado(int IdEmpresa,int IdBanco, ref string MensajeErrorOut)
        {
            try
            {
                string sUltCheq = "";
                ba_Talonario_cheques_x_banco_Info talCh = new ba_Talonario_cheques_x_banco_Info();


                List<ba_Talonario_cheques_x_banco_Info> lista = new List<ba_Talonario_cheques_x_banco_Info>();
                EntitiesBanco OEBanco = new EntitiesBanco();


                var select = (from q in OEBanco.ba_Talonario_cheques_x_banco
                              where q.IdEmpresa == IdEmpresa
                              && q.IdBanco == IdBanco
                              && q.Usado == false
                              && q.Estado == "A"
                              select q.Num_cheque).Min();

                if (select == null)
                {
                    sUltCheq = "";
                }
                else
                {
                    sUltCheq = select.ToString();
                }


                var selectTalonario = from C in OEBanco.ba_Talonario_cheques_x_banco
                                      where C.IdEmpresa == IdEmpresa
                                      && C.Usado==false
                                      && C.IdBanco == IdBanco
                                      && C.Num_cheque == sUltCheq
                                      select C;

                                     
                foreach (var item in selectTalonario)
                {
                    

                    talCh.IdEmpresa = item.IdEmpresa;
                    talCh.Estado = item.Estado;
                    talCh.IdBanco = item.IdBanco;
                    talCh.IdCbteCble_cbtecble_Usado = item.IdCbteCble_cbtecble_Usado;
                    talCh.IdEmpresa_cbtecble_Usado = item.IdEmpresa_cbtecble_Usado;
                    talCh.IdTipoCbte_cbtecble_Usado = item.IdTipoCbte_cbtecble_Usado;
                    talCh.Num_cheque = item.Num_cheque;
                    talCh.secuencia = item.secuencia;
                    talCh.Usado = item.Usado;

                  
                }
                return talCh;
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
        public Boolean Get_Info_Cheq_existe(int IdEmpresa, int IdBanco, string NumCheque, ref string Mensaje)
        {
            try
            {
                EntitiesBanco OEBanco = new EntitiesBanco();

                var select = (from q in OEBanco.ba_Talonario_cheques_x_banco
                             where q.IdEmpresa == IdEmpresa
                             && q.IdBanco == IdBanco
                             && q.Num_cheque==NumCheque
                             select q.Num_cheque).Any();
                if (select != false)
                {
                    return false;
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

        public ba_Talonario_cheques_x_banco_Info Get_Info_Ultimo_cheq_banco(int IdEmpresa, int IdBanco, ref string MensajeErrorOut)
        {
            try
            {
                string sUltCheq = "";
                ba_Talonario_cheques_x_banco_Info talCh = new ba_Talonario_cheques_x_banco_Info();


                List<ba_Talonario_cheques_x_banco_Info> lista = new List<ba_Talonario_cheques_x_banco_Info>();
                EntitiesBanco OEBanco = new EntitiesBanco();


                var select = (from q in OEBanco.ba_Talonario_cheques_x_banco
                              where q.IdEmpresa == IdEmpresa
                              && q.IdBanco == IdBanco
                              select q.Num_cheque).Max();

                if (select == null)
                {
                    sUltCheq = "";
                }
                else
                {
                    sUltCheq = select.ToString();
                }


                var selectTalonario = from C in OEBanco.ba_Talonario_cheques_x_banco
                                      where C.IdEmpresa == IdEmpresa
                                      && C.IdBanco == IdBanco
                                      && C.Num_cheque == sUltCheq
                                      select C;


                foreach (var item in selectTalonario)
                {


                    talCh.IdEmpresa = item.IdEmpresa;
                    talCh.Estado = item.Estado;
                    talCh.IdBanco = item.IdBanco;
                    talCh.IdCbteCble_cbtecble_Usado = item.IdCbteCble_cbtecble_Usado;
                    talCh.IdEmpresa_cbtecble_Usado = item.IdEmpresa_cbtecble_Usado;
                    talCh.IdTipoCbte_cbtecble_Usado = item.IdTipoCbte_cbtecble_Usado;
                    talCh.Num_cheque = item.Num_cheque;
                    talCh.secuencia = item.secuencia;
                    talCh.Usado = item.Usado;


                }
                return talCh;
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
     
        public Boolean GrabarDB(ba_Talonario_cheques_x_banco_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    EntitiesBanco EDB = new EntitiesBanco();

                    var Q = from per in EDB.ba_Talonario_cheques_x_banco
                            where (per.Num_cheque == info.Num_cheque
                            && per.IdEmpresa == info.IdEmpresa
                            && per.IdBanco == info.IdBanco) ||
                            (per.secuencia == info.secuencia
                            && per.IdEmpresa == info.IdEmpresa
                            && per.IdBanco == info.IdBanco) 
                            select per;
                
                    if (Q.ToList().Count == 0)
                    {
                        var address = new ba_Talonario_cheques_x_banco();

                        address.IdEmpresa = info.IdEmpresa;
                        address.secuencia = GetSecuencia(info.IdEmpresa);
                        address.IdBanco = info.IdBanco;
                        address.IdCbteCble_cbtecble_Usado = info.IdCbteCble_cbtecble_Usado;
                        address.IdEmpresa_cbtecble_Usado = info.IdEmpresa_cbtecble_Usado;
                        address.IdTipoCbte_cbtecble_Usado = info.IdTipoCbte_cbtecble_Usado;
                        address.IdUsuario_Anu = (info.IdUsuario_Anu == null) ? "" : info.IdUsuario_Anu;
                        //address.MotivoAnulacion = info.MotivoAnulacion;
                        //address.FechaAnulacion = info.FechaAnulacion;
                        address.Fecha_uso = DateTime.Now;                        
                        address.Num_cheque = info.Num_cheque;
                        address.Usado = info.Usado;
                        address.Estado = info.Estado;

                        context.ba_Talonario_cheques_x_banco.Add(address);
                        context.SaveChanges();

                        mensaje = "Se ha procedido a guardar ..# : " + info.Num_cheque.ToString() + " EXITOSAMENTE";
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                mensaje = "Error al grabar .." + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(ba_Talonario_cheques_x_banco_Info info, string numcheq, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Talonario_cheques_x_banco.FirstOrDefault(obj => obj.Num_cheque == numcheq && obj.IdEmpresa == info.IdEmpresa && obj.IdBanco == info.IdBanco);
                    if (contact != null)
                    {
                        contact.IdCbteCble_cbtecble_Usado = info.IdCbteCble_cbtecble_Usado;
                        contact.IdEmpresa_cbtecble_Usado = info.IdEmpresa_cbtecble_Usado;
                        contact.IdTipoCbte_cbtecble_Usado = info.IdTipoCbte_cbtecble_Usado;
                        contact.IdUsuario_Anu = (info.IdUsuario_Anu == null) ? "" : info.IdUsuario_Anu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.FechaAnulacion = info.FechaAnulacion;
                        contact.Fecha_uso = info.Fecha_uso;
                        contact.Num_cheque = info.Num_cheque;
                        contact.secuencia = info.secuencia;
                        contact.Usado = info.Usado;
                        contact.Estado = info.Estado;
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro  # : " + info.Num_cheque.ToString() + " EXITOSAMENTE";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(ba_Talonario_cheques_x_banco_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Talonario_cheques_x_banco.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.Num_cheque == Info.Num_cheque);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuario_Anu = Info.IdUsuario_Anu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.FechaAnulacion = Info.FechaAnulacion;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public Boolean Modificar_CbteCble(ba_Cbte_Ban_Info CbteBan_I, string Num_cheque, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Talonario_cheques_x_banco.FirstOrDefault(minfo => minfo.IdEmpresa == CbteBan_I.IdEmpresa && minfo.IdBanco == CbteBan_I.IdBanco && minfo.Num_cheque == Num_cheque);
                    if (contact != null)
                    {
                        contact.Usado = true;
                        contact.IdEmpresa_cbtecble_Usado = CbteBan_I.IdEmpresa;
                        contact.IdTipoCbte_cbtecble_Usado = CbteBan_I.IdTipocbte;
                        contact.IdCbteCble_cbtecble_Usado = CbteBan_I.IdCbteCble;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetSecuencia(int IdEmpresa)
        {
            try
            {
                decimal Secuencia;
                EntitiesBanco OETalonario = new EntitiesBanco();
                var select = (from q in OETalonario.ba_Talonario_cheques_x_banco
                              where q.IdEmpresa == IdEmpresa                              
                              select q.secuencia).Max();

                if (select == null)
                {
                    Secuencia = 1;
                }
                else
                {                    
                    Secuencia = Convert.ToDecimal(select.ToString()) + 1;
                }
                return Secuencia;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }
    }
}
