﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EntitiesCompras : DbContext
    {
        public EntitiesCompras()
            : base("name=EntitiesCompras")
        {
        }
        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<com_catalogo> com_catalogo { get; set; }
        public DbSet<com_catalogo_tipo> com_catalogo_tipo { get; set; }
        public DbSet<com_cotizacion_compra> com_cotizacion_compra { get; set; }
        public DbSet<com_cotizacion_compra_det> com_cotizacion_compra_det { get; set; }
        public DbSet<com_departamento> com_departamento { get; set; }
        public DbSet<com_dev_compra> com_dev_compra { get; set; }
        public DbSet<com_estado_cierre> com_estado_cierre { get; set; }
        public DbSet<com_GenerOCompra> com_GenerOCompra { get; set; }
        public DbSet<com_GenerOCompra_Det> com_GenerOCompra_Det { get; set; }
        public DbSet<com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider> com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider { get; set; }
        public DbSet<com_ListadoMateriales> com_ListadoMateriales { get; set; }
        public DbSet<com_ListadoMateriales_Det_x_com_GenerOCompra_Det> com_ListadoMateriales_Det_x_com_GenerOCompra_Det { get; set; }
        public DbSet<com_Motivo_Orden_Compra> com_Motivo_Orden_Compra { get; set; }
        public DbSet<com_ordencompra_local> com_ordencompra_local { get; set; }
        public DbSet<com_ordencompra_local_det_x_com_solicitud_compra_det> com_ordencompra_local_det_x_com_solicitud_compra_det { get; set; }
        public DbSet<com_solicitud_compra> com_solicitud_compra { get; set; }
        public DbSet<com_solicitud_compra_det_pre_aprobacion> com_solicitud_compra_det_pre_aprobacion { get; set; }
        public DbSet<vwcom_Catalogo_IdAuto_numeric> vwcom_Catalogo_IdAuto_numeric { get; set; }
        public DbSet<vwcom_cotizacion_compra> vwcom_cotizacion_compra { get; set; }
        public DbSet<vwcom_cotizacion_compra_det> vwcom_cotizacion_compra_det { get; set; }
        public DbSet<vwcom_cotizacion_compra_det_activa> vwcom_cotizacion_compra_det_activa { get; set; }
        public DbSet<vwcom_cotizacion_compra_det_Saldos> vwcom_cotizacion_compra_det_Saldos { get; set; }
        public DbSet<vwcom_dev_compra> vwcom_dev_compra { get; set; }
        public DbSet<vwcom_EstadoAnulacion> vwcom_EstadoAnulacion { get; set; }
        public DbSet<vwcom_EstadoAprob_List_Req> vwcom_EstadoAprob_List_Req { get; set; }
        public DbSet<vwcom_EstadoAprobacion> vwcom_EstadoAprobacion { get; set; }
        public DbSet<vwcom_EstadoAprobacion_sol_compra> vwcom_EstadoAprobacion_sol_compra { get; set; }
        public DbSet<vwcom_EstadoRecibido> vwcom_EstadoRecibido { get; set; }
        public DbSet<vwcom_GenerOCompra_Det> vwcom_GenerOCompra_Det { get; set; }
        public DbSet<vwcom_MotivoRequerimiento> vwcom_MotivoRequerimiento { get; set; }
        public DbSet<vwcom_ordencompra_local_con_cant_devolver> vwcom_ordencompra_local_con_cant_devolver { get; set; }
        public DbSet<vwcom_ordencompra_local_det_x_com_solicitud_compra_det> vwcom_ordencompra_local_det_x_com_solicitud_compra_det { get; set; }
        public DbSet<vwcom_ordencompra_local_det_x_MoviInven_SaldoItem> vwcom_ordencompra_local_det_x_MoviInven_SaldoItem { get; set; }
        public DbSet<vwcom_ordenesCompras_Aprobadas> vwcom_ordenesCompras_Aprobadas { get; set; }
        public DbSet<vwcom_solicitud_compra> vwcom_solicitud_compra { get; set; }
        public DbSet<vwcom_solicitud_compra_det_x_Orden_Compra> vwcom_solicitud_compra_det_x_Orden_Compra { get; set; }
        public DbSet<vwcom_TerminoPago> vwcom_TerminoPago { get; set; }
        public DbSet<com_dev_compra_det> com_dev_compra_det { get; set; }
        public DbSet<vwcom_dev_compra_con_det> vwcom_dev_compra_con_det { get; set; }
        public DbSet<vwcom_dev_compra_det_cant_devuelta_x_prod> vwcom_dev_compra_det_cant_devuelta_x_prod { get; set; }
        public DbSet<com_ordencompra_local_det> com_ordencompra_local_det { get; set; }
        public DbSet<vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven> vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven { get; set; }
        public DbSet<vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo> vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo { get; set; }
        public DbSet<com_solicitud_compra_det> com_solicitud_compra_det { get; set; }
        public DbSet<com_solicitud_compra_det_aprobacion> com_solicitud_compra_det_aprobacion { get; set; }
        public DbSet<vwcom_solicitud_compra_det> vwcom_solicitud_compra_det { get; set; }
        public DbSet<com_ListadoMateriales_Det> com_ListadoMateriales_Det { get; set; }
        public DbSet<vwcom_ordencompra_local_x_in_guia_x_traspaso_bodega> vwcom_ordencompra_local_x_in_guia_x_traspaso_bodega { get; set; }
        public DbSet<vwcom_ordencompra_local> vwcom_ordencompra_local { get; set; }
        public DbSet<vwcom_ordencompra_local_det> vwcom_ordencompra_local_det { get; set; }
        public DbSet<vwcom_ordencompra_local_vs_in_Guia_x_traspaso_bodega_Total_Reg> vwcom_ordencompra_local_vs_in_Guia_x_traspaso_bodega_Total_Reg { get; set; }
        public DbSet<vwcom_ListadoMateriales> vwcom_ListadoMateriales { get; set; }
        public DbSet<vwcom_ListadoMateriales_Detalle> vwcom_ListadoMateriales_Detalle { get; set; }
        public DbSet<vwcom_ListadoMateriales_Detalle_Saldos> vwcom_ListadoMateriales_Detalle_Saldos { get; set; }
        public DbSet<vwcom_ListadoMateriales_Detalle_SaldosReporte> vwcom_ListadoMateriales_Detalle_SaldosReporte { get; set; }
        public DbSet<vwcom_AllListDetMateriales> vwcom_AllListDetMateriales { get; set; }
        public DbSet<vwcom_solicitud_compra_det_aprobacion> vwcom_solicitud_compra_det_aprobacion { get; set; }
        public DbSet<com_TerminoPago> com_TerminoPago { get; set; }
        public DbSet<vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega> vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega { get; set; }
        public DbSet<vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul> vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul { get; set; }
        public DbSet<vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_det> vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_det { get; set; }
        public DbSet<vwcom_ordencompra_local_consulta> vwcom_ordencompra_local_consulta { get; set; }
        public DbSet<vwcom_solicitud_compra_x_items_con_saldos> vwcom_solicitud_compra_x_items_con_saldos { get; set; }
        public DbSet<com_comprador_familia> com_comprador_familia { get; set; }
        public DbSet<com_CotizacionPedidoSaltar> com_CotizacionPedidoSaltar { get; set; }
        public DbSet<com_CotizacionPedidoDet> com_CotizacionPedidoDet { get; set; }
        public DbSet<com_OrdenPedidoDet> com_OrdenPedidoDet { get; set; }
        public DbSet<vwcom_OrdenPedido> vwcom_OrdenPedido { get; set; }
        public DbSet<vwcom_OrdenPedidoDet_Aprobacion> vwcom_OrdenPedidoDet_Aprobacion { get; set; }
        public DbSet<com_solicitante> com_solicitante { get; set; }
        public DbSet<vwcom_CotizacionPedidoDetAprobacion> vwcom_CotizacionPedidoDetAprobacion { get; set; }
        public DbSet<vwcom_OrdenPedidoDet> vwcom_OrdenPedidoDet { get; set; }
        public DbSet<com_CotizacionPedido> com_CotizacionPedido { get; set; }
        public DbSet<vwcom_CotizacionPedido> vwcom_CotizacionPedido { get; set; }
        public DbSet<com_ordencompra_local_correo> com_ordencompra_local_correo { get; set; }
        public DbSet<com_parametro> com_parametro { get; set; }
        public DbSet<com_comprador> com_comprador { get; set; }
        public DbSet<vwcom_ordencompra_local_correo> vwcom_ordencompra_local_correo { get; set; }
        public DbSet<vwcom_CotizacionPedidoDet> vwcom_CotizacionPedidoDet { get; set; }
        public DbSet<vwcom_OrdenPedidoDet_Cotizacion> vwcom_OrdenPedidoDet_Cotizacion { get; set; }
        public DbSet<com_solicitante_aprobador> com_solicitante_aprobador { get; set; }
        public DbSet<com_OrdenPedido> com_OrdenPedido { get; set; }
        public DbSet<vwcom_OrdenPedidoAprobar> vwcom_OrdenPedidoAprobar { get; set; }
        public DbSet<vwcom_solicitante> vwcom_solicitante { get; set; }
    
        public virtual ObjectResult<SPCOM_ComprasPorPuntoCargo_Result> SPCOM_ComprasPorPuntoCargo(Nullable<int> idEmpresa, Nullable<int> idPuntoCargo)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPuntoCargoParameter = idPuntoCargo.HasValue ?
                new ObjectParameter("IdPuntoCargo", idPuntoCargo) :
                new ObjectParameter("IdPuntoCargo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPCOM_ComprasPorPuntoCargo_Result>("SPCOM_ComprasPorPuntoCargo", idEmpresaParameter, idPuntoCargoParameter);
        }
    }
}
