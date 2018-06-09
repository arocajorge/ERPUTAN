using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
  public  class ro_historico_liquidacion_vacaciones_Data
    {
      ro_Empleado_Data empleado_data = new ro_Empleado_Data();  
      string mensaje = "";
        public Boolean GrabarBD( ro_historico_liquidacion_vacaciones_Info Info)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {




                    var select = from q in db.ro_Historico_Liquidacion_Vacaciones
                                 where q.IdEmpresa == Info.IdEmpresa
                                 && q.IdSolicitud_Vacaciones == Info.IdSolicitud_Vacaciones
                                 && q.IdEmpleado == Info.IdEmpleado
                                 select q;

                    if (select.ToList().Count > 0)
                    {
                        
                            var contact = db.ro_Historico_Liquidacion_Vacaciones.First(obj => obj.IdEmpresa == Info.IdEmpresa &&
                            obj.IdSolicitud_Vacaciones == Info.IdSolicitud_Vacaciones && obj.IdEmpleado == Info.IdEmpleado);

                            contact.FechaPago = Info.FechaPago;
                            contact.IdNomina_Tipo = Info.IdNomina_Tipo;
                            contact.ValorCancelado = Info.ValorCancelado;
                            db.SaveChanges();
                       
                    }
                    else
                    {

                        ro_Historico_Liquidacion_Vacaciones Data = new ro_Historico_Liquidacion_Vacaciones();

                        Data.IdEmpresa = Info.IdEmpresa;
                        Data.IdNomina_Tipo = Info.IdNomina_Tipo;
                        Data.IdSolicitud_Vacaciones = Info.IdSolicitud_Vacaciones;
                        Data.IdEmpresa_OP = Info.IdEmpresa_OP;
                        Data.IdOrdenPago = Info.IdOrdenPago;
                        Data.IdEmpleado = Info.IdEmpleado;
                        Data.ValorCancelado = Info.ValorCancelado;
                        Data.FechaPago = Info.FechaPago;
                        Data.Observaciones = Info.Observaciones;
                        Data.IdUsuario = Info.IdUsuario;
                        Data.Estado = "A";
                        Data.Fecha_Transac = DateTime.Now;

                        db.ro_Historico_Liquidacion_Vacaciones.Add(Data);
                        db.SaveChanges();


                        empleado_data.Modificar_Estado(Info.IdEmpresa, Info.IdNomina_Tipo, Convert.ToInt32(Info.IdEmpleado), "EST_VAC");
                    }

















                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }

        }
        public Boolean EliminarDB(ro_historico_liquidacion_vacaciones_Info info)
        {
            try
            {
                EntitiesRoles OERoles = new EntitiesRoles();
                var select = from q in OERoles.ro_Historico_Liquidacion_Vacaciones
                             where q.IdEmpresa == info.IdEmpresa
                             && q.IdSolicitud_Vacaciones == info.IdSolicitud_Vacaciones
                             && q.IdEmpleado==info.IdEmpleado
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesRoles context = new EntitiesRoles())
                    {
                        var contact = context.ro_Historico_Liquidacion_Vacaciones.First(obj => obj.IdEmpresa == info.IdEmpresa &&
                             obj.IdSolicitud_Vacaciones == info.IdSolicitud_Vacaciones && obj.IdEmpleado == info.IdEmpleado);
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.FechaHoraAnul = DateTime.Now;
                        contact.MotiAnula = info.MotiAnula;
                        context.SaveChanges();
                    }

                    return true;
                }
                else
                {
                   // msg = "No es posible anular el registro del Cargo #: " + info.IdCargo.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public double Get_Valor_vacaciones(int IdEmpresa,int IdNomina_tipo,int IdEmpleado,DateTime Fecha_Inicio,DateTime Fecha_Fin,string IdRubro)
        {
            try
            {
                double Valor = 0;

                using (EntitiesRoles db = new EntitiesRoles())
                {
                var select = from C in db.spROL_Valor_Ganado_Vacaciones(IdEmpresa,IdNomina_tipo,IdEmpleado,Fecha_Inicio,Fecha_Fin,IdRubro)
                             select C;

                foreach (var item in select)
                {
                    Valor =Convert.ToDouble( item.Valor);
                }
                   
                }
                return Valor;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
