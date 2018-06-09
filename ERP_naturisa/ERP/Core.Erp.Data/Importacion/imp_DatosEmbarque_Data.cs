using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Importacion
{
    public class imp_DatosEmbarque_Data
    {
        string mensaje = "";
        public Boolean GuardarDB( List<imp_DatosEmbarque_Info> Lstinfo) 
        {

            try
            {
                int c = 1;
                foreach (var item in Lstinfo)
                {
                    using (EntitiesImportacion Contex = new EntitiesImportacion()) 
                    {
                        var address = new imp_DatosEmbarque();
                        
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdOrdenCompraExt = item.IdOrdenCompraExt;
                        address.IdSucursal = item.IdSucursal;
                        address.cp_secuencia = c;
                        c++;
                        address.cp_cantidad = item.cp_cantidad;
                        address.cp_Kiligramo = item.cp_Kiligramo;
                        address.cp_MCubicos = item.cp_MCubicos;
                        address.cp_TipoConten = item.cp_TipoConten;
                        address.cp_TipoEmbarque = item.cp_TipoEmbarque;
                        address.cp_ValorFlete = item.cp_ValorFlete;
                        Contex.imp_DatosEmbarque.Add(address);
                        Contex.SaveChanges();
                        Contex.Dispose();
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

        public List<imp_DatosEmbarque_Info> Get_List_DatosEmbarque(imp_ordencompra_ext_Info info) 
        {
                List<imp_DatosEmbarque_Info>   lst = new List<imp_DatosEmbarque_Info>();
                EntitiesImportacion Enti = new EntitiesImportacion();
            try
            {
                decimal idOrdenComprExt = (decimal)info.IdOrdenCompraExt;
                var select = from q in Enti.imp_DatosEmbarque
                             where q.IdEmpresa == info.IdEmpresa && q.IdOrdenCompraExt == idOrdenComprExt
                             && q.IdSucursal == info.IdSucusal
                             select q;


                foreach (var item in select)
                {
                    imp_DatosEmbarque_Info _InfoDEmbarque = new imp_DatosEmbarque_Info();
                    _InfoDEmbarque.IdEmpresa = item.IdEmpresa;
                    _InfoDEmbarque.IdSucursal = item.IdSucursal;
                    _InfoDEmbarque.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    _InfoDEmbarque.cp_secuencia = item.cp_secuencia;
                    _InfoDEmbarque.cp_TipoEmbarque = item.cp_TipoEmbarque;
                    _InfoDEmbarque.cp_TipoConten = item.cp_TipoConten;
                    _InfoDEmbarque.cp_cantidad = (Double)item.cp_cantidad;
                    _InfoDEmbarque.cp_Kiligramo = (Double)item.cp_Kiligramo;
                    _InfoDEmbarque.cp_MCubicos = (Double)item.cp_MCubicos;
                    _InfoDEmbarque.cp_ValorFlete = (Double)item.cp_ValorFlete;

                    lst.Add(_InfoDEmbarque);            
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

        public Boolean EliminarDB(imp_ordencompra_ext_Info Info) 
        {
            try
            {
                List<imp_DatosEmbarque_Info> ListaEliminar = new List<imp_DatosEmbarque_Info>();
                ListaEliminar = Get_List_DatosEmbarque(Info);

                foreach (var item in ListaEliminar)
                {

                    using (EntitiesImportacion context = new EntitiesImportacion())
                    {
                        var contact = context.imp_DatosEmbarque.FirstOrDefault(obj => obj.IdEmpresa == item.IdEmpresa && obj.IdSucursal == item.IdSucursal && obj.IdOrdenCompraExt == item.IdOrdenCompraExt && obj.cp_secuencia == item.cp_secuencia);
                        if (contact != null)
                        {
                            context.imp_DatosEmbarque.Remove(contact);
                            context.SaveChanges();
                            context.Dispose();
                        }
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
