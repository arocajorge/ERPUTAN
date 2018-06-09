using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_ordencompra_ext_x_imp_gastosxImport_Det_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> LstDetalle) 
        {
            try
            {
                int c = 1;
                foreach (var item in LstDetalle)
                {
                    using (EntitiesImportacion Context = new EntitiesImportacion())
                    {
                        var address = new imp_ordencompra_ext_x_imp_gastosxImport_det();
                        
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdRegistroGasto = item.IdRegistroGasto;
                        address.IdSucursal = item.IdSucusal;
                        address.IdOrdenCompraExt = item.IdOrdenCompraExt;
                        address.Secuencia = c;
                        address.IdGastoImp = item.IdGastoImp;
                        address.Valor = item.Valor;
                        c++;
                        Context.imp_ordencompra_ext_x_imp_gastosxImport_det.Add(address);
                        Context.SaveChanges();
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

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> Get_List_ordencompra_ext_x_imp_gastosxImport_Det(imp_ordencompra_ext_x_imp_gastosxImport_Info Info) 
        {
                List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> lst = new List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info>();
                EntitiesImportacion IMP = new EntitiesImportacion();
            try
            {
                var Consu = from q in IMP.imp_ordencompra_ext_x_imp_gastosxImport_det
                            where q.IdEmpresa == Info.IdEmpresa && q.IdSucursal == Info.IdSucusal && q.IdRegistroGasto == Info.IdRegistroGasto && q.IdOrdenCompraExt == Info.IdOrdenCompraExt
                            select q;

                foreach (var item in Consu)
                {

                    imp_ordencompra_ext_x_imp_gastosxImport_Det_Info obj = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Info();
                    obj.IdEmpresa = item.IdEmpresa;
                    obj.IdRegistroGasto = item.IdRegistroGasto;
                    obj.IdSucusal = item.IdSucursal;
                    obj.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    obj.Secuencia = item.Secuencia;
                    obj.IdGastoImp = item.IdGastoImp;
                    obj.Valor = item.Valor;

                    lst.Add(obj);
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

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> Get_List_ordencompra_ext_x_imp_gastosxImport_Det_x_OC(imp_ordencompra_ext_Info Info)
        {
            List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> lst = new List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info>();
            EntitiesImportacion IMP = new EntitiesImportacion();
            try
            {

                var Consu = from q in IMP.imp_ordencompra_ext_x_imp_gastosxImport_det
                            from d in IMP.vwImp_GastosImportacion
                            where q.IdEmpresa == Info.IdEmpresa && q.IdSucursal == Info.IdSucusal && q.IdOrdenCompraExt == Info.IdOrdenCompraExt
                            && q.IdEmpresa == d.IdEmpresa && q.IdSucursal == d.IdSucusal && q.IdOrdenCompraExt == d.IdOrdenCompraExt && q.IdRegistroGasto == d.IdRegistroGasto && d.Estado == "A"
                            select new { d.Observacion, q.IdEmpresa, q.Valor, d.IdRegistroGasto, q.IdSucursal, q.IdOrdenCompraExt, q.Secuencia, q.IdGastoImp, d.ba_descripcion, d.pr_nombre, d.Fecha, d.CodDocu_Pago };

                foreach (var item in Consu)
                {

                    imp_ordencompra_ext_x_imp_gastosxImport_Det_Info obj = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Info();
                    obj.Banco = item.ba_descripcion;
                    obj.Proveedor = item.pr_nombre;
                    obj.IdEmpresa = item.IdEmpresa;
                    obj.IdRegistroGasto = item.IdRegistroGasto;
                    obj.IdSucusal = item.IdSucursal;
                    obj.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    obj.Secuencia = item.Secuencia;
                    obj.IdGastoImp = item.IdGastoImp;
                    obj.Valor = item.Valor;
                    obj.Fecha = item.Fecha;
                    obj.Observacion = item.Observacion;
                    obj.CodDocu_Pago = item.CodDocu_Pago;
                    lst.Add(obj);
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

        public bool EliminarDB(imp_ordencompra_ext_x_imp_gastosxImport_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesImportacion oEnt = new EntitiesImportacion())
                {
                    var a = Get_List_ordencompra_ext_x_imp_gastosxImport_Det(Info);
                    if (a != null)
                    {
                        foreach (var item in a)
                        {
                            imp_ordencompra_ext_x_imp_gastosxImport_det contact = oEnt.
                                imp_ordencompra_ext_x_imp_gastosxImport_det.FirstOrDefault(q=>q.IdEmpresa == item.IdEmpresa && q.IdSucursal== item.IdSucusal &&q.IdOrdenCompraExt== item.IdOrdenCompraExt && q.IdRegistroGasto == item.IdRegistroGasto);
                            if (contact != null)
                            {
                                oEnt.imp_ordencompra_ext_x_imp_gastosxImport_det.Remove(contact);
                            }
                        }
                        oEnt.SaveChanges();
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
