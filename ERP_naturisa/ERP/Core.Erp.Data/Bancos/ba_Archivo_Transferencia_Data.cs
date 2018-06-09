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
    public class ba_Archivo_Transferencia_Data
    {
        string mensaje = "";

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia()
        {
            try
            {
                List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.ba_Archivo_Transferencia
                             select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.IdBanco = item.IdBanco;
                        Info.IdProceso_bancario = item.IdProceso_bancario;
                        Info.Origen_Archivo = item.Origen_Archivo;
                        Info.Cod_Empresa = item.Cod_Empresa;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.Fecha = item.Fecha;
                        Info.Archivo = item.Archivo;
                        Info.Estado = item.Estado;
                        Info.IdEstadoArchivo_cat = item.IdEstadoArchivo_cat;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transac = item.Fecha_Transac;
                        Info.Observacion = item.Observacion;
                        Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.Nom_pc = item.Nom_pc;
                        Info.Ip = item.Ip;
                        Info.Motivo_anulacion = item.Motivo_anulacion;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.IdMotivoArchivo_cat = item.IdMotivoArchivo_cat;
                        Info.Fecha_Proceso = item.Fecha_Proceso;
                        Lista.Add(Info);
                    }
                }

                if (Lista.Count!=0)
                {
                    ba_Archivo_Transferencia_Det_Data oData_det = new ba_Archivo_Transferencia_Det_Data();

                    foreach (var item in Lista)
                    {
                        item.Lst_Archivo_Transferencia_Det = oData_det.Get_List_Archivo_transferencia_Det(item.IdEmpresa,item.IdArchivo);
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

        public bool Actualizar_estado_contabilizacion(ba_Archivo_Transferencia_Info info_archivo)
        {
            try
            {
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    ba_Archivo_Transferencia Entity = Context.ba_Archivo_Transferencia.FirstOrDefault(q => q.IdEmpresa == info_archivo.IdEmpresa && q.IdArchivo == info_archivo.IdArchivo);
                    if (Entity != null)
                    {
                        Entity.Contabilizado = info_archivo.Contabilizado;
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
                throw new Exception(ex.ToString());
            }
        }

        public ba_Archivo_Transferencia_Info Get_Info_Archivo_Transferencia(int idEmpresa, decimal idArchivo)
        {
            try
            {
                ba_Archivo_Transferencia_Info Archivo = new ba_Archivo_Transferencia_Info();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    ba_Archivo_Transferencia item = Conexion.ba_Archivo_Transferencia.FirstOrDefault(q => q.IdArchivo == idArchivo && q.IdEmpresa == idEmpresa);

                    if (item != null)
                    {
                        Archivo.IdEmpresa = item.IdEmpresa;
                        Archivo.IdArchivo = item.IdArchivo;
                        Archivo.IdBanco = item.IdBanco;
                        Archivo.IdProceso_bancario = item.IdProceso_bancario;
                        Archivo.Origen_Archivo = item.Origen_Archivo;
                        Archivo.Cod_Empresa = item.Cod_Empresa;
                        Archivo.Nom_Archivo = item.Nom_Archivo;
                        Archivo.Fecha = item.Fecha;
                        Archivo.Archivo = item.Archivo;
                        Archivo.Estado = item.Estado;
                        Archivo.IdEstadoArchivo_cat = item.IdEstadoArchivo_cat;
                        Archivo.IdUsuario = item.IdUsuario;
                        Archivo.Fecha_Transac = item.Fecha_Transac;
                        Archivo.Observacion = item.Observacion;
                        Archivo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        Archivo.Fecha_UltMod = item.Fecha_UltMod;
                        Archivo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Archivo.Fecha_UltAnu = item.Fecha_UltAnu;
                        Archivo.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Archivo.Nom_pc = item.Nom_pc;
                        Archivo.Ip = item.Ip;
                        Archivo.Motivo_anulacion = item.Motivo_anulacion;
                        Archivo.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Archivo.IdMotivoArchivo_cat = item.IdMotivoArchivo_cat;
                        Archivo.Contabilizado = item.Contabilizado;
                        }
                    
                    ba_Archivo_Transferencia_Det_Data oData_det = new ba_Archivo_Transferencia_Det_Data();
                    Archivo.Lst_Archivo_Transferencia_Det = oData_det.Get_List_Archivo_transferencia_Det(Archivo.IdEmpresa, Archivo.IdArchivo);
                }
                return Archivo;
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

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia(int IdEmpresa, String Origen_Archivo,DateTime FechaInicio,DateTime Fecha_Fin)
        {
            try
            {

                DateTime fi = Convert.ToDateTime(FechaInicio.ToShortDateString());
                DateTime Ff = Convert.ToDateTime(Fecha_Fin.ToShortDateString());
                List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia
                               where q.IdEmpresa == IdEmpresa
                               && q.Origen_Archivo == Origen_Archivo
                               && q.Fecha>=fi
                               && q.Fecha<=Ff
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.IdBanco = item.IdBanco;
                        Info.IdProceso_bancario = item.IdProceso_bancario_tipo;
                        Info.Origen_Archivo = item.Origen_Archivo;
                        Info.Cod_Empresa = item.Cod_Empresa;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.Fecha = item.Fecha;                        
                        Info.IdEstadoArchivo_cat = item.IdEstadoArchivo_cat;
                        Info.Observacion = item.Observacion;
                        Info.nom_proceso_bancario = item.nom_proceso_bancario;
                        Info.nom_EstadoArchivo = item.nom_EstadoArchivo;
                        Info.Estado = item.Estado;
                        Info.CodigoLegal = item.CodigoLegal;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.cod_archivo = item.cod_archivo;
                        Info.IdMotivoArchivo_cat = item.IdMotivoArchivo_cat;
                        Info.nom_MotivoArchivo = item.nom_MotivoArchivo;
                        Info.Valor_Enviado = item.Valor_Enviado;
                        Info.Valor_cobrado = item.Valor_cobrado;
                        Info.Saldo_x_Cobrar = item.Saldo_x_Cobrar;
                        Info.Contabilizado = item.Contabilizado;
                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_Vista_Archivo_transferencia(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, int idBancoIni, int idBancoFin, string idProceso)
        {
            try
            {
                List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();
                fechaIni = fechaIni.Date;
                fechaFin = fechaFin.Date;
                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia
                               where q.IdEmpresa == IdEmpresa
                               && fechaIni<= q.Fecha && q.Fecha <= fechaFin
                               && idBancoIni<=q.IdBanco && q.IdBanco<=idBancoFin
                               && q.IdProceso_bancario_tipo.Contains(idProceso)
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.nom_empresa = item.nom_empresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.IdBanco = item.IdBanco;
                        Info.nom_banco = item.nom_banco;
                        Info.IdProceso_bancario = item.IdProceso_bancario_tipo;
                        Info.nom_proceso_bancario = item.nom_proceso_bancario;
                        Info.Origen_Archivo = item.Origen_Archivo;  
                        Info.Cod_Empresa = item.Cod_Empresa;
                        Info.Fecha = item.Fecha;
                        Info.IdEstadoArchivo_cat = item.IdEstadoArchivo_cat;
                        Info.nom_EstadoArchivo = item.nom_EstadoArchivo;
                        Info.CodigoLegal = item.CodigoLegal;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.Observacion = item.Observacion;
                        Info.IdMotivoArchivo_cat = item.IdMotivoArchivo_cat;
                        Info.nom_MotivoArchivo = item.nom_MotivoArchivo;
                        Info.Valor_Enviado = item.Valor_Enviado;
                        Info.Valor_cobrado = item.Valor_cobrado;
                        Info.Saldo_x_Cobrar = item.Saldo_x_Cobrar;
                        Info.Fecha_Proceso = item.Fecha_Proceso;
                        Info.Contabilizado = item.Contabilizado;
                        Info.Estado = item.Estado;
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

        public ba_Archivo_Transferencia_Info Get_Info_Vista_Archivo_transferencia(int idEmpresa, decimal idArchivo, int idBanco, string idProceso)
        {
            try
            {
                ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia
                               where idEmpresa == q.IdEmpresa && idArchivo == q.IdArchivo
                               && q.IdArchivo==idArchivo 
                               && q.IdProceso_bancario_tipo == idProceso
                               select q);

                    foreach (var item in lst)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.nom_empresa = item.nom_empresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.IdBanco = item.IdBanco;
                        Info.nom_banco = item.nom_banco;
                        Info.IdProceso_bancario = item.IdProceso_bancario_tipo;
                        Info.nom_proceso_bancario = item.nom_proceso_bancario;
                        Info.Origen_Archivo = item.Origen_Archivo;
                        Info.Cod_Empresa = item.Cod_Empresa;
                        Info.Fecha = item.Fecha;
                        Info.IdEstadoArchivo_cat = item.IdEstadoArchivo_cat;
                        Info.nom_EstadoArchivo = item.nom_EstadoArchivo;
                        Info.CodigoLegal = item.CodigoLegal;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.Observacion = item.Observacion;
                        Info.IdMotivoArchivo_cat = item.IdMotivoArchivo_cat;
                        Info.nom_MotivoArchivo = item.nom_MotivoArchivo;
                        Info.Valor_Enviado = item.Valor_Enviado;
                        Info.Valor_cobrado = item.Valor_cobrado;
                        Info.Saldo_x_Cobrar = item.Saldo_x_Cobrar;
                        Info.Fecha_Proceso = item.Fecha_Proceso;
                        Info.Contabilizado = item.Contabilizado;
                    }
                }
                /*
                ba_Archivo_Transferencia_Det_Data oData = new ba_Archivo_Transferencia_Det_Data();
                Info.Lst_Archivo_Transferencia_Det = oData.Get_List_Archivo_transferencia_Det(Info.IdEmpresa, Info.IdArchivo);
                */
                return Info;
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

        public List<ba_Archivo_Transferencia_Info> Get_Vista_Archivo_transferencia_x_Estado(string idEstadoArchivo,DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia
                               where q.IdEstadoArchivo_cat.Contains(idEstadoArchivo)
                               && fechaIni<=q.Fecha && q.Fecha<= fechaFin
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.nom_empresa = item.nom_empresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.IdBanco = item.IdBanco;
                        Info.nom_banco = item.nom_banco;
                        Info.IdProceso_bancario = item.IdProceso_bancario_tipo;
                        Info.nom_proceso_bancario = item.nom_proceso_bancario;
                        Info.Origen_Archivo = item.Origen_Archivo;
                        Info.Cod_Empresa = item.Cod_Empresa;
                        Info.Fecha = item.Fecha;
                        Info.IdEstadoArchivo_cat = item.IdEstadoArchivo_cat;
                        Info.nom_EstadoArchivo = item.nom_EstadoArchivo;
                        Info.CodigoLegal = item.CodigoLegal;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.IdMotivoArchivo_cat = item.IdMotivoArchivo_cat;
                        Info.nom_MotivoArchivo = item.nom_MotivoArchivo;
                        Info.Valor_Enviado = item.Valor_Enviado;
                        Info.Valor_cobrado = item.Valor_cobrado;
                        Info.Saldo_x_Cobrar = item.Saldo_x_Cobrar;
                        Info.Fecha_Proceso = item.Fecha_Proceso;
                        Info.Contabilizado = item.Contabilizado;
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

        public bool GrabarDB(ba_Archivo_Transferencia_Info info, ref int IdArchivo)
        {
            try
            {
                try
                {
                    List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();
                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        ba_Archivo_Transferencia address = new ba_Archivo_Transferencia();
                        info.Fecha = Convert.ToDateTime(info.Fecha.ToShortDateString());
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdArchivo = info.IdArchivo = GetId(info.IdEmpresa);
                        address.cod_archivo = info.cod_archivo == null || info.cod_archivo == "" ? GetId_codigoArchivo(info.IdEmpresa, info.Fecha) : info.cod_archivo;
                        address.IdBanco = info.IdBanco;
                        address.IdProceso_bancario = info.IdProceso_bancario;
                        address.Origen_Archivo = info.Origen_Archivo;
                        address.Cod_Empresa = info.Cod_Empresa;
                        address.Nom_Archivo = info.Nom_Archivo;
                        address.Fecha = info.Fecha;
                        if (info.Archivo == null)
                        {
                            info.Archivo = new byte[000000];
                        }

                        address.Archivo = info.Archivo;

                        address.Estado = info.Estado;
                        address.IdEstadoArchivo_cat = info.IdEstadoArchivo_cat;
                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transac = (DateTime)info.Fecha_Transac;
                        address.Observacion = info.Observacion;
                        address.IdMotivoArchivo_cat = info.IdMotivoArchivo_cat;
                        address.IdOrden_Bancaria = info.IdOrden_Bancaria;
                        address.Contabilizado = false;
                        address.Estado = true;
                        context.ba_Archivo_Transferencia.Add(address);
                        
                        context.SaveChanges();
                        IdArchivo = Convert.ToInt32(address.IdArchivo);
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

        public bool ModificarDB(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                try
                {
                    List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();

                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        var contact = context.ba_Archivo_Transferencia.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdArchivo == info.IdArchivo);
                        info.Fecha = Convert.ToDateTime(info.Fecha.ToShortDateString());
                        contact.IdBanco = info.IdBanco;
                        contact.IdProceso_bancario = info.IdProceso_bancario;
                        contact.IdOrden_Bancaria = info.IdOrden_Bancaria;
                        contact.Fecha = info.Fecha;
                        contact.Estado = info.Estado;
                        contact.Nom_Archivo = info.Nom_Archivo;
                        contact.Archivo = info.Archivo;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        context.SaveChanges();
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

        public bool Actualizar_Archivo(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                try
                {

                    List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();

                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        var contact = context.ba_Archivo_Transferencia.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdArchivo == info.IdArchivo);
                        if (contact != null)
                        {
                            contact.IdEstadoArchivo_cat = "FIL_ACTUA";
                            contact.IdOrden_Bancaria = info.IdOrden_Bancaria;
                            contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                            contact.Fecha_UltMod = info.Fecha_UltMod;
                            contact.Fecha_Proceso = info.Fecha_Proceso;
                            context.SaveChanges();
                        }
                    }
                    return true;
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

        public bool AnularDB(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                try
                {

                    List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();

                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        var contact = context.ba_Archivo_Transferencia.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdArchivo == info.IdArchivo);

                        contact.Estado = false;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.Motivo_anulacion = info.Motivo_anulacion;
                        context.SaveChanges();
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

        public int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesBanco context = new EntitiesBanco();

                var q = from C in context.ba_Archivo_Transferencia
                        where C.IdEmpresa == IdEmpresa                       
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from Query in context.ba_Archivo_Transferencia
                                   where Query.IdEmpresa == IdEmpresa                               
                                   select Query.IdArchivo).Max() + 1;
                    Id =(int) select_;
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
                throw new Exception(ex.ToString());
            }

        }

        public string GetId_codigoArchivo(int IdEmpresa, DateTime fecha)
        {
            string Id="";

            try
            {
                fecha = fecha.Date;

                EntitiesBanco context = new EntitiesBanco();

                var q = from C in context.ba_Archivo_Transferencia
                        where C.IdEmpresa == IdEmpresa
                        && C.Fecha==fecha
                        select C;
                if (q.ToList().Count == 0)
                {
                    Id = fecha.Year.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Day.ToString().PadLeft(2, '0') + "_" + "01";
                }
                else
                {
                    var select_ = (from Query in context.ba_Archivo_Transferencia
                                   where Query.IdEmpresa == IdEmpresa
                                    && Query.Fecha == fecha
                                   select Query.cod_archivo).Max() ;
                    int len = select_.Length;
                    int secuencia =Convert.ToInt32( select_.Substring(9,len-9));
                    secuencia=secuencia+1;
                    Id = fecha.Year.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Day.ToString().PadLeft(2, '0') + "_" +Convert.ToString( secuencia).PadLeft(2,'0');
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public string GetId_codigoArchivo_bolivariano(int IdEmpresa, int IdBanco, DateTime fecha)
        {
            string Id = "";

            try
            {
                fecha = fecha.Date;

                EntitiesBanco context = new EntitiesBanco();

                var q = from C in context.ba_Archivo_Transferencia
                        where C.IdEmpresa == IdEmpresa
                        && C.IdBanco == IdBanco
                        && C.Fecha == fecha
                        select C;
                if (q.ToList().Count == 0)
                {
                    Id = fecha.Year.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Day.ToString().PadLeft(2, '0') + "001";
                }
                else
                {
                    var select_ = (from Query in context.ba_Archivo_Transferencia
                                   where Query.IdEmpresa == IdEmpresa
                                    && Query.Fecha == fecha
                                    && Query.IdBanco == IdBanco
                                   select Query.cod_archivo).Max();
                    int len = select_.Length;
                    int secuencia = Convert.ToInt32(select_.Substring(9, len - 9));
                    secuencia = secuencia + 1;
                    Id = fecha.Year.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Day.ToString().PadLeft(2, '0') + Convert.ToString(secuencia).PadLeft(3, '0');
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public byte[] Get_Archivo(int idEmpresa, decimal idArchivo, string idProceso, int idBanco)
        {
            try
            {
                try
                {

                    byte[] binario = new byte[0];

                    using (EntitiesBanco Conexion = new EntitiesBanco())
                    {
                        var Archivo = (from q in Conexion.ba_Archivo_Transferencia
                                       where idEmpresa == q.IdEmpresa
                                       && idArchivo == q.IdArchivo
                                       && idBanco == q.IdBanco
                                       && idProceso == q.IdProceso_bancario
                                       select q.Archivo).FirstOrDefault();

                        if (Archivo != null)
                        {
                            binario = Archivo.ToArray();
                        }

                    }

                    return binario;
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
                throw new Exception(ex.ToString());
            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia(int IdEmpresa, int IdBanco, string IdProceso_bancario, String Origen_Archivo)
        {
            try
            {
                List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();
                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia
                               where q.IdEmpresa == IdEmpresa
                               && q.IdBanco == IdBanco
                               && q.IdProceso_bancario_tipo == IdProceso_bancario
                               && q.Origen_Archivo == Origen_Archivo
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo = item.IdArchivo;
                        Info.IdBanco = item.IdBanco;
                        Info.IdProceso_bancario = item.IdProceso_bancario_tipo;
                        Info.Origen_Archivo = item.Origen_Archivo;
                        Info.Cod_Empresa = item.Cod_Empresa;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.nom_banco = item.nom_banco;
                        Info.Fecha = item.Fecha;                        
                        Info.IdEstadoArchivo_cat = item.IdEstadoArchivo_cat;
                        Info.Observacion = item.Observacion;
                        Info.nom_proceso_bancario = item.nom_proceso_bancario;
                        Info.nom_EstadoArchivo = item.nom_EstadoArchivo;
                        Info.Estado = item.Estado;
                        Info.CodigoLegal = item.CodigoLegal;
                        Info.IdOrden_Bancaria = item.IdOrden_Bancaria;
                        Info.Observacion = item.Observacion;
                        Info.Valor_Enviado = item.Valor_Enviado;
                        Info.Valor_cobrado = item.Valor_cobrado;
                        Info.Saldo_x_Cobrar = item.Saldo_x_Cobrar;
                        Info.nom_MotivoArchivo = item.nom_MotivoArchivo;
                        Info.IdMotivoArchivo_cat = item.IdMotivoArchivo_cat;
                        Info.Fecha_Proceso = item.Fecha_Proceso;
                        Info.Contabilizado = item.Contabilizado;
                        Lista.Add(Info);
                    }
                }
                return Lista;
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

        public bool EliminarDB(int IdEmpresa, decimal IdArchivo)
        {
            try
            {
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    string sql = "delete from ba_Archivo_Transferencia where IdEmpresa = " + IdEmpresa + " AND IdArchivo=" + IdArchivo;
                    Context.Database.ExecuteSqlCommand(sql);
                    return true;
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
                throw new Exception(ex.ToString());
            }
        }
    }
}
