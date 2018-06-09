using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_DespachoDetalle_Data
    {
        string mensaje = "";
        public List<prd_DespachoDetalle_Info> ObtenerDespachoDetalle(decimal IdDespacho, int idempresa, int IdSucursal)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();

                List<prd_DespachoDetalle_Info> lM = new List<prd_DespachoDetalle_Info>();
                var select = from C in OEProduccion.prd_DespachoDet
                             where C.IdEmpresa == idempresa && C.IdSucursal == IdSucursal && C.IdDespacho == IdDespacho
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    prd_DespachoDetalle_Info Info = new prd_DespachoDetalle_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdDespacho = item.IdDespacho;
                    Info.Secuencia = item.Secuencia;
                    Info.IdOrdenTaller = item.IdOrdenTaller;
                    Info.Hora = item.Hora;
                    Info.IdProducto = item.IdProducto;
                    Info.peso = Convert.ToDecimal(item.peso);
                    Info.precio = Convert.ToDecimal(item.precio);
                    Info.CodigoBarraMaestro = item.CodigoBarraMaestro;
                    Info.CodigoBarra = item.CodigoBarra;
                    Info.Cantidad = item.Cantidad;
                    Info.Observacion = item.Observacion;
                    Info.precio = Convert.ToDecimal(item.precio);


                    lM.Add(Info);
                }
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

        public List<prd_DespachoDetalle_Info> ObtenerDespachoDetalle_para_GuiaRemision(decimal IdDespacho, int idempresa, int IdSucursal)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();

                List<prd_DespachoDetalle_Info> lM = new List<prd_DespachoDetalle_Info>();
                var select = from C in OEProduccion.prd_DespachoDet
                             let k = new
                             {
                                 //try this if you need a date field 
                                 //   p.SaleDate.Date.AddDays(-1 *p.SaleDate.Day - 1)
                                 Id_Empresa = C.IdEmpresa,
                                 Id_Sucursal = C.IdSucursal,
                                 Id_Despacho = C.IdDespacho,
                                 Id_Product = C.IdProducto
                                
                             }
                             where C.IdEmpresa == idempresa && C.IdSucursal == IdSucursal && C.IdDespacho == IdDespacho
                             //orderby C.Secuencia ascending
                              group C by k into t
                              select new
                              {
                                  IdEmpresa = t.Key.Id_Empresa,
                                  Id_Sucursal = t.Key.Id_Sucursal,
                                  Id_Despacho = t.Key.Id_Sucursal,
                                  IdProduct = t.Key.Id_Product,
                                  Qty = t.Sum(p => p.Cantidad)
                              };

                foreach (var item in select)
                {
                    prd_DespachoDetalle_Info Info = new prd_DespachoDetalle_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.Id_Sucursal;
                    Info.IdDespacho = item.Id_Despacho;
                    Info.IdProducto = item.IdProduct;
                    //Info.peso = Convert.ToDecimal(item.peso);
                    //Info.precio = Convert.ToDecimal(item.precio);
                    
                    Info.Cantidad = item.Qty;
                    //Info.Observacion = item.Observacion;
                    //Info.precio = Convert.ToDecimal(item.precio);


                    lM.Add(Info);
                }
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

        public Boolean grabarDB(List<prd_DespachoDetalle_Info> lmDetalleinfo, int idempresa, decimal IdDespacho, ref string msg)
        {
            try
            {
                
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    int sec = 0;
                    foreach (var item in lmDetalleinfo)
                    {
                        var Address = new prd_DespachoDet();

                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;
                        Address.IdDespacho = IdDespacho;
                        
                        Address.Secuencia = ++sec;

                        Address.IdOrdenTaller = Convert.ToDecimal(item.IdOrdenTaller);
                        Address.Hora = item.Hora;
                        Address.IdProducto = item.IdProducto;
                        Address.CodigoBarraMaestro = item.CodigoBarraMaestro;
                        Address.CodigoBarra = item.CodigoBarra;
                        Address.Cantidad = item.Cantidad;
                        Address.Observacion = item.Observacion;
                        Address.precio = Convert.ToDecimal (item.precio);
                        Address.peso = Convert.ToDecimal(item.peso);
                        if (item.Observacion.Length > 200)
                        {
                            Address.Observacion = item.Observacion.Substring(0, 200);
                        }

                        context.prd_DespachoDet.Add(Address);
                        context.SaveChanges();
                    }
                    context.Dispose();

                }
                msg = "Guardado con exito";
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

        public Boolean eliminarregistrotabla(List<prd_DespachoDetalle_Info> lmDetalleInfo, int idempresa, decimal IdDespacho, ref string msg)
        {
            try
            {

                using (EntitiesProduccion_Cidersus contex1 = new EntitiesProduccion_Cidersus())
                {

                    foreach (var item in lmDetalleInfo)
                    {
                        var address = contex1.prd_DespachoDet.FirstOrDefault(A => A.IdEmpresa == idempresa && A.IdSucursal == item.IdSucursal && A.IdDespacho == IdDespacho);
                        if (address != null)
                        {
                            contex1.prd_DespachoDet.Remove(address);
                            contex1.SaveChanges();
                            msg = "Guardado con exito";
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
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}
