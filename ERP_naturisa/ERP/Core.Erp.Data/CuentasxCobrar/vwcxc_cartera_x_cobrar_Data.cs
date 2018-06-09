using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
    public class vwcxc_cartera_x_cobrar_Data
    {
        string mensaje = "";
        public List<vwcxc_cartera_x_cobrar_Info> Get_List_cartera_x_cobrar(int IdEmpresa, int IdSucursal, DateTime FInicio, DateTime FFin)
        {
            try
            {
                List<vwcxc_cartera_x_cobrar_Info> Lst = new List<vwcxc_cartera_x_cobrar_Info>();
                EntitiesCuentas_x_Cobrar oCXC = new EntitiesCuentas_x_Cobrar();

                var sele = from q in oCXC.vwcxc_cartera_x_cobrar
                           where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                           && q.vt_fecha >= FInicio && q.vt_fecha <= FFin //&& q.Saldo > 0
                           select q;

                foreach (var item in sele)
                {
                    vwcxc_cartera_x_cobrar_Info Info = new vwcxc_cartera_x_cobrar_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdBodega = item.IdBodega;
                    Info.vt_tipoDoc = item.vt_tipoDoc;
                    Info.vt_NunDocumento = item.vt_NunDocumento;
                    Info.Referencia = item.Referencia;
                    Info.IdComprobante = item.IdComprobante;
                    Info.CodComprobante = item.CodComprobante;
                    Info.Su_Descripcion = item.Su_Descripcion;
                    Info.IdCliente = item.IdCliente;
                    Info.vt_fecha = item.vt_fecha;
                    Info.vt_total = item.vt_total;
                    Info.Saldo = item.Saldo;
                    Info.TotalxCobrado = item.TotalxCobrado;
                    Info.Bodega = item.Bodega;
                    Info.dc_ValorRetFu = item.dc_ValorRetFu;
                    Info.dc_ValorRetIva = item.dc_ValorRetIva;

                    Info.vt_Subtotal = item.vt_Subtotal;
                    Info.vt_iva = item.vt_iva;

                    Info.pe_nombreCompleto = "[" + Info.IdCliente + "] : " + item.NomCliente;
                    Lst.Add(Info);
                }
                return Lst;

             
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

        public List<vwcxc_cartera_x_cobrar_Info> Get_List_cartera_x_cobrar(int IdEmpresa, int IdSucursal, decimal IdCliente)
        {
            try
            {
                int IdSucursal_Ini = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursal_Fin = (IdSucursal == 0) ? 99999 : IdSucursal;

                List<vwcxc_cartera_x_cobrar_Info> Lst = new List<vwcxc_cartera_x_cobrar_Info>();
                EntitiesCuentas_x_Cobrar oEnti = new EntitiesCuentas_x_Cobrar();          

                var sele = from q in oEnti.vwcxc_cartera_x_cobrar
                           where q.IdEmpresa == IdEmpresa 
                           && q.IdSucursal >=IdSucursal_Ini && q.IdSucursal <=IdSucursal_Fin
                           && q.IdCliente == IdCliente && q.Saldo > 0
                           select q;

                foreach (var item in sele)
                {
                    vwcxc_cartera_x_cobrar_Info Obj = new vwcxc_cartera_x_cobrar_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.vt_tipoDoc = item.vt_tipoDoc;
                    Obj.vt_NunDocumento = item.vt_NunDocumento;
                    Obj.Referencia = item.Referencia;
                    Obj.IdComprobante = item.IdComprobante;
                    Obj.CodComprobante = item.CodComprobante;
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.IdCliente = item.IdCliente;
                    Obj.vt_fecha = item.vt_fecha;
                    Obj.vt_total = item.vt_total;
                    Obj.Saldo = item.Saldo;
                    Obj.TotalxCobrado = item.TotalxCobrado;
                    Obj.Bodega = item.Bodega;
                    Obj.vt_Subtotal = item.vt_Subtotal;
                    Obj.vt_iva = item.vt_iva;
                    Obj.vt_fech_venc = Convert.ToDateTime(item.vt_fech_venc);
                    Obj.SaldoAUX = Convert.ToDouble(item.Saldo);
                    Obj.NomCliente = item.NomCliente;
                    Obj.pe_nombreCompleto = "[" + Obj.IdCliente + "] : " + item.NomCliente;
                    Obj.dc_ValorRetFu = item.dc_ValorRetFu;
                    Obj.dc_ValorRetIva = item.dc_ValorRetIva;

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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public vwcxc_cartera_x_cobrar_Info Get_Info_cartera_x_cobrar(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc)
        {
            try
            {
                vwcxc_cartera_x_cobrar_Info Obj = new vwcxc_cartera_x_cobrar_Info();
                EntitiesCuentas_x_Cobrar oEnti = new EntitiesCuentas_x_Cobrar();
                var sele = from q in oEnti.vwcxc_cartera_x_cobrar
                           where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                           && q.IdBodega == IdBodega && q.IdComprobante == IdCbteCble && q.vt_tipoDoc == TipoDoc
                           select q;
                foreach (var item in sele)
                {
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.vt_tipoDoc = item.vt_tipoDoc;
                    Obj.vt_NunDocumento = item.vt_NunDocumento;
                    Obj.Referencia = item.Referencia;
                    Obj.IdComprobante = item.IdComprobante;
                    Obj.CodComprobante = item.CodComprobante;
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.IdCliente = item.IdCliente;
                    Obj.vt_fecha = item.vt_fecha;
                    Obj.vt_total = item.vt_total;
                    Obj.Saldo = item.Saldo;
                    Obj.TotalxCobrado = item.TotalxCobrado;
                    Obj.Bodega = item.Bodega;
                    Obj.vt_Subtotal = item.vt_Subtotal;
                    Obj.vt_iva = item.vt_iva;
                    Obj.vt_fech_venc = Convert.ToDateTime(item.vt_fech_venc);
                    Obj.SaldoAUX = Convert.ToDouble(item.Saldo);
                    Obj.NomCliente = item.NomCliente;
                    Obj.pe_nombreCompleto = "[" + Obj.IdCliente + "] : " + item.NomCliente;
                    Obj.dc_ValorRetFu = item.dc_ValorRetFu;
                    Obj.dc_ValorRetIva = item.dc_ValorRetIva;

                }


                return Obj;
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

        public vwcxc_cartera_x_cobrar_Data(){}
    }
}