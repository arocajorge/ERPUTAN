using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.General
{
    public class tb_banco_procesos_bancarios_x_empresa_Data
    {
        string mensaje = "";
        public List<tb_banco_procesos_bancarios_x_empresa_Info> Get_list_procesos_bancarios_x_empresa(int IdEmpresa)
        {
            try
            {
                List<tb_banco_procesos_bancarios_x_empresa_Info> Lista = new List<tb_banco_procesos_bancarios_x_empresa_Info>();

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.vwtb_tb_banco_procesos_bancarios
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        tb_banco_procesos_bancarios_x_empresa_Info info = new tb_banco_procesos_bancarios_x_empresa_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdProceso_bancario_tipo = item.IdProceso_bancario_tipo;
                        info.cod_Proceso = (ebanco_procesos_bancarios_tipo)Enum.Parse(typeof(ebanco_procesos_bancarios_tipo), item.IdProceso_bancario_tipo);
                        info.IdBanco = item.IdBanco;
                        info.cod_banco = item.cod_banco;
                        info.Codigo_Empresa = item.Codigo_Empresa;

                        info.Iniciales_Archivo = item.Iniciales_Archivo;
                        info.nom_proceso_bancario = item.nom_proceso_bancario;
                        info.Secuencial_detalle_inicial = item.Secuencial_detalle_inicial;
                        info.Tipo_Proc = item.Tipo_Proc;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }



        public List<tb_banco_procesos_bancarios_x_empresa_Info> Get_list_procesos_bancarios_x_empresa(int IdEmpresa,int IdBanco_financiero)
        {
            try
            {
                List<tb_banco_procesos_bancarios_x_empresa_Info> Lista = new List<tb_banco_procesos_bancarios_x_empresa_Info>();

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.vwtb_tb_banco_procesos_bancarios
                              where q.IdEmpresa == IdEmpresa
                              && q.IdBanco == IdBanco_financiero
                              select q;

                    foreach (var item in lst)
                    {
                        tb_banco_procesos_bancarios_x_empresa_Info info = new tb_banco_procesos_bancarios_x_empresa_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdProceso_bancario_tipo = item.IdProceso_bancario_tipo;
                        info.cod_Proceso = (ebanco_procesos_bancarios_tipo)Enum.Parse(typeof(ebanco_procesos_bancarios_tipo), item.IdProceso_bancario_tipo);

                        info.IdBanco = item.IdBanco;
                        info.cod_banco = item.cod_banco;
                        info.Codigo_Empresa = item.Codigo_Empresa;

                        info.Iniciales_Archivo = item.Iniciales_Archivo;
                        info.nom_proceso_bancario = item.nom_proceso_bancario;
                        info.Secuencial_detalle_inicial = item.Secuencial_detalle_inicial;
                        info.Se_contabiliza = item.Se_contabiliza;
                        info.IdTipoNota = item.IdTipoNota;
                        info.Tipo_Proc = item.Tipo_Proc;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_banco_procesos_bancarios_x_empresa_Info Get_info_proceso_bancario_x_empresa(int IdEmpresa, string IdProceso_bancario)
        {
            try
            {
                tb_banco_procesos_bancarios_x_empresa_Info info = new tb_banco_procesos_bancarios_x_empresa_Info();

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.vwtb_tb_banco_procesos_bancarios
                              where q.IdEmpresa == IdEmpresa
                              && q.IdProceso_bancario_tipo == IdProceso_bancario
                              select q;

                    foreach (var item in lst)
                    {                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdProceso_bancario_tipo = item.IdProceso_bancario_tipo;
                        info.cod_Proceso = (ebanco_procesos_bancarios_tipo)Enum.Parse(typeof(ebanco_procesos_bancarios_tipo), item.IdProceso_bancario_tipo);
                        info.IdBanco = item.IdBanco;
                        info.cod_banco = item.cod_banco;
                        info.Codigo_Empresa = item.Codigo_Empresa;

                        info.Iniciales_Archivo = item.Iniciales_Archivo;
                        info.nom_proceso_bancario = item.nom_proceso_bancario;
                        info.Secuencial_detalle_inicial = item.Secuencial_detalle_inicial;
                        info.Se_contabiliza = item.Se_contabiliza == null ? false : (bool)item.Se_contabiliza;
                        info.IdTipoNota = item.IdTipoNota;
                        info.Tipo_Proc = item.Tipo_Proc;
                    }
                }

                return info;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(tb_banco_procesos_bancarios_x_empresa_Info Info)
        {
            try
            {
                try
                {
                    using (EntitiesGeneral Context = new EntitiesGeneral())
                    {
                        tb_banco_procesos_bancarios_x_empresa Entity = new tb_banco_procesos_bancarios_x_empresa();

                        Entity.IdEmpresa = Info.IdEmpresa;
                        Entity.IdProceso_bancario_tipo = Info.IdProceso_bancario_tipo;
                        Entity.IdBanco = Info.IdBanco;
                        Entity.cod_banco = Info.cod_banco;
                        Entity.Codigo_Empresa = Info.Codigo_Empresa;
                        Entity.Secuencial_detalle_inicial = Info.Secuencial_detalle_inicial;
                        Entity.IdTipoNota = Info.IdTipoNota;
                        Entity.Se_contabiliza = Info.Se_contabiliza;

                        Context.tb_banco_procesos_bancarios_x_empresa.Add(Entity);
                        Context.SaveChanges();
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
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

        public bool GuardarDB(List<tb_banco_procesos_bancarios_x_empresa_Info> Lista)
        {
            try
            {
                try
                {
                    foreach (var item in Lista)
                    {
                        if (!GuardarDB(item))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
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

        public bool EliminarDB(int IdEmpresa, int IdBanco)
        {
            try
            {
                try
                {
                    string Comando = "DELETE tb_banco_procesos_bancarios_x_empresa WHERE IdEmpresa = "+IdEmpresa+" and IdBanco = "+IdBanco;
                    using(EntitiesGeneral Context = new EntitiesGeneral())
                    {
		                 Context.Database.ExecuteSqlCommand(Comando);
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
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
