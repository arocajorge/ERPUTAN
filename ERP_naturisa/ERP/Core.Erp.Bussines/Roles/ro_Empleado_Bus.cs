
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles.AGP;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.Data;
using Core.Erp.Info.class_sri.RDEP;
using Core.Erp.Info.class_sri.FacturaV2;
using System.IO;
using System.Xml;
using System.Xml.Serialization;



namespace Core.Erp.Business.Roles
{
    public class ro_Empleado_Bus
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_empleado_gastos_perso_Info> EGInfo = new List<ro_empleado_gastos_perso_Info>();
        ro_empleado_gastos_perso_Bus EGBus = new ro_empleado_gastos_perso_Bus();

        List<ro_CargaFamiliar_Info> CargaFamHijoinfo = new List<ro_CargaFamiliar_Info>();
        List<ro_CargaFamiliar_Info> CargaFamConyugueinfo = new List<ro_CargaFamiliar_Info>();
        List<ro_CargaFamiliar_Info> CargaFamDiscapacitadoinfo = new List<ro_CargaFamiliar_Info>();
        ro_CargaFamiliar_Bus CargaFamBus = new ro_CargaFamiliar_Bus();

        List<ro_empleado_gastos_perso_x_Gastos_deduci_Info> EGPinfo = new List<ro_empleado_gastos_perso_x_Gastos_deduci_Info>();
        ro_empleado_gastos_perso_x_Gastos_deduci_Bus EGPbus = new ro_empleado_gastos_perso_x_Gastos_deduci_Bus();

        List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> EOGPinfo = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>();
        ro_empleado_gastos_perso_x_otros_gast_deduci_Bus EOGPbus = new ro_empleado_gastos_perso_x_otros_gast_deduci_Bus();


        

        //DATA
        ro_Empleado_Data oRro_Empleado_Data = new ro_Empleado_Data();
        
        //BUS
        tb_persona_bus oTb_persona_bus = new tb_persona_bus();
        //ro_Empleado_Bus oro_Empleado_Bus = new ro_Empleado_Bus();
        ro_CargaFamiliar_Bus oRo_CargaFamiliar_Bus = new ro_CargaFamiliar_Bus();
        ro_empleado_x_titulos_Bus oRo_empleado_x_titulos_Bus = new ro_empleado_x_titulos_Bus();
        ro_Empleado_estudios_Bus oRo_Empleado_estudios_Bus = new ro_Empleado_estudios_Bus();
        ro_empleado_x_Proyeccion_Gastos_Personales_Bus oRo_empleado_x_Proyeccion_Gastos_Personales_Bus = new ro_empleado_x_Proyeccion_Gastos_Personales_Bus();
        ro_empleado_x_rubro_acumulado_Bus oRo_empleado_x_rubro_acumulado_Bus=new ro_empleado_x_rubro_acumulado_Bus();
        ro_empleado_x_centro_costo_Bus oRo_empleado_x_centro_costo_Bus = new ro_empleado_x_centro_costo_Bus();
        ro_empleado_x_ro_rubro_Bus oRo_empleado_x_ro_rubro_Bus = new ro_empleado_x_ro_rubro_Bus();
        ro_Empleado_TipoNomina_Bus oRo_Empleado_TipoNomina_Bus = new ro_Empleado_TipoNomina_Bus();
        ro_Empleado_X_Horario_Bus oRo_Empleado_X_Horario_Bus = new ro_Empleado_X_Horario_Bus();



        #endregion

        public gastosPersonales Get_GastosPersonales_x_Empleado(int  IdEmpresa ,decimal IdEmpleado , int IdAnioFiscal )
        {
            try
            {
                gastosPersonales Data = new gastosPersonales();
                EGPinfo = new List<ro_empleado_gastos_perso_x_Gastos_deduci_Info>(EGPbus.Get_List_empleado_gastos_perso_x_Gastos_dedu(param.IdEmpresa, Convert.ToInt32(IdEmpleado), IdAnioFiscal));
                EOGPinfo = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>(EOGPbus.Get_List_empleado_gastos_perso_x_otros_gast_deduc(param.IdEmpresa, Convert.ToInt32(IdEmpleado), IdAnioFiscal));
                EGInfo = new List<ro_empleado_gastos_perso_Info>(EGBus.Get_Info_empleado_gastos_pers(param.IdEmpresa, Convert.ToInt32(IdEmpleado), IdAnioFiscal));
                CargaFamHijoinfo = new List<ro_CargaFamiliar_Info>(CargaFamBus.Obtener_CargaFamiliarHijo(param.IdEmpresa, Convert.ToInt32(IdEmpleado)));
                CargaFamConyugueinfo = new List<ro_CargaFamiliar_Info>(CargaFamBus.Obtener_CargaFamiliarConyugue(param.IdEmpresa, Convert.ToInt32(IdEmpleado)));
                CargaFamDiscapacitadoinfo = new List<ro_CargaFamiliar_Info>(CargaFamBus.Obtener_CargaFamiliarDiscapacitado(param.IdEmpresa, Convert.ToInt32(IdEmpleado)));
                Data = CargaDatos();
                return Data;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_GastosPersonales_x_Empleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }    
          }

        private gastosPersonales CargaDatos()
        {
            try
            {

                Boolean TieneHijos = false;

                gastosPersonales Data = new gastosPersonales();

                foreach (var item in EGInfo)
                {
                    Data.identificacion = item.Num_Identificacion;
                    Data.nombresApellidos = item.Apellidos_Nombres;
                    Data.tipoIdentificacion = item.Tipo_Iden;
                    Data.dirCalle = item.calle_prin;
                    Data.dirNumero = item.Numero;
                    Data.dirInterseccion = item.Intersecion;
                    Data.dirProvincia = item.IdProvincia;
                    Data.dirCanton = item.IdCidudad;
                    Data.telefono = item.telefono;
                    Data.periodoFiscal = Convert.ToString(item.Anio_fiscal);
                }


                //detallesHijosDependientes

                List<detallesHijosDependientes> Detallehijo = new List<detallesHijosDependientes>();

                detallesHijosDependientes ItemDetallehijo = new detallesHijosDependientes();

                foreach (var item in CargaFamHijoinfo)
                {
                    TieneHijos = true;
                    ItemDetallehijo = new detallesHijosDependientes();
                    ItemDetallehijo.identificacion = item.Cedula;
                    ItemDetallehijo.nombres = item.Nombres;
                    if (item.Cedula != "" || item.Cedula != null)
                    {
                        if (item.Cedula.Length == 10)
                        {
                            ItemDetallehijo.tipoIdentificacion = "C";
                        }
                        else
                        {
                            if (item.Cedula.Length == 13)
                            {
                                ItemDetallehijo.tipoIdentificacion = "P";
                            }
                            else
                            {
                                ItemDetallehijo.tipoIdentificacion = "F";
                                ItemDetallehijo.identificacion = "9999999999999";
                            }
                        }
                    }

                    Detallehijo.Add(ItemDetallehijo);
                }

                List<detalleConyugueDependiente> DetalleConyugue = new List<detalleConyugueDependiente>();

                detalleConyugueDependiente ItemDetalleConyugue = new detalleConyugueDependiente();

                foreach (var item in CargaFamConyugueinfo)
                {
                    ItemDetalleConyugue = new detalleConyugueDependiente();
                    ItemDetalleConyugue.identificacion = item.Cedula;
                    ItemDetalleConyugue.nombres = item.Nombres;
                    if (item.Cedula != "" || item.Cedula != null)
                    {
                        if (item.Cedula.Length == 10)
                        {
                            ItemDetalleConyugue.tipoIdentificacion = "C";
                        }
                        else
                        {
                            ItemDetalleConyugue.tipoIdentificacion = "P";
                        }
                    }
                    DetalleConyugue.Add(ItemDetalleConyugue);
                }


                //detalleDiscapacitadosDependientes

                List<detalleDiscapacitadosDependientes> DetalleDiscapacitados = new List<detalleDiscapacitadosDependientes>();

                detalleDiscapacitadosDependientes ItemDetalleDiscapacitados = new detalleDiscapacitadosDependientes();

                foreach (var item in CargaFamDiscapacitadoinfo)
                {
                    ItemDetalleDiscapacitados = new detalleDiscapacitadosDependientes();
                    ItemDetalleDiscapacitados.identificacion = item.Cedula;
                    ItemDetalleDiscapacitados.nombres = item.Nombres;
                    if (item.Cedula != "" || item.Cedula != null)
                    {
                        if (item.Cedula.Length == 10)
                        {
                            ItemDetalleDiscapacitados.tipoIdentificacion = "C";
                        }
                        else
                        {
                            if (item.Cedula.Length == 13)
                            {
                                ItemDetalleDiscapacitados.tipoIdentificacion = "P";
                            }
                            else
                            {
                                ItemDetalleDiscapacitados.tipoIdentificacion = "F";
                                ItemDetalleDiscapacitados.identificacion = "9999999999999";
                            }
                        }
                    }
                    DetalleDiscapacitados.Add(ItemDetalleDiscapacitados);
                }



                //detalleGasto
                List<detalleGasto> DetalleGasto = new List<detalleGasto>();

                Boolean valor = false;
                foreach (var item in EGPinfo)
                {
                    detalleGasto ItemDetalleGasto = new detalleGasto();

                    ItemDetalleGasto.rucProveedor = item.Ruc;
                    ItemDetalleGasto.totalComprobantesVenta = Convert.ToDecimal(item.Num_CbteVta);
                    ItemDetalleGasto.totalBaseImponible = Convert.ToDecimal(item.Base_Imponible);
                    ItemDetalleGasto.tipoGasto = Convert.ToInt32(item.IdTipoGastos);
                    DetalleGasto.Add(ItemDetalleGasto);
                }
                if (EGPinfo.Count == 0)
                    valor = true;

                //detalleRubrosNoIdentificanProveedor
                List<detalleRubrosNoIdentificanProveedor> DetalleOGasto = new List<detalleRubrosNoIdentificanProveedor>();

                foreach (var item in EOGPinfo)
                {
                    detalleRubrosNoIdentificanProveedor ItemDetalleOGasto = new detalleRubrosNoIdentificanProveedor();

                    ItemDetalleOGasto.totalPencionesAlimenticias = Convert.ToDecimal(item.Valor_Pension_alim);
                    ItemDetalleOGasto.totalValoresAseguradoras = Convert.ToDecimal(item.Valor_no_cub_x_aseg);
                    DetalleOGasto.Add(ItemDetalleOGasto);
                }

                //
                Data.conyugueDependiente = DetalleConyugue;
                Data.hijosDependientes = Detallehijo;
                Data.discapacitadosDependientes = DetalleDiscapacitados;
                //Data.gastos = DetalleGasto;
                Data.gastos = ((valor == true) ? null : DetalleGasto);
                Data.rubrosNoIdentificanProveedor = DetalleOGasto;

                return Data;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CargaDatos", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };

                
            }

        }

        public List<ro_Empleado_Info> Get_List_Empleado_(int idempresa)
        {
           List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                     lM = oRro_Empleado_Data.Get_List_Empleado_(idempresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        
        }

        public List<ro_Empleado_Info> Get_List_Solicitud_Tarjeta(int IdEmpresa, int IdTipoNominaIni, int IdTipoNominaFin, int IdDepartamentoIni, int IdDepartamentoFin, string em_status, ref string mensaje)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                return oRro_Empleado_Data.Get_List_Solicitud_Tarjeta(IdEmpresa, IdTipoNominaIni, IdTipoNominaFin, IdDepartamentoIni, IdDepartamentoFin, em_status, ref mensaje);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public List<ro_Empleado_Info> Get_List_Empleado_Info_PorNominaSaldoNegativo(int IdEmpresa, int IdNominaTipo)
        {
            try{

                return oRro_Empleado_Data.Get_List_Empleado_Info_PorNominaSaldoNegativo(IdEmpresa, IdNominaTipo);
            }catch (Exception ex){
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Info_PorNominaSaldoNegativo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

    public List<ro_Empleado_Info> Get_List_Empleado_x_Nomina(int IdEmpresa)
    {
        try
        {

            return oRro_Empleado_Data.Get_List_Empleado_x_Nomina(IdEmpresa);
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_x_Nomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
        }

    }

   
        

    public List<ro_Empleado_Info> Get_List_Empleado_x_Nomina(int IdEmpresa,int IdTipoNomina)
    {
        try
        {

            return oRro_Empleado_Data.Get_List_Empleado_x_Nomina(IdEmpresa, IdTipoNomina);
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_x_Nomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
        }

    }

        public List<ro_Empleado_Info> Get_List_Empleado_x_NominaSueldoDigno(int IdEmpresa, int IdNominaTipo, double sueldoDigno, int anio)
    {
        try
        {
            return oRro_Empleado_Data.Get_List_Empleado_x_NominaSueldoDigno(IdEmpresa, IdNominaTipo, sueldoDigno,anio );
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_x_NominaSueldoDigno", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
        }

    }

        public List<ro_Empleado_Info>  GetListConsultaUtilidad(int idEmpresa, int anio)
    {
        try
        {
            List<ro_Empleado_Info> listado = new List<ro_Empleado_Info>();
            ro_Rol_Bus oRo_Rol_Bus = new ro_Rol_Bus();
            ro_CargaFamiliar_Bus oRo_CargaFamiliar_Bus = new Roles.ro_CargaFamiliar_Bus();
          

            DateTime fechaInicial = Convert.ToDateTime("01/01/"+anio.ToString());
            DateTime fechaFinal = Convert.ToDateTime("31/12/" + anio.ToString());


            listado=oRro_Empleado_Data.GetListConsultaUtilidad(idEmpresa, anio);

             
            foreach(ro_Empleado_Info item in listado)
            {
                item.diasTrabajo = oRo_Rol_Bus.GetDiasTrabajados360(idEmpresa, Convert.ToDateTime(item.em_fecha_ingreso), fechaInicial, fechaFinal);
                item.cargas = oRo_CargaFamiliar_Bus.pu_TotalCargasParaCalculoUtilidad(idEmpresa, item.IdEmpleado);
            
            
            }

            return listado;
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaUtilidad", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
        }

    }

        private Boolean Get_ValidarSaldoNegativoExpleadoXNomina(int idEmpresa,decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo,ref string msg) { 
        try
        {
            Boolean valorRetornar = false;

            ro_Rol_Detalle_Bus oRo_Rol_Detalle_Bus = new ro_Rol_Detalle_Bus();
            List<ro_Rol_Detalle_Info> oListRo_Rol_Detalle_Info = new List<ro_Rol_Detalle_Info>();

            oListRo_Rol_Detalle_Info = oRo_Rol_Detalle_Bus.GetListConsultaPorRolEmpleado(idEmpresa, idEmpleado, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref msg);

            foreach(ro_Rol_Detalle_Info item in oListRo_Rol_Detalle_Info)
            {
                if(item.Valor<0)
                {
                    valorRetornar = true;
                    break;
                }
            }




            return valorRetornar;
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ValidarSaldoNegativoExpleadoXNomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
    }
    }

        public ro_Empleado_Info Get_Info_Empleado_x_IdEmpleado(int IdEmpresa, decimal IdEmpleado)
    {
        try
        {
            return oRro_Empleado_Data.Get_Info_Empleado_x_IdEmpleado(IdEmpresa, IdEmpleado);
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_x_IdEmpleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
        }

    }

    public List<ro_Empleado_Info> Get_List_Empleado_Info_PorNominaSaldoNegativo(int IdEmpresa, int IdNominaTipo, int IdNominaTipoLiqui, int IdPeriodo, ref string msg)
    {
            try
            {
                List<ro_Empleado_Info> listado = new List<ro_Empleado_Info>();
                listado = oRro_Empleado_Data.Get_List_Empleado_Info_PorNominaSaldoNegativo(IdEmpresa, IdNominaTipo);

                foreach (ro_Empleado_Info item in listado)
                {
                    if (Get_ValidarSaldoNegativoExpleadoXNomina(item.IdEmpresa, item.IdEmpleado, IdNominaTipo, IdNominaTipoLiqui, IdPeriodo, ref msg))
                    {
                        item.checkSaldoNegativo = true;
                    }
                    else
                    {
                        item.checkSaldoNegativo = false;
                    }
                }
                return listado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Info_PorNominaSaldoNegativo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
    }

        public bool Eliminar_Empleados(int idempresa, ref string message)
    {
        try
        {
            return oRro_Empleado_Data.Eliminar_Empleados(idempresa, ref message);
        }
        catch (Exception ex)
        {
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_Empleados", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
        }
    }

        public List<ro_Empleado_Info> Get_List_Empleado_x_Empresa(int IdEmpresa)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                lM = oRro_Empleado_Data.Get_List_Empleado_x_Empresa(IdEmpresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public List<ro_Empleado_Info> Get_List_Empleado(int IdEmpresa, DateTime Fecha_inicio, DateTime Fecha_fin)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                lM = oRro_Empleado_Data.Get_List_Empleado(IdEmpresa, Fecha_inicio, Fecha_fin);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public List<ro_Empleado_Info> Get_Lis_Empleado_x_Departamento(int IdEmpresa, int IdDepartamento)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                lM = oRro_Empleado_Data.Get_Lis_Empleado_x_Departamento(IdEmpresa, IdDepartamento);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lis_Empleado_x_Departamento", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public List<ro_Empleado_Info> Get_Lis_Empleado(int IdEmpresa, ro_Empleado_Info oRo_Empleado_Info)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                lM = oRro_Empleado_Data.Get_Lis_Empleado(IdEmpresa, oRo_Empleado_Info);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lis_Empleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public ro_Empleado_Info Get_Info_Empleado_x_Persona(int idEmpresa, decimal idPersona)
        {
            try
            {
                return oRro_Empleado_Data.Get_Info_Empleado_x_Persona(idEmpresa, idPersona);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_x_Persona", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public List<ro_Empleado_Info> Get_List_Empleados_x_Periodo(int idempresa, int idperiodo)
        {
                List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                lM = oRro_Empleado_Data.Get_List_Empleados_x_Periodo(idempresa, idperiodo);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleados_x_Periodo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public List<ro_Empleado_Info> Get_List_EmpleadosVacaciones(int IdEmpresa, DateTime Fecha)
        {
            try
            {
                return oRro_Empleado_Data.Get_List_EmpleadosVacaciones(IdEmpresa, Fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_EmpleadosVacaciones", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public List<ro_Empleado_Info> Get_List_Empleados_Decimos(int IdEmpresa, int IdNomina_Tipo, string IdRubro, int IdPeriodoIni, int IdPeriodoFin)
        {
                List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                lM = oRro_Empleado_Data.Get_List_Empleados_Decimos(IdEmpresa, IdNomina_Tipo, IdRubro, IdPeriodoIni, IdPeriodoFin);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleados_Decimos", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        
        
        
        
        }

        public ro_Empleado_Info Get_Info_Empleado(int IdEmpresa, decimal IdEmpleado)
        {
                ro_Empleado_Info empleadoInfo = new ro_Empleado_Info();
            try
            {
                empleadoInfo = oRro_Empleado_Data.Get_Info_Empleado(IdEmpresa, IdEmpleado);
                return (empleadoInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public Boolean ModificarDB(ro_Empleado_Info info, ref string message)
        {
                try
                {
                    info.IdUsuarioUltModi = param.IdUsuario;
                    info.Fecha_UltMod = param.Fecha_Transac;
                    return oRro_Empleado_Data.ModificarDB(info, ref message);
                }
                catch (Exception ex)
                {
                    Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
                }

        }

        public Boolean ModificarDB(int IdEmpresa,int IdEmpleado, DateTime FechaRol,DateTime FechaIng)
        {
            try
            {
                
                return oRro_Empleado_Data.ModificarDB(IdEmpresa,IdEmpleado,FechaRol,FechaIng);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                return oRro_Empleado_Data.GetId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            } 
         
        }

        public Boolean AnularDB(ro_Empleado_Info info, ref string message)
        {
            try
            {
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = param.Fecha_Transac;


                return oRro_Empleado_Data.AnularDB(info, ref message);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public List<ro_Empleado_Info> Get_List_Empleado_persona(int IdEmpresa)
        {

            try
            {
                return oRro_Empleado_Data.Get_List_Empleado_persona(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_persona", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public Boolean ExisteEmpleado(int idempresa, decimal idpersona)
        {

            try
            {
                return oRro_Empleado_Data.ExisteEmpleado(idempresa, idpersona);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteEmpleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public ro_Empleado_Info Get_Info_Empleado_vs_Persona(int IdEmpresa, decimal IdPersona)
        {
            ro_Empleado_Info empleadoInfo = new ro_Empleado_Info();
            try
            {


                empleadoInfo = oRro_Empleado_Data.Get_Info_Empleado_vs_Persona(IdEmpresa, IdPersona);
                return (empleadoInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_vs_Persona", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }
   
        public List<ro_Empleado_Info> ConsultaEmpleadosxDep(int IDEmpresa, int IdDepartamento)
        {
                

            try
            {
                return oRro_Empleado_Data.ConsultaEmpleadosxDep(IDEmpresa, IdDepartamento);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaEmpleadosxDep", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }
        
        public List<ro_Empleado_Info> ProcesarDataTableRo_Empleado_Info(DataTable ds, int idempresa,int idsucursal, ref string MensajeError)
        {
            try
            {

                return oRro_Empleado_Data.ProcesarDataTableRo_Empleado_Info(ds, idempresa, idsucursal, ref MensajeError);                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        private Boolean GrabarDetalleBD(ro_Empleado_Info info)
        {
            try
            {
                ro_DocumentoxEmp_Bus DocBus = new ro_DocumentoxEmp_Bus();
               
                ////GUARDA DOCUMENTOS
                if (info.oListRo_DocumentoxEmp_Info.Count > 0)
                {

                    if (!DocBus.GuardarDB(info.oListRo_DocumentoxEmp_Info))
                    {
                        return false;
                    }

                }

                //GUARDA LAS CARGAS FAMILIARES
                if (info.oListRo_CargaFamiliar_Info.Count>0) {
                    oRo_CargaFamiliar_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, ref mensaje);
                    foreach (ro_CargaFamiliar_Info oRro_CargaFamiliar_Info in info.oListRo_CargaFamiliar_Info)
                    {
                        oRro_CargaFamiliar_Info.IdEmpleado = info.IdEmpleado;
                        if (!oRo_CargaFamiliar_Bus.GrabarBD(oRro_CargaFamiliar_Info, ref mensaje)) { return false; }
                    }
                }
                //GUARDA LOS TITULOS
                if (info.oListRo_empleado_x_titulos_Info.Count>0)
                {
                    oRo_empleado_x_titulos_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, ref mensaje);
                    foreach (ro_empleado_x_titulos_Info oRo_empleado_x_titulos_Info in info.oListRo_empleado_x_titulos_Info)
                    {
                        oRo_empleado_x_titulos_Info.IdEmpleado = info.IdEmpleado;
                        if (!oRo_empleado_x_titulos_Bus.GrabarDB(oRo_empleado_x_titulos_Info, ref mensaje)) { return false; }
                    }
                }
                //GUARDA LOS ESTUDIOS
                if (info.oListRo_Empleado_estudios_Info.Count>0)
                {
                    oRo_Empleado_estudios_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, ref mensaje);
                    foreach (ro_Empleado_estudios_Info oRo_Empleado_estudios_Info in info.oListRo_Empleado_estudios_Info)
                    {
                        oRo_Empleado_estudios_Info.IdEmpleado = info.IdEmpleado;
                        oRo_Empleado_estudios_Info.IdEmpresa = info.IdEmpresa;
                        if (!oRo_Empleado_estudios_Bus.GrabarDB(oRo_Empleado_estudios_Info, ref mensaje)) { return false; }
                    }
                }
                
                //GUARDA PROYECCION GASTOS PERSONALES
                if (info.oListRo_empleado_x_Proyeccion_Gastos_Personales_Info.Count>0)
                {
                    foreach (ro_empleado_x_Proyeccion_Gastos_Personales_Info oRo_empleado_x_Proyeccion_Gastos_Personales_Info in info.oListRo_empleado_x_Proyeccion_Gastos_Personales_Info)
                    {
                        oRo_empleado_x_Proyeccion_Gastos_Personales_Info.IdEmpleado = info.IdEmpleado;

                        if (!oRo_empleado_x_Proyeccion_Gastos_Personales_Bus.GrabarBD(oRo_empleado_x_Proyeccion_Gastos_Personales_Info, ref mensaje)) { return false; }
                    }
                }

                //BORRA DE LA B/D REGISTROS PREVIOS
                
                    oRo_empleado_x_rubro_acumulado_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, ref mensaje);

                    //GUARDA LOS RUBROS ACUMULADOS
                    foreach (ro_empleado_x_rubro_acumulado_Info oRo_empleado_x_rubro_acumulado_Info in info.oListRo_empleado_x_rubro_acumulado_Info)
                    {
                        oRo_empleado_x_rubro_acumulado_Info.IdEmpresa = info.IdEmpresa;
                        oRo_empleado_x_rubro_acumulado_Info.IdEmpleado = info.IdEmpleado;

                        if (!oRo_empleado_x_rubro_acumulado_Bus.GrabarBD(oRo_empleado_x_rubro_acumulado_Info, ref mensaje)) { return false; }
                    }
                

                //GUARDA LOS CENTROS DE COSTO DEL EMPLEADO
                if (info.oListro_empleado_x_centro_costo_Info.Count > 0)
                {
                    //BORRA DE LA B/D REGISTROS PREVIOS
                    oRo_empleado_x_centro_costo_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, ref mensaje);
                    foreach (ro_empleado_x_centro_costo_Info oRo_empleado_x_centro_costo_Info in info.oListro_empleado_x_centro_costo_Info)
                    {
                        oRo_empleado_x_centro_costo_Info.IdEmpresa = info.IdEmpresa;
                        oRo_empleado_x_centro_costo_Info.IdEmpleado = info.IdEmpleado;

                        if (!oRo_empleado_x_centro_costo_Bus.GrabarBD(oRo_empleado_x_centro_costo_Info, ref mensaje)) 
                        { 
                            return false; 
                        }
                    }
                }

                //GUARDA LAS NOMINAS X EMPLEADO
                if (info.oListRo_Empleado_TipoNomina_Info.Count > 0)
                {
                    //BORRA DE LA B/D REGISTROS PREVIOS
                    ro_Empleado_TipoNomina_Info tmp = new ro_Empleado_TipoNomina_Info();
                    tmp = info.oListRo_Empleado_TipoNomina_Info.FirstOrDefault();
                    oRo_Empleado_TipoNomina_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, ref mensaje);

                    //GUARDA LA NOMINA
                    foreach (ro_Empleado_TipoNomina_Info oRo_Empleado_TipoNomina_Info in info.oListRo_Empleado_TipoNomina_Info)
                    {
                        oRo_Empleado_TipoNomina_Info.IdEmpresa = info.IdEmpresa;
                        oRo_Empleado_TipoNomina_Info.IdEmpleado = info.IdEmpleado;

                        if (!oRo_Empleado_TipoNomina_Bus.GrabarDB(oRo_Empleado_TipoNomina_Info, ref mensaje)) { return false; }
                    }
                }


                //GUARDA LOS RUBROS FIJOS
                if (info.oListRo_empleado_x_ro_rubro_Info.Count > 0)
                {
                    //BORRA DE LA B/D REGISTROS PREVIOS
                    ro_empleado_x_ro_rubro_Info tmp = new ro_empleado_x_ro_rubro_Info();
                    tmp = info.oListRo_empleado_x_ro_rubro_Info.FirstOrDefault();
                    oRo_empleado_x_ro_rubro_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, tmp.IdNomina_Tipo, tmp.IdNomina_TipoLiqui, ref mensaje);

                    foreach (ro_empleado_x_ro_rubro_Info oRo_empleado_x_ro_rubro_Info in info.oListRo_empleado_x_ro_rubro_Info)
                    {
                        oRo_empleado_x_ro_rubro_Info.IdEmpleado = info.IdEmpleado;
                        oRo_empleado_x_ro_rubro_Info.IdEmpresa = info.IdEmpresa;
                        if (!oRo_empleado_x_ro_rubro_Bus.GrabarBD(oRo_empleado_x_ro_rubro_Info, ref mensaje)) { return false; }
                    }
                }



                //BORRA DE LA B/D REGISTROS PREVIOS                
                oRo_Empleado_X_Horario_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, ref mensaje);
                //GUARDA LOS HORARIOS
                foreach (ro_Empleado_X_Horario_Info oRo_Empleado_X_Horario_Info in info.oListRo_Empleado_X_Horario_Info)
                {
                    oRo_Empleado_X_Horario_Info.IdEmpleado = info.IdEmpleado;
                    oRo_Empleado_X_Horario_Info.IdEmpresa = info.IdEmpresa;
                    if (!oRo_Empleado_X_Horario_Bus.GrabarBD(oRo_Empleado_X_Horario_Info, ref mensaje)) { return false; }
                }

                // graba capacitaciones
                ro_Capacitaciones_x_Empleado_Bus buscapacitaciones= new ro_Capacitaciones_x_Empleado_Bus();
                if (buscapacitaciones.EliminarDB(info.ListCapacitaciones))
                {
                    foreach (var item in info.ListCapacitaciones)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        
                    }
                    buscapacitaciones.GuardarDB(info.ListCapacitaciones);
                }


               return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDetalleBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        
        
        }

        public Boolean GrabarDB(ro_Empleado_Info info, ref decimal idEmpleado, ref decimal idPersona_, ref string message)
        {
            try
            {
                Boolean valorRetornar = false;
                decimal idPersona=0;


                //MODIFICA EL EMPLEADO
                if (oRro_Empleado_Data.GetExiste(info, ref message))
                {
                    info.IdUsuarioUltModi = param.IdUsuario;
                    info.Fecha_UltMod = param.Fecha_Transac;
                    idEmpleado = info.IdEmpleado;
                    info.IdPersona = info.IdPersona;
                    //GUARDA PERSONA
                    if (oTb_persona_bus.GrabarDB(info.InfoPersona,ref idPersona, ref message))
                    {
                        //GUARDA EMPLEADO
                        if (oRro_Empleado_Data.ModificarDB(info, ref message))
                        {
                            //GUARDA EL DETALLE
                            valorRetornar=GrabarDetalleBD(info);
                        }
                    }

                }
                else
                {//NUEVO REGISTRO DEL EMPLEADO

                    //GUARDA PERSONA
                    if (oTb_persona_bus.GrabarDB(info.InfoPersona, ref idPersona, ref message))
                    {
                        info.IdUsuario = param.IdUsuario;
                        info.Fecha_Transaccion = param.Fecha_Transac;
                        info.IdUsuarioUltModi = param.IdUsuario;
                        info.Fecha_UltMod = param.Fecha_Transac;
                        info.IdPersona = idPersona;
                        //GUARDA EMPLEADO
                        if (oRro_Empleado_Data.GrabarDB(info, ref idEmpleado, ref message))
                        {
                            info.IdEmpleado = idEmpleado;

                            ro_HistoricoSueldo_Bus BusH = new ro_HistoricoSueldo_Bus();
                            info.InfoSueldo.IdEmpleado = idEmpleado;

                            BusH.GrabarDB(info.InfoSueldo, ref message);

                            //GUARDA EL DETALLE
                            valorRetornar = GrabarDetalleBD(info);
                        }
                    }
                }
                idPersona_ = idPersona;
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public ro_Empleado_Info GetInfoConsultaPorIdEmpleado(int idEmpresa, decimal idEmpleado)
        {
            try
            {
                return oRro_Empleado_Data.GetInfoConsultaPorIdEmpleado(idEmpresa, idEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoConsultaPorIdEmpleado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        private Boolean pu_ValidarXML() {
            try 
            {
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarXML", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public string pu_Right(string str, int length)
        {
            try
            {
                return str.Substring(str.Length - length, length);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_Right", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public rdep setInfoXML(List<ro_Empleado_Info> info,string ruc, int idPeriodo)
        {
            try
            {

                tb_Sucursal_Bus oTb_Sucursal_Bus = new tb_Sucursal_Bus();
                tb_Sucursal_Info oTb_Sucursal_Info = new Info.General.tb_Sucursal_Info();
                oTb_Sucursal_Info = oTb_Sucursal_Bus.Get_Info_Sucursal(param.IdEmpresa, param.IdSucursal);

                //CAMBIAR LA CULTURA REGIONAL PARA SETEAR EL PUNTO DECIMAL
                System.Threading.Thread.CurrentThread.CurrentCulture =System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

                //DATOS DE LA EMPRESA
                rdep oRdep = new rdep();
                oRdep.anio = idPeriodo.ToString();
                oRdep.numRuc = ruc;

                oRdep.retRelDep = new List<rdepRetRelDepDatRetRelDep>();

                foreach (ro_Empleado_Info item in info)
                {
                    rdepRetRelDepDatRetRelDep detalleRDEP = new rdepRetRelDepDatRetRelDep();

                    detalleRDEP.empleado = new List<rdepRetRelDepDatRetRelDepEmpleado>();
                    rdepRetRelDepDatRetRelDepEmpleado datosEmpleado = new rdepRetRelDepDatRetRelDepEmpleado();

                    //Tipo de identificación del trabajador
                    switch (item.InfoPersona.IdTipoDocumento)
                    {
                        case "CED":
                            datosEmpleado.tipIdRet = "C";

                            break;

                        case "PAS":
                            datosEmpleado.tipIdRet = "P";
                            break;
                        default:
                            //Identificación Tributaria del Exterior 
                            datosEmpleado.tipIdRet = "E";
                            break;
                    }

                    //Número de identificación del trabajador
                   datosEmpleado.idRet = item.InfoPersona.pe_cedulaRuc;

                    //Apellidos del trabajador
                   datosEmpleado.apellidoTrab = item.InfoPersona.pe_apellido;

                    //Nombres del trabajador
                   datosEmpleado.nombreTrab = item.InfoPersona.pe_nombre;

                    //Código del establecimiento

                   datosEmpleado.estab = oTb_Sucursal_Info.Su_CodigoEstablecimiento;

                    //Residencia del trabajador
                   if (item.IdTipoResidenciaSRI != null)
                   {
                       datosEmpleado.residenciaTrab = pu_Right(item.IdTipoResidenciaSRI, 2);
                   }
                   else
                   {
                       datosEmpleado.residenciaTrab = "01";

                   }

                    //País de residencia del trabajador
                   datosEmpleado.paisResidencia = "593";

                    //Aplica convenio para evitar doble imposición
                   if (item.IdAplicaConvenioDobleImposicionSRI != null)
                   {
                       datosEmpleado.aplicaConvenio = pu_Right(item.IdAplicaConvenioDobleImposicionSRI, 2);
                   }
                   else
                   {
                       datosEmpleado.aplicaConvenio = "NO";
                   }

                    //Condición del trabajador respecto a discapacidades
                    //if (item.em_empEspecial == "S") {datosEmpleado.tipoTrabajDiscap = "02"; } else {datosEmpleado.tipoTrabajDiscap = "01"; }
                 //  datosEmpleado.tipoTrabajDiscap = pu_Right(item.IdCondicionDiscapacidadSRI, 2); 

                    //Porcentaje de discapacidad
                   datosEmpleado.porcentajeDiscap = item.por_discapacidad.ToString();

                    //Tipo de identificación de la persona con discapacidad a quien sustituye o representa
                   if (item.IdTipoIdentDiscapacitadoSustitutoSRI != null)
                   {
                       datosEmpleado.tipIdDiscap = pu_Right(item.IdTipoIdentDiscapacitadoSustitutoSRI, 1);
                   }
                   else
                   {
                       datosEmpleado.tipIdDiscap = "N";
                   }

                    //Número de identificación de la persona con discapacidad a quien sustituye o representa
                   datosEmpleado.idDiscap = item.IdentDiscapacitadoSustitutoSRI;

                    //AGREGAR DATOS DEL DETALLE DE EMPLEADOS
                   detalleRDEP.empleado.Add(datosEmpleado);



                    //Sueldos y salarios
                   detalleRDEP.suelSal = item.totSueldo.ToString("F2");

                    //Sobresueldos, comisiones, bonos y otros ingresos gravados
                   detalleRDEP.sobSuelComRemu = (item.totComision + item.totHoraExtra).ToString("F2") ;

                    //Participación de utilidades
                    detalleRDEP.partUtil = item.totUtilidad.ToString("F2");
                    
                    //Ingresos gravados generados con otros empleadores
                    detalleRDEP.intGrabGen = "0.00"; ///AQUI INGRESAR MANUALMENTE

                    //Impuesto a la renta asumido por este empleador
                    detalleRDEP.impRentEmpl = "0.00"; //AQUI REVISAR EL CALCULO

                    //Décimo tercer sueldo
                    detalleRDEP.decimTer = item.totDecimoTercer.ToString("F2");
                    
                    //Décimo cuarto sueldo
                    detalleRDEP.decimCuar = item.totDecimoCuarto.ToString("F2");
                    
                    //Fondo de reserva
                    detalleRDEP.fondoReserva = item.totFondoReserva.ToString("F2");
                    
                    //Compensación Económica Salario Digno
                    detalleRDEP.salarioDigno = item.totSueldoDigno.ToString("F2");
                    
                    //Otros ingresos en relación de dependencia que no constituyen renta gravada
                    detalleRDEP.otrosIngRenGrav = "0.00";  ///AQUI INGRESAR MANUALMENTE

                    //Ingresos gravados con este empleador (Informativo)
                    detalleRDEP.ingGravConEsteEmpl = "0.00";  ///AQUI INGRESAR MANUALMENTE

                    //Sistema de salario neto
                    detalleRDEP.sisSalNet = "0.00";     //AQUI REVISAR EL CALCULO

                    //Aporte personal al IESS con este empleador (únicamente pagado por el trabajador)
                    detalleRDEP.apoPerIess = item.totIESS.ToString("F2");

                    //Aporte personal al IESS con otros empleadores (únicamente pagado por el trabajador)
                    detalleRDEP.aporPerIessConOtrosEmpls = "0.00";   ///AQUI INGRESAR MANUALMENTE

                   
                    //*****************DEDUCCION POR GASTOS PERSONALES***********************

                    //Deducción de gastos personales por Vivienda
                    detalleRDEP.deducVivienda = item.totGastoVivienda.ToString("F2");

                    //Deducción de gastos personales por Salud
                    detalleRDEP.deducSalud = item.totGastoSalud.ToString("F2");

                    //Deducción de gastos personales por Educación
                    detalleRDEP.deducEduca = item.totGastoEducacion.ToString("F2");

                    //Deducción de gastos personales por Alimentación
                    detalleRDEP.deducAliement = item.totGastoAlimentacion.ToString("F2"); ;

                    //Deducción de gastos personales por Vestimenta
                    //detalleRDEP. = "0.00";

                    //*************************************************************************
                                        
                    
                    //Exoneración por Discapacidad
                    detalleRDEP.exoDiscap = "0.00";     //AQUI REVISAR EL CALCULO

                    //Exoneración por Tercera Edad
                    detalleRDEP.exoTerEd = "0.00";      //AQUI REVISAR EL CALCULO

                    //Base imponible gravada
                    detalleRDEP.basImp = "0.00";

                    //Impuesto a la renta causado
                    detalleRDEP.impRentCaus = "0.00";

                    //Valor del impuesto retenido y asumido por otros empleadores durante el período declarado
                    detalleRDEP.valRetAsuOtrosEmpls = "0.00";       ///AQUI INGRESAR MANUALMENTE

                    //Valor del impuesto asumido por este empleador
                    detalleRDEP.valImpAsuEsteEmpl = "0.00";         

                    //Valor del impuesto retenido al trabajador por este empleador
                    detalleRDEP.valRet = "0.00";

                    oRdep.retRelDep.Add(detalleRDEP);
                }

                return oRdep;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "setInfoXML", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public Boolean pu_GenerarXMLRDEP(int idEmpresa, int idPeriodo, string RutaDescarga, ref string msg)
        {
            try {
                Boolean valorRetornar = false;

                //OBTIENE LOS DATOS DE LA EMPRESA
                tb_Empresa_Bus oTb_Empresa_Bus = new Business.General.tb_Empresa_Bus();
                tb_Empresa_Info oTb_Empresa_Info = new tb_Empresa_Info();
                
                oTb_Empresa_Info = oTb_Empresa_Bus.Get_Info_Empresa(idEmpresa);

                //OBTIENE LOS DATOS DE LOS EMPLEADOS
                List<ro_Empleado_Info> listadoEmpleado = new List<ro_Empleado_Info>();
                listadoEmpleado = GetListConsultaPorPeriodoRDEP(idEmpresa, idPeriodo);



                //CONVIERTE LA CONSULTA EN EL OBJETO PARA EL XML
                rdep oRdep = new rdep();
                oRdep = setInfoXML(listadoEmpleado, oTb_Empresa_Info.em_ruc.Trim(), idPeriodo);

                if (oRdep != null)
                {
                    string idRdep = oTb_Empresa_Info.em_nombre.Trim() + idPeriodo.ToString();
                  RutaDescarga="C:/"; //AQUI REVISAR LA RUTA


                    XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                    NamespaceObject.Add("", "");
                    XmlSerializer mySerializer = new XmlSerializer(typeof(rdep));
                    StreamWriter myWriter = new StreamWriter(RutaDescarga + "RDEP_"+idRdep + ".xml");
                    mySerializer.Serialize(myWriter, oRdep, NamespaceObject);
                    myWriter.Close();

                    return true;
                  
                
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GenerarXMLRDEP", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }        
        }

        public List<ro_Empleado_Info> GetListConsultaPorPeriodoRDEP(int idEmpresa, int idPeriodo)
        {
            try
            {
                return oRro_Empleado_Data.GetListConsultaPorPeriodoRDEP(idEmpresa, idPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorPeriodoRDEP", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public ro_Empleado_Info GetInfoPorEmpleadoRDEP(int idEmpresa,decimal idEmpleado, int anioFiscal, ref string msg)
        {
            try
            {
                return oRro_Empleado_Data.GetInfoPorEmpleadoRDEP(idEmpresa,idEmpleado, anioFiscal, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoPorEmpleadoRDEP", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public List<ro_Empleado_Info> GetListPorNovedadAvisoEntrada(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal)
     {
         try
         {
             return oRro_Empleado_Data.GetListPorNovedadAvisoEntrada(idEmpresa, fechaInicial, fechaFinal);
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorNovedadAvisoEntrada", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
         }
     }

        public List<ro_Empleado_Info> GetListPorNovedadAvisoSalida(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal)
     {
         try
         {
             return oRro_Empleado_Data.GetListPorNovedadAvisoSalida(idEmpresa, fechaInicial, fechaFinal);
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorNovedadAvisoSalida", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
         }
     }
     
        public List<ro_Empleado_Info> GetListPorNovedadAvisoNuevoSueldo(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal)
     {
         try
         {
             return oRro_Empleado_Data.GetListPorNovedadAvisoNuevoSueldo(idEmpresa, fechaInicial, fechaFinal);
         }
         catch (Exception ex)
         {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorNovedadAvisoNuevoSueldo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
         }
     }


        public List<ro_Empleado_Info> Get_Lis_Empleado_x_Periodo_Nomina(int IdEmpresa, int idNominaTipo, int IdnominaTipo_liq, int IdPeriodo)
        {
            try
            {
                return oRro_Empleado_Data.Get_Lis_Empleado_x_Periodo_Nomina(IdEmpresa, idNominaTipo, IdnominaTipo_liq, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorNovedadAvisoNuevoSueldo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        public List<ro_Empleado_Info> Obtener_Empleados(int idEmpresa)
        {
            try
            {return oRro_Empleado_Data.Obtener_Empleados(idEmpresa);
            }
            catch (Exception ex)
            {
                
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorNovedadAvisoNuevoSueldo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };

            }
        }






        public List<ro_Empleado_Info> Get_List_Empleado_x_Nomina_Liquidar(int idEmpresa, int IdTipoNomina, ro_periodo_x_ro_Nomina_TipoLiqui_Info Periodo)
        {
            try
            {

                return oRro_Empleado_Data.Get_List_Empleado_x_Nomina_Liquidar(idEmpresa, IdTipoNomina,Periodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_x_Nomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }


        public double GetSueldoActual(int idEmpresa, decimal idEmpleado)
        {
            try
            {

                return oRro_Empleado_Data.GetSueldoActual(idEmpresa, idEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }


        public Boolean Modificar_Estado(int IdEmpresa, int IdEmpleado, string em_status)
        {
            try
            {

                return oRro_Empleado_Data.Modificar_Estado(IdEmpresa, IdEmpleado, em_status);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }


        // fj




        public List<ro_Empleado_Info> get_lista_emp_con_sueldo_actual_para_calculo_HE(int IdEmpresa)
        {
            try
            {

                return oRro_Empleado_Data.get_lista_emp_con_sueldo_actual_para_calculo_HE(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_x_Nomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        public List<ro_Empleado_Info> Get_list_empleado_sin_registro_asistencia(int IdEmpresa, int IdNomina_tipo, DateTime Fecha, int IdDivision)
        {
            try
            {

                return oRro_Empleado_Data.Get_list_empleado_sin_registro_asistencia(IdEmpresa, IdNomina_tipo, Fecha, IdDivision);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_x_Nomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }
        public List<ro_Empleado_Info> Get_list_empleado_sin_registro_asistencia_eventuiales(int IdEmpresa, int IdNomina_tipo, DateTime Fecha)
        {
            try
            {

                return oRro_Empleado_Data.Get_list_empleado_sin_registro_asistencia_eventuiales(IdEmpresa, IdNomina_tipo, Fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_x_Nomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }
        }

        
    }
}
