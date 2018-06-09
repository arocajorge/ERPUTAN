using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.ActivoFijo
{
  public   class Af_Encargado_Data
    {
        string mensaje = "";

        public List<Af_Encargado_Info> Get_List_Encargado(int IdEmpresa)
        {
            List<Af_Encargado_Info> lM = new List<Af_Encargado_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Encargado
                             where A.IdEmpresa == IdEmpresa
                             select A;

                foreach (var item in select)
                {
                    Af_Encargado_Info info = new Af_Encargado_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.estado = item.estado;
                    info.IdEncargado = item.IdEncargado;
                    info.nom_encargado = item.nom_encargado;
                    
                   

                    lM.Add(info);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(Af_Encargado_Info info, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Encargado.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdEncargado == info.IdEncargado);
                    if (contact != null)
                    {
                        contact.estado = info.estado;
                        contact.nom_encargado = info.nom_encargado;
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Tipo de Activo Fijo #: " + info.IdEncargado.ToString() + " exitosamente";
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

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId(int idempresa)
        {
            try
            {
                int Id;
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Encargado
                             where q.IdEmpresa == idempresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    EntitiesActivoFijo OEPActivoFijoTipo = new EntitiesActivoFijo();
                    var select_pv = (from q in OEPActivoFijoTipo.Af_Encargado
                                     where q.IdEmpresa == idempresa
                                     select q.IdEncargado).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
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
                mensaje = ex.InnerException + " " + ex.Message;

                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean GrabarDB(Af_Encargado_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {

                    var address = new Af_Encargado();

                    int idpv = GetId(info.IdEmpresa);
                    id = idpv;

                    address.IdEmpresa = info.IdEmpresa;
                    address.IdEncargado = idpv;
                    address.estado = info.estado;
                    address.nom_encargado = info.nom_encargado;

                    context.Af_Encargado.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del Tipo de Af_Encargado_Info #: " + id.ToString() + " exitosamente.";
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

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(Af_Encargado_Info info, ref  string msg)
        {
            try
            {
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Encargado
                             where q.IdEmpresa == info.IdEmpresa && q.IdEncargado == info.IdEncargado
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                    {
                        var contact = context.Af_Encargado.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdEncargado == info.IdEncargado);
                        if (contact != null)
                        {
                            contact.estado = "I";
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro del Tipo de Activo Fijo #: " + info.IdEncargado.ToString() + " exitosamente";
                        }
                    }
                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Tipo de Activo Fijo #: " + info.IdEncargado.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
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

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
