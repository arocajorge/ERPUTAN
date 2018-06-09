using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;


using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
   public class cxc_conciliacion_Data
    {

       public decimal GetIdConciliacion(int IdEmpresa, int IdSucursal, ref string mensaje)
        {
            try
            {
                decimal Id;
                EntitiesCuentas_x_Cobrar ECXC = new EntitiesCuentas_x_Cobrar();

                var select = ECXC.cxc_conciliacion.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXC.cxc_conciliacion
                                   where t.IdEmpresa == IdEmpresa && t.IdSucursal == IdSucursal
                                   select t.IdConciliacion).Max();
                    Id = Convert.ToDecimal(select_.ToString()) + 1;
                   
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "",DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Guardar_Conciliacion(cxc_conciliacion_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar oEnti = new EntitiesCuentas_x_Cobrar())
                   {
                       if (Item.Detalle.Count() == 0 )
                       {
                           mensaje = "Seleccione los valores disponibles por cruzar";
                          return false;                        
                       }
                       if ( Item.Detalle.Count() == 1)
                       {
                           mensaje = "Seleccione los documentos de ventas";
                           return false;
                       }                                     
                    cxc_conciliacion cabe = new cxc_conciliacion();

                    cabe.IdEmpresa = Item.IdEmpresa;
                    cabe.IdSucursal = Item.IdSucursal;
                    cabe.IdCliente = Item.IdCliente;
                    cabe.IdConciliacion = Id = GetIdConciliacion(Item.IdEmpresa, Item.IdSucursal, ref mensaje);
                    cabe.Observacion = Item.Observacion;
                    cabe.Fecha = Convert.ToDateTime(Item.Fecha.ToShortDateString());
                    cabe.Estado = Item.Estado;
                    cabe.IdUsuario = Item.IdUsuario;
                    cabe.Fecha_Transaccion = Item.Fecha_Transaccion;
                    cabe.nom_pc = Item.nom_pc;
                    cabe.ip = Item.ip;

                    oEnti.cxc_conciliacion.Add(cabe);
                    oEnti.SaveChanges();

                    cxc_conciliacion_det_Data oData = new cxc_conciliacion_det_Data();
                    oData.GuardarDB(Item.Detalle, ref Id, ref mensaje);                                
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

        public List<cxc_conciliacion_Info> Get_List_conciliacion(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<cxc_conciliacion_Info> lM = new List<cxc_conciliacion_Info>();
                EntitiesCuentas_x_Cobrar ECXC = new EntitiesCuentas_x_Cobrar();

                var Conciliacion = from selec in ECXC.vwcxc_conciliacion
                                 where selec.IdEmpresa == IdEmpresa
                                 select selec;

                foreach (var item in Conciliacion)
                {
                    cxc_conciliacion_Info info = new cxc_conciliacion_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdConciliacion = item.IdConciliacion;
                    info.Fecha = item.Fecha;
                    info.Observacion = item.Observacion;
                    info.IdCliente = Convert.ToDecimal(item.IdCliente);
                    info.Estado = item.Estado;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transaccion = item.Fecha_Transaccion;
                    info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    info.Fecha_UltMod = Convert.ToDateTime(item.Fecha_UltMod);
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu = Convert.ToDateTime(item.Fecha_UltAnu);
                    info.MotivoAnulacion = item.MotivoAnulacion;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;

                    info.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.Su_Descripcion = item.Su_Descripcion;

                    info.IdEmpresa_cbte_cble = Convert.ToInt32(item.IdEmpresa_cbte_cble);
                    info.IdTipoCbte_cbte_cble = Convert.ToInt32(item.IdTipoCbte_cbte_cble);
                    info.IdCbteCble_cbte_cble = Convert.ToInt32(item.IdCbteCble_cbte_cble);

                    lM.Add(info);
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

        public Boolean ModificarConciliacion(cxc_conciliacion_Info Info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    cxc_conciliacion data = cxc.cxc_conciliacion.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdSucursal == Info.IdSucursal && v.IdConciliacion == Info.IdConciliacion);
                    if (data != null)
                    {
                        data.IdEmpresa_cbte_cble = Info.IdEmpresa_cbte_cble;
                        data.IdTipoCbte_cbte_cble = Info.IdTipoCbte_cbte_cble;
                        data.IdCbteCble_cbte_cble = Info.IdCbteCble_cbte_cble;
                        cxc.SaveChanges();
                        res = true;
                    }
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Anular_Conciliacion(cxc_conciliacion_Info Info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar Entity = new EntitiesCuentas_x_Cobrar())
                {                 
                    cxc_conciliacion cab_Ordpag = Entity.cxc_conciliacion.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdSucursal == Info.IdSucursal && v.IdConciliacion == Info.IdConciliacion);
                    if (cab_Ordpag != null)
                    {
                        cab_Ordpag.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        cab_Ordpag.Fecha_UltAnu = Info.Fecha_UltAnu;
                        cab_Ordpag.MotivoAnulacion = Info.MotivoAnulacion;
                        cab_Ordpag.Estado = "I";
                        Entity.SaveChanges();
                        res = true;
                    }
                }
                return res;
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
    }
}
