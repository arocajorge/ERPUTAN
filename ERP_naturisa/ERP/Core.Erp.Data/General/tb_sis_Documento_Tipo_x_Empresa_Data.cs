using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_sis_Documento_Tipo_x_Empresa_Data
    {
        string mensaje = "";

        public List<tb_sis_Documento_Tipo_x_Empresa_Info> Get_List_sis_Documento_Tipo_x_Empresa(int IdEmpresa)
        {
            try
            {
                List<tb_sis_Documento_Tipo_x_Empresa_Info> lst = new List<tb_sis_Documento_Tipo_x_Empresa_Info>();
                tb_sis_Documento_Tipo_x_Empresa_Info Info;
                EntitiesGeneral context = new EntitiesGeneral();
                var address = from q in context.tb_sis_Documento_Tipo_x_Empresa
                              where q.IdEmpresa == IdEmpresa
                              orderby q.Posicion
                              select q;
                              
                foreach (var item in address)
                { 
                    Info = new tb_sis_Documento_Tipo_x_Empresa_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.codDocumentoTipo = item.codDocumentoTipo;
                    Info.ApareceComboFac_TipoFact = item.ApareceComboFac_TipoFact;
                    Info.ApareceComboFac_Import = item.ApareceComboFac_Import;
                    Info.ApareceTalonario = item.ApareceTalonario;
                    Info.Descripcion = item.Descripcion;
                    Info.Posicion = item.Posicion;
                    Info.ApareceCombo_FileReporte = item.ApareceCombo_FileReporte;
                    lst.Add(Info);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean GuardarDB(List<tb_sis_Documento_Tipo_x_Empresa_Info> lst)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();
                

                foreach (var Info in lst)
                { 
                    if(ValidarSiExiste(Info.codDocumentoTipo,Info.IdEmpresa))
                    {
                        var address = new tb_sis_Documento_Tipo_x_Empresa();
                        address.IdEmpresa = Info.IdEmpresa;
                        address.codDocumentoTipo = Info.codDocumentoTipo.Trim();
                        address.ApareceComboFac_TipoFact = Info.ApareceComboFac_TipoFact.Trim();
                        address.ApareceComboFac_Import = Info.ApareceComboFac_Import.Trim();
                        address.ApareceTalonario = Info.ApareceTalonario.Trim();
                        address.Descripcion = Info.Descripcion.Trim();
                        address.Posicion = Info.Posicion;
                        address.ApareceCombo_FileReporte = Info.ApareceCombo_FileReporte;

                        context.tb_sis_Documento_Tipo_x_Empresa.Add(address);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
   
        public Boolean ModificarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = context.tb_sis_Documento_Tipo_x_Empresa.FirstOrDefault(var => var.codDocumentoTipo == Info.codDocumentoTipo && var.IdEmpresa == Info.IdEmpresa);
                if (address != null)
                {
                    address.ApareceComboFac_Import = Info.ApareceComboFac_Import;
                    address.ApareceComboFac_TipoFact = Info.ApareceComboFac_TipoFact;
                    address.ApareceTalonario = Info.ApareceTalonario;
                    address.Descripcion = Info.Descripcion;
                    address.Posicion = Info.Posicion;
                    address.ApareceCombo_FileReporte = Info.ApareceCombo_FileReporte;
                    context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
     
        public Boolean GuardarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();
                var address = new tb_sis_Documento_Tipo_x_Empresa();
                address.IdEmpresa = Info.IdEmpresa;
                address.codDocumentoTipo = Info.codDocumentoTipo;
                address.ApareceComboFac_TipoFact = Info.ApareceComboFac_TipoFact;
                address.ApareceComboFac_Import = Info.ApareceComboFac_Import;
                address.ApareceTalonario = Info.ApareceTalonario;
                address.Descripcion = Info.Descripcion;
                address.Posicion = Info.Posicion;
                address.ApareceCombo_FileReporte = Info.ApareceCombo_FileReporte;
                context.tb_sis_Documento_Tipo_x_Empresa.Add(address);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
       
        public Boolean ValidarSiExiste(string codDocumentoTipo, int IdEmpresa)
        {
            bool ret = false;
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = from q in context.tb_sis_Documento_Tipo_x_Empresa
                              where q.codDocumentoTipo == codDocumentoTipo && q.IdEmpresa == IdEmpresa
                             select q;

                if (address.ToList().Count > 0)
                {
                    ret = false;
                }
                else
                {
                    ret = true;
                }

                return ret;                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        //CJimenez 22.01.14
        public Boolean EliminarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = context.tb_sis_Documento_Tipo_x_Empresa.FirstOrDefault(var => var.codDocumentoTipo == Info.codDocumentoTipo && var.IdEmpresa == Info.IdEmpresa);
                if (address != null)
                {
                    context.tb_sis_Documento_Tipo_x_Empresa.Remove(address);
                    context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        //CJimenez 22.01.14
        public Boolean EliminarDB(List<tb_sis_Documento_Tipo_x_Empresa_Info> lst)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();
                foreach (var item in lst)
                {
                    //var address = context.tb_sis_Documento_Tipo_x_Empresa.First(var => var.codDocumentoTipo == item.codDocumentoTipo && var.IdEmpresa == item.IdEmpresa);
                    var address = context.tb_sis_Documento_Tipo_x_Empresa.FirstOrDefault(var => var.IdEmpresa == item.IdEmpresa);
                    if (address != null)
                    {
                        context.tb_sis_Documento_Tipo_x_Empresa.Remove(address);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
