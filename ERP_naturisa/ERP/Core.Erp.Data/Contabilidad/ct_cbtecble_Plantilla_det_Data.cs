using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_cbtecble_Plantilla_det_Data
    {
        string mensaje = "";
        
        public List<ct_cbtecble_Plantilla_det_Info> Get_list_Planilla_det(int IdEmpresa)
        {
            try
            {
                List<ct_cbtecble_Plantilla_det_Info> lM = new List<ct_cbtecble_Plantilla_det_Info>();
                EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                var select_det = from C in OECbtecble_det.ct_cbtecble_Plantilla_det
                                         where C.IdEmpresa == IdEmpresa
                                         select C;

                foreach (var item in select_det)
                {
                    ct_cbtecble_Plantilla_det_Info Cbt = new ct_cbtecble_Plantilla_det_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdTipoCbte = item.IdTipoCbte;
                    Cbt.secuencia = item.secuencia;
                    Cbt.IdCtaCble = item.IdCtaCble;
                    Cbt.IdCentroCosto = item.IdCentroCosto;
                    Cbt.dc_Valor = item.dc_Valor;
                    Cbt.Debe_Aux = (item.dc_Valor > 0) ? item.dc_Valor : 0;
                    Cbt.Haber_Aux = (item.dc_Valor < 0) ? item.dc_Valor * -1 : 0;
                    Cbt.dc_Observacion = item.dc_Observacion;
                    Cbt.IdPunto_cargo = item.IdPunto_cargo;
                    Cbt.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    lM.Add(Cbt);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }


        }
        
        public List<ct_cbtecble_Plantilla_det_Info> Get_list_Planilla_det(int IdEmpresa, int idTipoCbte, decimal IdPlantilla)
        {

            try
            {
                List<ct_cbtecble_Plantilla_det_Info> lM = new List<ct_cbtecble_Plantilla_det_Info>();
                EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                var selectPla_det = from C in OECbtecble_det.ct_cbtecble_Plantilla_det
                                    where C.IdEmpresa == IdEmpresa && C.IdTipoCbte == idTipoCbte && C.IdPlantilla == IdPlantilla
                                    select C;

                           
                foreach (var item in selectPla_det)
                {
                    ct_cbtecble_Plantilla_det_Info Cbt = new ct_cbtecble_Plantilla_det_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdTipoCbte = item.IdTipoCbte;
                    Cbt.secuencia = item.secuencia;
                    Cbt.IdCtaCble = item.IdCtaCble;
                    Cbt.IdCentroCosto = item.IdCentroCosto;
                    Cbt.dc_Valor = item.dc_Valor;

                    Cbt.Debe_Aux = (item.dc_Valor > 0) ? item.dc_Valor :0;
                    Cbt.Haber_Aux = (item.dc_Valor < 0) ? item.dc_Valor*-1 : 0;

                    Cbt.dc_Observacion = item.dc_Observacion;
                    Cbt.IdPunto_cargo = item.IdPunto_cargo;
                    Cbt.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    

                    lM.Add(Cbt);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_cbtecble_Plantilla_det_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble_Plantilla_det.FirstOrDefault(tbCbteCble => tbCbteCble.IdEmpresa == info.IdEmpresa && tbCbteCble.IdTipoCbte == info.IdTipoCbte && tbCbteCble.secuencia == info.secuencia);
                    if (contact != null)
                    {
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.IdCtaCble = info.IdCtaCble;
                        contact.IdTipoCbte = info.IdTipoCbte;
                        contact.secuencia = info.secuencia;
                        contact.dc_Valor = info.dc_Valor;
                        contact.dc_Observacion = info.dc_Observacion;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(ct_cbtecble_Plantilla_det_Info Info)
        {
            try
            {
                using (EntitiesDBConta contexto = new EntitiesDBConta())
                {
                    ct_cbtecble_Plantilla_det address_tabla = new ct_cbtecble_Plantilla_det();
                    address_tabla.IdEmpresa = Info.IdEmpresa;
                    address_tabla.IdTipoCbte = Info.IdTipoCbte;
                    address_tabla.IdCtaCble = Info.IdCtaCble;
                    address_tabla.IdPlantilla = Info.IdPlantilla;
                    
                    if (Info.IdCentroCosto != "")
                    {
                        address_tabla.IdCentroCosto = Info.IdCentroCosto; 
                    }

                    address_tabla.secuencia = Info.secuencia;
                    address_tabla.dc_Valor = Info.dc_Valor;
                    if (Info.Debe_Aux > 0)
                    {
                        address_tabla.dc_Valor = Info.Debe_Aux;
                    }
                    if (Info.Haber_Aux > 0)
                    {
                        address_tabla.dc_Valor = Info.Haber_Aux * -1;
                    }

                    address_tabla.dc_Observacion = (Info.dc_Observacion == null) ? "" : Info.dc_Observacion;
                    address_tabla.IdPunto_cargo = Info.IdPunto_cargo;
                    address_tabla.IdPunto_cargo_grupo = Info.IdPunto_cargo_grupo;
                    contexto.ct_cbtecble_Plantilla_det.Add(address_tabla); 

                    contexto.SaveChanges();
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<ct_cbtecble_Plantilla_det_Info> lista)
        {
            try
            {
                foreach (var item in lista)
                {
                    GrabarDB(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(ct_cbtecble_Plantilla_det_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble_Plantilla_det.FirstOrDefault(tb => tb.IdEmpresa == info.IdEmpresa && tb.IdTipoCbte == info.IdTipoCbte && tb.IdPlantilla == info.IdPlantilla && tb.secuencia==info.secuencia);
                    if (contact != null)
                    {
                        context.ct_cbtecble_Plantilla_det.Remove(contact);
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(List<ct_cbtecble_Plantilla_det_Info> lm)
        {
            try
            {

                foreach (var item in lm)
                {
                    EliminarDB(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public Boolean EliminarDB(int IdEmpresa,int IdTipoCbte ,decimal IdPlantilla)
        {
            try
            {

                
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var Consulta = context.Database.ExecuteSqlCommand("delete from ct_cbtecble_Plantilla_det where IdEmpresa = " + IdEmpresa + " and IdTipoCbte =" + IdTipoCbte + " and IdPlantilla= " + IdPlantilla + "");
                }
                
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        

        
    
        public ct_cbtecble_Plantilla_det_Data()
        {
            
        }
    }
}
