using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles_Fj
{
  public  class ro_fectividad_Entrega_x_Periodo_Empleado_Det_Data
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        public bool Guardar_DB(List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista)
        {
            try
            {
                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    foreach (var info in lista)
                    {
                        ro_fectividad_Entrega_x_Periodo_Empleado_Det add = new ro_fectividad_Entrega_x_Periodo_Empleado_Det();
                        add.IdEmpresa = info.IdEmpresa;
                        add.IdNomina_Tipo = info.IdNomina_Tipo;
                        add.IdNomina_tipo_Liq = info.IdNomina_tipo_Liq;
                        add.IdEfectividad = info.IdEfectividad; ;
                        add.IdPeriodo = info.IdPeriodo;
                        add.IdEmpleado = info.IdEmpleado;
                        add.IdRuta = info.IdRuta;
                        add.Recuperacion_cartera = info.Recuperacion_cartera;
                        add.Recuperacion_cartera_aplica = info.Recuperacion_cartera_aplica;
                        add.Efectividad_Entrega = info.Efectividad_Entrega;
                        add.Efectividad_Entrega_aplica = info.Efectividad_Entrega_aplica;
                        add.Efectividad_Volumen = info.Efectividad_Volumen;
                        add.Efectividad_Volumen_aplica = info.Efectividad_Volumen_aplica;
                        add.Observacion = info.Observacion;
                        db.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Add(add);
                        db.SaveChanges();
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

        public bool Modificar_DB(List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista)
        {
            try
            {
                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    foreach (var info in lista)
                    {

                        db.Database.ExecuteSqlCommand(" delete Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det where IdEmpresa='" + info.IdEmpresa + "' and IdNomina_Tipo='" + info.IdNomina_Tipo + "' and IdPeriodo='" + info.IdPeriodo + "' and IdEfectividad='" + info.IdEfectividad + "'  ");
                        ro_fectividad_Entrega_x_Periodo_Empleado_Det add = new ro_fectividad_Entrega_x_Periodo_Empleado_Det();
                        add.IdEmpresa = info.IdEmpresa;
                        add.IdNomina_Tipo = info.IdNomina_Tipo;
                        add.IdEmpleado = info.IdEmpleado;
                        add.IdRuta = info.IdRuta;
                        add.IdEfectividad = info.IdEfectividad;
                        add.IdRuta = info.IdRuta;
                        add.Efectividad_Entrega = info.Efectividad_Entrega;
                        add.Efectividad_Entrega_aplica = info.Efectividad_Entrega_aplica;
                        add.Efectividad_Volumen = info.Efectividad_Volumen;
                        add.Efectividad_Volumen_aplica = info.Efectividad_Volumen_aplica;
                        add.Recuperacion_cartera = info.Recuperacion_cartera;
                        add.Recuperacion_cartera_aplica = info.Recuperacion_cartera_aplica;
                        add.Observacion = info.Observacion;
                        add.Observacion = info.Observacion;
                        db.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Add(add);
                        db.SaveChanges();
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

        public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_x_periodo_x_empleado(int IdEmpresa, int idnomina_tipo, int IdPeriodo, int idefectividad)
        {
            try
            {
                List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();


                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {

                    var contact = from q in Context.vwro_fectividad_Entrega_x_Periodo_Empleado_Det
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdNomina_Tipo == idnomina_tipo
                                  && q.IdPeriodo == IdPeriodo
                                  && q.IdEfectividad == idefectividad
                                  select q;

                    foreach (var info in contact)
                    {
                        ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info add = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info();
                        add.IdEmpresa = info.IdEmpresa;
                        add.IdNomina_Tipo = info.IdNomina_Tipo;
                        add.IdEmpleado = info.IdEmpleado;
                        add.IdRuta = info.IdRuta;
                        add.IdEfectividad = info.IdEfectividad;
                        add.IdRuta = info.IdRuta;
                        add.Efectividad_Entrega = info.Efectividad_Entrega;
                        add.Efectividad_Entrega_aplica = info.Efectividad_Entrega_aplica;
                        add.Efectividad_Volumen = info.Efectividad_Volumen;
                        add.Efectividad_Volumen_aplica = info.Efectividad_Volumen_aplica;
                        add.Recuperacion_cartera = info.Recuperacion_cartera;
                        add.Recuperacion_cartera_aplica = info.Recuperacion_cartera_aplica;
                        add.Observacion = info.Observacion;
                        add.Observacion = info.Observacion;
                        add.ca_descripcion = info.ca_descripcion;
                        add.de_descripcion = info.de_descripcion;
                        add.pe_apellido = info.pe_apellido;
                        add.pe_nombre = info.pe_nombre;
                        add.pe_nombreCompleto = info.pe_nombreCompleto;
                        add.icono_eliminar = true;
                        add.ru_descripcion = info.ru_descripcion;
                        lista.Add(add);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_x_periodo_x_empleado(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
        {
            try
            {
                List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();


                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {

                    var contact = from q in Context.ro_fectividad_Entrega_x_Periodo_Empleado_Det
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdNomina_Tipo == idnomina_tipo
                                  && q.IdPeriodo == IdPeriodo
                                  && (q.Efectividad_Entrega_aplica > 0 || q.Efectividad_Volumen_aplica > 0 || q.Recuperacion_cartera_aplica > 0)
                                  select q;

                    foreach (var info in contact)
                    {
                        ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info add = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info();
                        add.IdEmpresa = info.IdEmpresa;
                        add.IdNomina_Tipo = info.IdNomina_Tipo;
                        add.IdNomina_tipo_Liq = info.IdNomina_tipo_Liq;
                        add.IdEmpleado = info.IdEmpleado;
                        add.Efectividad_Entrega_aplica = info.Efectividad_Entrega_aplica;
                        add.Efectividad_Volumen_aplica = info.Efectividad_Volumen_aplica;
                        add.Recuperacion_cartera_aplica = info.Recuperacion_cartera_aplica;   
                   
                        lista.Add(add);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_planificada(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
        {
            try
            {
                List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();


                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {

                    var contact = from q in Context.vwro_planificacion_x_ruta_entrega_x_empleado
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdTipoNomina == idnomina_tipo
                                  && q.IdPeriodo == IdPeriodo
                                  && q.IdRuta!=null
                                  select q;

                    foreach (var item in contact)
                    {
                        ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info Info = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info();
                        Info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        Info.IdNomina_Tipo = Convert.ToInt32(item.IdTipoNomina);
                        Info.IdEmpleado = Convert.ToInt32(item.IdEmpleado);
                        if (item.IdPeriodo != null)
                            Info.IdPeriodo = Convert.ToInt32(item.IdPeriodo);                       
                        if (item.IdRuta != null)
                            Info.IdRuta = Convert.ToInt32(item.IdRuta);
                        Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        Info.de_descripcion = item.de_descripcion;
                        Info.ca_descripcion = item.ca_descripcion;
                        Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Info.icono_eliminar = true;
                        Info.ru_descripcion = item.ru_descripcion;
                        if(item.IdGrupo!=null)
                        Info.IdGrupo =Convert.ToInt32( item.IdGrupo);
                        lista.Add(Info);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }



        public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_x_periodo_x_empleado_pagos_Adm(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
        {
            try
            {
                List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();


                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {

                    var contact = from q in Context.vwro_ro_fectividad_Entrega_x_planificacion_x_ruta_x_empleado
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdNomina_Tipo == idnomina_tipo
                                  && q.IdPeriodo == IdPeriodo
                                  && (q.Efectividad_Entrega_aplica > 0 || q.Efectividad_Volumen_aplica > 0 || q.Recuperacion_cartera_aplica > 0)
                                  select q;

                    foreach (var info in contact)
                    {
                        ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info add = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info();
                        add.IdEmpresa = info.IdEmpresa;
                        add.IdNomina_Tipo = info.IdNomina_Tipo;
                        add.IdEmpleado = info.IdEmpleado;
                        add.Efectividad_Entrega_aplica = info.Efectividad_Entrega_aplica;
                        add.Efectividad_Volumen_aplica = info.Efectividad_Volumen_aplica;
                        add.Recuperacion_cartera_aplica = info.Recuperacion_cartera_aplica;
                        

                        add.Efectividad_Entrega = info.Efectividad_Entrega;
                        add.Efectividad_Volumen= info.Efectividad_Volumen;
                        add.Recuperacion_cartera = info.Recuperacion_cartera;
                        

                        add.IdZona = info.IdZona;
                        lista.Add(add);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public int GetId(int IdEmpresa)
        {
            try
            {
                using (EntityRoles_FJ database = new EntityRoles_FJ())
                {

                    var query = (from i in database.ro_fectividad_Entrega_x_Periodo_Empleado
                                 where i.IdEmpresa == IdEmpresa
                                 select i);

                    if (query.Count() == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        var query_ = (from i in database.ro_fectividad_Entrega_x_Periodo_Empleado
                                      where i.IdEmpresa == IdEmpresa
                                      select i.IdEfectividad).Count();
                        return query.Count() + 1;
                    }

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
