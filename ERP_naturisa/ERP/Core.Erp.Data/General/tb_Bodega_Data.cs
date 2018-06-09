using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_Bodega_Data
    {
        string mensaje = "";

        public List<tb_Bodega_Info> Get_List_Bodega(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<tb_Bodega_Info> lM = new List<tb_Bodega_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_bodega
                                where A.IdEmpresa==IdEmpresa && A.IdSucursal==IdSucursal
                                      select A;
                
                foreach (var item in select_pv)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.cod_bodega = item.cod_bodega;
                    info.bo_Descripcion = item.bo_Descripcion.Trim();
                    info.bo_Descripcion2 = "[" + item.IdBodega + "]-" + item.bo_Descripcion.Trim();
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.cod_punto_emision = item.cod_punto_emision;
                    info.bo_esBodega = item.bo_EsBodega;
                    info.bo_manejaFacturacion = item.bo_manejaFacturacion;
                    info.Estado = (item.Estado == "A") ? true : false;
                    info.IdEstadoAproba_x_Ing_Egr_Inven = item.IdEstadoAproba_x_Ing_Egr_Inven;

                    info.IdCtaCtble_Inve = item.IdCtaCtble_Inve;
                    info.IdCtaCtble_Costo = item.IdCtaCtble_Costo;


                    lM.Add(info);
                }
                return (lM);
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

        public List<tb_Bodega_Info> Get_List_Bodega(int idempresa, Cl_Enumeradores.eTipoFiltro TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal)
        {

            try
            {
                List<tb_Bodega_Info> lM = new List<tb_Bodega_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_bodega
                                join B in OEGeneral.tb_sucursal
                                on new { A.IdEmpresa, A.IdSucursal } equals new { B.IdEmpresa, B.IdSucursal }
                                where A.IdEmpresa == idempresa
                                select new
                                {
                                    A.IdEmpresa,
                                    A.IdBodega,
                                    A.IdSucursal,
                                    A.cod_bodega,
                                    A.bo_Descripcion,
                                    A.cod_punto_emision,
                                    A.bo_EsBodega,
                                    A.bo_manejaFacturacion,
                                    A.Estado,
                                    B.Su_Descripcion,
                                    A.IdCtaCtble_Costo,
                                    A.IdCtaCtble_Inve
                                };
                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.bo_Descripcion = "Todas";
                    info.bo_Descripcion2 = "Todas";
                    info.IdBodega = 0;
                    lM.Add(info);
                }
                foreach (var item in select_pv)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.cod_bodega = item.cod_bodega;
                    info.bo_Descripcion = item.bo_Descripcion.Trim();
                    info.cod_punto_emision = item.cod_punto_emision;
                    info.bo_esBodega = item.bo_EsBodega;
                    info.bo_manejaFacturacion = item.bo_manejaFacturacion;
                    info.Estado = (item.Estado == "A") ? true : false;
                    info.NomSucursal = item.Su_Descripcion.Trim();

                    info.IdCtaCtble_Inve = item.IdCtaCtble_Inve;
                    info.IdCtaCtble_Costo = item.IdCtaCtble_Costo;

                    lM.Add(info);
                }
                return (lM);
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

        public List<tb_Bodega_Info> Get_List_Bodegas_x_CentroCosto(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                List<tb_Bodega_Info> lM = new List<tb_Bodega_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_bodega
                                join B in OEGeneral.tb_sucursal
                                on new { A.IdEmpresa, A.IdSucursal } equals new { B.IdEmpresa, B.IdSucursal }
                                where A.IdEmpresa == IdEmpresa && A.IdCentroCosto == IdCentroCosto
                                select new
                                {
                                    A.IdEmpresa,
                                    A.IdBodega,
                                    A.IdSucursal,
                                    A.cod_bodega,
                                    A.bo_Descripcion,
                                    A.cod_punto_emision,
                                    A.bo_EsBodega,
                                    A.bo_manejaFacturacion,
                                    A.Estado,
                                    A.IdCentroCosto,
                                    B.Su_Descripcion,
                                    A.IdCtaCtble_Inve,
                                    A.IdCtaCtble_Costo
                                };

                foreach (var item in select_pv)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.cod_bodega = item.cod_bodega;
                    info.bo_Descripcion = item.bo_Descripcion.Trim();
                    info.cod_punto_emision = item.cod_punto_emision;
                    info.bo_esBodega = item.bo_EsBodega;
                    info.bo_manejaFacturacion = item.bo_manejaFacturacion;
                    info.Estado = (item.Estado == "A") ? true : false;
                    info.NomSucursal = item.Su_Descripcion.Trim();
                    info.IdCentroCosto = item.IdCentroCosto;

                    info.IdCtaCtble_Inve = item.IdCtaCtble_Inve;
                    info.IdCtaCtble_Costo = item.IdCtaCtble_Costo;

                    lM.Add(info);
                }
                return (lM);
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

        public tb_Bodega_Info Get_Info_Bodega(int IdEmpresa, int IdSucursal, int IdBodega)
        {

            try
            {
                tb_Bodega_Info bodega = new tb_Bodega_Info();
                EntitiesGeneral Oenti = new EntitiesGeneral();

                var bodegas = from bo in Oenti.tb_bodega
                              join su in Oenti.tb_sucursal
                              on new { bo.IdEmpresa, bo.IdSucursal } equals new { su.IdEmpresa, su.IdSucursal }
                              where bo.IdEmpresa == IdEmpresa
                              && bo.IdSucursal == IdSucursal
                              && bo.IdBodega == IdBodega
                              select new
                              {
                                  bo.IdEmpresa,
                                  bo.IdBodega,
                                  bo.IdSucursal,
                                  bo.cod_bodega,
                                  bo.bo_Descripcion,
                                  su.Su_Descripcion,
                                  bo.cod_punto_emision,
                                  bo.IdCtaCtble_Inve,
                                  bo.IdCtaCtble_Costo
                              };
                foreach (var bod in bodegas)
                {
                    bodega.IdEmpresa = bod.IdEmpresa;
                    bodega.IdBodega = bod.IdBodega;
                    bodega.IdSucursal = bod.IdSucursal;
                    bodega.cod_bodega = bod.cod_bodega;
                    bodega.bo_Descripcion = bod.bo_Descripcion;
                    bodega.NomSucursal = bod.Su_Descripcion;
                    bodega.cod_punto_emision = bod.cod_punto_emision;

                    bodega.IdCtaCtble_Inve = bod.IdCtaCtble_Inve;
                    bodega.IdCtaCtble_Costo = bod.IdCtaCtble_Costo;

                }
                return bodega;
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

        public string Get_cod_pto_emision_x_Bodega(int IdEmpresa, int IdSucursal, int IdBodega)
        {

            try
            {
                string cod_pto_emision = "";

                EntitiesGeneral Oenti = new EntitiesGeneral();

                var bodegas = from bo in Oenti.tb_bodega
                              where bo.IdEmpresa == IdEmpresa
                              && bo.IdSucursal == IdSucursal
                              && bo.IdBodega == IdBodega
                              select bo;

                              
                foreach (var bod in bodegas)
                {
                    cod_pto_emision = bod.cod_punto_emision;
                }
                return cod_pto_emision;
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

        public Boolean ModificarDB(tb_Bodega_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {

                    var selecte = context.tb_bodega.Count(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega==info.IdBodega);

                    if (selecte == 0)
                    {

                        tb_Sucursal_Data odata = new tb_Sucursal_Data();
                        List<tb_Sucursal_Info> listaSu = new List<tb_Sucursal_Info>();
                        listaSu = odata.Get_List_Sucursal(info.IdEmpresa);

                        tb_Sucursal_Info infoSu = new tb_Sucursal_Info();
                        infoSu = listaSu.FirstOrDefault(q=> q.IdEmpresa==info.IdEmpresa && q.IdSucursal==info.IdSucursal);

                        msg = "La Sucursal : " + infoSu.Su_Descripcion + " no tiene bodega creada";
                        return false;
                    }

                    else
                    {

                        var contact = context.tb_bodega.First(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega);
                        if (info.Estado == false)
                        {
                            if (VerificarSiBodegaTieneMovimientos(info, ref msg))
                            {
                                return false;
                            }
                        }

                        contact.bo_Descripcion = info.bo_Descripcion;
                        contact.cod_punto_emision = info.cod_punto_emision;
                        contact.bo_EsBodega = info.bo_esBodega;
                        contact.bo_manejaFacturacion = info.bo_manejaFacturacion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.Estado = (info.Estado == true) ? "A" : "I";
                        contact.IdEstadoAproba_x_Ing_Egr_Inven = info.IdEstadoAproba_x_Ing_Egr_Inven;

                        contact.IdCtaCtble_Inve = (info.IdCtaCtble_Inve == "") ? null : info.IdCtaCtble_Inve;
                        contact.IdCtaCtble_Costo = (info.IdCtaCtble_Costo == "") ? null : info.IdCtaCtble_Costo;


                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la Bodega #: " + info.IdBodega.ToString() + " exitosamente";

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
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int getId(int idempresa,int idsucursal )
        {
            int Id=0;
            try
            {
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var select = from q in OEGeneral.tb_bodega
                             where q.IdEmpresa ==idempresa 
                             && q.IdSucursal ==idsucursal 
                             select q;

                if (select.ToList().Count <1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEGeneral.tb_bodega
                                     where q.IdEmpresa == idempresa
                                     select q.IdBodega).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
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

        public Boolean Grabar_Lista(List<tb_Bodega_Info> lista_nueva, List<tb_Bodega_Info> lista_antigua, ref string msg)
        {
            try
            {
                //eliminamos la lista antigua de los puntos de ventas
                foreach (var item in lista_antigua)
                {
                    //EliminarDB(
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
                 msg = "Se ha producido el siguiente error: " + ex.Message;
                 throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(tb_Bodega_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {

                    var address = new tb_bodega();
                    int idpv = getId(info.IdEmpresa,info.IdSucursal );
                    id = idpv;
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal; 
                    address.IdBodega = idpv;
                    address.bo_Descripcion = info.bo_Descripcion;
                    address.cod_punto_emision = info.cod_punto_emision;
                    address.IdCentroCosto = info.IdCentroCosto;
                    address.bo_EsBodega = "S";
                    address.bo_manejaFacturacion=info.bo_manejaFacturacion;
                    address.IdUsuario=info.IdUsuario;
                    address.Fecha_Transac=info.Fecha_Transac;
                    address.nom_pc=info.nom_pc;
                    address.ip=info.ip;
                    address.Estado = "A";
                    address.IdEstadoAproba_x_Ing_Egr_Inven = info.IdEstadoAproba_x_Ing_Egr_Inven;

                    address.IdCtaCtble_Inve = (info.IdCtaCtble_Inve == "") ? null : info.IdCtaCtble_Inve;
                    address.IdCtaCtble_Costo = (info.IdCtaCtble_Costo == "") ? null : info.IdCtaCtble_Costo;



                    context.tb_bodega.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro de la Bodega #: " + id.ToString() + " exitosamente.";
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
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificarSiBodegaTieneMovimientos(tb_Bodega_Info info, ref  string msg) 
        {
            try
            {
                using (EntitiesInventario entitie = new EntitiesInventario())
                    {
                        int cantidad = entitie.in_movi_inve.Count(v => v.IdEmpresa == info.IdEmpresa && v.IdSucursal == info.IdSucursal && v.IdBodega == info.IdBodega);
                        if (cantidad != 0)
                        {
                            msg = "No se puede anular bodega debido a que tiene movimientos";
                            return true;
                        }
                        else
                        {
                            {
                                return false;
                            }
                        }
                    }
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

        public Boolean EliminarDB(tb_Bodega_Info info, ref  string msg)
        {
            try
            {
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                if(VerificarSiBodegaTieneMovimientos(info, ref msg))
                {
                    
                    return false;
                }
              
                var select = from q in OEGeneral.tb_bodega
                             where q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega==info.IdBodega
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesGeneral context = new EntitiesGeneral())
                    {
                        var contact = context.tb_bodega.First(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega);
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.Estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro de la Bodega #: " + info.IdBodega.ToString() + " exitosamente";
                    }

                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Punto de Venta #: " + info.IdBodega.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Bodega_Data() { }
    }
}
