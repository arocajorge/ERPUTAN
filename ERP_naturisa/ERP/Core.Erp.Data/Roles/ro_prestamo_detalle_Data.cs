/*CLASE: ro_prestamo_detalle_Data
 *MODIFICADA POR: ALBERTO MENA
 *FECHA: 01-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_prestamo_detalle_Data
    {
        string mensaje = "";
        public decimal GetIdPrestamo()
        {
            try
            {
                decimal Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_prestamo
                        //  where C.IdEmpresa == idempresa //&& C.IdEmpleado == idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ro_prestamo
                                   select t.IdPrestamo).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_prestamo_detalle_Info> ConsultaxIdPrestamo(int IdEmpresa, decimal IdPrestamo)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {

                   
                    IQueryable<ro_prestamo_detalle_Info> Consulta = from q in Context.ro_prestamo_detalle
                                                                    where q.IdEmpresa == IdEmpresa && q.IdPrestamo == IdPrestamo
                                                                    select new ro_prestamo_detalle_Info
                                                                    {
                                                                        IdEmpresa = IdEmpresa,
                                                                        IdPrestamo = IdPrestamo,
                                                                        NumCuota = q.NumCuota,
                                                                        IdNominaTipoLiqui=q.IdNominaTipoLiqui,
                                                                        SaldoInicial = q.SaldoInicial,
                                                                        Interes = q.Interes,
                                                                        AbonoCapital = q.AbonoCapital,
                                                                        TotalCuota = q.TotalCuota,
                                                                        Saldo = q.Saldo,
                                                                        FechaPago = q.FechaPago,
                                                                        EstadoPago = q.EstadoPago,
                                                                        Estado = q.Estado,
                                                                        Observacion_det = q.Observacion_det,
                                                                        IdUsuario = q.IdUsuario,
                                                                        Fecha_Transac = q.Fecha_Transac,
                                                                        IdUsuarioUltMod = q.IdUsuarioUltMod,
                                                                        IdUsuarioUltAnu = q.IdUsuarioUltAnu,
                                                                        nom_pc = q.nom_pc,
                                                                        ip = q.ip,
                                                                        MotiAnula = q.MotiAnula
                                                                    };
                    return Consulta.ToList();
                }
            }

            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_prestamo_detalle_Info> GetListConsultaPorEmpleado(int idEmpresa, ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo, decimal idEmpleado)
        {
            try
            {
                List<ro_prestamo_detalle_Info> oListado = new List<ro_prestamo_detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var datos = (from a in db.vwRo_Prestamo_Detalle
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdEmpleado == idEmpleado
                                 && a.IdNomina_Tipo == info_periodo.IdNomina_Tipo
                                 && a.IdNominaTipoLiqui == info_periodo.IdNomina_TipoLiqui
                                 &&a.EstadoDetalle == "A" 
                                 && a.EstadoPago == "PEN"
                                 && a.FechaPago>=info_periodo.pe_FechaIni
                                 && a.FechaPago<=info_periodo.pe_FechaFin
                                 select a);

                    foreach (var item in datos)
                    {
                        ro_prestamo_detalle_Info info = new ro_prestamo_detalle_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNomina_Tipo = item.IdNomina_Tipo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdPrestamo = item.IdPrestamo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdRubro = item.IdRubro;
                        info.TotalCuota = item.TotalCuota;
                        info.NumCuota = item.NumCuota;
                        info.SaldoInicial = item.SaldoInicial;
                        info.Interes = item.Interes;
                        info.AbonoCapital = item.AbonoCapital;
                        info.ru_codRolGen = item.ru_codRolGen;
                        info.ru_descripcion = item.ru_descripcion;
                        info.EstadoPrestamo = item.EstadoPrestamo;
                        info.Saldo = item.Saldo;
                        info.FechaPago = item.FechaPago;
                        info.EstadoPago = item.EstadoPago;
                        info.EstadoDetalle = item.EstadoDetalle;
                        oListado.Add(info);
                    }
                    return oListado;
                }
            }

            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_prestamo_detalle_Info> GetListConsultaPorEmpleado(int idEmpresa,  decimal idEmpleado)
        {
            try
            {
                List<ro_prestamo_detalle_Info> oListado = new List<ro_prestamo_detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var datos = (from a in db.vwRo_Prestamo_Detalle
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdEmpleado == idEmpleado
                                 && a.EstadoDetalle == "A"
                                 && a.EstadoPago == "PEN"
                                 select a);

                    foreach (var item in datos)
                    {
                        ro_prestamo_detalle_Info info = new ro_prestamo_detalle_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNomina_Tipo = item.IdNomina_Tipo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdPrestamo = item.IdPrestamo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdRubro = item.IdRubro;
                        info.TotalCuota = item.TotalCuota;
                        info.NumCuota = item.NumCuota;
                        info.SaldoInicial = item.SaldoInicial;
                        info.Interes = item.Interes;
                        info.AbonoCapital = item.AbonoCapital;
                        info.ru_codRolGen = item.ru_codRolGen;
                        info.ru_descripcion = item.ru_descripcion;
                        info.EstadoPrestamo = item.EstadoPrestamo;
                        info.Saldo = item.Saldo;
                        info.FechaPago = item.FechaPago;
                        info.EstadoPago = item.EstadoPago;
                        info.EstadoDetalle = item.EstadoDetalle;
                        oListado.Add(info);
                    }
                    return oListado;
                }
            }

            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public List<ro_prestamo_detalle_Info> GetListConsultaGeneral(int idEmpresa)
        {
            try
            {
                List<ro_prestamo_detalle_Info> oListado = new List<ro_prestamo_detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var datos = (from a in db.vwRo_Prestamo_Detalle
                                 where a.IdEmpresa == idEmpresa
                                 select a);

                    foreach (var item in datos)
                    {
                        ro_prestamo_detalle_Info info = new ro_prestamo_detalle_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNomina_Tipo = item.IdNomina_Tipo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdPrestamo = item.IdPrestamo;
                        info.IdRubro = item.IdRubro;
                        info.TotalCuota = item.TotalCuota;
                        info.NumCuota = item.NumCuota;
                        info.SaldoInicial = item.SaldoInicial;
                        info.Interes = item.Interes;
                        info.AbonoCapital = item.AbonoCapital;
                        info.ru_codRolGen = item.ru_codRolGen;
                        info.ru_descripcion = item.ru_descripcion;
                        info.EstadoPrestamo = item.EstadoPrestamo;
                        info.Saldo = item.Saldo;
                        info.FechaPago = item.FechaPago;
                        info.EstadoPago = item.EstadoPago;
                        info.EstadoDetalle = item.EstadoDetalle;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        oListado.Add(info);
                    }
                    return oListado;
                }
            }

            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public Boolean GuardarPrestamoDetalle(List<ro_prestamo_detalle_Info> Lst, ref decimal Id, ref string mensaje)
        {
            try
            {
                int NumCuota_ = 0;
                foreach (var Item in Lst)
                {

                    using (EntitiesRoles Context = new EntitiesRoles())
                    {
                        ro_prestamo_detalle Deta = new ro_prestamo_detalle();

                        NumCuota_ = NumCuota_ + 1;
                        Deta.IdEmpresa = Item.IdEmpresa;
                        Deta.IdNominaTipoLiqui = Item.IdNominaTipoLiqui;

                        Deta.IdPrestamo = Id;
                        Deta.NumCuota = NumCuota_;
                        Deta.SaldoInicial = Item.SaldoInicial;
                        Deta.Interes = Item.Interes;
                        
                        Deta.AbonoCapital = Item.AbonoCapital;
                        Deta.TotalCuota = Item.TotalCuota;

                        Deta.Saldo = Item.Saldo;
                        Deta.FechaPago = Item.FechaPago;
                        Deta.EstadoPago = Item.EstadoPago;
                        Deta.Estado = Item.Estado;
                        Deta.Observacion_det = Item.Observacion_det;

                        Deta.IdUsuario = Item.IdUsuario;
                        Deta.Fecha_Transac = Item.Fecha_Transac;
                        Deta.nom_pc = Item.nom_pc;
                        Deta.ip = Item.ip;

                        Context.ro_prestamo_detalle.Add(Deta);
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

       
        public Boolean AnularDetallePrestamo(List<ro_prestamo_detalle_Info> listadetalle, ref string mensaje)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    foreach (var item in listadetalle)
                    {

                        var contact = context.ro_prestamo_detalle.First(VProdu => VProdu.IdEmpresa == item.IdEmpresa && VProdu.IdPrestamo == item.IdPrestamo
                            && VProdu.NumCuota == item.NumCuota);

                        contact.Estado = "I";

                        context.SaveChanges();

                        mensaje = "Se ha procedido a Anular el detalle #: " + item.IdPrestamo + " Exitosamente...";
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean EliminarDetallePrestamo(List<ro_prestamo_detalle_Info> listadetalle)
        {
            try
            {
                using (EntitiesRoles Enti = new EntitiesRoles())
                {
                    foreach (var item in listadetalle)
                    {
                        var contact = Enti.ro_prestamo_detalle.First(q => q.IdEmpresa == item.IdEmpresa && q.IdPrestamo == item.IdPrestamo
                     && q.NumCuota == item.NumCuota);
                        Enti.ro_prestamo_detalle.Remove(contact);
                        Enti.SaveChanges();
                    }


                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean ModificarEstadoCobroDB(ro_prestamo_detalle_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_prestamo_detalle.First(VProdu => VProdu.IdEmpresa == info.IdEmpresa && VProdu.IdPrestamo == info.IdPrestamo && VProdu.NumCuota == info.NumCuota);
                    contact.EstadoPago = info.EstadoPago;
                    context.SaveChanges();

                    mensaje = "Se ha procedido a Actualizar la Información Exitosamente...";
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public double SaldoPendiente(int IdEmpresa, int IdEmpleado)
        {
            double saldo = 0;
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var datos = (from a in context.vwRo_Prestamo_Detalle
                                 where a.IdEmpresa == IdEmpresa
                                 && a.IdEmpleado == IdEmpleado
                                 && a.EstadoPago == "PEN"
                                 && a.EstadoDetalle == "A"
                                 select a.TotalCuota).Sum();


                    saldo = datos;
                }
                return saldo;
            }
            catch (Exception ex)
            {

                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public bool Cambiar_estado_cancelada(int idEmpresa, int idnomina_tipo, DateTime fecha_inicio, DateTime fecha_fin)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    string SQL = " update ro_prestamo_detalle set EstadoPago='CAN'" +
                                                    " from ro_prestamo as C, ro_prestamo_detalle as D" +
                                                    " where C.IdPrestamo=D.IdPrestamo and C.IdEmpresa='" + idEmpresa + "' and C.IdNomina_Tipo='" + idnomina_tipo + "'  and D.FechaPago between '" + fecha_inicio + "' and '" + fecha_fin + "'";

                    db.Database.ExecuteSqlCommand(SQL);
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Abono_Prestamo(List<ro_prestamo_detalle_Info> listadetalle, ref string mensaje)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    foreach (var item in listadetalle)
                    {

                        var contact = context.ro_prestamo_detalle.First(VProdu => VProdu.IdEmpresa == item.IdEmpresa && VProdu.IdPrestamo == item.IdPrestamo
                            && VProdu.NumCuota == item.NumCuota);

                        contact.EstadoPago = item.EstadoPago;
                        contact.Fecha_UltMod = item.Fecha_UltMod;
                        contact.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        context.SaveChanges();

                        mensaje = "Se ha procedido a Anular el detalle #: " + item.IdPrestamo + " Exitosamente...";
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean Eliminar_Cuotas_Pendientes(int IdEmpresa, int IdPrestamo)
        {
           
                try
                {

                    using (EntitiesRoles db = new EntitiesRoles())
                    {
                        String SQL = "delete ro_prestamo_detalle where IdEmpresa='" + IdEmpresa + "' and IdPrestamo='" + IdPrestamo + "' and EstadoPago='PEN' ";
                        db.Database.ExecuteSqlCommand(SQL);
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    string array = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;
                    throw new Exception(ex.InnerException.ToString());
                }
            }

        public bool Modificar_Cuotas_Forma_Pago(List<ro_prestamo_detalle_Info> listadetalle)
        {
            try
            {
                int secuencia = 0;
                using (EntitiesRoles context = new EntitiesRoles())
                {
                   


                    ro_prestamo_detalle_Info info = new ro_prestamo_detalle_Info();
                    info = listadetalle.FirstOrDefault();
                    // elimino las cuotas de estado pendientes
                    Eliminar_Cuotas_Pendientes(info.IdEmpresa,Convert.ToInt32( info.IdPrestamo));
                    var datos = (from a in context.ro_prestamo_detalle
                                 where a.IdEmpresa == info.IdEmpresa
                                 && a.IdPrestamo == info.IdPrestamo
                                 select a);

                    if (datos.Count() > 0)
                    {
                        secuencia = (from prod in datos.Where(v => v.EstadoPago == "CAN") select prod.NumCuota).Max();
                    }

                    foreach (var Item in listadetalle)
                    {
                        secuencia = secuencia + 1;
                        ro_prestamo_detalle Deta = new ro_prestamo_detalle();
                        Deta.IdEmpresa = Item.IdEmpresa;
                        Deta.IdPrestamo = Item.IdPrestamo;
                        Deta.IdNominaTipoLiqui = Item.IdNominaTipoLiqui;
                        Deta.NumCuota = secuencia;
                        Deta.SaldoInicial = Item.SaldoInicial;
                        Deta.Interes = Item.Interes;
                        Deta.AbonoCapital = Item.AbonoCapital;
                        Deta.TotalCuota = Item.TotalCuota;
                        Deta.Saldo = Item.Saldo;
                        Deta.FechaPago = Item.FechaPago;
                        Deta.EstadoPago = Item.EstadoPago;
                        Deta.Estado = Item.Estado;
                        Deta.Observacion_det = Item.Observacion_det;
                        Deta.IdUsuario = Item.IdUsuario;
                        Deta.Fecha_Transac = Item.Fecha_Transac;
                        Deta.nom_pc = Item.nom_pc;
                        Deta.ip = Item.ip;
                        context.ro_prestamo_detalle.Add(Deta);
                        context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        
    }
}