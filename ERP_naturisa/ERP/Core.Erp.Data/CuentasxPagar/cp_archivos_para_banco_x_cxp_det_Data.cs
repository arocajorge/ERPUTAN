using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Data.CuentasxPagar
{
  public  class cp_archivos_para_banco_x_cxp_det_Data
    {

        string mensaje = "";


        public Boolean GuardaDB(List<cp_archivos_para_banco_x_cxp_det_Info> listaGrabar, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    foreach (var item in listaGrabar)
                    {
                        cp_archivos_para_banco_x_cxp_det Det = new cp_archivos_para_banco_x_cxp_det();

                        Det.IdEmpresa = item.IdEmpresa;
                        Det.IdArchivo = item.IdArchivo;
                        Det.Secuencia = item.Secuencia;
                        Det.IdEmpresa_op = item.IdEmpresa_op;
                        Det.IdOrdenPago_op = item.IdOrdenPago_op;
                        Det.Saldo_x_pagar = item.Saldo_x_pagar;
                        Det.Valor_pagado = item.Valor_pagado;
                        Det.IdUsuario = item.IdUsuario;
                        Det.Fecha_Transac = item.Fecha_Transac;
                        Det.Secuencia_op = item.Secuencia_op;
                        Context.cp_archivos_para_banco_x_cxp_det.Add(Det);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }



        public Boolean AnularDB(List<cp_archivos_para_banco_x_cxp_det_Info> listaAnular)
        {
            try
            {
                using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
                {
                    foreach (var item in listaAnular)
                    {
                     cp_archivos_para_banco_x_cxp_det AnularDet = Entity.cp_archivos_para_banco_x_cxp_det.FirstOrDefault(v => v.IdEmpresa ==item.IdEmpresa && v.IdArchivo==item.IdArchivo && v.Secuencia==item.Secuencia);
                     if (AnularDet != null)
                      {
                          AnularDet.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                          AnularDet.Fecha_UltAnu = item.Fecha_UltAnu;
                          AnularDet.Saldo_x_pagar = 0;
                          AnularDet.Valor_pagado = 0;
                        
                        
                        Entity.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public bool Eliminar_Detalle(int IdEmpresa, decimal idArchivo, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    Context.Database.ExecuteSqlCommand("delete cp_archivos_para_banco_x_cxp_det where IdEmpresa = " + IdEmpresa + " and IdArchivo = "+idArchivo+"");
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


        public List<cp_archivos_para_banco_x_cxp_det_Info> Get_List_Pagos_x_Archivos(int IdEmpresa, int IdArchivo, ref string mensaje)
        {
            try
            {


                List<cp_archivos_para_banco_x_cxp_det_Info> Lista = new List<cp_archivos_para_banco_x_cxp_det_Info>();
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var Listado_File = from q in ECXP.vwcp_cp_archivos_para_banco_x_cxp_det
                                   where q.IdEmpresa == IdEmpresa 
                                   && q.IdArchivo==IdArchivo
                                   select q;

                foreach (var item in Listado_File)
                {
                    cp_archivos_para_banco_x_cxp_det_Info info = new cp_archivos_para_banco_x_cxp_det_Info();

                    info.Secuencia_op = item.Secuencia_op;
                    info.observacion_op = item.Observacion_OP;
                    info.Valor_pagado = item.Valor_pagado;
                    info.Saldo_x_pagar = item.Saldo_x_pagar;
                    info.proveedor = item.pe_razonSocial;
                    info.estado_op = item.IdEstadoAprobacion;
                    info.fecha_op = item.Fecha_Pago;
                    info.check = true;
                    info.IdPersona =(int) item.IdPersona;
                    info.IdOrdenPago_op = item.IdOrdenPago_op;
                    info.Secuencia = item.Secuencia;
                    info.IdArchivo = item.IdArchivo;
                    info.IdEmpresa = IdEmpresa;
                    info.IdEmpresa_op =(int) item.IdOrdenPago_op;
                    Lista.Add(info);
                }
                return (Lista);
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
