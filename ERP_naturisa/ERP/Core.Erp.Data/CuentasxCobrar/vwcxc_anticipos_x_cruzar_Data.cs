using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Data.CuentasxCobrar
{
  public  class vwcxc_anticipos_x_cruzar_Data
    {
      string mensaje = "";
      public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar(vwcxc_anticipos_x_cruzar_Info info)
      {
          try
          {
              List<vwcxc_anticipos_x_cruzar_Info> lista = new List<vwcxc_anticipos_x_cruzar_Info>();
              EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();

              var consulta = from q in CXC.vwcxc_anticipos_x_cruzar
                             where q.IdEmpresa == info.IdEmpresa && q.IdCliente == info.IdCliente
                             select q;
              foreach (var item in consulta)
              {
                  vwcxc_anticipos_x_cruzar_Info infoAntCli = new vwcxc_anticipos_x_cruzar_Info();

                    infoAntCli.IdEmpresa_Cobro=Convert.ToInt32(item.IdEmpresa_Cobro);
                    infoAntCli.IdSucursal_cobro = Convert.ToInt32(item.IdSucursal_cobro);
                    infoAntCli.IdCobro_cobro = Convert.ToInt32(item.IdCobro_cobro);
                    infoAntCli.IdEmpresa = item.IdEmpresa;
                    infoAntCli.IdAnticipo = item.IdAnticipo;
                    infoAntCli.IdSucursal = item.IdSucursal;
                    infoAntCli.IdCliente = item.IdCliente;
                    infoAntCli.Fecha = Convert.ToDateTime(item.Fecha);
                    infoAntCli.Observacion = item.Observacion;
                    infoAntCli.pe_apellido = item.pe_apellido;
                    infoAntCli.pe_nombre = item.pe_nombre;
                    infoAntCli.IdCobro_tipo = item.IdCobro_tipo;
                    infoAntCli.cr_Banco = item.cr_Banco;
                    infoAntCli.cr_NumDocumento = item.cr_NumDocumento;
                    infoAntCli.IdCaja = item.IdCaja;
                    infoAntCli.cr_TotalCobro = item.cr_TotalCobro;
                    infoAntCli.Saldo_Pendiente = item.Saldo_Pendiente;

                    lista.Add(infoAntCli);                 
              }
              return lista;
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
