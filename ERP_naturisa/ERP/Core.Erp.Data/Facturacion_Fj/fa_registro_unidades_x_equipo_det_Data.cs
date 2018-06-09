using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_registro_unidades_x_equipo_det_Data
    {
        string MensajeError = "";

        public List<fa_registro_unidades_x_equipo_det_Info> Get_List_det(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_Info> Lista = new List<fa_registro_unidades_x_equipo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_registro_unidades_x_equipo_det
                              where info.IdEmpresa == q.IdEmpresa
                              && info.IdRegistro == q.IdRegistro
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_Info Info_det = new fa_registro_unidades_x_equipo_det_Info();

                        Info_det.IdEmpresa = item.IdEmpresa;
                        Info_det.IdRegistro = item.IdRegistro;
                        Info_det.IdFecha = item.IdFecha;
                        Info_det.IdUnidad_Medida = item.IdUnidad_Medida;
                        Info_det.IdTipo_Reg_cat = item.IdTipo_Reg_cat;
                        Info_det.IdActivoFijo = item.IdActivoFijo;
                        Info_det.Valor = item.Valor;
                        Info_det.fecha_reg = item.fecha_reg;
                        Info_det.fecha_modi = item.fecha_modi;
                        Info_det.IdPeriodo = item.IdPeriodo;
                        Info_det.CodActivoFijo = "[" + item.IdActivoFijo + "] " + item.CodActivoFijo;
                        Lista.Add(Info_det);    
                    }                    
                }
                return Lista;
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

        public Boolean GuardarDB(List<fa_registro_unidades_x_equipo_det_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_registro_unidades_x_equipo_det_Info item in Lista)
                    {
                        fa_registro_unidades_x_equipo_det Entity = new fa_registro_unidades_x_equipo_det();

                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdRegistro = item.IdRegistro;
                        Entity.IdFecha = item.IdFecha;
                        Entity.IdUnidad_Medida = item.IdUnidad_Medida;
                        Entity.IdTipo_Reg_cat = item.IdTipo_Reg_cat;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.Valor = item.Valor;
                        Entity.fecha_reg = item.fecha_reg;
                        Entity.fecha_modi = item.fecha_modi;
                        Entity.IdPeriodo = item.IdPeriodo;

                        Context.fa_registro_unidades_x_equipo_det.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
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

        public Boolean ModificarDB(List<fa_registro_unidades_x_equipo_det_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_registro_unidades_x_equipo_det_Info item in Lista)
                    {
                        fa_registro_unidades_x_equipo_det Entity = Context.fa_registro_unidades_x_equipo_det.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa
                            && q.IdRegistro == item.IdRegistro && q.IdActivoFijo == item.IdActivoFijo);

                        if (Entity!=null)
                        {
                            Entity.IdEmpresa = item.IdEmpresa;
                            Entity.IdRegistro = item.IdRegistro;
                            Entity.IdFecha = item.IdFecha;
                            Entity.IdUnidad_Medida = item.IdUnidad_Medida;
                            Entity.IdTipo_Reg_cat = item.IdTipo_Reg_cat;
                            Entity.IdActivoFijo = item.IdActivoFijo;
                            Entity.Valor = item.Valor;
                            Entity.fecha_reg = item.fecha_reg;
                            Entity.fecha_modi = item.fecha_modi;
                            Context.SaveChanges();
                        }
                    }
                }
                return true;
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

        public Boolean EliminarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())//IdPeriodo IdRegistro
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_registro_unidades_x_equipo_det where IdEmpresa ='" + info.IdEmpresa + "' and IdPeriodo='" + info.IdPeriodo + "' and IdRegistro='"+info.IdRegistro+"'");
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

        public List<fa_registro_unidades_x_equipo_det_Info> Get_List_Conciliacion_Horas(int IdEmpresa, int IdActivo_Fijo)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_Info> Lista = new List<fa_registro_unidades_x_equipo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_Pre_Facturacion_Conciliacion_horas_No_facturadas
                              where IdEmpresa == q.IdEmpresa
                              && IdActivo_Fijo == q.IdActivoFijo
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_Info Info_det = new fa_registro_unidades_x_equipo_det_Info();

                        Info_det.IdEmpresa = item.IdEmpresa;
                        Info_det.IdRegistro = item.IdActivoFijo;
                        Info_det.IdActivoFijo = item.IdActivoFijo;
                        Info_det.IdPeriodo = item.IdPeriodo;
                        Info_det.Num_horas_registradas = item.Num_horas_registradas;
                        Info_det.Num_horas_facturadas = item.Num_horas_facturadas;
                        Info_det.Af_Nombre = item.Af_Nombre;
                        Info_det.pe_FechaIni = item.pe_FechaIni;
                        Info_det.pe_FechaFin = item.pe_FechaFin;
                        Info_det.Horas_no_Facturadas = item.Horas_no_Facturadas;



                        Lista.Add(Info_det);
                    }
                }
                return Lista;
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
        
        public List<fa_registro_unidades_x_equipo_det_Info> Get_List_Conciliacion_Horas(int IdEmpresa)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_Info> Lista = new List<fa_registro_unidades_x_equipo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_Pre_Facturacion_Conciliacion_horas_No_facturadas
                              where IdEmpresa == q.IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_Info Info_det = new fa_registro_unidades_x_equipo_det_Info();

                        Info_det.IdEmpresa = item.IdEmpresa;
                        Info_det.IdRegistro = item.IdActivoFijo;
                        Info_det.IdActivoFijo = item.IdActivoFijo;
                        Info_det.IdPeriodo = item.IdPeriodo;
                        Info_det.Num_horas_registradas = item.Num_horas_registradas;
                        Info_det.Num_horas_facturadas = item.Num_horas_facturadas;
                        Info_det.Af_Nombre = item.Af_Nombre;
                        Info_det.pe_FechaIni = item.pe_FechaIni;
                        Info_det.pe_FechaFin = item.pe_FechaFin;
                        Info_det.Horas_no_Facturadas = item.Horas_no_Facturadas;



                        Lista.Add(Info_det);
                    }
                }
                return Lista;
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





        public List<fa_registro_unidades_x_equipo_det_Info> Get_List_Conciliacion_Horas_hom_vs_ho_maq(int IdEmpresa, int IdPeriodo, int IdActivo_Fijo)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_Info> Lista = new List<fa_registro_unidades_x_equipo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_conciliacion_horas_maquina_vs_horas_hombre
                              where IdEmpresa == q.IdEmpresa
                              && IdActivo_Fijo == q.IdActivoFijo
                              && q.IdPeriodo == IdPeriodo

                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_Info Info_det = new fa_registro_unidades_x_equipo_det_Info();

                        Info_det.IdEmpresa = item.IdEmpresa;
                        Info_det.IdRegistro = item.IdActivoFijo;
                        Info_det.IdActivoFijo = item.IdActivoFijo;
                        Info_det.IdPeriodo = item.IdPeriodo;
                        Info_det.hora_trabajada = item.hora_trabajada;
                        Info_det.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        Info_det.Valor = Convert.ToDouble(item.Valor);
                        Info_det.Af_Nombre = item.Af_Nombre;
                        Info_det.Horas_Trabajada_x_Af = item.Horas_Trabajada_x_Af;
                        Info_det.pe_nombreCompleto = item.pe_nombreCompleto;


                        Lista.Add(Info_det);
                    }
                }
                return Lista;
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

        public List<fa_registro_unidades_x_equipo_det_Info> Get_List_Conciliacion_Horas_hom_vs_ho_maq(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_Info> Lista = new List<fa_registro_unidades_x_equipo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_conciliacion_horas_maquina_vs_horas_hombre
                              where IdEmpresa == q.IdEmpresa
                              &&q.IdPeriodo==IdPeriodo
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_Info Info_det = new fa_registro_unidades_x_equipo_det_Info();
                        Info_det.IdEmpresa = item.IdEmpresa;
                        Info_det.IdRegistro = item.IdActivoFijo;
                        Info_det.IdActivoFijo = item.IdActivoFijo;
                        Info_det.IdPeriodo = item.IdPeriodo;
                        Info_det.hora_trabajada = item.hora_trabajada;
                        Info_det.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        Info_det.Valor =Convert.ToDouble(item.Valor);
                        Info_det.Af_Nombre = item.Af_Nombre;
                        Info_det.Horas_Trabajada_x_Af = item.Horas_Trabajada_x_Af;
                        Info_det.pe_nombreCompleto = item.pe_nombreCompleto;
                        Lista.Add(Info_det);
                    }
                }
                return Lista;
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
