using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_tarifario_facturacion_x_cliente_det_Data
    {
        string MensajeError = "";

        public bool Guardar(List<fa_tarifario_facturacion_x_cliente_det_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        fa_tarifario_facturacion_x_cliente_det add = new fa_tarifario_facturacion_x_cliente_det();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdTarifario = item.IdTarifario;
                        add.Secuencia = item.Secuencia;
                        add.cantidad = item.cantidad;
                        add.IdCategoriaAF = item.IdCategoriaAF;
                        add.Valor_x_Unidad = item.Valor_x_Unidad;
                        add.Unidades_minimas = item.Unidades_minimas;
                        add.IdUsuario = item.IdUsuario;
                        add.Estado = "A";
                        model.fa_tarifario_facturacion_x_cliente_det.Add(add);
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

        public bool Eliminar(fa_tarifario_facturacion_x_cliente_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    model.Database.ExecuteSqlCommand(" delete Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det where IdEmpresa = '" + info.IdEmpresa + "' and IdTarifario = '" + info.IdTarifario + "'");

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

        public List<fa_tarifario_facturacion_x_cliente_det_Info> Get_List_Tarifarios(int idempresa, decimal idtarifario)
        {
            try
            {
                List<fa_tarifario_facturacion_x_cliente_det_Info> lista = new List<fa_tarifario_facturacion_x_cliente_det_Info>();
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    var query = from q in model.fa_tarifario_facturacion_x_cliente_det
                                where q.IdEmpresa == idempresa
                                && q.IdTarifario == idtarifario
                                select q;

                    foreach (var item in query)
                    {
                        fa_tarifario_facturacion_x_cliente_det_Info info = new fa_tarifario_facturacion_x_cliente_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTarifario = item.IdTarifario;
                        info.Secuencia = item.Secuencia;
                        info.cantidad = item.cantidad;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.Valor_x_Unidad = item.Valor_x_Unidad;
                        info.Unidades_minimas = item.Unidades_minimas;
                        info.IdUsuario = item.IdUsuario;
                        info.Estado = item.Estado;
                        lista.Add(info);
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

        public bool Anular(List<fa_tarifario_facturacion_x_cliente_det_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        var add = model.fa_tarifario_facturacion_x_cliente_det.FirstOrDefault(cot => cot.IdEmpresa == item.IdTarifario && cot.Secuencia == item.Secuencia);
                        add.Estado = "I";
                        add.Fecha_UltAnu = DateTime.Now;
                        add.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
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

    }
}
