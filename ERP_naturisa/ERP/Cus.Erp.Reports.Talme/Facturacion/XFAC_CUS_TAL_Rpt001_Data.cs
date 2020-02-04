using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cus.Erp.Reports.Talme.Facturacion;



namespace Cus.Erp.Reports.Talme.Facturacion
{
   public  class XFAC_CUS_TAL_Rpt001_Data
    {

       List<XFAC_CUS_TAL_Rpt001_Info> listado = new List<XFAC_CUS_TAL_Rpt001_Info>();


        public List<XFAC_CUS_TAL_Rpt001_Info> Obtener_data(int idempresa,int idsucursal,int idbodega,decimal idpedido,
            ref string mensaje)
        {

            try
            {
                using (EntitiesFacturacion_Rpt DB = new EntitiesFacturacion_Rpt())
                {
                    var Consulta = from q in DB.vwFAC_CUS_TAL_Rpt001
                                   where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.IdBodega == idbodega
                                   && q.IdPedido == idpedido
                                   select q;

                    foreach (var item in Consulta)
                    {
                        XFAC_CUS_TAL_Rpt001_Info Info = new XFAC_CUS_TAL_Rpt001_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.em_nombre = item.em_nombre;
                        Info.IdCliente = item.IdCliente;
                        Info.IdSucursal = item.IdSucursal;
                        Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        Info.Su_Descripcion = item.Su_Descripcion;
                        Info.bo_Descripcion = item.bo_Descripcion;
                        Info.cp_diasPlazo = item.cp_diasPlazo;
                        Info.IdPedido = item.IdPedido;
                        Info.cp_desUni = item.cp_desUni;
                        Info.cp_fecha = item.cp_fecha;
                        Info.cp_fechaVencimiento = item.cp_fechaVencimiento;
                        Info.cp_observacion = item.cp_observacion;
                        Info.cp_PrecioFinal = item.cp_PrecioFinal;
                        Info.dp_cantidad = item.dp_cantidad;
                        Info.dp_iva = item.dp_iva;
                        Info.dp_peso = Convert.ToDouble(item.dp_peso);
                        Info.dp_PorDescuento = item.dp_PorDescuento;
                        Info.dp_precio = item.dp_precio;
                        Info.dp_subtotal = item.dp_subtotal;
                        Info.dp_total = item.dp_total;
                        Info.IdBodega = item.IdBodega;
                        Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        Info.IdEstadoProduccion = item.IdEstadoProduccion;
                        Info.IdPersona = item.IdPersona;
                        Info.IdProducto = item.IdProducto;
                        Info.interes = item.interes;
                        Info.otro1 = item.otro1;
                        Info.otro2 = item.otro2;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.Secuencial = item.Secuencial;
                        Info.transporte = item.transporte;
                        Info.pe_razonSocial = item.pe_razonSocial;
                        Info.pe_telefonoCasa = item.pe_telefonoCasa;
                        Info.pe_telefonoOfic = item.pe_telefonoOfic;
                        Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Info.pe_correo = item.pe_correo;
                        Info.pe_direccion = item.pe_direccion;
                                                                      
                       listado.Add(Info);
                    }
                }
                //return Lst;
                return listado;
            }
            catch (Exception ex)
            {
                //string arreglo = ToString();
                //tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                //tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                //oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                //mensaje = ex.InnerException + " " + ex.Message;
                return new List<XFAC_CUS_TAL_Rpt001_Info>();
            }




        }
       

    }
}
