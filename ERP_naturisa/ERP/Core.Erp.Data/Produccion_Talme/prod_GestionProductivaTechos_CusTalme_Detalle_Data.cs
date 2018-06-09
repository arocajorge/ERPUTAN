using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_GestionProductivaTechos_CusTalme_Detalle_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List <prod_GestionProductivaTechos_CusTalme_Detalle_Info> Lista)
        {
            try
            {
                int c = 1;
                foreach (var Info in Lista)
                {
                    using (EntitiesProduccion Context = new EntitiesProduccion())
                    {
                        var Address = new prod_GestionProductivaTechos_CusTalme_Detalle();

                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdGestionProductiva = Info.IdGestionProductiva;
                        Address.Secuencia = c;
                        c++;
                        Address.Prod_IdProducto = Info.Prod_IdProducto;
                        Address.Prod_Largo = Info.Prod_Largo;
                        Address.Prod_Ancho = Info.Prod_Ancho;
                        Address.Prod_PsoEsp = Info.Prod_PsoEsp;
                        Address.Prod_Espesor = Info.Prod_Espesor;
                        Address.Prod_PsoUnd = Info.Prod_PsoUnd;
                        Address.Prducc_Unidades = Info.Prducc_Unidades;
                        Address.Prducc_Kg = Info.Prducc_Kg;
                        if (Info.Segunda_IdProducto == 0)
                            Address.Segunda_IdProducto = null;
                        else
                            Address.Segunda_IdProducto = Info.Segunda_IdProducto;
                        Address.Segunda_Unidades = Info.Segunda_Unidades;
                        Address.Segunda_Kg = Info.Segunda_Kg;
                        Address.Chatarra_Kg = Info.Chatarra_Kg;
                        Address.Peso = Info.Peso;
                        Address.Kg_Desp = Info.Kg_Desp;
                        Address.Rend_Metalico = Info.Rend_Metalico;
                        Address.KW = Info.KW;
                        Address.Tiempo_Preparacion = Info.Tiempo_Preparacion;
                        Address.Tiempo_Produccion = Info.Tiempo_Produccion;
                        Address.Tiempo_Total = Info.Tiempo_Total;
                        Address.Parada_Mecanica = Info.Parada_Mecanica;
                        Address.Parada_Electrico = Info.Parada_Electrico;
                        Address.Parada_Logistica = Info.Parada_Logistica;
                        Address.Parada_Otros = Info.Parada_Otros;
                        Address.TotalParos = Info.TotalParos;
                        Address.Indicadores_TnHrs = Info.Indicadores_TnHrs;
                        Address.Indicadores_TimeParda = Info.Indicadores_TimeParda;
                        Address.Indicadores_UndsHrs = Info.Indicadores_UndsHrs;
                        Address.Indicadores_Calidad = Info.Indicadores_Calidad;

                        Context.prod_GestionProductivaTechos_CusTalme_Detalle.Add(Address);
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
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public List<prod_GestionProductivaTechos_CusTalme_Detalle_Info> Get_List_GestionProductivaTechos_CusTalme_Detall(int Idempresa, decimal Idgestion)
        {
                List<prod_GestionProductivaTechos_CusTalme_Detalle_Info> Lst = new List<prod_GestionProductivaTechos_CusTalme_Detalle_Info>();
                EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {

                var Query = from q in oEnti.prod_GestionProductivaTechos_CusTalme_Detalle
                            where q.IdEmpresa == Idempresa && q.IdGestionProductiva== Idgestion
                            select q;
                foreach (var item in Query)
                {
                    prod_GestionProductivaTechos_CusTalme_Detalle_Info Obj = new prod_GestionProductivaTechos_CusTalme_Detalle_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdGestionProductiva = item.IdGestionProductiva;
                    Obj.Secuencia = item.Secuencia;
                    Obj.Prod_IdProducto = Convert.ToDecimal(item.Prod_IdProducto);
                    Obj.Prod_Largo = Convert.ToDouble(item.Prod_Largo);
                    Obj.Prod_Ancho = Convert.ToDouble(item.Prod_Ancho);
                    Obj.Prod_PsoEsp = Convert.ToDouble(item.Prod_PsoEsp);
                    Obj.Prod_Espesor = Convert.ToDouble(item.Prod_Espesor);
                    Obj.Prod_PsoUnd = Convert.ToDouble(item.Prod_PsoUnd);
                    Obj.Prducc_Unidades = Convert.ToDouble(item.Prducc_Unidades);
                    Obj.Prducc_Kg = Convert.ToDouble(item.Prducc_Kg);
                    Obj.Segunda_IdProducto = Convert.ToDecimal(item.Segunda_IdProducto);
                    Obj.Segunda_Unidades = Convert.ToDouble(item.Segunda_Unidades);
                    Obj.Segunda_Kg = Convert.ToDouble(item.Segunda_Kg);
                    Obj.Chatarra_Kg = Convert.ToDouble(item.Chatarra_Kg);
                    Obj.Peso = Convert.ToDouble(item.Peso);
                    Obj.Kg_Desp = Convert.ToDouble(item.Kg_Desp);
                    Obj.Rend_Metalico = Convert.ToDouble(item.Rend_Metalico);
                    Obj.KW = Convert.ToDouble(item.KW);
                    Obj.Tiempo_Preparacion = item.Tiempo_Preparacion;
                    Obj.Tiempo_Produccion =item.Tiempo_Produccion;
                    Obj.Tiempo_Total = item.Tiempo_Total;
                    Obj.Parada_Mecanica = item.Parada_Mecanica;
                    Obj.Parada_Electrico = item.Parada_Electrico;
                    Obj.Parada_Logistica = item.Parada_Logistica;
                    Obj.Parada_Otros = item.Parada_Otros;
                    Obj.TotalParos = item.TotalParos;
                    Obj.Indicadores_TnHrs = Convert.ToDouble(item.Indicadores_TnHrs);
                    Obj.Indicadores_TimeParda = Convert.ToDouble(item.Indicadores_TimeParda);
                    Obj.Indicadores_UndsHrs = Convert.ToDouble(item.Indicadores_UndsHrs);
                    Obj.Indicadores_Calidad = Convert.ToDouble(item.Indicadores_Calidad);
                    Lst.Add(Obj);
                }
                return Lst;
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
