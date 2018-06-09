using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ObtenerReporte_Data
    {

        string mensaje = "";
    //    public List<tbPRD_Rpt_RPRD001_Info>  OptenerData_spPRD_Rpt_RPRD001(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, string IdUsuario, string nom_pc)
    //    {
    //        try
    //        {
    //            List<tbPRD_Rpt_RPRD001_Info> ListData = new List<tbPRD_Rpt_RPRD001_Info>();

    //            using (EntitiesProduccion_Cidersus  base_ = new EntitiesProduccion_Cidersus())
    //            {
    //               var q= from C in base_.Vwin_Imprimir_Cod_Barra
    //                      where C.IdEmpresa == IdEmpresa
    //                      && C.IdSucursal==IdSucursal
    //                      && C.IdBodega==IdBodega
    //                      && C.IdMovi_inven_tipo == IdMovi_inven_tipo
    //                      && C.IdNumMovi==IdNumMovi
    //                      select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRD_Rpt_RPRD001_Info info= new tbPRD_Rpt_RPRD001_Info();
    //                    info.CodigoBarra = item.CodigoBarra;
    //                    info.pr_descripcion = item.pr_descripcion;
                       
    //                    ListData.Add(info);
    //                }
    //            }
    //            return ListData;
    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

     
    //    public List<tbPRO_CUS_CID_Rpt003_Info> OptenerData_spPRD_Rpt_RPRD003(int IdEmpresa,int Idsucursal, decimal IdListadoMateriales)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt003_Info> ListData = new List<tbPRO_CUS_CID_Rpt003_Info>();


    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {
    //                var q = from C in base_.vwcom_ListadoMateriales_Detalle_SaldosReporte
    //                        where C.IdEmpresa == IdEmpresa 
    //                        && C.IdListadoMateriales == IdListadoMateriales 
    //                        && C.IdSucursal==Idsucursal
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt003_Info info = new tbPRO_CUS_CID_Rpt003_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.CodObra = item.CodObra;                      
    //                    info.Fecha_Transac = item.FechaReg;
    //                    info.IdListadoMateriales = item.IdListadoMateriales;
    //                    info.FechaReg = item.FechaReg;
    //                    info.Su_Descripcion = item.Su_Descripcion;
    //                    info.ot_descripcion = item.Observacion;
    //                    info.ob_descripcion = item.Descripcion;
    //                    info.lm_Observacion = item.lm_Observacion;
    //                    info.pr_codigo = item.pr_codigo;
    //                    info.pr_descripcion = item.pr_descripcion;
    //                    info.Unidades = item.Unidades;
    //                    info.IdEstadoAprob = item.IdEstadoAprob;

    //                    ListData.Add(info);
    //                }
    //            }

    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<tbPRO_CUS_CID_Rpt004_Info> OptenerData_spPRD_Rpt_RPRD004(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, string IdUsuario, string nom_pc)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt004_Info> ListData = new List<tbPRO_CUS_CID_Rpt004_Info>();


    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {
    //                base_.spPRO_CUS_CID_Rpt004(IdEmpresa, IdSucursal, IdOrdenCompra, IdUsuario, nom_pc);
    //                var q = from C in base_.tbPRO_CUS_CID_Rpt004
    //                        where C.IdUsuario == IdUsuario && C.nom_pc == nom_pc
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt004_Info info = new tbPRO_CUS_CID_Rpt004_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.IdUsuario = item.IdUsuario;
    //                    info.Fecha_Transac = item.Fecha_Transac;
    //                    info.nom_pc = item.nom_pc;
    //                    info.IdSucursal = item.IdSucursal;
    //                    info.IdOrdenCompra = item.IdOrdenCompra;
    //                    info.valorunitario = item.valorunitario;
    //                    info.valortotal = item.valortotal;
    //                    info.ivaxreg = item.ivaxreg;
    //                    info.oc_fecha = Convert.ToDateTime(item.oc_fecha);
    //                    info.fecha = info.oc_fecha.ToShortDateString();
    //                    info.pr_nombre = item.pr_nombre;
    //                    info.Solicitante = item.Solicitante;
    //                    info.pr_descripcion = item.pr_descripcion;
    //                    info.IdUnidadMedida = item.IdUnidadMedida;
    //                    info.pesoxreg = item.pesoxreg;
    //                    info.pr_peso = item.pr_peso;
    //                    info.IdProducto = item.IdProducto;
    //                    info.Secuencia = item.Secuencia;
    //                    info.cantidad = item.cantidad;


    //                    ListData.Add(info);
    //                }

    //            }

    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<tbPRO_CUS_CID_Rpt005_Info> OptenerData_spPRD_Rpt_RPRD005(int IdEmpresa, int IdSucursal,decimal IdDespacho)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt005_Info> ListData = new List<tbPRO_CUS_CID_Rpt005_Info>();

    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {
    //               // base_.spPRO_CUS_CID_Rpt005(IdEmpresa,IdSucursal,IdDespacho, IdUsuario, nom_pc);
    //                var q = from C in base_.vwin_DespachoMateriales
    //                        where C.IdEmpresa == IdEmpresa
    //                        && C.IdSucursal == IdSucursal
    //                        && C.IdDespacho == IdDespacho
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt005_Info info = new tbPRO_CUS_CID_Rpt005_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.IdUsuario = item.IdUsuario;
    //                    info.Fecha_Transac = Convert.ToDateTime(item.FechaFinTras);
    //                    info.cliente = item.pe_nombreCompleto;
    //                    info.pe_cedulaRuc = item.pe_cedulaRuc;
    //                    info.FechaReg =Convert.ToDateTime(item.FechaReg);
    //                    info.FechaIniTras = Convert.ToDateTime(item.FechaIniTras);
    //                    info.FechaFinTras =Convert.ToDateTime( item.FechaFinTras);
    //                    info.IdDespacho = item.IdDespacho;
    //                    info.PuntoLLegada = item.PuntoLLegada;
    //                    info.PuntoPartida = item.PuntoPartida;
    //                    info.Placa = item.Placa;
    //                    info.Chofer = item.Chofer;
    //                    info.TipoTransporte = item.TipoTransporte;
    //                    info.producto = item.pr_descripcion;
    //                    info.CodigoBarraMaestro = item.CodigoBarra;
    //                    info.cantidad = item.Cantidad;
    //                    info.peso =Convert.ToDecimal( item.peso);
    //                  //  info.pesoxprod = (item.pesoxcant > 0) ? Convert.ToString(item.pesoxcant) + " Kg.": "";
    //                    info.fechaemision = info.FechaReg.ToShortDateString();
    //                    info.fechainicio = info.FechaIniTras.ToShortDateString();
    //                    info.fechafin = info.FechaFinTras.ToShortDateString();
    //                    info.peso = Convert.ToDecimal(item.peso);
    //                    info.precio = Convert.ToDecimal(item.precio);
    //                    info.det_observacion = item.Observacion;
    //                    info.obra = item.Descripcion;
    //                    info.NumDespacho = item.NumDespacho;
    //                    info.NumFactura = item.NumFactura;
    //                    info.NumGuia = item.NumGuiaRemision;
    //                    info.Su_Descripcion = item.Su_Descripcion;
    //                    ListData.Add(info);
    //                }
    //            }

    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<tbPRO_CUS_CID_Rpt006_Info> OptenerData_spPRD_Rpt_RPRD006(int IdEmpresa, int IdSucursal, int IdBodega,
    //        int IdTipoMov, decimal IdNumMovi, string IdUsuario, string nom_pc)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt006_Info> ListData = new List<tbPRO_CUS_CID_Rpt006_Info>();


    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {
    //                base_.spPRO_CUS_CID_Rpt006(IdEmpresa, IdUsuario, nom_pc, IdSucursal, IdBodega, IdTipoMov, IdNumMovi);

    //                var q = from C in base_.tbPRO_CUS_CID_Rpt006
    //                        where C.IdUsuario == IdUsuario && C.nom_pc == nom_pc
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt006_Info info = new tbPRO_CUS_CID_Rpt006_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.IdUsuario = item.IdUsuario;
    //                    info.Fecha_Transac = item.Fecha_Transac;
    //                    info.nom_pc = item.nom_pc;
    //                    info.CodigoBarra = item.CodigoBarra;
    //                    info.dm_observacion = item.dm_observacion;
    //                    info.IdSucursal = item.IdSucursal;
    //                    info.IdBodega = item.IdBodega;
    //                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
    //                    info.IdNumMovi = item.IdNumMovi;
    //                    info.Secuencia = item.Secuencia;
    //                    info.cb_secuencia = item.cb_secuencia;
    //                    info.IdProducto = item.IdProducto;
    //                    info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
    //                    info.fecha = info.cm_fecha.ToShortDateString();
    //                    info.dm_cantidad = item.dm_cantidad;
    //                    info.cm_observacion = item.cm_observacion;
    //                    info.Su_Descripcion = item.Su_Descripcion;
    //                    info.bo_Descripcion = item.bo_Descripcion;
    //                    info.tm_descripcion = item.tm_descripcion;
    //                    info.pr_descripcion = item.pr_descripcion;


    //                    ListData.Add(info);
    //                }
    //            }

    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }



    //    public List<tbPRO_CUS_CID_Rpt007_Info> ImprimirReporte(int IdEmpresa, int IdSucursal, int IdBodega,int IdTipoMov, decimal IdNumMovi, string IdUsuario, string nom_pc)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt007_Info> ListData = new List<tbPRO_CUS_CID_Rpt007_Info>();
    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {

    //                var q = from C in base_.vwin_prd_EgresoInventario_x_Produccion
    //                        where C.IdEmpresa == IdEmpresa 
    //                        && C.IdSucursal == IdSucursal
    //                        && C.IdMovi_inven_tipo==IdTipoMov
    //                        && C.IdNumMovi == IdNumMovi
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt007_Info info = new tbPRO_CUS_CID_Rpt007_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.Fecha_Transac = item.cm_fecha;
    //                    info.dm_observacion = item.dm_observacion;
    //                    info.IdSucursal = item.IdSucursal;
    //                    info.IdBodega = item.IdBodega;
    //                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
    //                    info.IdNumMovi = item.IdNumMovi;
    //                    info.Secuencia = item.Secuencia;
    //                    info.IdProducto = item.IdProducto;
    //                    info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
    //                    info.dm_cantidad = item.dm_cantidad;
    //                    info.cm_observacion = item.cm_observacion;
    //                    info.Su_Descripcion = item.Su_Descripcion;
    //                    info.bo_Descripcion = item.bo_Descripcion;
    //                    info.pr_descripcion = item.pr_descripcion;
    //                    info.CodigoBarra = item.CodigoBarra;
    //                    info.SuEgr_Descripcion = item.Su_Descripcion;
    //                    info.boEgr_Descripcion = item.bo_Descripcion;
    //                    info.tmEgr_descripcion = item.cm_observacion;
    //                    info.fecha = info.cm_fecha.ToShortDateString();
    //                    info.IdNumMoviEg = IdNumMovi;                        
    //                    ListData.Add(info);
    //                }
    //            }



    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<tbPRO_CUS_CID_Rpt008_Info> OptenerData_spPRD_Rpt_RPRD008(int IdEmpresa, int IdSucursal, int IdBodega,
    //  int IdTipoMov, decimal IdNumMovi, string IdUsuario, string nom_pc)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt008_Info> ListData = new List<tbPRO_CUS_CID_Rpt008_Info>();


    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {
    //                base_.spPRO_CUS_CID_Rpt008(IdEmpresa, IdUsuario, nom_pc, IdSucursal, IdBodega, IdTipoMov, IdNumMovi);

    //                var q = from C in base_.tbPRO_CUS_CID_Rpt008
    //                        where C.IdUsuario == IdUsuario && C.nom_pc == nom_pc
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt008_Info info = new tbPRO_CUS_CID_Rpt008_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.IdUsuario = item.IdUsuario;
    //                    info.Fecha_Transac = item.Fecha_Transac;
    //                    info.nom_pc = item.nom_pc;
    //                    info.CodigoBarra = item.CodigoBarra;
    //                    info.dm_observacion = item.dm_observacion;
    //                    info.IdSucursal = item.IdSucursal;
    //                    info.IdBodega = item.IdBodega;
    //                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
    //                    info.IdNumMovi = item.IdNumMovi;
    //                    info.Secuencia = item.Secuencia;
    //                    info.cb_secuencia = item.cb_secuencia;
    //                    info.IdProducto = item.IdProducto;
    //                    info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
    //                    info.dm_cantidad = item.dm_cantidad;
    //                    info.cm_observacion = item.cm_observacion;
    //                    info.Su_Descripcion = item.Su_Descripcion;
    //                    info.bo_Descripcion = item.bo_Descripcion;
    //                    info.tm_descripcion = item.tm_descripcion;
    //                    info.pr_descripcion = item.pr_descripcion;
    //                    info.Id = item.Id;
    //                    info.pr_nombre = item.pr_nombre;
    //                    info.NumDocumentoRelacionado = item.NumDocumentoRelacionado;
    //                    info.NumFactura = item.NumFactura;
    //                    info.oc_NumDocumento = item.oc_NumDocumento;
    //                    info.IdOrdenCompra = item.IdOrdenCompra;
    //                    info.oc_fecha = Convert.ToDateTime(item.oc_fecha);
    //                    info.oc_observacion = item.oc_observacion;
    //                    info.ocdet_cantidad = item.ocdet_cantidad;
    //                    info.fecha_oc = info.oc_fecha.ToShortDateString();

    //                    ListData.Add(info);
    //                }

    //            }

    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }


    //    public List<tbPRO_CUS_CID_Rpt009_Info> OptenerData_spPRD_Rpt_RPRD009(int IdEmpresa, int IdSucursal, decimal IdGrupoTrabajo,
    // string IdUsuario, string nom_pc)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt009_Info> ListData = new List<tbPRO_CUS_CID_Rpt009_Info>();


    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {
    //                base_.spPRO_CUS_CID_Rpt009(IdEmpresa, IdSucursal, IdGrupoTrabajo, IdUsuario, nom_pc);

    //                var q = from C in base_.tbPRO_CUS_CID_Rpt009
    //                        where C.IdUsuario == IdUsuario && C.nom_pc == nom_pc
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt009_Info info = new tbPRO_CUS_CID_Rpt009_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.IdUsuario = item.IdUsuario;
    //                    info.Fecha_Transac = item.Fecha_Transac;
    //                    info.nom_pc = item.nom_pc;
    //                    info.IdSucursal = item.IdSucursal;
    //                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
    //                    info.CodObra = item.CodObra;
    //                    info.IdLider = item.IdLider;
    //                    info.IdOrdenTaller = item.IdOrdenTaller;
    //                    info.Su_Descripcion = item.Su_Descripcion;
    //                    info.ob_descripcion = item.ob_descripcion;
    //                    info.ot_descripcion = item.ot_descripcion;
    //                    info.gt_Descripcion = item.gt_Descripcion;
    //                    info.et_descripcion = item.et_descripcion;
    //                    info.mp_descripcion = item.mp_descripcion;
    //                    info.pe_nombreCompleto = item.pe_nombreCompleto;
    //                    info.Observacion = item.Observacion;
    //                    info.lider = item.lider;


    //                    ListData.Add(info);
    //                }

    //            }

    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

    //    public List<tbPRO_CUS_CID_Rpt010_Info> OptenerData_spPRD_Rpt_RPRD010(int IdEmpresa, int IdProcesoProductivo, 
    //string IdUsuario, string nom_pc)
    //    {

    //        try
    //        {
    //            List<tbPRO_CUS_CID_Rpt010_Info> ListData = new List<tbPRO_CUS_CID_Rpt010_Info>();


    //            using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
    //            {
    //                base_.spPRO_CUS_CID_Rpt010(IdEmpresa, IdUsuario, nom_pc, IdProcesoProductivo);

    //                var q = from C in base_.tbPRO_CUS_CID_Rpt010
    //                        where C.IdUsuario == IdUsuario && C.nom_pc == nom_pc
    //                        select C;

    //                foreach (var item in q)
    //                {
    //                    tbPRO_CUS_CID_Rpt010_Info info = new tbPRO_CUS_CID_Rpt010_Info();
    //                    info.IdEmpresa = item.IdEmpresa;
    //                    info.IdUsuario = item.IdUsuario;
    //                    info.Fecha_Transac = item.Fecha_Transac;
    //                    info.nom_pc = item.nom_pc;
    //                    info.IdProcesoProductivo = item.IdProcesoProductivo;
    //                    info.ProcProd = item.ProcProd;
    //                    info.CodObra = item.CodObra;
    //                    info.obra = item.obra;
    //                    info.IdEtapa = item.IdEtapa;
    //                    info.NombreEtapa = item.NombreEtapa;
    //                    info.PorcentajeEtapa = item.PorcentajeEtapa;



    //                    ListData.Add(info);
    //                }

    //            }

    //            return ListData;

    //        }
    //        catch (Exception ex)
    //        {
    //            string arreglo = ToString();
    //            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
    //            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
    //            mensaje = ex.ToString() + " " + ex.Message;
    //            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
    //            throw new Exception(ex.ToString());
    //        }
    //    }

      
    
    }
}
