using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//cxc_cobro_x_anticipo
//DEREK MEJÍA
//04022014
//13032014

///24
namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cobro_x_Anticipo_det_Data
    {
        public List<cxc_cobro_x_Anticipo_det_Info> Get_List_cobro_x_Anticipo_det(int IdEmpresa, int IdAnticipo, ref string mensaje)
        {
            try
            {
                List<cxc_cobro_x_Anticipo_det_Info> Lst = new List<cxc_cobro_x_Anticipo_det_Info>();
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consul = from q in cxc.cxc_cobro_x_Anticipo_det
                                 where q.IdEmpresa == IdEmpresa && q.IdAnticipo == IdAnticipo
                                 select q;
                    foreach (var item in consul)
                    {
                        cxc_cobro_x_Anticipo_det_Info info = new cxc_cobro_x_Anticipo_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdAnticipo = item.IdAnticipo;
                        info.IdCobro_cobro = item.IdCobro_cobro;
                        info.IdCobro_tipo = item.IdCobro_tipo;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_Cobro = item.IdEmpresa_Cobro;
                        info.IdSucursal_cobro = item.IdSucursal_cobro;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.IdUsuario = item.IdUsuario;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;
                        info.MotiAnula = item.MotiAnula;
                        Lst.Add(info);
                    }
                }
                return Lst;
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

        public Boolean GuardarDB(List<cxc_cobro_x_Anticipo_det_Info> info, ref string mensaje) {
            try
            {
                //int numero = 0;
                //if (modificar(info,ref numero)==false)
                //{
                    //int i =0;
               // eliminar(info,ref mensaje);
                    foreach (var item in info)
                    {
                        //i++;
                        //if (i==numero)
                        //{
                            using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                            {
                                cxc_cobro_x_Anticipo_det data = new cxc_cobro_x_Anticipo_det();
                                data.IdEmpresa = item.IdEmpresa;
                                data.IdAnticipo = item.IdAnticipo;
                                data.IdCobro_cobro = item.IdCobro_cobro;
                                data.IdCobro_tipo = item.IdCobro_tipo.Trim();
                                data.Secuencia = item.Secuencia;
                                data.IdEmpresa_Cobro = item.IdEmpresa_Cobro;
                                data.IdSucursal_cobro = item.IdSucursal_cobro;
                                data.Fecha_Transac = item.Fecha_Transac;
                                data.IdUsuario = item.IdUsuario;
                                data.IdUsuarioUltMod = item.IdUsuarioUltMod;
                                data.Fecha_UltMod = item.Fecha_UltMod;
                                data.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                                data.Fecha_UltAnu = item.Fecha_UltAnu;
                                data.nom_pc = item.nom_pc;
                                data.ip = item.ip;
                                data.Estado = item.Estado;
                                data.MotiAnula = item.MotiAnula;
                                cxc.cxc_cobro_x_Anticipo_det.Add(data);
                                cxc.SaveChanges();
                            }
                        //}
                    }
                //}                                                       
               
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

        public Boolean ModificarDB(List<cxc_cobro_x_Anticipo_det_Info> info,ref int numero, ref string mensaje) {
            try
            {
                Boolean res = false;
                foreach (var item in info)
                {
                    numero++;
                    using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                    {
                        cxc_cobro_x_Anticipo_det data = cxc.cxc_cobro_x_Anticipo_det.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdAnticipo == item.IdAnticipo && v.Secuencia == item.Secuencia);
                        if (data != null)
                        {
                            data.IdCobro_cobro = item.IdCobro_cobro;
                            data.IdCobro_tipo = item.IdCobro_tipo.Trim();
                            data.IdEmpresa_Cobro = item.IdEmpresa_Cobro;
                            data.IdSucursal_cobro = item.IdSucursal_cobro;
                            data.Fecha_Transac = item.Fecha_Transac;
                            data.IdUsuario = item.IdUsuario;
                            data.IdUsuarioUltMod = item.IdUsuarioUltMod;
                            data.Fecha_UltMod = item.Fecha_UltMod;
                            data.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                            data.Fecha_UltAnu = item.Fecha_UltAnu;
                            data.nom_pc = item.nom_pc;
                            data.ip = item.ip;
                            data.Estado = item.Estado;
                            data.MotiAnula = item.MotiAnula;
                            cxc.SaveChanges();
                            res = true;
                        }
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

        public Boolean Modificar_datos_cobro(List<cxc_cobro_x_Anticipo_det_Info> info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                foreach (var item in info)
                {
                    using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                    {
                        cxc_cobro_x_Anticipo_det data = cxc.cxc_cobro_x_Anticipo_det.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdAnticipo == item.IdAnticipo && v.Secuencia == item.Secuencia);
                        if (data != null)
                        {
                            data.IdEmpresa_Cobro = item.IdEmpresa_Cobro;
                            data.IdSucursal_cobro = item.IdSucursal_cobro;
                            data.IdCobro_cobro = item.IdCobro_cobro;
                            cxc.SaveChanges();
                            res = true;
                        }
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

        public Boolean EliminarDB(List<cxc_cobro_x_Anticipo_det_Info> info, ref string mensaje) {
            try
            {
                Boolean res = false;
                foreach (var item in info)
                {               
                    using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                    {
                        cxc_cobro_x_Anticipo_det data = cxc.cxc_cobro_x_Anticipo_det.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdAnticipo == item.IdAnticipo && v.Secuencia == item.Secuencia);
                        if (data != null)
                        {
                            cxc.cxc_cobro_x_Anticipo_det.Remove(data);
                            cxc.SaveChanges();
                            res = true;
                        }
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
    }
}
