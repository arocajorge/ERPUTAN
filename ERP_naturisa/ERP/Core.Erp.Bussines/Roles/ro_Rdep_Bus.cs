/*CLASE: ro_Rdep_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 05-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.class_sri.RDEP;

using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Core.Erp.Business.Roles
{
   public  class ro_Rdep_Bus
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

       //INFO
        List<ro_tabla_Impu_Renta_Info> oListRo_tabla_Impu_Renta_Info = new List<ro_tabla_Impu_Renta_Info>();

       //DATA
        ro_Rdep_Data oData = new ro_Rdep_Data();

       //BUS
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_Tabla_Impu_Renta_Bus oRo_Tabla_Impu_Renta_Bus = new ro_Tabla_Impu_Renta_Bus();


       //oRo_Tabla_Impu_Renta_Bus.ConsultaTablaImpuAnio(anioFiscal)

       //CONSTRUCTOR
        public ro_Rdep_Bus() { }



        public List<ro_Rdep_Info>  GetListGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.GetListGeneral(idEmpresa,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListGeneral", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
            }
        }

        public ro_Rdep_Info GetInfoPorEmpleado(int idEmpresa, decimal idEmpleado, int anioFiscal, ref string msg)
        {
            try
            {
                return oData.GetInfoPorEmpleado(idEmpresa, idEmpleado, anioFiscal, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
            }
        }


        public Boolean GetExiste(ro_Rdep_Info info, ref string msg)
        {
            try
            {
                return oData.GetExiste(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetExiste", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
            }
        }




        public Boolean GuardarBD(ro_Rdep_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
           
                //MODIFICAR
                if(oData.GetExiste(info, ref msg)){

                    info.UsuarioModifica = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;

                    valorRetornar = oData.ModificarBD(info, ref msg);
                }else{//GRABAR
                    info.Estado = "A";
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;
                    info.UsuarioModifica = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;

                    valorRetornar = oData.GuardarBD(info, ref msg);                
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
            }
        }



        public int CalcularAniosDeDiferencia(DateTime primerFecha, DateTime segundaFecha)
        {
            return Math.Abs(primerFecha.Year - segundaFecha.Year);
        }


       public ro_Rdep_Info setInfoRdep(int idEmpresa,decimal idEmpleado, int anioFiscal, ref string msg)
        {
            try
            {
                ro_Rdep_Info oRo_Rdep_Info = new Info.Roles.ro_Rdep_Info();

                ro_Empleado_Data oRo_Empleado_Bus = new ro_Empleado_Data();
                ro_Empleado_Info oRo_Empleado_Info = new ro_Empleado_Info();

                oRo_Empleado_Info = oRo_Empleado_Bus.GetInfoPorEmpleadoRDEP(idEmpresa, idEmpleado, anioFiscal, ref msg);


                oRo_Rdep_Info.IdEmpleado = oRo_Empleado_Info.IdEmpleado;
                oRo_Rdep_Info.IdEmpresa = oRo_Empleado_Info.IdEmpresa;
                oRo_Rdep_Info.AnioFiscal = anioFiscal;
                oRo_Rdep_Info.FechaIngresa = param.Fecha_Transac;

                oRo_Rdep_Info.CedulaRuc = oRo_Empleado_Info.InfoPersona.pe_cedulaRuc;

                //Sueldos y salarios
                oRo_Rdep_Info.suelSal = oRo_Empleado_Info.totSueldo.ToString("F2");

                //Sobresueldos, comisiones, bonos y otros ingresos gravados
                oRo_Rdep_Info.sobSuelComRemu = (oRo_Empleado_Info.totComision + oRo_Empleado_Info.totHoraExtra).ToString("F2");

                //Participación de utilidades
                oRo_Rdep_Info.partUtil = oRo_Empleado_Info.totUtilidad.ToString("F2");

                //Ingresos gravados generados con otros empleadores
                oRo_Rdep_Info.intGrabGen = "0.00"; ///AQUI INGRESAR MANUALMENTE

                //Impuesto a la renta asumido por este empleador
                oRo_Rdep_Info.impRentEmpl = "0.00"; //AQUI REVISAR EL CALCULO

                //Décimo tercer sueldo
                oRo_Rdep_Info.decimTer = oRo_Empleado_Info.totDecimoTercer.ToString("F2");

                //Décimo cuarto sueldo
                oRo_Rdep_Info.decimCuar = oRo_Empleado_Info.totDecimoCuarto.ToString("F2");

                //Fondo de reserva
                oRo_Rdep_Info.fondoReserva = oRo_Empleado_Info.totFondoReserva.ToString("F2");

                //Compensación Económica Salario Digno
                oRo_Rdep_Info.salarioDigno = oRo_Empleado_Info.totSueldoDigno.ToString("F2");

                //Otros ingresos en relación de dependencia que no constituyen renta gravada
                oRo_Rdep_Info.otrosIngRenGrav = "0.00";  ///AQUI INGRESAR MANUALMENTE

                //Ingresos gravados con este empleador (Informativo)
                oRo_Rdep_Info.ingGravConEsteEmpl = "0.00";  ///AQUI INGRESAR MANUALMENTE

                //Sistema de salario neto
                oRo_Rdep_Info.sisSalNet = "0.00";     //AQUI REVISAR EL CALCULO

                //Aporte personal al IESS con este empleador (únicamente pagado por el trabajador)
                oRo_Rdep_Info.apoPerIess = oRo_Empleado_Info.totIESS.ToString("F2");

                //Aporte personal al IESS con otros empleadores (únicamente pagado por el trabajador)
                oRo_Rdep_Info.aporPerIessConOtrosEmpls = "0.00";   ///AQUI INGRESAR MANUALMENTE


                //*****************DEDUCCION POR GASTOS PERSONALES***********************

                //Deducción de gastos personales por Vivienda
                oRo_Rdep_Info.deducVivienda = oRo_Empleado_Info.totGastoVivienda.ToString("F2");

                //Deducción de gastos personales por Salud
                oRo_Rdep_Info.deducSalud = oRo_Empleado_Info.totGastoSalud.ToString("F2");

                //Deducción de gastos personales por Educación
                oRo_Rdep_Info.deducEduca = oRo_Empleado_Info.totGastoEducacion.ToString("F2");

                //Deducción de gastos personales por Alimentación
                oRo_Rdep_Info.deducAliement = oRo_Empleado_Info.totGastoAlimentacion.ToString("F2"); 

                //Deducción de gastos personales por Vestimenta
                oRo_Rdep_Info.deducVestim = oRo_Empleado_Info.totGastoVestimenta.ToString("F2"); 

                //*************************************************************************

                //Exoneración por Discapacidad MAYOR A 30% DE DISCAPACIDAD
                if (oRo_Empleado_Info.em_empEspecial !=null && oRo_Empleado_Info.em_empEspecial == "S" && oRo_Empleado_Info.por_discapacidad >= 30)
                {
                    double fraccionBasica = Convert.ToDouble(oRo_Tabla_Impu_Renta_Bus.GetInfoFraccionBasica(anioFiscal, ref mensaje).ExcesoHasta);

                    if (oRo_Empleado_Info.por_discapacidad >= 30 && oRo_Empleado_Info.por_discapacidad <= 49)
                    {
                        oRo_Rdep_Info.exoDiscap = (fraccionBasica * 2 * 0.60).ToString("F2");  //60 %
                    }
                    else
                    {
                        if (oRo_Empleado_Info.por_discapacidad >= 50 && oRo_Empleado_Info.por_discapacidad <= 74)
                        {
                            oRo_Rdep_Info.exoDiscap = (fraccionBasica * 2 * 0.70).ToString("F2");  //70 %
                        }
                        else
                        {
                            if (oRo_Empleado_Info.por_discapacidad >= 75 && oRo_Empleado_Info.por_discapacidad <= 84)
                            {
                                oRo_Rdep_Info.exoDiscap = (fraccionBasica * 2 * 0.8).ToString("F2");  //80 %
                            }
                            else
                            {
                                if (oRo_Empleado_Info.por_discapacidad >= 85 && oRo_Empleado_Info.por_discapacidad <= 100)
                                {
                                    oRo_Rdep_Info.exoDiscap = (fraccionBasica * 2 ).ToString("F2");  //100 %
                                }
                            }
                        }                    
                    }
                    
                    
                    
                    oRo_Rdep_Info.exoDiscap = (fraccionBasica * 2).ToString("F2");
                }
                else {
                    oRo_Rdep_Info.exoDiscap = "0.00";
                }

              
                //Exoneración por Tercera Edad
                if (oRo_Empleado_Info.pe_fechaNacimiento!=null && CalcularAniosDeDiferencia(param.Fecha_Transac, Convert.ToDateTime(oRo_Empleado_Info.pe_fechaNacimiento)) >= 65)
                {
                    double fraccionBasica = Convert.ToDouble(oRo_Tabla_Impu_Renta_Bus.GetInfoFraccionBasica(anioFiscal, ref mensaje).ExcesoHasta);
                    oRo_Rdep_Info.exoTerEd = (fraccionBasica * 2).ToString("F2");
                }else{
                    oRo_Rdep_Info.exoTerEd = "0.00";    
                }

                //Base imponible gravada
                oRo_Rdep_Info.basImp = "0.00";

                //Impuesto a la renta causado
                oRo_Rdep_Info.impRentCaus = "0.00";

                //Valor del impuesto retenido y asumido por otros empleadores durante el período declarado
                oRo_Rdep_Info.valRetAsuOtrosEmpls = "0.00";       ///AQUI INGRESAR MANUALMENTE

                //Valor del impuesto asumido por este empleador
                oRo_Rdep_Info.valImpAsuEsteEmpl = "0.00";

                //Valor del impuesto retenido al trabajador por este empleador
                oRo_Rdep_Info.valRet = "0.00";

                //    oRdep.retRelDep.Add(detalleRDEP);
                //}

               oRo_Rdep_Info= pu_CalcularRDEP(oRo_Rdep_Info);

                return oRo_Rdep_Info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "setInfoRdep", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };

            }
        }


       public string pu_Right(string str, int length)
       {
           return str.Substring(str.Length - length, length);
       }

   
       
       public rdep setInfoXML(List<ro_Rdep_Info> info, string ruc, int idPeriodo)
       {
           try
           {
               //CAMBIAR LA CULTURA REGIONAL PARA SETEAR EL PUNTO DECIMAL
               System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

               //DATOS DE LA EMPRESA
               rdep oRdep = new rdep();
               oRdep.anio = idPeriodo.ToString();
               oRdep.numRuc = ruc;

               oRdep.retRelDep = new List<rdepRetRelDepDatRetRelDep>();


               foreach (ro_Rdep_Info item in info)
               {
                   rdepRetRelDepDatRetRelDep detalleRDEP = new rdepRetRelDepDatRetRelDep();

                   detalleRDEP.empleado = new List<rdepRetRelDepDatRetRelDepEmpleado>();
                   rdepRetRelDepDatRetRelDepEmpleado datosEmpleado = new rdepRetRelDepDatRetRelDepEmpleado();


                   //CONSULTAR DATOS DEL EMPLEADO
                   ro_Empleado_Info ro_Empleado_Info = new ro_Empleado_Info();
                   ro_Empleado_Info = oRo_Empleado_Bus.Get_Info_Empleado(item.IdEmpresa, item.IdEmpleado);

                    #region Empleado

                   //Tipo de identificación del trabajador
                   switch (ro_Empleado_Info.InfoPersona.IdTipoDocumento)
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
                   datosEmpleado.idRet = ro_Empleado_Info.InfoPersona.pe_cedulaRuc;

                   //Apellidos del trabajador
                   datosEmpleado.apellidoTrab = ro_Empleado_Info.InfoPersona.pe_apellido;

                   //Nombres del trabajador
                   datosEmpleado.nombreTrab = ro_Empleado_Info.InfoPersona.pe_nombre;

                   //Código del establecimiento
                   tb_Sucursal_Bus oTb_Sucursal_Bus = new tb_Sucursal_Bus();
                   tb_Sucursal_Info oTb_Sucursal_Info = new Info.General.tb_Sucursal_Info();
                   oTb_Sucursal_Info = oTb_Sucursal_Bus.Get_Info_Sucursal(param.IdEmpresa, param.IdSucursal);
                   datosEmpleado.estab = oTb_Sucursal_Info.Su_CodigoEstablecimiento;

                   //Residencia del trabajador
                   datosEmpleado.residenciaTrab = pu_Right(ro_Empleado_Info.IdTipoResidenciaSRI, 2);

                   //País de residencia del trabajador
                   datosEmpleado.paisResidencia = "593";

                   //Aplica convenio para evitar doble imposición
                   datosEmpleado.aplicaConvenio = pu_Right(ro_Empleado_Info.IdAplicaConvenioDobleImposicionSRI, 2);

                   //Condición del trabajador respecto a discapacidades
                   //if (item.em_empEspecial == "S") {datosEmpleado.tipoTrabajDiscap = "02"; } else {datosEmpleado.tipoTrabajDiscap = "01"; }
                   datosEmpleado.tipoTrabajDiscap= "NO";//= pu_Right(ro_Empleado_Info.IdCondicionDiscapacidadSRI, 2);

                   //Porcentaje de discapacidad
                   datosEmpleado.porcentajeDiscap = ro_Empleado_Info.por_discapacidad.ToString();

                   //Tipo de identificación de la persona con discapacidad a quien sustituye o representa
                   datosEmpleado.tipIdDiscap = pu_Right(ro_Empleado_Info.IdTipoIdentDiscapacitadoSustitutoSRI, 1);

                   //Número de identificación de la persona con discapacidad a quien sustituye o representa
                   datosEmpleado.idDiscap = ro_Empleado_Info.IdentDiscapacitadoSustitutoSRI;

                   //AGREGAR DATOS DEL DETALLE DE EMPLEADOS
                   detalleRDEP.empleado.Add(datosEmpleado);


                    #endregion

                   #region detalle

                   //Sueldos y salarios
                   detalleRDEP.suelSal = item.suelSal;

                   //Sobresueldos, comisiones, bonos y otros ingresos gravados
                   detalleRDEP.sobSuelComRemu = item.sobSuelComRemu;

                   //Participación de utilidades
                   detalleRDEP.partUtil = item.partUtil;

                   //Ingresos gravados generados con otros empleadores
                   detalleRDEP.intGrabGen = item.intGrabGen;

                   //Impuesto a la renta asumido por este empleador
                   detalleRDEP.impRentEmpl = item.impRentEmpl;

                   //Décimo tercer sueldo
                   detalleRDEP.decimTer = item.decimTer;

                   //Décimo cuarto sueldo
                   detalleRDEP.decimCuar = item.decimCuar;

                   //Fondo de reserva
                   detalleRDEP.fondoReserva = item.fondoReserva;

                   //Compensación Económica Salario Digno
                   detalleRDEP.salarioDigno = item.salarioDigno;

                   //Otros ingresos en relación de dependencia que no constituyen renta gravada
                   detalleRDEP.otrosIngRenGrav = item.otrosIngRenGrav;

                   //Ingresos gravados con este empleador (Informativo)
                   detalleRDEP.ingGravConEsteEmpl = item.ingGravConEsteEmpl;

                   //Sistema de salario neto
                   detalleRDEP.sisSalNet = item.sisSalNet;

                   //Aporte personal al IESS con este empleador (únicamente pagado por el trabajador)
                   detalleRDEP.apoPerIess = item.apoPerIess;

                   //Aporte personal al IESS con otros empleadores (únicamente pagado por el trabajador)
                   detalleRDEP.aporPerIessConOtrosEmpls = item.aporPerIessConOtrosEmpls;


                   //*****************DEDUCCION POR GASTOS PERSONALES***********************

                   //Deducción de gastos personales por Vivienda
                   detalleRDEP.deducVivienda = item.deducVivienda;

                   //Deducción de gastos personales por Salud
                   detalleRDEP.deducSalud = item.deducSalud;

                   //Deducción de gastos personales por Educación
                   detalleRDEP.deducEduca = item.deducEduca;

                   //Deducción de gastos personales por Alimentación
                   detalleRDEP.deducAliement = item.deducAliement;

                   //Deducción de gastos personales por Vestimenta
                   //detalleRDEP. = "0.00";

                   //*************************************************************************


                   //Exoneración por Discapacidad
                   detalleRDEP.exoDiscap = item.exoDiscap;

                   //Exoneración por Tercera Edad
                   detalleRDEP.exoTerEd = item.exoTerEd;

                   //Base imponible gravada
                   detalleRDEP.basImp = item.basImp;

                   //Impuesto a la renta causado
                   detalleRDEP.impRentCaus = item.impRentCaus;

                   //Valor del impuesto retenido y asumido por otros empleadores durante el período declarado
                   detalleRDEP.valRetAsuOtrosEmpls = item.valRetAsuOtrosEmpls;

                   //Valor del impuesto asumido por este empleador
                   detalleRDEP.valImpAsuEsteEmpl = item.valImpAsuEsteEmpl;

                   //Valor del impuesto retenido al trabajador por este empleador
                   detalleRDEP.valRet = item.valRet;

                   #endregion

                   oRdep.retRelDep.Add(detalleRDEP);
               }

               return oRdep;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "setInfoXML", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
           }
       }




       public Boolean pu_GenerarXMLRDEP(List<ro_Rdep_Info> info,int idEmpresa, int idPeriodo, ref string RutaDescarga, ref string msg)
       {
           try
           {
               Boolean valorRetornar = false;

               //OBTIENE LOS DATOS DE LA EMPRESA
               tb_Empresa_Bus oTb_Empresa_Bus = new Business.General.tb_Empresa_Bus();
               tb_Empresa_Info oTb_Empresa_Info = new tb_Empresa_Info();

               oTb_Empresa_Info = oTb_Empresa_Bus.Get_Info_Empresa(idEmpresa);

               //CONVIERTE LA CONSULTA EN EL OBJETO PARA EL XML
               rdep oRdep = new rdep();
               oRdep = setInfoXML(info, oTb_Empresa_Info.em_ruc.Trim(), idPeriodo);


               if (oRdep != null)
               {
                   string idRdep = oTb_Empresa_Info.em_nombre.Trim() + idPeriodo.ToString();
                   RutaDescarga = RutaDescarga + "RDEP_" + idRdep + ".xml";
                   XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                   NamespaceObject.Add("", "");
                   XmlSerializer mySerializer = new XmlSerializer(typeof(rdep));
                   StreamWriter myWriter = new StreamWriter(RutaDescarga);
                   mySerializer.Serialize(myWriter, oRdep, NamespaceObject);
                   myWriter.Close();

                   return true;


               }

               return valorRetornar;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GenerarXMLRDEP", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
           }
       }





       public double pu_CalcularImpuestoRenta(double baseImponible, int anioFiscal, Boolean esDiscapacitado=false, Boolean esTercerEdad=false)
       {
           try
           {

               double exedente = 0;
               double fraccionBasica = 0;
               double porcentajeFraccionExedente = 0;
               double impuestoFraccionBasica = 0;
               double valorIR = 0;

               oListRo_tabla_Impu_Renta_Info = oRo_Tabla_Impu_Renta_Bus.ConsultaTablaImpuAnio(anioFiscal).OrderByDescending(v=>v.Secuencia).ToList();

               //OBTIENE EL RANGO DE LA BASE IMPONIBLE
               foreach(ro_tabla_Impu_Renta_Info item in oListRo_tabla_Impu_Renta_Info){
                    if(baseImponible>=item.FraccionBasica)
                    {
                        fraccionBasica = Convert.ToDouble(item.FraccionBasica);
                        porcentajeFraccionExedente = Convert.ToDouble(item.Por_ImpFraccion_Exce);
                        impuestoFraccionBasica = Convert.ToDouble(item.ImpFraccionBasica);

                        break;
                    }            
               }

               exedente = baseImponible - fraccionBasica;

               valorIR = impuestoFraccionBasica + (exedente * porcentajeFraccionExedente * 0.01);

               return valorIR;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CalcularImpuestoRenta", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
           }

       }



       public ro_Rdep_Info pu_CalcularRDEP(ro_Rdep_Info info)
       {
           try {
               double totalIngresos = 0;
               double totalDeducciones = 0;
               double baseImponible = 0;
               double totalIngresosInformativo = 0;

               totalIngresos = Convert.ToDouble(info.suelSal) + Convert.ToDouble(info.sobSuelComRemu) + Convert.ToDouble(info.partUtil) + Convert.ToDouble(info.intGrabGen) + Convert.ToDouble(info.valImpAsuEsteEmpl);

               totalDeducciones = Convert.ToDouble(info.apoPerIess) + Convert.ToDouble(info.aporPerIessConOtrosEmpls) + Convert.ToDouble(info.deducVivienda)
                               + Convert.ToDouble(info.deducSalud) + Convert.ToDouble(info.deducEduca) + Convert.ToDouble(info.deducAliement) + Convert.ToDouble(info.deducVestim)
                               + Convert.ToDouble(info.exoDiscap) + Convert.ToDouble(info.exoTerEd);

               baseImponible = totalIngresos - totalDeducciones;

               if (baseImponible > 0)
               {
                   info.basImp = baseImponible.ToString("F2");
                   //IMPUESTO A LA RENTA CAUSADO
                   info.impRentCaus = pu_CalcularImpuestoRenta(baseImponible, info.AnioFiscal).ToString("F2");

               }
               else {
                   info.basImp = "0.00";
                   info.impRentCaus = "0.00";
               }

               //INGRESOS GRAVADOS CON ESTE EMPLEADOR (informativo)  
               totalIngresosInformativo = Convert.ToDouble(info.suelSal) + Convert.ToDouble(info.sobSuelComRemu) + Convert.ToDouble(info.partUtil) + Convert.ToDouble(info.valImpAsuEsteEmpl);
               info.ingGravConEsteEmpl = totalIngresosInformativo.ToString("F2");


               return info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_CalcularRDEP", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
           }

       }



       public Boolean pu_ValidarRDEP(ro_Rdep_Info info, ref string msg)
       {
            double fraccionBasica = 0;
            double limiteGastoDeducible = 0;

           fraccionBasica = Convert.ToDouble(oRo_Tabla_Impu_Renta_Bus.ConsultaTablaImpuAnio(info.AnioFiscal).Where(v => v.FraccionBasica == 0 && v.ImpFraccionBasica == 0 && v.Por_ImpFraccion_Exce == 0).FirstOrDefault().ExcesoHasta);

           try {

               //GASTO VIVIENDA
               if (info.deducVivienda == "" )
               {
                   msg = "El Gasto Vivienda es obligatorio, revise por favor ";
                   return false;
               }
               else {
                   limiteGastoDeducible = fraccionBasica * 0.325;

                   if (Convert.ToDouble(info.deducVivienda) > limiteGastoDeducible)
                   {
                       msg = "La cuantía máxima del Gasto Vivienda debe ser menor que " + limiteGastoDeducible.ToString("F2") + " ( equivale a 0.325 veces la fracción básica) ";
                       return false;
                   }              
               }

               //GASTO EDUCACION
               if (info.deducEduca == "" )
               {
                   msg = "El Gasto Educación es obligatorio, revise por favor ";
                   return false;
               }
               else
               {
                   limiteGastoDeducible = fraccionBasica * 0.325;

                   if (Convert.ToDouble(info.deducEduca) > limiteGastoDeducible)
                   {
                       msg = "La cuantía máxima del Gasto Educación debe ser menor que " + limiteGastoDeducible.ToString("F2") + " ( equivale a 0.325 veces la fracción básica) ";
                       return false;
                   }
               }

               //GASTO ALIMENTOS
               if (info.deducAliement == "")
               {
                   msg = "El Gasto Alimentacion es obligatorio, revise por favor ";
                   return false;
               }
               else
               {
                   limiteGastoDeducible = fraccionBasica * 0.325;

                   if (Convert.ToDouble(info.deducAliement) > limiteGastoDeducible)
                   {
                       msg = "La cuantía máxima del Gasto Alimentos debe ser menor que " + limiteGastoDeducible.ToString("F2") + " ( equivale a 0.325 veces la fracción básica) ";
                       return false;
                   }
               }

               //GASTO VESTIMENTA
               if (info.deducVestim == "" )
               {
                   msg = "El Gasto Vestimenta es obligatorio, revise por favor ";
                   return false;
               }
               else
               {
                   limiteGastoDeducible = fraccionBasica * 0.325;

                   if (Convert.ToDouble(info.deducVestim) > limiteGastoDeducible)
                   {
                       msg = "La cuantía máxima del Gasto Vestimenta debe ser menor que " + limiteGastoDeducible.ToString("F2") + " ( equivale a 0.325 veces la fracción básica) ";
                       return false;
                   }
               }


               //GASTO SALUD
               if (info.deducSalud == "")
               {
                   msg = "El Gasto Salud es obligatorio, revise por favor ";
                   return false;
               }
               else
               {
                   limiteGastoDeducible = fraccionBasica * 1.3;

                   if (Convert.ToDouble(info.deducSalud) > limiteGastoDeducible)
                   {
                       msg = "La cuantía máxima del Gasto Salud debe ser menor que " + limiteGastoDeducible.ToString("F2") + " ( equivale a 1.3 veces la fracción básica) ";
                       return false;
                   }
               }



               if (info.suelSal == "" )
               {
                   msg = "Sueldos y salarios es obligatorio, revise por favor ";
                   return false;
               }

               if (info.sobSuelComRemu == "" )
               {
                   msg = "Sobresueldos, comisiones, bonos y otros ingresos gravados es obligatorio, revise por favor ";
                   return false;
               }

               if (info.partUtil == "" )
               {
                   msg = "Participación de utilidades es obligatorio, revise por favor ";
                   return false;
               }


               if (info.intGrabGen == "")
               {
                   msg = "Ingresos gravados generados con otros empleadores es obligatorio, revise por favor ";
                   return false;
               }



               if (info.impRentEmpl == "" )
               {
                   msg = "Impuesto a la renta asumido por este empleador es obligatorio, revise por favor ";
                   return false;
               }

               if (info.decimTer == "" )
               {
                   msg = "Décimo tercer sueldo es obligatorio, revise por favor ";
                   return false;
               }

               if (info.decimCuar == "" )
               {
                   msg = "Décimo cuarto sueldo es obligatorio, revise por favor ";
                   return false;
               }

               if (info.fondoReserva == "" )
               {
                   msg = "Fondo de reserva es obligatorio, revise por favor ";
                   return false;
               }


               if (info.salarioDigno == "" )
               {
                   msg = "Compensación Económica Salario Digno es obligatorio, revise por favor ";
                   return false;
               }




               if (info.otrosIngRenGrav == "" )
               {
                   msg = "Otros ingresos en relación de dependencia que no constituyen renta gravada es obligatorio, revise por favor ";
                   return false;
               }



               //if (info.intGrabGen == "")
               //{
               //    msg = "Ingresos gravados con este empleador (Informativo) es obligatorio, revise por favor ";
               //    return false;
               //}



               if (info.apoPerIess == "")
               {
                   msg = "Aporte personal al IESS con este empleador (únicamente pagado por el trabajador) es obligatorio, revise por favor ";
                   return false;
               }



               if (info.aporPerIessConOtrosEmpls == "")
               {
                   msg = "Aporte personal al IESS con otros empleadores (únicamente pagado por el trabajador) es obligatorio, revise por favor ";
                   return false;
               }



               if (info.exoDiscap == "")
               {
                   msg = "Exoneración por Discapacidad es obligatorio, revise por favor ";
                   return false;
               }



               if (info.exoTerEd == "")
               {
                   msg = "Exoneración por Tercera Edad es obligatorio, revise por favor ";
                   return false;
               }



               if (info.basImp == "")
               {
                   msg = "Base imponible gravada es obligatorio, revise por favor ";
                   return false;
               }



               if (info.impRentCaus == "")
               {
                   msg = "Impuesto a la renta causado es obligatorio, revise por favor ";
                   return false;
               }


               if (info.valRetAsuOtrosEmpls == "")
               {
                   msg = "Valor del impuesto retenido y asumido por otros empleadores durante el período declarado es obligatorio, revise por favor ";
                   return false;
               }


               if (info.valImpAsuEsteEmpl == "")
               {
                   msg = "Valor del impuesto asumido por este empleador es obligatorio, revise por favor ";
                   return false;
               }


               if (info.valRet == "")
               {
                   msg = "Valor del impuesto retenido al trabajador por este empleador es obligatorio, revise por favor ";
                   return false;
               }



               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarRDEP", ex.Message), ex) { EntityType = typeof(ro_Rdep_Bus) };
           }
       }










    }
}
