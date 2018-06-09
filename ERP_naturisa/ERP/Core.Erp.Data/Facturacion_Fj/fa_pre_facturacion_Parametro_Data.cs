using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion_FJ;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_pre_facturacion_Parametro_Data
    {
        public fa_pre_facturacion_Parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                fa_pre_facturacion_Parametro_Info Info = new fa_pre_facturacion_Parametro_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion_Parametro contact = Context.fa_pre_facturacion_Parametro.FirstOrDefault(q => q.IdEmpresa == IdEmpresa);

                    if (contact != null)
                    {
                        Info.IdEmpresa = contact.IdEmpresa;
                        Info.Se_Cobra_Iva = contact.Se_Cobra_Iva;
                        Info.Tipo_Cobro_Poliza_X = contact.Tipo_Cobro_Poliza_X;
                        Info.IdSucursal_para_facturar = (contact.IdSucursal_para_facturar == null) ? 0 : Convert.ToInt32(contact.IdSucursal_para_facturar);
                        Info.IdBodega_para_facturar = (contact.IdBodega_para_facturar == null) ? 0 : Convert.ToInt32(contact.IdBodega_para_facturar);
                        Info.Liquidar_x_grupo = contact.Liquidar_x_grupo;
                       // Info.Margen_Ganancia_por_BS = contact.Margen_Ganancia_por_BS;
                       // Info.Margen_Ganancia_por_MO = contact.Margen_Ganancia_por_MO;
                    }
                }
                return Info;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_pre_facturacion_Parametro_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion_Parametro contact = new fa_pre_facturacion_Parametro();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.Se_Cobra_Iva = Info.Se_Cobra_Iva;
                    contact.Tipo_Cobro_Poliza_X = Info.Tipo_Cobro_Poliza_X;
                    contact.Liquidar_x_grupo = Info.Liquidar_x_grupo;
                   // contact.Margen_Ganancia_por_BS = Info.Margen_Ganancia_por_BS;
                   // contact.Margen_Ganancia_por_MO = Info.Margen_Ganancia_por_MO;
                    Context.fa_pre_facturacion_Parametro.Add(contact);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_pre_facturacion_Parametro_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion_Parametro contact = Context.fa_pre_facturacion_Parametro.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.Se_Cobra_Iva = Info.Se_Cobra_Iva;
                        contact.Tipo_Cobro_Poliza_X = Info.Tipo_Cobro_Poliza_X;
                        contact.Liquidar_x_grupo = Info.Liquidar_x_grupo;
                        //contact.Margen_Ganancia_por_BS = Info.Margen_Ganancia_por_BS;
                        //contact.Margen_Ganancia_por_MO = Info.Margen_Ganancia_por_MO;
                        Context.SaveChanges();
                    }
                    else
                    {
                        if (GuardarDB(Info, ref mensaje))
                        { return true; }
                        else
                        { return false; }
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
                throw new Exception(ex.ToString());
            }
        }
    }
}
