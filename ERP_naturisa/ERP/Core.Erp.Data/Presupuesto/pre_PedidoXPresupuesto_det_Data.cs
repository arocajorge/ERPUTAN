using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

//8-5-2013
//7-5-2013
namespace Core.Erp.Data.Presupuesto
{
    public class pre_PedidoXPresupuesto_det_Data
    {
        string mensaje = "";
        public Boolean GrabarDB(pre_PedidoXPresupuesto_det_Info Info)
        {
            try
            {
                List<pre_PedidoXPresupuesto_det_Info> Lst = new List<pre_PedidoXPresupuesto_det_Info>();
                using (EntitiesPresupuesto Context = new EntitiesPresupuesto())
                {
                    var Address = new pre_PedidoXPresupuesto_det();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdPedidoXPre = Info.IdPedidoXPre;
                    Address.Secuencia_reg = Info.Secuencia_reg;
                    Address.IdPresupuesto_pre = Info.IdPresupuesto_pre;
                    Address.IdAnio_pre = Info.IdAnio_pre;
                    Address.Secuencia_pre = Info.Secuencia_pre;
                    Address.Producto = Info.Producto;
                    Address.Cant = Info.Cant;
                    Address.CodEstadoAprobacion = "PEN";
                    Address.Cotizado = "N";

                    Context.pre_PedidoXPresupuesto_det.Add(Address);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean GrabarLista(List<pre_PedidoXPresupuesto_det_Info> lista, decimal IdPedidoXPre)
        {
            try
            {
                int secuencia = 0;
                foreach (var item in lista)
                {
                    item.IdPedidoXPre = IdPedidoXPre;
                    secuencia = secuencia + 1;
                    item.Secuencia_reg = secuencia;
                    
                    GrabarDB(item);
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

        public List<pre_PedidoXPresupuesto_det_Info> ObtenerList(int IdEmpresa, decimal IdPedidoXPre)
        {
            try
            {
                List<pre_PedidoXPresupuesto_det_Info> Lst = new List<pre_PedidoXPresupuesto_det_Info>();
                EntitiesPresupuesto oEnti = new EntitiesPresupuesto();

                var Query = from q in oEnti.pre_PedidoXPresupuesto_det
                            where q.IdEmpresa == IdEmpresa && q.IdPedidoXPre == IdPedidoXPre
                            select q;
                foreach (var item in Query)
                {
                    pre_PedidoXPresupuesto_det_Info Obj = new pre_PedidoXPresupuesto_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdPedidoXPre = item.IdPedidoXPre;
                    Obj.Secuencia_reg = item.Secuencia_reg;
                    Obj.IdPresupuesto_pre = item.IdPresupuesto_pre;
                    Obj.IdAnio_pre = item.IdAnio_pre;
                    Obj.Secuencia_pre = item.Secuencia_pre;
                    Obj.Producto = item.Producto;
                    Obj.Cant = item.Cant;
                    Obj.CodEstadoAprobacion = item.CodEstadoAprobacion;
                    Obj.CotizadoB  = (item.Cotizado == "S") ? true : false; ;
                    Obj.Cotizado  = item.Cotizado;
                    Obj.UltiFechaEstadoApro  = item.UltiFechaEstadoApro;
                    Obj.IdUsuarioEstadoApro  = item.IdUsuarioEstadoApro;

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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }



        public List<pre_PedidoXPresupuesto_det_Info> ObtenerListPedidoDet(int IdEmpresa, string CodAprobacion = "T",string join="N")
        {
            try
            {
                string query = "";
                List<pre_PedidoXPresupuesto_det_Info> Lst = new List<pre_PedidoXPresupuesto_det_Info>();
                EntitiesPresupuesto oEnti = new EntitiesPresupuesto();
            
                if (CodAprobacion == "T")
                    query = "select * from vwpre_PedidoXPresupuesto_det where IdEmpresa=" + IdEmpresa;
                else if (join == "S" && CodAprobacion != "T" )
                {
                    query = "select * from vwpre_PedidoXPresupuesto_det where IdEmpresa=" + IdEmpresa + "and  (cast(IdPedidoXPre as varchar(25)) + cast(Secuencia_reg as varchar(25)) + cast(IdPresupuesto_pre as varchar(25)) + cast(IdAnio_pre as varchar(25)) + cast(Secuencia_pre as varchar(25)))  not in(select cast(IdPedidoXPre as varchar(25)) + cast(Secuencia_reg_ped as varchar(25)) + cast(IdPresupuesto_pre as varchar(25)) + cast(IdAnio_pre as varchar(25)) + cast(Secuencia_pre as varchar(25)) from pre_ordencompra_local_det ) and CodEstadoAprobacion = '" + CodAprobacion + "'";
                }
                else
                    query = "select * from vwpre_PedidoXPresupuesto_det where IdEmpresa=" + IdEmpresa + " and CodEstadoAprobacion ='" + CodAprobacion + "' ";

                var Query = oEnti.Database.SqlQuery<pre_PedidoXPresupuesto_det_Info>(query).ToList();

                foreach (var item in Query)
                {
                    pre_PedidoXPresupuesto_det_Info Obj = new pre_PedidoXPresupuesto_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdPedidoXPre = item.IdPedidoXPre;
                    Obj.Secuencia_reg = item.Secuencia_reg;
                    Obj.IdPresupuesto_pre = item.IdPresupuesto_pre;
                    Obj.IdAnio_pre = item.IdAnio_pre;
                    Obj.Secuencia_pre = item.Secuencia_pre;
                    Obj.Producto = item.Producto;
                    Obj.Cant = item.Cant;
                    Obj.NPresupuesto_pre = item.NPresupuesto_pre;

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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public List<pre_PedidoXPresupuesto_det_Info> ObtenerListRpt(int IdEmpresa, decimal IdPedidoXPre)
        {
            try
            {
                List<pre_PedidoXPresupuesto_det_Info> Lst = new List<pre_PedidoXPresupuesto_det_Info>();
                EntitiesPresupuesto oEnti = new EntitiesPresupuesto();
                var Query = from q in oEnti.vwpre_PedidoXPresupuesto_det
                            where q.IdEmpresa == IdEmpresa && q.IdPedidoXPre == IdPedidoXPre
                            select q;
                foreach (var item in Query)
                {
                    pre_PedidoXPresupuesto_det_Info Obj = new pre_PedidoXPresupuesto_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdPedidoXPre = item.IdPedidoXPre;
                    Obj.Secuencia_reg = item.Secuencia_reg;
                    Obj.IdPresupuesto_pre = item.IdPresupuesto_pre;
                    Obj.IdAnio_pre = item.IdAnio_pre;
                    Obj.Secuencia_pre = item.Secuencia_pre;
                    Obj.Producto = item.Producto;
                    Obj.Cant = item.Cant;
                    Obj.NPresupuesto_pre = item.NPresupuesto_pre;

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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean ModificarDB(List<pre_PedidoXPresupuesto_det_Info> Lst, int IdEmpresa, decimal IdPedidoXPre)
        {
            try
            {
                using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                {
                    context.Database.ExecuteSqlCommand("delete from pre_PedidoXPresupuesto_det where IdEmpresa =" + IdEmpresa + " and IdPedidoXPre = " + IdPedidoXPre);
                    context.SaveChanges();
                    GrabarLista(Lst,IdPedidoXPre);
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
        public Boolean EliminarDB(pre_PedidoXPresupuesto_det_Info info)
        {
            try
            {
                using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                {
                    var contact = context.pre_PedidoXPresupuesto_det.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdPedidoXPre == info.IdPedidoXPre && minfo.Secuencia_reg == info.Secuencia_reg);
                    if (contact != null)
                    {
                        context.pre_PedidoXPresupuesto_det.Add(contact);
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


        public List<pre_PedidoXPresupuesto_det_Info> ObtenerListFiltro(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, string CodAprobacion = "T")
        {
            try
            {
                List<pre_PedidoXPresupuesto_det_Info> lst = new List<pre_PedidoXPresupuesto_det_Info>();
                EntitiesPresupuesto db = new EntitiesPresupuesto();
                string query = "";

                if (CodAprobacion == "T")
                    query = "select * from vwpre_PedidoXPresupuesto_det where IdEmpresa=" + IdEmpresa + " and Fecha >='" + fechaIni.Month + "/" + fechaIni.Day + "/" + fechaIni.Year + "' and Fecha <= '" + fechaFin.Month + "/" + fechaFin.Day + "/" + fechaFin.Year + "' order by IdPedidoXPre";
                else
                    query = "select * from vwpre_PedidoXPresupuesto_det where IdEmpresa=" + IdEmpresa + " and Fecha >='" + fechaIni.Month + "/" + fechaIni.Day + "/" + fechaIni.Year + "' and Fecha <= '" + fechaFin.Month + "/" + fechaFin.Day + "/" + fechaFin.Year + "' and CodEstadoAprobacion ='" + CodAprobacion + "' order by IdPedidoXPre";
                var sel = db.Database.SqlQuery<pre_PedidoXPresupuesto_det_Info>(query).ToList();

                foreach (var item in sel)
                {
                    item.CotizadoB = (item.Cotizado == "S") ? true : false;
                    lst.Add(item);
                }

                return lst;
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


        public Boolean ModificarDBEstadoAprobacion(pre_PedidoXPresupuesto_det_Info info)
        {
            try
            {
                using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                {
                    var contact = context.pre_PedidoXPresupuesto_det.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdPedidoXPre == info.IdPedidoXPre && minfo.Secuencia_reg==info.Secuencia_reg );
                    if (contact != null)
                    {
                        contact.CodEstadoAprobacion = info.CodEstadoAprobacion;
                        contact.Cotizado = (info.CotizadoB == true) ? "S" : "N";
                        contact.UltiFechaEstadoApro = info.UltiFechaEstadoApro;
                        contact.IdUsuarioEstadoApro = info.IdUsuarioEstadoApro;
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

        public Boolean ModificarDBEstadoAprobacionLst(List<pre_PedidoXPresupuesto_det_Info> lst)
        {
            try
            {
                foreach (var item in lst)
                {
                    ModificarDBEstadoAprobacion(item);
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


        public pre_PedidoXPresupuesto_det_Data()
        {
            
        }
    }
}
