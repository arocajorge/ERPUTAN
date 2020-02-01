using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt029_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt029_Info> consultar_data(int IdEmpresa, int IdBodega, int IdBodegaFin, int IdSucursal, int IdSucursalFin,DateTime fecha_corte, ref String MensajeError)
        {
            try
            {
                List<XINV_Rpt029_Info> listadedatos = new List<XINV_Rpt029_Info>();

                using (Entities_Inventario_General BalanceGeneral = new Entities_Inventario_General())
                {
                    BalanceGeneral.SetCommandTimeOut(3000);
                    var select = from h in BalanceGeneral.spINV_Rpt029(IdEmpresa,IdSucursal,IdSucursalFin, IdBodega,IdBodegaFin,fecha_corte)
                                 select h;
                    foreach (var item in select)
                    {
                        XINV_Rpt029_Info itemInfo = new XINV_Rpt029_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.pr_codigo = item.pr_codigo;
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.pr_observacion = item.pr_observacion;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.Stock = item.Stock;
                        itemInfo.costo = Convert.ToDouble(item.mv_costo);
                        itemInfo.costo_total = Convert.ToDouble(item.costo_total);
                        itemInfo.nom_UnidadMedida = item.nom_UnidadMedida;
                        itemInfo.nom_UnidadMedidaCompra = item.nom_UnidadMedidaCompra;
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt029_Info>();
            }
        }

        public List<XINV_Rpt029_Info> Get_data(int IdEmpresa, int IdSucursal, List<int> lst_bod, Boolean Registro_Cero,DateTime Fecha_corte, ref String MensajeError)
        {
            try
            {
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;

                //Sucursal
                IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
                IdSucursalFin = (IdSucursal == 0) ? 999999 : IdSucursal;
                Fecha_corte = Fecha_corte.Date;
                List<XINV_Rpt029_Info> listadedatos = new List<XINV_Rpt029_Info>();

                using (Entities_Inventario_General BalanceGeneral = new Entities_Inventario_General())
                {
                    BalanceGeneral.SetCommandTimeOut(3000);
                    foreach (var item_bod in lst_bod)
                    {
                        var select = from h in BalanceGeneral.spINV_Rpt029(IdEmpresa, IdSucursalIni, IdSucursalFin, item_bod, item_bod, Fecha_corte)
                                     select h;

                        if (Registro_Cero == false)
                            select = select.Where(v => Math.Round(v.Stock, 2) != 0);

                        foreach (var item in select)
                        {
                            XINV_Rpt029_Info itemInfo = new XINV_Rpt029_Info();
                            itemInfo.IdEmpresa = item.IdEmpresa;
                            itemInfo.IdBodega = item.IdBodega;
                            itemInfo.IdSucursal = item.IdSucursal;
                            itemInfo.IdProducto = item.IdProducto;
                            itemInfo.IdSucursal = item.IdSucursal;
                            itemInfo.pr_codigo = item.pr_codigo;
                            itemInfo.pr_descripcion = item.pr_descripcion;
                            itemInfo.pr_observacion = item.pr_observacion;
                            itemInfo.nom_bodega = item.nom_bodega;
                            itemInfo.nom_sucursal = item.nom_sucursal;
                            itemInfo.Stock = item.Stock;
                            itemInfo.costo = Convert.ToDouble(item.mv_costo);
                            itemInfo.costo_total = Convert.ToDouble(item.costo_total);
                            itemInfo.IdCategoria = item.IdCategoria;
                            itemInfo.ca_Categoria = item.ca_Categoria;
                            itemInfo.IdLinea = item.IdLinea;
                            itemInfo.nom_linea = item.nom_linea;
                            itemInfo.nom_UnidadMedida = item.nom_UnidadMedida;
                            itemInfo.nom_UnidadMedidaCompra = item.nom_UnidadMedidaCompra;
                            listadedatos.Add(itemInfo);
                        }
                    }
                    
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                
                return new List<XINV_Rpt029_Info>();
            }
        }

        public List<XINV_Rpt029_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime fecha_corte)
        {
            try
            {
                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 9999999 : IdProducto;

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 99999 : IdSucursal;

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                List<XINV_Rpt029_Info> Lista = new List<XINV_Rpt029_Info>();

                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    /*
                    var lst = from q in Context.vwINV_Rpt029
                              where q.IdEmpresa == IdEmpresa
                              && IdSucursal_ini <= q.IdSucursalOrigen && q.IdSucursalOrigen <= IdSucursal_fin
                              && IdBodega_ini <= q.IdBodegaOrigen && q.IdBodegaOrigen <= IdBodega_fin
                              && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                              && q.Fecha <= fecha_corte
                              select q;
                    
                    foreach (var item in lst)
                    {
                        XINV_Rpt029_Info itemInfo = new XINV_Rpt029_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursalOrigen = item.IdSucursalOrigen;
                        itemInfo.IdBodegaOrigen = item.IdBodegaOrigen;
                        itemInfo.IdProducto = Convert.ToDecimal(item.IdProducto);
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.IdTransferencia = item.IdTransferencia;
                        itemInfo.dt_secuencia = item.dt_secuencia;
                        itemInfo.dt_cantidad = item.dt_cantidad;
                        itemInfo.IdEstablecimiento = item.IdEstablecimiento;
                        itemInfo.IdPuntoEmision = item.IdPuntoEmision;
                        itemInfo.NumDocumento_Guia = item.NumDocumento_Guia;
                        itemInfo.NumeroAutorizacion = item.NumeroAutorizacion;
                        itemInfo.FechaAutorizacion = item.FechaAutorizacion;
                        itemInfo.IdentificacionTransportista = item.IdentificacionTransportista;
                        itemInfo.NombreTransportista = item.NombreTransportista;
                        itemInfo.MotivoGuia = item.MotivoGuia;
                        itemInfo.Direc_sucu_Llegada = item.Direc_sucu_Llegada;
                        itemInfo.Direc_sucu_Partida = item.Direc_sucu_Partida;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.Nombre = item.Nombre;
                        itemInfo.NombreDestinatario = item.NombreDestinatario;
                        itemInfo.IdentificacionDestinatario = item.IdentificacionDestinatario;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.Su_Direccion = item.Su_Direccion;
                        itemInfo.NombreEmpresa = item.NombreEmpresa;
                        itemInfo.NumeroContribuyente = item.NumeroContribuyente;
                        itemInfo.em_ruc = item.em_ruc;
                        Lista.Add(itemInfo);
                    }
                     * */
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
