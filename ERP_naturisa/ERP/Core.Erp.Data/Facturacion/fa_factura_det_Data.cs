using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Data.Facturacion
{
  public  class fa_factura_det_Data
    {
      string mensaje="";
      public Boolean GuardarDB(List<fa_factura_det_info> Lista, ref decimal Id,ref string msg)
      {
          try
          {
              List<fa_factura_det_otros_campos_Info> List = new List<fa_factura_det_otros_campos_Info>();
              fa_factura_det_otros_campos_Data odata = new fa_factura_det_otros_campos_Data();

              using (EntitiesFacturacion Contex = new EntitiesFacturacion())
              {
                  int secuencia = 0;
                  foreach (var item in Lista)
                  {
                      if (item.IdProducto != 0)
                      {
                          var address = new fa_factura_det();
                          secuencia = secuencia + 1;

                          address.IdEmpresa = item.IdEmpresa;
                          address.IdSucursal = item.IdSucursal;
                          address.IdBodega = item.IdBodega;
                          address.IdCbteVta = Id;
                          address.Secuencia = Convert.ToInt32(secuencia);
                          address.IdProducto = item.IdProducto;
                          address.vt_cantidad = item.vt_cantidad;
                          address.vt_Precio = item.vt_Precio;
                          address.vt_PorDescUnitario = item.vt_PorDescUnitario;
                          address.vt_DescUnitario = item.vt_DescUnitario;
                          address.vt_PrecioFinal = item.vt_PrecioFinal;
                          address.vt_Subtotal = item.vt_Subtotal;
                          address.vt_iva = item.vt_iva;
                          address.vt_total = item.vt_total;
                          address.vt_Peso = item.vt_Peso;
                          address.vt_estado = item.vt_estado;
                          
                          address.vt_detallexItems = item.vt_detallexItems == null ? "" : item.vt_detallexItems.ToString().Trim();
                          address.vt_por_iva = (item.vt_por_iva == null) ? 0 : Convert.ToDouble(item.vt_por_iva);
                          address.IdPunto_Cargo = item.IdPunto_cargo;
                          address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                          address.IdCod_Impuesto_Iva = (item.IdCod_Impuesto_Iva == "") ? null : item.IdCod_Impuesto_Iva;
                          address.IdCod_Impuesto_Ice = (item.IdCod_Impuesto_Ice == "") ? null : item.IdCod_Impuesto_Ice;
                          address.IdCentroCosto = item.IdCentroCosto;
                          address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                          Contex.fa_factura_det.Add(address);
                          Contex.SaveChanges();
                      }
                  }
                  odata.GuardarDB(List);
              }
              return true;
          }
          catch (DbEntityValidationException ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
              msg = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public List<fa_factura_det_info> Get_List_factura_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref string msg)
      {
          try
          {
              List<fa_factura_det_info> Lista = new List<fa_factura_det_info>();

              EntitiesFacturacion oEnt = new EntitiesFacturacion();

              var consulta = from h in oEnt.vwfa_factura_det
                          where h.IdEmpresa == IdEmpresa
                                && h.IdSucursal == IdSucursal
                                && h.IdBodega == IdBodega
                                && h.IdCbteVta == IdCbteVta
                          select h;

              foreach (var item in consulta)
              {
                  fa_factura_det_info info = new fa_factura_det_info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdSucursal = item.IdSucursal;
                  info.IdBodega = item.IdBodega;
                  info.IdCbteVta = item.IdCbteVta;
                  info.Secuencia = item.Secuencia;
                  info.IdProducto = item.IdProducto;
                  info.vt_cantidad = item.vt_cantidad;
                  info.vt_Precio = item.vt_Precio;
                  info.vt_PorDescUnitario = item.vt_PorDescUnitario;
                  info.vt_DescUnitario = item.vt_DescUnitario;
                  info.vt_PrecioFinal = item.vt_PrecioFinal;
                  info.vt_Subtotal = item.vt_Subtotal;
                  info.vt_iva = item.vt_iva;
                  info.vt_total = item.vt_total;
                  info.vt_estado = item.vt_estado;
                  info.vt_detallexItems = item.vt_detallexItems;
                  info.vt_Peso = Convert.ToDouble(item.vt_Peso);
                  info.vt_por_iva = item.vt_por_iva;
                  info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  info.IdPunto_cargo = item.IdPunto_Cargo;
                  info.pr_codigo = item.pr_codigo;
                  info.pr_descripcion = item.pr_descripcion;
                  info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                  info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                  info.IdCentroCosto = item.IdCentroCosto;
                  info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                  Lista.Add(info);
              }
              return Lista;
          }
          catch (Exception ex)
          {
              
               string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      
      
      }

      public Boolean ModificarDB(List<fa_factura_det_info> Lista, fa_factura_Info info)
      {
          try
          {
                  List<fa_factura_det_info> listaAux = new List<fa_factura_det_info>();
                  listaAux = Get_List_factura_det
              (info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta, ref mensaje);

                  using (EntitiesFacturacion context = new EntitiesFacturacion())
                  {
                      foreach (var item in listaAux)
                      {
                          var contact = context.fa_factura_det.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdCbteVta == info.IdCbteVta && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega);
                          if (contact != null)
                          {
                              context.fa_factura_det.Remove(contact);
                              context.SaveChanges();
                          }
                      }
                              int secuencia = 0;
                              foreach (var item in Lista)
                              {
                                  var address = new fa_factura_det();
                                  secuencia = secuencia + 1;
                                  address.vt_cantidad = item.vt_cantidad;
                                  address.vt_Peso = item.vt_Peso;
                                  address.vt_Precio = item.vt_Precio;
                                  address.IdEmpresa = item.IdEmpresa;
                                  address.IdSucursal = item.IdSucursal;
                                  address.IdBodega = item.IdBodega;
                                  address.IdCbteVta = info.IdCbteVta;
                                  address.Secuencia = Convert.ToInt32(secuencia);
                                  address.IdProducto = item.IdProducto;
                                  address.vt_PorDescUnitario = item.vt_PorDescUnitario;
                                  address.vt_DescUnitario = item.vt_DescUnitario;
                                  address.IdProducto = item.IdProducto;
                                  address.vt_total = item.vt_total;
                                  address.vt_iva = item.vt_iva;
                                  address.vt_Subtotal = item.vt_Subtotal;
                                  address.vt_PrecioFinal = item.vt_PrecioFinal;
                                  address.vt_detallexItems = (item.vt_detallexItems == null) ? "" : item.vt_detallexItems.Trim();
                                  address.vt_estado = item.vt_estado;
                                  address.vt_por_iva = Convert.ToDouble(item.vt_por_iva);
                                  address.IdPunto_Cargo = item.IdPunto_cargo;
                                  address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                                  address.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                                  address.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                                  address.IdCentroCosto = item.IdCentroCosto;
                                  address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                                  context.fa_factura_det.Add(address);
                                  context.SaveChanges();
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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }
    }
}
