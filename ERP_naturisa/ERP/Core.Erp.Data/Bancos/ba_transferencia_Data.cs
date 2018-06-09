using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Bancos
{
    public class ba_transferencia_Data
    {
        string mensaje = "";

        public List<ba_transferencia_Info> Get_List_transferencia(int IdEmpresa)
        {
            try
            {
                List<ba_transferencia_Info> lM = new List<ba_transferencia_Info>();
                EntitiesBanco b = new EntitiesBanco();


                var select = from q in b.vwba_transferencia 
                             where q.IdEmpresa_origen==IdEmpresa
                             select q ;


                foreach (var item in select)
                {
                    ba_transferencia_Info dat_ = new ba_transferencia_Info();

                    dat_.IdTransferencia=item.IdTransferencia;
                    dat_.IdEmpresa_origen =item.IdEmpresa_origen;
                    dat_.IdCbteCble_origen=item.IdCbteCble_origen;
                    dat_.IdTipocbte_origen=item.IdTipocbte_origen;
                    dat_.IdEmpresa_destino=item.IdEmpresa_destino;
                    dat_.IdCbteCble_destino=item.IdCbteCble_destino;
                    dat_.IdTipocbte_destino=item.IdTipocbte_destino;
                    dat_.tr_observacion=item.tr_observacion;
                    dat_.tr_valor=item.tr_valor;
                    dat_.tr_fecha =item.tr_fecha;
                    dat_.tr_estado =item.tr_estado;
                    dat_.IdUsuario =item.IdUsuario;
                    dat_.IdUsuario_Anu =item.IdUsuario_Anu;
                    dat_.FechaAnulacion =item.FechaAnulacion;
                    dat_.Fecha_Transac =item.Fecha_Transac;
                    dat_.Fecha_UltMod =item.Fecha_UltMod;
                    dat_.IdUsuarioUltMod =item.IdUsuarioUltMod;
                    dat_.ip =item.ip;
                    dat_.nom_pc=item.nom_pc;
                    dat_.tr_MotivoAnulacion =item.tr_MotivoAnulacion;
                    dat_.NEmpresaOrigen=item.NEmpresaOrigen;
                    dat_.NEmpresaDestino = item.NEmpresaDestino;
                    dat_.IdBanco_origen = item.IdBanco_origen;
                    dat_.IdBanco_destino = item.IdBanco_destino;
                    dat_.NBancoOrigen = item.NBancoOrigen;
                    dat_.NBancoDestino = item.NBancoDestino;

                    lM.Add(dat_);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ba_transferencia_Info Get_Info_transferencia(int IdEmpresa, int idtransferencia)
        {
            try
            {
                ba_transferencia_Info lM = new ba_transferencia_Info();
                EntitiesBanco b = new EntitiesBanco();


                var select = from q in b.vwba_transferencia
                             where q.IdEmpresa_origen == IdEmpresa && q.IdTransferencia == idtransferencia
                             select q;

                foreach (var item in select)
                {
                    ba_transferencia_Info dat_ = new ba_transferencia_Info();

                    dat_.IdTransferencia = item.IdTransferencia;
                    dat_.IdEmpresa_origen = item.IdEmpresa_origen;
                    dat_.IdCbteCble_origen = item.IdCbteCble_origen;
                    dat_.IdTipocbte_origen = item.IdTipocbte_origen;
                    dat_.IdEmpresa_destino = item.IdEmpresa_destino;
                    dat_.IdCbteCble_destino = item.IdCbteCble_destino;
                    dat_.IdTipocbte_destino = item.IdTipocbte_destino;
                    dat_.tr_observacion = item.tr_observacion;
                    dat_.tr_valor = item.tr_valor;
                    dat_.tr_fecha = item.tr_fecha;
                    dat_.tr_estado = item.tr_estado;
                    dat_.IdUsuario = item.IdUsuario;
                    dat_.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat_.FechaAnulacion = item.FechaAnulacion;
                    dat_.Fecha_Transac = item.Fecha_Transac;
                    dat_.Fecha_UltMod = item.Fecha_UltMod;
                    dat_.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat_.ip = item.ip;
                    dat_.nom_pc = item.nom_pc;
                    dat_.tr_MotivoAnulacion = item.tr_MotivoAnulacion;
                    dat_.NEmpresaOrigen = item.NEmpresaOrigen;
                    dat_.NEmpresaDestino = item.NEmpresaDestino;
                    dat_.IdBanco_origen = item.IdBanco_origen;
                    dat_.IdBanco_destino = item.IdBanco_destino;
                    dat_.NBancoOrigen = item.NBancoOrigen;
                    dat_.NBancoDestino = item.NBancoDestino;

                    lM=dat_;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(ba_transferencia_Info info,ref decimal IdTranf)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    EntitiesBanco EDB = new EntitiesBanco();

                    var address = new ba_transferencia();

                    address.IdTransferencia = GetId(info.IdEmpresa_origen);
                    IdTranf = address.IdTransferencia;
                    address.IdEmpresa_origen = info.IdEmpresa_origen;
                    address.IdTipocbte_origen = info.IdTipocbte_origen;
                    address.IdCbteCble_origen = info.IdCbteCble_origen;
                    address.IdEmpresa_destino = info.IdEmpresa_destino;
                    address.IdTipocbte_destino = info.IdTipocbte_destino;
                    address.IdCbteCble_destino = info.IdCbteCble_destino;
                    address.tr_observacion = info.tr_observacion;
                    address.tr_valor = info.tr_valor;
                    address.tr_fecha = info.tr_fecha;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.IdUsuario = info.IdUsuario;
                    address.ip = info.ip;
                    address.nom_pc = info.nom_pc;
                    address.tr_estado  = "A";

                    address.IdBanco_origen = info.IdBanco_origen;
                    address.IdBanco_destino = info.IdBanco_destino;


                    context.ba_transferencia.Add(address);
                    context.SaveChanges();
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

        public Boolean ModificarDB(ba_transferencia_Info info, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_transferencia.FirstOrDefault(minfo => minfo.IdEmpresa_origen == info.IdEmpresa_origen && minfo.IdTransferencia == info.IdTransferencia );
                    if (contact != null)
                    {

                        contact.IdTipocbte_origen = info.IdTipocbte_origen;
                        contact.IdCbteCble_origen = info.IdCbteCble_origen;
                        contact.IdEmpresa_destino = info.IdEmpresa_destino;
                        contact.IdTipocbte_destino = info.IdTipocbte_destino;
                        contact.IdCbteCble_destino = info.IdCbteCble_destino;
                        contact.tr_observacion = info.tr_observacion;
                        contact.tr_valor = info.tr_valor;
                        contact.tr_fecha = info.tr_fecha;
                        contact.Fecha_Transac = info.Fecha_Transac;
                        contact.IdUsuario = info.IdUsuario;
                        contact.ip = info.ip;
                        contact.nom_pc = info.nom_pc;
                        contact.tr_estado = "A";
                        contact.IdBanco_origen = info.IdBanco_origen;
                        contact.IdBanco_destino = info.IdBanco_destino;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                 decimal Id;
                    EntitiesBanco base_ = new EntitiesBanco();

                    var q = from C in base_.ba_transferencia 
                            where C.IdEmpresa_origen  == IdEmpresa
                            select C;
                    if (q.ToList().Count == 0)
                        return 1;
                    else
                    {
                        var select_ = (from T in base_.ba_transferencia
                                       where T.IdEmpresa_origen  == IdEmpresa
                                       select T.IdTransferencia).Max();
                        Id = Convert.ToDecimal(select_.ToString()) + 1;
                        return Id;
                    }
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

        public ba_rpt_transferencia_Info Get_Info_rpt_transferencia(int IdEmpresa, int Idtransferencia)
        { 
            try
            {
                string MensajeError = "";
                ba_rpt_transferencia_Info Datos= new ba_rpt_transferencia_Info() ;
                
                
                ct_Cbtecble_det_Data CbteCble_D = new ct_Cbtecble_det_Data();

                Datos.Transf = Get_Info_transferencia(IdEmpresa, Idtransferencia);
                Datos.diario_ND = CbteCble_D.Get_list_Cbtecble_det(Datos.Transf.IdEmpresa_origen, Datos.Transf.IdTipocbte_origen, Datos.Transf.IdCbteCble_origen, ref MensajeError);
                Datos.diario_NC = CbteCble_D.Get_list_Cbtecble_det(Datos.Transf.IdEmpresa_destino, Datos.Transf.IdTipocbte_destino, Datos.Transf.IdCbteCble_destino, ref MensajeError);
                return Datos;
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

        public Boolean AnularDB(ba_transferencia_Info info, ref string msg)
        {
            try
            {
                Boolean res = true;
                    try
                    {
                        using (EntitiesBanco Context = new EntitiesBanco())
                        {
                            var contact = Context.ba_transferencia.FirstOrDefault(A => A.IdEmpresa_origen == info.IdEmpresa_origen
                                && A.IdTransferencia == info.IdTransferencia);
                            if (contact != null)
                            {
                                contact.tr_estado = "I";
                                contact.IdUsuario_Anu = info.IdUsuario_Anu;
                                contact.tr_MotivoAnulacion = info.tr_MotivoAnulacion;
                                contact.FechaAnulacion = info.FechaAnulacion;
                                contact.tr_observacion = info.tr_observacion;
                                Context.SaveChanges();
                                msg = "Grabación exitosa..";
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
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                        msg = ex.ToString() + " " + ex.Message;
                        res = false;
                    }
                    return res;
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
        
        public ba_transferencia_Data()
        {
            
        }
    }
}
