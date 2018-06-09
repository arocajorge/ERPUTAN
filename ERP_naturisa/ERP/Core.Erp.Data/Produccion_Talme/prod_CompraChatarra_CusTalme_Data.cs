using System;
using System.Collections.Generic;
using System.Linq;
using Core.Erp.Data;
using System.Text;

using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_CompraChatarra_CusTalme_Data
    {
        string mensaje = "";
        decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id = 0;

                EntitiesProduccion Oenti = new EntitiesProduccion();


                var q = from C in Oenti.prod_CompraChatarra_CusTalme
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in Oenti.prod_CompraChatarra_CusTalme
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdLiquidacion).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }

        public Boolean GuardarDB(prod_CompraChatarra_CusTalme_Info Info, ref decimal IdLiquidacion , ref string Mensaje )
        {
            try
            {
               
                List<prod_CompraChatarra_CusTalme_Info> Lst = new List<prod_CompraChatarra_CusTalme_Info>();
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    var Address = new prod_CompraChatarra_CusTalme();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdLiquidacion = IdLiquidacion = GetId(Info.IdEmpresa);
                    Address.IdProveedor_Presu = Info.IdProveedor_Presu;
                    Address.IdProveedor = Info.IdProveedor;
                    Address.Fecha = Info.Fecha;
                    Address.Beneficiario = Info.Beneficiario;
                    Address.Placa = Info.Placa;
                    Address.IdTipoChatarra = Info.IdTipoChatarra;
                    Address.PrecioChatarra = Info.PrecioChatarra;
                    Address.TLlenoKg = Info.TLlenoKg;
                    Address.TVacionKg = Info.TVacionKg;
                    Address.TMermaKg = Info.TMermaKg;
                    Address.TNetokg = Info.TNetokg; 
                    Address.Subtotal = Info.Subtotal;
                    Address.Descuento = Info.Descuento;
                    Address.Total = Info.Total;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.IdUsuarioUltMod = Info.IdUsuario;
                    Address.Fecha_Transa = Info.Fecha_Transaccion;
                    Address.Fecha_UltMod = Info.Fecha_UltMod;
                    Address.ip = Info.ip;
                    Info.nom_pc = Info.nom_pc;
                    Address.Estado = "A";

                    Context.prod_CompraChatarra_CusTalme.Add(Address);
                    Context.SaveChanges();

                    Mensaje = "Registro # "+IdLiquidacion+ " Ingresado Correctamente";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prod_CompraChatarra_CusTalme_Info> Get_List_CompraChatarra_CusTalme(int IdEmpresa, DateTime DechaInicial, DateTime FechaFin)
        {
               EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            { 
                string Querty = "select * from vwProd_CompraChatarra Where IdEmpresa ="+IdEmpresa+" and Fecha>= '" + DechaInicial.ToString("yyyy/MM/dd") + "' and Fecha <= '" + FechaFin.ToString("yyyy/MM/dd") + "'";
                return oEnti.Database.SqlQuery<prod_CompraChatarra_CusTalme_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Anular(prod_CompraChatarra_CusTalme_Info Info, ref string Mensaje)
        {
            try
            {
                using (EntitiesProduccion oEnt = new EntitiesProduccion())
                {
                    var Contact = oEnt.prod_CompraChatarra_CusTalme.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdLiquidacion == Info.IdLiquidacion);
                    if (Contact != null)
                    {
                        Contact.Estado = "I";
                        Contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        Contact.IdUsuario = Info.IdUsuario;
                        Contact.ip = Info.ip;
                        Contact.nom_pc = Info.nom_pc;
                        oEnt.SaveChanges();
                        Mensaje = "Se Ha procedido Anular Con exito La Transaccion # " + Info.IdLiquidacion;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
