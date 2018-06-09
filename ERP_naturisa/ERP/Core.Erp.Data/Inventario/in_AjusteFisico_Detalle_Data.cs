using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class in_AjusteFisico_Detalle_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(List<in_AjusteFisico_Detalle_Info>Lista) 
        {
            try
            {
                int sec = 1;
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    foreach (var item in Lista)
                    {
                        var address = new in_AjusteFisico_Detalle();
                        address.CantidadAjustada = item.CantidadAjustada;
                        address.IdAjusteFisico = item.IdAjusteFisico;
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdProducto = item.IdProducto;
                        address.Secuencia = sec;
                        address.StockFisico = item.StockFisico;
                        address.StockSistema = item.StockSistema;
                        address.IdCentroCosto = item.IdCentroCosto;

                        Contex.in_AjusteFisico_Detalle.Add(address);
                        Contex.SaveChanges();
                        sec++;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_AjusteFisico_Detalle_Info> Get_List_AjusteFisico_Detalle(int IdEmpresa, decimal IdAjusteFisico) 
        {

            try
            {

                List<in_AjusteFisico_Detalle_Info> List = new List<in_AjusteFisico_Detalle_Info>();

                EntitiesInventario oEntities = new EntitiesInventario();

                var select = from q in oEntities.in_AjusteFisico_Detalle
                             where q.IdEmpresa == IdEmpresa 
                             && q.IdAjusteFisico == IdAjusteFisico
                             select q;




                foreach (var item in select)
                {
                    in_AjusteFisico_Detalle_Info _Info = new in_AjusteFisico_Detalle_Info();
                    _Info.IdEmpresa = item.IdEmpresa;
                    _Info.IdAjusteFisico = item.IdAjusteFisico;
                    _Info.IdProducto = item.IdProducto;
                    _Info.CantidadAjustada = item.CantidadAjustada;
                    _Info.StockFisico = item.StockFisico;
                    _Info.StockSistema = item.StockSistema;
                    _Info.IdCentroCosto = item.IdCentroCosto;
                    List.Add(_Info);
                }
                return List;
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

        public Boolean EliminarDB(int IdEmpresa , decimal IdAjusteFisico) 
        {
            try
            {
                using (EntitiesInventario Entity = new EntitiesInventario())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete in_AjusteFisico_Detalle where IdEmpresa = "+IdEmpresa +" and IdAjusteFisico = "+IdAjusteFisico);    
                
                }
                return true;
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
