using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
///Prog: Catherine Jimenez
///11:14 22/02/2014
///
namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_trans_a_generar_x_FormaPago_OP_Data
    {
        string mensaje = "";

        public List<cp_trans_a_generar_x_FormaPago_OP_Info> Get_List_trans_a_generar_x_FormaPago_OP()
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                List<cp_trans_a_generar_x_FormaPago_OP_Info> lst = new List<cp_trans_a_generar_x_FormaPago_OP_Info>();
                var select = from q in context.cp_trans_a_generar_x_FormaPago_OP
                             select q;

                cp_trans_a_generar_x_FormaPago_OP_Info Info;

                foreach (var item in select)
                {
                    Info = new cp_trans_a_generar_x_FormaPago_OP_Info();
                    Info.IdTipoTransaccion = item.IdTipoTransaccion;
                    Info.Descripcion = item.Descripcion;
              
                    lst.Add(Info);

                }
                return lst;
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

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();

                var Existe = from q in context.cp_trans_a_generar_x_FormaPago_OP
                             where q.IdTipoTransaccion == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public Boolean ModificarDB(List<cp_trans_a_generar_x_FormaPago_OP_Info> lst)
        {
            try
            {
                foreach (cp_trans_a_generar_x_FormaPago_OP_Info item in lst)
                {
                    if (ValidarCodigoExiste(item.IdTipoTransaccion))
                    {
                        ModificarDB(item);
                    }
                    else
                    {
                        GuardarDB(item);
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

        public cp_trans_a_generar_x_FormaPago_OP_Info Get_Info_trans_a_generar_x_FormaPago_OP(string IdTipoTransaccion)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                cp_trans_a_generar_x_FormaPago_OP_Info Info = new cp_trans_a_generar_x_FormaPago_OP_Info();
                var address = context.cp_trans_a_generar_x_FormaPago_OP.FirstOrDefault(var => var.IdTipoTransaccion == IdTipoTransaccion);
                if (address != null)
                {
                    Info.IdTipoTransaccion = address.IdTipoTransaccion;
                    Info.Descripcion = address.Descripcion;
                }
                return Info;
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

        public Boolean GuardarDB(cp_trans_a_generar_x_FormaPago_OP_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = new cp_trans_a_generar_x_FormaPago_OP();
                address.Descripcion = Info.Descripcion;
                address.IdTipoTransaccion = Info.IdTipoTransaccion;

                context.cp_trans_a_generar_x_FormaPago_OP.Add(address);
                context.SaveChanges();
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

        public Boolean ModificarDB(cp_trans_a_generar_x_FormaPago_OP_Info Info)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = context.cp_trans_a_generar_x_FormaPago_OP.FirstOrDefault(var => var.IdTipoTransaccion == Info.IdTipoTransaccion);
                if (address != null)
                {
                    address.Descripcion = Info.Descripcion;
                    context.SaveChanges();
                    res = true;
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
    }
}
