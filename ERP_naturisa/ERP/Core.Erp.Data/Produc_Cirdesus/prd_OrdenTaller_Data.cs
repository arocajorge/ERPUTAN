using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_OrdenTaller_Data
    {
        string mensaje = "";
        public List<prd_OrdenTaller_Info> ObtenerListaOT(int idempresa)
        {
            try
            {
                List<prd_OrdenTaller_Info> lm = new List<prd_OrdenTaller_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.vwprd_OrdenTaller
                                where A.IdEmpresa == idempresa
                                orderby A.NumeroOT
                                select A;
                foreach (var item in registros)
                {
                    prd_OrdenTaller_Info info = new prd_OrdenTaller_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.CodObra = item.CodObra;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProducto = item.IdProducto;
                    info.NumeroOT = item.NumeroOT;
                    info.CantidadPieza = item.CantidadPieza;
                    info.TotalPeso = item.TotalPeso;
                    info.Estado = item.Estado;
                    info.Observacion = item.Observacion;
                    info.PesoUnitario = item.PesoUnitaro;
                    info.Codigo = item.Codigo;
                    info.FechaReg = item.ot_FechaReg;
                    info.CodObra = item.CodObra;
                    info.ob_descripcion = item.ob_descripcion;
                    info.NomProducto = item.pr_descripcion;
                    info.Referencia = "[" + item.CodObra.Trim() + "]" + " - " + item.ob_descripcion.Trim();
                    info.NomSucursal = item.Su_Descripcion;
                    info.ca_categorias = item.ca_Categoria;
                    info.IdCliente = item.IdCliente;
                    info.IdListadoDiseno = item.IdListadoDiseno;
                    info.LongitudUnitaria = Convert.ToDecimal(item.longitudProducto);
                    info.TotalLongitud = item.TotalLongitud;
                    info.IdListadoDiseno = item.IdListadoDiseno;
                    info.ListadoDiseno = item.lm_Observacion;
                    lm.Add(info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_OrdenTaller_Info> ObtenerListaOT_x_Obra(int idempresa, string CodObra)
        {
            try
            {
                List<prd_OrdenTaller_Info> lm = new List<prd_OrdenTaller_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.vwprd_OrdenTaller
                                where A.IdEmpresa == idempresa && A.CodObra == CodObra
                                orderby A.NumeroOT
                                select A;
                foreach (var item in registros)
                {
                    prd_OrdenTaller_Info info = new prd_OrdenTaller_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.CodObra = item.CodObra;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProducto = item.IdProducto;
                    info.NumeroOT = item.NumeroOT;
                    info.CantidadPieza = item.CantidadPieza;
                    info.TotalPeso = item.TotalPeso;
                    info.Estado = item.Estado;
                    info.Observacion = item.Observacion;
                    info.PesoUnitario = item.PesoUnitaro;
                    info.Codigo = item.Codigo;
                    info.FechaReg = item.ot_FechaReg;
                    info.CodObra = item.CodObra;
                    info.ob_descripcion = item.ob_descripcion;
                    info.NomProducto = item.pr_descripcion;
                    info.Referencia = "[" + item.CodObra.Trim() + "]" + " - " + item.ob_descripcion.Trim();
                    info.NomSucursal = item.Su_Descripcion;
                    info.ca_categorias = item.ca_Categoria;
                    info.IdCliente = item.IdCliente;
                    info.IdListadoDiseno = item.IdListadoDiseno;
                    info.ListadoDiseno = item.lm_Observacion;
                    info.LongitudUnitaria = Convert.ToDecimal(item.longitudProducto);
                    info.TotalLongitud = item.TotalLongitud;

                    lm.Add(info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        public List<prd_OrdenTaller_Info> ObtenerListaOT_x_CentroCosto(int idempresa, string IdCentroCosto)
        {
            try
            {
                List<prd_OrdenTaller_Info> lm = new List<prd_OrdenTaller_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.vwprd_OrdenTaller
                                where A.IdEmpresa == idempresa && A.CodObra == IdCentroCosto
                                orderby A.NumeroOT
                                select A;
                foreach (var item in registros)
                {
                    prd_OrdenTaller_Info info = new prd_OrdenTaller_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.CodObra = item.CodObra;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProducto = item.IdProducto;
                    info.NumeroOT = item.NumeroOT;
                    info.CantidadPieza = item.CantidadPieza;
                    info.TotalPeso = item.TotalPeso;
                    info.Estado = item.Estado;
                    info.Observacion = item.Observacion;
                    info.Codigo = item.Codigo;
                    info.PesoUnitario = item.PesoUnitaro;
                    info.FechaReg = item.ot_FechaReg;
                    info.CodObra = item.CodObra;
                    info.ob_descripcion = item.ob_descripcion;
                    info.NomProducto = item.pr_descripcion;
                    info.ca_categorias = item.ca_Categoria;

                    info.LongitudUnitaria = Convert.ToDecimal(item.longitudProducto);
                    info.TotalLongitud = item.TotalLongitud;

                    info.Referencia = "[" + item.CodObra.Trim() + "]" + " - " + item.ob_descripcion.Trim();

                    lm.Add(info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public prd_OrdenTaller_Info ObtenerUnaOT(int IdEmpresa, int IdSucursal, decimal IdOrdenTaller, string CodObra)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var registros = from A in OEProduccion.vwprd_OrdenTaller
                                where A.IdEmpresa == IdEmpresa 
                                && A.IdSucursal==IdSucursal 
                                && A.IdOrdenTaller == IdOrdenTaller
                                && A.CodObra == CodObra
                                select A;
                if (registros.ToList().Count > 0)
                {
                    prd_OrdenTaller_Info info = new prd_OrdenTaller_Info();
                    foreach (var item in registros)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.CodObra = item.CodObra;
                        info.IdOrdenTaller = item.IdOrdenTaller;
                        info.IdProducto = item.IdProducto;
                        info.NumeroOT = item.NumeroOT;
                        info.CantidadPieza = item.CantidadPieza;
                        info.TotalPeso = item.TotalPeso;
                        info.Estado = item.Estado;
                        info.Observacion = item.Observacion;
                        info.PesoUnitario = item.PesoUnitaro;
                        info.Codigo = item.Codigo;
                        info.FechaReg = item.ot_FechaReg;
                        info.CodObra = item.CodObra;
                        info.ob_descripcion = item.ob_descripcion;
                        info.NomProducto = item.pr_descripcion;
                        info.NomSucursal = item.Su_Descripcion;
                        info.LongitudUnitaria = Convert.ToDecimal(item.longitudProducto);
                        info.TotalLongitud = item.TotalLongitud;

                    }
                    return info;
                }
                else
                    return new prd_OrdenTaller_Info();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_OrdenTaller_Info> ObtenerOrdenesTaller_x_GrupoTrabajoCab_x_CentroCosto(int idempresa, string CodObra, decimal IdGrupoTrabajo)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                List<prd_OrdenTaller_Info> lM = new List<prd_OrdenTaller_Info>();
                //var select = from C in OEProduccion.vwprd_GrupoTrabajoCab
                //             join B in OEProduccion.vwprd_OrdenTaller
                //             on new { C.IdEmpresa, C.IdSucursal,  } equals new { B.IdEmpresa, B.IdSucursal, B.IdOrdenTaller }
                //             where C.IdEmpresa == idempresa && C.CodObra == CodObra && C.IdGrupoTrabajo == IdGrupoTrabajo
                //             orderby C.IdOrdenTaller ascending
                //             select new
                //             {

                //                 B.IdEmpresa,
                //                 B.IdSucursal,
                //                 B.CodObra,
                //                 B.IdProducto,
                //                 B.CantidadPieza,
                //                 B.Estado,
                //                B.Su_Descripcion,
                //                 B.ob_descripcion,
                //                 B.IdOrdenTaller,
                //                 B.pr_descripcion,
                //                 B.NumeroOT,
                //                 B.Observacion,
                //                 B.TotalPeso,
                //                 B.PesoUnitaro,
                //                 B.Codigo
                //             };

                //foreach (var item in select)
                //{
                //    prd_OrdenTaller_Info info = new prd_OrdenTaller_Info();
                //    info.IdEmpresa = item.IdEmpresa;
                //    info.IdSucursal = item.IdSucursal;
                //    info.CodObra = item.CodObra;
                //    info.IdOrdenTaller = item.IdOrdenTaller;
                //    info.IdProducto = item.IdProducto;
                //    info.NumeroOT = item.NumeroOT;
                //    info.CantidadPieza = item.CantidadPieza;
                //    info.TotalPeso = item.TotalPeso;
                //    info.Estado = item.Estado;
                //    info.Observacion = item.Observacion;
                //    info.Codigo = item.Codigo;
                //    info.PesoUnitario = item.PesoUnitaro;
                //    info.NomSucursal = item.Su_Descripcion;
                //    info.CodObra = item.CodObra;
                //    info.ob_descripcion = item.ob_descripcion;
                //    info.NomProducto = item.pr_descripcion;
                //    lM.Add(info);
                //}
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public int ObtenerIDOrdenTaller(int idempresa, int IdSucursal, string CodObra, ref string msg)
        {
            try
            {
                int Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_Orden_Taller
                             where q.IdEmpresa == idempresa 
                             && q.IdSucursal == IdSucursal 
                             && q.CodObra == CodObra
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_Orden_Taller
                                     where q.IdEmpresa == idempresa 
                                     && q.IdSucursal == IdSucursal 
                                     && q.CodObra == CodObra
                                     select q.IdOrdenTaller).Max();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public decimal getNumDoc(int idempresa, int IdSucursal)
        {
            try
            {
                decimal Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_Orden_Taller
                             where q.IdEmpresa == idempresa 
                             && q.IdSucursal == IdSucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_Orden_Taller
                                     where q.IdEmpresa == idempresa 
                                     && q.IdSucursal == IdSucursal
                                     select q.IdOrdenTaller).Max();
                    Id = Convert.ToDecimal(select_pv.ToString()) + 1;
                }
                return Id;
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

        public Boolean VerificarCodigo(string NumDoc)
        {

            try
            {
                EntitiesProduccion_Cidersus oen = new EntitiesProduccion_Cidersus();

                var select = from q in oen.prd_Orden_Taller
                             where q.Codigo == NumDoc
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
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(int idempresa, prd_OrdenTaller_Info info, ref string msg, ref decimal idgenerada, ref string numDoc)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var address = new prd_Orden_Taller();
                    idgenerada =  getNumDoc(idempresa, info.IdSucursal);
                    
                    address.IdEmpresa = idempresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdOrdenTaller = idgenerada;
                    address.CodObra = info.CodObra;
                    //Para pasarla al winform
                    address.IdCliente = info.IdCliente;
                    address.IdProducto = info.IdProducto;
                    //address.NumeroOT = idgenerada;
                    address.TotalPeso = info.TotalPeso;
                    address.Estado = info.Estado;
                    address.FechaReg = info.FechaReg;
                    address.CantidadPieza = info.CantidadPieza;

                    address.LongitudUnitaria = info.LongitudUnitaria;
                    address.TotalLongitud = info.TotalLongitud;
                    address.IdListadoDiseno = info.IdListadoDiseno;
                    address.Observacion = info.Observacion;
                    address.PesoUnitaro = info.PesoUnitario;
                    if (info.Codigo == string.Empty)
                        info.Codigo = idgenerada.ToString("00");
                    while ((VerificarCodigo(info.Codigo)))
                    {
                        info.Codigo = info.Codigo + "-0";
                    }
                        
                    address.Codigo = info.Codigo;
                    numDoc = address.Codigo;

                    context.prd_Orden_Taller.Add(address);
                    context.SaveChanges();
                }
                msg = "Se ha generado la Orden de Taller # " + numDoc + " exitosamente";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(int idempresa, prd_OrdenTaller_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_Orden_Taller.FirstOrDefault(obj => obj.IdEmpresa == idempresa && obj.IdSucursal == info.IdSucursal && obj.CodObra == info.CodObra && obj.IdOrdenTaller == info.IdOrdenTaller);
                    if (contact != null)
                    {
                        contact.IdEmpresa = idempresa;
                        contact.IdSucursal = info.IdSucursal;
                        contact.CodObra = info.CodObra;
                        contact.IdOrdenTaller = info.IdOrdenTaller;
                        contact.IdProducto = info.IdProducto;
                        contact.NumeroOT = info.NumeroOT;
                        contact.TotalPeso = info.TotalPeso;

                        contact.LongitudUnitaria = info.LongitudUnitaria;
                        contact.TotalLongitud = info.TotalLongitud;

                        contact.Estado = info.Estado;
                        contact.FechaReg = info.FechaReg;
                        contact.CantidadPieza = info.CantidadPieza;
                        contact.Observacion = info.Observacion;
                        contact.PesoUnitaro = info.PesoUnitario;
                        contact.Codigo = info.Codigo;
                        contact.IdCliente = info.IdCliente;
                        contact.IdListadoDiseno = info.IdListadoDiseno;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la Orden de Taller #: " + info.Codigo + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Anular(int idempresa, prd_OrdenTaller_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_Orden_Taller.FirstOrDefault(A => A.IdEmpresa == idempresa && A.IdSucursal == info.IdSucursal && A.IdOrdenTaller == info.IdOrdenTaller && A.CodObra == info.CodObra);
                    if (contact != null)
                    {
                        contact.Estado = info.Estado;
                        context.SaveChanges();
                        msg = "Se Cambio el estado de la Orden de Taller :" + info.Codigo.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_OrdenTaller_Info> GetLisOrdenTaller(int idempresa,int IdSucursal,string CodObra)
        {
            try
            {
                List<prd_OrdenTaller_Info> lm = new List<prd_OrdenTaller_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.prd_Orden_Taller
                                where A.IdEmpresa == idempresa
                                && A.CodObra==CodObra
                                && A.IdSucursal==IdSucursal
                                orderby A.NumeroOT
                                select A;
                foreach (var item in registros)
                {
                    prd_OrdenTaller_Info info = new prd_OrdenTaller_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.CodObra = item.CodObra;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProducto = item.IdProducto;
                    info.NumeroOT = item.NumeroOT;
                    info.CantidadPieza = item.CantidadPieza;
                    info.TotalPeso = item.TotalPeso;
                    info.Estado = item.Estado;
                    info.Observacion = item.Observacion;
                    info.PesoUnitario = item.PesoUnitaro;
                    info.Codigo = item.Codigo;
                    lm.Add(info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
