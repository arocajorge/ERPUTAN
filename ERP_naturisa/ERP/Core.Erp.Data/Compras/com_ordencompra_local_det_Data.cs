using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Objects;
using System.Data.Entity;
using System.Data.EntityModel;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Info.General;

using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Compras
{
    public class com_ordencompra_local_det_Data
    {
        string mensaje = "";
        
        public Boolean GuardarDB(List<com_ordencompra_local_det_Info> LstInfo, ref string msg)
        {
            try
            {
                int sec = 0;
                foreach (var item in LstInfo)
                {
                    using (EntitiesCompras Context = new EntitiesCompras())
                    {
                        sec = sec + 1;
                        var Address = new com_ordencompra_local_det();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;
                        Address.IdOrdenCompra = item.IdOrdenCompra;
                        Address.Secuencia = sec; 
                        Address.IdProducto = item.IdProducto;
                        Address.do_Cantidad = item.do_Cantidad;
                        Address.do_precioCompra = item.do_precioCompra;
                        Address.do_porc_des = item.do_porc_des;
                        Address.do_descuento = item.do_descuento;
                        Address.do_precioFinal = item.do_precioFinal;
                        Address.do_subtotal = item.do_subtotal;
                        Address.do_iva = item.do_iva;
                        Address.do_total = item.do_total;
                        Address.do_ManejaIva = true;
                        Address.do_Costeado = (item.do_Costeado == null) ? "N" : item.do_Costeado;
                        Address.do_peso = item.do_peso;
                        Address.do_observacion = item.do_observacion == null ? "" : item.do_observacion;
                        Address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        Address.IdPunto_cargo = item.IdPunto_cargo == 0 ? null : item.IdPunto_cargo;
                        Address.IdCentroCosto = item.IdCentroCosto;
                        Address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Address.IdUnidadMedida = item.IdUnidadMedida;
                        Address.Por_Iva = item.Por_Iva;
                        Address.IdCod_Impuesto = (item.IdCod_Impuesto == null || item.IdCod_Impuesto == "") ? "IVA12" : item.IdCod_Impuesto;
                        Context.com_ordencompra_local_det.Add(Address);
                        Context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString()); 
            }
        }

        public int  GetId()
        {
            try
            {
                int Id;
                EntitiesCompras OECompras = new EntitiesCompras();
                var select = from q in OECompras.com_ordencompra_local_det
                             select q;

                if (select == null)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.com_ordencompra_local_det
                                     select q.Secuencia).Max();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
                List<com_ordencompra_local_det_Info> Lst = new List<com_ordencompra_local_det_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var Query = from q in oEnti.vwcom_ordencompra_local_det
                            where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal &&
                            q.IdOrdenCompra == IdOrdenCompra
                            select q;
                foreach (var item in Query)
                {
                    com_ordencompra_local_det_Info Obj = new com_ordencompra_local_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.do_Cantidad = item.do_Cantidad;
                    Obj.do_precioCompra = item.do_precioCompra;
                    Obj.do_porc_des = item.do_porc_des;
                    Obj.do_descuento = item.do_descuento;
                    Obj.do_precioFinal = item.do_precioFinal;
                    Obj.do_subtotal = item.do_subtotal;
                    Obj.do_iva = item.do_iva;
                    Obj.do_total = item.do_total;
                    //Obj.do_ManejaIva = item.do_ManejaIva;
                    Obj.do_Costeado = item.do_Costeado;
                    Obj.do_peso = item.do_peso;
                    Obj.do_observacion = item.do_observacion;
                    Obj.Tiene_despacho = "N";
                    Obj.Tiene_Movi_Inven = "S";
                    Obj.Esta_en_base = "S";

                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.Por_Iva = item.Por_Iva;

                    Obj.IdCod_Impuesto = item.IdCod_Impuesto;

                    if (item.IdCentroCosto_sub_centro_costo != null)
                    {
                        Obj.Nomsub_centro_costo = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.nom_sub_centro_costo.Trim();
                    }

                    Obj.IdUnidadMedida = item.IdUnidadMedida;

                    Obj.oc_fecha = item.oc_fecha;
                    Obj.oc_observacion = item.oc_observacion;
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.Idmotivo = item.IdMotivo;
                    Obj.nom_motivo_OC = item.nom_motivo_OC;

                    Obj.producto = item.pr_descripcion;
                    Obj.Nom_UnidadMedida = item.nom_medida;
                    Obj.IdUnidadMedida_x_prod = item.IdUnidadMedida_Consumo;
                    Obj.Referencia = "Sucursal : " + item.Su_Descripcion + " con Orden de Compra #: " + item.IdOrdenCompra + " y Fecha: " + item.oc_fecha + " , Observación: " + item.oc_observacion + " y Motivo: " + item.nom_motivo_OC;
                    

                    Lst.Add(Obj);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det(int IdEmpresa)
        {
            List<com_ordencompra_local_det_Info> Lst = new List<com_ordencompra_local_det_Info>();
            EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var Query = from q in oEnti.vwcom_ordencompra_local_det
                            where q.IdEmpresa == IdEmpresa 
                            select q;

                foreach (var item in Query)
                {
                    com_ordencompra_local_det_Info Obj = new com_ordencompra_local_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.do_Cantidad = item.do_Cantidad;
                    Obj.do_precioCompra = item.do_precioCompra;
                    Obj.do_porc_des = item.do_porc_des;
                    Obj.do_descuento = item.do_descuento;
                    Obj.do_precioFinal = item.do_precioFinal;
                    Obj.do_subtotal = item.do_subtotal;
                    Obj.do_iva = item.do_iva;
                    Obj.do_total = item.do_total;
                    //Obj.do_ManejaIva = item.do_ManejaIva;
                    Obj.do_Costeado = item.do_Costeado;
                    Obj.do_peso = item.do_peso;
                    Obj.do_observacion = item.do_observacion;
                    Obj.Tiene_despacho = "N";
                    Obj.Tiene_Movi_Inven = "S";
                    Obj.Esta_en_base = "S";

                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    if (item.IdCentroCosto_sub_centro_costo != null &&  item.nom_sub_centro_costo!=null)
                    {
                        Obj.Nomsub_centro_costo = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.nom_sub_centro_costo.Trim();
                    }

                    Obj.IdUnidadMedida = item.IdUnidadMedida;

                    Obj.oc_fecha = item.oc_fecha;
                    Obj.oc_observacion = item.oc_observacion;
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.Idmotivo = item.IdMotivo;
                    Obj.nom_motivo_OC = item.nom_motivo_OC;

                    Obj.producto = item.pr_descripcion;
                    Obj.Nom_UnidadMedida = item.nom_medida;

                    Obj.Referencia = "Sucursal : " + item.Su_Descripcion + " con Orden de Compra #: " + item.IdOrdenCompra + " y Fecha: " + item.oc_fecha + " , Observación: " + item.oc_observacion + " y Motivo: " + item.nom_motivo_OC;

                    Obj.Por_Iva = item.Por_Iva;
                    Obj.IdCod_Impuesto = item.IdCod_Impuesto;

                    Lst.Add(Obj);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det_Agrupado(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            List<com_ordencompra_local_det_Info> Lst = new List<com_ordencompra_local_det_Info>();
            EntitiesCompras oEnti = new EntitiesCompras();
            try
            {             
                var Query = from q in oEnti.com_ordencompra_local_det
                             where q.IdEmpresa == IdEmpresa
                           && q.IdSucursal == IdSucursal
                           && q.IdOrdenCompra == IdOrdenCompra


                             group q by new { q.IdEmpresa, q.IdSucursal, q.IdOrdenCompra } into g
                             select new
                             {
                                 IdEmpresa = g.Key.IdEmpresa,
                                 IdSucursal = g.Key.IdSucursal,
                                 IdOrdenCompra = g.Key.IdOrdenCompra,
                                 cant_tot_det = g.Sum(x => x.do_Cantidad)
                             };

                foreach (var item in Query)
                {
                    com_ordencompra_local_det_Info Obj = new com_ordencompra_local_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.do_Cantidad = item.cant_tot_det;
                    Lst.Add(Obj);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public com_ordencompra_local_det_Info Get_Info_ordencompra_local_det(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int secuencia)
        {
                EntitiesCompras oEnti = new EntitiesCompras();
                com_ordencompra_local_det_Info Obj = new com_ordencompra_local_det_Info();
            try
            {

                var Query = from q in oEnti.com_ordencompra_local_det
                            where q.IdEmpresa == IdEmpresa 
                            && q.IdSucursal == IdSucursal 
                            && q.IdOrdenCompra == IdOrdenCompra
                            && q.Secuencia == secuencia
                            select q;
                foreach (var item in Query)
                {
                   
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.do_Cantidad = item.do_Cantidad;
                    Obj.do_precioCompra = item.do_precioCompra;
                    Obj.do_porc_des = item.do_porc_des;
                    Obj.do_descuento = item.do_descuento;
                    Obj.do_precioFinal = item.do_precioFinal;
                    Obj.do_subtotal = item.do_subtotal;
                    Obj.do_iva = item.do_iva;
                    Obj.do_total = item.do_total;
                    //Obj.do_ManejaIva = item.do_ManejaIva;
                    Obj.do_Costeado = item.do_Costeado;
                    Obj.do_peso = item.do_peso;
                    Obj.do_observacion = item.do_observacion;

                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.IdUnidadMedida = item.IdUnidadMedida;


                    Obj.Por_Iva = item.Por_Iva;
                    Obj.IdCod_Impuesto = item.IdCod_Impuesto;
                }
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Eliminarregistrotabla(List<com_ordencompra_local_det_Info> lmDetalleInfo, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {

                    foreach (var item in lmDetalleInfo)
                    {
                        var address = context.com_ordencompra_local_det.FirstOrDefault(A => A.IdEmpresa == item.IdEmpresa
                            && A.IdSucursal == item.IdSucursal && A.IdOrdenCompra == item.IdOrdenCompra
                            && A.Secuencia == item.Secuencia);

                        if (address != null)
                        {
                            context.com_ordencompra_local_det.Remove(address);
                            context.SaveChanges();
                        }
                    }
                }
                msg = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(ex.ToString());
            }


        }

        public Boolean EliminarDetalle_OC(int IdEmpresa ,int IdSucursal,decimal IdOrdenCompra , ref string msg)
        {
            try
            {

                 using (EntitiesCompras Entity = new EntitiesCompras())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete from com_ordencompra_local_det where IdEmpresa = " + IdEmpresa
                        + " and IdSucursal = " + IdSucursal
                        + " and IdOrdenCompra = " + IdOrdenCompra
                        );               
                }            
                msg = "Guardado con éxito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();

                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det_x_Proveedor(int IdEmpresa, int IdSucursal, decimal IdProveedor)
        {
                List<com_ordencompra_local_det_Info> Lst = new List<com_ordencompra_local_det_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {

                var Query = from det in oEnti.com_ordencompra_local_det
                            join cab in oEnti.com_ordencompra_local
                            on new { det.IdEmpresa, det.IdOrdenCompra } equals new { cab.IdEmpresa, cab.IdOrdenCompra }
                            where cab.IdProveedor == IdProveedor
                            && det.IdEmpresa == IdEmpresa
                            && det.IdSucursal == IdSucursal
                            select new
                            {
                                det.IdOrdenCompra,
                                det.IdEmpresa,
                                det.IdProducto,
                                det.IdSucursal,
                                det.do_Cantidad

                            };

                foreach (var item in Query)
                {
                    com_ordencompra_local_det_Info Obj = new com_ordencompra_local_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.IdProducto = item.IdProducto;
                    Obj.do_Cantidad = item.do_Cantidad;

                    Lst.Add(Obj);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_det_Info> Get_List_ordencompra_local_det_x_Saldos_x_Proveedor(int IdEmpresa, int IdSucursal, decimal IdProveedor)
        {
                List<com_ordencompra_local_det_Info> Lst = new List<com_ordencompra_local_det_Info>();
                EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
             try
             {             

                var Select = from det in oEnti.vwcom_OC_local_det_x_MoviInven_SaldoItem_x_Obra_x_OT 
                             where det.IdEmpresa == IdEmpresa
                             && det.IdSucursal == IdSucursal
                             && det.IdProveedor == IdProveedor
                             select det;

                foreach (var item in Select)
                {
                    com_ordencompra_local_det_Info Obj = new com_ordencompra_local_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.do_CantidadOC = item.do_CantidadOC;
                    Obj.dm_cantidad_Inv = item.dm_cantidad_Inv;
                    Obj.SaldoxRecibir = Convert.ToDouble(item.SaldoxRecibir);
                    Obj.oc_fecha = Convert.ToDateTime(item.oc_fecha);
                    Obj.oc_NumDocumento = item.oc_NumDocumento;
                    Obj.oc_observacion = item.oc_observacion;
                    Obj.solicitante = item.Solicitante;
                    Obj.FechaAprob = Convert.ToDateTime(item.co_fecha_aprobacion);
                    Obj.FechaRep = Convert.ToDateTime(item.co_fechaReproba);
                    Obj.UsuarioAprueba = item.IdUsuario_Aprueba;
                    Obj.UsuarioReprueba = item.IdUsuario_Reprue;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.IdOrdenTaller_preasignada = item.IdOrdenTaller_preasignada;

                    Lst.Add(Obj);
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

        public List<com_ordencompra_local_det_Info> Get_List_OC_local_det_x_Saldos_x_Proveedor_x_Obra_x_OT(int IdEmpresa, int IdSucursal, decimal IdProveedor)
        {
            List<com_ordencompra_local_det_Info> Lst = new List<com_ordencompra_local_det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {

                var Select = from det in oEnti.vwcom_OC_local_det_x_MoviInven_SaldoItem_x_Obra_x_OT
                             where det.IdEmpresa == IdEmpresa
                             && det.IdSucursal == IdSucursal
                             && det.IdProveedor == IdProveedor
                             select det;

                foreach (var item in Select)
                {
                    com_ordencompra_local_det_Info Obj = new com_ordencompra_local_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.do_CantidadOC = item.do_CantidadOC;
                    Obj.dm_cantidad_Inv = item.dm_cantidad_Inv;
                    Obj.SaldoxRecibir = Convert.ToDouble(item.SaldoxRecibir);
                    Obj.oc_fecha = Convert.ToDateTime(item.oc_fecha);
                    Obj.oc_NumDocumento = item.oc_NumDocumento;
                    Obj.oc_observacion = item.oc_observacion;
                    Obj.solicitante = item.Solicitante;
                    Obj.FechaAprob = Convert.ToDateTime(item.co_fecha_aprobacion);
                    Obj.FechaRep = Convert.ToDateTime(item.co_fechaReproba);
                    Obj.UsuarioAprueba = item.IdUsuario_Aprueba;
                    Obj.UsuarioReprueba = item.IdUsuario_Reprue;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.IdOrdenTaller_preasignada = item.IdOrdenTaller_preasignada;

                    Lst.Add(Obj);
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

        public int GetSecuencia_x_OC(int idempresa,int idsucursal,decimal idOrdenCompra)
        {
            try
            {
                int Id;
                EntitiesCompras OECompras = new EntitiesCompras();

                var select = from q in OECompras.com_ordencompra_local_det
                             where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.IdOrdenCompra == idOrdenCompra
                             select q;

                if (select == null)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.com_ordencompra_local_det
                                     where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.IdOrdenCompra == idOrdenCompra
                                     select q.Secuencia).Max();
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

        public List<in_movi_inve_detalle_Info> Get_List_movi_inve_detalle(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<in_movi_inve_detalle_Info> Lst = new List<in_movi_inve_detalle_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();

                 var Query = from q in oEnti.vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo
                            where q.IdEmpresa == IdEmpresa && q.IdProveedor == IdProveedor
                            && q.Estado=="A" 
                            && q.IdEstadoAprobacion_cat=="APRO" 
                            && q.Saldo_OC_x_Ing >0
                            select q;
                foreach (var item in Query)
                {
                    in_movi_inve_detalle_Info Obj = new in_movi_inve_detalle_Info();
                    Obj.IdEmpresa = Convert.ToInt32(item.IdEmpresa);

                    Obj.IdSucursal =  Convert.ToInt32(item.IdSucursal);
                    Obj.IdOrdenCompra =Convert.ToDecimal(item.IdOrdenCompra);
                    Obj.secuencia_oc_det = Convert.ToInt32(item.secuencia_oc_det);
                    Obj.nom_sucu = item.nom_sucu;
                    Obj.IdProveedor = Convert.ToDecimal(item.IdProveedor);
                    Obj.nom_proveedor = item.nom_proveedor;

                    Obj.Tipo = item.Tipo;
                    Obj.oc_fecha = Convert.ToDateTime(item.oc_fecha);
                    Obj.oc_observacion = item.oc_observacion;
                    Obj.cod_producto = item.cod_producto;
                    Obj.nom_producto = item.nom_producto;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.cantidad_ing_a_Inven = 0;
                    Obj.Estado = item.Estado;
                    Obj.IdEstadoAprobacion = item.IdEstadoAprobacion_cat;

                    Obj.oc_precio = Convert.ToDouble(item.oc_precio);                   
                    Obj.cantidad_pedida_OC =  Convert.ToDouble(item.cantidad_pedida_OC);                 
                    Obj.Saldo_x_Ing_OC =  Convert.ToDouble(item.Saldo_OC_x_Ing);
                    Obj.Saldo_x_Ing_OC_AUX =  Convert.ToDouble(item.Saldo_OC_x_Ing);
                    Obj.pr_stock =  Convert.ToDouble(item.pr_stock);
                    Obj.pr_peso =  Convert.ToDouble(item.pr_peso);
                    Obj.CostoProducto =  Convert.ToDouble(item.CostoProducto);

                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_Cargo = Convert.ToInt32(item.IdPunto_cargo);
                    Obj.IdUnidadMedida = item.IdUnidadMedida;
                    Lst.Add(Obj);
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

        public Boolean ModificarDB(List<com_ordencompra_local_det_Info> ListInfo, ref  string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {

                    foreach (var item in ListInfo)
                    {



                        var contact = context.com_ordencompra_local_det.FirstOrDefault(obj => obj.IdOrdenCompra == item.IdOrdenCompra &&
                         obj.IdSucursal == item.IdSucursal && obj.IdEmpresa == item.IdEmpresa && obj.Secuencia==item.Secuencia && obj.IdProducto==item.IdProducto);

                        if (contact != null)
                        {


                            contact.do_Cantidad = item.do_Cantidad;
                            contact.do_precioCompra = item.do_precioCompra;
                            contact.do_porc_des = item.do_porc_des;
                            contact.do_descuento = item.do_descuento;
                            contact.do_precioFinal = item.do_precioFinal;
                            contact.do_subtotal = item.do_subtotal;
                            contact.do_iva = item.do_iva;
                            contact.do_total = item.do_total;
                            contact.do_ManejaIva = true;

                            contact.do_observacion = item.do_observacion;
                            contact.IdCentroCosto = item.IdCentroCosto;
                            contact.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            contact.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                            contact.IdPunto_cargo = item.IdPunto_cargo;
                            contact.IdUnidadMedida = item.IdUnidadMedida;
                            contact.Por_Iva = item.Por_Iva;
                            contact.IdCod_Impuesto = item.IdCod_Impuesto;

                          


                            context.SaveChanges();
                            msg = "Se ha procedido a modificar el registro de Orden Compra #: " + item.IdOrdenCompra.ToString() + " exitosamente";
                        }

                        
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
                mensaje = ex.ToString();

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    
    }
}
