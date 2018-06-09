using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class vwFa_Documentos_x_Relacionar_NC_ND_Data
    {
        string mensaje = "";
        public List<vwFa_Documentos_x_Relacionar_NC_ND_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(int IdEmpresa, int IdSucursal, decimal IdCliente)
        {
       
            try
            {
                List<vwFa_Documentos_x_Relacionar_NC_ND_Info> Lst = new List<vwFa_Documentos_x_Relacionar_NC_ND_Info>();
                EntitiesFacturacion oEnti = new EntitiesFacturacion();

                var sele = from q in oEnti.vwFa_Documentos_x_Relacionar_NC_ND
                           where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                           && q.IdCliente == IdCliente && q.Saldo > 0
                           select q;

                foreach (var item in sele)
                {
                    vwFa_Documentos_x_Relacionar_NC_ND_Info Obj = new vwFa_Documentos_x_Relacionar_NC_ND_Info();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }



        public List<vwFa_Documentos_x_Relacionar_NC_ND_Info> Get_List_Cobros_CredDeb_Conciliados(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {

            try
            {
                List<vwFa_Documentos_x_Relacionar_NC_ND_Info> Lst = new List<vwFa_Documentos_x_Relacionar_NC_ND_Info>();
                EntitiesFacturacion oEnti = new EntitiesFacturacion();

                var sele = from q in oEnti.vwFa_Documentos_Relacionados_NC_ND
                           where q.IdEmpresa_nt == IdEmpresa && q.IdSucursal_nt == IdSucursal
                           && q.IdBodega_nt == IdBodega && q.IdNota_nt == IdNota
                           select q;

                foreach (var item in sele)
                {
                    vwFa_Documentos_x_Relacionar_NC_ND_Info Obj = new vwFa_Documentos_x_Relacionar_NC_ND_Info();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
