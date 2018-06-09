using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
  public  class XFAC_GRAF_Rpt002_Data
    {

      public List<XFAC_GRAF_Rpt002_Info> Get_List_Data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
      {
          try
          {
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

              List<XFAC_GRAF_Rpt002_Info> Lista = new List<XFAC_GRAF_Rpt002_Info>();
              using (EntitiesFacturacion_Rpt_GRAF Context = new EntitiesFacturacion_Rpt_GRAF())
              {
                  var selectGuia = from q in Context.vwFAC_GRAF_Rpt002
                                   where q.IdEmpresa == IdEmpresa
                                   && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                   select q;


                  foreach (var item in selectGuia)
                  {
                        XFAC_GRAF_Rpt002_Info info = new XFAC_GRAF_Rpt002_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdBodega = item.IdBodega;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoDocumento= item.IdTipoDocumento;
                        info.numDocumento= item.numDocumento;
                        info.IdCbteVta = item.IdCbteVta;
                        info.IdCliente= item.IdCliente;
                        info.nom_cliente= item.nom_cliente;
                        info.vt_fecha= item.vt_fecha;
                        info.IdCalendario= item.IdCalendario;
                        info.AnioFiscal= item.AnioFiscal;
                        info.NombreMes= item.NombreMes;
                        info.NombreCortoFecha= item.NombreCortoFecha;
                        info.IdProducto= item.IdProducto;
                        info.nom_producto= item.nom_producto;
                        info.vt_cantidad= item.vt_cantidad;
                        info.vt_PrecioFinal= item.vt_PrecioFinal;
                        info.vt_Subtotal= item.vt_Subtotal;
                        info.vt_iva= item.vt_iva;
                        info.vt_total= item.vt_total;
                        info.nom_sucursal= item.nom_sucursal;
                        info.IdCategoria= item.IdCategoria;
                        info.IdLinea= item.IdLinea;
                        info.IdGrupo= item.IdGrupo;
                        info.IdSubgrupo= item.IdSubgrupo;
                        info.nom_categoria= item.nom_categoria;
                        info.nom_linea= item.nom_linea;
                        info.nom_grupo= item.nom_grupo;
                        info.nom_subgrupo= item.nom_subgrupo;
                        info.Idtipo_cliente= item.Idtipo_cliente;
                        info.nom_tipo_cliente= item.nom_tipo_cliente;
                        info.vt_Observacion= item.vt_Observacion;
                        info.IdVendedor= item.IdVendedor;
                        info.nom_vendedor= item.nom_vendedor;
                        info.num_op= item.num_op;
                        info.fecha_op= item.fecha_op;
                        info.num_cotizacion= item.num_cotizacion;
                        info.fecha_cotizacion= item.fecha_cotizacion;
                        info.porc_comision= item.porc_comision;
                        info.IdEquipo= item.IdEquipo;
                        info.nom_Equipo = item.nom_Equipo;
                        info.IdMes = item.IdMes;
                        info.Estado = item.Estado;
                        info.Secuencia = item.Secuencia;       
                      Lista.Add(info);
                  }
              }
              return Lista;
          }
          catch (Exception ex)
          {
              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }
    }
}
