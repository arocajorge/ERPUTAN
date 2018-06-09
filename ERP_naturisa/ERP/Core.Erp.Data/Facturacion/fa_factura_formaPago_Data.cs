using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using System.Data.Objects;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_formaPago_Data
    {
        string mensaje = "";
        //public Boolean GuardarDB(List<fa_factura_formaPago_Info> Lista)
        //{
        //    try
        //    {int Secuencia = 1;
        //    foreach (fa_factura_formaPago_Info Info in Lista)
        //        {
        //            using (EntitiesFacturacion Context = new EntitiesFacturacion())
        //            {
        //                var contact = fa_factura_formaPago.Createfa_factura_formaPago(0, 0, 0, 0, "", 0, 0, DateTime.Now, DateTime.Now, 0,0);
        //                fa_factura_formaPago Address = new fa_factura_formaPago();

        //                Address.IdEmpresa = Info.IdEmpresa;
        //                Address.IdSucursal = Info.IdSucursal;
        //                Address.IdBodega = Info.IdBodega;
        //                Address.IdFactura = Info.IdFactura;
        //                Address.IdCobro_tipo = Info.IdCobro_tipo;
        //                Address.secuencia = Secuencia;
        //                Address.Valor = Info.Valor;
        //                Address.FechaEdicion = Info.FechaEdicion;
        //                Address.FechaCobro = Info.FechaCobro;
        //                Address.Porcentaje = Info.Porcentaje;
        //                Address.Dias = Info.Dias;
        //                Secuencia++;
        //                contact = Address;
        //                Context.fa_factura_formaPago.AddObject(contact);
        //                Context.SaveChanges();
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //      string arreglo = ToString();
        //      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //      tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //      mensaje = ex.InnerException + " " + ex.Message;  
        //          oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
        //        return false; 
        //    }
        //}

        //public List<fa_factura_formaPago_Info> ConsultaEspecifica(int IdEmpresa, int IdSucursal, int IdBodega, decimal Idtransaccion) 
        //{
        //    try
        //    {
        //        List<fa_factura_formaPago_Info> Lst = new List<fa_factura_formaPago_Info>();
        //        ObjectResult<fa_factura_formaPago_Info> Consulta;
        //        using (EntitiesFacturacion Entity = new EntitiesFacturacion())
        //        {
        //            string Query = "select * from fa_factura_formaPago where IdEmpresa = " + IdEmpresa + " and IdBodega = " + IdBodega + " and IdSucursal = " + IdSucursal + " And IdFactura = " + Idtransaccion;
        //            Consulta = Entity.ExecuteStoreQuery<fa_factura_formaPago_Info>(Query);
        //            foreach (var item in Consulta)
        //            {
        //                Lst.Add(item); 
        //            }



        //        }



        //        return Lst;

        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //          tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //          tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //          mensaje = ex.InnerException + " " + ex.Message;  
        //          oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
        //        return new List<fa_factura_formaPago_Info>();
        //    }
        
        //}

    }
}
