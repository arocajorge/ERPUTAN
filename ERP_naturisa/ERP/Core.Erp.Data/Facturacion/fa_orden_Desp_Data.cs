using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_orden_Desp_Data
    {
        string mensaje = "";
        fa_orden_Desp_det_Data DataDetalle = new fa_orden_Desp_det_Data();
        fa_orden_Desp_det_x_fa_pedido_det_Data DataOrdenXpedido = new fa_orden_Desp_det_x_fa_pedido_det_Data();
        fa_guia_remision_det_x_fa_orden_Desp_det_Data data = new fa_guia_remision_det_x_fa_orden_Desp_det_Data();

        public List<fa_orden_Desp_Info> Get_List_orden_Desp(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin
            , DateTime FechaIni, DateTime FechaFin) 
        {
            try
            {
                List<fa_orden_Desp_Info> lst = new List<fa_orden_Desp_Info>();


                EntitiesFacturacion OEnti = new EntitiesFacturacion();

                if (IdSucursalFin == 0)
                {
                    IdSucursalIni = 0;
                    IdSucursalFin = 5000;
                }

                if (IdBodegaFin == 0)
                {
                    IdBodegaIni = 0;
                    IdBodegaFin = 5000;
                }

              
                    var selectDespachos = from q in OEnti.vwfa_orden_despacho_detalle
                                          where q.IdEmpresa == IdEmpresa
                                          && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                          && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                          && q.od_fecha >= FechaIni && q.od_fecha <= FechaFin
                                          select q;
             

                var CabeceraOrden = from cab in selectDespachos
                                    group cab by new
                                    {
                                        cab.od_DespAbierto,
                                        cab.CodOrdenDespacho,
                                        cab.IdEmpresa,
                                        cab.IdBodega,
                                        cab.IdSucursal,
                                        cab.bo_Descripcion,
                                        cab.Su_Descripcion,
                                        cab.Ve_Vendedor,
                                        cab.pe_apellido,
                                        cab.pe_nombre,
                                        cab.IdOrdenDespacho,
                                        cab.Estado,
                                        cab.IdTransportista,
                                        cab.od_Observacion,
                                        cab.od_TotalKilos,
                                        cab.od_TotalQuintales,
                                        cab.od_fecha,
                                        cab.od_fech_venc,
                                        cab.od_plazo,
                                        cab.IdCliente,
                                        cab.IdVendedor
                                    }
                                        into grouping
                                        select new { grouping.Key/*, Subototal = grouping.Sum(p => p.od_Subtotal), Iva = grouping.Sum(p => p.od_iva), Total = grouping.Sum(p => p.od_total) */ };

                 foreach (var item in CabeceraOrden)
                {
                    fa_orden_Desp_Info info = new fa_orden_Desp_Info();
                    info.CodOrden = item.Key.CodOrdenDespacho;
                     info.od_DespAbierto = item.Key.od_DespAbierto;
                    info.IdCliente = item.Key.IdCliente;
                    info.IdVendedor = item.Key.IdVendedor;
                    info.IdBodega = item.Key.IdBodega;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Cliente = item.Key.pe_nombre + " " + item.Key.pe_apellido;
                    info.Estado = item.Key.Estado;
                    info.od_TotalKilos = (float)item.Key.od_TotalKilos;
                    info.od_TotalQuintales = (float)item.Key.od_TotalQuintales;
                    //info.Subtotal = Convert.ToDecimal(item.Subototal);
                    //info.Total = item.Total;
                    //info.Iva = item.Iva;
                    info.IdOrdenDespacho = item.Key.IdOrdenDespacho;
                    info.od_Observacion = item.Key.od_Observacion;
                    info.IdTransportista = item.Key.IdTransportista; ;
                    info.od_fecha=item.Key.od_fecha;
                    info.od_plazo = item.Key.od_plazo; 
                     info.od_fech_venc = item.Key.od_fech_venc;

    
                    lst.Add(info);


                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        
        }


        public Boolean VerificarCodigo(string Codigo, int IdEmpresa)
        {

            try
            {

                EntitiesFacturacion oen = new EntitiesFacturacion();

                var select = from q in oen.fa_orden_Desp
                             where q.CodOrdenDespacho == Codigo && q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count() >= 1)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarEstado(int IdEmpresa, fa_orden_Desp_Info oCot)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_orden_Desp.FirstOrDefault(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdOrdenDespacho == oCot.IdOrdenDespacho && minfo.IdBodega == oCot.IdBodega&& minfo.IdSucursal == oCot.IdSucursal);
                    if (contact != null)
                    {
                        contact.MotivoAnu = oCot.MotivoAnu;
                        contact.ip = oCot.ip;
                        contact.nom_pc = oCot.nom_pc;
                        contact.Fecha_UltAnu = oCot.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = oCot.IdUsuarioUltAnu;
                        contact.Estado = "I";
                        context.SaveChanges();
                        DataOrdenXpedido.EliminarDB(oCot);
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_rpt_orden_Desp_Info Get_Info_rpt_orde_Despacho(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin
            , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                EntitiesFacturacion OEnti = new EntitiesFacturacion();

                if (IdSucursalFin == 0)
                {
                    IdSucursalIni = 0;
                    IdSucursalFin = 5000;
                }

                if (IdBodegaFin == 0)
                {
                    IdBodegaIni = 0;
                    IdBodegaFin = 5000;
                }



                var selectDespachos = from q in OEnti.vwfa_orden_despacho_detalle
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                      && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                      && q.od_fecha >= FechaIni && q.od_fecha <= FechaFin
                                      select q;

                var CabeceraOrden = from cab in selectDespachos
                                    group cab by new
                                    {
                                        cab.IdEmpresa,
                                        cab.IdBodega,
                                        cab.IdSucursal,
                                        cab.bo_Descripcion,
                                        cab.Su_Descripcion,
                                        cab.Ve_Vendedor,
                                        cab.pe_apellido,
                                        cab.pe_nombre,
                                        cab.IdOrdenDespacho,
                                        cab.Estado,
                                        cab.od_Observacion,
                                        cab.od_TotalKilos,
                                        cab.od_TotalQuintales,
                                        cab.IdTransportista,
                                        cab.od_fecha,
                                        cab.od_fech_venc,
                                        cab.od_plazo


                                    }
                                        into grouping
                                        select new { grouping.Key, Subototal = grouping.Sum(p => p.od_Subtotal), Iva = grouping.Sum(p => p.od_iva), Total = grouping.Sum(p => p.od_total) };
                fa_rpt_orden_Desp_Info lst = new fa_rpt_orden_Desp_Info();
                List<fa_orden_Desp_Info> lista = new List<fa_orden_Desp_Info>();

                foreach (var item in CabeceraOrden)
                {

                    fa_orden_Desp_Info info = new fa_orden_Desp_Info();
                    info.IdEmpresa = item.Key.IdBodega;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Cliente = item.Key.pe_nombre + " " + item.Key.pe_apellido;
                    info.Estado = item.Key.Estado;
                    info.Subtotal = Convert.ToDecimal(item.Subototal);
                    info.Total = item.Total;
                    info.Iva = item.Iva;
                    info.IdOrdenDespacho = item.Key.IdOrdenDespacho;
                    info.od_Observacion = item.Key.od_Observacion;
                    info.IdTransportista = item.Key.IdTransportista;
                    info.od_fecha = item.Key.od_fecha;
                    info.od_plazo = item.Key.od_plazo;
                    info.od_fech_venc = item.Key.od_fech_venc;



                    lista.Add(info);


                }

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int idEmpresa)
        {
            try
            {
                decimal IdOrde = 0;
               

                    EntitiesFacturacion oEFAC = new EntitiesFacturacion();

                    var Select = from q in oEFAC.fa_orden_Desp
                                 where q.IdEmpresa == idEmpresa
                                 select q;
                    if (Select.ToList().Count == 0)
                    {
                        IdOrde = 1;
                        return 1;
                    }
                    else
                    {

                        var qmax = (from q in oEFAC.fa_orden_Desp
                                    where q.IdEmpresa == idEmpresa
                                    select q.IdOrdenDespacho).Max();


                        IdOrde = Convert.ToInt32(qmax.ToString()) + 1;

                        return IdOrde;

                    }
               
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_orden_Desp_Info info, ref decimal IdOrdenDespacho) 
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    
                    var address = new fa_orden_Desp();

                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdBodega = info.IdBodega;
                    address.IdOrdenDespacho =IdOrdenDespacho= GetId(info.IdEmpresa);
                    address.CodOrdenDespacho = (info.CodOrden == "") ? "Ord" + IdOrdenDespacho : info.CodOrden;
                    address.IdCliente = info.IdCliente;
                    address.IdVendedor = info.IdVendedor;
                    address.IdTransportista = info.IdTransportista;
                    address.od_fecha = info.od_fecha;
                    address.od_plazo = info.od_plazo;
                    address.od_fech_venc = info.od_fech_venc;
                    address.od_Observacion = info.od_Observacion;
                    address.od_TotalKilos = info.od_TotalKilos;
                    address.od_TotalQuintales = info.od_TotalQuintales;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Estado ="A";
                    address.od_DespAbierto = info.od_DespAbierto;

                    int c = 1;
                    (from q in info.ListaDetalle select q).ToList().ForEach(var => 
                    { var.IdOrdenDespacho = address.IdOrdenDespacho; 
                      var.IdEmpresa = info.IdEmpresa;
                      var.Secuencia = c; 
                      c++;
                     var.IdSucursal = info.IdSucursal; 
                     var.IdBodega = info.IdBodega; });

                    context.fa_orden_Desp.Add(address);
                    context.SaveChanges();
                    if (DataDetalle.GuardarDB(info))
                    {
                        if (info.od_DespAbierto == "N")
                        {
                            if (DataOrdenXpedido.GuardarDB(info))
                            {
                                                              
                                return true;

                            }
                            else
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    else 
                    {
                        return false;
                    }                
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_orden_Desp_Info> Get_List_Orden_Desp_x_Cliente(int IdEmpresa, int IdSucursal ,int IdBodega,decimal Idcliente )
        {
            try
            {
                List<fa_orden_Desp_Info> lst = new List<fa_orden_Desp_Info>();
                EntitiesFacturacion OEnti = new EntitiesFacturacion();
                var selectDespachos = from q in OEnti.vwfa_orden_Desp_sin_guiaRemi
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdBodega == IdBodega
                                      && q.IdSucursal == IdSucursal
                                      && q.IdCliente == Idcliente
                                      && q.Estado =="A"
                                      select q;
                var CabeceraOrden = from cab in selectDespachos
                                    group cab by new
                                    {
                                        cab.od_DespAbierto,
                                        cab.CodOrdenDespacho,
                                        cab.IdEmpresa,
                                        cab.IdBodega,
                                        cab.IdSucursal,
                                        cab.IdVendedor,
                                        
                                        cab.IdOrdenDespacho,
                                        cab.Estado,
                                        cab.IdTransportista,
                                        cab.od_Observacion,
                                        cab.od_TotalKilos,
                                        cab.od_TotalQuintales,
                                        cab.od_fecha,
                                        cab.od_fech_venc,
                                        cab.od_plazo,
                                        cab.IdCliente,
                                    }
                                        into grouping
                                        select new { grouping.Key };

                foreach (var item in CabeceraOrden)
                {
                    fa_orden_Desp_Info info = new fa_orden_Desp_Info();
                    info.CodOrden = item.Key.CodOrdenDespacho;
                    info.od_DespAbierto = item.Key.od_DespAbierto;
                    info.IdCliente = item.Key.IdCliente;
                    info.IdVendedor = item.Key.IdVendedor;
                    info.IdBodega = item.Key.IdBodega;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.Estado = item.Key.Estado;
                    info.od_TotalKilos = (float)item.Key.od_TotalKilos;
                    info.od_TotalQuintales = (float)item.Key.od_TotalQuintales;
                    info.IdOrdenDespacho = item.Key.IdOrdenDespacho;
                    info.od_Observacion = item.Key.od_Observacion;
                    info.IdTransportista = item.Key.IdTransportista; ;
                    info.od_fecha = item.Key.od_fecha;
                    info.od_plazo = item.Key.od_plazo;
                    info.od_fech_venc = item.Key.od_fech_venc;


                    lst.Add(info);


                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }

        public Boolean ModificarDB(int IdEmpresa, fa_orden_Desp_Info info)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_orden_Desp.FirstOrDefault(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdOrdenDespacho == info.IdOrdenDespacho && minfo.IdBodega == info.IdBodega && minfo.IdSucursal == info.IdSucursal);
                    if (contact != null)
                    {
                        contact.IdTransportista = info.IdTransportista;
                        contact.od_fecha = info.od_fecha;
                        contact.od_plazo = info.od_plazo;
                        contact.od_fech_venc = info.od_fech_venc;
                        contact.od_TotalKilos = info.od_TotalKilos;
                        contact.od_TotalQuintales = info.od_TotalQuintales;
                        contact.Fecha_Transac = info.Fecha_Transac;
                        contact.od_fecha = info.od_fecha;

                        contact.od_Observacion = info.od_Observacion;

                        contact.IdUsuarioUltMod = info.IdUsuario;
                        contact.Fecha_UltMod = DateTime.Now;

                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        context.SaveChanges();
                    }
             
                    if (info.od_DespAbierto == "N")
                    {
                        if (DataOrdenXpedido.EliminarDB(info))
                        {

                            if (info.ListaGuiaRemision.Count() !=0)
                            {
                                data.Eliminar_fa_guia_remision_det_x_fa_orden_Desp_det(info);                                                          
                            }
                            
                            if (DataDetalle.EliminarDB(info))
                            {
                                int c = 1;
                                (from q in info.ListaDetalle select q).ToList().ForEach(var =>
                                {
                                    var.IdOrdenDespacho = info.IdOrdenDespacho;
                                    var.IdEmpresa = info.IdEmpresa;
                                    var.Secuencia = c;
                                    c++;
                                    var.IdSucursal = info.IdSucursal;
                                    var.IdBodega = info.IdBodega;
                                });
                                                                                              
                                if (DataDetalle.GuardarDB(info))
                                {
                                                                                                                                                                            
                                    if (info.od_DespAbierto == "N")
                                    {
                                        if (DataOrdenXpedido.GuardarDB(info))
                                        {

                                            if (info.ListaGuiaRemision.Count() != 0)
                                            {
                                                fa_guia_remision_Info infoGuia = new fa_guia_remision_Info();

                                                foreach (var item in info.ListaGuiaRemision)
                                                {
                                                    fa_guia_remision_det_Info info1 = new fa_guia_remision_det_Info();

                                                    info1.IdEmpresa = item.gi_IdEmpresa;
                                                    info1.IdSucursal = item.gi_IdSucursal;
                                                    info1.IdBodega = item.gi_IdBodega;

                                                    info1.IdGuiaRemision = item.gi_IdGuiaRemision;
                                                    info1.od_IdOrdenDespacho = item.od_IdOrdenDespacho;

                                                    info1.gi_cantidad = item.gi_cantidad;
                                                    info1.IdProducto = item.gi_IdProducto;
                                                    info1.Secuencia = item.gi_Secuencia;
                                                                                                                                                                                                                                                             
                                                    infoGuia.ListaDetalle.Add(info1);
                                                
                                                }
                                             
                                                string msg = "";
                                                data.GuardarDB(infoGuia, ref msg);
                                            }
                                                                                      
                                           return true;                                            
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }

                                }
                                else
                                {
                                    return false;
                                }

                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }

                    }

                    if (DataDetalle.EliminarDB(info))
                    {
                        if (DataDetalle.GuardarDB(info))
                        {
                            return true;

                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }


                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
