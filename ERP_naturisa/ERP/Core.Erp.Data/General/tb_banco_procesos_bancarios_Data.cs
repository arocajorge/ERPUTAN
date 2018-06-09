using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.Academico;

namespace Core.Erp.Data.General
{
    public class tb_banco_procesos_bancarios_Data
    {
        string mensaje = "";

        public int getId(int IdBanco)
        {
            int Id = 0;
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    //var contact = from q in context.tb_banco_procesos_bancarios
                    //              where q.IdBanco==IdBanco
                    //              select q;

                    //if (contact.ToList().Count < 1)
                    //{
                    //    Id = 1;
                    //}
                    //else
                    //{
                    //    var contact1 = (from q in context.tb_banco_procesos_bancarios
                    //                    where q.IdBanco == IdBanco
                    //                    select q.IdProceso_bancario).Max();
                    //    Id = Convert.ToInt32(contact1.ToString()) + 1;
                    //}
                }
                return Id;
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
        
        public List<tb_banco_procesos_bancarios_Info> Get_List()
        {
            try
            {
                List<tb_banco_procesos_bancarios_Info> lista = new List<tb_banco_procesos_bancarios_Info>();

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = from c in context.tb_banco_procesos_bancarios
                                  select c;

                    foreach (var item in contact)
                    {
                        tb_banco_procesos_bancarios_Info Info = new tb_banco_procesos_bancarios_Info();
                        //Info.IdBanco = item.IdBanco;
                        //Info.IdProceso_bancario = item.IdProceso_bancario;
                        //Info.cod_banco = item.cod_banco;
                        //Info.nom_proceso_bancario = item.nom_proceso_bancario;
                        //Info.estado = item.estado;
                        //Info.EstaEnBase = true;
                        //Info.Nombre_Archivo = item.Nombre_Archivo;
                        lista.Add(Info);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_banco_procesos_bancarios_Info> Get_List(int IdBanco)
        {
            try
            {
                List<tb_banco_procesos_bancarios_Info> lista = new List<tb_banco_procesos_bancarios_Info>();

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = from c in context.vwtb_tb_banco_procesos_bancarios
                                  where c.IdBanco==IdBanco
                                  select c;

                    foreach (var item in contact)
                    {
                        tb_banco_procesos_bancarios_Info Info = new tb_banco_procesos_bancarios_Info();
                        Info.IdBanco = item.IdBanco;
                        Info.IdProceso_bancario = item.IdProceso_bancario;
                        Info.cod_banco = item.cod_banco;
                        Info.nom_proceso_bancario = item.nom_proceso_bancario;
                        Info.EstaEnBase = true;
                        Info.Nombre_Archivo = item.Iniciales_Archivo;
                        Info.Codigo_Empresa = item.Codigo_Empresa;
                        lista.Add(Info);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(tb_banco_procesos_bancarios_Info Info, int IdBanco, ref string Mensaje)
        {
            try
            {
                bool resultado = false;

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = new tb_banco_procesos_bancarios();

                    //contact.IdBanco = IdBanco;
                    //contact.IdProceso_bancario = Info.IdProceso_bancario;
                    //contact.cod_banco = (Info.cod_banco == "") ? Info.IdProceso_bancario : Info.cod_banco;
                    //contact.nom_proceso_bancario = Info.nom_proceso_bancario;
                    //contact.estado = Info.estado;
                    //context.tb_banco_procesos_bancarios.Add(contact);
                    //context.SaveChanges();
                    //Mensaje = "Se ha procedido a grabar el registro exitosamente";
                    //resultado = true;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<tb_banco_procesos_bancarios_Info> Lista_Info, int IdBanco, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                foreach (var item in Lista_Info)
                {
                    resultado = GrabarDB(item, IdBanco, ref mensaje);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<tb_banco_procesos_bancarios_Info> Lista_Info, int IdBanco, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                foreach (var item in Lista_Info)
                {
                    resultado = ModificarDB(item, IdBanco, ref mensaje);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_banco_procesos_bancarios_Info Info, int IdBanco, ref string msg)
        {
            try
            {
                bool resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                //    var address = context.tb_banco_procesos_bancarios.FirstOrDefault(v => v.IdBanco == Info.IdBanco && v.IdProceso_bancario==Info.IdProceso_bancario);
                //    if (address != null)
                //    {
                //        //address.nom_proceso_bancario = Info.nom_proceso_bancario;
                //        //address.estado = Info.estado;
                //        //address.cod_banco = Info.cod_banco;
                //        //context.SaveChanges();
                //        //msg = "Se ha modificado el Banco #: " + address.IdBanco.ToString() + " exitosamente.";
                //        //resultado = true;
                //    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdBanco, ref string mensaje)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var Consulta = context.Database.ExecuteSqlCommand("delete from tb_banco_procesos_bancarios where IdBanco= " + IdBanco + "");
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
