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
    
  public  class fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string MensajeError = "";
        public bool Guardar(fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info item, ref int IdDepreciacion)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                   
                        fa_tarifario_facturacion_x_cliente_Af_Depreciacion add = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdDepreciacion = GetId(item.IdEmpresa);
                        add.IdTarifario = item.IdTarifario;
                        add.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        add.IdPeriodo = item.IdPeriodo;
                        add.Descripcion = item.Descripcion;
                        add.Fecha_Depreciacion = item.Fecha_Depreciacion;
                        add.Num_Act_Depre = item.Num_Act_Depre;
                        add.Valor_Tot_Depre = item.Valor_Tot_Depre;
                        add.Valor_Tot_DepreAcum = item.Valor_Tot_DepreAcum;
                        add.Valot_Tot_Importe = item.Valot_Tot_Importe;
                        model.fa_tarifario_facturacion_x_cliente_Af_Depreciacion.Add(add);
                        model.SaveChanges();
                        IdDepreciacion = (int)add.IdDepreciacion;

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
                    model.Database.ExecuteSqlCommand(" delete Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Af_Depreciacion where IdEmpresa = '" + IdEmpresa + "' and IdTarifario = '" + IdTarifario + "'");

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

        public List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info> Get_List_Activo_fijos_Depreciar(int idempresa, decimal idtarifario)
        {
            try
            {
                List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info> lista = new List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info>();
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    var query = from q in model.fa_tarifario_facturacion_x_cliente_Af_Depreciacion
                                where q.IdEmpresa == idempresa
                                && q.IdTarifario == idtarifario
                                select q;

                    foreach (var item in query)
                    {
                        fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info add = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdDepreciacion = item.IdDepreciacion;
                        add.IdTarifario = item.IdTarifario;
                        add.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        add.IdPeriodo = item.IdPeriodo;
                        add.Descripcion = item.Descripcion;
                        add.Fecha_Depreciacion = item.Fecha_Depreciacion;
                        add.Num_Act_Depre = item.Num_Act_Depre;
                        add.Valor_Tot_Depre = item.Valor_Tot_Depre;
                        add.Valor_Tot_DepreAcum = item.Valor_Tot_DepreAcum;
                        add.Valot_Tot_Importe = item.Valot_Tot_Importe;
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

        public bool Anular(List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    //foreach (var item in lista)
                    //{
                    //    var add = model.fa_tarifario_facturacion_x_cliente_Af_Depreciacion.FirstOrDefault(cot => cot.IdEmpresa == item.IdTarifario && cot.Secuencia == item.Secuencia);
                    //    add.Estado = "I";
                    //    add.Fecha_UltAnu = DateTime.Now;
                    //    add.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    //    model.SaveChanges();

                    //}

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

        public int GetId(int idEmpresa)
        {
            try
            {
                int Id;
                Entity_Facturacion_FJ db = new Entity_Facturacion_FJ();

                var selecte = db.fa_tarifario_facturacion_x_cliente_Af_Depreciacion.Count(q => q.IdEmpresa == idEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.fa_tarifario_facturacion_x_cliente_Af_Depreciacion
                                     where q.IdEmpresa == idEmpresa
                                     select q.IdDepreciacion).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
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
