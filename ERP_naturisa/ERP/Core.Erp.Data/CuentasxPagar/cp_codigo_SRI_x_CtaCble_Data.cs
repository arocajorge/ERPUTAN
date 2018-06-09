using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_codigo_SRI_x_CtaCble_Data
    {   
        string mensaje = "";

        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble()
        {

            try
            {
                List<cp_codigo_SRI_x_CtaCble_Info> lm = new List<cp_codigo_SRI_x_CtaCble_Info>();
                EntitiesCuentasxPagar CodSRIxCC = new EntitiesCuentasxPagar();
                var q = from A in CodSRIxCC.vwcp_codigo_SRI_x_ctaCble
                        select A;
                tb_Empresa_Data emp = new tb_Empresa_Data();
                List<tb_Empresa_Info> listaEmpresa = new List<tb_Empresa_Info>();
                listaEmpresa = emp.Get_List_Empresa();
                foreach (var item in q)
                {
                    cp_codigo_SRI_x_CtaCble_Info info = new cp_codigo_SRI_x_CtaCble_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.Empresa = (from x in listaEmpresa
                                    where x.IdEmpresa == item.IdEmpresa
                                    select x.em_nombre).ToString();
                    info.idCodigo_SRI = item.idCodigo_SRI;
                    info.IdCtaCble = item.IdCtaCble;
                    info.pc_Cuenta = item.pc_Cuenta;
                    lm.Add(info);
                }
                return lm;
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
      
        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble(int IdEmpresa)
        {

            try
            {
                List<cp_codigo_SRI_x_CtaCble_Info> lm = new List<cp_codigo_SRI_x_CtaCble_Info>();
                EntitiesCuentasxPagar CodSRIxCC = new EntitiesCuentasxPagar();
                var q = from A in CodSRIxCC.vwcp_codigo_SRI_x_ctaCble
                        where A.IdEmpresa==IdEmpresa
                        select A;
                tb_Empresa_Data emp = new tb_Empresa_Data();
                List<tb_Empresa_Info> listaEmpresa = new List<tb_Empresa_Info>();
                listaEmpresa = emp.Get_List_Empresa();
                foreach (var item in q)
                {
                    cp_codigo_SRI_x_CtaCble_Info info = new cp_codigo_SRI_x_CtaCble_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.Empresa = (from x in listaEmpresa
                                    where x.IdEmpresa == item.IdEmpresa
                                    select x.em_nombre).ToString();
                    info.idCodigo_SRI = item.idCodigo_SRI;
                    info.IdCtaCble = item.IdCtaCble;
                    info.pc_Cuenta = item.pc_Cuenta;
                    lm.Add(info);
                }
                return lm;
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

        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble(int IdEmpresa,int IdCodigo_SRI)
        {

            try
            {
                List<cp_codigo_SRI_x_CtaCble_Info> lm = new List<cp_codigo_SRI_x_CtaCble_Info>();
                EntitiesCuentasxPagar CodSRIxCC = new EntitiesCuentasxPagar();
                var q = from A in CodSRIxCC.vwcp_codigo_SRI_x_ctaCble
                        where A.IdEmpresa == IdEmpresa
                        && A.idCodigo_SRI == IdCodigo_SRI
                        select A;
                tb_Empresa_Data emp = new tb_Empresa_Data();
                List<tb_Empresa_Info> listaEmpresa = new List<tb_Empresa_Info>();
                listaEmpresa = emp.Get_List_Empresa();
                foreach (var item in q)
                {
                    cp_codigo_SRI_x_CtaCble_Info info = new cp_codigo_SRI_x_CtaCble_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.Empresa = (from x in listaEmpresa
                                    where x.IdEmpresa == item.IdEmpresa
                                    select x.em_nombre).ToString();
                    info.idCodigo_SRI = item.idCodigo_SRI;
                    info.IdCtaCble = item.IdCtaCble;
                    info.pc_Cuenta = item.pc_Cuenta;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.idUsuario = item.idUsuario;
                    info.fecha_UltMod = item.fecha_UltMod;
                    lm.Add(info);
                }
                return lm;
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

        public cp_codigo_SRI_x_CtaCble_Info GetInfo_codigo_SRI_x_CtaCble( int IdEmpresa ,int IdCodigo_SRI)
        {

            try
            {
                cp_codigo_SRI_x_CtaCble_Info info = new cp_codigo_SRI_x_CtaCble_Info();
                EntitiesCuentasxPagar CodSRIxCC = new EntitiesCuentasxPagar();
                var q = from A in CodSRIxCC.cp_codigo_SRI_x_CtaCble
                        where A.IdEmpresa == IdEmpresa &&
                        A.idCodigo_SRI == IdCodigo_SRI
                        select A;
                tb_Empresa_Data emp = new tb_Empresa_Data();
                List<tb_Empresa_Info> listaEmpresa = new List<tb_Empresa_Info>();
                listaEmpresa = emp.Get_List_Empresa();
                foreach (var item in q)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.Empresa = (from x in listaEmpresa
                                    where x.IdEmpresa == item.IdEmpresa
                                    select x.em_nombre).ToString();
                    info.idCodigo_SRI = item.idCodigo_SRI;
                    info.IdCtaCble = item.IdCtaCble;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.idUsuario = item.idUsuario;
                    info.fecha_UltMod = item.fecha_UltMod;
                }
                return info;
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

        public Boolean GuardarDB(cp_codigo_SRI_x_CtaCble_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_codigo_SRI_x_CtaCble Address = new cp_codigo_SRI_x_CtaCble();

                    Address.IdEmpresa = info.IdEmpresa;
                    Address.idCodigo_SRI = info.idCodigo_SRI;
                    Address.IdCtaCble = info.IdCtaCble;
                    Address.idUsuario = info.idUsuario;
                    Address.ip = info.ip;
                    Address.nom_pc = info.nom_pc;
                    Address.fecha_UltMod = info.fecha_UltMod;

                    Context.cp_codigo_SRI_x_CtaCble.Add(Address);
                    Context.SaveChanges();
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

        public Boolean ModificarDB(cp_codigo_SRI_x_CtaCble_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar param = new EntitiesCuentasxPagar();
                    var selectBaParam = (from C in param.cp_codigo_SRI_x_CtaCble
                                         where C.IdEmpresa == info.IdEmpresa && 
                                         C.idCodigo_SRI == info.idCodigo_SRI
                                         select C).Count();

                    if (selectBaParam == 0)
                    {
                        cp_codigo_SRI_x_CtaCble addressG = new cp_codigo_SRI_x_CtaCble();
                        addressG.IdEmpresa = info.IdEmpresa;
                        addressG.idCodigo_SRI = info.idCodigo_SRI;
                        addressG.IdCtaCble = info.IdCtaCble;
                        addressG.fecha_UltMod = info.fecha_UltMod;
                        addressG.idUsuario = info.idUsuario;
                        addressG.ip = info.ip;
                        addressG.nom_pc = info.nom_pc;

                        context.cp_codigo_SRI_x_CtaCble.Add(addressG);
                        context.SaveChanges();
                    }
                    else
                    {
                        var contact = context.cp_codigo_SRI_x_CtaCble.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.idCodigo_SRI == info.idCodigo_SRI);
                        if (contact != null)
                        {
                            contact.IdEmpresa = info.IdEmpresa;
                            contact.idCodigo_SRI = info.idCodigo_SRI;
                            contact.IdCtaCble = info.IdCtaCble;
                            contact.fecha_UltMod = info.fecha_UltMod;
                            contact.idUsuario = info.idUsuario;
                            contact.ip = info.ip;
                            contact.nom_pc = info.nom_pc;
                            context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public cp_codigo_SRI_x_CtaCble_Data() { }
    }
}
