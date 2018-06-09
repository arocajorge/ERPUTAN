/*CLASE: tb_Banco_Data
 *MODIFICADO POR: Pedro Salinas
 *FECHA: 19-02-2016
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_Banco_Data
    {
        string mensaje = "";

        public List<tb_banco_Info> Get_List_Banco() 
        {
            try
            {
                List<tb_banco_Info> lst = new List<tb_banco_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_banco
                             select q;
                foreach (var item in bancos)
                {
                    tb_banco_Info info = new tb_banco_Info();

                    info.IdBanco = item.IdBanco;
                    info.ba_descripcion = item.ba_descripcion;
                    info.Estado = item.Estado;
                    info.CodigoLegal = item.CodigoLegal;
                    info.TieneFormatoTransferencia = item.TieneFormatoTransferencia;
                    lst.Add(info);   
                }
                return lst;
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

        public int getId()
        {
            int Id = 0;
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = from q in context.tb_banco
                                  select q;

                    if (contact.ToList().Count < 1)
                    {
                        Id = 1;
                    }
                    else
                    {
                        var contact1 = (from q in context.tb_banco
                                        select q.IdBanco).Max();
                        Id = Convert.ToInt32(contact1.ToString()) + 1;
                    }
                }
                return Id;
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

        public Boolean GrabarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_banco();
                    address.IdBanco = Info.IdBanco = getId();
                    address.ba_descripcion = Info.ba_descripcion;
                    address.Estado = Info.Estado;
                    address.CodigoLegal = Info.CodigoLegal;
                    address.TieneFormatoTransferencia = Convert.ToBoolean(Info.TieneFormatoTransferencia);
                    context.tb_banco.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido grabar el Banco #: " + address.IdBanco.ToString() + " exitosamente.";
                    resultado = true;
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

        public Boolean ActualizarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                bool resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_banco.FirstOrDefault(v => v.IdBanco == Info.IdBanco);
                    if (address != null)
                    {
                        address.ba_descripcion = Info.ba_descripcion;
                        address.Estado = Info.Estado;
                        address.CodigoLegal = Info.CodigoLegal;
                        address.TieneFormatoTransferencia = Convert.ToBoolean(Info.TieneFormatoTransferencia);
                        context.SaveChanges();
                        msg = "Se ha modificado el Banco #: " + address.IdBanco.ToString() + " exitosamente.";
                        resultado = true;
                    }
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

        public Boolean AnulaDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_banco.FirstOrDefault(q => q.IdBanco == Info.IdBanco);
                    if (address != null)
                    {
                        address.Estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el Banco #: " + Info.IdBanco.ToString() + " exitosamente.";
                        resultado = true;
                    }
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
    }
}
