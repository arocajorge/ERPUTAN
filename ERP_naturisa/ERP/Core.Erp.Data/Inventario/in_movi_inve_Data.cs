using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;

namespace Core.Erp.Data.Inventario
{
    
    public class in_movi_inve_Data
    {
        string mensaje = "";
        public in_movi_inve_Data() { }

        prd_parametros_CusCidersus_Data dataParam = new prd_parametros_CusCidersus_Data();
        prd_parametros_CusCidersus_Info paramCUS = new prd_parametros_CusCidersus_Info();

        public List<in_movi_inve_Info> Get_list_Movi_inven
            (int idcompany,int idSucursalIni ,int idSucursalFin ,int IdBodegaIni,int IdBodegaFin,
            int TipoMoviIni, int TipoMoviFin, DateTime FechaIni, DateTime FechaFin ,string Signo_Ing_Egre="")
        {
                try
                {
                    List<in_movi_inve_Info> lM = new List<in_movi_inve_Info>();
                    FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                    FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                    if (TipoMoviIni == 0)
                    {
                        TipoMoviFin = 5000;
                        TipoMoviIni = 0;
                    }
                    else
                    {
                        TipoMoviFin = TipoMoviIni;
                    }


                    if (idSucursalIni == 0)
                    {
                        idSucursalFin = 5000;
                        idSucursalIni = 0;
                    }
                    else
                    {
                        idSucursalFin=idSucursalIni;
                    }


                    if (IdBodegaIni == 0)
                    {
                        IdBodegaFin = 5000;
                        IdBodegaIni = 0;
                    }
                    else
                    {
                        IdBodegaFin = IdBodegaIni;
                    }
                    EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                    var selectCbtecble = from C in OECbtecble_Info.vwin_movi_inve
                                         where C.IdEmpresa == idcompany
                                         && C.IdSucursal >= idSucursalIni && C.IdSucursal <= idSucursalFin
                                         && C.IdBodega >=IdBodegaIni && C.IdBodega<=IdBodegaFin
                                         && C.IdMovi_inven_tipo>=TipoMoviIni && C.IdMovi_inven_tipo<=TipoMoviFin
                                         && C.cm_fecha>= FechaIni && C.cm_fecha<=FechaFin
                                         && C.cm_tipo.Contains(Signo_Ing_Egre)
                                         select C;
                    
                    foreach (var item in selectCbtecble)
                    {
                        in_movi_inve_Info moviI = new in_movi_inve_Info();

                        moviI.cm_anio = item.cm_anio;
                        moviI.cm_fecha = item.cm_fecha;
                        moviI.cm_mes = item.cm_mes;
                        moviI.cm_observacion = item.cm_observacion;
                        moviI.cm_tipo = item.cm_tipo;
                        moviI.Estado = item.Estado;
                        moviI.Fecha_Transac = item.Fecha_Transac;
                        moviI.Fecha_UltAnu = item.Fecha_UltAnu;
                        moviI.Fecha_UltMod = item.Fecha_UltMod;
                        moviI.IdBodega = item.IdBodega;
                        moviI.IdCbteCble = item.IdCbteCble;
                        moviI.IdCbteCble_Tipo = item.IdCbteCble_Tipo;
                        moviI.IdCtaCble = item.IdCtaCble;
                        moviI.IdEmpresa = item.IdEmpresa;
                        moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        moviI.IdNumMovi = item.IdNumMovi;
                        moviI.IdSucursal = item.IdSucursal;
                        moviI.IdUsuario = item.IdUsuario;
                        moviI.IdusuarioUltAnu = item.IdusuarioUltAnu;
                        moviI.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        moviI.ip = item.ip;
                        moviI.nom_pc = item.nom_pc;
                        moviI.NomBodega = item.NomBodega;
                        moviI.NomSucursal = item.NomSucursal;
                        moviI.NomTipoMovi = item.NomTipoMovi;
                        moviI.CodTipoMovi = item.CodTipoMovi;
                        moviI.NemoTipoMovi = item.NemoTipoMovi;
                        moviI.IdCentroCosto = item.IdCentroCosto;
                        moviI.CodMoviInven = item.CodMoviInven ;
                        moviI.CodNomTipoMovi = "[" + item.IdMovi_inven_tipo + "] - " + item.NomTipoMovi;
                        moviI.ReferenciaOC = String.Format("{0} - {1} - {2}", 
                            (item.CodCentroCosto!=null)?item.CodCentroCosto.Trim():"",
                            (item.Centro_costo!=null)?item.Centro_costo.Trim():"", 
                            item.cm_observacion.Trim());

                        moviI.IdEmpresa_x_Anu = item.IdEmpresa_x_Anu;
                        moviI.IdSucursal_x_Anu = item.IdSucursal_x_Anu;
                        moviI.IdBodega_x_Anu = item.IdBodega_x_Anu;
                        moviI.IdMovi_inven_tipo_x_Anu = item.IdMovi_inven_tipo_x_Anu;
                        moviI.IdNumMovi_x_Anu = item.IdNumMovi_x_Anu;
                        moviI.MotivoAnulacion = item.MotivoAnulacion;

                        lM.Add(moviI);
                    }

                    
                    return (lM);
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

        public List<in_movi_inve_Info> Get_list_Movi_inven_x_despachar(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                int IdSucursalIni = IdSucursal;
                int IdSucursalFin = IdSucursal==0 ? 99999 : IdSucursal;

                int IdBodegaIni = IdBodega;
                int IdBodegaFin = IdBodega == 0 ? 99999 : IdBodega;

                List<in_movi_inve_Info> Lista = new List<in_movi_inve_Info>();

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_movi_inve_x_despachar
                              where q.IdEmpresa == IdEmpresa 
                              && IdSucursalIni<= q.IdSucursal && q.IdSucursal <=IdSucursalFin
                              && IdBodegaIni<= q.IdBodega && q.IdBodega <= IdBodegaFin
                              select q;

                    foreach (var item in lst)
                    {
                        in_movi_inve_Info info = new in_movi_inve_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.cm_tipo = item.signo;
                        info.CodMoviInven = item.CodMoviInven;
                        info.IdEstadoDespacho_cat = item.IdEstadoDespacho_cat;
                        info.cm_fecha = item.cm_fecha;
                        info.Estado = item.Estado;
                        info.nom_bodega = item.bo_Descripcion;
                        info.nom_sucursal = item.Su_Descripcion;
                        info.cm_observacion = item.cm_observacion;
                        info.NomTipoMovi = item.nom_TipoMovi;
                        info.nom_EstadoDespacho = item.nom_EstadoDespacho;
                        info.num_Trans = item.num_Trans;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_movi_inve_Info> Get_list_Movi_inven_para_contabilizar(int IdEmpresa, string cm_signo, DateTime Fecha_ini, DateTime Fecha_fin, string Estado_contabilizacion)
        {
            try
            {
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                List<in_movi_inve_Info> Lista = new List<in_movi_inve_Info>();

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_movi_inve_x_estado_contabilizacion
                              where q.IdEmpresa == IdEmpresa
                              && q.cm_tipo == cm_signo
                              && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                              && Estado_contabilizacion == q.Estado_contabilizacion
                              select q;

                    foreach (var item in lst)
                    {
                        in_movi_inve_Info info = new in_movi_inve_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.cod_sucursal = item.cod_sucursal;
                        info.nom_sucursal = item.nom_sucursal;
                        info.cod_bodega = item.cod_bodega;
                        info.nom_bodega = item.nom_bodega;
                        info.cm_fecha = item.cm_fecha;
                        info.tipo_movi_inven = item.nom_tipo_movi;
                        info.cm_tipo = item.cm_tipo;
                        info.cm_observacion = item.cm_observacion;

                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdCbteCble = item.IdCbteCble;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(in_movi_inve_Info prI, ref decimal idMoviInven, ref string mensaje)
        {           
            try
            {
               using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();
                    var Q = from per in EDB.in_movi_inve
                            where per.IdEmpresa == prI.IdEmpresa
                            && per.IdMovi_inven_tipo == prI.IdMovi_inven_tipo
                            && per.IdBodega==prI.IdBodega
                            && per.IdSucursal==prI.IdSucursal
                            && per.IdNumMovi==prI.IdNumMovi
                            select per;

                    decimal IdDev = prI.IdNumMovi;

                    if (Q.ToList().Count == 0)
                    {

                        prI.IdNumMovi = GetIdMovi_Inven(prI.IdEmpresa, prI.IdSucursal, prI.IdBodega, prI.IdMovi_inven_tipo);
                      
                        var address = new in_movi_inve();

                        address.IdEmpresa = prI.IdEmpresa;
                        address.IdSucursal = prI.IdSucursal;
                        address.IdBodega = prI.IdBodega;
                        address.IdMovi_inven_tipo = prI.IdMovi_inven_tipo;
                        idMoviInven=address.IdNumMovi = prI.IdNumMovi;
                        if (prI.CodMoviInven != "" && prI.CodMoviInven!=null)
                        { address.CodMoviInven = prI.CodMoviInven; }
                        else
                        { address.CodMoviInven = "MINV" + prI.IdNumMovi; }
                        address.cm_tipo = prI.cm_tipo;
                        address.cm_observacion = prI.cm_observacion;
                        if (prI.cm_observacion.Length > 1000)
                        {
                            address.cm_observacion = prI.cm_observacion.Substring(0, 1000);
                        }
                        //se le quito el convert.ToDataTime porque en el colegio quieren ordenar los reportes por fecha hora.
                        address.cm_fecha = prI.cm_fecha;

                        address.IdCbteCble = (prI.IdCbteCble == 0) ? null : prI.IdCbteCble;
                        address.IdCbteCble_Tipo = (prI.IdCbteCble_Tipo == 0) ? null : prI.IdCbteCble_Tipo;

                        if (prI.IdCtaCble == null)
                        { address.IdCtaCble = null;}
                        else
                        { address.IdCtaCble = (prI.IdCtaCble.Trim() == "") ? null : prI.IdCtaCble;  }
                        
                        address.cm_anio = prI.cm_fecha.Year;
                        address.cm_mes = prI.cm_fecha.Month;
                        address.Estado = "A";

                        address.Fecha_Transac = DateTime.Now;
                        address.Fecha_UltMod = prI.Fecha_UltMod;
                        address.IdUsuario = prI.IdUsuario;
                        address.IdUsuarioUltModi = prI.IdUsuarioUltModi;
                        address.ip = prI.ip;
                        address.nom_pc = prI.nom_pc;
                        address.IdCentroCosto = (prI.IdCentroCosto == "") ?null : prI.IdCentroCosto;
                        address.IdCentroCosto_sub_centro_costo = (prI.IdCentroCosto_sub_centro_costo == "") ? null : prI.IdCentroCosto_sub_centro_costo;

                        address.IdProvedor = prI.IdProvedor;
                        address.NumDocumentoRelacionado = prI.NumDocumentoRelacionado;
                        address.NumFactura = prI.NumFactura;

                        address.IdEmpresa_x_Anu = prI.IdEmpresa_x_Anu;
                        address.IdSucursal_x_Anu = prI.IdSucursal_x_Anu;
                        address.IdBodega_x_Anu = prI.IdBodega_x_Anu;
                        address.IdMovi_inven_tipo_x_Anu = prI.IdMovi_inven_tipo_x_Anu;
                        address.IdNumMovi_x_Anu = prI.IdNumMovi_x_Anu;
                        address.IdMotivo_Inv = prI.IdMotivo_inv;
                        context.in_movi_inve.Add(address);
                        context.SaveChanges();

                        mensaje = "Grabacion ok..";
                    }
                    else
                        return false;
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

        public Boolean GrabarDB(ref List<in_movi_inve_Info> lmMovInCab, List<in_movi_inve_detalle_Info> lmMovInDetSinId, ref List<in_movi_inve_detalle_Info> lmMovInDetConId, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();

                    int secuen = 0;
                    lmMovInDetConId = new List<in_movi_inve_detalle_Info>();

                    foreach (var item in lmMovInCab)
                    {
                        item.IdNumMovi = GetIdMovi_Inven(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdMovi_inven_tipo);

                        //var contact = in_movi_inve.Createin_movi_inve(0, 0, 0, 0, 0, "", "", "", DateTime.Now, 0, 0, "");
                        var address = new in_movi_inve();

                        address.IdEmpresa = item.IdEmpresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdBodega = item.IdBodega;
                        address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;

                        decimal idmovinGenerada = address.IdNumMovi = item.IdNumMovi;
                            
                        address.CodMoviInven = item.CodMoviInven;
                        address.cm_tipo = item.cm_tipo;
                        address.cm_observacion = item.cm_observacion;
                        //se quito el convert.ToDataTime porque en el colegio necesitan sacar los reportes en fecha/hora.
                        address.cm_fecha = item.cm_fecha;


                        address.IdCbteCble = item.IdCbteCble;
                        address.IdCbteCble_Tipo = item.IdCbteCble_Tipo;
                        address.IdCtaCble = item.IdCtaCble;

                        address.cm_anio = item.cm_fecha.Year;
                        address.cm_mes = item.cm_fecha.Month;
                        address.Estado = item.Estado;

                        address.Fecha_Transac = Convert.ToDateTime(item.cm_fecha.ToShortDateString());
                        address.Fecha_UltMod = Convert.ToDateTime(item.cm_fecha.ToShortDateString());
                        address.IdUsuario = item.IdUsuario;
                        address.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        address.ip = item.ip;
                        address.nom_pc = item.nom_pc;
                        address.IdCentroCosto = item.IdCentroCosto;
                        address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;


                        address.IdEmpresa_x_Anu = item.IdEmpresa_x_Anu;
                        address.IdSucursal_x_Anu = item.IdSucursal_x_Anu;
                        address.IdBodega_x_Anu = item.IdBodega_x_Anu;
                        address.IdMovi_inven_tipo_x_Anu = item.IdMovi_inven_tipo_x_Anu;
                        address.IdNumMovi_x_Anu = item.IdNumMovi_x_Anu;


                        //contact = address;
                        context.in_movi_inve.Add(address);
                        context.SaveChanges();

                        mensaje = "Grabacion ok..";

                        //con lo siguiente seteo el id de la cabecera en el detalle que le corresponde
                        secuen++;
                        var li = lmMovInDetSinId.Where<in_movi_inve_detalle_Info>(C => C.Secuencia == secuen);

                        if (li.ToList().Count == 1)
                            foreach (var itemdet in li)
                            {
                                itemdet.IdNumMovi = idmovinGenerada;
                                lmMovInDetConId.Add(itemdet);
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
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar .." + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(in_movi_inve_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_movi_inve.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdSucursal == prI.IdSucursal && VProdu.IdBodega == prI.IdBodega && VProdu.IdMovi_inven_tipo == prI.IdMovi_inven_tipo && VProdu.IdNumMovi == prI.IdNumMovi);
                    if (contact != null)
                    {
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.cm_anio = prI.cm_fecha.Year;
                        contact.cm_fecha = Convert.ToDateTime(prI.cm_fecha.ToShortDateString());
                        contact.cm_mes = prI.cm_fecha.Month;
                        contact.cm_observacion = prI.cm_observacion;
                        contact.IdCtaCble = prI.IdCtaCble;
                        contact.IdUsuarioUltModi = prI.IdUsuarioUltModi;
                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
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
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(in_movi_inve_Info MoviInfo, ref  string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_movi_inve.FirstOrDefault(prod1 => prod1.IdEmpresa == MoviInfo.IdEmpresa && prod1.IdSucursal == MoviInfo.IdSucursal && prod1.IdBodega == MoviInfo.IdBodega && prod1.IdMovi_inven_tipo == MoviInfo.IdMovi_inven_tipo && prod1.IdNumMovi == MoviInfo.IdNumMovi);
                    //no elimino el registro solo cambia el estado de activo a inactivo
                    if (contact != null)
                    {
                        contact.Estado = "I"; //cambio el estado de activo por inactivo
                        contact.cm_observacion = " ***ANULADO***" + contact.cm_observacion;
                        contact.IdusuarioUltAnu = MoviInfo.IdusuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltModi = MoviInfo.IdUsuarioUltModi;
                        contact.MotivoAnulacion = MoviInfo.MotivoAnulacion;
                        contact.IdEmpresa_x_Anu = MoviInfo.IdEmpresa_x_Anu;
                        contact.IdSucursal_x_Anu = MoviInfo.IdSucursal_x_Anu;
                        contact.IdBodega_x_Anu = MoviInfo.IdBodega_x_Anu;
                        contact.IdMovi_inven_tipo_x_Anu = MoviInfo.IdMovi_inven_tipo_x_Anu;
                        contact.IdNumMovi_x_Anu = MoviInfo.IdNumMovi_x_Anu;
                        contact.MotivoAnulacion = MoviInfo.MotivoAnulacion;
                        context.SaveChanges();
                        mensaje = "Anulacion Exitosa..";
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
                mensaje = "Error al Anular:  " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
             
        public decimal GetIdMovi_Inven(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo)
        {
            try
            {
                decimal IdMovi_inven_tipo1;

                EntitiesInventario OECbtecble = new EntitiesInventario();
                var q = from A in OECbtecble.in_movi_inve
                        where A.IdEmpresa == IdEmpresa
                        && A.IdBodega==IdBodega 
                        && A.IdMovi_inven_tipo==IdMovi_inven_tipo
                        && A.IdSucursal == IdSucursal
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdMovi_inven_tipo1 = 1;
                }
                else
                {
                    OECbtecble = new EntitiesInventario();
                    var selectCbtecble = (from CbtCble in OECbtecble.in_movi_inve
                                          where CbtCble.IdEmpresa == IdEmpresa
                                            && CbtCble.IdBodega == IdBodega
                                            && CbtCble.IdMovi_inven_tipo == IdMovi_inven_tipo
                                            && CbtCble.IdSucursal == IdSucursal
                                          select CbtCble.IdNumMovi).Max();
                    IdMovi_inven_tipo1 = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdMovi_inven_tipo1;
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

        public in_movi_inve_Info Get_list_Movi_inven_Reporte(int IdEmpresa, int IdSucursal, int IdBodega,
            int TipoMovi, decimal IdNumMovi)
        {
            try
            {
                byte[] logo;

                logo = null;

                in_movi_inve_Info moviI = new in_movi_inve_Info();
                EntitiesGeneral OGeneral = new EntitiesGeneral();

                var Logo = from E in OGeneral.tb_empresa
                           where E.IdEmpresa == IdEmpresa
                           select E;

                foreach (var item in Logo)
                {
                    logo = item.em_logo;

                }

                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_movi_inve
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdSucursal == IdSucursal
                                     && C.IdBodega == IdBodega
                                     && C.IdMovi_inven_tipo == TipoMovi
                                     && C.IdNumMovi == IdNumMovi
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    moviI.cm_anio = item.cm_anio;
                    moviI.cm_fecha = item.cm_fecha;
                    moviI.cm_mes = item.cm_mes;
                    moviI.cm_observacion = item.cm_observacion;
                    moviI.cm_tipo = item.cm_tipo;
                    moviI.Estado = item.Estado;
                    moviI.Fecha_Transac = item.Fecha_Transac;
                    moviI.Fecha_UltAnu = item.Fecha_UltAnu;
                    moviI.Fecha_UltMod = item.Fecha_UltMod;
                    moviI.IdBodega = item.IdBodega;
                    moviI.IdCbteCble = item.IdCbteCble;
                    moviI.IdCbteCble_Tipo = item.IdCbteCble_Tipo;
                    moviI.IdCtaCble = item.IdCtaCble;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.IdUsuario = item.IdUsuario;
                    moviI.IdusuarioUltAnu = item.IdusuarioUltAnu;
                    moviI.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    moviI.ip = item.ip;
                    moviI.nom_pc = item.nom_pc;
                    moviI.NomBodega = item.NomBodega;
                    moviI.NomSucursal = item.NomSucursal;
                    moviI.NomTipoMovi = item.NomTipoMovi;
                    moviI.CodTipoMovi = item.CodTipoMovi;
                    moviI.NemoTipoMovi = item.NemoTipoMovi;
                    moviI.CodMoviInven = item.CodMoviInven;
                    moviI.IdCentroCosto = item.IdCentroCosto;
                    moviI.logo = logo;

                    moviI.IdEmpresa_x_Anu = item.IdEmpresa_x_Anu;
                    moviI.IdSucursal_x_Anu = item.IdSucursal_x_Anu;
                    moviI.IdBodega_x_Anu = item.IdBodega_x_Anu;
                    moviI.IdMovi_inven_tipo_x_Anu = item.IdMovi_inven_tipo_x_Anu;
                    moviI.IdNumMovi_x_Anu = item.IdNumMovi_x_Anu;
                    moviI.MotivoAnulacion = item.MotivoAnulacion;
                }
                /// busco el detalle
                /// 
                in_movi_inve_detalle_Data Movidet_data = new in_movi_inve_detalle_Data();
                List<in_movi_inve_detalle_Info> listdetalle_Movi = new List<in_movi_inve_detalle_Info>();

                listdetalle_Movi = Movidet_data.Get_list_Movi_inven_det(IdEmpresa, IdSucursal, IdBodega, TipoMovi, IdNumMovi);
                moviI.listmovi_inve_detalle_Info = listdetalle_Movi;

                return (moviI);
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
        
        public decimal Get_IdMovInv(int IdEmpresa, int IdSucursal, int IdBodega, string codMovi)
        {
            try
            {
                decimal x = 0;
                EntitiesInventario OECbtecble = new EntitiesInventario();
                var q = from A in OECbtecble.in_movi_inve
                        where A.IdEmpresa == IdEmpresa
                        && A.IdBodega==IdBodega
                        && A.IdSucursal == IdSucursal && A.CodMoviInven==codMovi
                        select A;
                foreach (var item in q)
                {
                    x=item.IdNumMovi;
                }
                return x;
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

        public List<vwIn_MoviemientoInvetarioXImportacion_Info> Get_List_SaldoImpoXMovimiento(int IdEmpres,int IdSucursal, int IdBodega, decimal IdOrdenCompraExterna) 
        {
            try
            {
                List<vwIn_MoviemientoInvetarioXImportacion_Info> lista = new List<vwIn_MoviemientoInvetarioXImportacion_Info>();

                using(EntitiesInventario Oentities = new EntitiesInventario())
                {
                    var consulta = from q in Oentities.vwin_MoviemientoInvetarioXImportacion
                                   where q.IdEmpresa == IdEmpres && q.in_IdBodega == IdBodega && q.IdSucursal == IdSucursal && q.IdOrdenCompraExt == IdOrdenCompraExterna
                                   select q;
                    foreach (var item in consulta)
                    {
                        vwIn_MoviemientoInvetarioXImportacion_Info obj = new vwIn_MoviemientoInvetarioXImportacion_Info();
                        obj.di_cantidad_Solicitada = item.di_cantidad_Solicitada;
                        obj.dm_cantidad_Ingresa = item.dm_cantidad_Ingresa;
                        obj.IdProducto = item.IdProducto;
                        obj.IdEmpresa = item.IdEmpresa;
                        obj.IdOrdenCompraExt = item.IdOrdenCompraExt;
                        obj.IdSucursal = item.IdSucursal;
                        obj.in_IdBodega = item.in_IdBodega;
                        obj.SaldoxIngresar = item.SaldoxIngresar;

                        lista.Add(obj);
                    }
                   
                }

                return lista;
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

        public List<in_movi_inve_Info> Get_list_Movi_inven_Recepcion
        (int IdEmpresa,  int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin)
        {

            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
             
                if (IdSucursalIni == 0)
                {
                    IdSucursalFin = 5000;
                    IdSucursalIni = 0;
                }
                else
                    IdSucursalFin = IdSucursalIni;

                if (IdBodegaIni == 0)
                {
                    IdBodegaFin = 5000;
                    IdBodegaIni = 0;
                }
                else
                    IdBodegaFin = IdBodegaIni;

                paramCUS = dataParam.ObtenerObjeto(IdEmpresa);

                List<in_movi_inve_Info> lM = new List<in_movi_inve_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_movi_inve
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdMovi_inven_tipo == paramCUS.IdMovi_inven_tipo_ing_suc_princ
                                     && C.IdSucursal >= IdSucursalIni && C.IdSucursal <= IdSucursalFin
                                     && C.IdBodega >= IdBodegaIni && C.IdBodega <= IdBodegaFin
                                     && C.cm_fecha >= FechaIni && C.cm_fecha <= FechaFin
                                     
                                   select C;
                foreach (var item in selectCbtecble)
                {
                    in_movi_inve_Info moviI = new in_movi_inve_Info();

                    moviI.cm_anio = item.cm_anio;
                    moviI.cm_fecha = item.cm_fecha;
                    moviI.cm_mes = item.cm_mes;
                    moviI.cm_observacion = item.cm_observacion;
                    moviI.cm_tipo = item.cm_tipo;
                    moviI.Estado = item.Estado;
                    moviI.Fecha_Transac = item.Fecha_Transac;
                    moviI.Fecha_UltAnu = item.Fecha_UltAnu;
                    moviI.Fecha_UltMod = item.Fecha_UltMod;
                    moviI.IdBodega = item.IdBodega;
                    moviI.IdCbteCble = item.IdCbteCble;
                    moviI.IdCbteCble_Tipo = item.IdCbteCble_Tipo;
                    moviI.IdCtaCble = item.IdCtaCble;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.IdUsuario = item.IdUsuario;
                    moviI.IdusuarioUltAnu = item.IdusuarioUltAnu;
                    moviI.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    moviI.ip = item.ip;
                    moviI.nom_pc = item.nom_pc;
                    moviI.NomBodega = item.NomBodega;
                    moviI.NomSucursal = item.NomSucursal;
                    moviI.NomTipoMovi = item.NomTipoMovi;
                    moviI.CodTipoMovi = item.CodTipoMovi;
                    moviI.NumFactura = (item.NumFactura == null) ? "" : item.NumFactura; 
                    moviI.IdProvedor = (decimal)((item.IdProvedor == null) ? 0 : item.IdProvedor);
                    moviI.NumDocumentoRelacionado = (item.NumDocumentoRelacionado==null)?"":item.NumDocumentoRelacionado;
                    moviI.NemoTipoMovi = item.NemoTipoMovi;
                    moviI.IdCentroCosto = item.IdCentroCosto;
                    moviI.CodNomTipoMovi = "[" + item.CodTipoMovi + "] - " + item.NomTipoMovi;
                    moviI.ReferenciaOC = String.Format("{0} - {1} - {2}",
                    (item.CodCentroCosto != null) ? item.CodCentroCosto.Trim() : "",
                    (item.Centro_costo != null) ? item.Centro_costo.Trim() : "",
                    item.cm_observacion.Trim());
                    moviI.IdEmpresa_x_Anu = item.IdEmpresa_x_Anu;
                    moviI.IdSucursal_x_Anu = item.IdSucursal_x_Anu;
                    moviI.IdBodega_x_Anu = item.IdBodega_x_Anu;
                    moviI.IdMovi_inven_tipo_x_Anu = item.IdMovi_inven_tipo_x_Anu;
                    moviI.IdNumMovi_x_Anu = item.IdNumMovi_x_Anu;
                    moviI.MotivoAnulacion = item.MotivoAnulacion;

                    lM.Add(moviI);
                }

                return (lM);
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
            
        public List<in_movi_inve_Info> Get_list_Movi_inven_x_ProdDiariaLagminadosTalme(int IdEmpresa, int IdSucursal, int IdBodega, int TipoMovi, decimal IdNumMov)
        {
            try
            {
                List<in_movi_inve_Info> lM = new List<in_movi_inve_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select = from C in OEInventario.vwin_movi_inve
                             where C.IdEmpresa == IdEmpresa
                             && C.IdSucursal == IdSucursal
                             && C.IdBodega == IdBodega
                             && C.IdMovi_inven_tipo == TipoMovi
                             && C.IdNumMovi == IdNumMov
                             select new
                             {
                                 C.cm_anio,
                                 C.cm_fecha,
                                 C.cm_mes,
                                 C.cm_observacion,
                                 C.cm_tipo,
                                 C.Estado,
                                 C.Fecha_Transac,
                                 C.Fecha_UltAnu,
                                 C.Fecha_UltMod,
                                 C.IdBodega,
                                 C.IdCbteCble,
                                 C.IdCbteCble_Tipo,
                                 C.IdCtaCble,
                                 C.IdEmpresa,
                                 C.IdMovi_inven_tipo,
                                 C.IdNumMovi,
                                 C.IdSucursal,
                                 C.IdUsuario,
                                 C.IdusuarioUltAnu,
                                 C.IdUsuarioUltModi,
                                 C.ip,
                                 C.nom_pc,
                                 C.NomBodega,
                                 C.NomSucursal,
                                 C.NomTipoMovi,
                                 C.CodTipoMovi,
                                 C.NemoTipoMovi,
                                 C.CodMoviInven,
                                 C.IdEmpresa_x_Anu,
                                 C.IdSucursal_x_Anu,
                                 C.IdBodega_x_Anu,
                                 C.IdMovi_inven_tipo_x_Anu,
                                 C.IdNumMovi_x_Anu,
                                 C.MotivoAnulacion
                             };

                foreach (var item in select)
                {
                    in_movi_inve_Info moviI = new in_movi_inve_Info();

                    moviI.cm_anio = item.cm_anio;
                    moviI.cm_fecha = item.cm_fecha;
                    moviI.cm_mes = item.cm_mes;
                    moviI.cm_observacion = item.cm_observacion;
                    moviI.cm_tipo = item.cm_tipo;
                    moviI.Estado = item.Estado;
                    moviI.Fecha_Transac = item.Fecha_Transac;
                    moviI.Fecha_UltAnu = item.Fecha_UltAnu;
                    moviI.Fecha_UltMod = item.Fecha_UltMod;
                    moviI.IdBodega = item.IdBodega;
                    moviI.IdCbteCble = item.IdCbteCble;
                    moviI.IdCbteCble_Tipo = item.IdCbteCble_Tipo;
                    moviI.IdCtaCble = item.IdCtaCble;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.IdUsuario = item.IdUsuario;
                    moviI.IdusuarioUltAnu = item.IdusuarioUltAnu;
                    moviI.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    moviI.ip = item.ip;
                    moviI.nom_pc = item.nom_pc;
                    moviI.NomBodega = item.NomBodega;
                    moviI.NomSucursal = item.NomSucursal;
                    moviI.NomTipoMovi = item.NomTipoMovi;
                    moviI.CodTipoMovi = item.CodTipoMovi;
                    moviI.NemoTipoMovi = item.NemoTipoMovi;
                    moviI.CodMoviInven = item.CodMoviInven;

                    moviI.IdEmpresa_x_Anu = item.IdEmpresa_x_Anu;
                    moviI.IdSucursal_x_Anu = item.IdSucursal_x_Anu;
                    moviI.IdBodega_x_Anu = item.IdBodega_x_Anu;
                    moviI.IdMovi_inven_tipo_x_Anu = item.IdMovi_inven_tipo_x_Anu;
                    moviI.IdNumMovi_x_Anu = item.IdNumMovi_x_Anu;
                    moviI.MotivoAnulacion = item.MotivoAnulacion;

                    lM.Add(moviI);
                }

                return (lM);
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

        public List<in_movi_inve_Info> Get_list_Movi_inven
        (int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<in_movi_inve_Info> lM = new List<in_movi_inve_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_movi_inve
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdSucursal >= IdSucursal
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_movi_inve_Info moviI = new in_movi_inve_Info();

                    moviI.cm_anio = item.cm_anio;
                    moviI.cm_fecha = item.cm_fecha;
                    moviI.cm_mes = item.cm_mes;
                    moviI.cm_observacion = item.cm_observacion;
                    moviI.cm_tipo = item.cm_tipo;
                    moviI.Estado = item.Estado;
                    moviI.Fecha_Transac = item.Fecha_Transac;
                    moviI.Fecha_UltAnu = item.Fecha_UltAnu;
                    moviI.Fecha_UltMod = item.Fecha_UltMod;
                    moviI.IdBodega = item.IdBodega;
                    moviI.IdCbteCble = item.IdCbteCble;
                    moviI.IdCbteCble_Tipo = item.IdCbteCble_Tipo;
                    moviI.IdCtaCble = item.IdCtaCble;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.IdUsuario = item.IdUsuario;
                    moviI.IdusuarioUltAnu = item.IdusuarioUltAnu;
                    moviI.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    moviI.ip = item.ip;
                    moviI.nom_pc = item.nom_pc;
                    moviI.NomBodega = item.NomBodega;
                    moviI.NomSucursal = item.NomSucursal;
                    moviI.NomTipoMovi = item.NomTipoMovi;
                    moviI.CodTipoMovi = item.CodTipoMovi;
                    moviI.NumFactura = (item.NumFactura == null) ? "" : item.NumFactura;
                    moviI.IdProvedor = (decimal)((item.IdProvedor == null) ? 0 : item.IdProvedor);
                    moviI.NumDocumentoRelacionado = (item.NumDocumentoRelacionado == null) ? "" : item.NumDocumentoRelacionado;
                    moviI.NemoTipoMovi = item.NemoTipoMovi;
                    moviI.CodMoviInven = item.CodMoviInven;

                    moviI.IdCentroCosto = item.IdCentroCosto;
                    moviI.CodNomTipoMovi = "[" + item.CodTipoMovi + "] - " + item.NomTipoMovi;
                    moviI.ReferenciaOC = String.Format("{0} - {1} - {2}", (item.CodCentroCosto != null) ?
item.CodCentroCosto.Trim() : "",
                        (item.Centro_costo != null) ?
item.Centro_costo.Trim() : "",
                        item.cm_observacion.Trim());
                    moviI.IdEmpresa_x_Anu = item.IdEmpresa_x_Anu;
                    moviI.IdSucursal_x_Anu = item.IdSucursal_x_Anu;
                    moviI.IdBodega_x_Anu = item.IdBodega_x_Anu;
                    moviI.IdMovi_inven_tipo_x_Anu = item.IdMovi_inven_tipo_x_Anu;
                    moviI.IdNumMovi_x_Anu = item.IdNumMovi_x_Anu;
                    moviI.MotivoAnulacion = item.MotivoAnulacion;

                    lM.Add(moviI);
                }

                return (lM);
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

        public in_movi_inve_Info Get_Info_Movi_inven(int IdEmpresa, int IdSucursal, int IdBodega,
        int TipoMovi, decimal IdNumMovi)
        {
            try
            {              
                in_movi_inve_Info moviI = new in_movi_inve_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_movi_inve
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdSucursal == IdSucursal
                                     && C.IdBodega == IdBodega
                                     && C.IdMovi_inven_tipo == TipoMovi
                                     && C.IdNumMovi == IdNumMovi
                                     select C;
                foreach (var item in selectCbtecble)
                {
                    moviI.cm_anio = item.cm_anio;
                    moviI.cm_fecha = item.cm_fecha;
                    moviI.cm_mes = item.cm_mes;
                    moviI.cm_observacion = item.cm_observacion;
                    moviI.cm_tipo = item.cm_tipo;
                    moviI.Estado = item.Estado;
                    moviI.Fecha_Transac = item.Fecha_Transac;
                    moviI.Fecha_UltAnu = item.Fecha_UltAnu;
                    moviI.Fecha_UltMod = item.Fecha_UltMod;
                    moviI.IdBodega = item.IdBodega;
                    moviI.IdCbteCble = item.IdCbteCble;
                    moviI.IdCbteCble_Tipo = item.IdCbteCble_Tipo;
                    moviI.IdCtaCble = item.IdCtaCble;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.IdUsuario = item.IdUsuario;
                    moviI.IdusuarioUltAnu = item.IdusuarioUltAnu;
                    moviI.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    moviI.ip = item.ip;
                    moviI.nom_pc = item.nom_pc;
                    moviI.IdMotivo_inv = item.IdMotivo_Inv;

                    moviI.nom_sucursal = item.NomSucursal;
                    moviI.nom_bodega = item.NomBodega;
                    moviI.tipo_movi_inven = item.NomTipoMovi;
                    moviI.nom_proveedor = "";

                    moviI.NomBodega = item.NomBodega;
                    moviI.NomSucursal = item.NomSucursal;
                    moviI.NomTipoMovi = item.NomTipoMovi;
                    moviI.CodTipoMovi = item.CodTipoMovi;
                    moviI.NemoTipoMovi = item.NemoTipoMovi;
                    moviI.CodMoviInven = item.CodMoviInven;
                    moviI.IdCentroCosto = item.IdCentroCosto;

                    moviI.IdEmpresa_x_Anu = item.IdEmpresa_x_Anu;
                    moviI.IdSucursal_x_Anu = item.IdSucursal_x_Anu;
                    moviI.IdBodega_x_Anu = item.IdBodega_x_Anu;
                    moviI.IdMovi_inven_tipo_x_Anu = item.IdMovi_inven_tipo_x_Anu;
                    moviI.IdNumMovi_x_Anu = item.IdNumMovi_x_Anu;
                    moviI.MotivoAnulacion = item.MotivoAnulacion;
                }
                /// busco el detalle
                /// 
                in_movi_inve_detalle_Data Movidet_data = new in_movi_inve_detalle_Data();
                List<in_movi_inve_detalle_Info> listdetalle_Movi = new List<in_movi_inve_detalle_Info>();

                listdetalle_Movi = Movidet_data.Get_list_Movi_inven_det(IdEmpresa, IdSucursal, IdBodega, TipoMovi, IdNumMovi);

                moviI.listmovi_inve_detalle_Info = listdetalle_Movi;
                return (moviI);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString().ToString());
            }
        }

        public List<in_movi_inve_Info> Get_List_IngCompra_x_Bodega(int IdEmpresa, int IdSucursal,int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {
            List<in_movi_inve_Info> Lst = new List<in_movi_inve_Info>();
            EntitiesInventario OEComp = new EntitiesInventario();
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                      
                var Select = from q in OEComp.vwin_movi_inve_x_Ing_Ordencompra_local
                             where q.IdEmpresa == IdEmpresa
                             && q.cm_fecha <= FechaFin
                             && q.cm_fecha >= FechaIni
                             && q.IdBodega == IdBodega
                             && q.IdSucursal == IdSucursal
                             select q;
                foreach (var item in Select)
                {
                    in_movi_inve_Info IngCompBodInfo = new in_movi_inve_Info();
                    IngCompBodInfo.IdEmpresa = item.IdEmpresa;
                    IngCompBodInfo.IdSucursal = item.IdSucursal;
                    IngCompBodInfo.IdBodega = item.IdBodega;
                    IngCompBodInfo.IdMovi_inven_tipo = item.IdTipoMoviInven;
                    IngCompBodInfo.IdNumMovi = item.IdNumMovi;
                    IngCompBodInfo.nom_sucursal = item.nom_sucursal;
                    IngCompBodInfo.nom_bodega = item.nom_bodega;
                    IngCompBodInfo.tipo_movi_inven = item.tipo_movi_inven;
                    IngCompBodInfo.IdProvedor = item.IdProveedor;
                    IngCompBodInfo.nom_proveedor = item.nom_proveedor;
                    IngCompBodInfo.oc_fecha = item.cm_fecha;
                    IngCompBodInfo.cm_observacion = item.cm_observacion;

                    Lst.Add(IngCompBodInfo);
                }
                    return Lst;             
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int IdMovimientoEmpresa(int IdEmpresa)
        {
            try
            {
                Int32 IdMovimiento = 0;
                EntitiesInventario OEEtapa = new EntitiesInventario();
                var selecte = OEEtapa.in_movi_inve.Count();

                if (selecte == 0)
                {
                    IdMovimiento = 1;
                }
                else
                {
                    var select_em = (from q in OEEtapa.in_movi_inve
                                     where q.IdEmpresa==IdEmpresa
                                     select q.IdNumMovi).Max();
                     
                    IdMovimiento = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return IdMovimiento;

            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_proceso_cerrado(in_movi_inve_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_movi_inve Entity = Context.in_movi_inve.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == info.IdBodega && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);
                    if (Entity!= null)
                    {
                        Entity.cm_observacion = info.cm_observacion;
                        Entity.cm_fecha = info.cm_fecha.Date;
                        Entity.CodMoviInven = info.CodMoviInven;
                        Context.SaveChanges();

                        msgs = "Modificación realizada correctamente";
                    }                    
                }

                return true;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Actualizar_estado_despacho(List<in_movi_inve_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    using (EntitiesInventario Context = new EntitiesInventario())
                    {
                        in_movi_inve Entity = Context.in_movi_inve.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi);
                        if (Entity != null)
                        {
                            Entity.IdEstadoDespacho_cat = "EST_DES_DES";
                            Entity.Fecha_despacho = DateTime.Now;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public DateTime Get_fecha_costeo_recomendada(int IdEmpresa, int IdSucursal)
        {
            try
            {
                DateTime Fecha_recomendada = DateTime.Now.Date;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_movi_inve_fecha_costeo_recomendada_x_sucursal
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              select q;

                    foreach (var item in lst)
                    {
                        Fecha_recomendada = item.fecha_sin_costear == null ? DateTime.Now.Date : Convert.ToDateTime(item.fecha_sin_costear);
                    }
                }

                return Fecha_recomendada.Date;
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
    }
}
