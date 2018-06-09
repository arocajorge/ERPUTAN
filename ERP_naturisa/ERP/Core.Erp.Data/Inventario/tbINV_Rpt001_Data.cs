using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class tbINV_Rpt001_Data
    {
        string mensaje = "";
        public List<tbINV_Rpt001_Info> RptConsulta(int IdEmpresa , string IdUsuario) 
        {
            try
            {
                //using (EntitiesInventario entity = new EntitiesInventario())
                //{
                //    IEnumerable<tbINV_Rpt001_Info> Consulta = from q in entity.tbINV_Rpt001
                //                                              where q.IdEmpresa_SP == IdEmpresa  && q.IdUsuario_SP== IdUsuario
                //                                              select new tbINV_Rpt001_Info
                //                                              {
                //                                                  IdEmpresa_SP = q.IdEmpresa_SP,
                //                                                  IdUsuario_SP = q.IdUsuario_SP,
                //                                                  Fecha_Transac = q.Fecha_Transac,
                //                                                  nom_pc = q.nom_pc,
                //                                                  Su_Descripcion = q.Su_Descripcion,
                //                                                  bo_Descripcion = q.bo_Descripcion,
                //                                                  IdCategoria = q.IdCategoria,
                //                                                  ca_Categoria = q.ca_Categoria,
                //                                                  pr_codigo = q.pr_codigo,
                //                                                  pr_descripcion = q.pr_descripcion,
                //                                                  pr_peso = q.pr_peso,
                //                                                  stock = q.stock,
                //                                                  Tonelaje_x_Sucursal = q.Tonelaje_x_Sucursal,
                //                                                  pr_Pedidos = q.pr_Pedidos,
                //                                                  Toneladas_x_Pedido = q.Toneladas_x_Pedido,
                //                                                  Disponible = q.Disponible,
                //                                                  Tonelaje_Disponible = q.Tonelaje_Disponible
                //                                              };



                //        return Consulta.ToList() ;
                //}
                return new List<tbINV_Rpt001_Info>();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
