using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_GestionProductivaAcero_CusTalme_Data
    {
        string mensaje = "";

        decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id = 0;

                EntitiesProduccion Oenti = new EntitiesProduccion();


                var q = from C in Oenti.prod_GestionProductivaAcero_CusTalme
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in Oenti.prod_GestionProductivaAcero_CusTalme
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdGestionAceria).Max();
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
                throw new Exception(ex.ToString().ToString());
            }
        }

        public Boolean GuardarDB(prod_GestionProductivaAcero_CusTalme_Info Info , ref Decimal IdGestion,ref string Mensaje)
        {
            try
            {
              
                List<prod_GestionProductivaAcero_CusTalme_Info> Lst = new List<prod_GestionProductivaAcero_CusTalme_Info>();
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                   
                    var Address = new prod_GestionProductivaAcero_CusTalme();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdGestionAceria =IdGestion= GetId(Info.IdEmpresa);
                    Address.Fecha = Info.Fecha;
                    Address.IdHorno = Info.IdHorno;
                    Address.IdColada = Info.IdColada;
                    Address.chat_En_Horno = Info.chat_En_Horno;
                    Address.chat_Cargada = Info.chat_Cargada;
                    Address.Vaci_TempC = Info.Vaci_TempC;
                    Address.Vaci_acero = Info.Vaci_acero;
                    Address.EnHor_Acero = Info.EnHor_Acero;
                    Address.EnHor_Perdida = Info.EnHor_Perdida;
                    Address.Comps_C = Info.Comps_C;
                    Address.Comps_Si = Info.Comps_Si;
                    Address.Comps_Mn = Info.Comps_Mn;
                    Address.Comps_P = Info.Comps_P;
                    Address.Comps_S = Info.Comps_S;
                    Address.Comps_SAE = Info.Comps_SAE;
                    Address.AdiMet_Carburante = Info.AdiMet_Carburante;
                    Address.AdiMet_Cal = Info.AdiMet_Cal;
                    Address.AdiMet_Desercoriante = Info.AdiMet_Desercoriante;
                    Address.Tiem_Encendido = Info.Tiem_Encendido;
                    Address.Tiem_Apagado = Info.Tiem_Apagado;
                    Address.Tiem_Fundicion = Info.Tiem_Fundicion;
                    Address.Tiem_Vaciado = Info.Tiem_Vaciado;
                    Address.Tiem_Total = Info.Tiem_Total;
                    Address.Ener_Ea = Info.Ener_Ea;
                    Address.Ener_Er = Info.Ener_Er;
                    Address.Ener_Total = Info.Ener_Total;
                    Address.Ferroa_FeSi = Info.Ferroa_FeSi;
                    Address.Ferroa_FeMn = Info.Ferroa_FeMn;
                    Address.IndiHor_Rendimiento = Info.IndiHor_Rendimiento;
                    Address.IndiHor_Productividad = Info.IndiHor_Productividad;
                    Address.Tundish = Info.Tundish;
                    Address.InicioCC = Info.InicioCC;
                    Address.FinCC = Info.FinCC;
                    Address.Tiempo = Info.Tiempo;
                    Address.AceroCldo = Info.AceroCldo;
                    Address.Palanquilla = Info.Palanquilla;
                    Address.Marrano = Info.Marrano;
                    Address.Escoria = Info.Escoria;
                    Address.PerdidaCC = Info.PerdidaCC;
                    Address.RendtCC = Info.RendtCC;
                    Address.ProductivCC = Info.ProductivCC;
                    Address.IdProducto_TipoPalanquilla = Info.IdProducto_TipoPalanquilla;
                    Address.Unidades = Info.Unidades;
                    Address.Longitud = Info.Longitud;
                    Address.PesoUnitario = Info.PesoUnitario;
                    Address.PesoMetro = Info.PesoMetro;
                    Address.Perdida = Info.Perdida;
                    Address.ProdRend = Info.ProdRend;
                    Address.ProdProduct = Info.ProdProduct;
                    Address.Observacion = Info.Observacion;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transaccion = Info.Fecha_Transaccion;
                    Address.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                    Address.Fecha_UltMod = Info.Fecha_UltMod;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.Estado = "A";
                    Address.Termopares = Info.Termopares;
                    Address.FeSiMn = Info.FeSiMn;
                    Context.prod_GestionProductivaAcero_CusTalme.Add(Address);
                    Context.SaveChanges();
                    Mensaje = "Se A Procedido A guardar Con exito el Registro #" + Address.IdGestionAceria;
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
                throw new Exception(ex.ToString().ToString());
            }
        }

        public List<prod_GestionProductivaAcero_CusTalme_Info> Get_List_GestionProductivaAcero_CusTalm(int IdEmpresa, DateTime FechaIni, DateTime FechaFin) 
        {
                List<prod_GestionProductivaAcero_CusTalme_Info> lista = new List<prod_GestionProductivaAcero_CusTalme_Info>();
            try
            {
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    string dateIni = FechaIni.ToString("yyyy/MM/dd");
                    string dateFin = FechaFin.ToString("yyyy/MM/dd");
                    string Query = "select * from vwProd_GestionProductivaAceria_CusTalme where IdEmpresa ="+IdEmpresa+"  and Fecha >= '" + dateIni + "' and Fecha <= '"+dateFin+"'";
                    lista = Context.Database.SqlQuery<prod_GestionProductivaAcero_CusTalme_Info>(Query).ToList();
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString().ToString());
            }
        }

        public Boolean AnularDB(prod_GestionProductivaAcero_CusTalme_Info Info, ref string Mensaje)
        {
            try
            {
                using (EntitiesProduccion oEnt = new EntitiesProduccion())
                {
                    var Contact = oEnt.prod_GestionProductivaAcero_CusTalme.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdGestionAceria == Info.IdGestionAceria && var.IdSucursal == Info.IdSucursal);
                    if(Contact!=null)
                    {
                        Contact.Estado = "I";
                        oEnt.SaveChanges();
                        Mensaje = "Se Ha procedido Anular Con exito La Transaccion # "+Info.IdGestionAceria;
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
                throw new Exception(ex.ToString().ToString());
            }
        }
    }
}
