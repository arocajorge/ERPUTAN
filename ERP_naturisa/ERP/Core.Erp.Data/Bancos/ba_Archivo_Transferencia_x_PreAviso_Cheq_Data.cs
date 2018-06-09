using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Bancos
{
   public  class ba_Archivo_Transferencia_x_PreAviso_Cheq_Data
    {


        string mensaje = "";

        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Get_List_Archivo_transferencia()
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.ba_Archivo_Transferencia_x_PreAviso_Cheq
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Info = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo_preaviso_cheq = item.IdArchivo_preaviso_cheq;
                        Info.IdBanco = item.IdBanco;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.Fecha = item.Fecha;
                        Info.Archivo = item.Archivo;
                        Info.Estado = item.Estado;
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
                        Info.Fecha_Proceso = item.Fecha_Proceso;
                        Lista.Add(Info);
                    }
                }

                //if (Lista.Count != 0)
                //{
                //    ba_Archivo_Transferencia_Det_Data oData_det = new ba_Archivo_Transferencia_Det_Data();

                //    foreach (var item in Lista)
                //    {
                //        item.Lst_Archivo_Transferencia_Det = oData_det.Get_List_Archivo_transferencia_Det(item.IdEmpresa, item.IdProceso_bancario, item.IdArchivo);
                //    }
                //}

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

        public ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Get_Info_Archivo_Transferencia(int idEmpresa, decimal idArchivo)
        {
            try
            {
                ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Archivo = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    ba_Archivo_Transferencia_x_PreAviso_Cheq item = Conexion.ba_Archivo_Transferencia_x_PreAviso_Cheq.FirstOrDefault(q => q.IdArchivo_preaviso_cheq == idArchivo && q.IdEmpresa == idEmpresa);

                    if (item != null)
                    {
                        Archivo.IdEmpresa = item.IdEmpresa;
                        Archivo.IdArchivo_preaviso_cheq = item.IdArchivo_preaviso_cheq;
                        Archivo.IdBanco = item.IdBanco;
                        Archivo.Nom_Archivo = item.Nom_Archivo;
                        Archivo.Fecha = item.Fecha;
                        Archivo.Archivo = item.Archivo;
                        Archivo.Estado = item.Estado;
                        Archivo.IdUsuario = item.IdUsuario;
                        Archivo.Fecha_Transac = item.Fecha_Transac;
                        Archivo.Observacion = item.Observacion;
                        Archivo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        Archivo.Fecha_UltMod = item.Fecha_UltMod;
                        Archivo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Archivo.Fecha_UltAnu = item.Fecha_UltAnu;
                        Archivo.Nom_pc = item.Nom_pc;
                        Archivo.Ip = item.Ip;
                        Archivo.Motivo_anulacion = item.Motivo_anulacion;

                    }

                    //ba_Archivo_Transferencia_Det_Data oData_det = new ba_Archivo_Transferencia_Det_Data();
                    //Archivo.Lst_Archivo_Transferencia_Det = oData_det.Get_List_Archivo_transferencia_Det(Archivo.IdEmpresa, Archivo.IdProceso_bancario, Archivo.IdArchivo);
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

        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Get_List_Archivo_transferencia(int IdEmpresa,  DateTime FechaInicio, DateTime Fecha_Fin)
        {
            try
            {

                DateTime fi = Convert.ToDateTime(FechaInicio.ToShortDateString());
                DateTime Ff = Convert.ToDateTime(Fecha_Fin.ToShortDateString());
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia_x_PreAviso_Cheq
                               where q.IdEmpresa == IdEmpresa
                               && q.Fecha >= fi
                               && q.Fecha <= Ff
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Info = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo_preaviso_cheq = item.IdArchivo_preaviso_cheq;
                        Info.IdBanco = item.IdBanco;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.Fecha = item.Fecha;
                        Info.Estado = item.Estado;
                        Info.Observacion = item.Observacion;
                        Info.Estado = item.Estado;

                        Info.nom_banco = item.nom_banco;

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

        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Get_List_Archivo_transferencia(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, int idBancoIni, int idBancoFin)
            
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();

                idBancoIni = (idBancoIni == 0) ? 1 : idBancoIni;
                idBancoFin = (idBancoFin == 0) ? 99999999 : idBancoFin;


                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia_x_PreAviso_Cheq
                               where fechaIni <= q.Fecha && q.Fecha <= fechaFin
                               && idBancoIni <= q.IdBanco && q.IdBanco <= idBancoFin
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Info = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo_preaviso_cheq = item.IdArchivo_preaviso_cheq;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.IdBanco = item.IdBanco;
                        Info.Fecha = item.Fecha;
                        Info.Observacion = item.Observacion;
                        Info.Fecha_Proceso = item.Fecha_Proceso;
                        Info.nom_banco = item.nom_banco;
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

        public ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Get_Info_Archivo_transferencia(int idEmpresa, decimal idArchivo, int idBanco)
        {
            try
            {
                ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Info = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia_x_PreAviso_Cheq
                               where idEmpresa == q.IdEmpresa
                               && idArchivo == q.IdArchivo_preaviso_cheq
                               && q.IdBanco == idBanco
                               select q);

                    foreach (var item in lst)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo_preaviso_cheq = item.IdArchivo_preaviso_cheq;
                        Info.Nom_Archivo = item.Nom_Archivo;
                        Info.IdBanco = item.IdBanco;
                        Info.Fecha = item.Fecha;
                        Info.Observacion = item.Observacion;
                        Info.Fecha_Proceso = item.Fecha_Proceso;

                        Info.nom_banco = item.nom_banco;

                    }
                }

                //ba_Archivo_Transferencia_Det_Data oData = new ba_Archivo_Transferencia_Det_Data();
                //Info.Lst_Archivo_Transferencia_Det = oData.Get_List_Vista_Archivo_transferencia_Det(Info.IdEmpresa, Info.IdArchivo, Info.IdBanco, Info.IdProceso_bancario);

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

        public bool GrabarDB(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info, ref decimal IdArchivo)
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();

                using (EntitiesBanco context = new EntitiesBanco())
                {
                    ba_Archivo_Transferencia_x_PreAviso_Cheq address = new ba_Archivo_Transferencia_x_PreAviso_Cheq();
                    info.Fecha = Convert.ToDateTime(info.Fecha.ToShortDateString());
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdArchivo_preaviso_cheq = GetId(info.IdEmpresa);
                    address.cod_Archivo_preaviso_cheq = GetId_codigoArchivo(info.IdEmpresa, info.Fecha);
                    address.IdBanco = info.IdBanco;
                    address.Nom_Archivo = info.Nom_Archivo;
                    address.Fecha = info.Fecha;
                    if (info.Archivo == null)
                    {
                        info.Archivo = new byte[000000];
                    }

                    address.Archivo = info.Archivo;

                    address.Estado = info.Estado;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = (DateTime)info.Fecha_Transac;
                    address.Observacion = info.Observacion;
                    context.ba_Archivo_Transferencia_x_PreAviso_Cheq.Add(address);
                    context.SaveChanges();
                    IdArchivo = address.IdArchivo_preaviso_cheq;
                    return true;
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

        public bool ModificarDB(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info)
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();

                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Archivo_Transferencia_x_PreAviso_Cheq.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa 
                        && minfo.IdArchivo_preaviso_cheq == info.IdArchivo_preaviso_cheq);
                    info.Fecha = Convert.ToDateTime(info.Fecha.ToShortDateString());

                    contact.IdBanco = info.IdBanco;
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

        public bool Actualizar_Archivo(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info)
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();

                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Archivo_Transferencia_x_PreAviso_Cheq.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa 
                        && minfo.IdArchivo_preaviso_cheq == info.IdArchivo_preaviso_cheq
                        && minfo.IdBanco == info.IdBanco);

                    contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contact.Fecha_UltMod = info.Fecha_UltMod;
                    contact.Fecha_Proceso = info.Fecha_Proceso;
                    context.SaveChanges();
                    return true;

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

        public bool AnularDB(ba_Archivo_Transferencia_x_PreAviso_Cheq_Info info)
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();

                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Archivo_Transferencia_x_PreAviso_Cheq.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa 
                        && minfo.IdBanco == info.IdBanco 
                        && minfo.IdArchivo_preaviso_cheq == info.IdArchivo_preaviso_cheq);

                    contact.Estado = false;
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = info.Fecha_UltAnu;
                    contact.Motivo_anulacion = info.Motivo_anulacion;
                    context.SaveChanges();
                    return true;

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

                var q = from C in context.ba_Archivo_Transferencia_x_PreAviso_Cheq
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from Query in context.ba_Archivo_Transferencia_x_PreAviso_Cheq
                                   where Query.IdEmpresa == IdEmpresa
                                   select Query.IdArchivo_preaviso_cheq).Max() + 1;
                    Id = (int)select_;
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
            string Id = "";

            try
            {
                EntitiesBanco context = new EntitiesBanco();

                var q = from C in context.ba_Archivo_Transferencia_x_PreAviso_Cheq
                        where C.IdEmpresa == IdEmpresa
                        && C.Fecha == fecha
                        select C;
                if (q.ToList().Count == 0)
                {
                    Id = fecha.Year.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Day.ToString().PadLeft(2, '0') + "_" + "01";
                }
                else
                {
                    var select_ = (from Query in context.ba_Archivo_Transferencia_x_PreAviso_Cheq
                                   where Query.IdEmpresa == IdEmpresa
                                    && Query.Fecha == fecha
                                   select Query.cod_Archivo_preaviso_cheq).Max();
                    int len = select_.Length;
                    int secuencia = Convert.ToInt32(select_.Substring(9, len - 9));
                    secuencia = secuencia + 1;
                    Id = fecha.Year.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Day.ToString().PadLeft(2, '0') + "_" + Convert.ToString(secuencia).PadLeft(2, '0');
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

        public byte[] Get_Archivo(int idEmpresa, decimal idArchivo)
        {
            try
            {
                byte[] binario = new byte[0];

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var Archivo = (from q in Conexion.ba_Archivo_Transferencia_x_PreAviso_Cheq
                                   where idEmpresa == q.IdEmpresa
                                   && idArchivo == q.IdArchivo_preaviso_cheq
                                   select q.Archivo).FirstOrDefault();

                    if (Archivo != null)
                    {
                        binario = Archivo.ToArray();
                    }

                }

                return binario;

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

