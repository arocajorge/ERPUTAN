
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Acta_Finiquito_Data
    {

        string mensaje = "";

        public List<ro_Acta_Finiquito_Info> GetListConsultaGeneral(int idEmpresa)
        {
            List<ro_Acta_Finiquito_Info> listado = new List<ro_Acta_Finiquito_Info>();

            try
            {
                EntitiesRoles db = new EntitiesRoles();
                var datos = (from a in db.vwRo_ActaFiniquito
                            where a.IdEmpresa == idEmpresa
                            select a);

                foreach (var item in datos)
                {
                    ro_Acta_Finiquito_Info info = new ro_Acta_Finiquito_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActaFiniquito = item.IdActaFiniquito;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdCausaTerminacion = item.IdCausaTerminacion;
                    info.IdContrato = item.IdContrato;
                    info.IdCargo = item.IdCargo;
                    info.FechaIngreso = item.FechaIngreso;
                    info.FechaSalida = item.FechaSalida;
                    info.UltimaRemuneracion = item.UltimaRemuneracion;
                    info.Observacion = item.ObservacionFiniquito;
                    info.Ingresos = item.Ingresos;
                    info.Egresos = item.Egresos;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod = item.Fecha_UltMod;
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu = item.Fecha_UltAnu;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.Estado = item.EstadoActa;
                    info.MotiAnula = item.MotiAnula;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.EsMujerEmbarazada = item.EsMujerEmbarazada;
                    info.EsDirigenteSindical = item.EsDirigenteSindical;
                    info.EsPorDiscapacidad = item.EsPorDiscapacidad;
                    info.EsPorEnfermedadNoProfesional = item.EsPorEnfermedadNoProfesional;


                    info.NombreCompleto = item.NombreCompleto;
                    info.Identificacion = item.Identificacion;
                    info.TipoIdentificacion = item.TipoIdentificacion;
                    info.FechaNcto = item.FechaNcto;
                    info.Cargo = item.Cargo;
                    info.Departamento = item.Departamento;
                    info.IdContrato_Tipo = item.IdContrato_Tipo;
                    info.NumDocumento = item.NumDocumento;
                    info.FechaInicio = item.FechaInicio;
                    info.FechaFin = item.FechaFin;
                    info.EstadoContrato = item.EstadoContrato;
                    info.ObservacionContrato = item.ObservacionContrato;
                    info.Apellidos = item.pe_apellido;
                    info.Nombres = item.pe_nombre;
                    info.Cedula = item.Identificacion;
                    info.Codigo = item.em_codigo;


                    listado.Add(info);
                }
                return listado;
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


        public ro_Acta_Finiquito_Info GetInfoConsultaPorId(int idEmpresa, decimal idActaFiniquito)
        {
            ro_Acta_Finiquito_Info info = new ro_Acta_Finiquito_Info();

            try
            {
                EntitiesRoles db = new EntitiesRoles();
                var item = (from a in db.ro_Acta_Finiquito
                             where a.IdEmpresa == idEmpresa
                             && a.IdActaFiniquito == idActaFiniquito
                             select a).FirstOrDefault();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActaFiniquito = item.IdActaFiniquito;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdCausaTerminacion = item.IdCausaTerminacion;
                    info.IdContrato = item.IdContrato;
                    info.IdCargo = item.IdCargo;
                    info.FechaIngreso = item.FechaIngreso;
                    info.FechaSalida = item.FechaSalida;
                    info.UltimaRemuneracion = item.UltimaRemuneracion;
                    info.Observacion = item.Observacion;
                    info.Ingresos = item.Ingresos;
                    info.Egresos = item.Egresos;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac =Convert.ToDateTime( item.Fecha_Transac);
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod = item.Fecha_UltMod;
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu = item.Fecha_UltAnu;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.Estado = item.Estado;
                    info.MotiAnula = item.MotiAnula;

                    info.EsMujerEmbarazada = item.EsMujerEmbarazada;
                    info.EsDirigenteSindical = item.EsDirigenteSindical;
                    info.EsPorDiscapacidad = item.EsPorDiscapacidad;
                    info.EsPorEnfermedadNoProfesional = item.EsPorEnfermedadNoProfesional;

                return info;
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

        public decimal getId(int IdEmpresa, decimal idEmpleado)
        {
            decimal Id = 0;
            try
            {

                EntitiesRoles db = new EntitiesRoles();
                var selecte = db.ro_Acta_Finiquito.Count(q => q.IdEmpresa == IdEmpresa && q.IdEmpleado==idEmpleado);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_Acta_Finiquito
                                     where q.IdEmpresa == IdEmpresa && q.IdEmpleado == idEmpleado
                                     select q.IdActaFiniquito).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
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

        public Boolean GetExiste(ro_Acta_Finiquito_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_Acta_Finiquito
                                where a.IdEmpresa == info.IdEmpresa && a.IdEmpleado == info.IdEmpleado && a.IdActaFiniquito==info.IdActaFiniquito
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
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

        
        public Boolean GrabarBD(ro_Acta_Finiquito_Info item, ref decimal id, ref string msg) { 
            try
            {

                using(EntitiesRoles db =new EntitiesRoles()){

                    ro_Acta_Finiquito info = new ro_Acta_Finiquito();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActaFiniquito = id = getId(item.IdEmpresa,item.IdEmpleado);
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdCausaTerminacion = item.IdCausaTerminacion;
                    info.IdContrato = item.IdContrato;
                    info.IdCargo = item.IdCargo;
                    info.FechaIngreso = item.FechaIngreso;
                    info.FechaSalida = item.FechaSalida;
                    info.UltimaRemuneracion = item.UltimaRemuneracion;
                    info.Observacion = item.Observacion;
                    info.Ingresos = item.Ingresos;
                    info.Egresos = item.Egresos;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.Estado = item.Estado;
                    info.MotiAnula = item.MotiAnula;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.EsMujerEmbarazada = item.EsMujerEmbarazada;
                    info.EsDirigenteSindical = item.EsDirigenteSindical;
                    info.EsPorDiscapacidad = item.EsPorDiscapacidad;
                    info.EsPorEnfermedadNoProfesional = item.EsPorEnfermedadNoProfesional;

                    db.ro_Acta_Finiquito.Add(info);
                    db.SaveChanges();
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
                msg = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        
        }
        public Boolean ModificarDB(ro_Acta_Finiquito_Info item, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var info = db.ro_Acta_Finiquito.First(v => v.IdEmpresa == item.IdEmpresa 
                        && v.IdActaFiniquito== item.IdActaFiniquito && v.IdEmpleado==item.IdEmpleado);

                    info.IdCausaTerminacion = item.IdCausaTerminacion;
                    info.IdContrato = item.IdContrato;
                    info.IdCargo = item.IdCargo;
                    info.FechaIngreso = item.FechaIngreso;
                    info.FechaSalida = item.FechaSalida;
                    info.UltimaRemuneracion = item.UltimaRemuneracion;
                    info.Observacion = item.Observacion;
                    info.Ingresos = item.Ingresos;
                    info.Egresos = item.Egresos;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod = item.Fecha_UltMod;
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu = item.Fecha_UltAnu;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.Estado = item.Estado;
                    info.MotiAnula = item.MotiAnula;
                    info.IdCodSectorial = item.IdCodSectorial;

                    info.EsMujerEmbarazada = item.EsMujerEmbarazada;
                    info.EsDirigenteSindical = item.EsDirigenteSindical;
                    info.EsPorDiscapacidad = item.EsPorDiscapacidad;
                    info.EsPorEnfermedadNoProfesional = item.EsPorEnfermedadNoProfesional;

                    db.SaveChanges();
                   
                    msg = "Se ha procedido actualizar el registro del Dpto # : " + info.IdActaFiniquito.ToString() + " exitosamente";
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
