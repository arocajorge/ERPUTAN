using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
  public  class in_Guia_x_traspaso_bodega_det_sin_oc_Data
    {
        string mensaje = "";

      public Boolean GuardarDB(List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> LstInfo)
        {
            try
            {
                int sec = 0;

                foreach (var item in LstInfo)
                {
                    using (EntitiesInventario Context = new EntitiesInventario())
                    {
                        sec = sec + 1;

                        var Address = new in_Guia_x_traspaso_bodega_det_sin_oc();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdGuia = item.IdGuia;
                        Address.secuencia = sec;
                        Address.Num_Fact = item.Num_Fact;
                        Address.IdProveedor = item.IdProveedor == 0 ? null : item.IdProveedor;
                        Address.nom_proveedor = item.nom_proveedor;
                        Address.IdProducto = item.IdProducto == 0 ? null : item.IdProducto;
                        Address.nom_producto = item.nom_producto;

                        if (item.observacion==null)
                        {
                            item.observacion = "";                       
                        }
                        
                        Address.observacion = item.observacion;
                        Address.Cantidad_enviar = item.Cantidad_enviar;

                        Context.in_Guia_x_traspaso_bodega_det_sin_oc.Add(Address);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

      public Boolean EliminarDB(int IdEmpresa,decimal IdGuia)
        {
            try
            {

                EntitiesInventario Oent = new EntitiesInventario();

                string Query = "delete from in_Guia_x_traspaso_bodega_det_sin_oc where IdEmpresa = " + IdEmpresa + "   and IdGuia= " + IdGuia + "";
                Oent.Database.ExecuteSqlCommand(Query);

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

      public List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> Get_List_Guia_x_traspaso_bodega_det_sin_oc(int idempresa, decimal IdGuia)
        {
            List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> Lst = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();
            EntitiesInventario oEnti = new EntitiesInventario();
            try
            {
                var Query = from q in oEnti.in_Guia_x_traspaso_bodega_det_sin_oc
                            where q.IdEmpresa == idempresa && q.IdGuia == IdGuia
                            select q;
                foreach (var item in Query)
                {
                    in_Guia_x_traspaso_bodega_det_sin_oc_Info Obj = new in_Guia_x_traspaso_bodega_det_sin_oc_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdGuia = item.IdGuia;
                    Obj.secuencia = item.secuencia;
                    Obj.Num_Fact = item.Num_Fact;
                    Obj.IdProveedor = Convert.ToDecimal(item.IdProveedor);
                    Obj.nom_proveedor = item.nom_proveedor;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.nom_producto = item.nom_producto;
                    Obj.observacion = item.observacion;
                    Obj.Cantidad_enviar = Convert.ToDouble(item.Cantidad_enviar);

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
    }
}
