using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_TerminoPago_Distribucion_Data
    {
        string mensaje = "";

        public List<fa_TerminoPago_Distribucion_Info> Get_List_TerminoPago_Distribucion(string IdTipoFormaPago)
        {
            try
            {
                List<fa_TerminoPago_Distribucion_Info> lst = new List<fa_TerminoPago_Distribucion_Info>();
                EntitiesFacturacion context = new EntitiesFacturacion();

                var select = from q in context.fa_TerminoPago_Distribucion
                             where q.IdTerminoPago == IdTipoFormaPago
                             select q;

                fa_TerminoPago_Distribucion_Info _Info;

                foreach (var item in select)
                {
                    _Info = new fa_TerminoPago_Distribucion_Info();
                    _Info.IdTerminoPago = item.IdTerminoPago;
                    _Info.Secuencia = item.Secuencia;
                    _Info.Por_distribucion = item.Por_distribucion;
                    _Info.Num_Dias_Vcto = item.Num_Dias_Vcto;
                    lst.Add(_Info);
                }

                return lst;
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

        public Boolean GuardarDB(List<fa_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                foreach (var item in lst)
                {
                    var address = new fa_TerminoPago_Distribucion();

                    address.IdTerminoPago = item.IdTerminoPago;
                    address.Secuencia = item.Secuencia;
                    address.Por_distribucion = item.Por_distribucion;
                    address.Num_Dias_Vcto = item.Num_Dias_Vcto;
                    context.fa_TerminoPago_Distribucion.Add(address);
                    context.SaveChanges();
                }

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

         public Boolean EliminarDB(string IdTipoFormaPago)
        {
            try
            {

                 using (EntitiesFacturacion Entity = new EntitiesFacturacion())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete fa_TerminoPago_Distribucion where IdTerminoPago ='" + IdTipoFormaPago + "'");
                }

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

        

        public Boolean ModificarDB(List<fa_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                foreach (var item in lst)
                {
                    var address = new fa_TerminoPago_Distribucion();

                    address.IdTerminoPago = item.IdTerminoPago;
                    address.Secuencia = item.Secuencia;
                    address.Por_distribucion = item.Por_distribucion;
                    address.Num_Dias_Vcto = item.Num_Dias_Vcto;
                    context.fa_TerminoPago_Distribucion.Add(address);
                    context.SaveChanges();

                }

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
