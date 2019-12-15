using Core.Erp.Data.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Erp.Data.Bancos
{
    public class ba_Archivo_Transferencia_Det_Data
    {
        string mensaje = "";

        public List<ba_Archivo_Transferencia_Det_Info> Get_List_Archivo_transferencia_Det(int idEmpresa, decimal idArchivo)
        {
            try
            {
                List<ba_Archivo_Transferencia_Det_Info> Lista = new List<ba_Archivo_Transferencia_Det_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {                    

                    var lst = (from q in Conexion.vwba_Archivo_Transferencia_Det
                               where idEmpresa == q.IdEmpresa && idArchivo == q.IdArchivo
                             select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_Det_Info Info = new ba_Archivo_Transferencia_Det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.Secuencia = item.Secuencia;
                        Info.IdProceso_bancario = item.IdProceso_bancario;
                        Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Info.num_cta_acreditacion = item.num_cta_acreditacion;
                        Info.Valor = item.Valor;
                        Info.Valor_cobrado = item.Valor_cobrado;
                        Info.Saldo = item.Saldo == null ? 0 : Convert.ToDecimal(item.Saldo);
                        Info.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                        Info.nom_EstadoRegistro = item.nom_EstadoRegistro_cat;
                        Info.Secuencial_reg_x_proceso = item.Secuencial_reg_x_proceso;
                        Info.Id_Item = item.Id_Item;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.Fecha = item.Fecha;
                        
                        Info.IdEmpresa_pago = item.IdEmpresa_pago;
                        Info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        Info.IdCbteCble_pago = item.IdCbteCble_pago;
                        Info.cb_Estado = item.cb_Estado;

                        Lista.Add(Info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }       

        public List<ba_Archivo_Transferencia_Det_Info> Get_List_Vista_Archivo_transferencia_Det(int idEmpresa,int idBancoIni, int idBancoFin, string idProceso, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<ba_Archivo_Transferencia_Det_Info> Lista = new List<ba_Archivo_Transferencia_Det_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia_Det
                               where idEmpresa == q.IdEmpresa 
                               && idBancoIni<= q.IdBanco && q.IdBanco <= idBancoFin
                               && FechaIni <= q.Fecha && q.Fecha <= FechaFin
                               && idProceso.Contains(idProceso)
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_Det_Info Info = new ba_Archivo_Transferencia_Det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.Secuencia = item.Secuencia;
                        Info.IdProceso_bancario = item.IdProceso_bancario;
                        Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Info.num_cta_acreditacion = item.num_cta_acreditacion;
                        Info.Valor = item.Valor;
                        Info.Valor_cobrado = item.Valor_cobrado;
                        Info.Saldo = item.Saldo == null ? 0 : Convert.ToDecimal(item.Saldo);
                        Info.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                        Info.nom_EstadoRegistro = item.nom_EstadoRegistro_cat;
                        Info.Secuencial_reg_x_proceso = item.Secuencial_reg_x_proceso;
                        Info.Id_Item = item.Id_Item;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.Fecha = item.Fecha;

                        Info.IdEmpresa_pago = item.IdEmpresa_pago;
                        Info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        Info.IdCbteCble_pago = item.IdCbteCble_pago;
                        Info.cb_Estado = item.cb_Estado;

                        Lista.Add(Info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool GrabarDB(List<ba_Archivo_Transferencia_Det_Info> Lista)
        {
            try
            {
                try
                {
                int secuencia = 0;
                using (EntitiesBanco context = new EntitiesBanco())
                {                
                    foreach (var item in Lista)
                    {
                        secuencia = secuencia + 1;
                        ba_Archivo_Transferencia_Det Addres = new ba_Archivo_Transferencia_Det();
                        Addres.IdEmpresa = item.IdEmpresa;
                        Addres.IdArchivo = item.IdArchivo;
                        Addres.IdProceso_bancario = item.IdProceso_bancario;
                        Addres.Secuencia = item.Secuencia = secuencia;
                        Addres.IdEmpresa_OP = item.IdEmpresa_OP;
                        Addres.IdOrdenPago = item.IdOrdenPago;
                        Addres.Secuencia_OP = item.Secuencia_OP;
                        Addres.IdNominaTipo = item.IdNominaTipo;
                        Addres.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        Addres.IdPeriodo = item.IdPeriodo;
                        Addres.IdEmpleado = item.IdEmpleado;
                        Addres.IdRubro = item.IdRubro;
                        Addres.Valor = item.Valor;

                        Addres.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                        Addres.Estado = true;
                        Addres.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;                        
                        Addres.Id_Item = item.Id_Item;
                        Addres.Valor_cobrado = 0;
                        Addres.Secuencial_reg_x_proceso = item.Secuencial_reg_x_proceso;
                           

                        context.ba_Archivo_Transferencia_Det.Add(Addres);
                        context.SaveChanges();
                    }

                    if (Lista.Count() == 0)
                    {
                        return false;
                    }

                    return true;

                }
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdArchivo)
        {
            try
            {
                try
                {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    string sql="delete from ba_Archivo_Transferencia_Det where IdEmpresa = " +IdEmpresa+ " AND IdArchivo=" + IdArchivo;
                    context.Database.ExecuteSqlCommand(sql);
                    return true;
                }
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(ba_Archivo_Transferencia_Det_Info item)
        {
            try
            {
                try
                {
                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        var contact = context.ba_Archivo_Transferencia_Det.FirstOrDefault(minfo => minfo.IdEmpresa == item.IdEmpresa && minfo.IdArchivo == item.IdArchivo && minfo.Secuencia == item.Secuencia);
                        if (contact != null)
                        {
                            contact.Estado = false;
                            //Anulacion op
                            contact.IdEmpresa_OP = null;
                            contact.IdOrdenPago = null;
                            contact.Secuencia_OP = null;
                            //Anulacion rol
                            contact.IdEmpresaNomina = null;
                            contact.IdNominaTipo = null;
                            contact.IdNominaTipoLiqui = null;
                            contact.IdPeriodo = null;
                            contact.IdRubro = null;
                            contact.IdEmpleado = null;

                            context.SaveChanges();

                            item.IdEmpresa_pago = contact.IdEmpresa_pago;
                            item.IdTipoCbte_pago = contact.IdTipoCbte_pago;
                            item.IdCbteCble_pago = contact.IdCbteCble_pago;
                        }

                        return true;
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item_Ex in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item_Ex.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Actualizar_registro(ba_Archivo_Transferencia_Det_Info Info)
        {
            try
            {
                try
                {

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    ba_Archivo_Transferencia_Det Entity = Conexion.ba_Archivo_Transferencia_Det.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdArchivo == Info.IdArchivo &&  q.Secuencia == Info.Secuencia);
                    if (Entity!=null)
                    {
                        Entity.Id_Item = Info.Id_Item;
                        Entity.IdEstadoRegistro_cat = Info.IdEstadoRegistro_cat == null ? "REG_COBR" : Info.IdEstadoRegistro_cat;
                        Entity.Valor_cobrado = Info.Valor_cobrado;
                        Entity.Fecha_proceso = Info.Fecha_Proceso;
                        Entity.Contabilizado = Info.Contabilizado;
                        Conexion.SaveChanges();    
                    }
                    
                }
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificarDB(ba_Archivo_Transferencia_Det_Info Info)
        {
            try
            {
                try
                {
                    using (EntitiesBanco Conexion = new EntitiesBanco())
                    {
                        ba_Archivo_Transferencia_Det Entity = Conexion.ba_Archivo_Transferencia_Det.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdArchivo == Info.IdArchivo && q.Secuencia == Info.Secuencia);
                        if (Entity!=null)
                        {
                            Entity.IdEmpresa_pago = Info.IdEmpresa_pago;
                            Entity.IdTipoCbte_pago = Info.IdTipoCbte_pago;
                            Entity.IdCbteCble_pago = Info.IdCbteCble_pago;
                            Conexion.SaveChanges();    
                        }
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(ex.ToString());
            }
        }

        public decimal Get_Secuencial_registro_BB(int IdEmpresa, string IdProceso_bancario)
        {
            try
            {
                try
                {
                    decimal Secuencial_registro = 0;

                    using (EntitiesBanco Context = new EntitiesBanco())
                    {
                        var lst = from q in Context.ba_Archivo_Transferencia_Det
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdProceso_bancario == IdProceso_bancario
                                  && q.Secuencial_reg_x_proceso != null
                                  select q;

                        if (lst.Count() != 0)
                        {
                            Secuencial_registro = Convert.ToDecimal(lst.Max(q => q.Secuencial_reg_x_proceso)+1);
                        }
                    }
                    if (Secuencial_registro == 0)
                    {
                        using (EntitiesGeneral Context = new EntitiesGeneral())
                        {
                            var lst = from q in Context.tb_banco_procesos_bancarios_x_empresa
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdProceso_bancario_tipo == IdProceso_bancario
                                      && q.Secuencial_detalle_inicial != null
                                      select q;
                            if (lst.Count() != 0)
                            {
                                Secuencial_registro = Convert.ToDecimal(lst.Max(q => q.Secuencial_detalle_inicial));    
                            }
                        }
                    }
                    if (Secuencial_registro == 0) Secuencial_registro = 1;

                    return Secuencial_registro;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(ex.ToString());
            }
        }

        public decimal Get_secuencial_registro_BB_modificar(int IdEmpresa, string IdProceso_bancario, decimal IdArchivo)
        {
            try
            {
                try
                {
                    decimal Secuencial_registro = 0;

                    using (EntitiesBanco Context = new EntitiesBanco())
                    {

                        var lst = from q in Context.ba_Archivo_Transferencia_Det
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdProceso_bancario == IdProceso_bancario
                                  && q.IdArchivo == IdArchivo
                                  && q.Secuencial_reg_x_proceso != null
                                  select q;

                        if (lst.Count() != 0)
                        {
                            Secuencial_registro = Convert.ToDecimal(lst.Min(q => q.Secuencial_reg_x_proceso));
                        }
                    }

                    if (Secuencial_registro == 0)
                    {
                        using (EntitiesGeneral Context = new EntitiesGeneral())
                        {
                            var lst = from q in Context.tb_banco_procesos_bancarios_x_empresa
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdProceso_bancario_tipo == IdProceso_bancario
                                      && q.Secuencial_detalle_inicial != null
                                      select q;
                            if (lst.Count() != 0)
                            {
                                Secuencial_registro = Convert.ToDecimal(lst.Min(q => q.Secuencial_detalle_inicial));
                            }
                        }
                    }
                    if (Secuencial_registro == 0) Secuencial_registro = 1;

                    return Secuencial_registro;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
                throw new Exception(ex.ToString());
            }
        }
    }
}
