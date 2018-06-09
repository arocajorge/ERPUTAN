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
   public class ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Data
    {


        string mensaje = "";

        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> Get_List_Archivo_Transferencia_x_PreAviso_Cheq_det(int idEmpresa, decimal idArchivo)
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    var lst = (from q in Conexion.vwba_Archivo_Transferencia_x_PreAviso_Cheq_det
                               where idEmpresa == q.IdEmpresa && idArchivo == q.IdArchivo_preaviso_cheq
                               select q);

                    foreach (var item in lst)
                    {
                        ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info Info = new ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdArchivo_preaviso_cheq = item.IdArchivo_preaviso_cheq;
                        Info.secuencia = item.secuencia;
                        Info.observacion_det = item.observacion_det;
                        Info.IdEmpresa_mvba = item.IdEmpresa_mvba;
                        Info.IdCbteCble_mvba = item.IdCbteCble_mvba;
                        Info.IdTipocbte_mvba = item.IdTipocbte_mvba;
                        Info.cb_Fecha = item.cb_Fecha;
                        Info.cb_Observacion = item.cb_Observacion;
                        Info.cb_Cheque = item.cb_Cheque;
                        Info.cb_Valor = item.cb_Valor;
                        Info.CodTipoCbte = item.CodTipoCbte;
                        Info.cb_giradoA = item.cb_giradoA;
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


       
        public bool GrabarDB(List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> Lista)
        {
            try
            {
                int secuencia = 0;
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    foreach (var item in Lista)
                    {
                        secuencia = secuencia + 1;
                        ba_Archivo_Transferencia_x_PreAviso_Cheq_det Addres = new ba_Archivo_Transferencia_x_PreAviso_Cheq_det();
                        Addres.IdEmpresa = item.IdEmpresa;


                        context.ba_Archivo_Transferencia_x_PreAviso_Cheq_det.Add(Addres);
                        context.SaveChanges();
                    }

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


        public bool AnularDB(List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> lista)
        {
            try
            {

                using (EntitiesBanco context = new EntitiesBanco())
                {
                    foreach (var item in lista)
                    {
                        var contact = context.ba_Archivo_Transferencia_x_PreAviso_Cheq_det.FirstOrDefault(minfo => minfo.IdEmpresa == item.IdEmpresa 
                            && minfo.IdArchivo_preaviso_cheq == item.IdArchivo_preaviso_cheq 
                            && minfo.secuencia == item.secuencia);

                        //contact.Estado = "I";
                        
                        context.SaveChanges();
                    }
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

        public Boolean Actualizar_registro(ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info Info)
        {
            try
            {

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    ba_Archivo_Transferencia_x_PreAviso_Cheq_det Entity = Conexion.ba_Archivo_Transferencia_x_PreAviso_Cheq_det.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa 
                        && q.IdArchivo_preaviso_cheq == Info.IdArchivo_preaviso_cheq
                        && q.secuencia == Info.secuencia);

                    //Entity.Id_Item = Info.Id_Item;
                    //Entity.IdEstadoRegistro_cat = Info.IdEstadoRegistro_cat;
                    //**Entity.Valor_cobrado = Info.Valor_cobrado;

                    Conexion.SaveChanges();
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


    }
}
