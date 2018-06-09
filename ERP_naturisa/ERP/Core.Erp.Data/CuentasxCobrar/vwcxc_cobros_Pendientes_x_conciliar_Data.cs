using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
  public  class vwcxc_cobros_Pendientes_x_conciliar_Data
    {

      public List<vwcxc_cobros_Pendientes_x_conciliar_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(int IdEmpresa, int IdSucursal, decimal IdCliente, Cl_Enumeradores.TipoConciliacion IdTipoConciliacion, ref string mensaje)
      {
          try
          {
              EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();

              List<vwcxc_cobros_Pendientes_x_conciliar_Info> lst = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
              List<vwcxc_cobros_Pendientes_x_conciliar_Info> lstReturn = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
              string query = " select IdEmpresa,IdSucursal,ISNULL(IdBodega,'')as IdBodega,tipo,isnull(IdCobro,0)as IdCobro, " +
                " ISNULL(IdNota,0)as IdNota,  ISNULL(CreDeb,'')as CreDeb,ISNULL(Serie1,'') as Serie1,ISNULL(Serie2,'') as Serie2 " +
                " ,ISNULL(NumNota_Impresa,'')as NumNota_Impresa,IdCliente,NomSucursal, ISNULL(Nom_Bodega,'')as Nom_Bodega,no_fecha,no_fecha_venc,sc_observacion " +
                " ,Nom_Cliente,ISNULL(Motivo_Nota,'')as Motivo_Nota,Referencia,sc_total,Saldo,IdTipoConciliacion,IdCobro_Tipo,ISNULL(IdTipoNota,'')as IdTipoNota,IdCaja, IdCtaCble_cxc, IdCtaCble_Anti " +
                " from vwcxc_cobros_pendientes_x_conciliar " +
                " where IdEmpresa= " + IdEmpresa + " and IdCliente= " + IdCliente + " and IdTipoConciliacion='" + IdTipoConciliacion.ToString() + "' " +
                " and IdSucursal=" + IdSucursal + " and Saldo >0";

              lst = CXC.Database.SqlQuery<vwcxc_cobros_Pendientes_x_conciliar_Info>(query).ToList();

              vwcxc_cobros_Pendientes_x_conciliar_Info info;

              foreach (var item in lst)
              {
                  info = new vwcxc_cobros_Pendientes_x_conciliar_Info();

                  info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                  info.IdSucursal = Convert.ToInt32(item.IdSucursal);
                  info.IdBodega = Convert.ToInt32(item.IdBodega);
                  info.Tipo = item.Tipo;
                  info.IdNota = Convert.ToDecimal(item.IdNota);
                  info.CreDeb = item.CreDeb;
                  info.Serie1 = item.Serie1;
                  info.Serie2 = item.Serie2;
                  info.NumNota_Impresa = item.NumNota_Impresa;
                  info.IdCliente = item.IdCliente;
                  info.NomSucursal = item.NomSucursal;
                  info.Nom_Bodega = item.Nom_Bodega;
                  info.no_fecha = Convert.ToDateTime(item.no_fecha);
                  info.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                  info.sc_observacion = item.sc_observacion;
                  info.Nom_Cliente = item.Nom_Cliente;
                  info.Motivo_Nota = item.Motivo_Nota;
                  info.Referencia = item.Referencia;
                  info.sc_total = Convert.ToDouble(item.sc_total);
                  info.Saldo = Convert.ToDouble(item.Saldo);
                  info.saldoAUX_CreDeb = Convert.ToDouble(item.Saldo);
                  info.IdTipoConciliacion = item.IdTipoConciliacion;
                  info.IdCobro = Convert.ToDecimal(item.IdCobro);
                  info.IdCobro_Tipo = item.IdCobro_Tipo;
                  info.IdTipoNota = Convert.ToInt32(item.IdTipoNota);
                  info.IdCaja = Convert.ToInt32(item.IdCaja);
                  info.NombreCompleto = "[" + item.IdCliente + "] -" + "[" + item.Nom_Cliente + "]";
                  info.IdCtaCble_cxc = item.IdCtaCble_cxc;
                  info.IdCtaCble_Anti = item.IdCtaCble_Anti;
                  lstReturn.Add(info);
              }
              return lstReturn;
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }
    }
}
