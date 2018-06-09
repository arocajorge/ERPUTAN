using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

using System.Reflection;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
  public  class vwin_movi_inve_x_cbteCble_Datos_Data
    {
      string mensaje = "";

      public List<vwin_movi_inve_x_cbteCble_Datos_Info> Get_List_vwin_movi_inve_x_cbteCble_Datos(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, 
          string Tipo_ing_egr,string Tipo_Contabilizado)
      {
          List<vwin_movi_inve_x_cbteCble_Datos_Info> Lst = new List<vwin_movi_inve_x_cbteCble_Datos_Info>();
          try
          {


              try
              {

              

              
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
              EntitiesInventario oEnti = new EntitiesInventario();




              var Query = from q in oEnti.vwin_movi_inve_x_cbteCble_Datos
                          where q.IdEmpresa == IdEmpresa
                          && q.cm_fecha >= FechaIni
                          && q.cm_fecha <= FechaFin
                          && q.cm_tipo_movi.Contains(Tipo_ing_egr)
                          && q.Tipo_Contabilizado.Contains(Tipo_Contabilizado)
                          select q;

              foreach (var item in Query)
              {
                  vwin_movi_inve_x_cbteCble_Datos_Info Obj = new vwin_movi_inve_x_cbteCble_Datos_Info();


                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdBodega = item.IdBodega;
                  Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                  Obj.IdNumMovi = item.IdNumMovi;
                  Obj.cm_observacion = item.cm_observacion;
                  Obj.cm_fecha = item.cm_fecha;
                  Obj.codigo = item.Su_Descripcion;
                  Obj.bo_Descripcion = item.bo_Descripcion;
                  Obj.cm_tipo_movi = item.cm_tipo_movi;
                  Obj.cm_descripcionCorta = item.cm_descripcionCorta;
                  Obj.Secuencia = item.Secuencia;
                  Obj.IdProducto = item.IdProducto;
                  Obj.pr_codigo = item.pr_codigo;
                  Obj.pr_descripcion = item.pr_descripcion;
                  Obj.dm_observacion = item.dm_observacion;
                  Obj.dm_cantidad = item.dm_cantidad;
                  Obj.mv_costo = item.mv_costo;
                  Obj.IdCentroCosto = item.IdCentroCosto;
                  Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  Obj.IdPunto_cargo = item.IdPunto_cargo;
                  Obj.nom_punto_cargo = item.nom_punto_cargo;
                  Obj.tc_TipoCbte = item.tc_TipoCbte;
                  Obj.cb_Fecha = item.cb_Fecha;
                  Obj.IdEmpresa_ct = item.IdEmpresa_ct;
                  Obj.IdTipoCbte = item.IdTipoCbte;
                  Obj.IdCbteCble = item.IdCbteCble;
                  Obj.TotalCosto = item.mv_costo * item.dm_cantidad;
                  Obj.tm_descripcion = item.tm_descripcion;

                  Obj.IdEmpresa_inv = item.IdEmpresa_inv;
                  Obj.IdSucursal_inv =item.IdSucursal_inv;
                  Obj.IdBodega_inv = item.IdBodega_inv;
                  Obj.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
                  Obj.IdNumMovi_inv = item.IdNumMovi_inv;


                  Obj.Modificar_producto = item.IdProducto != 0 ? true : false;
                  Obj.Modificar_contabilidad = item.IdCbteCble != null && item.IdCbteCble != 0 ? true : false;


                  Lst.Add(Obj);
              }

              return Lst;


              }
              catch (DbEntityValidationException ex)
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

      public List<vwin_movi_inve_x_cbteCble_Datos_Info> Get_List_vwin_movi_inve_x_cbteCble_Datos_No_Contabilizados(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,
          string Tipo_ing_egr)
      {
          List<vwin_movi_inve_x_cbteCble_Datos_Info> Lst = new List<vwin_movi_inve_x_cbteCble_Datos_Info>();
          try
          {

              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
              EntitiesInventario oEnti = new EntitiesInventario();
              




              var Query = from q in oEnti.vwin_movi_inve_x_cbteCble_Datos
                          where q.IdEmpresa == IdEmpresa
                          && q.cm_fecha >= FechaIni
                          && q.cm_fecha <= FechaFin
                          && q.cm_tipo_movi.Contains(Tipo_ing_egr)
                          && q.Tipo_Contabilizado== "NO CONTABILIZADO"
                          group q by new 
                          { 
                              q.IdEmpresa, 
                              q.IdSucursal,
                              q.IdBodega,
                              q.IdMovi_inven_tipo,
                              q.IdNumMovi,
                              q.cm_observacion_inv,
                              q.cm_fecha,
                              q.Su_Descripcion,
                              q.bo_Descripcion,
                              q.cm_descripcionCorta,
                              q.cm_tipo_movi,
                              q.IdEmpresa_inv,
                              q.IdSucursal_inv,
                              q.IdBodega_inv,
                              q.IdMovi_inven_tipo_inv,
                              q.IdNumMovi_inv,
                              q.tm_descripcion
                          }
                              into grouping
                              select new { grouping.Key, TotalCosto = grouping.Sum(p => (p.dm_cantidad * p.mv_costo)) };

              foreach (var item in Query)
              {
                  vwin_movi_inve_x_cbteCble_Datos_Info Obj = new vwin_movi_inve_x_cbteCble_Datos_Info();


                  Obj.IdEmpresa = item.Key.IdEmpresa;
                  Obj.IdSucursal = item.Key.IdSucursal;
                  Obj.IdBodega = item.Key.IdBodega;
                  Obj.IdMovi_inven_tipo = item.Key.IdMovi_inven_tipo;
                  Obj.IdNumMovi = item.Key.IdNumMovi;
                  Obj.cm_observacion = item.Key.cm_observacion_inv;
                  Obj.cm_fecha = item.Key.cm_fecha;
                  Obj.codigo = item.Key.Su_Descripcion;
                  Obj.bo_Descripcion = item.Key.bo_Descripcion;
                  Obj.cm_descripcionCorta = item.Key.cm_descripcionCorta;
                  Obj.cm_tipo_movi = item.Key.cm_tipo_movi;
                  Obj.TotalCosto = item.TotalCosto;
                  Obj.IdEmpresa_inv = item.Key.IdEmpresa_inv;
                  Obj.IdSucursal_inv = item.Key.IdSucursal_inv;
                  Obj.IdBodega_inv = item.Key.IdBodega_inv;
                  Obj.IdMovi_inven_tipo_inv = item.Key.IdMovi_inven_tipo_inv;
                  Obj.IdNumMovi_inv = item.Key.IdNumMovi_inv;
                  Obj.tm_descripcion = item.Key.tm_descripcion;
                  Lst.Add(Obj);
              }

              return Lst;
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
