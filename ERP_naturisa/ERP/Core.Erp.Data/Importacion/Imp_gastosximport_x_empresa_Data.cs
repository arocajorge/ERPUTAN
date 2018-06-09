using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_gastosximport_x_empresa_Data
    {
        string mensaje="";
        public List<imp_gastosximport_x_empresa_Info> Get_List_gastosximport_x_empresa(int IdEmpresa) 
        {
                List<imp_gastosximport_x_empresa_Info> lst = new List<imp_gastosximport_x_empresa_Info>();
                EntitiesImportacion IMP = new EntitiesImportacion();
            try
            {
                var Consulta = from q in IMP.imp_gastosxImport_x_Empresa
                               where q.IdEmpresa == IdEmpresa
                               select q;

                foreach (var item in Consulta)
                {
                    imp_gastosximport_x_empresa_Info obj = new imp_gastosximport_x_empresa_Info();
                    obj.IdEmpresa = item.IdEmpresa;
                    obj.IdGastoImp = item.IdGastoImp;
                    obj.IdCtaCble = item.IdCtaCble;
                    obj.debcre_DebBanco = item.debcre_DebBanco;
                    obj.debCre_Provicion = item.debCre_Provicion;

                    lst.Add(obj);
                    
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

        public List<imp_gastosximport_x_empresa_Info> Get_List_gastosximport_x_empresa() 
        {
                List<imp_gastosximport_x_empresa_Info> lst = new List<imp_gastosximport_x_empresa_Info>();
                EntitiesImportacion IMP = new EntitiesImportacion();
            try
            {
                var Consulta = from q in IMP.vwimp_gastosxImport_x_Empresa_x_CtaCble
                                                   select q;

                foreach (var item in Consulta)
                {
                    imp_gastosximport_x_empresa_Info obj = new imp_gastosximport_x_empresa_Info();
                    obj.IdEmpresa = item.IdEmpresa;
                    obj.IdGastoImp = item.IdGastoImp;
                    obj.IdCtaCble = item.IdCtaCble;
                    obj.debcre_DebBanco = item.debcre_DebBanco;
                    obj.debCre_Provicion = item.debCre_Provicion;
                    obj.AfectaLiquidacion = item.AfectaLiquidacion;

                    lst.Add(obj);
                    
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

        public Boolean ModificarDB(List<imp_gastosximport_x_empresa_Info> lst)
        {
            try
            {
                foreach (var item in lst)
                {
                    using (EntitiesImportacion Context = new EntitiesImportacion()) 
                    {
                        var contact = Context.imp_gastosxImport_x_Empresa.FirstOrDefault(var => var.IdEmpresa == item.IdEmpresa && var.IdGastoImp == item.IdGastoImp);
                        if (contact != null)
                        {
                            contact.IdCtaCble = item.IdCtaCble;
                            contact.debcre_DebBanco = item.debcre_DebBanco;
                            contact.debCre_Provicion = item.debCre_Provicion;
                            contact.AfectaLiquidacion = item.AfectaLiquidacion;
                            Context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(imp_gastosximport_x_empresa_Info Info) 
        {
            try
            {
                using (EntitiesImportacion Context = new EntitiesImportacion()) 
                {
                    var Address = new imp_gastosxImport_x_Empresa();

                    Address.debcre_DebBanco = Info.debcre_DebBanco;
                    Address.debCre_Provicion = Info.debCre_Provicion;
                    Address.IdGastoImp = Info.IdGastoImp;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdCtaCble = Info.IdCtaCble;
                    Address.AfectaLiquidacion = Info.AfectaLiquidacion;
                    Context.imp_gastosxImport_x_Empresa.Add(Address);
                    Context.SaveChanges();
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
