using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


using Core.Erp.Info.Roles;

namespace Core.Erp.Data.Roles
{
public class ro_prestamo_Data
    {
    string mensaje = "";


    public decimal GetIdPrestamo()
    {
        try
        {
            decimal Id;
            EntitiesRoles OECbtecble = new EntitiesRoles();

            var q = from C in OECbtecble.ro_prestamo
                  //  where C.IdEmpresa == idempresa //&& C.IdEmpleado == idEmpleado
                    select C;
            if (q.ToList().Count == 0)
                return 1;
            else
            {
                var select_ = (from t in OECbtecble.ro_prestamo
                               select t.IdPrestamo).Max();
                Id = Convert.ToInt32(select_.ToString()) + 1;
                return Id;
             
            }
        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }

    public Boolean Guardar_DB(ro_prestamo_Info Item, ref decimal Id, ref string mensaje)
    {
        try
        {
            using (EntitiesRoles Context = new EntitiesRoles())
            {
                ro_prestamo Cabe = new ro_prestamo();
                               
                Cabe.IdEmpresa = Item.IdEmpresa;
                Cabe.IdPrestamo = Id = GetIdPrestamo();
                Cabe.IdNomina_Tipo = Item.IdNomina_Tipo;
                Cabe.IdEmpleado = Item.IdEmpleado;
                Cabe.IdRubro = Item.IdRubro;
                Cabe.IdEmpleado_Aprueba = Item.IdEmpleado_Aprueba;
                Cabe.IdMotivo_Prestamo = Item.IdMotivo_Prestamo;
                Cabe.Estado = Item.Estado;
                Cabe.Fecha = Convert.ToDateTime(Item.Fecha.ToShortDateString());
                Cabe.MontoSol = Item.MontoSol;
                Cabe.TasaInteres = Item.TasaInteres;
                Cabe.TotalPrestamo = Item.TotalPrestamo;
                Cabe.NumCuotas = Item.NumCuotas;
                Cabe.IdTipo_Pago = Item.IdTipo_Pago;
                Cabe.Fecha_PriPago = Item.Fecha_PriPago;
                Cabe.Observacion = Item.Observacion;
                Cabe.Tipo_Calculo = Item.Tipo_Calculo;

                Cabe.IdUsuario = Item.IdUsuario;
                Cabe.Fecha_Transac = Item.Fecha_Transac;
            	Cabe.nom_pc=Item.nom_pc;
		        Cabe.ip=Item.ip;
                Cabe.IdNominaTipoLiqui = Item.IdNominaTipoLiqui;
                Context.ro_prestamo.Add(Cabe);
                Context.SaveChanges();
            }

            return true;
        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }


    public List<ro_prestamo_Info> ConsultarCabeceraPrestamo(int IdEmpresa, DateTime FechaInicio, DateTime FechaFin)
    {
        try
        {
            using (EntitiesRoles oen = new EntitiesRoles())
            {
                FechaInicio = Convert.ToDateTime(FechaInicio.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                List<ro_prestamo_Info> ListaPrestamo= new List<ro_prestamo_Info>();
                var Consulta = from q in oen.vwRo_Prestamo
                                                      where q.IdEmpresa == IdEmpresa && q.Fecha >= FechaInicio && q.Fecha<= FechaFin
                                                     select q;
                foreach (var item in Consulta)
	            {
                    ro_prestamo_Info info=new ro_prestamo_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdPrestamo = item.IdPrestamo;
                    info.IdNomina_Tipo = item.IdNomina_Tipo;
                    info.nomi_descripcion = item.nomi_descripcion;
                    info.IdEmpleado = item.IdEmpleado;
                    info.pe_nombre =item.pe_apellido+" "+ item.pe_nombre;
                    info.IdRubro = item.IdRubro;
                    info.ru_descripcion = item.ru_descripcion;
                    info.IdEmpleado_Aprueba = item.IdEmpleado_Aprueba;
                    info.pe_nombre_apru = item.pe_nombre_apru;
                    info.Codigo = item.Codigo;
                    info.ca_descripcion = item.ca_descripcion;
                    info.Estado = item.Estado;
                    info.Fecha=item.Fecha;
                    info.MontoSol=item.MontoSol;
                    info.TasaInteres=item.TasaInteres;
                    info.NumCuotas = item.NumCuotas;
                    info.cod_pago = item.cod_pago;
                    info.peri_pago = item.peri_pago;
                    info.Observacion = item.Observacion;
                    info.TotalPrestamo =Convert.ToDouble( item.TotalPrestamo);
                    info.TotalCobrado = item.TotalCobrado;
                    info.SaldoPrestamo = item.SaldoPrestamo;
                    info.Fecha_PriPago =item.Fecha_PriPago;
                    info.Tipo_Calculo=item.Tipo_Calculo;
                    info.MotiAnula = item.MotiAnula;
                    info.Cedula = item.pe_cedulaRuc;
                    info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                  ListaPrestamo.Add(info);
		 
	             }
               

                   
                                                     
               // }
                //return obj;
                return ListaPrestamo;
            }

        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }//haac 02/10/13






    public List<ro_prestamo_Info> GetListConsultarPrestamoXEmpleado(int idEmpresa, int idEmpleado)
    {
        try
        {
            using (EntitiesRoles db = new EntitiesRoles())
            {
               // fechaInicio = Convert.ToDateTime(fechaInicio.ToShortDateString());
                //fechaFin = Convert.ToDateTime(fechaFin.ToShortDateString());

                List<ro_prestamo_Info> ListaPrestamo = new List<ro_prestamo_Info>();


                var Consulta = from q in db.vwRo_Prestamo
                               where q.IdEmpresa == idEmpresa && q.IdEmpleado==idEmpleado
                               select q;
                foreach (var item in Consulta)
                {
                    ro_prestamo_Info info = new ro_prestamo_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdPrestamo = item.IdPrestamo;
                    info.IdNomina_Tipo = item.IdNomina_Tipo;
                    info.nomi_descripcion = item.nomi_descripcion;
                    info.IdEmpleado = item.IdEmpleado;
                    info.pe_nombre = item.pe_nombre;
                    info.IdRubro = item.IdRubro;
                    info.ru_descripcion = item.ru_descripcion;
                    info.IdEmpleado_Aprueba = item.IdEmpleado_Aprueba;
                    info.pe_nombre_apru = item.pe_nombre_apru;
                    info.Codigo = item.Codigo;
                    info.ca_descripcion = item.ca_descripcion;
                    info.Estado = item.Estado;
                    info.Fecha = item.Fecha;
                    info.MontoSol = item.MontoSol;
                    info.TasaInteres = item.TasaInteres;
                    info.NumCuotas = item.NumCuotas;
                    info.cod_pago = item.cod_pago;
                    info.peri_pago = item.peri_pago;
                    info.Observacion = item.Observacion;
                    info.TotalPrestamo = Convert.ToDouble(item.TotalPrestamo);
                    info.TotalCobrado = item.TotalCobrado;
                    info.SaldoPrestamo = item.SaldoPrestamo;
                    info.Fecha_PriPago = item.Fecha_PriPago;
                    info.Tipo_Calculo = item.Tipo_Calculo;
                    info.MotiAnula = item.MotiAnula;
                    ListaPrestamo.Add(info);

                }

                return ListaPrestamo;
            }

        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }







    public ro_prestamo_Info ObtenerPrestamo(int IdEmpresa, decimal IdPrestamo, decimal IdEmpleado)
    {
        try
        {
            //lista = new List<ro_Empleado_Novedad_Cab_Info>();

           EntitiesRoles ORol = new EntitiesRoles();

            var item = ORol.vwRo_Prestamo.First(A => A.IdEmpresa == IdEmpresa
                          && A.IdPrestamo == IdPrestamo
                          && A.IdEmpleado == IdEmpleado);

                 ro_prestamo_Info Reg = new ro_prestamo_Info();
            
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdPrestamo = item.IdPrestamo;
                    Reg.IdNomina_Tipo = item.IdNomina_Tipo;
                    Reg.nomi_descripcion = item.nomi_descripcion;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.pe_nombre = item.pe_nombre;
                    Reg.IdRubro = item.IdRubro;
                    Reg.ru_descripcion = item.ru_descripcion;
                    Reg.IdEmpleado_Aprueba = item.IdEmpleado_Aprueba;
                    Reg.pe_nombre_apru = item.pe_nombre_apru;
                    Reg.Codigo = item.Codigo;
                    Reg.ca_descripcion = item.ca_descripcion;
                    Reg.Estado = item.Estado;
                    Reg.Fecha=item.Fecha;
                    Reg.MontoSol=item.MontoSol;
                    Reg.TasaInteres=item.TasaInteres;
                    Reg.NumCuotas = item.NumCuotas;
                    Reg.cod_pago = item.cod_pago;
                    Reg.peri_pago = item.peri_pago;
                    Reg.Observacion = item.Observacion;
                    Reg.TotalPrestamo =Convert.ToDouble( item.TotalPrestamo);
                    Reg.TotalCobrado = item.TotalCobrado;
                    Reg.SaldoPrestamo = item.SaldoPrestamo;
                    Reg.Fecha_PriPago = item.Fecha_PriPago;
        

            return Reg;

        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }







    public List<ro_prestamo_Info> ConsultarCabeceraPrestamoxIdPrestamo(int IdEmpresa, decimal IdPrestamo)
    {
        try
        {
            using (EntitiesRoles oen = new EntitiesRoles())
            {


                List<ro_prestamo_Info> ListaPrestamo = new List<ro_prestamo_Info>();
                var Consulta = from q in oen.vwRo_Prestamo
                               where q.IdEmpresa == IdEmpresa && q.IdPrestamo ==IdPrestamo
                               select q;
                foreach (var item in Consulta)
                {
                    ro_prestamo_Info info = new ro_prestamo_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdPrestamo = item.IdPrestamo;
                    info.IdNomina_Tipo = item.IdNomina_Tipo;
                    info.nomi_descripcion = item.nomi_descripcion;
                    info.IdEmpleado = item.IdEmpleado;
                    info.pe_nombre = item.pe_nombre;
                    info.IdRubro = item.IdRubro;
                    info.ru_descripcion = item.ru_descripcion;
                    info.IdEmpleado_Aprueba = item.IdEmpleado_Aprueba;
                    info.pe_nombre_apru = item.pe_nombre_apru;
                    info.Codigo = item.Codigo;
                    info.ca_descripcion = item.ca_descripcion;
                    info.Estado = item.Estado;
                    info.Fecha = item.Fecha;
                    info.MontoSol = item.MontoSol;
                    info.TasaInteres = item.TasaInteres;
                    info.NumCuotas = item.NumCuotas;
                    info.cod_pago = item.cod_pago;
                    info.peri_pago = item.peri_pago;
                    info.Observacion = item.Observacion;
                    info.TotalPrestamo = Convert.ToDouble(item.TotalPrestamo);
                    info.TotalCobrado = item.TotalCobrado;
                    info.SaldoPrestamo = item.SaldoPrestamo;
                    info.Fecha_PriPago = item.Fecha_PriPago;
                    info.Tipo_Calculo = item.Tipo_Calculo;
                    info.MotiAnula = item.MotiAnula;
                    ListaPrestamo.Add(info);

                }
                return ListaPrestamo;
            }

        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }//haac 08/10/13

    public Boolean ModificarCabeceraPrestamo(ro_prestamo_Info Info)
    {
        try
        {
            using (EntitiesRoles Entity = new EntitiesRoles())
            {

                var prestamo = Entity.ro_prestamo.First(v => v.IdPrestamo == Info.IdPrestamo && v.IdEmpresa==Info.IdEmpresa);
                               
                prestamo.IdNomina_Tipo = Info.IdNomina_Tipo;
                prestamo.IdEmpleado = Info.IdEmpleado;
                prestamo.IdRubro = Info.IdRubro;
                prestamo.IdEmpleado_Aprueba = Info.IdEmpleado_Aprueba;
                prestamo.IdMotivo_Prestamo = Info.IdMotivo_Prestamo;
                prestamo.Estado = Info.Estado;
                prestamo.Fecha = Info.Fecha;
                prestamo.MontoSol = Info.MontoSol;
                prestamo.TasaInteres = Info.TasaInteres;
                prestamo.TotalPrestamo = Info.TotalPrestamo;
                prestamo.NumCuotas = Info.NumCuotas;
                prestamo.IdTipo_Pago = Info.IdTipo_Pago;
                prestamo.Fecha_PriPago = Info.Fecha_PriPago;
                prestamo.Observacion = Info.Observacion;
                prestamo.Tipo_Calculo = Info.Tipo_Calculo;
                prestamo.Estado = Info.Estado;
                prestamo.IdNominaTipoLiqui = Info.IdNominaTipoLiqui;
                Entity.SaveChanges();
            }


            return true;
        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }

    }

    public Boolean AnularPrestamo(ro_prestamo_Info _Info)
    {
        try
        {
            using (EntitiesRoles Entity = new EntitiesRoles())
            {

                ro_prestamo  cabecera = Entity.ro_prestamo.First(v => v.IdPrestamo == _Info.IdPrestamo && v.IdEmpresa==_Info.IdEmpresa );

               // Entity.ro_prestamo.Remove(cabecera);
                cabecera.IdUsuarioUltAnu = _Info.IdUsuarioUltAnu;
                cabecera.Fecha_UltAnu = _Info.Fecha_UltAnu;
                cabecera.MotiAnula = _Info.MotiAnula;

                cabecera.Estado = "I";
                Entity.SaveChanges();
            }

            return true;
        }
        catch (Exception ex)
        {
            string array = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }
    }
}
