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
   public class fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Data
   {
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       string MensajeError = "";
        public bool Guardar(List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info> lista)
        {
            try
            {
                int secuencia = 0;
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        secuencia++;
                        fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det add = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdDepreciacion = item.IdDepreciacion;
                        add.IdTarifario = item.IdTarifario;
                        add.Secuencia = secuencia;
                        add.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        add.IdActivoFijo = item.IdActivoFijo;
                        add.Concepto = item.Concepto;
                        add.Valor_Compra = item.Valor_Compra;
                        add.Valor_Salvamento = item.Valor_Salvamento;
                        add.Vida_Util = item.Vida_Util;
                        add.Porc_Depreciacion = item.Porc_Depreciacion;
                        add.Valor_Depreciacion = item.Valor_Depreciacion;
                        add.Valor_Depre_Acum = item.Valor_Depre_Acum;
                        add.Valor_Importe = item.Valor_Importe;
                      
                        model.fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det.Add(add);
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
                    model.Database.ExecuteSqlCommand(" delete Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det where IdEmpresa = '" + IdEmpresa + "' and IdTarifario = '" + IdTarifario + "'");

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

        public List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info> Get_List_tabla_depreciacion_x_activo(int idempresa, decimal idtarifario)
        {
            try
            {
                List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info> lista = new List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info>();
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    var query = from q in model.vwaf_fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det
                                where q.IdEmpresa == idempresa
                                && q.IdTarifario == idtarifario
                                select q;

                    foreach (var item in query)
                    {
                        fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info add = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdDepreciacion = item.IdDepreciacion;
                        add.IdTarifario = item.IdTarifario;
                        add.Secuencia = item.Secuencia;
                        add.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        add.IdActivoFijo = item.IdActivoFijo;
                        add.Concepto = item.Concepto;
                        add.Valor_Compra = item.Valor_Compra;
                        add.Valor_Salvamento = item.Valor_Salvamento;
                        add.Vida_Util = item.Vida_Util;
                        add.Porc_Depreciacion = item.Porc_Depreciacion;
                        add.Valor_Depreciacion = item.Valor_Depreciacion;
                        add.Valor_Depre_Acum = item.Valor_Depre_Acum;
                        add.Valor_Importe = item.Valor_Importe;
                        add.Af_Nombre = item.Af_Nombre;
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

        public bool Anular(List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        //var add = model.fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det.FirstOrDefault(cot => cot.IdEmpresa == item.IdTarifario && cot.Secuencia == item.Secuencia);
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
