using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Importacion
{
    public class imp_gastosxImport_Data
    {
        string mensaje="";
        public List<imp_gastosxImport_Info> Get_List_gastosxImport()
        {
                List<imp_gastosxImport_Info> Lst = new List<imp_gastosxImport_Info>();
                EntitiesImportacion oEnt = new EntitiesImportacion();
            try
            {
                var Lista = from q in oEnt.imp_gastosxImport
                            select q;
                foreach (var item in Lista)
                {
                    imp_gastosxImport_Info Info = new imp_gastosxImport_Info();
                    Info.IdGastoImp = item.IdGastoImp;
                    Info.CodGastoImp = item.CodGastoImp;
                    Info.ga_decripcion = item.ga_decripcion;
                    Info.ga_estado = item.ga_estado;
                    Lst.Add(Info);
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

        public List<vwImp_GastosImportacion_X_Proveedor_Info> Get_List_GastosImportacion_X_Proveedor(int IdEmpresa, int IdSucursal, decimal IdOrdenCompraExt)
        {
                List<vwImp_GastosImportacion_X_Proveedor_Info> Lst = new List<vwImp_GastosImportacion_X_Proveedor_Info>();
                EntitiesImportacion oEnt = new EntitiesImportacion();
            try
            {
                var Lista = from q in oEnt.vwImp_GastosImportacion_X_Proveedor
                            where q.IdCbteCble == null && q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdOrdenCompraExt == IdOrdenCompraExt
                            select q;
                foreach (var item in Lista)
                {
                    vwImp_GastosImportacion_X_Proveedor_Info Info = new vwImp_GastosImportacion_X_Proveedor_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdRegistroGasto = item.IdRegistroGasto;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    Info.IdTipoCbte = item.IdTipoCbte;
                    Info.IdCbteCble = item.IdCbteCble;
                    Info.IdCbteCble_Anu = item.IdCbteCble_Anu;
                    Info.IdCbteCble_Anu = item.IdCbteCble_Anu;
                    Info.ga_descripcion = item.ga_descripcion;
                    Info.Valor = item.Valor;
                    Info.Observacion = item.Observacion;
                    Info.CodDocu_Pago = item.CodDocu_Pago;

                    Lst.Add(Info);
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

        public List<vwImp_GastosImportacion_X_Proveedor_Info> Get_List_GastosImportacion_X_ProveedorYCbte(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
                List<vwImp_GastosImportacion_X_Proveedor_Info> Lst = new List<vwImp_GastosImportacion_X_Proveedor_Info>();
                EntitiesImportacion oEnt = new EntitiesImportacion();
            try
            {
                var Lista = from q in oEnt.vwImp_GastosImportacion_X_Proveedor
                            where q.IdCbteCble == IdCbteCble && q.IdEmpresa == IdEmpresa && q.IdTipoCbte == IdTipoCbte
                            select q;

                foreach (var item in Lista)
                {
                    vwImp_GastosImportacion_X_Proveedor_Info Info = new vwImp_GastosImportacion_X_Proveedor_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdRegistroGasto = item.IdRegistroGasto;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    Info.IdTipoCbte = item.IdTipoCbte;
                    Info.IdCbteCble = item.IdCbteCble;
                    Info.IdCbteCble_Anu = item.IdCbteCble_Anu;
                    Info.IdCbteCble_Anu = item.IdCbteCble_Anu;
                    Info.ga_descripcion = item.ga_descripcion;
                    Info.Valor = item.Valor;
                    Info.Observacion = item.Observacion;
                    Info.CodDocu_Pago = item.CodDocu_Pago;
                    Info.IdGastoImp = item.IdGastoImp;

                    Lst.Add(Info);
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

        int GetId()
        {
            try
            {
                int ID = 0;


                EntitiesImportacion oEntities = new EntitiesImportacion();
                var select = from q in oEntities.imp_gastosxImport
                             select q;
                if (select.ToList().Count < 1)
                {
                    ID = 1;
                }
                else
                {
                    var GetiD = (from q in oEntities.imp_gastosxImport
                                 select q.IdGastoImp).Max();

                    ID = Convert.ToInt32(GetiD.ToString()) + 1;
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

        public Boolean GuardarDB(ref imp_gastosxImport_Info Info) 
        {
            try
            {
                using (EntitiesImportacion Context = new EntitiesImportacion()) 
                {
                    var Address = new imp_gastosxImport();

                    Address.CodGastoImp = Info.CodGastoImp;
                    Address.ga_decripcion = Info.ga_decripcion;
                    Address.ga_estado = "A";
                    Info.IdGastoImp= Address.IdGastoImp = GetId();
                    Context.imp_gastosxImport.Add(Address);
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

        public Boolean ValidarCodigo(String Codigo) 
        {
            try
            {
                if (Codigo == null || Codigo == "")
                {
                    return false;
                }
                else
                {
                    EntitiesImportacion oEntities = new EntitiesImportacion();
                    var contact = oEntities.imp_gastosxImport.FirstOrDefault(var => var.CodGastoImp == Codigo);
                    return true;
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
        
        public Boolean ModificarDB(imp_gastosxImport_Info Info) 
        {
            try
            {
                EntitiesImportacion oEntities = new EntitiesImportacion();
                var contact = oEntities.imp_gastosxImport.FirstOrDefault(var => var.IdGastoImp == Info.IdGastoImp);
                if(contact!=null)
                    contact.ga_decripcion = Info.ga_decripcion;
                
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

        public Boolean Validar(imp_gastosxImport_Info Info) 
        {
            try
            {
                using(EntitiesImportacion oEntities = new EntitiesImportacion())
                {

                    var asd = oEntities.Database.SqlQuery<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info>("select * from imp_ordencompra_ext_x_imp_gastosxImport_det where IdGastoImp = "+Info.IdGastoImp);
                    if (asd.ToList().Count >= 1)
                    {
                        return false;
                    }
                    else 
                    {
                        return true;
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

        public Boolean AnularDB(imp_gastosxImport_Info Info)
        {
            try
            {
                EntitiesImportacion oEntities = new EntitiesImportacion();
                var contact = oEntities.imp_gastosxImport.FirstOrDefault(var => var.IdGastoImp == Info.IdGastoImp);
                if (contact != null)
                {
                    contact.ga_estado = "I";
                    oEntities.SaveChanges();
                    oEntities.Dispose();
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
