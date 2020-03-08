using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Data.Contabilidad;

namespace Core.Erp.Data.Inventario
{
    
    public class in_movi_inve_Data
    {
        string mensaje = "";
        public in_movi_inve_Data() { }
        in_UnidadMedida_Data odataUnidadMedida = new in_UnidadMedida_Data();
        tb_Sucursal_Data odata_su = new tb_Sucursal_Data();
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
                        info.IdNumMoviPreAprobado = item.IdNumMoviPreAprobado;

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

        private decimal get_id(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo)
        {
            try
            {
                decimal ID = 1;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.in_movi_inve
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega
                              && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                              select q;

                    if (lst.Count() > 0)
                        ID = lst.Max(q => q.IdNumMovi) + 1;
                }

                return ID;
            }
            catch (Exception)
            {
                
                throw;
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

        public bool ContabilizacionData(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, string IdUsuario, ref string mensaje)
        {
            EntitiesInventario db_inv = new EntitiesInventario();
            EntitiesDBConta db_ct = new EntitiesDBConta();
            EntitiesGeneral db_gen = new EntitiesGeneral();
            try
            {
                if (db_inv.in_movi_inve_x_ct_cbteCble.Where(q=>q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdMovi_inven_tipo == IdMovi_inven_tipo && q.IdNumMovi == IdNumMovi).Count() > 0)
                    return true;

                #region Variables
                ct_Cbtecble_Data odata_ct = new ct_Cbtecble_Data();
                int secuencia = 1;
                int secuencia_reg = 1;
                double valor = 0;
                double total = 0;
                bool es_transferencia = false;
                #endregion

                #region Valido si se contabiliza
                var movimiento = (from movi in db_inv.in_movi_inve
                                  join tipo in db_inv.in_movi_inven_tipo
                                      on new { movi.IdEmpresa, movi.IdMovi_inven_tipo } equals new { tipo.IdEmpresa, tipo.IdMovi_inven_tipo }
                                  where movi.IdEmpresa == IdEmpresa
                                  && movi.IdSucursal == IdSucursal
                                  && movi.IdBodega == IdBodega
                                  && movi.IdMovi_inven_tipo == IdMovi_inven_tipo
                                  && movi.IdNumMovi == IdNumMovi
                                  && tipo.Genera_Diario_Contable == true
                                  select new{
                                      IdEmpresa = movi.IdEmpresa,
                                      IdSucursal = movi.IdSucursal,
                                      IdBodega = movi.IdBodega,
                                      IdMovi_inven_tipo = movi.IdMovi_inven_tipo,
                                      IdNumMovi = movi.IdNumMovi,
                                      IdMotivo_Inv = movi.IdMotivo_Inv,
                                      IdTipoCbte = tipo.IdTipoCbte,
                                      movi.cm_fecha,
                                      movi.cm_observacion,
                                      tipo.tm_descripcion,
                                      tipo.cm_descripcionCorta,
                                      movi.cm_tipo
                                  }).FirstOrDefault();

                if (movimiento == null)
                    return true;
                #endregion

                #region Consulto cuenta de inventario de la bodega
                var bodega = db_gen.tb_bodega.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega).FirstOrDefault();
                if (string.IsNullOrEmpty(bodega.IdCtaCtble_Inve))
                {
                    mensaje = "La bodega " + bodega.bo_Descripcion + " no tiene parametrizada una cuenta para inventario";
                    return false;
                }
                #endregion

                #region Valido el tipo de contabilización
                var motivo = db_inv.in_Motivo_Inven.Where(q => q.IdEmpresa == movimiento.IdEmpresa && q.IdMotivo_Inv == movimiento.IdMotivo_Inv).FirstOrDefault();
                if (motivo == null)
                {
                    mensaje = "El motivo no existe";
                    return false;
                }

                var parametros = db_inv.in_parametro.Where(q => q.IdEmpresa == IdEmpresa).FirstOrDefault();
                if (parametros == null)
                {
                    mensaje = "No se encontró parámetros de inventario";
                    return false;
                }

                if (parametros.IdMovi_inven_tipo_egresoBodegaOrigen == IdMovi_inven_tipo || parametros.IdMovi_inven_tipo_ingresoBodegaDestino == IdMovi_inven_tipo)
                    es_transferencia = true;

                if (es_transferencia && string.IsNullOrEmpty(parametros.P_IdCtaCble_transitoria_transf_inven))
                {
                    mensaje = "Falta cuenta contable transitoria de transferencias";
                    return false;
                }

                #endregion

                //(-) Debe Costo / Haber Bodega
                //(+) Debe Bodega / Haber Costo

                #region Consulto detalle con todos los campos para contabilizar
                var lst_det = (from det in db_inv.in_movi_inve_detalle
                               join pro in db_inv.in_Producto
                               on new { det.IdEmpresa, det.IdProducto } equals new { pro.IdEmpresa, pro.IdProducto }                               
                               join inv in db_inv.in_Ing_Egr_Inven_det
                               on new { IdEmpresa = det.IdEmpresa, IdSucursal = det.IdSucursal, IdBodega = det.IdBodega, IdMovi_inven_tipo = det.IdMovi_inven_tipo, IdNumMovi = det.IdNumMovi, Secuencia = det.Secuencia }
                               equals new { IdEmpresa = (int)inv.IdEmpresa_inv, IdSucursal = (int)inv.IdSucursal_inv, IdBodega = (int)inv.IdBodega_inv, IdMovi_inven_tipo = (int)inv.IdMovi_inven_tipo_inv, IdNumMovi = (decimal)inv.IdNumMovi_inv, Secuencia = (int)inv.secuencia_inv }
                               join ct in db_inv.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble
                                on new { IdEmpresa = pro.IdEmpresa, IdCategoria = pro.IdCategoria, IdLinea = pro.IdLinea, IdGrupo = pro.IdGrupo, IdSubGrupo = pro.IdSubGrupo, IdCentroCosto = det.IdCentroCosto, IdCentroCosto_sub_centro_costo = det.IdCentroCosto_sub_centro_costo }
                                equals new { IdEmpresa = ct.IdEmpresa, IdCategoria = ct.IdCategoria, IdLinea = ct.IdLinea, IdGrupo = ct.IdGrupo, IdSubGrupo = ct.IdSubgrupo, IdCentroCosto = ct.IdCentroCosto, IdCentroCosto_sub_centro_costo = ct.IdSub_centro_costo }
                                into gr from p in gr.DefaultIfEmpty()
                               where det.IdEmpresa == IdEmpresa
                               && det.IdSucursal == IdSucursal
                               && det.IdBodega == IdBodega
                               && det.IdMovi_inven_tipo == IdMovi_inven_tipo
                               && det.IdNumMovi == IdNumMovi
                               select new in_movi_inve_detalle_Info
                               {
                                   IdNumMovi = inv.IdNumMovi,
                                   Secuencia = det.Secuencia,
                                   dm_cantidad = det.dm_cantidad,
                                   mv_costo = det.mv_costo,
                                   IdCentroCosto = det.IdCentroCosto,
                                   IdCentroCosto_sub_centro_costo = det.IdCentroCosto_sub_centro_costo,
                                   IdCtaCbleCosto = p == null ? null : p.IdCtaCble,
                                   pr_descripcion = pro.pr_descripcion
                               }).ToList();
                #endregion                

                    #region Valido detalle de movimientos para contabilizar
                    if (!es_transferencia && lst_det.Where(q => string.IsNullOrEmpty(q.IdCtaCbleCosto)).Count() > 0)
                    {
                        mensaje = "Falta parametrizar relación centro/cuenta";
                        return false;
                    }
                    if (lst_det.Where(q=>q.mv_costo == 0).Count() > 0)
                    {
                        mensaje = "Detalles con costo 0:";
                        foreach (var item in lst_det.Where(q=>q.mv_costo == 0).ToList())
                        {
                            mensaje += "\n"+item.pr_descripcion;
                        }
                        return false;
                    }
                    #endregion

                    #region Cabecera del diario
                    var suc = odata_su.Get_Info_Sucursal(IdEmpresa, IdSucursal);
                    var diario = new ct_cbtecble
                    {
                        IdEmpresa = movimiento.IdEmpresa,
                        IdTipoCbte = (int)movimiento.IdTipoCbte,
                        IdCbteCble = odata_ct.Get_IdCbteCble(movimiento.IdEmpresa, (int)movimiento.IdTipoCbte, ref mensaje),
                        CodCbteCble = movimiento.cm_descripcionCorta,
                        IdPeriodo = Convert.ToInt32(movimiento.cm_fecha.ToString("yyyyMM")),
                        cb_Fecha = movimiento.cm_fecha,
                        cb_Valor = 0,
                        cb_Observacion = movimiento.tm_descripcion + " #" + lst_det.Max(q => q.IdNumMovi).ToString() + " " + movimiento.cm_observacion,
                        cb_Secuencia = 1,
                        cb_Anio = movimiento.cm_fecha.Year,
                        cb_mes = movimiento.cm_fecha.Month,
                        IdUsuario = IdUsuario,
                        cb_FechaTransac = DateTime.Now,
                        cb_para_conciliar = false,
                        IdSucursal = suc.IdSucursalContabilizacion ?? suc.IdSucursal,
                        cb_Mayorizado = "N",
                        cb_Estado = "A"
                    };

                    #endregion

                    #region Detalle del diario y relaciones
                    foreach (var item in lst_det)
                    {
                        valor = Math.Round(item.dm_cantidad * (double)item.mv_costo, 2, MidpointRounding.AwayFromZero);
                        total += valor;
                        //Debe
                        db_ct.ct_cbtecble_det.Add(new ct_cbtecble_det
                        {
                            IdEmpresa = diario.IdEmpresa,
                            IdTipoCbte = diario.IdTipoCbte,
                            IdCbteCble = diario.IdCbteCble,
                            secuencia = secuencia,
                            IdCtaCble = movimiento.cm_tipo == "-" ? (es_transferencia ? parametros.P_IdCtaCble_transitoria_transf_inven : item.IdCtaCbleCosto) : bodega.IdCtaCtble_Inve,                            
                            IdCentroCosto = movimiento.cm_tipo == "-" ? item.IdCentroCosto : null,
                            IdCentroCosto_sub_centro_costo = movimiento.cm_tipo == "-" ? item.IdCentroCosto_sub_centro_costo : null,
                            dc_Valor = Math.Abs(valor),
                            dc_Observacion = item.pr_descripcion.Trim(),
                            dc_para_conciliar = false
                        });
                        db_inv.in_movi_inve_detalle_x_ct_cbtecble_det.Add(new in_movi_inve_detalle_x_ct_cbtecble_det
                        {
                            IdEmpresa_inv = IdEmpresa,
                            IdSucursal_inv = IdSucursal,
                            IdBodega_inv = IdBodega,
                            IdMovi_inven_tipo_inv = IdMovi_inven_tipo,
                            IdNumMovi_inv = IdNumMovi,
                            Secuencia_inv = item.Secuencia,
                            IdEmpresa_ct = diario.IdEmpresa,
                            IdTipoCbte_ct = diario.IdTipoCbte,
                            IdCbteCble_ct = diario.IdCbteCble,
                            secuencia_ct = secuencia++,
                            Secuencial_reg = secuencia_reg++,
                            observacion = "la cta se tomo de:" + (movimiento.cm_tipo == "+" ? "X_BODEGA" : "X_MOTIVO_INV")
                        });
                        //Haber
                        db_ct.ct_cbtecble_det.Add(new ct_cbtecble_det
                        {
                            IdEmpresa = diario.IdEmpresa,
                            IdTipoCbte = diario.IdTipoCbte,
                            IdCbteCble = diario.IdCbteCble,
                            secuencia = secuencia,
                            IdCtaCble = movimiento.cm_tipo == "-" ? bodega.IdCtaCtble_Inve : (es_transferencia ? parametros.P_IdCtaCble_transitoria_transf_inven : item.IdCtaCbleCosto),
                            IdCentroCosto = movimiento.cm_tipo == "-" ? null : item.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = movimiento.cm_tipo == "-" ? null : item.IdCentroCosto_sub_centro_costo,
                            dc_Valor = Math.Abs(valor) * -1,
                            dc_Observacion = item.pr_descripcion.Trim(),
                            dc_para_conciliar = false
                        });
                        db_inv.in_movi_inve_detalle_x_ct_cbtecble_det.Add(new in_movi_inve_detalle_x_ct_cbtecble_det
                        {
                            IdEmpresa_inv = IdEmpresa,
                            IdSucursal_inv = IdSucursal,
                            IdBodega_inv = IdBodega,
                            IdMovi_inven_tipo_inv = IdMovi_inven_tipo,
                            IdNumMovi_inv = IdNumMovi,
                            Secuencia_inv = item.Secuencia,
                            IdEmpresa_ct = diario.IdEmpresa,
                            IdTipoCbte_ct = diario.IdTipoCbte,
                            IdCbteCble_ct = diario.IdCbteCble,
                            secuencia_ct = secuencia++,
                            Secuencial_reg = secuencia_reg++,
                            observacion = "la cta se tomo de:" + (movimiento.cm_tipo == "-" ? "X_BODEGA" : "X_MOTIVO_INV")
                        });
                    }
                    diario.cb_Valor = Math.Abs(Math.Round(total,2,MidpointRounding.AwayFromZero));
                    db_ct.ct_cbtecble.Add(diario);

                    db_inv.in_movi_inve_x_ct_cbteCble.Add(new in_movi_inve_x_ct_cbteCble
                    {
                        IdEmpresa = IdEmpresa,
                        IdSucursal = IdSucursal,
                        IdBodega = IdBodega,
                        IdMovi_inven_tipo = IdMovi_inven_tipo,
                        IdNumMovi = IdNumMovi,
                        IdTipoCbte = diario.IdTipoCbte,
                        IdCbteCble = diario.IdCbteCble,
                        IdEmpresa_ct = diario.IdEmpresa,
                        Observacion = "Contabilización " + DateTime.Now.ToString()
                    });
                    #endregion
                

                db_ct.SaveChanges();
                db_inv.SaveChanges();

                db_ct.Dispose();
                db_inv.Dispose();
                db_gen.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                db_ct.Dispose();
                db_inv.Dispose();
                db_gen.Dispose();
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AprobarData(int IdEmpresa, int IdSucursal, int IdMoviInven_tipo, decimal IdNumMovi,string signo,string IdUsuario, ref string mensaje)
        {
            EntitiesInventario db_inv = new EntitiesInventario();
            try
            {
                #region Variables
                int secuencia = 1;
                decimal IdNumMovi_inv = 0;
                List<SecuencialHistorico> lst_secuencia = new List<SecuencialHistorico>();
                in_producto_x_tb_bodega_Costo_Historico costo_historico = new in_producto_x_tb_bodega_Costo_Historico();
                int secuencia_historico = 1;
                #endregion

                #region Obtengo detalle de movimiento
                var info_ing = db_inv.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMoviInven_tipo && q.IdNumMovi == IdNumMovi).FirstOrDefault();
                if (info_ing == null)
                {
                    mensaje = "El movimiento # " + IdNumMovi + " no existe";
                    return false;
                }
                int IdFecha = Convert.ToInt32(info_ing.cm_fecha.ToString("yyyyMMdd"));
                var e_motivo = db_inv.in_Motivo_Inven.Where(q => q.IdEmpresa == info_ing.IdEmpresa && q.IdMotivo_Inv == info_ing.IdMotivo_Inv).FirstOrDefault();
                if(e_motivo == null)
                {
                    mensaje = "El movimiento # " + IdNumMovi + " no tiene motivo para saber si debe o no mover inventario";
                    return false;
                }

                var e_ingegr = db_inv.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMoviInven_tipo && q.IdNumMovi == IdNumMovi && q.IdEstadoAproba == "PEND" && q.IdNumMovi_inv == null).ToList();
                if (e_ingegr.Count == 0)
                {
                    mensaje = "El movimiento # " + IdNumMovi + " no tiene detalles sin aprobación";
                    return false;
                }
                #endregion
                
                
                var bodegas = e_ingegr.GroupBy(q => q.IdBodega).Select(q=>q.Key).ToList();
                foreach (var i_IdBodega in bodegas)
                {
                    secuencia++;
                    #region Cabecera
                    if (e_motivo.Genera_Movi_Inven == "S")
                    {
                        db_inv.in_movi_inve.Add(new in_movi_inve
                        {
                            IdEmpresa = IdEmpresa,
                            IdSucursal = IdSucursal,
                            IdBodega = i_IdBodega,
                            IdMovi_inven_tipo = IdMoviInven_tipo,
                            IdNumMovi = IdNumMovi_inv = get_id(IdEmpresa, IdSucursal, i_IdBodega, IdMoviInven_tipo),
                            CodMoviInven = info_ing.CodMoviInven,
                            cm_tipo = info_ing.signo,
                            cm_observacion = info_ing.cm_observacion,
                            cm_fecha = info_ing.cm_fecha,
                            cm_anio = info_ing.cm_fecha.Year,
                            cm_mes = info_ing.cm_fecha.Month,
                            Estado = "A",
                            IdMotivo_Inv = info_ing.IdMotivo_Inv,
                            IdUsuario = IdUsuario,
                            Fecha_Transac = DateTime.Now
                        });
                    }
	                #endregion
                    #region Detalle
                    foreach (var det in e_ingegr.Where(q => q.IdBodega == i_IdBodega).ToList())
                    {
                        if (e_motivo.Genera_Movi_Inven == "S")
                        {
                            if (info_ing.signo == "-")
                            {
                                costo_historico = db_inv.in_producto_x_tb_bodega_Costo_Historico.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == i_IdBodega && q.IdProducto == det.IdProducto).OrderByDescending(q => q.fecha).FirstOrDefault();
                                det.mv_costo = costo_historico == null ? 0 : costo_historico.costo;
                            }
                            else
                            {
                                if (info_ing.signo == "+")
                                {
                                    if (lst_secuencia.Where(q => q.IdProducto == det.IdProducto).Count() > 0)
                                    {
                                        secuencia_historico = lst_secuencia.Max(q => q.Secuencia) + 1;
                                    }
                                    else
                                    {
                                        var secuencia_h = db_inv.in_producto_x_tb_bodega_Costo_Historico.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == i_IdBodega && q.IdProducto == det.IdProducto && q.IdFecha == IdFecha).ToList();
                                        if (secuencia_h.Count > 0)
                                            secuencia_historico = secuencia_h.Max(q => q.Secuencia) + 1;
                                    }                                    
                                    db_inv.in_producto_x_tb_bodega_Costo_Historico.Add(new in_producto_x_tb_bodega_Costo_Historico
                                    {
                                        IdEmpresa = IdEmpresa,
                                        IdSucursal = IdSucursal,
                                        IdBodega = i_IdBodega,
                                        IdProducto = det.IdProducto,
                                        IdFecha = IdFecha,
                                        Secuencia = secuencia_historico,
                                        fecha = info_ing.cm_fecha,
                                        costo = det.mv_costo,
                                        Stock_a_la_fecha = 0,
                                        Observacion = "NO VALIDO",
                                        fecha_trans = DateTime.Now
                                    });
                                    lst_secuencia.Add(new SecuencialHistorico { IdProducto = det.IdProducto, Secuencia = secuencia_historico });
                                }
                            }
                            db_inv.in_movi_inve_detalle.Add(new in_movi_inve_detalle
                            {
                                IdEmpresa = IdEmpresa,
                                IdSucursal = IdSucursal,
                                IdBodega = i_IdBodega,
                                IdMovi_inven_tipo = IdMoviInven_tipo,
                                IdNumMovi = IdNumMovi_inv,
                                Secuencia = secuencia,
                                mv_tipo_movi = info_ing.signo,
                                IdProducto = det.IdProducto,

                                dm_cantidad = odataUnidadMedida.GetCantidadConvertida(det.IdEmpresa, det.IdProducto, det.IdUnidadMedida_sinConversion, (det.dm_cantidad_sinConversion)),
                                dm_cantidad_sinConversion = det.dm_cantidad_sinConversion,
                                mv_costo = det.mv_costo,
                                mv_costo_sinConversion = det.mv_costo_sinConversion,
                                IdUnidadMedida = det.IdUnidadMedida,
                                IdUnidadMedida_sinConversion = det.IdUnidadMedida_sinConversion,

                                IdCentroCosto = det.IdCentroCosto,
                                IdCentroCosto_sub_centro_costo = det.IdCentroCosto_sub_centro_costo,
                                IdPunto_cargo = det.IdPunto_cargo,
                                IdPunto_cargo_grupo = det.IdPunto_cargo_grupo,
                                Costeado = false,
                                dm_stock_actu = 0,
                                dm_stock_ante = 0,
                                dm_observacion = ""
                            });
                            det.IdEmpresa_inv = IdEmpresa;
                            det.IdSucursal_inv = IdSucursal;
                            det.IdBodega_inv = i_IdBodega;
                            det.IdMovi_inven_tipo_inv = IdMoviInven_tipo;
                            det.IdNumMovi_inv = IdNumMovi_inv;
                            det.secuencia_inv = secuencia++;
                        }
                        det.IdEstadoAproba = "APRO";
                    }
                    #endregion
                    db_inv.SaveChanges();
                    if (e_motivo.Genera_Movi_Inven == "S")
                        ContabilizacionData(IdEmpresa, IdSucursal, i_IdBodega, IdMoviInven_tipo, IdNumMovi_inv, IdUsuario, ref mensaje);
                }
                db_inv.Dispose();
                return true;
            }
            catch (Exception)
            {
                db_inv.Dispose();
                throw;
            }
        }
    }


    public class SecuencialHistorico
    {
        public decimal IdProducto { get; set; }
        public int Secuencia { get; set; }
    }
}

