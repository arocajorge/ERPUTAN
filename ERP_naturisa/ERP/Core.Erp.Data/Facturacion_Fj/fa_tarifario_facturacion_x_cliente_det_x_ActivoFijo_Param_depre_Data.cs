using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Facturacion_Fj
{
   public class fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string MensajeError = "";
        public bool Guardar(List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre add = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdTarifario = item.IdTarifario;
                        add.IdActivoFijo = item.IdActivoFijo;
                        add.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                        add.Af_anios_vida_util = item.Af_anios_vida_util;
                        add.Af_costo_historico = item.Af_costo_historico;
                        add.Af_costo_compra = item.Af_costo_compra;
                        add.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        add.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        add.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        add.se_factura_valorSalvamento = item.se_factura_valorSalvamento;
                        add.Af_ValorSalvamento = item.Af_ValorSalvamento;
                        add.Af_ValorResidual = item.Af_ValorResidual;
                        add.se_factura_Iva = item.se_factura_Iva;
                        model.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre.Add(add);
                        model.SaveChanges();

                    }

                    return true;

                }

            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool Eliminar(int IdEmpresa, int IdTarifario)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    model.Database.ExecuteSqlCommand(" delete Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre where IdEmpresa = '" + IdEmpresa + "' and IdTarifario = '" +IdTarifario + "'");

                    return true;

                }

            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info> Get_List_Param_depreciacion_AF(int idempresa, decimal idtarifario)
        {
            try
            {
                List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info> lista = new List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info>();
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    var query = from q in model.vwfa_fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre
                                where q.IdEmpresa == idempresa
                                && q.IdTarifario == idtarifario
                                select q;

                    foreach (var item in query)
                    {
                        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info add = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info();


                        add.IdEmpresa = item.IdEmpresa;
                        add.IdTarifario = item.IdTarifario;
                        add.IdActivoFijo = item.IdActivoFijo;
                        add.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                        add.Af_anios_vida_util = item.Af_anios_vida_util;
                        add.Af_costo_historico = item.Af_costo_historico;
                        add.Af_costo_compra = item.Af_costo_compra;
                        add.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        add.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        add.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        add.se_factura_valorSalvamento = item.se_factura_valorSalvamento;
                        add.Af_ValorSalvamento = item.Af_ValorSalvamento;
                        add.Af_ValorResidual = item.Af_ValorResidual;
                        add.Af_Nombre = item.Af_Nombre;
                        add.se_factura_Iva = item.se_factura_Iva;
                        lista.Add(add);
                    }
                    return lista;

                }

            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool Anular(List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        //var add = model.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre.FirstOrDefault(cot => cot.IdEmpresa == item.IdTarifario && cot.Secuencia == item.Secuencia);
                        //add.Estado = "I";
                        //add.Fecha_UltAnu = DateTime.Now;
                        //add.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        //model.SaveChanges();

                    }

                    return true;

                }

            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

    }
}
