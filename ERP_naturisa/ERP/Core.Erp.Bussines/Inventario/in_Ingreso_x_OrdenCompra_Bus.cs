using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_Ingreso_x_OrdenCompra_Bus
    {

        in_Ingreso_x_OrdenCompra_Data odata = new in_Ingreso_x_OrdenCompra_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        string mensaje = "";


        Boolean Genera_Inventario(in_Ingreso_x_OrdenCompra_Info info, decimal IdIngreso_oc, ref string msg)
        {
            try
            {
                //graba inventario
                in_movi_inve_Info info_MoviInve = new in_movi_inve_Info();

                info_MoviInve.IdEmpresa = info.IdEmpresa;
                info_MoviInve.IdSucursal = info.IdSucursal;
                info_MoviInve.IdBodega = info.IdBodega;

                int Idtipo = 0;
                com_parametro_Data odataParam = new com_parametro_Data();
                com_parametro_Info list_parametro = new com_parametro_Info();

                list_parametro = odataParam.Get_Info_parametro(info.IdEmpresa);
                Idtipo = list_parametro.IdMovi_inven_tipo_OC;

                if (list_parametro == null)
                {
                    msg = "No existen parámetros de compras";
                    return false;
                }

                in_movi_inven_tipo_Info Info_moviInvTipo = new in_movi_inven_tipo_Info();
                in_movi_inven_tipo_Bus bus_moviInvTipo = new in_movi_inven_tipo_Bus();

                Info_moviInvTipo = bus_moviInvTipo.Get_Info_movi_inven_tipo(info.IdEmpresa, Idtipo);

                if (Info_moviInvTipo == null)
                {

                    msg = "No existen Tipos de Movimientos de Inventario";
                    return false;
                }

                info_MoviInve.IdMovi_inven_tipo = Info_moviInvTipo.IdMovi_inven_tipo;
                info_MoviInve.CodMoviInven = Info_moviInvTipo.Codigo;
                info_MoviInve.cm_tipo = Info_moviInvTipo.cm_tipo_movi;

                info_MoviInve.cm_observacion = info.Observacion;
                info_MoviInve.cm_fecha = info.Fecha_ing_bod;
                info_MoviInve.cm_anio = info.Fecha_ing_bod.Year;
                info_MoviInve.cm_mes = info.Fecha_ing_bod.Month;
                //info_MoviInve.IdCentroCosto = Convert.ToString(cmb_Centro_Costo.EditValue);
                //info_MoviInve.IdCentroCosto_sub_centro_costo = Convert.ToString(cmb_Sub_Centro_Costo.EditValue);
                info_MoviInve.IdProvedor = info.IdProveedor;

                //detalle
                List<in_movi_inve_detalle_Info> list_inveDet = new List<in_movi_inve_detalle_Info>();

                foreach (var item1 in info.listIngxOrdComDet)
                {
                    in_movi_inve_detalle_Info infoMovDet = new in_movi_inve_detalle_Info();

                    // infoMovDet.Checked = item.Checked;
                    infoMovDet.oc_IdEmpresa = item1.IdEmpresa_oc;
                    infoMovDet.oc_IdSucursal = item1.IdSucursal_oc;
                    infoMovDet.oc_IdOrdenCompra = item1.IdOrdenCompra;
                    // infoMovDet.oc_Secuencial = item1.secuencia_oc_det;
                    infoMovDet.oc_Secuencial = item1.Secuencia_oc;
                    infoMovDet.IdProducto = item1.IdProducto;
                    infoMovDet.dm_cantidad = item1.Cant_a_recibir;
                    infoMovDet.dm_stock_ante = item1.pr_stock;
                    infoMovDet.dm_stock_actu = item1.pr_stock + item1.Cant_a_recibir;
                    infoMovDet.oc_observacion = info_MoviInve.cm_observacion;
                    infoMovDet.dm_precio = item1.oc_precio;
                    infoMovDet.mv_costo = item1.oc_precio;// se coloca el costo de la OC de la columna precio de compra 
                    infoMovDet.peso = item1.pr_peso;
                    infoMovDet.IdCentroCosto = item1.IdCentroCosto;
                    infoMovDet.IdCentroCosto_sub_centro_costo = item1.IdCentroCosto_sub_centro_costo;
                    infoMovDet.nom_producto = item1.nom_producto;

                    list_inveDet.Add(infoMovDet);

                }

                info_MoviInve.listmovi_inve_detalle_Info = list_inveDet;

                //detalle

                in_movi_inve_Bus bus_MovInve = new in_movi_inve_Bus();
                decimal idMoviInven;
                idMoviInven = 0;
                string mensaje_cbte_cble = "";

                if (bus_MovInve.GrabarDB(info_MoviInve, ref idMoviInven, ref mensaje, ref mensaje_cbte_cble))
                {
                    //grabando tabla intermedia  in_movi_inve_detalle_x_com_ordencompra_local_det

                    #region grabando tabla intermedia  in_movi_inve_detalle_x_com_ordencompra_local_det

                    List<in_movi_inve_detalle_Info> listMovInvDet = new List<in_movi_inve_detalle_Info>();
                    in_movi_inve_detalle_Bus bus_MovInvDet = new in_movi_inve_detalle_Bus();
                    listMovInvDet = bus_MovInvDet.Get_list_Movi_inven_det(info_MoviInve.IdEmpresa, info_MoviInve.IdSucursal, info_MoviInve.IdBodega, info_MoviInve.IdMovi_inven_tipo, idMoviInven);

                    List<in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info> listIngComp = new List<in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info>();
                    List<in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info> listOrdComp = new List<in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info>();

                    in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info info1;

                    foreach (var item2 in listMovInvDet)
                    {
                        info1 = new in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info();

                        info1.mi_IdEmpresa = item2.IdEmpresa;
                        info1.mi_IdSucursal = item2.IdSucursal;
                        info1.mi_IdBodega = item2.IdBodega;
                        info1.mi_IdMovi_inven_tipo = item2.IdMovi_inven_tipo;
                        info1.mi_IdNumMovi = item2.IdNumMovi;
                        info1.mi_Secuencia = item2.Secuencia;

                        listIngComp.Add(info1);
                    }

                    //  foreach (var item in ListaBind)
                    foreach (var item3 in info_MoviInve.listmovi_inve_detalle_Info)
                    {
                        info1 = new in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info();

                        //if (item3.Checked == true)
                        //{
                        info1.ocd_IdEmpresa = item3.IdEmpresa;
                        info1.ocd_IdSucursal = item3.IdSucursal;
                        //  info1.ocd_IdOrdenCompra = item3.IdOrdenCompra;
                        info1.ocd_IdOrdenCompra = item3.oc_IdOrdenCompra;
                        info1.ocd_Secuencia = item3.oc_Secuencial;

                        listOrdComp.Add(info1);

                        //}


                    }

                    int ocd_IdEmpresa = 0;
                    int ocd_IdSucursal = 0;
                    decimal ocd_IdOrdenCompra = 0;
                    int ocd_Secuencia = 0;

                    foreach (var item4 in listIngComp)
                    {
                        var items = listOrdComp.First(v => v.mi_IdEmpresa == 0 && v.mi_IdSucursal == 0 && v.mi_IdBodega == 0 && v.mi_IdMovi_inven_tipo == 0 && v.mi_IdNumMovi == 0 && v.mi_Secuencia == 0);
                        ocd_IdEmpresa = items.ocd_IdEmpresa;
                        ocd_IdSucursal = items.ocd_IdSucursal;
                        ocd_IdOrdenCompra = items.ocd_IdOrdenCompra;
                        ocd_Secuencia = items.ocd_Secuencia;

                        listOrdComp.Remove(items);

                        item4.ocd_IdEmpresa = ocd_IdEmpresa;
                        item4.ocd_IdSucursal = ocd_IdSucursal;
                        item4.ocd_IdOrdenCompra = ocd_IdOrdenCompra;
                        item4.ocd_Secuencia = ocd_Secuencia;
                    }

                    in_movi_inve_detalle_x_com_ordencompra_local_detalle_Bus bus_Inter = new in_movi_inve_detalle_x_com_ordencompra_local_detalle_Bus();

                    if (bus_Inter.GrabarDB(listIngComp, ref mensaje))
                    {
                    }

                    // consulta grid contable

                    //info_InMovxCble = new in_movi_inve_x_ct_cbteCble_Info();
                    //info_InMovxCble = bus_InMovxCble.Obtener_x_Movi_Inven(Info_MoviInve.IdEmpresa, Info_MoviInve.IdSucursal, Info_MoviInve.IdBodega, Info_MoviInve.IdMovi_inven_tipo, idMoviInven);

                    //this.ucCon_GridDiarioContable1.setInfo(info_InMovxCble.IdEmpresa, info_InMovxCble.IdTipoCbte, info_InMovxCble.IdCbteCble);

                    #endregion

                    // actualizando los item de movimiento en tabla in_Ingreso_x_OrdenCompra

                    // consulta in_Ingreso_x_OrdenCompra
                    in_Ingreso_x_OrdenCompra_Info infoIngxComp = new in_Ingreso_x_OrdenCompra_Info();
                    infoIngxComp = odata.Get_Info_Ingreso_x_OrdenCompra(info.IdEmpresa, IdIngreso_oc);

                    // consulta in_movi_inve
                    in_movi_inve_Bus bus_MovInv = new in_movi_inve_Bus();
                    in_movi_inve_Info infoMovInv = new in_movi_inve_Info();
                    infoMovInv = bus_MovInv.Get_Info_Movi_inven(info_MoviInve.IdEmpresa, info_MoviInve.IdSucursal, info_MoviInve.IdBodega, info_MoviInve.IdMovi_inven_tipo, idMoviInven);

                    // actualizar item Movimientos en in_Ingreso_x_OrdenCompra

                    infoIngxComp.IdEmpresa_mIinv = infoMovInv.IdEmpresa;
                    infoIngxComp.IdSucursal_mInv = infoMovInv.IdSucursal;
                    infoIngxComp.IdBodega_mInv = infoMovInv.IdBodega;
                    infoIngxComp.IdMovi_inven_tipo_mInv = infoMovInv.IdMovi_inven_tipo;
                    infoIngxComp.IdNumMovi_mInv = infoMovInv.IdNumMovi;

                    string msgs = "";
                    // odata.ModificarCabecera(infoIngxComp, ref msgs);
                }

                else
                {
                    msg = mensaje + "-" + mensaje_cbte_cble;
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Genera_Inventario", ex.Message), ex) { EntityType = typeof(in_Ingreso_x_OrdenCompra_Bus) };

            }

        }


        public Boolean Validar_objeto_IngxComp(in_Ingreso_x_OrdenCompra_Info Info, ref string msg)
        {
            try
            {
                if (Info.IdEmpresa == 0)
                {
                    msg = "La variable IdEmpresa estan en cero... IdEmpresa == 0  ";
                    return false;
                }
                if (Info.IdProveedor == 0 || Info.IdProveedor == null)
                {
                    msg = "Ingrese el Proveedor ";
                    return false;
                }

                if (Info.IdMotivo == 0 || Info.IdMotivo == null)
                {
                    msg = "Ingrese el Motivo ";
                    return false;
                }

                if (Info.listIngxOrdComDet.Count == 0 || Info.listIngxOrdComDet.Count == null)
                {
                    msg = "No existen detalles a Grabar o No ha seleccionado algún item ";
                    return false;
                }


                if (Info.listIngxOrdComDet.Count != 0)
                {

                    foreach (var item in Info.listIngxOrdComDet)
                    {
                        if (item.IdMotivo_OC != Info.IdMotivo)
                        {
                            msg = "El item: " + item.nom_producto + " con Motivo: " + item.Nom_Motivo + " ,es diferente al Motivo escogido en los Datos Generales ";
                            return false;
                        }
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto_IngxComp", ex.Message), ex) { EntityType = typeof(in_Ingreso_x_OrdenCompra_Bus) };


            }

        }

        public List<in_Ingreso_x_OrdenCompra_Info> Get_List_Ingreso_x_OrdenCompra(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {

            try
            {
                return odata.Get_List_Ingreso_x_OrdenCompra(IdEmpresa, IdSucursal, IdBodega, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngxComp", ex.Message), ex) { EntityType = typeof(in_Ingreso_x_OrdenCompra_Bus) };

            }
        }


        public in_Ingreso_x_OrdenCompra_Info Get_Info_Ingreso_x_OrdenCompra(int IdEmpresa, decimal IdIngreso_x_oc)
        {
            try
            {
                return odata.Get_Info_Ingreso_x_OrdenCompra(IdEmpresa, IdIngreso_x_oc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_Info_IngxComp", ex.Message), ex) { EntityType = typeof(in_Ingreso_x_OrdenCompra_Bus) };

            }



        }


    }
}
