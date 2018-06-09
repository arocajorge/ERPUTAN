using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Activo_fijo_tipo_Data
    {
        string mensaje = "";

        public List<Af_Activo_fijo_tipo_Info> Get_List_ActivoFijoTipo(int idempresa)
        {
                List<Af_Activo_fijo_tipo_Info> lM = new List<Af_Activo_fijo_tipo_Info>();
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo_tipo
                                where A.IdEmpresa == idempresa
                                select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_tipo_Info info = new Af_Activo_fijo_tipo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijoTipo = item.IdActijoFijoTipo;
                    info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;
                    info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    info.CodActivoFijo = item.CodActivoFijo.Trim();
                    info.Af_Descripcion = item.Af_Descripcion.Trim();
                    info.Af_Descripcion2 = "[" + item.IdActijoFijoTipo +"]-"+ item.Af_Descripcion;
                    info.Af_Porcentaje_depre = item.Af_Porcentaje_depre;
                    info.Af_anio_depreciacion = item.Af_anio_depreciacion;
                    info.Estado = item.Estado;
                    if (item.Se_Deprecia == null)
                    info.Se_Deprecia = false;
                    else
                    info.Se_Deprecia = item.Se_Deprecia;
                    info.IdCentroCosto_Activo = item.IdCentroCosto_Activo;
                    info.IdCentroCosto_Dep_Acum = item.IdCentroCosto_Dep_Acum;
                    info.IdCentroCosto_Gasto_Depre = item.IdCentroCosto_Gasto_Depre;


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

        public Boolean ModificarDB(Af_Activo_fijo_tipo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo_tipo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdActijoFijoTipo == info.IdActivoFijoTipo);
                    if (contact != null)
                    {
                        contact.CodActivoFijo = info.CodActivoFijo;
                        contact.Af_Descripcion = info.Af_Descripcion;
                        contact.IdCtaCble_Activo = info.IdCtaCble_Activo;
                        contact.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;
                        contact.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                        contact.Af_Porcentaje_depre = info.Af_Porcentaje_depre;
                        contact.Af_anio_depreciacion = info.Af_anio_depreciacion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.ip = info.ip;
                        contact.Estado = info.Estado;
                        contact.Se_Deprecia = info.Se_Deprecia;

                        contact.IdCentroCosto_Activo = info.IdCentroCosto_Activo;
                        contact.IdCentroCosto_Dep_Acum = info.IdCentroCosto_Dep_Acum;
                        contact.IdCentroCosto_Gasto_Depre = info.IdCentroCosto_Gasto_Depre;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Tipo de Activo Fijo #: " + info.IdActivoFijoTipo.ToString() + " exitosamente";
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

        public int getId(int idempresa)
        {
            try
            {
                int Id;
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Activo_fijo_tipo
                             where q.IdEmpresa == idempresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    EntitiesActivoFijo OEPActivoFijoTipo = new EntitiesActivoFijo();
                    var select_pv = (from q in OEPActivoFijoTipo.Af_Activo_fijo_tipo
                                     where q.IdEmpresa == idempresa
                                     select q.IdActijoFijoTipo).Max();
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

        public Boolean GrabarDB(Af_Activo_fijo_tipo_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var address = new Af_Activo_fijo_tipo();
                    int idpv = getId(info.IdEmpresa);
                    id = idpv;
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdActijoFijoTipo = idpv;
                    address.IdCtaCble_Activo = info.IdCtaCble_Activo;
                    address.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;
                    address.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                    address.CodActivoFijo = (info.CodActivoFijo == "" || info.CodActivoFijo == null) ? "TAF" + idpv : info.CodActivoFijo;
                    address.Af_Descripcion = info.Af_Descripcion;
                    address.Af_Porcentaje_depre = info.Af_Porcentaje_depre;
                    address.Af_anio_depreciacion = info.Af_anio_depreciacion;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Estado = "A";
                    address.IdCentroCosto_Activo = info.IdCentroCosto_Activo;
                    address.IdCentroCosto_Dep_Acum = info.IdCentroCosto_Dep_Acum;
                    address.IdCentroCosto_Gasto_Depre = info.IdCentroCosto_Gasto_Depre;
                    address.Se_Deprecia = info.Se_Deprecia;
                    //contact = address;
                    context.Af_Activo_fijo_tipo.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del Tipo de Activo Fijo #: " + id.ToString() + " exitosamente.";
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

        public Boolean AnularDB(Af_Activo_fijo_tipo_Info info, ref  string msg)
        {
            try
            {
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Activo_fijo_tipo
                             where q.IdEmpresa == info.IdEmpresa && q.IdActijoFijoTipo==info.IdActivoFijoTipo 
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                    {
                        var contact = context.Af_Activo_fijo_tipo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdActijoFijoTipo == info.IdActivoFijoTipo);//e && obj.IdActivoFijo == info.IdActivoFijoTipo);
                        if (contact != null)
                        {
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = DateTime.Now;
                            contact.MotiAnula = info.MotiAnula;
                            //contact.nom_pc = info.nom_pc;
                            //contact.ip = info.ip;
                            contact.Estado = "I";
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro del Tipo de Activo Fijo #: " + info.IdActivoFijoTipo.ToString() + " exitosamente";
                        }
                    }
                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Tipo de Activo Fijo #: " + info.IdActivoFijoTipo.ToString() + " debido a que ya se encuentra anulado.";
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
