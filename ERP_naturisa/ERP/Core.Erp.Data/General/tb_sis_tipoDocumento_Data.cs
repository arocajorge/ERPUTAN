using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_sis_tipoDocumento_Data
    {
        string mensaje = "";
        public List<tb_sis_tipoDocumento_Info> Get_List_sis_tipoDocumento()
        {
            try
            {
                List<tb_sis_tipoDocumento_Info> lm = new List<tb_sis_tipoDocumento_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var q = from A in OEGeneral.tb_sis_Documento_Tipo
                        orderby A.Posicion
                        select A;
                foreach (var item in q)
                {
                    tb_sis_tipoDocumento_Info info = new tb_sis_tipoDocumento_Info();
                    info.IdTipoDocumento = item.codDocumentoTipo.Trim();
                    info.Descripcion = item.descripcion.Trim();
                    info.Estado = item.estado;
                    info.Posicion=Convert.ToInt32(item.Posicion);
                    lm.Add(info);
                }
                return lm;
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


        public List<tb_sis_tipoDocumento_Info> Get_List_sis_tipoDocumento(int IdEmpresa)
        {
            try
            {
                List<tb_sis_tipoDocumento_Info> lst = new List<tb_sis_tipoDocumento_Info>();
                EntitiesGeneral context = new EntitiesGeneral();
                tb_sis_Documento_Tipo_x_Empresa_Data TipoDocEmpresaData = new tb_sis_Documento_Tipo_x_Empresa_Data();

                var q = from A in context.tb_sis_Documento_Tipo
                        orderby A.Posicion
                        select A;
                foreach (var item in q)
                {

                    tb_sis_tipoDocumento_Info info = new tb_sis_tipoDocumento_Info();
                    if (TipoDocEmpresaData.ValidarSiExiste(item.codDocumentoTipo,IdEmpresa))
                    {
                        info.IdTipoDocumento = item.codDocumentoTipo.Trim();
                        info.Descripcion = item.descripcion.Trim();
                        info.Estado = item.estado;
                        info.Posicion = Convert.ToInt32(item.Posicion);
                        lst.Add(info);
                    }
                    
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

        public Boolean GuardarDB(tb_sis_tipoDocumento_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = new tb_sis_Documento_Tipo();

                address.codDocumentoTipo = Info.IdTipoDocumento;
                address.descripcion = Info.Descripcion;
                address.estado = Info.Estado;
                address.Posicion = Info.Posicion;

                context.tb_sis_Documento_Tipo.Add(address);
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

        public Boolean ModificarDB(tb_sis_tipoDocumento_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = context.tb_sis_Documento_Tipo.FirstOrDefault(var => var.codDocumentoTipo == Info.IdTipoDocumento);
                if (address != null)
                {
                    address.descripcion = Info.Descripcion;
                    address.estado = Info.Estado;
                    address.Posicion = Info.Posicion;
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

        public tb_sis_tipoDocumento_Data() { }
    }
}
