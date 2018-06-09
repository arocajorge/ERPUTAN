using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Roles
{
    public class ro_contrato_data
    {
        string mensaje = "";
        List<ro_contrato_Info> lista = new List<ro_contrato_Info>();

        public Boolean GrabarDB(ro_contrato_Info ro_info, ref string mensaje)
        {
            try
            {
               int idContrato;
                using (EntitiesRoles context = new EntitiesRoles())
                { 
                    
                    EntitiesRoles EDB = new EntitiesRoles();

                    idContrato = getIdContrato(ro_info.IdEmpresa);

                    ro_info.IdContrato = idContrato;

                    var Q = from per in EDB.ro_contrato
                            where per.IdContrato == ro_info.IdContrato && per.IdEmpresa == ro_info.IdEmpresa
                            select per;

                    if (Q.ToList().Count == 0)
                    {

                    var address = new ro_contrato();

                    address.IdContrato = getIdContrato(ro_info.IdEmpresa);
                    if (ro_info.NumDocumento == null || ro_info.NumDocumento=="")
                    {
                        address.NumDocumento = address.IdContrato.ToString();
                    }
                    else
                    {
                        address.NumDocumento = ro_info.NumDocumento;
                    }
                    address.IdEmpleado = ro_info.IdEmpleado;
                    address.IdContrato_Tipo = ro_info.IdContrato_Tipo;
                    address.FechaInicio = ro_info.FechaInicio;
                    address.FechaFin = ro_info.FechaFin;
                    address.Observacion = ro_info.Observacion;
                    address.MotiAnula = ro_info.MotiAnula;
                    address.Estado = ro_info.Estado;
                    address.IdEmpresa = ro_info.IdEmpresa;
                    address.EstadoContrato = ro_info.EstadoContrato;

                    context.ro_contrato.Add(address);
                    context.SaveChanges();

                    if (ActualizarContrato(ro_info) == false)
                    {
                        mensaje = "Problemas al actualizar el contrato en el empleado..";
                        return false;
                    }

                    mensaje = "Se ha procedido a grabar la información exitosamente..";

                    }
                    else
                        return false;
               }
                return true;
            } 
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(ro_contrato_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_contrato.First(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdContrato == prI.IdContrato);

                    contact.IdContrato = prI.IdContrato;
                    contact.NumDocumento = prI.NumDocumento;
                    contact.IdContrato_Tipo = prI.IdContrato_Tipo;
                    contact.IdEmpleado = prI.IdEmpleado;
                    contact.FechaInicio = prI.FechaInicio;
                    contact.FechaFin = prI.FechaFin;
                    contact.Estado = prI.Estado;
                    contact.IdEmpresa = prI.IdEmpresa;
                    contact.Observacion = prI.Observacion;
                    contact.EstadoContrato = prI.EstadoContrato;

                    context.SaveChanges();

                    mensaje = "Se ha procedido a actualizar los datos exitosamente...";
                }
               return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(ro_contrato_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_contrato.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdContrato == info.IdContrato);
                    contact.Estado = "I";
                    contact.MotiAnula = info.MotiAnula;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int getIdContrato(int idempresa)
        {

            try
            {

                int Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();



                var q = from C in OECbtecble.ro_contrato
                        where C.IdEmpresa == idempresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in OECbtecble.ro_contrato
                                   where t.IdEmpresa == idempresa
                                   select t.IdContrato).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_contrato_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                EntitiesRoles ORol = new EntitiesRoles();
                lista = new List<ro_contrato_Info>();

                var sresult = from A in ORol.vwRo_Contrato
                              where A.IdEmpresa == IdEmpresa
                              orderby A.IdContrato, A.IdEmpleado
                              select A;

                foreach (var item in sresult)
                {
                    ro_contrato_Info Reg = new ro_contrato_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdContrato = item.IdContrato;
                    Reg.IdContrato_Tipo = item.IdContrato_Tipo;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.NumDocumento = item.NumDocumento;
                    Reg.FechaInicio = item.FechaInicio;
                    Reg.FechaFin = item.FechaFin;
                    Reg.Estado = item.Estado;
                    Reg.Observacion = item.Observacion;
                    Reg.MotiAnula = item.MotiAnula;
                    Reg.NomCatalogo = item.ca_descripcion;
                    Reg.pe_nombreCompleto = item.pe_nombreCompleto;
                    Reg.EstadoContrato = item.EstadoContrato;
                    Reg.MotiAnula = item.MotiAnula;
                    Reg.Nombres = item.pe_nombre;
                    Reg.Apellidos = item.pe_apellido;
                    Reg.Codigo = item.em_codigo;
                    Reg.Cedula = item.pe_cedulaRuc;
                    if (item.EstadoContrato == "ECT_ACT")
                    {
                        Reg.Estado_Contrato = "Contrato Actual";
                    }
                    else
                    {
                        Reg.Estado_Contrato = "Contrato Liquidado";
                    }
                    lista.Add(Reg);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_contrato_Info> GetListPorEmpleado(int IdEmpresa, decimal IdEmpleado)
        {

            try
            {
                lista = new List<ro_contrato_Info>();
                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwRo_Contrato
                              where A.IdEmpresa == IdEmpresa
                              &&   A.IdEmpleado == IdEmpleado
                              select A;

                foreach (var item in sresult)
                {
                    ro_contrato_Info Reg = new ro_contrato_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdContrato = item.IdContrato;
                    Reg.IdContrato_Tipo = item.IdContrato_Tipo;
                    Reg.ca_descripcion = item.ca_descripcion;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.NumDocumento = item.NumDocumento;
                    Reg.FechaInicio = item.FechaInicio;
                    Reg.FechaFin = item.FechaFin;
                    Reg.Estado = item.Estado;
                    Reg.Observacion = item.Observacion;
                    Reg.EstadoContrato = item.EstadoContrato;

                    lista.Add(Reg);

                }

                return lista;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        //Get_SiExisteContratoActivo




        public bool Get_SiExisteContratoActivo(int IdEmpresa, decimal IdEmpleado)
        {

            try
            {
               
                lista = new List<ro_contrato_Info>();
                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwRo_Contrato
                              where A.IdEmpresa == IdEmpresa
                              && A.IdEmpleado == IdEmpleado
                              && A.EstadoContrato == "ECT_ACT"
                              select A;
                if (sresult.Count() >0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ActualizarContrato(ro_contrato_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdEmpleado == info.IdEmpleado);

                    if (contact.IdEmpleado != null)
                    {
                        contact.em_fechaTerminoContra = info.FechaFin;

                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_contrato_data(){}


        public Boolean CambiarEstadoContrado(int idempresa,int idempleado, int idcontrato)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_contrato.First(VCont => VCont.IdEmpresa == idempresa && VCont.IdContrato == idcontrato && VCont.IdEmpleado == idempleado);

                    contact.FechaFin = DateTime.Now;
                    contact.Estado = "I";
                    contact.EstadoContrato = "ECT_LIQ";

                    context.SaveChanges();

                    mensaje = "Se ha procedido a actualizar los datos exitosamente...";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
