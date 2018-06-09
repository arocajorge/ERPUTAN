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
    public class vwfa_factura_sri_Data
    {
        string mensaje = "";
        public List<vwfa_factura_sri_Info> Get_list_Factura_Sri(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref string msg)
        {
            try
            {
                List<vwfa_factura_sri_Info> lista = new List<vwfa_factura_sri_Info>();

                EntitiesFacturacion OEFAC = new EntitiesFacturacion();

                var consulta = from h in OEFAC.vwfa_factura_sri
                                where h.IdEmpresa == IdEmpresa
                                && h.IdSucursal == IdSucursal
                                && h.IdBodega == IdBodega
                                && h.IdCbteVta == IdCbteVta
                                select new 
                                {
                                    h.IdEmpresa,
                                    h.IdSucursal,
                                    h.IdBodega,
                                    h.IdCbteVta,
                                    h.vt_tipoDoc,
                                    h.vt_serie1,
                                    h.vt_serie2,
                                    h.vt_autorizacion,
                                    h.vt_NumFactura,
                                    h.IdCliente,
                                    h.vt_fecha,
                                    h.Estado,
                                    h.RazonSocial,
                                    h.NombreComercial,
                                    h.ContribuyenteEspecial,
                                    h.ObligadoAllevarConta,
                                    h.em_ruc,
                                    h.em_direccion,
                                    h.Su_Descripcion,
                                    h.Su_Direccion,
                                    h.cl_RazonSocial,
                                    h.pe_nombreCompleto,
                                    h.IdTipoDocumento,
                                    h.pe_cedulaRuc,
                                    h.pe_correo,
                                    h.vt_plazo,
                                    h.vt_fech_venc,
                                    h.vt_Observacion
                                };

                foreach (var item in consulta)
                {
                    vwfa_factura_sri_Info Info = new vwfa_factura_sri_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdBodega = item.IdBodega;
                    Info.IdCbteVta = item.IdCbteVta;
                    Info.vt_tipoDoc = item.vt_tipoDoc;
                    Info.vt_serie1 = item.vt_serie1;
                    Info.vt_serie2 = item.vt_serie2;
                    Info.vt_autorizacion = item.vt_autorizacion;
                    Info.vt_NumFactura = item.vt_NumFactura;
                    Info.IdCliente = item.IdCbteVta;
                    Info.vt_fecha = item.vt_fecha;
                    Info.Estado = item.Estado;
                    Info.RazonSocial = item.RazonSocial;
                    Info.NombreComercial = item.NombreComercial;
                    Info.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    Info.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    Info.em_ruc = item.em_ruc;
                    Info.em_direccion = item.em_direccion;
                    Info.Su_Descripcion = item.Su_Descripcion;
                    Info.Su_Direccion = item.Su_Direccion;
                    Info.cl_RazonSocial = item.cl_RazonSocial;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.IdTipoDocumento = item.IdTipoDocumento;
                    Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Info.pe_correo = item.pe_correo;
                    Info.vt_plazo = item.vt_plazo;

                    Info.vt_fech_venc = item.vt_fech_venc;
                    Info.vt_Observacion = item.vt_Observacion;
                    lista.Add(Info);
                }
                return lista;
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
