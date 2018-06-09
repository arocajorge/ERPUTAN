using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
namespace Core.Erp.Data.Roles
{
 public   class ro_DiasFaltados_x_Empleado_Data
    {


        string mensaje = "";

        public int getId(int IdEmpresa,int IdEmpleado)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_DiasFaltados_x_Empleado
                             where q.IdEmpresa == IdEmpresa && q.IdEmpleado==IdEmpleado
                             select q;

                if (select.Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_DiasFaltados_x_Empleado
                                     where q.IdEmpresa == IdEmpresa && q.IdEmpleado==IdEmpleado
                                     select q.IdFalta).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
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

        public Boolean GuardarDB( ro_DiasFaltados_x_Empleado_Info Info)
        {
            try
            {
               
                
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_DiasFaltados_x_Empleado();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdEmpleado = Info.IdEmpleado;
                    Address.CodCatalogo = Info.CodCatalogo;
                    Address.IdNominaTipo = Info.IdNominaTipo;
                    Address.IdNominaTipoLiq = Info.IdNominaTipoLiq;
                    Address.IdFalta = getId(Info.IdEmpresa, Info.IdEmpleado);

                    Address.FechaFaltaDesde = Info.FechaFaltaDesde;
                    Address.FechaFaltaHasta = Info.FechaFaltaHasta;
                    Address.DiasFaltados = Info.DiasFaltados;
                    Address.DiasDescuento = Info.DiasDescuento;

                    Address.FechaDescuentaRol = Info.FechaDescuentaRol;
                    Address.ValorDescuentaRol =Info.ValorDescuentaRol;
                    Address.Observacion = Info.Observacion;

                    Address.estado = "A";
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.IdNovedad = Info.IdNovedad;
                    if (Address.CatalogoDescripcion == null)
                    {
                        Address.CatalogoDescripcion = ".";
                    }
                    else
                    {
                        Address.CatalogoDescripcion = Info.CatalogoDescripcion;

                    }
                    Context.ro_DiasFaltados_x_Empleado.Add(Address);
                    Context.SaveChanges();



                
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


        public List<ro_DiasFaltados_x_Empleado_Info> ConsultaGeneral(int IdEmpresa, DateTime FechaDesde, DateTime FechaHasta)
        {
            List<ro_DiasFaltados_x_Empleado_Info> Lst = new List<ro_DiasFaltados_x_Empleado_Info>();
            try
            {
                DateTime fi = Convert.ToDateTime(FechaDesde.ToShortDateString());
                DateTime ff = Convert.ToDateTime(FechaHasta.ToShortDateString());

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.vwRo_DiasFaltados_x_Empleado
                            where q.IdEmpresa == IdEmpresa
                            && q.FechaFaltaDesde>=fi
                            &&q.FechaFaltaHasta<=ff
                            select q;
                foreach (var item in Query)
                {
                    ro_DiasFaltados_x_Empleado_Info Address = new ro_DiasFaltados_x_Empleado_Info();


                    Address.IdEmpresa = item.IdEmpresa;
                    Address.IdEmpleado =Convert.ToInt32( item.IdEmpleado);
                    Address.CodCatalogo = item.CodCatalogo;
                    Address.IdNominaTipo = item.IdNominaTipo;
                    Address.IdNominaTipoLiq = item.IdNominaTipoLiq;
                    Address.FechaFaltaDesde = item.FechaFaltaDesde;
                    Address.FechaFaltaHasta = item.FechaFaltaHasta;
                    Address.DiasFaltados = item.DiasFaltados;
                    Address.DiasDescuento = item.DiasDescuento;
                    Address.FechaDescuentaRol = item.FechaDescuentaRol;
                    Address.ValorDescuentaRol = item.ValorDescuentaRol;
                    Address.Observacion = item.Observacion;
                    Address.CatalogoDescripcion = item.CatalogoDescripcion;
                    Address.estado = item.estado;
                    Address.IdUsuario = item.IdUsuario;
                    Address.Fecha_Transac = item.Fecha_Transac;
                    Address.pe_cedulaRuc = item.pe_cedulaRuc;
                    Address.pe_apellido = item.pe_apellido;
                    Address.pe_nombre = item.pe_nombre;
                    Address.IdFalta = item.IdFalta;
                    Address.IdNovedad =item.IdNovedad;
                    Lst.Add(Address);
                }

                return Lst;
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


        public Boolean ModificarDB(ro_DiasFaltados_x_Empleado_Info Info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var Address = context.ro_DiasFaltados_x_Empleado.First(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdEmpleado == Info.IdEmpleado && minfo.IdFalta == Info.IdFalta);
                    Address.CodCatalogo = Info.CodCatalogo;
                    Address.IdNominaTipo = Info.IdNominaTipo;
                    Address.IdNominaTipoLiq = Info.IdNominaTipoLiq;
                    Address.FechaFaltaDesde = Info.FechaFaltaDesde;
                    Address.FechaFaltaHasta = Info.FechaFaltaHasta;
                    Address.DiasFaltados = Info.DiasFaltados;
                    Address.DiasDescuento = Info.DiasDescuento;
                    Address.FechaDescuentaRol = Info.FechaDescuentaRol;
                    Address.ValorDescuentaRol = Info.ValorDescuentaRol;
                    Address.Observacion = Info.Observacion;
                    Address.CatalogoDescripcion = Info.CatalogoDescripcion;
                    Address.estado = Info.estado;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    Address.Fecha_UltMod = Info.Fecha_UltMod;





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


        public Boolean Anular(ro_DiasFaltados_x_Empleado_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_DiasFaltados_x_Empleado.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdEmpleado == info.IdEmpleado && minfo.IdFalta==info.IdFalta);
                    contact.estado = "I";
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = info.Fecha_UltAnu;
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



        public int Get_Dias_Faltados_x_Periodo(int IdEmpresa, int IdEmpleado,DateTime FechaInic,DateTime FechaFin)
        {
            try
            {
                DateTime Fi = Convert.ToDateTime(FechaInic.ToShortDateString());
                DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
                int DiasFalt = 0;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var diasFaltas =( from q in OEEmpleado.ro_DiasFaltados_x_Empleado
                             where q.IdEmpresa == IdEmpresa 
                             && q.IdEmpleado == IdEmpleado
                             && q.FechaDescuentaRol>=Fi
                             && q.FechaDescuentaRol<=Ff
                             && q.CodCatalogo=="218"
                             && q.estado=="A"
                             select q.DiasDescuento);

                if (diasFaltas.Count()==  0)
                {
                    DiasFalt = 0;
                }
                else
                {
                    DiasFalt =Convert.ToInt32( diasFaltas.Sum());
                }
                return DiasFalt;
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
