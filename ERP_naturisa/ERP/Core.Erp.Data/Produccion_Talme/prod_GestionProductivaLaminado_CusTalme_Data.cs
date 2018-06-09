using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_GestionProductivaLaminado_CusTalme_Data
    {
        string mensaje = "";
        prod_GestionProductivaLaminado_x_paradas_CusTalme_Data oData = new prod_GestionProductivaLaminado_x_paradas_CusTalme_Data();

        decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id = 0;

                EntitiesProduccion Oenti = new EntitiesProduccion();


                var q = from C in Oenti.prod_GestionProductivaLaminado_CusTalme
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in Oenti.prod_GestionProductivaLaminado_CusTalme
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdGestionProductiva).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB(prod_GestionProductivaLaminado_CusTalme_Info Info , ref decimal Id, ref string msj)
        {
            string Mes = "";
            try
            {
                List<prod_GestionProductivaLaminado_CusTalme_Info> Lst = new List<prod_GestionProductivaLaminado_CusTalme_Info>();
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    var Address = new prod_GestionProductivaLaminado_CusTalme();
                     Id = GetId(Info.IdEmpresa);
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdGestionProductiva = Id;
                    Address.IdTurno = Info.IdTurno;
                    Address.IdEmpleado_JefeTurno = Info.IdEmpleado_JefeTurno;
                    Address.IdProducto_MateriaPrima = Info.IdProducto_MateriaPrima;
                    Address.Id_Bobina = Info.Id_Bobina;
                    Address.Num_Orden = Info.Num_Orden;
                    Address.kg_Cargados = Info.kg_Cargados;
                    Address.kg_producidos = Info.kg_producidos;
                    Address.IdProducto_Producido1 = Info.IdProducto_Producido1;
                    Address.unidades_prd_1 = Info.unidades_prd_1;
                    Address.pesokg_prd_1 = Info.pesokg_prd_1;
                    Address.IdProducto_Producido2 = Info.IdProducto_Producido2;
                    Address.unidades_prd_2 = Info.unidades_prd_2;
                    Address.pesokg_prd_2 = Info.pesokg_prd_2;
                    Address.kg_retazo_porcen = Info.kg_retazo_porcen;
                    Address.kg_retazo_valor = Info.kg_retazo_valor;
                    Address.kg_chatarra_porcen = Info.kg_chatarra_porcen;
                    Address.kg_chatarra_valor = Info.kg_chatarra_valor;
                    Address.kg_oxidacion_porcen = Info.kg_oxidacion_porcen;
                    Address.kg_oxidacion_valor = Info.kg_oxidacion_valor;
                    Address.rendi_metal_historico = Info.rendi_metal_historico;
                    Address.rendi_metal_real = Info.rendi_metal_real;
                    Address.rendi_metal_Diferencia = Info.rendi_metal_Diferencia;
                    Address.consumo_kilowatios = Info.consumo_kilowatios;
                    Address.consumo_galones = Info.consumo_galones;
                    Address.cambio_prue_programado = Info.cambio_prue_programado;
                    Address.cambio_prue_real = Info.cambio_prue_real;
                    Address.cambio_prue_porcentaje = Info.cambio_prue_porcentaje;
                    Address.hora_turno_ini = Info.hora_turno_ini;
                    Address.hora_turno_fin = Info.hora_turno_fin;
                    Address.hora_jornada = Info.hora_jornada;
                    Address.hora_productiva = Info.hora_productiva;
                    Address.hora_Paros = Info.hora_Paros;
                    Address.hora_Neta = Info.hora_Neta;
                    Address.hora_Hrs_Maquina = Info.hora_Hrs_Maquina;
                    Address.Ton_Programada = Info.Ton_Programada;
                    Address.Ton_real = Info.Ton_real;
                    Address.Ton_Eficiencia = Info.Ton_Eficiencia;
                    Address.Ton_TnHrNeta = Info.Ton_TnHrNeta;
                    Address.Ton_kwTon = Info.Ton_kwTon;
                    Address.Ton_GlsTon = Info.Ton_GlsTon;
                    Address.EficienciaProduccion = Info.EficienciaProduccion;
                    Address.Estado = "A";
                    Address.Fecha = Info.Fecha;

                    Context.prod_GestionProductivaLaminado_CusTalme.Add(Address);
                    Context.SaveChanges();
                    msj = "Guardado Exitosamente Le Gestion #" + Id;
                    decimal id = Id;
                    Info.ListDetalle.ForEach(Var =>
                                                {
                                                    Var.IdEmpresa = Info.IdEmpresa; Var.IdGestionProductiva = id;
                                                });
                    if (oData.GuardarDB(Info.ListDetalle, ref Mes))
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
                
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(int IdEmpresa, decimal Id)
        {
            try
            {
                using (EntitiesProduccion oEnt = new EntitiesProduccion()) 
                {
                    var Contact = oEnt.prod_GestionProductivaLaminado_CusTalme.First(var => var.IdEmpresa == IdEmpresa && var.IdGestionProductiva == Id);
                    Contact.Estado = "I";
                    oEnt.SaveChanges();
                
                }


                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<prod_GestionProductivaLaminado_CusTalme_Info> Get_List_GestionProductivaLaminado_CusTalm(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
                List<prod_GestionProductivaLaminado_CusTalme_Info> lista = new List<prod_GestionProductivaLaminado_CusTalme_Info>();
            try
            {
                EntitiesProduccion oEnt = new EntitiesProduccion();
                string FechaInStr = FechaIni.ToString("MM/dd/yyyy");
                string FechaFinStr = FechaFin.ToString("MM/dd/yyyy");
                string Query = "select * from vwProd_GestionProductivaTalmeLaminado where IdEmpresa =" + IdEmpresa + " and Fecha >= '" + FechaInStr + "' and Fecha <='" + FechaFinStr + "'";


                var Consulta = oEnt.Database.SqlQuery<prod_GestionProductivaLaminado_CusTalme_Info>(Query);
                return Consulta.ToList();
                                           
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public Boolean ModificarDB(prod_GestionProductivaLaminado_CusTalme_Info Info)
        {
            try
            {
                using (EntitiesProduccion oEnt = new EntitiesProduccion())
                {
                    var Contact = oEnt.prod_GestionProductivaLaminado_CusTalme.First(var => var.IdEmpresa == Info.IdEmpresa && var.IdGestionProductiva == Info.IdGestionProductiva);
                    Contact.IdTurno = Info.IdTurno;
                    Contact.IdEmpleado_JefeTurno = Info.IdEmpleado_JefeTurno;
                    Contact.Id_Bobina = Info.Id_Bobina;
                    Contact.Num_Orden = Info.Num_Orden;
                    Contact.kg_Cargados = Info.kg_Cargados;
                    Contact.kg_producidos = Info.kg_producidos;
                    Contact.kg_retazo_porcen = Info.kg_retazo_porcen;
                    Contact.kg_retazo_valor = Info.kg_retazo_valor;
                    Contact.kg_chatarra_porcen = Info.kg_chatarra_porcen;
                    Contact.kg_chatarra_valor = Info.kg_chatarra_valor;
                    Contact.kg_oxidacion_porcen = Info.kg_oxidacion_porcen;
                    Contact.kg_oxidacion_valor = Info.kg_oxidacion_valor;
                    Contact.rendi_metal_historico = Info.rendi_metal_historico;
                    Contact.rendi_metal_real = Info.rendi_metal_real;
                    Contact.rendi_metal_Diferencia = Info.rendi_metal_Diferencia;
                    Contact.consumo_kilowatios = Info.consumo_kilowatios;
                    Contact.consumo_galones = Info.consumo_galones;
                    Contact.cambio_prue_programado = Info.cambio_prue_programado;
                    Contact.cambio_prue_real = Info.cambio_prue_real;
                    Contact.cambio_prue_porcentaje = Info.cambio_prue_porcentaje;
                    Contact.hora_turno_ini = Info.hora_turno_ini;
                    Contact.hora_turno_fin = Info.hora_turno_fin;
                    Contact.hora_jornada = Info.hora_jornada;
                    Contact.hora_productiva = Info.hora_productiva;
                    Contact.hora_Paros = Info.hora_Paros;
                    Contact.hora_Neta = Info.hora_Neta;
                    Contact.hora_Hrs_Maquina = Info.hora_Hrs_Maquina;
                    Contact.Ton_Programada = Info.Ton_Programada;
                    Contact.Ton_real = Info.Ton_real;
                    Contact.Ton_Eficiencia = Info.Ton_Eficiencia;
                    Contact.Ton_TnHrNeta = Info.Ton_TnHrNeta;
                    Contact.Ton_kwTon = Info.Ton_kwTon;
                    Contact.Ton_GlsTon = Info.Ton_GlsTon;
                    Contact.EficienciaProduccion = Info.EficienciaProduccion;
                    Contact.Fecha = Info.Fecha;
                    oEnt.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public void EjecutarSpReporte(int IdEmpresa, decimal IdGestion, string IdUsuario, string nom_Pc)
        {
            try
            {
                EntitiesProduccion oEntities = new EntitiesProduccion() ;

              //  oEntities.spProd_Rpt_PRD_CUS_TAL_001(IdEmpresa, IdGestion, nom_Pc, IdUsuario);              
                    
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
