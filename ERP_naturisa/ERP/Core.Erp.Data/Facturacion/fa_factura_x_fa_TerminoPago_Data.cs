using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Facturacion
{
  public  class fa_factura_x_fa_TerminoPago_Data
    {
      string mensaje = "";

      public Boolean GuardarDB(List<fa_factura_x_fa_TerminoPago_Info> Lista, ref string mensajeE)
        {
            try
            {

                foreach (fa_factura_x_fa_TerminoPago_Info Info in Lista)
                {
                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {

                        fa_factura_x_fa_TerminoPago Address = new fa_factura_x_fa_TerminoPago();

                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdSucursal = Info.IdSucursal;
                        Address.IdBodega = Info.IdBodega;
                        Address.IdCbteVta = Info.IdCbteVta;
                        Address.IdTerminoPago = Info.IdTerminoPago;
                        Address.Secuencia = Info.Secuencia;
                        Address.Fecha = Info.Fecha;
                        Address.Fecha_vct = Info.Fecha_vct;
                        Address.Dias_Plazo = Info.Dias_Plazo;
                        Address.Por_Distribucion = Info.Por_Distribucion;
                        Address.Valor = Info.Valor;
                        Context.fa_factura_x_fa_TerminoPago.Add(Address);
                        Context.SaveChanges();
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
                mensajeE = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_factura_x_fa_TerminoPago_Info> Get_List_fa_factura_x_formaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                List<fa_factura_x_fa_TerminoPago_Info> Lst = new List<fa_factura_x_fa_TerminoPago_Info>();
                EntitiesFacturacion oEnti = new EntitiesFacturacion();
                var Query = from q in oEnti.fa_factura_x_fa_TerminoPago
                            where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdCbteVta == IdCbteVta
                            select q;

                foreach (var item in Query)
                {
                    fa_factura_x_fa_TerminoPago_Info Obj = new fa_factura_x_fa_TerminoPago_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdCbteVta = item.IdCbteVta;

                    Obj.IdTerminoPago = item.IdTerminoPago;
                    Obj.Secuencia = item.Secuencia;
                    Obj.Fecha = item.Fecha;
                    Obj.Fecha_vct = item.Fecha_vct;
                    Obj.Dias_Plazo = item.Dias_Plazo;
                    Obj.Por_Distribucion = item.Por_Distribucion;
                    Obj.Valor = item.Valor;


                    

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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

    }
}
