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
   public class fa_tarifario_facturacion_x_cliente_Por_comision_Data
    {
        string MensajeError = "";

        public bool Guardar(List<fa_tarifario_facturacion_x_cliente_Por_comision_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        fa_tarifario_facturacion_x_cliente_Por_comision add = new fa_tarifario_facturacion_x_cliente_Por_comision();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdTarifario = item.IdTarifario;
                        add.IdAnio = item.IdAnio;
                        add.porcentaje = item.porcentaje;
                        add.Fecha_Fin = item.Fecha_Fin;
                        add.Fecha_inicio = item.Fecha_inicio;
                        model.fa_tarifario_facturacion_x_cliente_Por_comision.Add(add);
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

        public bool Eliminar(int IdEmpresa,int IdTarifario)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    model.Database.ExecuteSqlCommand(" delete Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision where IdEmpresa = '" + IdEmpresa + "' and IdTarifario = '" + IdTarifario + "'");

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

        public List<fa_tarifario_facturacion_x_cliente_Por_comision_Info> Get_List_Tarifarios_Porcentaje_Ganancia(int idempresa, decimal idtarifario)
        {
            try
            {
                List<fa_tarifario_facturacion_x_cliente_Por_comision_Info> lista = new List<fa_tarifario_facturacion_x_cliente_Por_comision_Info>();
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    var query = from q in model.fa_tarifario_facturacion_x_cliente_Por_comision
                                where q.IdEmpresa == idempresa
                                && q.IdTarifario == idtarifario
                                select q;

                    foreach (var item in query)
                    {
                        fa_tarifario_facturacion_x_cliente_Por_comision_Info info = new fa_tarifario_facturacion_x_cliente_Por_comision_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTarifario = item.IdTarifario;
                        info.IdAnio = item.IdAnio;
                        info.porcentaje = item.porcentaje;
                        info.Fecha_Fin = item.Fecha_Fin;
                        info.Fecha_inicio = item.Fecha_inicio;
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

        public double Get_Fee(int idempresa,int Idanio, decimal IdCliente)
        {
            try
            {
                double valor = 0;
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    var query = from q in model.vwfa_tarifario_facturacion_x_cliente_Por_comision
                                where q.IdEmpresa == idempresa
                                && q.IdAnio==Idanio
                                && q.IdCliente==IdCliente
                                select q;

                    if (query.Count() > 0)
                        valor = query.FirstOrDefault().porcentaje;

                }


                return valor;
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
