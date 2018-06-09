using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cobro_tipo_x_cobros_Docxc_Data
    {
        string mensaje = "";

        public Boolean ValidarSiExiste(string IdCobro_tipo)
        {
            bool ret = false;
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = from q in context.cxc_cobro_tipo_x_cobros_Docxc
                              where q.IdCobro_tipo == IdCobro_tipo 
                              select q;

                if (address.ToList().Count > 0)
                {
                    ret = false;
                }
                else
                {
                    ret = true;
                }
                return ret;
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

        public List<cxc_cobro_tipo_Info> Get_List_cobro_tipo()
        {
            try
            {
                List<cxc_cobro_tipo_Info> lst = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();

                var select = from q in context.cxc_cobro_tipo
                             join w in context.cxc_cobro_tipo_x_cobros_Docxc
                             on q.IdCobro_tipo equals w.IdCobro_tipo
                             orderby w.Posicion
                             select q;


                cxc_cobro_tipo_Info _Info;
                foreach (var item in select)
                {
                    _Info = new cxc_cobro_tipo_Info();
                    _Info.IdCobro_tipo = item.IdCobro_tipo;
                    _Info.tc_descripcion = item.tc_descripcion;
                    lst.Add(_Info);
                }
                return lst;
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

        public Boolean ModificarDB(cxc_cobro_tipo_x_cobros_Docxc_Info Info)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = context.cxc_cobro_tipo_x_cobros_Docxc.FirstOrDefault(var => var.IdCobro_tipo == Info.IdCobro_tipo);
                if (address != null)
                {
                    address.Posicion = Info.Posicion;
                    context.SaveChanges();
                    res = true;
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

        public List<cxc_cobro_tipo_x_cobros_Docxc_Info> Get_List_cobro_tipo_x_cobros_Docxc(ref string mensaje)
        {
            try
            {
                List<cxc_cobro_tipo_x_cobros_Docxc_Info> lst = new List<cxc_cobro_tipo_x_cobros_Docxc_Info>();
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();

                var select = from q in context.cxc_cobro_tipo_x_cobros_Docxc
                             orderby q.Posicion
                             select q;

                cxc_cobro_tipo_x_cobros_Docxc_Info _Info;
                foreach (var item in select)
                {
                    _Info = new cxc_cobro_tipo_x_cobros_Docxc_Info();
                    _Info.IdCobro_tipo = item.IdCobro_tipo;
                    _Info.Posicion = item.Posicion;
                    lst.Add(_Info);
                }
                return lst;
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

        public Boolean GuardarDB(cxc_cobro_tipo_x_cobros_Docxc_Info Info)
        {
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = new cxc_cobro_tipo_x_cobros_Docxc();
                address.IdCobro_tipo = Info.IdCobro_tipo;
                address.Posicion = Info.Posicion;
                context.cxc_cobro_tipo_x_cobros_Docxc.Add(address);
                context.SaveChanges();

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

        public Boolean EliminarDB(cxc_cobro_tipo_x_cobros_Docxc_Info Info)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = context.cxc_cobro_tipo_x_cobros_Docxc.FirstOrDefault(var => var.IdCobro_tipo == Info.IdCobro_tipo);
                if (address != null)
                {
                    context.cxc_cobro_tipo_x_cobros_Docxc.Remove(address);
                    context.SaveChanges();
                    res = true;
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
