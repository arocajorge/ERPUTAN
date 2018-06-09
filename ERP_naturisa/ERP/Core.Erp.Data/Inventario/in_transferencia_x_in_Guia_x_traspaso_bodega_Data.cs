using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Inventario
{
    public class in_transferencia_x_in_Guia_x_traspaso_bodega_Data
    {
        string mensaje = "";

        public Boolean VerificacionGuia_x_transferencia(int IdEmpresa_Guia, decimal IdGuia)
        {
            try
            {
                using (EntitiesInventario oen = new EntitiesInventario())
                {
                    var select = from q in oen.in_transferencia_x_in_Guia_x_traspaso_bodega
                                 where q.IdGuia == IdGuia && q.IdEmpresa_Guia == IdEmpresa_Guia 
                                 select q;

                    if (select.Count() == 0)
                        return true;
                    else
                        return false;
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

        public Boolean GuardarDB(in_transferencia_x_in_Guia_x_traspaso_bodega_Info InfoGuia, ref string msjError)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var Address = new in_transferencia_x_in_Guia_x_traspaso_bodega();
                    Address.IdEmpresa = InfoGuia.IdEmpresa;
                    Address.IdSucursalOrgen = InfoGuia.IdSucursalOrgen;
                    Address.IdBodegaOrigen = InfoGuia.IdBodegaOrigen;
                    Address.IdTransferencia = InfoGuia.IdTransferencia;
                    Address.IdEmpresa_Guia = InfoGuia.IdEmpresa_Guia;
                    Address.IdGuia = InfoGuia.IdGuia;
                    Address.Observacion = InfoGuia.Observacion;

                    Context.in_transferencia_x_in_Guia_x_traspaso_bodega.Add(Address);
                    Context.SaveChanges();
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

        public Boolean EliminarDB(in_transferencia_Info InfoTrans ) 
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    string comando = "DELETE in_transferencia_x_in_Guia_x_traspaso_bodega where IdEmpresa = "+InfoTrans.IdEmpresa+" and IdSucursalOrgen = "+InfoTrans.IdSucursalOrigen+" and IdBodegaOrigen = "+InfoTrans.IdBodegaOrigen+" and IdTransferencia = "+InfoTrans.IdTransferencia;
                    Context.Database.ExecuteSqlCommand(comando);
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
