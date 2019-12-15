using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
namespace Core.Erp.Business.Bancos
{
    public class ba_Archivo_Transferencia_Det_Bus
    {
        ba_Archivo_Transferencia_Det_Data oData = new ba_Archivo_Transferencia_Det_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cxc_cobro_Bus bus_cobro = new cxc_cobro_Bus();
        ba_Cbte_Ban_Info Info_Comprobante_Bancario;
        ba_Cbte_Ban_Bus Bus_Comprobante_Bancario = new ba_Cbte_Ban_Bus();
        ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();

        public List<ba_Archivo_Transferencia_Det_Info> Get_List_Archivo_transferencia_Det(int idEmpresa, decimal idArchivo)
        {
            try
            {
                return oData.Get_List_Archivo_transferencia_Det(idEmpresa, idArchivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }

        public List<ba_Archivo_Transferencia_Det_Info> Get_List_Vista_Archivo_transferencia_Det(int idEmpresa, int idBancoIni, int idBancoFin, string idProceso, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_List_Vista_Archivo_transferencia_Det(idEmpresa, idBancoIni, idBancoFin, idProceso, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Vista_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };
            }
        }

        public Boolean Actualizar_registro(ba_Archivo_Transferencia_Det_Info Info)
        {
            try
            {
                return oData.Actualizar_registro(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_registro", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }

        public bool GrabarDB(List<ba_Archivo_Transferencia_Det_Info> Lista)
        {
            try
            {
                return oData.GrabarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }

        public bool AnularDB(List<ba_Archivo_Transferencia_Det_Info> Lista)
        {
            try
            {
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info InfoParam_Banco = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BusParam_Banco = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

                InfoParam_Banco = BusParam_Banco.Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa, "NDBA");
                int IdTipo_rev = InfoParam_Banco.IdTipoCbteCble_Anu;

                string MensajeError = "";
                foreach (var item in Lista)
                {
                    oData.AnularDB(item);

                    Info_Comprobante_Bancario = Bus_Comprobante_Bancario.Get_Info_Cbte_Ban(Convert.ToInt32(item.IdEmpresa_pago), Convert.ToInt32(item.IdTipoCbte_pago), Convert.ToDecimal(item.IdCbteCble_pago), ref MensajeError);
                    if (Info_Comprobante_Bancario != null && Info_Comprobante_Bancario.IdEmpresa != 0)
                    {
                        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
                        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();

                        Info_Comprobante_Bancario.MotivoAnulacion = "Anulado por administrador de archivos";
                        Info_Comprobante_Bancario.IdUsuario_Anu = param.IdUsuario;
                        Info_Comprobante_Bancario.FechaAnulacion = param.Fecha_Transac;
                        decimal IdCbteCble_rev = 0;
                        CbteCble_B.ReversoCbteCble(Convert.ToInt32(item.IdEmpresa_pago), Convert.ToDecimal(item.IdCbteCble_pago), Convert.ToInt32(item.IdTipoCbte_pago), IdTipo_rev, ref IdCbteCble_rev, ref MensajeError, Info_Comprobante_Bancario.MotivoAnulacion);

                        Info_Comprobante_Bancario.IdTipoCbte_Anulacion = IdTipo_rev;
                        Info_Comprobante_Bancario.IdCbteCble_Anulacion = IdCbteCble_rev;
                        cp_orden_pago_cancelaciones_Bus OGPagos_B = new cp_orden_pago_cancelaciones_Bus();
                        OGPagos_B.Eliminar_OrdenPagoCancelaciones(Info_Comprobante_Bancario.IdEmpresa, Info_Comprobante_Bancario.IdTipocbte, Info_Comprobante_Bancario.IdCbteCble, ref MensajeError);
                        Bus_Comprobante_Bancario.AnularDB(Info_Comprobante_Bancario, ref MensajeError);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdArchivo)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa,IdArchivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }

        public decimal Get_Secuencial_registro_BB(int IdEmpresa, string IdProceso_bancario)
        {
            try
            {
                return oData.Get_Secuencial_registro_BB(IdEmpresa, IdProceso_bancario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Secuencial_registro_BB", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }

        public decimal Get_secuencial_registro_BB_modificar(int IdEmpresa, string IdProceso_bancario, decimal IdArchivo)
        {
            try
            {
                return oData.Get_secuencial_registro_BB_modificar(IdEmpresa, IdProceso_bancario, IdArchivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_secuencial_registro_BB_modificar", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }

        public Boolean ModificarDB(ba_Archivo_Transferencia_Det_Info Info)
        {
            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };

            }
        }
    }
}
