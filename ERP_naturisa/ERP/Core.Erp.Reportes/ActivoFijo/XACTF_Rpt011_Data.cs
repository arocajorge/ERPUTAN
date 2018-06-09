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
   public class XACTF_Rpt011_Data
    {

       public List<XACTF_Rpt011_Info> consultar_data(int IdEmpresa,int IdPeriodo, ref string mensaje)
       {
           try
           {
               List<XACTF_Rpt011_Info> lstRpt = new List<XACTF_Rpt011_Info>();

               using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
               {
                   var select = from q in listado.vwACTF_Rpt011
                                where q.IdEmpresa == IdEmpresa  && q.IdPeriodo== IdPeriodo    
                                && q.Estado=="A"
                                select q;

                   foreach (var item in select)
                   {
                       XACTF_Rpt011_Info info = new XACTF_Rpt011_Info();
                       info.IdEmpresa = item.IdEmpresa;                                           
                       info.IdDepreciacion= item.IdDepreciacion;
                       info.IdPeriodo = item.IdPeriodo;
                       info.nom_activo = item.nom_activo;
                       info.nom_tipo_depreciacion = item.nom_tipo_depreciacion;
                       info.Af_costo_compra = item.Af_costo_compra;
                       info.Valor_Depre_Acum = item.Valor_Depre_Acum;
                       info.Dep_Actual = item.Dep_Actual;
                       info.Porc_Depreciacion = item.Porc_Depreciacion;
                       info.Valor_dep_Ant = item.Valor_dep_Ant;
                       info.Estado = item.Estado;
                       info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                       info.nom_ActijoFijoTipo = item.nom_ActijoFijoTipo;
                       info.IdCategoriaAF = item.IdCategoriaAF;
                       info.nom_CategoriaAF = item.nom_CategoriaAF;

                       lstRpt.Add(info);
                   }

               }

               return lstRpt;
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
