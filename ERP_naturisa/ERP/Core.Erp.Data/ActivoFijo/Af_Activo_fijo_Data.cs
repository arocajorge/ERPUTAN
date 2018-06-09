using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Info.Facturacion_FJ;
using System.Data.Entity.Validation;


namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Activo_fijo_Data
    {
        string mensaje = "";

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo(int IdEmpresa, string EstadoProceso)
        {
                List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             select A;

                if (EstadoProceso != "")
                {
                    select = select.Where(q => q.Estado_Proceso == EstadoProceso);
                }

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre;
                    info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie;
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Es_carroceria = item.Es_carroceria;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion;
                    info.Af_NumPlaca = item.Af_NumPlaca;
                    info.Af_Anio_fabrica =  item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                    info.Af_foto = item.Af_foto;
                    info.Af_Depreciacion_acum = item.Af_Depreciacion_acum;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.IdPeriodoDeprec = item.IdPeriodoDeprec;
                    info.Af_Codigo_Parte = item.Af_Codigo_Parte;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;

                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.IdProveedor = item.IdProveedor;
                    info.Af_FechaPoliza = item.Af_FechaPoliza;
                    info.Af_ValorPoliza =item.Af_ValorPoliza;
                    info.Af_ValorVenta = item.Af_ValorVenta;
                    info.Af_NumPoliza = item.Af_NumPoliza;
                    info.Af_Fecha_Venta = item.Af_Fecha_Venta;
                    info.Af_Fecha_Vencimiento = item.Af_Fecha_Vencimiento;
                    info.Af_Fecha_Retiro = item.Af_Fecha_Retiro;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;

                    info.IdEmpresa_oc = item.IdEmpresa_oc;
                    info.IdSucursal_oc = item.IdSucursal_oc;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.Secuencia_oc;
                    info.IdProducto = item.IdProducto;
                    info.numDocumento = item.numDocumento;
                    info.Cantidad = item.Cantidad;
                    info.Costo_uni = item.Costo_uni;
                    info.SubTotal = item.SubTotal;
                    info.valor_Iva = item.valor_Iva;
                    info.Total = item.Total;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;

                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;

                    info.IdDepartamento = item.IdDepartamento;
                    info.IdEncargado = item.IdEncargado;

                    info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                    info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.Af_fecha_vigencia_desde = item.Af_fecha_vigencia_desde;
                    info.SubTotal = item.Subtotal_Prima;
                    info.valor_Iva = item.Iva_Prima;
                    info.Af_valor_prima = item.Prima;

                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

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

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo(int IdEmpresa)
        {
            List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre.Trim();
                    info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie;
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;

                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion;

                    info.Af_NumPlaca =( item.Af_NumPlaca==null)?"": item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.IdPeriodoDeprec = item.IdPeriodoDeprec;
                    info.Af_Codigo_Parte = item.Af_Codigo_Parte;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.Es_carroceria = item.Es_carroceria;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.IdProveedor = item.IdProveedor;
                    info.Af_FechaPoliza = item.Af_FechaPoliza;
                    info.Af_ValorPoliza = item.Af_ValorPoliza;
                    info.Af_ValorVenta = item.Af_ValorVenta;
                    info.Af_NumPoliza = item.Af_NumPoliza;
                    info.Af_Fecha_Venta = item.Af_Fecha_Venta;
                    info.Af_Fecha_Vencimiento = item.Af_Fecha_Vencimiento;
                    info.Af_Fecha_Retiro =item.Af_Fecha_Retiro;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;

                    info.IdEmpresa_oc = item.IdEmpresa_oc;
                    info.IdSucursal_oc = item.IdSucursal_oc;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.Secuencia_oc;
                    info.IdProducto = item.IdProducto;
                    info.numDocumento = item.numDocumento;
                    info.Cantidad = item.Cantidad;
                    info.Costo_uni = item.Costo_uni;
                    info.SubTotal = item.SubTotal;
                    info.valor_Iva =item.valor_Iva;
                    info.Total = item.Total;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;

                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;

                    info.IdDepartamento = item.IdDepartamento;
                    info.IdEncargado =item.IdEncargado;
                    info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                    info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.Af_fecha_vigencia_desde = item.Af_fecha_vigencia_desde;
                    info.SubTotal = item.Subtotal_Prima;
                    info.valor_Iva = item.Iva_Prima;
                    info.Af_valor_prima = item.Prima;

                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;


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

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo_x_categoria(int IdEmpresa, int idCategoria)
        {
            List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && idCategoria== A.IdCategoriaAF
                             select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre.Trim();
                    info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie.Trim();
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Es_carroceria = item.Es_carroceria;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion.Trim();
                    info.Af_NumPlaca = item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.IdPeriodoDeprec = item.IdPeriodoDeprec;
                    info.Af_Codigo_Parte = item.Af_Codigo_Parte;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;

                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.IdProveedor = item.IdProveedor;
                    info.Af_FechaPoliza = item.Af_FechaPoliza;
                    info.Af_ValorPoliza = item.Af_ValorPoliza;
                    info.Af_ValorVenta = item.Af_ValorVenta;
                    info.Af_NumPoliza = item.Af_NumPoliza;
                    info.Af_Fecha_Venta = item.Af_Fecha_Venta;
                    info.Af_Fecha_Vencimiento = item.Af_Fecha_Vencimiento;
                    info.Af_Fecha_Retiro = item.Af_Fecha_Retiro;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;

                    info.IdEmpresa_oc = item.IdEmpresa_oc;
                    info.IdSucursal_oc = item.IdSucursal_oc;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.Secuencia_oc;
                    info.IdProducto = item.IdProducto;
                    info.numDocumento = item.numDocumento;
                    info.Cantidad = item.Cantidad;
                    info.Costo_uni = item.Costo_uni;
                    info.SubTotal = item.SubTotal;
                    info.valor_Iva = item.valor_Iva;
                    info.Total = item.Total;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;

                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;

                    info.IdDepartamento = item.IdDepartamento;
                    info.IdEncargado = item.IdEncargado;
                    info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                    info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.Af_fecha_vigencia_desde = item.Af_fecha_vigencia_desde;
                    info.SubTotal = item.Subtotal_Prima;
                    info.valor_Iva = item.Iva_Prima;
                    info.Af_valor_prima = item.Prima;

                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;


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

        public Af_Activo_fijo_Info Get_Info_ActivoFijo(int IdEmpresa, int IdActivoFijo)
        {
            Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && A.IdActivoFijo == IdActivoFijo
                             
                             select A;

                foreach (var item in select)
                {
                    info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre;
                    info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie;
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_Capacidad = item.Af_Capacidad;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion;
                    info.Af_NumPlaca = item.Af_NumPlaca;
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.IdPeriodoDeprec = item.IdPeriodoDeprec;
                    info.Af_Codigo_Parte = item.Af_Codigo_Parte;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.IdProveedor = item.IdProveedor;
                    info.Es_carroceria = item.Es_carroceria;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.IdProveedor = item.IdProveedor;
                    info.Af_FechaPoliza = item.Af_FechaPoliza;
                    info.Af_ValorPoliza = item.Af_ValorPoliza;
                    info.Af_ValorVenta = item.Af_ValorVenta;
                    info.Af_NumPoliza = item.Af_NumPoliza;
                    info.Af_Fecha_Venta = item.Af_Fecha_Venta;
                    info.Af_Fecha_Vencimiento = item.Af_Fecha_Vencimiento;
                    info.Af_Fecha_Retiro = item.Af_Fecha_Retiro;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;

                    info.IdEmpresa_oc = item.IdEmpresa_oc;
                    info.IdSucursal_oc =item.IdSucursal_oc;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.Secuencia_oc;
                    info.IdProducto =item.IdProducto;
                    info.numDocumento = item.numDocumento;
                    info.Cantidad = item.Cantidad;
                    info.Costo_uni = item.Costo_uni;
                    info.SubTotal = item.SubTotal;
                    info.valor_Iva = item.valor_Iva;
                    info.Total = item.Total;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;

                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.IdDepartamento = item.IdDepartamento;
                    info.IdEncargado = item.IdEncargado;

                    info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                    info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.Af_fecha_vigencia_desde = item.Af_fecha_vigencia_desde;
                    info.SubTotal = item.Subtotal_Prima;
                    info.valor_Iva = item.Iva_Prima;
                    info.Af_valor_prima = item.Prima;

                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

                }
                return info;
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

        public Af_Activo_fijo_Info Get_ActivoFijo(int IdEmpresa, string codigo)
        {
            Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && A.CodActivoFijo.Equals(codigo)

                             select A;

                foreach (var item in select)
                {

                    info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre.Trim();
                    info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = (item.Af_NumSerie == null) ? null : item.Af_NumSerie.Trim();
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_Capacidad = item.Af_Capacidad;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = (item.Af_observacion == null) ? null : item.Af_observacion.Trim();
                    info.Af_NumPlaca = (item.Af_NumPlaca == null) ? null : item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.IdPeriodoDeprec = item.IdPeriodoDeprec;
                    info.Af_Codigo_Parte = item.Af_Codigo_Parte;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.IdProveedor = item.IdProveedor;
                    info.Es_carroceria = item.Es_carroceria;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.IdProveedor = item.IdProveedor;
                    info.Af_FechaPoliza = item.Af_FechaPoliza;
                    info.Af_ValorPoliza = item.Af_ValorPoliza;
                    info.Af_ValorVenta = item.Af_ValorVenta;
                    info.Af_NumPoliza = item.Af_NumPoliza;
                    info.Af_Fecha_Venta = item.Af_Fecha_Venta;
                    info.Af_Fecha_Vencimiento = item.Af_Fecha_Vencimiento;
                    info.Af_Fecha_Retiro = item.Af_Fecha_Retiro;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;

                    info.IdEmpresa_oc = item.IdEmpresa_oc;
                    info.IdSucursal_oc = item.IdSucursal_oc;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.Secuencia_oc;
                    info.IdProducto = item.IdProducto;
                    info.numDocumento = item.numDocumento;
                    info.Cantidad = item.Cantidad;
                    info.Costo_uni = item.Costo_uni;
                    info.SubTotal = item.SubTotal;
                    info.valor_Iva = item.valor_Iva;
                    info.Total = item.Total;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;

                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.IdDepartamento = item.IdDepartamento;
                    info.IdEncargado = item.IdEncargado;

                    info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                    info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.Af_fecha_vigencia_desde = item.Af_fecha_vigencia_desde;
                    info.SubTotal = item.Subtotal_Prima;
                    info.valor_Iva = item.Iva_Prima;
                    info.Af_valor_prima = item.Prima;

                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

                }
                return info;
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


        public Boolean ModificarDB(Af_Activo_fijo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdActivoFijo == info.IdActivoFijo );
                    if (contact != null)
                    {
                        contact.CodActivoFijo = info.CodActivoFijo;
                        contact.IdTipoDepreciacion = info.IdTipoDepreciacion;
                        contact.Af_Nombre = info.Af_Nombre;
                        contact.IdActijoFijoTipo = info.IdActijoFijoTipo;
                        contact.IdCatalogo_Marca = info.IdCatalogo_Marca;
                        contact.IdCatalogo_Modelo = info.IdCatalogo_Modelo;
                        contact.Af_NumSerie = info.Af_NumSerie;
                        contact.IdCatalogo_Color = info.IdCatalogo_Color;
                        contact.Af_fecha_compra = info.Af_fecha_compra;
                        contact.Af_fecha_ini_depre = info.Af_fecha_ini_depre;
                        contact.Af_fecha_fin_depre = info.Af_fecha_fin_depre;
                        contact.Af_Costo_historico = info.Af_Costo_historico;
                        contact.Af_costo_compra = info.Af_costo_compra;
                        contact.Af_Vida_Util = info.Af_Vida_Util;
                        contact.Af_Meses_depreciar = info.Af_Meses_depreciar;
                        contact.Af_porcentaje_deprec = info.Af_porcentaje_deprec;
                        contact.Af_observacion = info.Af_observacion;
                        contact.Af_NumPlaca = info.Af_NumPlaca;
                        contact.Af_Anio_fabrica =info.Af_Anio_fabrica;
                        contact.Estado = info.Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.Af_Capacidad = info.Af_Capacidad;
                        contact.Af_foto = info.Af_foto;
                        contact.Af_DescripcionCorta = info.Af_DescripcionCorta;
                        contact.IdPeriodoDeprec = info.IdPeriodoDeprec;
                        contact.Af_Codigo_Parte = info.Af_Codigo_Parte;
                        contact.Af_Codigo_Barra = info.Af_Codigo_Barra;
                        contact.Af_DescripcionTecnica = info.Af_DescripcionTecnica;
                        contact.IdProveedor = info.IdProveedor;
                        contact.Af_FechaPoliza = info.Af_FechaPoliza;
                        contact.Af_ValorPoliza = info.Af_ValorPoliza;
                        contact.Af_ValorVenta = info.Af_ValorVenta;
                        contact.Af_NumPoliza = info.Af_NumPoliza;
                        contact.Af_Fecha_Venta = info.Af_Fecha_Venta;
                        contact.Af_Fecha_Vencimiento =info.Af_Fecha_Vencimiento;
                        contact.Af_Fecha_Retiro = info.Af_Fecha_Retiro;
                        contact.Estado_Proceso = info.Estado_Proceso;
                        contact.Af_ValorSalvamento = info.Af_ValorSalvamento;
                        contact.Af_ValorResidual = info.Af_ValorResidual;
                        contact.IdEmpresa_oc = info.IdEmpresa_oc;
                        contact.IdSucursal_oc =info.IdSucursal_oc;
                        contact.IdOrdenCompra = info.IdOrdenCompra;
                        contact.Secuencia_oc = info.Secuencia_oc;
                        contact.IdProducto = (info.IdProducto == 0) ? null : info.IdProducto;
                        contact.numDocumento = info.numDocumento;
                        contact.Cantidad = info.Cantidad;
                        contact.Costo_uni = info.Costo_uni;
                        contact.SubTotal = info.SubTotal;
                        contact.valor_Iva = info.valor_Iva;
                        contact.Total = info.Total;
                        contact.IdEmpresa_Ogiro = info.IdEmpresa_Ogiro;
                        contact.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
                        contact.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
                        contact.IdOrden_giro_Tipo = info.IdOrden_giro_Tipo;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.IdUnidadFact_cat = info.IdUnidadFact_cat;
                        contact.Af_ValorUnidad_Actu = info.Af_ValorUnidad_Actu;
                        contact.Af_NumSerie_Motor = info.Af_NumSerie_Motor;
                        contact.Af_NumSerie_Chasis = info.Af_NumSerie_Chasis;
                        contact.IdCategoriaAF = info.IdCategoriaAF;
                        contact.IdDepartamento = info.IdDepartamento;
                        contact.IdSucursal = info.IdSucursal;
                        contact.IdTipoCatalogo_Ubicacion = info.IdTipoCatalogo_Ubicacion;
                        contact.IdEncargado = info.IdEncargado;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;


                        //contact.IdCtaCble_Activo = info.IdCtaCble_Activo;
                        //contact.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                        //contact.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;


                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Activo Fijo #: " + info.IdActivoFijo.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarUbicacion(Af_CambioUbicacion_Activo_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa && obj.IdActivoFijo == Info.IdActivoFijo );
                    if (contact != null)
                    {
                        contact.IdSucursal = Info.IdSucursal_Actu==null ? contact.IdSucursal : (int)Info.IdSucursal_Actu;
                        contact.IdDepartamento = Info.IdDepartamento_Actu==null ? contact.IdDepartamento : Info.IdDepartamento_Actu;
                        contact.IdTipoCatalogo_Ubicacion = Info.IdTipoCatalogo_Ubicacion_Actu == null ? contact.IdTipoCatalogo_Ubicacion : Info.IdTipoCatalogo_Ubicacion_Actu;
                        contact.IdCentroCosto = Info.IdCentroCosto_Actu == null ? contact.IdCentroCosto : Info.IdCentroCosto_Actu;
                        contact.IdCentroCosto_sub_centro_costo = Info.IdCentroCosto_sub_centro_costo_Actu == null ? contact.IdCentroCosto_sub_centro_costo : Info.IdCentroCosto_sub_centro_costo_Actu;
                        contact.Af_ValorUnidad_Actu = Info.Af_ValorUnidad_Actu;
                        contact.IdEncargado = Info.IdEncargado_Actu;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(Af_Activo_fijo_Info info, ref int IdActivoFijo, ref string CodActivo, ref string msg)
        {
            try
            {
                try
                {
                    using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                    {
                        Af_Activo_fijo address = new Af_Activo_fijo();
                        int idpv = GetId(info.IdEmpresa);
                        IdActivoFijo = idpv;
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdActivoFijo = info.IdActivoFijo = idpv;
                        address.IdActijoFijoTipo = info.IdActijoFijoTipo;
                        address.IdSucursal = info.IdSucursal;
                        address.IdDepartamento = info.IdDepartamento;
                        address.CodActivoFijo = CodActivo = info.CodActivoFijo == "" || info.CodActivoFijo == null ? info.IdActivoFijo.ToString() : info.CodActivoFijo.Trim();
                        address.Af_Nombre = info.Af_Nombre;
                        address.IdCatalogo_Marca = info.IdCatalogo_Marca;
                        address.IdCatalogo_Modelo = info.IdCatalogo_Modelo;
                        address.Af_NumSerie = info.Af_NumSerie;
                        address.IdCatalogo_Color = info.IdCatalogo_Color;
                        address.IdTipoCatalogo_Ubicacion = info.IdTipoCatalogo_Ubicacion;
                        address.Af_fecha_compra = info.Af_fecha_compra.Date;
                        address.Af_fecha_ini_depre = info.Af_fecha_ini_depre.Date;
                        address.Af_fecha_fin_depre = info.Af_fecha_fin_depre.Date;
                        address.Af_Costo_historico = info.Af_Costo_historico;
                        address.Af_costo_compra = info.Af_costo_compra;
                        address.Af_Vida_Util = info.Af_Vida_Util;
                        address.Af_Meses_depreciar = info.Af_Meses_depreciar;
                        address.Af_porcentaje_deprec = info.Af_porcentaje_deprec;
                        address.Af_observacion = (info.Af_observacion == null) ? "" : info.Af_observacion;
                        
                        address.Af_NumPlaca = info.Af_NumPlaca;
                        address.Af_Anio_fabrica = info.Af_Anio_fabrica;
                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transac = DateTime.Now;
                        address.Estado = "A";
                        address.IdTipoDepreciacion = info.IdTipoDepreciacion;
                        address.Af_foto = info.Af_foto;
                        address.Af_DescripcionCorta = info.Af_DescripcionCorta;
                        address.IdPeriodoDeprec = info.IdPeriodoDeprec;
                        address.Af_Codigo_Parte = info.Af_Codigo_Parte;
                        address.Af_Codigo_Barra = (info.Af_Codigo_Barra == "" || info.Af_Codigo_Barra == null) ? CodActivo : info.Af_Codigo_Barra;

                        address.Af_DescripcionTecnica = info.Af_DescripcionTecnica;
                        address.IdProveedor = info.IdProveedor;
                        address.Af_FechaPoliza = info.Af_FechaPoliza == null ? info.Af_FechaPoliza : Convert.ToDateTime(info.Af_FechaPoliza).Date;
                        address.Af_ValorPoliza = info.Af_ValorPoliza;
                        address.Af_ValorVenta = info.Af_ValorVenta;
                        address.Af_NumPoliza = info.Af_NumPoliza;
                        address.Af_Fecha_Venta = info.Af_Fecha_Venta == null ? info.Af_Fecha_Venta : Convert.ToDateTime(info.Af_Fecha_Venta).Date;
                        address.Af_Fecha_Vencimiento = info.Af_Fecha_Vencimiento == null ? info.Af_Fecha_Vencimiento : Convert.ToDateTime(info.Af_Fecha_Vencimiento).Date;
                        address.Af_Fecha_Retiro = info.Af_Fecha_Retiro == null ? info.Af_Fecha_Retiro : Convert.ToDateTime(info.Af_Fecha_Retiro).Date; ;
                        address.Estado_Proceso = info.Estado_Proceso;
                        address.Af_ValorSalvamento = info.Af_ValorSalvamento;
                        address.Af_ValorResidual = info.Af_ValorResidual;

                        address.IdEmpresa_oc = info.IdEmpresa_oc;
                        address.IdSucursal_oc = info.IdSucursal_oc;
                        address.IdOrdenCompra = info.IdOrdenCompra;
                        address.Secuencia_oc = info.Secuencia_oc;
                        address.IdProducto = info.IdProducto == 0 ? null : info.IdProducto;
                        address.numDocumento = info.numDocumento;
                        address.Cantidad = info.Cantidad;
                        address.Costo_uni = info.Costo_uni;
                        address.SubTotal = info.SubTotal;
                        address.valor_Iva = info.valor_Iva;
                        address.Total = info.Total;
                        address.IdEmpresa_Ogiro = info.IdEmpresa_Ogiro;
                        address.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
                        address.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
                        address.IdOrden_giro_Tipo = info.IdOrden_giro_Tipo;
                        address.Af_Capacidad = info.Af_Capacidad;
                        address.Af_NumSerie_Motor = info.Af_NumSerie_Motor;
                        address.Af_NumSerie_Chasis = info.Af_NumSerie_Chasis;
                        address.IdCategoriaAF = info.IdCategoriaAF;
                        address.Es_carroceria = info.Es_carroceria;
                       
                        address.IdDepartamento = info.IdDepartamento;
                        address.IdEncargado = info.IdEncargado;
                        
                        address.IdUnidadFact_cat = info.IdUnidadFact_cat;
                        address.Af_ValorUnidad_Actu = info.Af_ValorUnidad_Actu;
                        address.IdCentroCosto = info.IdCentroCosto;
                        address.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        address.Af_fecha_vigencia_desde = info.Af_fecha_vigencia_desde;
                        info.SubTotal = info.SubTotal;
                        info.valor_Iva = info.valor_Iva;
                        info.Af_valor_prima = info.Af_valor_prima;
                        address.Af_Depreciacion_acum = info.Af_Depreciacion_acum;


                        //address.IdCtaCble_Activo = info.IdCtaCble_Activo;
                        //address.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                        //address.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;


                        context.Af_Activo_fijo.Add(address);

                        context.SaveChanges();
                        msg = "Se ha procedido a grabar el registro del Activo Fijo #: " + IdActivoFijo.ToString() + " Exitosamente.";
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                 

                    

                    
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = mensaje +" Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                            
                        }
                    }


                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", "Af_Activo_fijo_Data", "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        private string GetCodigoActivo(int IdEmpresa, int IdSucursal, int IdActijoFijoTipo )
        {
            try
            {
                String Codigo = "";
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Activo_fijo
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                             && q.IdActijoFijoTipo == IdActijoFijoTipo
                             select q;

                if (select.ToList().Count == 0)
                {
                    Codigo = "00001";
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.Af_Activo_fijo
                                     where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                     && q.IdActijoFijoTipo == IdActijoFijoTipo
                                     select q.CodActivoFijo.Substring(q.CodActivoFijo.Length - 5,5)).Max();

                    Codigo = select_pv.ToString();                       
                    Codigo = (Convert.ToInt32(Codigo.Substring(Codigo.Length - 5,5)) + 1).ToString().PadLeft(5, '0');                 
                }
                return Codigo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(Af_Activo_fijo_Info info, ref  string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdActivoFijo == info.IdActivoFijo && obj.IdActijoFijoTipo == info.IdActijoFijoTipo);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro del Activo Fijo #: " + info.IdActivoFijo.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarEstadoProceso(int IdEmpresa, int IdActivoFijo ,string EstadoProceso)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == IdEmpresa && obj.IdActivoFijo == IdActivoFijo);
                    if (contact != null)
                    {
                        contact.Estado_Proceso = EstadoProceso;
                        context.SaveChanges();
                    }
                }
                return true;
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

        public int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Activo_fijo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.Af_Activo_fijo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdActivoFijo).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
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

        public Af_Activo_fijo_Data()
        {
          
        }

      
        public List<Af_Activo_fijo_Info> Get_List_Vista_Af(int idEmpresa)
        {
            try
            {
                List<Af_Activo_fijo_Info> Lista = new List<Af_Activo_fijo_Info>();

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var lst = from q in Context.vwAf_Activo_fijo
                              where q.IdEmpresa == idEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;                        
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.nom_encargado = item.nom_encargado;
                        info.CodActivoFijo = item.CodActivoFijo;
                        info.nom_Color = item.nom_Color;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.Marca = item.Marca;
                        info.Af_Capacidad = item.Af_Capacidad;
                        info.Modelo = item.Modelo;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.nom_Categoria = item.nom_Categoria;
                        info.Es_carroceria = item.Es_carroceria;

                        //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                        //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                        //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

                        Lista.Add(info);
                    }
                }

                return Lista;
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

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria(int idEmpresa,int idCategoria)
        {
            try
            {
                List<Af_Activo_fijo_Info> Lista = new List<Af_Activo_fijo_Info>();

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var lst = from q in Context.vwAf_Activo_fijo
                              where q.IdEmpresa == idEmpresa
                              && q.IdCategoriaAF == idCategoria
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.nom_encargado = item.nom_encargado;
                        info.nom_Color = item.nom_Color;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.nom_Categoria = item.nom_Categoria;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Af_Capacidad = item.Af_Capacidad;
                        info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        info.Af_Costo_historico = item.Af_Costo_historico;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                        info.Af_Vida_Util = item.Af_Vida_Util;
                        info.Af_Meses_depreciar = item.Af_Meses_depreciar;                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.Es_carroceria = item.Es_carroceria;

                        //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                        //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                        //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;


                        Lista.Add(info);
                    }
                }

                return Lista;
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

        public Boolean Grabar_Poliza_x_Activo(Af_Poliza_x_AF_Info info)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    foreach (var item in info.lst_Det)
                    {
                        Af_Activo_fijo Entity = Context.Af_Activo_fijo.FirstOrDefault(q=>q.IdEmpresa == item.IdEmpresa && q.IdActivoFijo == item.IdActivoFijo);
                        if (Entity != null)
                        {
                            Entity.Af_FechaPoliza = info.fecha;
                            Entity.Af_fecha_vigencia_desde = info.fecha_vigencia_desde;
                            Entity.Af_Fecha_Vencimiento = info.fecha_vigencia_hasta;
                            Entity.Af_ValorPoliza = info.Total;
                            Entity.Subtotal_Prima = item.Subtotal_12;//opin
                            Entity.Iva_Prima = item.Iva;
                            Entity.Prima = item.Prima;
                            Context.SaveChanges();
                        }    
                    }
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

        public bool Actualizar_Unidades(List<fa_registro_unidades_x_equipo_det_Info> Lista)
        {
            try
            {
                var agrupacion = from p in Lista                                 
                                 group p by new { p.IdActivoFijo,p.IdEmpresa } into grupo
                                 select grupo;

                List<fa_registro_unidades_x_equipo_det_Info> Lista_agrupada=new List<fa_registro_unidades_x_equipo_det_Info>();

                foreach (var item in agrupacion)
                {
                    fa_registro_unidades_x_equipo_det_Info info = new fa_registro_unidades_x_equipo_det_Info();
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdActivoFijo = item.Key.IdActivoFijo;
                    info.Valor = Lista.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdActivoFijo == info.IdActivoFijo).Max(q => q.Valor);
                    Lista_agrupada.Add(info);
                }

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    foreach (var item in Lista_agrupada)
                    {
                        Af_Activo_fijo Entity = Context.Af_Activo_fijo.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdActivoFijo == item.IdActivoFijo);

                        if (Entity!=null)
                        {
                            Entity.Af_ValorUnidad_Actu = item.Valor;
                            Context.SaveChanges();
                        }
                    }
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

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo_x_Tipo(int IdEmpresa, int IdTipo)
        {
            List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && IdTipo == A.IdActijoFijoTipo
                             
                             select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = (item.Af_Nombre==null)?"": item.Af_Nombre.Trim();
                    info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = (item.Af_NumSerie == null) ? "" : item.Af_NumSerie.Trim(); 
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_Capacidad = item.Af_Capacidad;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = (item.Af_observacion == null) ? "" : item.Af_observacion.Trim();
                    info.Af_NumPlaca = (item.Af_NumPlaca == null) ? "" : item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.IdPeriodoDeprec = item.IdPeriodoDeprec;
                    info.Af_Codigo_Parte = item.Af_Codigo_Parte;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.Es_carroceria = item.Es_carroceria;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.IdProveedor = item.IdProveedor;
                    info.Af_FechaPoliza = item.Af_FechaPoliza;
                    info.Af_ValorPoliza = item.Af_ValorPoliza;
                    info.Af_ValorVenta = item.Af_ValorVenta;
                    info.Af_NumPoliza = item.Af_NumPoliza;
                    info.Af_Fecha_Venta = item.Af_Fecha_Venta;
                    info.Af_Fecha_Vencimiento = item.Af_Fecha_Vencimiento;
                    info.Af_Fecha_Retiro = item.Af_Fecha_Retiro;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;

                    info.IdEmpresa_oc = item.IdEmpresa_oc;
                    info.IdSucursal_oc = item.IdSucursal_oc;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.Secuencia_oc;
                    info.IdProducto = item.IdProducto;
                    info.numDocumento = item.numDocumento;
                    info.Cantidad = item.Cantidad;
                    info.Costo_uni = item.Costo_uni;
                    info.SubTotal = item.SubTotal;
                    info.valor_Iva = item.valor_Iva;
                    info.Total = item.Total;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;

                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;

                    info.IdDepartamento = item.IdDepartamento;
                    info.IdEncargado = item.IdEncargado;
                    info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                    info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.Af_fecha_vigencia_desde = item.Af_fecha_vigencia_desde;
                    info.SubTotal = item.Subtotal_Prima;
                    info.valor_Iva = item.Iva_Prima;
                    info.Af_valor_prima = item.Prima;


                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;


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

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria_x_tarifario(int idEmpresa, int idCategoria, decimal IdTarifario)
        {
            try
            {
                List<Af_Activo_fijo_Info> Lista = new List<Af_Activo_fijo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_x_Tarifario
                              where q.IdEmpresa == idEmpresa
                              && q.IdTarifario == IdTarifario
                              && q.IdCategoriaAF == idCategoria
                              select q;

                    var lst_disponibles = from q in Context.vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_disponibles
                                          where q.IdEmpresa == idEmpresa
                                          && q.IdCategoriaAF == idCategoria
                                          select q;
                    
                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.nom_encargado = item.nom_encargado;
                        info.nom_Color = item.nom_Color;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.nom_Categoria = item.nom_Categoria;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Es_carroceria = item.Es_carroceria;
                        info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        info.Af_Costo_historico = item.Af_Costo_historico;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                        info.Af_Vida_Util = item.Af_Vida_Util;
                        info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        info.IdEmpresa = item.IdEmpresa;
                        info.Seleccionado = true;
                        if(item.Num_empleado_relacionado!=null)
                        info.Num_empleado_relacionado = item.Num_empleado_relacionado;
                        Lista.Add(info);
                    }                    

                    foreach (var item in lst_disponibles)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.nom_encargado = item.nom_encargado;
                        info.nom_Color = item.nom_Color;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.nom_Categoria = item.nom_Categoria;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Es_carroceria = item.Es_carroceria;
                        info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        info.Af_Costo_historico = item.Af_Costo_historico;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                        info.Af_Vida_Util = item.Af_Vida_Util;
                        info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        info.IdEmpresa = item.IdEmpresa;
                        info.Seleccionado = false;
                        Lista.Add(info);
                    }
                }
                
                return Lista;
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

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria_disponibles(int idEmpresa, int idCategoria)
        {
            try
            {
                List<Af_Activo_fijo_Info> Lista = new List<Af_Activo_fijo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_disponibles
                              where q.IdEmpresa == idEmpresa
                              && q.IdCategoriaAF == idCategoria
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.nom_encargado = item.nom_encargado;
                        info.nom_Color = item.nom_Color;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.nom_Categoria = item.nom_Categoria;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Es_carroceria = item.Es_carroceria;
                        info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        info.Af_Costo_historico = item.Af_Costo_historico;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                        info.Af_Vida_Util = item.Af_Vida_Util;
                        info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        info.IdEmpresa = item.IdEmpresa;
                        info.Seleccionado = false;
                        Lista.Add(info);
                    }
                }
               return Lista;
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

        public bool EliminarDB_Todos(int idEmpresa, ref string mensaje)
        {
            try
            {
                EntitiesActivoFijo OEAf_ActivoFijo = new EntitiesActivoFijo();
                OEAf_ActivoFijo.Database.ExecuteSqlCommand("delete Af_Activo_fijo where IdEmpresa = " + idEmpresa);

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

       

    }
}
