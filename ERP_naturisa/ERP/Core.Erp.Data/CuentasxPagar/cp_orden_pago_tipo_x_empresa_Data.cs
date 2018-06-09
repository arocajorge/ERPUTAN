using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_pago_tipo_x_empresa_Data
    {
        string mensaje = "";

        public List<cp_orden_pago_tipo_x_empresa_Info> Get_List_orden_pago_tipo_x_empresa(int IdEmpresa)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                List<cp_orden_pago_tipo_x_empresa_Info> lst = new List<cp_orden_pago_tipo_x_empresa_Info>();
                var select = from q in context.vwcp_orden_pago_tipo_x_empresa
                             where q.IdEmpresa == IdEmpresa 
                             select q;

                cp_orden_pago_tipo_x_empresa_Info Info;

                foreach (var item in select)
                {
                    Info = new cp_orden_pago_tipo_x_empresa_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdTipo_op = item.IdTipo_op;
                    Info.IdCtaCble = item.IdCtaCble;
                    Info.IdCtaCble_Credito = item.IdCtaCble_Credito;

                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.IdTipoCbte_OP = Convert.ToInt32(item.IdTipoCbte_OP);
                    Info.IdTipoCbte_OP_anulacion = Convert.ToInt32(item.IdTipoCbte_OP_anulacion);
                    Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Info.Buscar_FactxPagar = "S";
                    Info.GeneraDiario = item.GeneraDiario;
                    Info.nom_Tipo_op = item.Descripcion;
                    Info.Estado = item.Estado;
                    Info.Viene_de_Base = true;
                    Info.Dispara_Alerta = (item.Dispara_Alerta == null) ? false : Convert.ToBoolean(item.Dispara_Alerta);


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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(string Cod, int IdEmpresa)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();

                var Existe = from q in context.cp_orden_pago_tipo_x_empresa
                             where q.IdTipo_op == Cod && q.IdEmpresa == IdEmpresa
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<cp_orden_pago_tipo_x_empresa_Info> lst)
        {
            try
            {
                string msgError = "";
                
                foreach (cp_orden_pago_tipo_x_empresa_Info item in lst)
                {
                    if (ValidarCodigoExiste(item.IdTipo_op,item.IdEmpresa))
                    {
                        ModificarDB(item, ref msgError);
                    }
                    else
                    {
                        GuardarDB(item, ref msgError);
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

        public cp_orden_pago_tipo_x_empresa_Info Get_Info_orden_pago_tipo_x_empresa(int IdEmpresa, string IdTipo_Op)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                cp_orden_pago_tipo_x_empresa address= new cp_orden_pago_tipo_x_empresa();
                if (IdTipo_Op != null)
                {
                    address = context.cp_orden_pago_tipo_x_empresa.FirstOrDefault(var => var.IdTipo_op == IdTipo_Op && var.IdEmpresa == IdEmpresa);
                }
                else
                {
                    address = context.cp_orden_pago_tipo_x_empresa.FirstOrDefault(var => var.IdEmpresa == IdEmpresa);
                }
                cp_orden_pago_tipo_x_empresa_Info Info = new cp_orden_pago_tipo_x_empresa_Info();

                if (address != null)
                {
                    Info.IdEmpresa = address.IdEmpresa;
                    Info.IdTipo_op = address.IdTipo_op;
                    Info.IdCtaCble = address.IdCtaCble;
                    Info.IdCtaCble_Credito = address.IdCtaCble_Credito;
                    Info.IdCentroCosto = address.IdCentroCosto;
                    Info.IdTipoCbte_OP = address.IdTipoCbte_OP;
                    Info.IdTipoCbte_OP_anulacion = address.IdTipoCbte_OP_anulacion;
                    Info.IdEstadoAprobacion = address.IdEstadoAprobacion;

                    Info.Dispara_Alerta = (address.Dispara_Alerta == null) ? false : Convert.ToBoolean(address.Dispara_Alerta);

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
        
        public Boolean GuardarDB(cp_orden_pago_tipo_x_empresa_Info Info, ref string msgError)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = new cp_orden_pago_tipo_x_empresa();
                address.IdEmpresa = Info.IdEmpresa;
                address.IdTipo_op = Info.IdTipo_op;
                address.IdCtaCble = Info.IdCtaCble;
                address.IdCtaCble_Credito = Info.IdCtaCble_Credito;
                address.IdCentroCosto = Info.IdCentroCosto;
                address.IdTipoCbte_OP = Info.IdTipoCbte_OP;
                address.IdTipoCbte_OP_anulacion = Info.IdTipoCbte_OP_anulacion;
                address.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                address.Buscar_FactxPagar = Info.Buscar_FactxPagar;
                address.Dispara_Alerta = Info.Dispara_Alerta;


                context.cp_orden_pago_tipo_x_empresa.Add(address);
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msgError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(cp_orden_pago_tipo_x_empresa_Info Info, ref string msgError)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = context.cp_orden_pago_tipo_x_empresa.FirstOrDefault(var => var.IdTipo_op == Info.IdTipo_op && var.IdEmpresa == Info.IdEmpresa);
                if (address != null)
                {
                    address.IdCtaCble = Info.IdCtaCble;
                    address.IdCtaCble_Credito = Info.IdCtaCble_Credito;
                    address.IdCentroCosto = Info.IdCentroCosto;
                    address.IdTipoCbte_OP = Info.IdTipoCbte_OP;
                    address.IdTipoCbte_OP_anulacion = Info.IdTipoCbte_OP_anulacion;
                    address.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                    address.Dispara_Alerta = Info.Dispara_Alerta;

                    context.SaveChanges();
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
                msgError = mensaje;
                throw new Exception(ex.ToString());
            }
        }
    }
}