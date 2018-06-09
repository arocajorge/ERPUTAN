using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_GestionProductivaTechos_CusTalme_Cab_Data
    {
        string mensaje = "";
        prod_GestionProductivaTechos_CusTalme_Detalle_Data dataDetalle = new prod_GestionProductivaTechos_CusTalme_Detalle_Data();
        
        decimal GetId(int IdEmpresa)
        {            
            try
            {
                decimal Id = 0;

                EntitiesProduccion Oenti = new EntitiesProduccion();


                var q = from C in Oenti.prod_GestionProductivaTechos_CusTalme_Cab
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in Oenti.prod_GestionProductivaTechos_CusTalme_Cab
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
                mensaje = ex.ToString()+ " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }
        
        public Boolean GuardarDB(prod_GestionProductivaTechos_CusTalme_Cab_Info Info , ref decimal Id)
        {
            try
            {
                List<prod_GestionProductivaTechos_CusTalme_Cab_Info> Lst = new List<prod_GestionProductivaTechos_CusTalme_Cab_Info>();
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    var Address = new prod_GestionProductivaTechos_CusTalme_Cab();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdGestionProductiva =Id = GetId(Info.IdEmpresa);
                    Address.IdProducto_MateriaPrima = Info.IdProducto_MateriaPrima;
                    Address.Fecha = Info.Fecha;
                    Address.IdModeloProd = Info.IdModeloProd;
                    Address.HrsTurno = Info.HrsTurno;
                    Address.Tprep = Info.Tprep;
                    Address.Despacho = Info.Despacho;
                    Address.Factor = Info.Factor;
                    Address.Num_Personas = Info.Num_Personas;
                    Address.Consumo = Info.Consumo;
                    Address.Chatarra = Info.Chatarra;
                    Address.IdTurno = Info.IdTurno;

                    Address.ip = Info.ip;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.nom_pc = Info.nom_pc;
                    Address.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                    Address.Fecha_UltMod = Info.Fecha_UltMod;
                    Address.Estado = "A";

                    Info.ListaDetalle.ForEach(var=> {var.IdGestionProductiva=    Address.IdGestionProductiva;var.IdEmpresa = Address.IdEmpresa;});

                    Context.prod_GestionProductivaTechos_CusTalme_Cab.Add(Address);
                    Context.SaveChanges();

                    if (dataDetalle.GuardarDB(Info.ListaDetalle))
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
                mensaje = ex.ToString()+ " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(prod_GestionProductivaTechos_CusTalme_Cab_Info info)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {
                    var contact = context.prod_GestionProductivaTechos_CusTalme_Cab.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdGestionProductiva == info.IdGestionProductiva);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString()+ " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prod_GestionProductivaTechos_CusTalme_Cab_Info> Get_List_GestionProductivaTechos_CusTalme_Cab(int IdEmpresa, DateTime FechaInicial, DateTime FechaFin) 
        {
            List<prod_GestionProductivaTechos_CusTalme_Cab_Info> lista = new List<prod_GestionProductivaTechos_CusTalme_Cab_Info>();
            try
            {              

                using (EntitiesProduccion Oent = new EntitiesProduccion()) 
                {
                    string FeIn = FechaInicial.ToString("yyyy/MM/dd");
                    string FeFn = FechaFin.ToString("yyyy/MM/dd");
                    string query="select * from vwprod_GestionProductivaTechos_Talme where IdEmpresa = "+IdEmpresa+" And Fecha >= '"+FeIn+"' and Fecha <= '"+FeFn+"' ";
                    var Consulta = Oent.Database.SqlQuery<prod_GestionProductivaTechos_CusTalme_Cab_Info>(query);
                    lista = Consulta.ToList();
                
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString()+ " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public void EjecutarSpReporte(string IdUsuario,int IdEmpresa,string NomPc,decimal IdGestion) 
        {
                EntitiesProduccion oEnt = new EntitiesProduccion();
            try
            {
               // oEnt.spProd_Rpt_PRD_CUS_TAL_002(IdUsuario, IdEmpresa, IdGestion, NomPc);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString()+ " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }        
        }
    }
}
