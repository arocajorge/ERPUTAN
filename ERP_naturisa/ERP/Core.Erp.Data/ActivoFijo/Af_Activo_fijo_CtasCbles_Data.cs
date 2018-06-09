using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Compras;


namespace Core.Erp.Data.ActivoFijo
{
   public class Af_Activo_fijo_CtasCbles_Data
    {
        string mensaje = "";

        public List<Af_Activo_fijo_CtasCbles_Info> Get_List_Activo_fijo_CtasCbles(int IdEmpresa, int IdActivo_fijo)
        {
            List<Af_Activo_fijo_CtasCbles_Info> lM = new List<Af_Activo_fijo_CtasCbles_Info>();
            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.vwAf_Activo_fijo_CtasCbles
                             where A.IdEmpresa == IdEmpresa
                             && A.IdActivoFijo==IdActivo_fijo
                              select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_CtasCbles_Info info = new Af_Activo_fijo_CtasCbles_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.IdTipoCuenta = item.IdTipoCuenta;

                    info.IdCtaCble = item.IdCtaCble;
                    info.IdCentroCosto = item.IdCentroCosto;

                    info.Secuencia = Convert.ToInt32(item.Secuencia);
                    info.porc_distribucion = item.porc_distribucion;

                    info.Observacion = item.Observacion;

                    lM.Add(info);
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

        public List<Af_Activo_fijo_CtasCbles_Info> Get_List_Activo_fijo_CtasCbles(int IdEmpresa)
        {
            List<Af_Activo_fijo_CtasCbles_Info> lM = new List<Af_Activo_fijo_CtasCbles_Info>();
            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.vwAf_Activo_fijo_CtasCbles
                             where A.IdEmpresa == IdEmpresa
                             select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_CtasCbles_Info info = new Af_Activo_fijo_CtasCbles_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.IdTipoCuenta = item.IdTipoCuenta;
                    info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdCentroCosto = item.IdCentroCosto;

                    info.Secuencia = Convert.ToInt32(item.Secuencia);
                    info.porc_distribucion = item.porc_distribucion;

                    info.Observacion = item.Observacion;

                    lM.Add(info);
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

        public List<Af_Activo_fijo_CtasCbles_Info> Get_List_Activo_fijo_CtasCbles()
        {
            List<Af_Activo_fijo_CtasCbles_Info> lM = new List<Af_Activo_fijo_CtasCbles_Info>();
            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = (from A in OEPActivoFijo.Af_Activo_fijo_CtasCbles
                              select A).ToList();
                foreach (Af_Activo_fijo_CtasCbles item in select)
                {
                    Af_Activo_fijo_CtasCbles_Info info = new Af_Activo_fijo_CtasCbles_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.IdTipoCuenta = item.IdTipoCuenta;
                    
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdCentroCosto = item.IdCentroCosto;

                    info.Secuencia = item.Secuencia;
                    info.porc_distribucion = item.porc_distribucion;

                    info.Observacion = item.Observacion;

                    lM.Add(info);
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

        public Boolean GuardarDB(List<Af_Activo_fijo_CtasCbles_Info> lstInfoCbte, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    foreach (var item in lstInfoCbte)
                    {
                        var Address = new Af_Activo_fijo_CtasCbles();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdActivoFijo = item.IdActivoFijo;
                        Address.IdTipoCuenta = item.IdTipoCuenta;
                        Address.IdCtaCble = item.IdCtaCble;
                        Address.IdCentroCosto = item.IdCentroCosto;
                        Address.Observacion = (item.Observacion == null) ? "" : item.Observacion;
                        Address.Secuencia = item.Secuencia;
                        Address.porc_distribucion = item.porc_distribucion;

                        Context.Af_Activo_fijo_CtasCbles.Add(Address);
                        Context.SaveChanges();
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
                msjError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(List<Af_Activo_fijo_CtasCbles_Info> lstInfoCbte, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    foreach (var item in lstInfoCbte)
                    {
                        var contact = Context.Af_Activo_fijo_CtasCbles.FirstOrDefault(af => af.IdEmpresa == item.IdEmpresa && af.IdActivoFijo == item.IdActivoFijo && af.IdTipoCuenta == item.IdTipoCuenta);
                        if (contact != null)
                        {
                            contact.IdCtaCble = item.IdCtaCble;
                            contact.IdCentroCosto = item.IdCentroCosto;
                            contact.Observacion = item.Observacion;

                            contact.Secuencia = item.Secuencia;
                            contact.porc_distribucion = item.porc_distribucion;

                            Context.SaveChanges();
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
                msjError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdActivoFijo)
        {
            try
            {

                EntitiesCompras Oent = new EntitiesCompras();

                var Consulta = Oent.Database.ExecuteSqlCommand("delete from Af_Activo_fijo_CtasCbles where IdEmpresa = " + IdEmpresa + " and IdActivoFijo =" + IdActivoFijo);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }
   
   }
}
