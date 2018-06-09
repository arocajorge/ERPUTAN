/*CLASE: ro_Empleado_Novedad_Cab_Data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 18-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Empleado_Novedad_Cab_Data
    {
        string mensaje = "";
        List<ro_Empleado_Novedad_Info> lista = new List<ro_Empleado_Novedad_Info>();

        public Boolean GrabarDB(ro_Empleado_Novedad_Info ro_info,ref decimal id ,ref string mensaje)
        {    try
            {
               // int IdNovedad;
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    
                    EntitiesRoles EDB = new EntitiesRoles();

                
                   // ro_info.IdNovedad = IdNovedad;

                    var address = new ro_empleado_Novedad();

                    address.IdNovedad = ro_info.IdNovedad=id=GetIdNovedad(ro_info.IdEmpresa, Convert.ToDecimal(ro_info.IdEmpleado == null ? 0 : ro_info.IdEmpleado));;
                    address.IdEmpresa = ro_info.IdEmpresa;
                    address.IdEmpleado = Convert.ToDecimal(ro_info.IdEmpleado == null ? 0 : ro_info.IdEmpleado);
                    address.TotalValor = ro_info.TotalValor;
                    address.Fecha = ro_info.Fecha;
                    address.IdNomina_Tipo = ro_info.IdNomina_Tipo;
                    address.IdNomina_TipoLiqui = ro_info.IdNomina_TipoLiqui;
                    //address.IdTipoLiqui_Rol_PeriocidadPago = ro_info.IdTipoLiqui_Rol_PeriocidadPago;
                    address.IdUsuario = ro_info.IdUsuario;
                    address.Fecha_Transac = ro_info.Fecha_Transac;
                    address.nom_pc = ro_info.nom_pc;
                    address.ip = ro_info.ip;
                    address.Estado = "A";


                    context.ro_empleado_Novedad.Add(address);
                    context.SaveChanges();

                }
                mensaje = "Se ha guardado la información exitosamente...";
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

        public Boolean GrabarDB(ro_Empleado_Novedad_Info ro_info, decimal idnovedad, ref string mensaje)
        {
            try
            {
               
                using (EntitiesRoles context = new EntitiesRoles())
                {

                   
                    EntitiesRoles EDB = new EntitiesRoles();

                  
                     ro_info.IdNovedad = idnovedad;

                    var address = new ro_empleado_Novedad();

                    address.IdNovedad = ro_info.IdNovedad;
                    address.IdEmpresa = ro_info.IdEmpresa;
                    address.IdEmpleado = Convert.ToDecimal(ro_info.IdEmpleado == null ? 0 : ro_info.IdEmpleado);
                    address.TotalValor = ro_info.TotalValor;
                    address.Fecha = ro_info.Fecha;
                    address.IdNomina_Tipo = ro_info.IdNomina_Tipo;
                    address.IdNomina_TipoLiqui = ro_info.IdNomina_TipoLiqui;
                    //address.IdTipoLiqui_Rol_PeriocidadPago = ro_info.IdTipoLiqui_Rol_PeriocidadPago;
                    address.IdUsuario = ro_info.IdUsuario;
                    address.Fecha_Transac = ro_info.Fecha_Transac;
                    address.nom_pc = ro_info.nom_pc;
                    address.ip = ro_info.ip;
                    address.Estado = ro_info.Estado;

                    context.ro_empleado_Novedad.Add(address);
                    context.SaveChanges();

                }
                mensaje = "Se ha guardado la información exitosamente...";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                mensaje = "Error al grabar .." + ex.Message;
                return false;
            }
        }

        public Boolean ModificarDB(ro_Empleado_Novedad_Info ro_info, ref string mensaje,decimal idTransaccion)
        {
            try{
                using (EntitiesRoles context = new EntitiesRoles()){

                    ro_empleado_Novedad contact = context.ro_empleado_Novedad.FirstOrDefault(var => var.IdEmpresa == ro_info.IdEmpresa
                                  && var.IdEmpleado == ro_info.IdEmpleado && var.IdNovedad == ro_info.IdNovedad);


                    if(contact!=null){//ACTUALIZA REGISTRO
                        contact.Estado = ro_info.Estado;
                        contact.Fecha = ro_info.Fecha;
                        contact.Fecha_UltMod = ro_info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = ro_info.IdUsuarioUltMod;

                        contact.Fecha_UltAnu = ro_info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = ro_info.IdUsuarioUltAnu;
                            
                        double totalvalor = 0;

                        foreach (var item in ro_info.LstDetalle)
                        {
                            totalvalor = totalvalor + item.Valor;
                        }

                        contact.TotalValor = totalvalor;
                        context.SaveChanges();                    
                    }
                    else
                   {//CREA UN NUEVO REGISTRO

                        decimal idNovedad=ro_info.IdNovedad;
                        if (GrabarDB(ro_info, ref mensaje, ref idNovedad, ref idTransaccion))
                        {
                            return true;
                        }else{return false;}

                    }

                    
                    ////ACTUALIZAR EL DETALLE 1
                    //ro_Empleado_Novedad_Det_Data DetData = new ro_Empleado_Novedad_Det_Data();
                    //foreach (var item in ro_info.LstDetalle)
                    //{

                    //    if (DetData.EliminarDB(ro_info.IdEmpresa, ro_info.IdNovedad, ro_info.IdEmpleado, item.IdRubro, ref mensaje))
                    //    {
                    //        int sec = 0;
                    //        sec = DetData.getSecuencia(item.IdEmpresa, item.IdNovedad, item.IdEmpleado);
                    //        item.Secuencia = sec;
                    //        if (!DetData.GrabarDB(item, ref mensaje))
                    //        { return false; }
                    //    }
                    //    else
                    //    {
                    //        return false;
                    //    }
                    //}


                    ////ACTUALIZAR EL DETALLE 2
                    //ro_Novedad_x_Empleado_Data oRo_Novedad_x_Empleado_Data = new ro_Novedad_x_Empleado_Data();
                    //foreach (var item in ro_info.lstNovedadEmpleado){
                    //    if (oRo_Novedad_x_Empleado_Data.BorrarDB(item ,ref mensaje)){
                    //        if (!oRo_Novedad_x_Empleado_Data.GrabarDB(item, item.IdTransaccion, ref mensaje)) { return false; }
                    //    }else{
                    //        return false;
                    //    }
                    //}

                }

                mensaje = "Se ha procedido a actualizar la novedad # " + ro_info.IdNovedad;
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


        public Boolean GrabarDB(ro_Empleado_Novedad_Info ro_info, ref string mensaje, ref decimal idnovedad,ref decimal idTransaccion)
        {
            try
            {
                ro_Novedad_x_Empleado_Data BusNovedadXEmpleado = new ro_Novedad_x_Empleado_Data();
                int IdNovedad;
                using (EntitiesRoles context = new EntitiesRoles())
                {

                  
                    EntitiesRoles EDB = new EntitiesRoles();

                    //OBTIENE LA SECUENCIA DE LA NOVEDAD POR EMPLEADO
                    IdNovedad = GetIdNovedad(ro_info.IdEmpresa, Convert.ToDecimal(ro_info.IdEmpleado == null ? 0 : ro_info.IdEmpleado));
                    idTransaccion=  BusNovedadXEmpleado.getId(ro_info.IdEmpresa);

                    ro_info.IdNovedad = IdNovedad;
                    idnovedad = IdNovedad;

                    var address = new ro_empleado_Novedad();

                    address.IdNovedad = ro_info.IdNovedad;
                    address.IdEmpresa = ro_info.IdEmpresa;
                    address.IdEmpleado = Convert.ToDecimal(ro_info.IdEmpleado == null ? 0 : ro_info.IdEmpleado);
                    address.TotalValor = ro_info.TotalValor;
                    address.Fecha = ro_info.Fecha;
                    address.IdNomina_Tipo = ro_info.IdNomina_Tipo;
                    address.IdNomina_TipoLiqui = ro_info.IdNomina_TipoLiqui;
                    //address.IdTipoLiqui_Rol_PeriocidadPago = ro_info.IdTipoLiqui_Rol_PeriocidadPago;
                    address.IdUsuario = ro_info.IdUsuario;
                    address.Fecha_Transac = ro_info.Fecha_Transac;
                    address.nom_pc = ro_info.nom_pc;
                    address.ip = ro_info.ip;
                    address.Estado ="A";
                    address.IdCalendario = ro_info.IdCalendario;
                    context.ro_empleado_Novedad.Add(address);
                    context.SaveChanges();

                
                    ro_Empleado_Novedad_Det_Data DataDet = new ro_Empleado_Novedad_Det_Data();
                    ro_Novedad_x_Empleado_Data oRo_Novedad_x_Empleado_Data =new ro_Novedad_x_Empleado_Data();

                    int sec = 0;

                    foreach (var item in ro_info.LstDetalle)
                    {
                        item.IdNovedad = ro_info.IdNovedad;
                        item.Secuencia = ++sec;
                        if (!DataDet.GrabarDB(item, ref mensaje))
                            return false;
                    }


                
                }
                mensaje = "Se ha guardado la información exitosamente...";
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

        public Boolean AnularDB(ro_Empleado_Novedad_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado_Novedad.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdNovedad==info.IdNovedad && minfo.IdEmpleado == info.IdEmpleado);
                    contact.Estado = "I";
                    contact.MotiAnula = info.MotiAnula;
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = info.Fecha_UltAnu;
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

        
        public int GetIdNovedad(int idempresa, decimal idEmpleado)
        {
            try
            {

                int Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_empleado_Novedad
                        where C.IdEmpresa == idempresa && C.IdEmpleado==idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in OECbtecble.ro_empleado_Novedad
                                   where t.IdEmpresa == idempresa && t.IdEmpleado==idEmpleado
                                   select t.IdNovedad).Max();
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

        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa,DateTime FechaInicio,DateTime FechaFin)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Info>();
                DateTime fi = Convert.ToDateTime(FechaInicio.ToShortDateString());
                DateTime ff = Convert.ToDateTime(FechaFin.ToShortDateString());

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwro_Empleado_Novedades
                              where A.IdEmpresa == IdEmpresa
                              && A.FechaPago>=fi
                              && A.FechaPago<=ff
                              orderby A.IdEmpleado, A.IdNovedad
                              select A;

                foreach (var item in sresult)
                {
                    ro_Empleado_Novedad_Info Reg = new ro_Empleado_Novedad_Info();

                    //Datos Cabecera
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.Fecha = item.Fecha;
                    Reg.TotalValor = Math.Abs(item.TotalValor);
                    Reg.IdUsuario = item.IdUsuario;
                    Reg.Fecha_Transac = item.Fecha_Transac;
                    Reg.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Reg.Fecha_UltAnu = item.Fecha_UltAnu;
                    Reg.nom_pc = item.nom_pc;
                    Reg.ip = item.ip;
                    Reg.MotiAnula = item.MotiAnula;
                    Reg.Estado = item.Estado_det;

                    Reg.descripcion_tiponomina = item.descripcion_tiponomina;
                    Reg.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Reg.IdNomina_Tipo = item.IdNomina_Tipo;
                    Reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Reg.RubroDescp = item.ru_descripcion;
                    Reg.NomPerComp = item.pe_nombreCompleto;

                    Reg.InfoNovedadDet.IdEmpresa = item.IdEmpresa;
                    Reg.InfoNovedadDet.IdNovedad = item.IdNovedad;
                    Reg.InfoNovedadDet.FechaPago = item.FechaPago;//19112013 D
                    Reg.InfoNovedadDet.IdRubro = item.IdRubro;
                    Reg.InfoNovedadDet.ru_descripcion = item.ru_descripcion;
                    Reg.InfoNovedadDet.Observacion = item.Observacion;
                    Reg.InfoNovedadDet.Valor = Math.Abs(Convert.ToDouble(item.Valor));
                    Reg.InfoNovedadDet.EstadoCobro = (item.EstadoCobro).Trim();
                    //nuevo
                    Reg.EstadoCobro = (item.EstadoCobro).Trim();
                    //
                    Reg.InfoNovedadDet.Estado = item.Estado_det;
                    Reg.InfoPersona.pe_apellido = item.pe_apellido;
                    Reg.InfoPersona.pe_nombre=item.pe_nombre;
                    Reg.MotivoModifica = item.MotivoModiica;
                    Reg.NomPerComp = item.pe_apellido + " " + item.pe_nombre;
                    Reg.Secuencia = item.IdTransaccion;
                    Reg.Num_Horas = item.Num_Horas;
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



        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Info>();
                

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwro_Empleado_Novedades
                              where A.IdEmpresa == IdEmpresa
                              
                              orderby A.IdEmpleado, A.IdNovedad
                              select A;

                foreach (var item in sresult)
                {
                    ro_Empleado_Novedad_Info Reg = new ro_Empleado_Novedad_Info();

                    //Datos Cabecera
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.Fecha = item.Fecha;
                    Reg.TotalValor = Math.Abs(item.TotalValor);
                    Reg.IdUsuario = item.IdUsuario;
                    Reg.Fecha_Transac = item.Fecha_Transac;
                    Reg.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Reg.Fecha_UltAnu = item.Fecha_UltAnu;
                    Reg.nom_pc = item.nom_pc;
                    Reg.ip = item.ip;
                    Reg.MotiAnula = item.MotiAnula;
                    Reg.Estado = item.Estado;

                    Reg.descripcion_tiponomina = item.descripcion_tiponomina;
                    Reg.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Reg.IdNomina_Tipo = item.IdNomina_Tipo;
                    Reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Reg.RubroDescp = item.ru_descripcion;
                    Reg.NomPerComp = item.pe_nombreCompleto;

                    Reg.InfoNovedadDet.IdEmpresa = item.IdEmpresa;
                    Reg.InfoNovedadDet.IdNovedad = item.IdNovedad;
                    Reg.InfoNovedadDet.FechaPago = item.FechaPago;//19112013 D
                    Reg.InfoNovedadDet.IdRubro = item.IdRubro;
                    Reg.InfoNovedadDet.ru_descripcion = item.ru_descripcion;
                    Reg.InfoNovedadDet.Observacion = item.Observacion;
                    Reg.InfoNovedadDet.Valor = Math.Abs(Convert.ToDouble(item.Valor));
                    Reg.InfoNovedadDet.EstadoCobro = (item.EstadoCobro).Trim();
                    //nuevo
                    Reg.EstadoCobro = (item.EstadoCobro).Trim();
                    //
                    Reg.InfoNovedadDet.Estado = item.Estado_det;
                    Reg.InfoPersona.pe_apellido = item.pe_apellido;
                    Reg.InfoPersona.pe_nombre = item.pe_nombre;
                    Reg.MotivoModifica = item.MotivoModiica;
                    Reg.NomPerComp = item.pe_apellido + " " + item.pe_nombre;
                    Reg.Secuencia = item.IdTransaccion;

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






        public ro_Empleado_Novedad_Info Get_Info_Empleado_Novedad_Cab(int IdEmpresa, decimal IdNovedades, string Idrubro)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Info>();


                EntitiesRoles ORol = new EntitiesRoles();

                var item = ORol.vwro_Empleado_Novedades.First(A => A.IdEmpresa == IdEmpresa
                              && A.IdNovedad == IdNovedades 
                              && A.IdRubro == Idrubro);
                              

              
                    ro_Empleado_Novedad_Info Reg = new ro_Empleado_Novedad_Info();

                    //Datos Cabecera
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.Fecha = item.Fecha;
                    Reg.TotalValor = item.TotalValor;
                    Reg.IdUsuario = item.IdUsuario;
                    Reg.Fecha_Transac = item.Fecha_Transac;
                    Reg.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Reg.Fecha_UltAnu = item.Fecha_UltAnu;
                    Reg.nom_pc = item.nom_pc;
                    Reg.ip = item.ip;
                    Reg.MotiAnula = item.MotiAnula;
                    Reg.Estado = item.Estado;
                    Reg.descripcion_tiponomina = item.descripcion_tiponomina;
                    Reg.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Reg.IdNomina_Tipo = item.IdNomina_Tipo;
                    Reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Reg.IdRubro = item.IdRubro;
                    //Reg.RubroDescp = item.ru_descripcion;

                    Reg.RubroDescp = item.ru_descripcion;
                    Reg.NomPerComp = item.pe_nombreCompleto;
                   

                    //Datos Detalle
                    Reg.InfoNovedadDet.IdEmpresa = item.IdEmpresa;
                    Reg.InfoNovedadDet.IdNovedad = item.IdNovedad;
                    Reg.InfoNovedadDet.IdRubro = item.IdRubro;
                    Reg.InfoNovedadDet.ru_descripcion = item.ru_descripcion;
                    Reg.InfoNovedadDet.Observacion = item.Observacion;
                    Reg.InfoNovedadDet.Valor = Convert.ToDouble(item.Valor);
                    Reg.InfoNovedadDet.EstadoCobro = item.EstadoCobro;
                    Reg.InfoNovedadDet.Estado = item.Estado_det;

                    return Reg;
                
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

        public ro_Empleado_Novedad_Info Get_Info_Empleado_Novedad_Cab_x_Rubro(int IdEmpresa, decimal IdNovedades, string IdRubro, decimal IdEmpleado)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Info>();


                EntitiesRoles ORol = new EntitiesRoles();

                var item = ORol.vwro_Empleado_Novedades.First(A => A.IdEmpresa == IdEmpresa
                              && A.IdNovedad == IdNovedades && A.IdEmpleado == IdEmpleado
                              && A.IdRubro == IdRubro);



                ro_Empleado_Novedad_Info Reg = new ro_Empleado_Novedad_Info();

                //Datos Cabecera
                Reg.IdEmpresa = item.IdEmpresa;
                Reg.IdNovedad = item.IdNovedad;
                Reg.IdEmpleado = item.IdEmpleado;
                Reg.Fecha = item.Fecha;
                Reg.TotalValor = item.TotalValor;
                Reg.IdUsuario = item.IdUsuario;
                Reg.Fecha_Transac = item.Fecha_Transac;
                Reg.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                Reg.Fecha_UltAnu = item.Fecha_UltAnu;
                Reg.nom_pc = item.nom_pc;
                Reg.ip = item.ip;
                Reg.MotiAnula = item.MotiAnula;
                Reg.Estado = item.Estado;
                Reg.descripcion_tiponomina = item.descripcion_tiponomina;
                Reg.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                Reg.IdNomina_Tipo = item.IdNomina_Tipo;
                Reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                Reg.IdRubro = item.IdRubro;
                //Reg.RubroDescp = item.ru_descripcion;

                Reg.RubroDescp = item.ru_descripcion;
                Reg.NomPerComp = item.pe_nombreCompleto;


                //Datos Detalle
                Reg.InfoNovedadDet.IdEmpresa = item.IdEmpresa;
                Reg.InfoNovedadDet.IdNovedad = item.IdNovedad;
                Reg.InfoNovedadDet.IdRubro = item.IdRubro;
                Reg.InfoNovedadDet.ru_descripcion = item.ru_descripcion;
                Reg.InfoNovedadDet.Observacion = item.Observacion;
                Reg.InfoNovedadDet.Valor = Convert.ToDouble(item.Valor);
                Reg.InfoNovedadDet.EstadoCobro = item.EstadoCobro;
                Reg.InfoNovedadDet.Estado = item.Estado_det;
                Reg.Secuencia = item.IdTransaccion;

                return Reg;

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

        public Boolean Modificar_Nov(ro_Empleado_Novedad_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    double total=0;

                    var contact = context.ro_empleado_Novedad.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdNovedad == info.IdNovedad && minfo.IdEmpleado == info.IdEmpleado);

                    var q = from C in context.ro_empleado_novedad_det
                            where C.IdEmpresa == info.IdEmpresa && C.IdEmpleado == info.IdEmpleado
                            && C.IdNovedad == info.IdNovedad
                            select C;

                    foreach (var item in q)
                    {
                        ro_Empleado_Novedad_Det_Info Obj = new ro_Empleado_Novedad_Det_Info();
                       
                        Obj.Valor = item.Valor;
                        total = total + Obj.Valor;
                    }

                    contact.MotivoModiica = info.MotivoModifica;
                    contact.TotalValor = total;
                    

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


        public Boolean EliminarBD(int idEmpresa, decimal idNovedad,decimal idEmpleado ,int idNominaTipo, int idNominaTipoLiqui, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_Novedad where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNovedad=" + idNovedad.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       //+ " AND IdNomina_Tipo=" + idNominaTipo.ToString()
                       //+ " AND IdNomina_TipoLiqui=" + idNominaTipoLiqui.ToString()                      
                       );
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


        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa,string IdCalendario,string IdRubro)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Info>();


                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwro_Empleado_Novedades
                              where A.IdEmpresa == IdEmpresa
                              && A.IdCalendario==IdCalendario
                              && A.IdRubro==IdRubro
                              && A.Estado=="A"
                              && A.EstadoCobro=="PEN"
                              orderby A.IdEmpleado, A.IdNovedad
                              select A;

                foreach (var item in sresult)
                {
                    ro_Empleado_Novedad_Info Reg = new ro_Empleado_Novedad_Info();

                    //Datos Cabecera
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.Fecha = item.Fecha;
                    Reg.TotalValor = Math.Abs(item.TotalValor);
                    Reg.IdUsuario = item.IdUsuario;
                    Reg.Fecha_Transac = item.Fecha_Transac;
                    Reg.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Reg.Fecha_UltAnu = item.Fecha_UltAnu;
                    Reg.nom_pc = item.nom_pc;
                    Reg.ip = item.ip;
                    Reg.MotiAnula = item.MotiAnula;
                    Reg.Estado = item.Estado;

                    Reg.descripcion_tiponomina = item.descripcion_tiponomina;
                    Reg.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Reg.IdNomina_Tipo = item.IdNomina_Tipo;
                    Reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Reg.RubroDescp = item.ru_descripcion;
                    Reg.NomPerComp = item.pe_nombreCompleto;

                    Reg.InfoNovedadDet.IdEmpresa = item.IdEmpresa;
                    Reg.InfoNovedadDet.IdNovedad = item.IdNovedad;
                    Reg.InfoNovedadDet.FechaPago = item.FechaPago;//19112013 D
                    Reg.InfoNovedadDet.IdRubro = item.IdRubro;
                    Reg.InfoNovedadDet.ru_descripcion = item.ru_descripcion;
                    Reg.InfoNovedadDet.Observacion = item.Observacion;
                    Reg.InfoNovedadDet.Valor = Math.Abs(Convert.ToDouble(item.Valor));
                    Reg.InfoNovedadDet.EstadoCobro = (item.EstadoCobro).Trim();
                    //nuevo
                    Reg.EstadoCobro = (item.EstadoCobro).Trim();
                    //
                    Reg.InfoNovedadDet.Estado = item.Estado_det;
                    Reg.InfoPersona.pe_apellido = item.pe_apellido;
                    Reg.InfoPersona.pe_nombre = item.pe_nombre;
                    Reg.MotivoModifica = item.MotivoModiica;
                    Reg.NomPerComp = item.pe_apellido + " " + item.pe_nombre;
                    Reg.Secuencia = item.IdTransaccion;
                    Reg.IdCalendario = item.IdCalendario;
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





        public List<ro_Empleado_Novedad_Info> Get_List_Novedades_Cambiar_estado_Canceladas(int IdEmpresa,int idnomina,int idnomina_tipo,DateTime fecha_incion,DateTime fecha_fin)
        {
            try
            {
                lista = new List<ro_Empleado_Novedad_Info>();


                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwro_Empleado_Novedades
                              where A.IdEmpresa == IdEmpresa
                              && A.IdNomina_Tipo==idnomina
                              && A.IdNomina_TipoLiqui==idnomina_tipo
                              && A.FechaPago>=fecha_incion
                              && A.FechaPago<=fecha_fin
                              && A.EstadoCobro=="PEN"
                              && A.Estado_det=="A"
                              select A;

                foreach (var item in sresult)
                {
                    ro_Empleado_Novedad_Info Reg = new ro_Empleado_Novedad_Info();

                    //Datos Cabecera
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdNovedad = item.IdNovedad;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.Fecha = item.Fecha;
                    Reg.TotalValor = Math.Abs(item.TotalValor);
                    Reg.IdUsuario = item.IdUsuario;
                    Reg.Fecha_Transac = item.Fecha_Transac;
                    Reg.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Reg.Fecha_UltAnu = item.Fecha_UltAnu;
                    Reg.nom_pc = item.nom_pc;
                    Reg.ip = item.ip;
                    Reg.MotiAnula = item.MotiAnula;
                    Reg.Estado = item.Estado;

                    Reg.descripcion_tiponomina = item.descripcion_tiponomina;
                    Reg.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    Reg.IdNomina_Tipo = item.IdNomina_Tipo;
                    Reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    Reg.RubroDescp = item.ru_descripcion;
                    Reg.NomPerComp = item.pe_nombreCompleto;

                    Reg.InfoNovedadDet.IdEmpresa = item.IdEmpresa;
                    Reg.InfoNovedadDet.IdNovedad = item.IdNovedad;
                    Reg.InfoNovedadDet.FechaPago = item.FechaPago;//19112013 D
                    Reg.InfoNovedadDet.IdRubro = item.IdRubro;
                    Reg.InfoNovedadDet.ru_descripcion = item.ru_descripcion;
                    Reg.InfoNovedadDet.Observacion = item.Observacion;
                    Reg.InfoNovedadDet.Valor = Math.Abs(Convert.ToDouble(item.Valor));
                    Reg.InfoNovedadDet.EstadoCobro = (item.EstadoCobro).Trim();
                    //nuevo
                    Reg.EstadoCobro = (item.EstadoCobro).Trim();
                    //
                    Reg.InfoNovedadDet.Estado = item.Estado_det;
                    Reg.InfoPersona.pe_apellido = item.pe_apellido;
                    Reg.InfoPersona.pe_nombre = item.pe_nombre;
                    Reg.MotivoModifica = item.MotivoModiica;
                    Reg.NomPerComp = item.pe_apellido + " " + item.pe_nombre;
                    Reg.Secuencia = item.IdTransaccion;

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



    }
}
