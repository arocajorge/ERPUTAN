using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Conciliacion_det_no_conciliado_Data
    {/*
       string mensaje = "";
        public List<ba_Conciliacion_det_no_conciliado_Info> Get_List_Conciliacion_det_no_conciliado(int IdEmpresa, int IdConciliacion, int Secuencia)
        {
            //try
            //{
            //   List<ba_Conciliacion_det_no_conciliado_Info> lM = new List<ba_Conciliacion_det_no_conciliado_Info>();
            //    EntitiesBanco db = new EntitiesBanco();

            //    var select_ = from T in db.ba_Conciliacion_det_no_conciliado
            //                  where T.IdEmpresa == IdEmpresa && T.IdConciliacion==IdConciliacion && T.Secuencia==Secuencia 
            //                  select T;


            //    foreach (var item in select_)
            //    {
            //        ba_Conciliacion_det_no_conciliado_Info dat = new ba_Conciliacion_det_no_conciliado_Info();

            //        dat.IdEmpresa = item.IdEmpresa;
            //        dat.IdConciliacion= item.IdConciliacion;
            //        dat.Secuencia	= item.Secuencia;
            //        dat.IdCbteCble= item.IdCbteCble;
            //        dat.IdTipocbte= item.IdTipocbte;
            //        dat.tipo_IngEgr = item.tipo_IngEgr;
            //        dat.SecuenciaCbte= item.SecuenciaCbte;
            //        dat.Estado= item.Estado;
            //        dat.IdUsuario= item.IdUsuario;
            //        dat.IdUsuario_Anu= item.IdUsuario_Anu;
            //        dat.IdUsuarioUltMod= item.IdUsuarioUltMod;
            //        dat.Fecha_Transac= item.Fecha_Transac;
            //        dat.Fecha_UltMod= item.Fecha_UltMod;
            //        dat.FechaAnulacion= item.FechaAnulacion;
            //        dat.ip= item.ip;
            //        dat.nom_pc= item.nom_pc;
            //        dat.MotivoAnulacion = item.MotivoAnulacion;

            //        lM.Add(dat);
            //    }
            //    return (lM);
            //}
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
        }

        public List<vwba_TransaccionesAConciliar_Info> Get_List_TransaccionesAConciliar(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                List<vwba_TransaccionesAConciliar_Info> lM = new List<vwba_TransaccionesAConciliar_Info>();
                EntitiesBanco b = new EntitiesBanco();


                var select_ = from T in b.vwba_Conciliacion_det_no_conciliado 
                              where T.IdEmpresa == IdEmpresa && T.IdConciliacion == IdConciliacion

                              select T;
                foreach (var item in select_)
                {
                    vwba_TransaccionesAConciliar_Info dat_ = new vwba_TransaccionesAConciliar_Info();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCbteCble = item.IdCbteCble;
                    dat_.IdTipocbte = item.IdTipoCbte;
                    dat_.CodTipoCbte = item.CodTipoCbte;
                    dat_.tc_TipoCbte = item.tc_TipoCbte;
                    dat_.CodTipoCbteBan = item.CodTipoCbteBan;
                    dat_.Descripcion = item.ba_descripcion;
                    dat_.IdPeriodo = item.IdPeriodo;
                    dat_.IdBanco =(int) item.IdBanco;
                    dat_.cb_Fecha = item.cb_Fecha;
                    dat_.cb_Observacion = item.cb_Observacion;
                    dat_.cb_Cheque = item.cb_Cheque;
                    dat_.cb_FechaCheque = item.cb_FechaCheque;
                    dat_.ba_descripcion = item.ba_descripcion;
                    dat_.IdCtaCble = item.IdCtaCble;
                    dat_.pc_Cuenta = item.pc_Cuenta;
                    dat_.dc_Valor = item.dc_Valor;
                    dat_.Estado = item.Estado;
                    dat_.SecuenciaCbteCble = item.SecuenciaCbteCble;
                    dat_.ReferenciaCbte = item.ReferenciaCbte;
                    dat_.IdConciliacion = (int)item.IdConciliacion ;
                    dat_.SecuenciaConciliacion = item.SecuenciaConciliacion;
                    dat_.tipo_IngEgr = item.tipo_IngEgr;
                    dat_.No_Conciliado = item.No_Conciliado;

                    

                    dat_.chk = false;

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

        public int getSecuencia(int IdEmpresa, int IdConciliacion)
        {
            try
            {
                int Id;
                EntitiesBanco base_ = new EntitiesBanco();

                var q = from C in base_.ba_Conciliacion_det_no_conciliado
                        where C.IdEmpresa == IdEmpresa && C.IdConciliacion == IdConciliacion
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from T in base_.ba_Conciliacion_det_no_conciliado
                                   where T.IdEmpresa == IdEmpresa && T.IdConciliacion == IdConciliacion
                                   select T.Secuencia).Max();
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }


        public Boolean GrabarDB(ba_Conciliacion_det_no_conciliado_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    EntitiesBanco EDB = new EntitiesBanco();

                    //var contact = ba_Conciliacion_det_no_conciliado.Createba_Conciliacion_det_no_conciliado(0,0,0,0,0,0,"");
                    var address = new ba_Conciliacion_det_no_conciliado();


                    address.IdEmpresa = info.IdEmpresa;
                    address.IdConciliacion = info.IdConciliacion;
                    address.Secuencia = info.Secuencia;
                    address.IdCbteCble = info.IdCbteCble;
                    address.IdTipocbte = info.IdTipocbte;
                    address.SecuenciaCbte = info.SecuenciaCbte;
                    address.Estado = info.Estado;
                    address.tipo_IngEgr = info.tipo_IngEgr;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.ip = info.ip;
                    address.nom_pc = info.nom_pc;
                   
                    //contact = address;

                    context.ba_Conciliacion_det_no_conciliado.Add(address);
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


        public Boolean ModificarDB(ba_Conciliacion_det_no_conciliado_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Conciliacion_det_no_conciliado.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdConciliacion == info.IdConciliacion && minfo.Secuencia == info.Secuencia);
               
                    contact.IdCbteCble = info.IdCbteCble;
                    contact.IdTipocbte = info.IdTipocbte;
                    contact.SecuenciaCbte = info.SecuenciaCbte;
                    contact.Estado = info.Estado;
                    contact.Fecha_UltMod = info.Fecha_UltMod;
                    contact.IdUsuarioUltMod = info.IdUsuarioUltMod;

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

        public Boolean AnularDB(ba_Conciliacion_det_no_conciliado_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Conciliacion_det_no_conciliado.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdConciliacion == info.IdConciliacion && minfo.Secuencia == info.Secuencia);
                    
                    contact.Estado = "I";
                    contact.FechaAnulacion = info.FechaAnulacion;
                    contact.IdUsuario_Anu = info.IdUsuario_Anu;
                    contact.MotivoAnulacion = info.MotivoAnulacion;

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


        public Boolean EliminarDB(int IdEmpresa, int IdConciliacion)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
               

                context.Database.ExecuteSqlCommand("delete from ba_Conciliacion_det_no_conciliado where IdEmpresa ='" + IdEmpresa + "' and IdConciliacion='" + IdConciliacion + "' ");
                       
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

        public ba_Conciliacion_det_no_conciliado_Data()
        {
            
        }
    }
      * */
    }
}
