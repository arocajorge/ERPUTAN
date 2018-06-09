using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_ordencompra_ext_x_imp_gastosxImport_Data
    {
        string mensaje = "";
        imp_ordencompra_ext_x_imp_gastosxImport_Det_Data BusDetalle = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Data();

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Get_List_ordencompra_ext_x_imp_gastosxImpor(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin) 
        {
                List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Lst = new List<imp_ordencompra_ext_x_imp_gastosxImport_Info>();
                EntitiesImportacion oEnti = new EntitiesImportacion();
            try
            {
                var Consulta = from q in oEnti.vwImp_GastosImportacion
                               where q.IdEmpresa == IdEmpresa && q.Fecha >= FechaIni && q.Fecha <= FechaFin && q.IdSucusal == IdSucursal
                               select q;
                foreach (var item in Consulta)
                {
                    imp_ordencompra_ext_x_imp_gastosxImport_Info _Info = new imp_ordencompra_ext_x_imp_gastosxImport_Info();

                    _Info.IdEmpresa = item.IdEmpresa;
                    _Info.IdRegistroGasto = item.IdRegistroGasto;
                    _Info.IdSucusal = item.IdSucusal;
                    _Info.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    _Info.Fecha = item.Fecha;
                    _Info.Observacion = item.Observacion;
                    _Info.IdProveedor = Convert.ToDecimal((item.IdProveedor == null) ? 0 : item.IdProveedor);
                    _Info.IdBanco = item.IdBanco;

                    _Info.Sucursal = item.Su_Descripcion;
                    _Info.CodDocu_Pago = item.CodDocu_Pago;
                    _Info.Estado = item.Estado;
                    _Info.IdTipoCbte = Convert.ToInt16((item.IdTipoCbte == null) ? 0 : item.IdTipoCbte); 
                    _Info.IdCbteCble = Convert.ToDecimal((item.IdCbteCble == null) ? 0 : item.IdCbteCble);
                    _Info.IdTipoCbte_Anul = Convert.ToInt16((item.IdTipoCbte_Anu == null) ? 0 : item.IdTipoCbte_Anu);
                    _Info.IdCbteCble_Anulado = Convert.ToDecimal((item.IdCbteCble_Anu == null) ? 0 : item.IdCbteCble_Anu);
                    _Info.CodOrdenCompraExt = item.CodOrdenCompraExt;
                    _Info.Tipo_Importacion = item.Tipo_Importacion;
                    Lst.Add(_Info);                    
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

        public Boolean GuardarDB(imp_ordencompra_ext_x_imp_gastosxImport_Info info)
        {
            try
            {
                    using(EntitiesImportacion Contex = new EntitiesImportacion())
                    {

                        imp_ordencompra_ext_x_imp_gastosxImport address = new imp_ordencompra_ext_x_imp_gastosxImport();

                        address.IdEmpresa = info.IdEmpresa;
                        address.IdRegistroGasto = info.IdRegistroGasto =GetId(info);
                        address.IdSucusal = info.IdSucusal;
                        address.IdOrdenCompraExt = info.IdOrdenCompraExt;
                        address.Fecha = info.Fecha;
                        address.Observacion = info.Observacion;
                        address.IdProveedor = info.IdProveedor;

                        if (info.IdBanco == 0)
                        {address.IdBanco = null;}
                        else { address.IdBanco = info.IdBanco; }
                                               
                        address.IdTipoCbte=info.IdTipoCbte ;
                        address.CodDocu_Pago = info.CodDocu_Pago;
                        address.Estado = "A";

                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transac = info.Fecha_Transac;
                        address.Fecha_UltMod = info.Fecha_UltMod;
                        address.IdUsuarioUltMod = info.IdUsuarioUltMod;

                        //contac = address;
                        Contex.imp_ordencompra_ext_x_imp_gastosxImport.Add(address);
                       Contex.SaveChanges();
                       info.ListaGastos.ForEach(var => var.IdRegistroGasto = address.IdRegistroGasto);
                       BusDetalle.GuardarDB(info.ListaGastos);
                       Contex.Dispose();                                 
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

        public Boolean GuardarDB(List<imp_ordencompra_ext_x_imp_gastosxImport_Info> lst, ref string mensaje)
        {
            try
            {
                foreach (imp_ordencompra_ext_x_imp_gastosxImport_Info info in lst)
                {
                    GuardarDB(info);
                
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

        public Boolean AnularDB(imp_ordencompra_ext_x_imp_gastosxImport_Info info) 
        {
            try
            {
                    using (EntitiesImportacion Contex = new EntitiesImportacion())
                    {
                        var contact = Contex.imp_ordencompra_ext_x_imp_gastosxImport.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucusal == info.IdSucusal && obj.IdOrdenCompraExt == info.IdOrdenCompraExt && obj.IdRegistroGasto == info.IdRegistroGasto);
                        if (contact != null)
                        {
                            contact.Estado = "I";
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = info.Fecha_UltAnu;
                            contact.IdTipoCbte_Anu = info.IdTipoCbte_Anul;
                            Contex.SaveChanges();
                            Contex.Dispose();
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

        public Boolean AnularXOG(int IdEmpresa,int IdTipoCbte, decimal IdCbteCble, int IdTipoCbte_Anu, decimal IdCbteCble_Anu,string IdUsuario,DateTime Fecha, string TipoReg = "AGAST")
        {
            try
            {

                return false;
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

        public decimal GetId(imp_ordencompra_ext_x_imp_gastosxImport_Info info) 
        {

            try
            {
                decimal ID =0;

                EntitiesImportacion oEntities = new EntitiesImportacion();
                var select = from q in oEntities.imp_ordencompra_ext_x_imp_gastosxImport
                             where q.IdEmpresa == info.IdEmpresa && q.IdSucusal == info.IdSucusal //&& q.IdOrdenCompraExt == info.IdOrdenCompraExt
                             select q;
                if (select.ToList().Count < 1)
                {
                    ID = 1;
                }
                else
                {
                    var GetiD = (from q in oEntities.imp_ordencompra_ext_x_imp_gastosxImport
                                 where q.IdEmpresa == info.IdEmpresa && q.IdSucusal == info.IdSucusal

                                 select q.IdRegistroGasto).Max();

                    ID = Convert.ToDecimal(GetiD.ToString()) + 1;
                }

                return ID;
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

        public Boolean ModificarDB(List<imp_ordencompra_ext_x_imp_gastosxImport_Info> lst, List<imp_ordencompra_ext_x_imp_gastosxImport_Info> LstAnterior,ref string mensaje) {
            Boolean res = true;
            try
            {
                using (EntitiesImportacion Contex = new EntitiesImportacion())
                {
                    if (LstAnterior != null && LstAnterior.Count > 0)
                    {
                        List<imp_ordencompra_ext_x_imp_gastosxImport_Info> listaactual = Get_List_ordencompra_ext_x_imp_gastosxImport(LstAnterior[0].IdEmpresa,
                            LstAnterior[0].IdSucusal, LstAnterior[0].IdOrdenCompraExt);
                        foreach (var item in listaactual)
                        {
                            imp_ordencompra_ext_x_imp_gastosxImport address = Contex.imp_ordencompra_ext_x_imp_gastosxImport.FirstOrDefault(p => p.IdEmpresa ==
                                              item.IdEmpresa && p.IdRegistroGasto == item.IdRegistroGasto && p.IdSucusal ==
                                              item.IdSucusal && p.IdOrdenCompraExt == item.IdOrdenCompraExt);

                            Contex.imp_ordencompra_ext_x_imp_gastosxImport.Remove(address);
                        }
                        Contex.SaveChanges();
                    }
                }
                return GuardarDB(lst, ref mensaje);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Get_List_ordencompra_ext_x_imp_gastosxImport_Para_Contabilizar(int IdEmpresa, int IdSucursal, decimal IdRegistro)
        {
                List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Lst = new List<imp_ordencompra_ext_x_imp_gastosxImport_Info>();
                EntitiesImportacion oEnti = new EntitiesImportacion();
            try
            {

                var Consult = from q in oEnti.vwImp_GastosImportacionCabYDet
                              where q.IdEmpresa == IdEmpresa && q.IdSucusal == IdSucursal && q.IdRegistroGasto == IdRegistro && q.Estado == "A"
                              select q;

                foreach (var item in Consult)
                {
                    
                    imp_ordencompra_ext_x_imp_gastosxImport_Info _Info = new imp_ordencompra_ext_x_imp_gastosxImport_Info();

                    _Info.IdEmpresa = item.IdEmpresa;
                    _Info.IdRegistroGasto = item.IdRegistroGasto;
                    _Info.IdSucusal = item.IdSucusal;
                    _Info.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    _Info.Fecha = item.Fecha;
                    _Info.Observacion = item.Observacion;
                    _Info.IdProveedor = item.IdProveedor;
                    _Info.IdBanco = item.IdBanco;
                    _Info.CodDocu_Pago = item.CodDocu_Pago;
                    _Info.Estado = item.Estado;
                    _Info.IdGastoImp = item.IdGastoImp;
                    _Info.Valor = item.Valor;
                    _Info.IdCtaCble_Banco = item.IdCtaCble_Banco;
                    _Info.IdCtaCble = item.IdCtaCble_Gaso;
                    _Info.IdCtaCble_Importacion = item.IdCtaCble_import;

                    _Info.IdTipoCbte = Convert.ToInt32((item.IdTipoCbte == null) ? 0 : item.IdTipoCbte);
                    _Info.CodDocu_Pago = item.CodDocu_Pago;
                    _Info.CodOrdenCompraExt=item.CodOrdenCompraExt;
                    _Info.debcre_DebBanco = item.debcre_DebBanco;
                    _Info.debCre_Provicion = item.debCre_Provicion;
                    Lst.Add(_Info);              
                
                
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

        public Boolean ModificarDB(imp_ordencompra_ext_x_imp_gastosxImport_Info info, decimal IdCbteCble)
        {
            try
            {
                using (EntitiesImportacion Contex = new EntitiesImportacion())
                {
                    var contact = Contex.imp_ordencompra_ext_x_imp_gastosxImport.FirstOrDefault(var =>  var.IdEmpresa == info.IdEmpresa && var.IdSucusal == info.IdSucusal && var.IdRegistroGasto == info.IdRegistroGasto);
                    if (contact != null)
                    {
                        contact.IdCbteCble = IdCbteCble;
                        Contex.SaveChanges();
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

        public Boolean ActualizarAnulado(imp_ordencompra_ext_x_imp_gastosxImport_Info info, decimal IdCbteCble)
        {
            try
            {
                using (EntitiesImportacion Contex = new EntitiesImportacion())
                {
                    var contact = Contex.imp_ordencompra_ext_x_imp_gastosxImport.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSucusal == info.IdSucusal && var.IdRegistroGasto == info.IdRegistroGasto);
                    if (contact != null)
                    {
                        contact.IdCbteCble_Anu = IdCbteCble;
                        Contex.SaveChanges();
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


        public imp_ordencompra_ext_x_imp_gastosxImport_Info Get_Info_ordencompra_ext_x_imp_gastosxImpor(int IdEmpresa, int IdSucursa, Decimal IdRegistroGasto) 
        {
                imp_ordencompra_ext_x_imp_gastosxImport_Info _Info = new imp_ordencompra_ext_x_imp_gastosxImport_Info();
                EntitiesImportacion IMP = new EntitiesImportacion();
            try
            {
                var item = IMP.imp_ordencompra_ext_x_imp_gastosxImport.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdSucusal == IdSucursa && var.IdRegistroGasto == IdRegistroGasto);
                if (item != null)
                {
                    _Info.IdEmpresa = item.IdEmpresa;
                    _Info.IdRegistroGasto = item.IdRegistroGasto;
                    _Info.IdSucusal = item.IdSucusal;
                    _Info.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    _Info.Fecha = item.Fecha;
                    _Info.Observacion = item.Observacion;
                    _Info.IdProveedor = item.IdProveedor;
                    _Info.IdBanco = Convert.ToInt32(item.IdBanco);
                    _Info.CodDocu_Pago = item.CodDocu_Pago;
                    _Info.Estado = item.Estado;
                    _Info.IdTipoCbte = Convert.ToInt16((item.IdTipoCbte == null) ? 0 : item.IdTipoCbte);
                    _Info.IdCbteCble = Convert.ToDecimal((item.IdCbteCble == null) ? 0 : item.IdCbteCble);
                    _Info.IdTipoCbte_Anul = Convert.ToInt16((item.IdTipoCbte_Anu == null) ? 0 : item.IdTipoCbte_Anu);
                    _Info.IdCbteCble_Anulado = Convert.ToDecimal((item.IdCbteCble_Anu == null) ? 0 : item.IdCbteCble_Anu);
                }
                return _Info;
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

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Get_List_ordencompra_ext_x_imp_gastosxImport(int IdEmpresa, int IdSucursa, Decimal IdOrdenCompraExterna)
        {
                List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Lst = new List<imp_ordencompra_ext_x_imp_gastosxImport_Info>();
                EntitiesImportacion oEnti = new EntitiesImportacion();
            try
            {
                var Query = from q in oEnti.imp_ordencompra_ext_x_imp_gastosxImport
                            where q.IdEmpresa == IdEmpresa  && q.IdSucusal == IdSucursa && q.IdOrdenCompraExt == IdOrdenCompraExterna
                            select q;
                foreach (var item in Query)
                {
                    imp_ordencompra_ext_x_imp_gastosxImport_Info Obj = new imp_ordencompra_ext_x_imp_gastosxImport_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRegistroGasto = item.IdRegistroGasto;
                    Obj.IdSucusal = item.IdSucusal;
                    Obj.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    Obj.Fecha = item.Fecha;
                    Obj.Observacion = item.Observacion;
                    Obj.IdProveedor = item.IdProveedor;
                    Obj.IdBanco = Convert.ToInt32(item.IdBanco);
                    Obj.CodDocu_Pago = item.CodDocu_Pago;
                    Obj.Estado = item.Estado;
                    Obj.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);
                    Obj.IdCbteCble = Convert.ToDecimal (item.IdCbteCble);
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwImp_OrdenCompraExt_X_CbteCble_Info> Get_List_OrdenCompraExt_X_CbteCble_x_DiariosXgastos(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, decimal IdRegistrosGasto)
        {
            List<vwImp_OrdenCompraExt_X_CbteCble_Info> lst = new List<vwImp_OrdenCompraExt_X_CbteCble_Info>();
            try
            {
                using(EntitiesImportacion oContext = new EntitiesImportacion())
                {
                    string Query = "select a.*,a.cb_Fecha as Fecha  ,b.tc_TipoCbte as tipoCTCB from ct_cbtecble  a inner join ct_cbtecble_tipo b on a.IdTipoCbte= b.IdTipoCbte" +
                    " where IdCbteCble = (select IdCbteCble from dbo.imp_ordencompra_ext_x_imp_gastosxImport where IdRegistroGasto=" + IdRegistrosGasto +
                    " and IdEmpresa =" + IdEmpresa + " and IdSucusal =" + IdSucursal + " and IdOrdenCompraExt=" + IdOrdenCompra + ") and IdEmpresa =" + IdEmpresa +
                    " and a.IdTipoCbte = (select IdTipoCbte from dbo.imp_ordencompra_ext_x_imp_gastosxImport where IdRegistroGasto=" + IdRegistrosGasto +
                    " and IdEmpresa=" + IdEmpresa + " and IdSucusal =" + IdSucursal + " and IdOrdenCompraExt=" + IdOrdenCompra + ") " +
                    " union" +
                    " select a.* ,a.cb_Fecha as Fecha ,b.tc_TipoCbte as tipoCTCB from ct_cbtecble  a inner join ct_cbtecble_tipo b on a.IdTipoCbte= b.IdTipoCbte " +
                    " where IdCbteCble = (select IdCbteCble_Anu from dbo.imp_ordencompra_ext_x_imp_gastosxImport where IdRegistroGasto=" + IdRegistrosGasto +
                    " and IdEmpresa =" + IdEmpresa + " and IdSucusal =" + IdSucursal + " and IdOrdenCompraExt=" + IdOrdenCompra + ") and IdEmpresa =" + IdEmpresa +
                    " and a.IdTipoCbte = (select IdTipoCbte_Anu from dbo.imp_ordencompra_ext_x_imp_gastosxImport where IdRegistroGasto=" + IdRegistrosGasto +
                    " and IdEmpresa =" + IdEmpresa + " and IdSucusal =" + IdSucursal + " and IdOrdenCompraExt=" + IdOrdenCompra + ") ";
                    var Consulta = oContext.Database.SqlQuery<ct_Cbtecble_Info>(Query);
                    List<ct_Cbtecble_Info> lstCt = new List<ct_Cbtecble_Info>();
                    lstCt = Consulta.ToList();

                    foreach (var item in lstCt)
                    {
                        vwImp_OrdenCompraExt_X_CbteCble_Info Info = new vwImp_OrdenCompraExt_X_CbteCble_Info();
                        Info.IdCbte = item.IdCbteCble;
                        Info.CodCbte = item.CodCbteCble;
                        Info.Estado = item.Estado;
                        Info.Fecha = item.cb_Fecha;
                        Info.Valor = item.cb_Valor;
                        Info.Observacion = item.cb_Observacion;
                        Info.TipoComprobanteContable = item.tipoCTCB;
                        Info.IdEmpresa = IdEmpresa;
                        Info.IdSucursal = IdSucursal;
                        Info.IdOrdenCompraExt = IdOrdenCompra;
                        Info.ct_IdTipoCbte = item.IdTipoCbte;
                    
                        lst.Add(Info);
                    }
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

        public Boolean EliminarDB(int IdEmpresa, int IdSucursa, Decimal IdOrdenCompraExterna, decimal idRegistroGasto, ref string mensaje)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_ordencompra_ext_x_imp_gastosxImport.FirstOrDefault(C => C.IdEmpresa == IdEmpresa && C.IdSucusal == IdSucursa && C.IdOrdenCompraExt == IdOrdenCompraExterna && C.IdRegistroGasto == idRegistroGasto);
                    if(contact!=null)
                    {
                        context.imp_ordencompra_ext_x_imp_gastosxImport.Remove(contact);
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
    }
}
