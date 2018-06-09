using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
    
    public class cxc_cobro_tipo_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(cxc_cobro_tipo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                    decimal cont = 0;
                    try
                    {
                        cont = (from C in CxC.cxc_cobro_tipo
                                where C.IdCobro_tipo == info.IdCobro_tipo
                                select C).Count();
                    }
                    catch (Exception)
                    {
                    }
                    if (cont > 0) { msg = "Codigo Ya asignado"; return false; }
                    var addressG = new cxc_cobro_tipo();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = info.tc_Orden;
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.Fecha_Transac = info.Fecha_Transac;
                    addressG.tc_seMuestraManCheque = info.tc_seMuestraManCheque;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_seCobra = info.tc_seCobra;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;
                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.PorcentajeRet = info.PorcentajeRet;
                    addressG.tc_cobroDirecto = "N";
                    addressG.tc_cobroInDirecto = "N";
                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;

                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    context.cxc_cobro_tipo.Add(addressG);
                    context.SaveChanges();
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
                msg = ex.InnerException.ToString();
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(cxc_cobro_tipo_Info info, ref string msg)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var addressG = context.cxc_cobro_tipo.FirstOrDefault(cot => cot.IdCobro_tipo == info.IdCobro_tipo);
                    if (addressG != null)
                    {
                        addressG.tc_descripcion = info.tc_descripcion;
                        addressG.tc_EsCheque = info.tc_EsCheque;
                        addressG.tc_Afecha = info.tc_Afecha;
                        addressG.tc_interno = info.tc_interno;
                        addressG.Estado = info.Estado;
                        addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                        addressG.tc_abreviatura = info.tc_abreviatura;
                        addressG.tc_docXCobrar = info.tc_docXCobrar;
                        addressG.tc_Orden = info.tc_Orden;
                        addressG.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        addressG.Fecha_UltMod = info.Fecha_UltMod;
                        addressG.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        addressG.Fecha_UltAnu = info.Fecha_UltAnu;
                        addressG.tc_cobroDirecto = "N";
                        addressG.tc_cobroInDirecto = "N";
                        addressG.ESRetenIVA = info.ESRetenIVA;
                        addressG.ESRetenFTE = info.ESRetenFTE;
                        addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                        addressG.PorcentajeRet = info.PorcentajeRet;
                        addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                        addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;
                        addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                        addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;                                        
                msg = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo()
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo select q;
                foreach (var info in select)
                {
                    cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;
                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    lista.Add(addressG);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_x_RetFte()
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo where q.ESRetenFTE == "S" && q.Estado == "A" select q;
                foreach (var info in select)
                {
                    cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;


                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);

                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    lista.Add(addressG);
                }
                return lista;
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

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_RetIva()
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo where q.ESRetenIVA == "S" && q.Estado == "A" select q;
                foreach (var info in select)
                {
                    cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;

                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);

                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    lista.Add(addressG);
                }
                return lista;
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

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo(string docxcobrar)
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo where q.tc_docXCobrar == docxcobrar.Trim() select q;
                foreach (var info in select)
                {
                    cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;


                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;

                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    lista.Add(addressG);
                }
                return lista;
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

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_ParaMantCheque()
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo where q.tc_seMuestraManCheque == "S" select q;
                foreach (var info in select)
                {
                    cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;
                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    lista.Add(addressG);
                }
                return lista;
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

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_x_Anticipo(int IdEmpresa)
        {
            try
            {
                cxc_Cobro_Tipo_x_Anticipo_Data data = new cxc_Cobro_Tipo_x_Anticipo_Data();
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo where q.Estado == "A" select q;
                foreach (var info in select)
                {
                    if (data.ValidarSiExiste(info.IdCobro_tipo, IdEmpresa))
                    {
                        cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                        addressG.IdCobro_tipo = info.IdCobro_tipo;

                        addressG.tc_descripcion = info.tc_descripcion;
                        addressG.tc_EsCheque = info.tc_EsCheque;
                        addressG.tc_Afecha = info.tc_Afecha;
                        addressG.tc_interno = info.tc_interno;
                        addressG.Estado = info.Estado;
                        addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                        addressG.tc_abreviatura = info.tc_abreviatura;
                        addressG.tc_docXCobrar = info.tc_docXCobrar;
                        addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                        addressG.IdUsuario = info.IdUsuario;
                        addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                        addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                        addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;
                        addressG.ESRetenIVA = info.ESRetenIVA;
                        addressG.ESRetenFTE = info.ESRetenFTE;
                        addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);
                        addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;

                        addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                        addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                        addressG.nom_pc = info.nom_pc;
                        addressG.ip = info.ip;
                        lista.Add(addressG);
                    }
                }
                return lista;
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

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_Documento()
        {
            try
            {
                cxc_cobro_tipo_x_cobros_Docxc_Data data = new cxc_cobro_tipo_x_cobros_Docxc_Data();
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo where q.Estado == "A" select q;
                foreach (var info in select)
                {
                    if (data.ValidarSiExiste(info.IdCobro_tipo))
                    {
                        cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                        addressG.IdCobro_tipo = info.IdCobro_tipo;

                        addressG.tc_descripcion = info.tc_descripcion;
                        addressG.tc_EsCheque = info.tc_EsCheque;
                        addressG.tc_Afecha = info.tc_Afecha;
                        addressG.tc_interno = info.tc_interno;
                        addressG.Estado = info.Estado;
                        addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                        addressG.tc_abreviatura = info.tc_abreviatura;
                        addressG.tc_docXCobrar = info.tc_docXCobrar;
                        addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                        addressG.IdUsuario = info.IdUsuario;
                        addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                        addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                        addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;

                        addressG.ESRetenIVA = info.ESRetenIVA;
                        addressG.ESRetenFTE = info.ESRetenFTE;
                        addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);
                        addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;

                        addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                        addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                        addressG.nom_pc = info.nom_pc;
                        addressG.ip = info.ip;
                        lista.Add(addressG);
                    }
                }
                return lista;
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

        public cxc_cobro_tipo_Data()
        {
        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_Anticipo(int IdEmpresa)
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_tipo
                             join w in CxC.cxc_cobro_tipo_x_anticipo
                             on q.IdCobro_tipo equals w.IdCobro_tipo
                             where w.IdEmpresa == IdEmpresa
                             select q;
                foreach (var info in select)
                {
                    cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;


                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);

                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;

                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    lista.Add(addressG);
                }
                return lista;
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

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_Todos()
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();
                cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                var select = from q in CxC.cxc_cobro_tipo select q;

                foreach (var info in select)
                {
                    addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;
                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;

                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;

                    addressG.Impresion_Vario = false;
                    lista.Add(addressG);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());

            }
        }


        /// <summary>
        /// se envia el listado de los tipo q se quiere ext
        /// </summary>
        /// <param name="lTipoCobros"></param> 
        /// <returns></returns>
        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo(List<string> lTipoCobros )
        {
            try
            {
                List<cxc_cobro_tipo_Info> lista = new List<cxc_cobro_tipo_Info>();
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();
                cxc_cobro_tipo_Info addressG = new cxc_cobro_tipo_Info();
                var select = from q in CxC.cxc_cobro_tipo 
                             where lTipoCobros.Contains(q.IdCobro_tipo)
                             select q;

                foreach (var info in select)
                {
                    addressG = new cxc_cobro_tipo_Info();
                    addressG.IdCobro_tipo = info.IdCobro_tipo;

                    addressG.tc_descripcion = info.tc_descripcion;
                    addressG.tc_EsCheque = info.tc_EsCheque;
                    addressG.tc_Afecha = info.tc_Afecha;
                    addressG.tc_interno = info.tc_interno;
                    addressG.Estado = info.Estado;
                    addressG.tc_generaNCAuto = info.tc_generaNCAuto;
                    addressG.tc_abreviatura = info.tc_abreviatura;
                    addressG.tc_docXCobrar = info.tc_docXCobrar;
                    addressG.tc_Orden = Convert.ToInt32(info.tc_Orden);
                    addressG.IdUsuario = info.IdUsuario;
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Que_Tipo_Registro_Genera = info.tc_Que_Tipo_Registro_Genera;
                    addressG.tc_SePuede_Depositar = info.tc_SePuede_Depositar;
                    addressG.ESRetenIVA = info.ESRetenIVA;
                    addressG.ESRetenFTE = info.ESRetenFTE;
                    addressG.PorcentajeRet = Convert.ToDouble(info.PorcentajeRet);
                    addressG.IdEstadoCobro_Inicial = info.IdEstadoCobro_Inicial;
                    addressG.tc_Tomar_Cta_Cble_De = info.tc_Tomar_Cta_Cble_De;
                    addressG.nom_pc = info.nom_pc;
                    addressG.ip = info.ip;
                    addressG.Impresion_Vario = false;

                    addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;

                    lista.Add(addressG);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());

            }
        }
    
    }
}

