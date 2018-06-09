using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.ActivoFijo
{
     public class XACTF_Rpt013_Data
    {
         public List< XACTF_Rpt013_Info> consultar_data(int IdEmpresa, int IdSucursal,int IdActivoFijo, ref string mensaje)
     {
         try
         {
             List<XACTF_Rpt013_Info> list = new List<XACTF_Rpt013_Info>();
             using (Entities_ActivoFijo_Reportes historial = new Entities_ActivoFijo_Reportes())
             {
                 var select = from h in historial.vwACTF_Rpt013
                              where h.IdEmpresa == IdEmpresa
                              && h.IdSucursal == IdSucursal
                              && h.IdActivoFijo == IdActivoFijo
                              select h;
                 foreach (var item in select)
                 {
                     XACTF_Rpt013_Info info = new XACTF_Rpt013_Info();
                     info.Af_costo_compra = item.Af_costo_compra;
                     info.Af_Costo_historico = item.Af_costo_compra;
                     info.Af_fecha_compra = item.Af_fecha_compra;
                     info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                     info.Af_fecha_ini_depre = item.Af_fecha_fin_depre;
                     info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                     info.Af_Nombre = item.Af_Nombre;
                     info.Af_NumSerie = item.Af_NumSerie;
                     info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                     info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                     info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                     info.Af_Vida_Util = item.Af_Vida_Util;
                     info.CodActivoFijo = item.CodActivoFijo;
                     info.de_descripcion = item.de_descripcion;
                     info.Fecha = Convert.ToDateTime(item.Fecha);
                     info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                     info.IdActivoFijo = item.IdActivoFijo;
                     info.IdDepartamento = Convert.ToInt32(item.IdDepartamento);
                     info.IdEmpresa = item.IdEmpresa;
                     info.Marca = item.Marca;
                     info.Modelo = item.Modelo;
                     info.Tipo_Registro = item.Tipo_Registro;
                     info.Valor = Convert.ToDouble(item.Valor);
                     info.IdSucursal = item.IdSucursal;
                     info.nom_Sucursal = item.nom_Sucursal;

                     list.Add(info);
                 }
             }
             return list;

         }
         catch (Exception ex)
         {

             string arreglo = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
             mensaje = ex.InnerException + " " + ex.Message;
             oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
             throw new Exception(ex.ToString());
         }
	   }
    }
}
