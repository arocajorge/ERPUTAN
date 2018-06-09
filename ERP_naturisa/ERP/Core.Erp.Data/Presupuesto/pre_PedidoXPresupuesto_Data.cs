using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

//8-5-2013
namespace Core.Erp.Data.Presupuesto
{
    public class pre_PedidoXPresupuesto_Data
    {
        string mensaje = "";
        pre_PedidoXPresupuesto_det_Data dat_det = new pre_PedidoXPresupuesto_det_Data();
        public Boolean GrabarDB(pre_PedidoXPresupuesto_Info Info,ref decimal IdPedidoXPre)
        {
            try
            {
                List<pre_PedidoXPresupuesto_Info> Lst = new List<pre_PedidoXPresupuesto_Info>();
                using (EntitiesPresupuesto Context = new EntitiesPresupuesto())
                {
                    var Address = new pre_PedidoXPresupuesto();
                    IdPedidoXPre=getIdPedidoXPre(Info.IdEmpresa);
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdPedidoXPre = IdPedidoXPre;
                    Address.IdDepartamento = Info.IdDepartamento;
                    Address.Fecha = Convert.ToDateTime(Info.Fecha.ToShortDateString()) ;
                    Address.Observacion = Info.Observacion;
                    Address.IdProveedor1 = Info.IdProveedor1;
                    Address.IdProveedor2 = Info.IdProveedor2;
                    Address.IdProveedor3 = Info.IdProveedor3;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.Estado = Info.Estado;
                    Context.pre_PedidoXPresupuesto.Add(Address);
                    Context.SaveChanges();
                    //guardar detalle
                    dat_det.GrabarLista(Info.Lst_PedidoXPre_D, IdPedidoXPre);
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
                throw new Exception(ex.ToString());
            }
        }


        public List<pre_PedidoXPresupuesto_Info> ObtenerList(int IdEmpresa)
        {
            try
            {
                List<pre_PedidoXPresupuesto_Info> Lst = new List<pre_PedidoXPresupuesto_Info>();
                EntitiesPresupuesto oEnti = new EntitiesPresupuesto();
                var Query = from q in oEnti.pre_PedidoXPresupuesto
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {
                    pre_PedidoXPresupuesto_Info Obj = new pre_PedidoXPresupuesto_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdPedidoXPre = item.IdPedidoXPre;
                    Obj.IdDepartamento = item.IdDepartamento;
                    Obj.Fecha = item.Fecha;
                    Obj.Observacion = item.Observacion;
                    Obj.IdProveedor1 = item.IdProveedor1;
                    Obj.IdProveedor2 = item.IdProveedor2;
                    Obj.IdProveedor3 = item.IdProveedor3;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.Fecha_UltMod = item.Fecha_UltMod;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.Fecha_UltAnu = item.Fecha_UltAnu;
                    Obj.nom_pc = item.nom_pc;
                    Obj.ip = item.ip;
                    Obj.Estado = item.Estado;
                   

                    Lst.Add(Obj);
                }
                return Lst;
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

        public decimal getIdPedidoXPre(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesPresupuesto base_ = new EntitiesPresupuesto();

                var q = from C in base_.pre_PedidoXPresupuesto 
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from CbtCble in base_.pre_PedidoXPresupuesto
                                   where CbtCble.IdEmpresa == IdEmpresa
                                   select CbtCble.IdPedidoXPre).Max();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }


        public Boolean ModificarDB(pre_PedidoXPresupuesto_Info info)
        {
            try
            {
                using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                {
                    var contact = context.pre_PedidoXPresupuesto.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdPedidoXPre == info.IdPedidoXPre);
                    if (contact != null)
                    {
                        contact.IdDepartamento = info.IdDepartamento;
                        contact.Fecha = Convert.ToDateTime(info.Fecha.ToShortDateString());
                        contact.Observacion = info.Observacion;
                        contact.IdProveedor1 = info.IdProveedor1;
                        contact.IdProveedor2 = info.IdProveedor2;
                        contact.IdProveedor3 = info.IdProveedor3;
                        contact.Estado = info.Estado;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;

                        dat_det.ModificarDB(info.Lst_PedidoXPre_D, info.IdEmpresa, info.IdPedidoXPre);

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
                throw new Exception(ex.ToString());
            }
        }


        public Boolean AnularDB(pre_PedidoXPresupuesto_Info info)
        {
            try
            {
                using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                {
                    var contact = context.pre_PedidoXPresupuesto.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdPedidoXPre == info.IdPedidoXPre);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
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
                throw new Exception(ex.ToString());
            }
        }


        public pre_rpt_PedidoXPresupuesto_Info ObtenerListRpt(int IdEmpresa,decimal IdPedidoXPre)
        {
            try
            {
                pre_rpt_PedidoXPresupuesto_Info Pedido = new pre_rpt_PedidoXPresupuesto_Info();
                pre_PedidoXPresupuesto_det_Data pedDet_D= new pre_PedidoXPresupuesto_det_Data();
                EntitiesPresupuesto db = new EntitiesPresupuesto();
                var sel = db.Database.SqlQuery<pre_rpt_PedidoXPresupuesto_Info>("select * from vwpre_PedidoXPresupuesto where IdEmpresa=" + IdEmpresa + " and IdPedidoXPre =" + IdPedidoXPre + "");
                Pedido = (pre_rpt_PedidoXPresupuesto_Info)sel.First();
                Pedido.Lst_PedidoXPre_D = pedDet_D.ObtenerListRpt(IdEmpresa, IdPedidoXPre);

                return Pedido;
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
 
        public pre_PedidoXPresupuesto_Data()
        {
            
        }
    }
}
