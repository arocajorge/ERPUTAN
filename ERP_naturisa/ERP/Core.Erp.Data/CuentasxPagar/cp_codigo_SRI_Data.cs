using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_codigo_SRI_Data
    {
        string mensaje = "";

        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI_x_codigo(string[] CodRetencion,int IdEmpresa)
        {
            List<cp_codigo_SRI_Info> lM = new List<cp_codigo_SRI_Info>();
            try
            {
             
                
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();
                
                var select_ = from TI in OEUser.vwcp_codigo_SRI
                                           where (CodRetencion.Contains(TI.IdTipoSRI)) && TI.IdEmpresa == IdEmpresa
                              orderby TI.co_f_valides_hasta descending 
                                      select TI;

                foreach (var item in select_)
                {
                    cp_codigo_SRI_Info dat = new cp_codigo_SRI_Info();
                    dat.IdCodigo_SRI = item.IdCodigo_SRI ;
                    dat.codigoSRI = item.codigoSRI;
                    dat.co_codigoBase = item.co_codigoBase;
                    dat.co_descripcion = item.co_descripcion;
                    dat.co_porRetencion = item.co_porRetencion;
                    dat.co_f_vigente_desde = item.co_f_valides_desde;
                    dat.co_f_vigente_hasta = item.co_f_valides_hasta;
                    dat.co_estado = item.co_estado;
                    dat.IdTipoSRI = item.IdTipoSRI;
                    //dat.IdCtaCble = item.IdCtaCble;
                    dat.descriConcate = "[" + item.codigoSRI + "] - " + item.co_descripcion + " " + item.co_porRetencion + "%";
                    
                    lM.Add(dat);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI_IvaRet(int IdEmpresa)
        {
            List<cp_codigo_SRI_Info> lM = new List<cp_codigo_SRI_Info>();
            try
            {
                
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var select_ = from TI in OEUser.vwcp_codigo_SRI
                          
                              where (TI.IdTipoSRI=="COD_RET_IVA" || TI.IdTipoSRI=="COD_RET_FUE") && TI.IdEmpresa == IdEmpresa
                              orderby TI.co_f_valides_hasta descending
                              select TI;

                foreach (var item in select_)
                {
                    cp_codigo_SRI_Info dat = new cp_codigo_SRI_Info();
                    dat.IdCodigo_SRI = item.IdCodigo_SRI;
                    dat.codigoSRI = item.codigoSRI;
                    dat.co_codigoBase = item.co_codigoBase;
                    dat.co_descripcion = item.co_descripcion;
                    dat.co_porRetencion = item.co_porRetencion;
                    dat.co_f_vigente_desde = item.co_f_valides_desde;
                    dat.co_f_vigente_hasta = item.co_f_valides_hasta;
                    dat.co_estado = item.co_estado;
                    dat.IdTipoSRI = item.IdTipoSRI;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.descriConcate = "[" + item.codigoSRI + "] - " + item.co_descripcion + " " + item.co_porRetencion + "%";

                    dat.FechaVigente = dat.co_f_vigente_desde.ToShortDateString() + " - " + dat.co_f_vigente_hasta.ToShortDateString();

                    if (item.IdTipoSRI == "COD_RET_IVA")
                    { dat.Tipo = "IVA"; }

                    if (item.IdTipoSRI == "COD_RET_FUE")
                    { dat.Tipo = "RTF"; }

                    lM.Add(dat);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI(string cod_tipo)
        {
            try
            {
                List<cp_codigo_SRI_Info> lM = new List<cp_codigo_SRI_Info>();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();

                var select_ = from TI in Base.cp_codigo_SRI 
                              where TI.IdTipoSRI.Contains(cod_tipo)
                              select TI;

                foreach (var item in select_)
                {
                  
                    cp_codigo_SRI_Info datI = new cp_codigo_SRI_Info();
                    
                    datI.IdCodigo_SRI = item.IdCodigo_SRI ;
                    datI.codigoSRI  = item.codigoSRI;
                    datI.co_codigoBase  = item.co_codigoBase;
                    datI.co_descripcion  = item.co_descripcion;
                    datI.co_descripcion2 = "[" + item.codigoSRI + "]-"+ item.co_descripcion;
                    datI.co_porRetencion  = item.co_porRetencion;
                    datI.co_f_vigente_desde  = item.co_f_valides_desde;
                    datI.co_f_vigente_hasta  = item.co_f_valides_hasta;
                    datI.co_estado  = item.co_estado;
                    datI.IdTipoSRI = item.IdTipoSRI;


                    lM.Add(datI);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }
      
        public int GetId()
        {
            try
            {
                int Id;
                EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar();
                var selectCbtecble = (from CbtCble in base_.cp_codigo_SRI
                                      select CbtCble.IdCodigo_SRI ).Max();

                Id = selectCbtecble + 1;
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }


        }

        public Boolean GrabarDB(cp_codigo_SRI_Info info, ref int id)
        {
            try
            {
                int id_ = 0;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();
                    var Q = from per in EDB.cp_codigo_SRI
                            where per.IdCodigo_SRI  == info.IdCodigo_SRI
                            select per;
                    if (Q.ToList().Count == 0)
                    {

                        id_ = GetId();
                        id = id_;


                        cp_codigo_SRI address = new cp_codigo_SRI();
                        address.IdCodigo_SRI  = id_;
                        address.codigoSRI = info.codigoSRI.Trim();
                        address.co_codigoBase = info.co_codigoBase.Trim();
                        address.co_descripcion = info.co_descripcion.Trim();
                        address.co_porRetencion = info.co_porRetencion;
                        address.co_f_valides_desde = Convert.ToDateTime(info.co_f_vigente_desde.ToShortDateString());
                        address.co_f_valides_hasta = Convert.ToDateTime(info.co_f_vigente_hasta.ToShortDateString());
                        address.co_estado = info.co_estado;
                        address.IdTipoSRI = info.IdTipoSRI;
                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transac = info.Fecha_Transac;
                        address.ip = info.ip;
                        address.nom_pc = info.nom_pc;
                       // address.IdCtaCble = info.IdCtaCble.Trim();

                        context.cp_codigo_SRI.Add(address);
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(cp_codigo_SRI_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_codigo_SRI.FirstOrDefault(minfo => minfo.IdCodigo_SRI  == info.IdCodigo_SRI);
                    if (contact != null)
                    {
                        contact.codigoSRI = info.codigoSRI;
                        contact.co_codigoBase = info.co_codigoBase;
                        contact.co_descripcion = info.co_descripcion.Trim();
                        contact.co_porRetencion = info.co_porRetencion;
                        contact.co_f_valides_desde = info.co_f_vigente_desde;
                        contact.co_f_valides_hasta = info.co_f_vigente_hasta;
                        contact.co_estado = info.co_estado;
                        contact.IdTipoSRI = info.IdTipoSRI;
                        contact.IdUsuario = info.IdUsuario;
                        contact.Fecha_Transac = info.Fecha_UltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(cp_codigo_SRI_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_codigo_SRI.FirstOrDefault(minfo => minfo.IdCodigo_SRI == info.IdCodigo_SRI);
                    if (contact != null)
                    {
                        contact.co_estado = "I";
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public cp_codigo_SRI_Data() { }

        public Boolean ModificarDB(List<cp_codigo_SRI_x_CtaCble_Info> lista, int codigoSRI) {
            try
            {
                using (EntitiesCuentasxPagar Contex = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar param_Info = new EntitiesCuentasxPagar();
                    var selectBaParam = (from C in param_Info.cp_codigo_SRI_x_CtaCble
                                         where C.idCodigo_SRI == codigoSRI
                                         select C).Count();
                    if (selectBaParam == 0)
                    {
                        foreach (var item in lista)
                        {                            
                            cp_codigo_SRI_x_CtaCble address = new cp_codigo_SRI_x_CtaCble();
                            address.IdEmpresa = item.IdEmpresa;
                            address.idCodigo_SRI = codigoSRI;
                            address.IdCtaCble = item.IdCtaCble;
                            address.idUsuario = item.idUsuario;
                            address.ip = item.ip;
                            address.fecha_UltMod=Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            address.nom_pc = item.nom_pc;
                            Contex.cp_codigo_SRI_x_CtaCble.Add(address);
                            Contex.SaveChanges();
                        }
                    }
                    else
                    {

                        using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                        {
                            foreach (var item in lista)
                            {
                                var contact = context.cp_codigo_SRI_x_CtaCble.First(cot => cot.IdEmpresa == item.IdEmpresa && cot.idCodigo_SRI == item.idCodigo_SRI);
                                
                                contact.IdCtaCble = item.IdCtaCble;
                                contact.idUsuario = item.idUsuario;
                                contact.ip = item.ip;
                                contact.fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                contact.nom_pc = item.nom_pc;
                                context.SaveChanges();
                            }
                        }
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        
        }

        public List<cp_codigo_SRI_Info> Get_List_codigo_SRI_(int IdEmpresa)
        {
            try
            {
             
                List<cp_codigo_SRI_Info> lM = new List<cp_codigo_SRI_Info>();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var select_ = from TI in OEUser.vwcp_codigo_SRI
                               where  TI.IdEmpresa == IdEmpresa
                              orderby TI.co_f_valides_hasta descending
                              select TI;

                foreach (var item in select_)
                {
                    cp_codigo_SRI_Info dat = new cp_codigo_SRI_Info();
                    dat.IdCodigo_SRI = item.IdCodigo_SRI;
                    dat.codigoSRI = item.codigoSRI;
                    dat.co_codigoBase = item.co_codigoBase;
                    dat.co_descripcion = item.co_descripcion;
                    dat.co_porRetencion = item.co_porRetencion;
                    dat.co_f_vigente_desde = item.co_f_valides_desde;
                    dat.co_f_vigente_hasta =item.co_f_valides_hasta;
                    dat.co_estado = item.co_estado;
                    dat.IdTipoSRI = item.IdTipoSRI;
                    dat.IdCtaCble = item.IdCtaCble;
                    dat.descriConcate = "[" + item.codigoSRI + "] - " + item.co_descripcion + " " + item.co_porRetencion + "%";

                   

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
