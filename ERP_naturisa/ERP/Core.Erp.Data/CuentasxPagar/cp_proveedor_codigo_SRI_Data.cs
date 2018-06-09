using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_proveedor_codigo_SRI_Data
    {
        string mensaje = "";
        public List<cp_proveedor_codigo_SRI_Info> Get_List_proveedor_codigo_SRI(int IdEmpresa, decimal Iproveedor)
        {
            try
            {
                List<cp_proveedor_codigo_SRI_Info> lM = new List<cp_proveedor_codigo_SRI_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var select_ = from T in db.cp_proveedor_codigo_SRI
                              where T.IdEmpresa == IdEmpresa && T.IdProveedor == Iproveedor
                              select T;

                foreach (var item in select_)
                {
                    cp_proveedor_codigo_SRI_Info dat = new cp_proveedor_codigo_SRI_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdProveedor = item.IdProveedor;
                    dat.IdCodigo_SRI = item.IdCodigo_SRI;
                   // dat.IdCtaCble = item.IdCtaCble;

                    dat.observacion = item.observacion;
                   
                    lM.Add(dat);
                }
                return (lM);
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
      
        public Boolean GrabarDB(cp_proveedor_codigo_SRI_Info info)
        {
            try
            {                
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();

                    var address = new cp_proveedor_codigo_SRI();
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdProveedor = info.IdProveedor;
                    address.IdCodigo_SRI = info.IdCodigo_SRI;
                    address.observacion = info.observacion == null ? "" : info.observacion.Trim();
                    context.cp_proveedor_codigo_SRI.Add(address);
                    context.SaveChanges();
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

        public Boolean GrabarDB(List<cp_proveedor_codigo_SRI_Info> lista)
        {
            try
            {
                foreach (var item in lista)
                {
                    GrabarDB(item);
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
    
        public Boolean ModificarDB(cp_proveedor_codigo_SRI_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var select = from A in context.cp_proveedor_codigo_SRI 
                                 where A.IdEmpresa==info.IdEmpresa 
                                 && A.IdProveedor == info.IdProveedor 
                                 && A.IdCodigo_SRI == info.IdCodigo_SRI 
                                 select A;
                    if(select.ToList().Count<1)
                    {
                        GrabarDB(info);
                    }
                    else
                    {                        
                        var contact = context.cp_proveedor_codigo_SRI.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdProveedor == info.IdProveedor && minfo.IdCodigo_SRI == info.IdCodigo_SRI);
                        if (contact != null)
                        {
                            contact.observacion = info.observacion;
                            context.SaveChanges();
                        }
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
      
        public Boolean ModificarDB(cp_proveedor_Info info)
        { 
            try
            {
                if(info.lista_codigoSRI_Proveedor.Count !=0)
                {
                    if (info.lista_codigoSRI_Proveedor_Old.Count != 0)
                    {
                        if (EliminarDB(info.lista_codigoSRI_Proveedor_Old))
                        {
                            GrabarDB(info.lista_codigoSRI_Proveedor);                  
                        }
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
                return false;
            }
        }

        public Boolean EliminarDB(cp_proveedor_codigo_SRI_Info Info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_proveedor_codigo_SRI.FirstOrDefault(min => min.IdEmpresa == Info.IdEmpresa && min.IdProveedor == Info.IdProveedor && min.IdCodigo_SRI == Info.IdCodigo_SRI);
                    if (contact != null)
                    {
                        context.cp_proveedor_codigo_SRI.Remove(contact);
                        context.SaveChanges();
                        context.Dispose();
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

        public Boolean EliminarDB(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var q = context.Database.ExecuteSqlCommand("delete cp_proveedor_codigo_SRI WHERE IdEmpresa=" + IdEmpresa + " and IdProveedor= " + IdProveedor);
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

        public Boolean EliminarDB(List<cp_proveedor_codigo_SRI_Info> lm)
        {
            try
            {

                foreach (var item in lm)
                {
                    EliminarDB(item);
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

        public cp_proveedor_codigo_SRI_Data() { }
    }
}
