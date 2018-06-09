using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
    public class in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Data
    {
        string mensaje = "";

        public bool GuardarDB(in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info info)
        {
            try
            {
                try
                {
                    using (EntitiesInventario Context = new EntitiesInventario())
                    {
                        in_transferencia_det_x_in_Guia_x_traspaso_bodega_det Entity = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det();
                        Entity.IdEmpresa_trans = info.IdEmpresa_trans;
                        Entity.IdSucursalOrigen_trans = info.IdSucursalOrigen_trans;
                        Entity.IdBodegaOrigen_trans = info.IdBodegaOrigen_trans;
                        Entity.IdTransferencia_trans = info.IdTransferencia_trans;
                        Entity.Secuencia_trans = info.Secuencia_trans;
                        Entity.IdEmpresa_guia = info.IdEmpresa_guia;
                        Entity.IdGuia_guia = info.IdGuia_guia;
                        Entity.Secuencia_guia = info.Secuencia_guia;
                        Entity.Observacion = info.Observacion;
                        Context.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.Add(Entity);
                        Context.SaveChanges();
                    }

                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: "+item_validaciones.PropertyName +" Mensaje: "+ item_validaciones.ErrorMessage+"\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);                    
                    throw new Exception(mensaje);
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
                throw new Exception(mensaje);
            }
        }

        public bool EliminarDB(in_transferencia_Info info)
        {
            try
            {
                try
                {
                    string comando = "DELETE in_transferencia_det_x_in_Guia_x_traspaso_bodega_det WHERE IdEmpresa_trans = " + info.IdEmpresa + " and IdSucursalOrigen_trans = " + info.IdSucursalOrigen + " and IdBodegaOrigen_trans = " + info.IdBodegaOrigen + " and IdTransferencia_trans = " + info.IdTransferencia;

                    using (EntitiesInventario Context = new EntitiesInventario())
                    {
                        Context.Database.ExecuteSqlCommand(comando);                        
                    }

                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(mensaje);
            }
        }

        public List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info> Get_list_trans_x_guia(int IdEmpresa, decimal IdGuia)
        {
            try
            {
                List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info> Lista = new List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info>();

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_transferencia_det_x_in_Guia_x_traspaso_bodega_det
                              where q.IdEmpresa_guia == IdEmpresa
                              && q.IdGuia_guia == IdGuia
                              select q;

                    foreach (var item in lst)
                    {
                        in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info info = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info();
                        info.IdEmpresa_trans = item.IdEmpresa_trans;
                        info.IdSucursalOrigen_trans = item.IdSucursalOrigen_trans;
                        info.IdBodegaOrigen_trans = item.IdBodegaOrigen_trans;
                        info.IdTransferencia_trans = item.IdTransferencia_trans;
                        info.Secuencia_trans = item.Secuencia_trans;
                        info.IdEmpresa_guia = item.IdEmpresa_guia;
                        info.IdGuia_guia = item.IdGuia_guia;
                        info.Secuencia_guia = item.Secuencia_guia;
                        
                        info.cod_sucursal = item.codigo;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.cod_bodega = item.cod_bodega;
                        info.bo_Descripcion = item.bo_Descripcion;
                        info.IdProducto = item.IdProducto;
                        info.pr_codigo = item.pr_codigo;
                        info.pr_descripcion = item.pr_descripcion;

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
                throw new Exception(mensaje);
            }
        }
    }
}
