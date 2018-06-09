using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt001_Data
    {
        string mensaje = "";

        public List<XFAC_Rpt001_Info> getDatosDocumentos(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, string IdTipoDocumento, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<XFAC_Rpt001_Info> lstReport = new List<XFAC_Rpt001_Info>();
                fechaIni = Convert.ToDateTime(fechaIni.ToShortDateString());
                fechaFin = Convert.ToDateTime(fechaFin.ToShortDateString());

                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {

                    var select = from q in ListadoDocu.vwFAC_Rpt001
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.vt_fecha >= fechaIni && q.vt_fecha <= fechaFin
                                 select q;
               
                    if (IdTipoDocumento != "0")
                    {
                         select = from q in ListadoDocu.vwFAC_Rpt001
                                     where q.IdEmpresa == IdEmpresa
                                     && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                     && q.vt_fecha >= fechaIni && q.vt_fecha <= fechaFin
                                     && q.IdTipoDocumento == IdTipoDocumento
                                     select q;
                    }

                    
                    foreach (var item in select)
                    {

                        XFAC_Rpt001_Info itemInfo = new XFAC_Rpt001_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = Convert.ToInt32(item.IdBodega);
                        itemInfo.IdTipoDocumento = item.IdTipoDocumento;
                        itemInfo.numDocumento = item.numDocumento;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.nombreCliente = item.nombreCliente;
                        itemInfo.vt_fecha = item.vt_fecha;
                        itemInfo.IdCalendario = item.IdCalendario;
                        itemInfo.AnioFiscal = Convert.ToInt32(item.AnioFiscal);
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.NombreMes = item.NombreMes;
                        itemInfo.NombreCortoFecha = item.NombreCortoFecha;
                        itemInfo.vt_cantidad = item.vt_cantidad;
                        itemInfo.vt_PrecioFinal = item.vt_PrecioFinal;
                        itemInfo.vt_Subtotal = item.vt_Subtotal;
                        itemInfo.vt_iva = item.vt_iva;
                        itemInfo.vt_total = item.vt_total;

                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.nombreProducto = item.nombreProducto;
                        itemInfo.IdCategoria = item.IdCategoria;
                        itemInfo.IdLinea = item.IdLinea;
                        itemInfo.IdGrupo = item.IdGrupo;
                        itemInfo.IdSubgrupo = item.IdSubgrupo;
                        itemInfo.ca_Categoria = item.ca_Categoria;
                        itemInfo.nom_linea = item.nom_linea;
                        itemInfo.nom_grupo = item.nom_grupo;
                        itemInfo.nom_subgrupo = item.nom_subgrupo;
                        itemInfo.Idtipo_cliente = item.Idtipo_cliente;
                        itemInfo.Descripcion_tip_cliente = item.Descripcion_tip_cliente;
                        itemInfo.vt_Observacion = item.vt_Observacion;
                        itemInfo.IdVendedor = item.IdVendedor;
                        itemInfo.Vendedor = item.Vendedor;


                        lstReport.Add(itemInfo);

                    }
                }
                return lstReport;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
                return new List<XFAC_Rpt001_Info>();
            }

        }

        public XFAC_Rpt001_Data()
        {

        }
    }
}
