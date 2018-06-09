using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_TerminoPago_Data
    {
        string mensaje = "";


        public List<fa_TerminoPago_Info> Get_List_TerminoPago(string IdTipoCredito)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                List<fa_TerminoPago_Info> lst = new List<fa_TerminoPago_Info>();

                var select = from q in context.fa_TerminoPago
                             select q;

                if (IdTipoCredito == Cl_Enumeradores.eTipoCreditoCliente.CRE.ToString())
                    select = select.Where(q => q.Dias_Vct > 0);

                if (IdTipoCredito == Cl_Enumeradores.eTipoCreditoCliente.CON.ToString())
                    select = select.Where(q => q.IdTerminoPago == IdTipoCredito);

                fa_TerminoPago_Info _Info;

                foreach(var item in select )
                {
                    _Info = new fa_TerminoPago_Info();
                    _Info.IdTerminoPago = item.IdTerminoPago;
                    _Info.nom_TerminoPago = item.nom_TerminoPago;
                    _Info.Dias_Vct = item.Dias_Vct;
                    _Info.Num_Cuotas = item.Num_Coutas;
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

        public Boolean GuardarDB(fa_TerminoPago_Info _Info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                var address = new fa_TerminoPago();

                address.IdTerminoPago = _Info.IdTerminoPago;
                address.nom_TerminoPago = _Info.nom_TerminoPago;
                address.Dias_Vct = _Info.Dias_Vct;
                address.Num_Coutas = _Info.Num_Cuotas;

                context.fa_TerminoPago.Add(address);
                context.SaveChanges();

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

        public Boolean ModificarDB(fa_TerminoPago_Info _Info, ref string msjError)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                var address = context.fa_TerminoPago.FirstOrDefault(var => var.IdTerminoPago == _Info.IdTerminoPago);
                if (address != null)
                {
                    address.nom_TerminoPago = _Info.nom_TerminoPago;
                    address.Dias_Vct = _Info.Dias_Vct;
                    address.Num_Coutas = _Info.Num_Cuotas;

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
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_TerminoPago_Info> Get_List_TerminoPago()
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                List<fa_TerminoPago_Info> lst = new List<fa_TerminoPago_Info>();

                var select = from q in context.fa_TerminoPago
                             select q;

                fa_TerminoPago_Info _Info;

                foreach (var item in select)
                {
                    _Info = new fa_TerminoPago_Info();
                    _Info.IdTerminoPago = item.IdTerminoPago;
                    _Info.nom_TerminoPago = item.nom_TerminoPago;
                    _Info.Dias_Vct = item.Dias_Vct;
                    _Info.Num_Cuotas = item.Num_Coutas;
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

        

    }
}
