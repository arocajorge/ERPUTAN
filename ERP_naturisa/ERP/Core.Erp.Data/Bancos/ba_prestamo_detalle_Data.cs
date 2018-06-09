using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Bancos
{
    public class ba_prestamo_detalle_Data
    {
        string mensaje = "";
        public decimal GetIdPrestamo()
        {
            try
            {
                decimal Id;
                EntitiesBanco  OECbtecble = new EntitiesBanco();

                var q = from C in OECbtecble.ba_prestamo
                        //  where C.IdEmpresa == idempresa //&& C.IdEmpleado == idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ba_prestamo
                                   select t.IdPrestamo).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ba_prestamo_detalle_Info> Get_List_EstadoCuenta(ba_prestamo_Info Item, ref string msg)
        {
            try
            {
                List<ba_prestamo_detalle_Info> listado = new List<ba_prestamo_detalle_Info>();
                try
                {
                    string q =

                        "SELECT     det.IdEmpresa, det.IdPrestamo, det.NumCuota," +
                                    " det.SaldoInicial, det.Interes, det.AbonoCapital, " +
                                    " det.TotalCuota, det.Saldo, det.FechaPago, " +
                                    " det.EstadoPago, det.Estado, " +
                                    " det.Observacion_det, canc.Secuencia, " +
                                    " canc.Monto_Canc, canc.Saldo AS Saldo_Canc," +
                                    " canc.FechaPago AS Fecha_Canc, canc.Observacion_canc" +
                                    " FROM         dbo.ba_prestamo_detalle AS det LEFT OUTER JOIN" +
                                                          " dbo.ba_prestamo_detalle_cancelacion AS canc ON " +
                                                          "det.IdEmpresa = canc.IdEmpresa AND " +
                                                          "det.IdPrestamo = canc.IdPrestamo AND" +
                                                          " det.NumCuota = canc.NumCuota" +
                                    " WHERE     (det.IdEmpresa = {0}) AND (det.IdPrestamo = {1})";


                    string query = string.Format(q, Item.IdEmpresa, Item.IdPrestamo);
                    EntitiesBanco oEnt = new EntitiesBanco();
                    listado = oEnt.Database.SqlQuery<ba_prestamo_detalle_Info>(query).ToList();

                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;
                    msg = ex.Message + ex.InnerException;
                    listado = new List<ba_prestamo_detalle_Info>();

                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ba_prestamo_detalle_Info> Get_List_DetallePrestamosxCancelar(ba_prestamo_Info Item, ref string msg)
        {
            List<ba_prestamo_detalle_Info> listado = new List<ba_prestamo_detalle_Info>();
            try
            {
                string query = "select * from vwba_prestamo_detalle_cancelacion where IdEmpresa = " + Item.IdEmpresa +
                    " and IdPrestamo = " + Item.IdPrestamo;
                EntitiesBanco oEnt = new EntitiesBanco();
                listado = oEnt.Database.SqlQuery<ba_prestamo_detalle_Info>(query).ToList();
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
      
        public List<ba_prestamo_detalle_Info> Get_List_prestamo_detalle(int IdEmpresa, decimal IdPrestamo)
        {
            try
            {
                //List<ba_prestamo_detalle_Info> Lst = new List<ba_prestamo_detalle_Info>();
                using (EntitiesBanco Context = new EntitiesBanco())
                {



                    IQueryable<ba_prestamo_detalle_Info> Consulta = from q in Context.ba_prestamo_detalle
                                                                    where q.IdEmpresa == IdEmpresa && q.IdPrestamo == IdPrestamo
                                                                    select new ba_prestamo_detalle_Info
                                                                    {
                                                                        IdEmpresa = IdEmpresa,
                                                                        IdPrestamo = IdPrestamo,
                                                                        NumCuota = q.NumCuota,
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
                                                                        // Fecha_UltMod = Convert.ToDateTime(q.Fecha_UltMod),
                                                                        IdUsuarioUltAnu = q.IdUsuarioUltAnu,
                                                                        //  Fecha_UltAnu = Convert.ToDateTime(q.Fecha_UltAnu),
                                                                        nom_pc = q.nom_pc,
                                                                        ip = q.ip,
                                                                        MotiAnula = q.MotiAnula
                                                                    };
                    return Consulta.ToList();
                }
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarPrestamoDetalle(List<ba_prestamo_detalle_Info> Lst)
        {

            try
            {
                int secuencia = 0;
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                foreach (var Item in Lst)
                {
                        secuencia++;            
                        ba_prestamo_detalle Deta = new ba_prestamo_detalle();
                        Deta.IdEmpresa = Item.IdEmpresa;
                        Deta.IdPrestamo = Item.IdPrestamo;
                        Deta.NumCuota = Item.NumCuota;
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
                        Context.ba_prestamo_detalle.Add(Deta);
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDetallePrestamo(ba_prestamo_detalle_Info prI, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_prestamo_detalle.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdPrestamo == prI.IdPrestamo && VProdu.NumCuota == prI.NumCuota);
                    if (contact != null)
                    {
                        contact.NumCuota = prI.NumCuota;
                        contact.SaldoInicial = prI.SaldoInicial;
                        contact.Interes = prI.Interes;
                        contact.AbonoCapital = prI.AbonoCapital;
                        contact.TotalCuota = prI.TotalCuota;
                        contact.Saldo = prI.Saldo;
                        contact.FechaPago = prI.FechaPago;
                        contact.EstadoPago = prI.EstadoPago;
                        contact.Observacion_det = prI.Observacion_det;
                        context.SaveChanges();
                        msg = "Se ha procedido a Actualizar la Información Exitosamente...";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Error al Grabar" + ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDetallePrestamo(List<ba_prestamo_detalle_Info> listadetalle, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    foreach (var item in listadetalle)
                    {
                        var contact = context.ba_prestamo_detalle.FirstOrDefault(VProdu => VProdu.IdEmpresa == item.IdEmpresa && VProdu.IdPrestamo == item.IdPrestamo && VProdu.NumCuota == item.NumCuota);
                        if (contact != null)
                        {
                            contact.Estado = "I";
                            contact.EstadoPago = item.EstadoPago;

                            context.SaveChanges();
                            msg = "Se ha procedido a Anular el detalle #: " + item.IdPrestamo + " Exitosamente...";
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Error al Grabar" + ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean CancelarEstadoDetallePrestamo(ba_prestamo_detalle_Info info, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_prestamo_detalle.FirstOrDefault(VProdu => VProdu.IdEmpresa == info.IdEmpresa && VProdu.IdPrestamo == info.IdPrestamo && VProdu.NumCuota == info.NumCuota);
                    if (contact != null)
                    {
                       
                            contact.EstadoPago = "CAN";
                        
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Error al Grabar" + ex.InnerException;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDetallePrestamo(ba_prestamo_detalle_Info _Info)
        {
            try
            {
                using (EntitiesBanco Entity = new EntitiesBanco())
                {

                    ba_prestamo_detalle detalle = Entity.ba_prestamo_detalle.FirstOrDefault(v => v.IdPrestamo == _Info.IdPrestamo && v.NumCuota == _Info.NumCuota && v.IdEmpresa == _Info.IdEmpresa);
                    if (detalle != null)
                    {
                        detalle.IdUsuarioUltAnu = _Info.IdUsuarioUltAnu;
                        detalle.Fecha_UltAnu = _Info.Fecha_UltAnu;
                        detalle.MotiAnula = _Info.MotiAnula;
                        detalle.Estado = "I";
                        Entity.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ReversaEstadoCanc(ba_prestamo_detalle_Info _Info, ref string msg)
        {
            try
            {
                Boolean res = false;
                try
                {
                    using (EntitiesBanco Entity = new EntitiesBanco())
                    {
                        ba_prestamo_detalle detalle = Entity.ba_prestamo_detalle.FirstOrDefault(v => v.IdPrestamo == _Info.IdPrestamo && v.NumCuota == _Info.NumCuota && v.IdEmpresa == _Info.IdEmpresa);
                        if (detalle != null)
                        {
                            detalle.EstadoPago = "PEN";
                            Entity.SaveChanges();
                            res = true;
                        }
                    }
                    return res;
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool Eliminar(int idempresa, int idprestamo)
        {
            try
            {
                
                    using (EntitiesBanco Entity = new EntitiesBanco())
                    {

                        string SQL = "delete ba_prestamo_detalle where idempresa='" + idempresa + "' and idprestamo='" + idprestamo + "'";
                        Entity.Database.ExecuteSqlCommand(SQL);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    throw new Exception(ex.ToString());
                }
        }
    }
}
