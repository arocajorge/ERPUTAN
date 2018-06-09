using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_Catalogo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Catalogo_Data oData = new ba_Catalogo_Data();


        public List<ba_Catalogo_Info> Get_List_PeriocidadPago()
        {
            try{return oData.Get_List_PeriocidadPago(); }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener  .." + ex.Message;
                return new List<ba_Catalogo_Info>();
            }
            
        }
        
        public List<ba_Catalogo_Info> Get_List_MetodoCalculo()
        {
            try{ return oData.Get_List_MetodoCalculo();
            }catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener .." + ex.Message;
                return new List<ba_Catalogo_Info>(); 
            }
            
        }

        public List<ba_Catalogo_Info> Get_List_MotivoPrestamo()
        {
            try{ return oData.Get_List_MotivoPrestamo();}
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener .." + ex.Message;
                return new List<ba_Catalogo_Info>();
            }
            
        }

        public List<ba_Catalogo_Info> Get_List_EstadoPago()
        {
            try{ return oData.Get_List_EstadoPago();}
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener .." + ex.Message;
                return new List<ba_Catalogo_Info>(); 
            }
            
        }


        public List<ba_Catalogo_Info> Get_List_Estado_Cbte_ban()
        {
            try { return oData.Get_List_Estado_Cbte_ban(); }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener .." + ex.Message;
                return new List<ba_Catalogo_Info>();
            }

        }

        public string GetId()
        {
            try{ return oData.GetId(); }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error  .." + ex.Message;
                return null; 
            }
        }

        public List<ba_Catalogo_Info> Get_List_Catalogo()
        {
            try{ return oData.Get_List_Catalogo(); }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener .." + ex.Message;
                return new List<ba_Catalogo_Info>(); 
            } 
        }

        public List<ba_Catalogo_Info> Get_List_Catalogo(string cod)
        {
            try { return oData.Get_List_Catalogo(cod); }
            catch (Exception ex )
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener .." + ex.Message;
                return new List<ba_Catalogo_Info>();
            }
        }

        public Boolean GuardarDB(ref ba_Catalogo_Info Info)
        {
            try { return oData.GuardarDB(ref Info); }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return false; 
            }
        }

        public Boolean ValidarCodigoExiste(string cod)
        {
            try { return oData.ValidarCodigoExiste(cod); }
            catch (Exception ex) 
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Validar .." + ex.Message;
                return false; 
            }
        }

        public Boolean ModificarDB(ref ba_Catalogo_Info Info)
        {
            try { return oData.ModificarDB(Info); }
            catch (Exception ex) 
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Modificar .." + ex.Message;
                return false; 
            }
        }

        public Boolean AnularDB(ref ba_Catalogo_Info Info)
        {
            try { return oData.AnularDB(Info); }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Anular .." + ex.Message;
                return false; 
            }
        }

        public Boolean ValidarIdTipoCatalogo_Descripcion(string idTipoCatalogo, string ca_descripcion)
        {
            try { return oData.ValidarIdTipoCatalogo_Descripcion(idTipoCatalogo, ca_descripcion); }
            catch (Exception ex) 
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Validar .." + ex.Message;
                return false; 
            }
        }

    }
}
