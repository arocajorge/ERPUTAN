using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaMatricula_Mant : Form
    {
        #region "Variables"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_FrmAcaMatricula_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaMatricula_Mant_FormClosing event_FrmAcaMatricula_Mant_FormClosing;
        public List<Aca_Familiar_Info> lstFamiliar;
        Aca_Matricula_Info matriculaInfo = new Aca_Matricula_Info();
        Aca_Familiar_Bus BusFamiliar_x_Estudiante;
        Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info Info_rep_eco_dual_Estu_Matri = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
        List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> lista_forma_pago_x_estudiante_x_matricula;
        Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Bus bus_forma_pagp_x_estudiante_x_matricula = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Bus();
        Aca_Documento_Bancario_x_Rep_Economico_Info Info_forma_pago_rep_eco_dual = new Aca_Documento_Bancario_x_Rep_Economico_Info();
        List<Aca_Documento_Bancario_x_Rep_Economico_Info> lista_forma_pago_rep_eco_dual = new List<Aca_Documento_Bancario_x_Rep_Economico_Info>();
        Aca_Documento_Bancario_x_Rep_Economico_Bus bus_forma_pago = new Aca_Documento_Bancario_x_Rep_Economico_Bus();
        List<tb_banco_x_mg_banco_Info> lista_bancos = new List<tb_banco_x_mg_banco_Info>();

        tb_banco_x_mg_banco_Bus bus_banco = new tb_banco_x_mg_banco_Bus();
        
        List<Aca_Catalogo_Info> lista_catalogo = new List<Aca_Catalogo_Info>();
        Aca_Catalogo_Bus bus_catalogo = new Aca_Catalogo_Bus();

        Aca_tipo_mecanismo_de_pago_Bus bus_tipo_meca_pago = new Aca_tipo_mecanismo_de_pago_Bus();
        List<Aca_Tipo_mecanismo_de_pago_Info> list_tipo_meca_pago = new List<Aca_Tipo_mecanismo_de_pago_Info>();
        Aca_Familiar_x_Estudiante_Bus BusFamiliar_x_Estudiante_DUAL = new Aca_Familiar_x_Estudiante_Bus();
        Aca_matricula_Bus negMatricula = new Aca_matricula_Bus();
        //Aca_Familiar_Bus BusFamiliar_DUAL = new Aca_Familiar_Bus();
        decimal IdFamiliarDual = 0;
        int IdDocumentoBancario = 0;
        string mensaje = string.Empty;
        #endregion

        #region "CargarDatos"
        private void CargarGridMatriculaDocumentos()
        {
            try
            {
                this.gridControlMatriculaDocumentos.DataSource = Get_Lista_Materiales_Documento();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void CargaDatosSistemaDual()
        {
            //lista_bancos = bus_banco.Get_List_Banco_Aca();
            cmbInstitucionFinanciera.Properties.DataSource = lista_bancos;
            cmbInstitucionFinanciera.Properties.DisplayMember = "nombre";
            cmbInstitucionFinanciera.Properties.ValueMember = "Id_tb_banco_x_mgbanco";


        }
        private void CargarCombo()
        {
            try
            {
                Aca_Anio_Lectivo_Bus negP = new Aca_Anio_Lectivo_Bus();
                List<Aca_Anio_Lectivo_Bus> lista = new List<Aca_Anio_Lectivo_Bus>();
                cmbAnioLectivo.Properties.DataSource = negP.Get_List_Anio_Lectivo(param.IdInstitucion);
                cmbAnioLectivo.Properties.ValueMember = "IdAnioLectivo";
                cmbAnioLectivo.Properties.DisplayMember = "Descripcion";


                lista_bancos = bus_banco.Get_List_Banco_Aca();
                cmb_banco.DataSource = lista_bancos;
                cmb_banco.DisplayMember = "nombre";
                cmb_banco.ValueMember = "Id_tb_banco_x_mgbanco";

                list_tipo_meca_pago = bus_tipo_meca_pago.Get_Lista_tipo_mecanismo_Pago();
                cmb_forma_pago.DataSource = list_tipo_meca_pago;
                cmb_forma_pago.DisplayMember = "nombre";
                cmb_forma_pago.ValueMember = "Id_tipo_meca_pago";

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                    ucAca_Estudiante.CargarListEstudiante();
                else
                    ucAca_Estudiante.CargarListEstudiante_sin_Matricula();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void LimpiarControles()
        {

            txtCodMatricula.Text = string.Empty;
            txtIdMatricula.Text = string.Empty;
            txtObservacion.Text = string.Empty;

        }
        private void CargarMatricula()
        {
            try
            {
                txtCodMatricula.Text = matriculaInfo.CodMatricula;
                txtIdMatricula.Text = matriculaInfo.IdMatricula.ToString();
                txtObservacion.Text = matriculaInfo.Observacion;
                cmbAnioLectivo.EditValue = matriculaInfo.IdAnioLectivo;
                chkCodigoConvivencia.Checked = matriculaInfo.Cod_convivencia_doy_fe;

                rdb_No_estoy_deacuerdo_foto.Checked = matriculaInfo.No_estoy_deacuerdo_foto;
                rdb_Si_estoy_deacuerdo_foto.Checked = matriculaInfo.Si_estoy_deacuerdo_foto;


                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    deFechaMatricula.EditValue = DateTime.Now.ToShortDateString();
                    rdb_No_estoy_deacuerdo_foto.Checked = true;
                }
                else
                {

                    ucAca_Estudiante.set_Estudiante(matriculaInfo.IdEstudiante);
                    deFechaMatricula.EditValue = matriculaInfo.Fecha_matricula == null ? DateTime.Now : matriculaInfo.Fecha_matricula;
                    ucAca_SedeJornadaSeccionCurso.cmbParalelo.EditValue = matriculaInfo.IdParalelo;
                    ucAca_SedeJornadaSeccionCurso.cmbCurso.EditValue = matriculaInfo.IdCurso;
                    ucAca_SedeJornadaSeccionCurso.cmbJornada.EditValue = matriculaInfo.IdJornada;
                    ucAca_SedeJornadaSeccionCurso.cmbSeccion.EditValue = matriculaInfo.IdSeccion;
                    ucAca_SedeJornadaSeccionCurso.cmbSede.EditValue = matriculaInfo.IdSede;
                }

                ucAca_Familiar_x_EstudianteRE.Cargar_familiares_x_estudiante_historico(matriculaInfo.IdInstitucion, matriculaInfo.IdEstudiante);



                if (matriculaInfo.Estado == "A") chkEstado.Checked = true;
                if (matriculaInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (matriculaInfo.Estado != null && matriculaInfo.Estado != "")
                    {
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        #endregion

        #region "Set"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_matricula(Aca_Matricula_Info info)
        {
            try
            {
                matriculaInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region "Get"

        private List<Aca_Documento_Bancario_x_Rep_Economico_Info> Get_rep_eco_dual(ref string mensaje)
        {
            try
            {
                if (xtraTabPageSistemaDual.PageVisible == true)
                {
                    lista_forma_pago_rep_eco_dual = new List<Aca_Documento_Bancario_x_Rep_Economico_Info>();
                    Info_forma_pago_rep_eco_dual = new Aca_Documento_Bancario_x_Rep_Economico_Info();
                    Info_forma_pago_rep_eco_dual.IdInstitucion = matriculaInfo.IdInstitucion;
                    Info_forma_pago_rep_eco_dual.IdParentesco_cat = "REP_ECO_DUAL";
                    Info_forma_pago_rep_eco_dual.IdFamiliar = lstFamiliar.Find(v => v.IdParentescoCat == "REP_ECO_DUAL").IdFamiliar;
                    if(cmbInstitucionFinanciera.EditValue != null)
                    Info_forma_pago_rep_eco_dual.Id_tb_banco_x_mgbanco = (int)cmbInstitucionFinanciera.EditValue;
                    if(cmbTipoMecanismoPago.EditValue != null)
                    Info_forma_pago_rep_eco_dual.Id_tipo_meca_pago = (int)cmbTipoMecanismoPago.EditValue;
                    Info_forma_pago_rep_eco_dual.Fecha_Expiracion = dtFechaExpiracion.DateTime;
                    Info_forma_pago_rep_eco_dual.Numero_Documento = txtNumDocumentoBancario.Text;
                    if(cmbInstitucionFinanciera.EditValue != null)
                    Info_forma_pago_rep_eco_dual.IdBanco = lista_bancos.Find(a => a.Id_tb_banco_x_mgbanco == Info_forma_pago_rep_eco_dual.Id_tb_banco_x_mgbanco).IdBanco_Erp;
                    Info_forma_pago_rep_eco_dual.Observacion = " Actualizacion ERP Rep_eco_dual ";
                    Info_forma_pago_rep_eco_dual.IdUsuario = param.IdUsuario;
                    Info_forma_pago_rep_eco_dual.Fecha_Transac = DateTime.Now;
                    Info_forma_pago_rep_eco_dual.Nom_pc = param.nom_pc;
                    Info_forma_pago_rep_eco_dual.Ip = param.ip;
                    Info_forma_pago_rep_eco_dual.Estado = true;
                    lista_forma_pago_rep_eco_dual.Add(Info_forma_pago_rep_eco_dual);

                    
                }
                return lista_forma_pago_rep_eco_dual;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<Aca_Documento_Bancario_x_Rep_Economico_Info>();
            }
        }

        private Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info Get_rep_eco_dual_x_Estu_Matri(ref string mensaje)
        {
            try
            {

                if (lista_forma_pago_rep_eco_dual.Count() != 0)
                {

                    foreach (var item in lista_forma_pago_rep_eco_dual)
                    {
                        Info_rep_eco_dual_Estu_Matri = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
                        Info_rep_eco_dual_Estu_Matri.IdInstitucion = item.IdInstitucion;
                        Info_rep_eco_dual_Estu_Matri.IdFamiliar = item.IdFamiliar;
                        Info_rep_eco_dual_Estu_Matri.IdParentesco_cat = item.IdParentesco_cat;
                        Info_rep_eco_dual_Estu_Matri.IdEstudiante = matriculaInfo.IdEstudiante;
                        Info_rep_eco_dual_Estu_Matri.IdMatricula = (matriculaInfo.IdMatricula == 0) ? Convert.ToDecimal(txtIdMatricula.Text) : matriculaInfo.IdMatricula;
                        Info_rep_eco_dual_Estu_Matri.Id_tb_banco_x_mgbanco = item.Id_tb_banco_x_mgbanco;
                        Info_rep_eco_dual_Estu_Matri.Id_tipo_meca_pago = item.Id_tipo_meca_pago;
                        Info_rep_eco_dual_Estu_Matri.IdDocumento_Bancario = (IdDocumentoBancario == 0) ? Info_forma_pago_rep_eco_dual.IdDocumento_Bancario : IdDocumentoBancario;
                        Info_rep_eco_dual_Estu_Matri.Observacion = " Actualizacion ERP Rep_eco_dual por estudiante por matricula";


                    }
                }
                return Info_rep_eco_dual_Estu_Matri;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
            }
        }


        private List<Aca_Matricula_x_Documento_Info> Get_Lista_Materiales_Documento()
        {
            List<Aca_Matricula_x_Documento_Info> lista = new List<Aca_Matricula_x_Documento_Info>();
            try
            {
                Aca_Material_x_Documento_Bus neg = new Aca_Material_x_Documento_Bus();
                Aca_Matricula_x_Documento_Info info = new Aca_Matricula_x_Documento_Info();
                info.IdInstitucion = matriculaInfo.IdInstitucion;
                info.IdMatricula = matriculaInfo.IdMatricula;
                info.IdSede = matriculaInfo.IdSede;

                lista = neg.Get_List_Matricul_x_Documento(info);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<Aca_Matricula_x_Documento_Info>();
            }
            return lista;
        }

        private Aca_Matricula_Info GetMatricula(ref string mensaje)
        {
            matriculaInfo = new Aca_Matricula_Info();
            try
            {
                txtObservacion.Focus();

                matriculaInfo.IdInstitucion = param.IdInstitucion;
                matriculaInfo.IdSede = Convert.ToInt16(ucAca_SedeJornadaSeccionCurso.cmbSede.EditValue);
                matriculaInfo.IdMatricula = string.IsNullOrEmpty(txtIdMatricula.Text) ? 0 : Convert.ToDecimal(txtIdMatricula.Text);
                matriculaInfo.CodMatricula = txtCodMatricula.Text;

                matriculaInfo.listaFamiliar = lstFamiliar;
                foreach (var item in matriculaInfo.listaFamiliar)
                {
                    switch (item.IdParentescoCat)
                    {
                        case "REP_ECO":
                            item.porcentaje_dual = 100;
                            if (!string.IsNullOrEmpty(txtPorecentajeDual.Text))
                            {
                                item.porcentaje_dual = item.porcentaje_dual - Convert.ToInt32(txtPorecentajeDual.EditValue);
                            }
                            break;
                    }

                }

                matriculaInfo.IdAnioLectivo = cmbAnioLectivo.EditValue == null ? 0 : Convert.ToInt16(cmbAnioLectivo.EditValue);

                matriculaInfo.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);

                matriculaInfo.IdFamiliar_repre_econ = lstFamiliar.Find(v => v.IdParentescoCat == "REP_ECO").IdFamiliar;
                matriculaInfo.IdFamiliar_repre_legal = lstFamiliar.Find(v => v.IdParentescoCat == "REP_LEGAL").IdFamiliar;
                matriculaInfo.Observacion = txtObservacion.Text.Trim();

                matriculaInfo.IdParalelo = Convert.ToInt16(ucAca_SedeJornadaSeccionCurso.cmbParalelo.EditValue);
                matriculaInfo.Estado = chkEstado.Checked == true ? "A" : "I";
                matriculaInfo.UsuarioCreacion = param.IdUsuario;
                matriculaInfo.UsuarioModificacion = param.IdUsuario;

                matriculaInfo.estudianteInfo.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);
                matriculaInfo.estudianteInfo.IdInstitucion = param.IdInstitucion;
                matriculaInfo.estudianteInfo.UsuarioCreacion = param.IdUsuario;
                matriculaInfo.estudianteInfo.UsuarioModificacion = param.IdUsuario;

                matriculaInfo.Cod_convivencia_doy_fe = chkCodigoConvivencia.Checked;
                matriculaInfo.Si_estoy_deacuerdo_foto = rdb_Si_estoy_deacuerdo_foto.Checked;
                matriculaInfo.No_estoy_deacuerdo_foto = rdb_No_estoy_deacuerdo_foto.Checked;
                matriculaInfo.Fecha_matricula = Convert.ToDateTime(deFechaMatricula.EditValue);

                matriculaInfo.listaDocumento = Get_Lista_Materiales_Documento();

                if (lista_forma_pago_x_estudiante_x_matricula.Count != 0)
                {
                    if (lista_forma_pago_x_estudiante_x_matricula.Where(v => v.check == true).Count() > 0)
                    {
                        matriculaInfo.Forma_Debito = lista_forma_pago_x_estudiante_x_matricula.Where(v => v.check == true).FirstOrDefault();
                        matriculaInfo.Forma_Debito.IdMatricula = matriculaInfo.IdMatricula;
                        matriculaInfo.Forma_Debito.IdEstudiante = matriculaInfo.IdEstudiante;
                        matriculaInfo.Forma_Debito.Observacion = "Actualizacion estudiante por matricula ERP";


                    }
                    else
                    {
                        Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info docu_rep_eco = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
                        docu_rep_eco = (Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info)gridView_Dco_bancario.GetFocusedRow();
                        lista_forma_pago_x_estudiante_x_matricula = new List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info>();
                        lista_forma_pago_x_estudiante_x_matricula.Add(docu_rep_eco);
                        matriculaInfo.Forma_Debito = lista_forma_pago_x_estudiante_x_matricula.Where(v => v.check == true).FirstOrDefault();

                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Aca_Matricula_Info();
            }
            return matriculaInfo;
        }

        private List<Aca_Familiar_Info> Get_Familiar_rep_eco_dual()
        {
            try
            {
               
                if (matriculaInfo.listaFamiliar.Count() == 4)
                {


                    Aca_Familiar_Info info_familiar = new Aca_Familiar_Info();
                    info_familiar.Persona_Info = ucFa_ClienteCmb1.get_ClienteInfo().Persona_Info;
                    if (info_familiar.Persona_Info.IdPersona != 0)
                    {
                        info_familiar.IdParentescoCat = "REP_ECO_DUAL";
                        info_familiar.UsuarioCreacion = param.IdUsuario;
                        info_familiar.FechaCreacion = DateTime.Now;
                        info_familiar.porcentaje_dual = Convert.ToInt32(txtPorecentajeDual.EditValue);
                        matriculaInfo.listaFamiliar.Add(info_familiar);
                    }

                }
                else
                {
                    foreach (var item in matriculaInfo.listaFamiliar)
                    {
                        switch (item.IdParentescoCat)
                        {
                            case "REP_ECO_DUAL":
                                item.Persona_Info = ucFa_ClienteCmb1.get_ClienteInfo().Persona_Info;
                                if (item.Persona_Info.IdPersona != 0)
                                {
                                    item.IdParentescoCat = "REP_ECO_DUAL";
                                    item.UsuarioCreacion = param.IdUsuario;
                                    item.FechaCreacion = DateTime.Now;
                                    item.porcentaje_dual = Convert.ToInt32(txtPorecentajeDual.EditValue);

                                }

                                break;

                        }

                    }
                }
                return matriculaInfo.listaFamiliar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<Aca_Familiar_Info>();
            }
        }
        #endregion

        #region "Grabar,Actualizar, Eliminar"
        private bool guardarDatos()
        {
            bool resultado = false;
            try
            {
               
                if (validaciones())
                {
                    matriculaInfo = GetMatricula(ref mensaje);

                    if (xtraTabPageSistemaDual.PageVisible != false)
                    {
                        lstFamiliar = Get_Familiar_rep_eco_dual();
                        lista_forma_pago_rep_eco_dual = Get_rep_eco_dual(ref mensaje);
                        Info_rep_eco_dual_Estu_Matri = Get_rep_eco_dual_x_Estu_Matri(ref mensaje);
                    }
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Actualizar();
                            break;
                    }
                }
            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        private bool Grabar()
        {
            try
            {
                decimal id = 0;
                bool resultado = negMatricula.GrabarDB(matriculaInfo, ref id, ref mensaje);
                txtIdMatricula.Text = id.ToString();

                if (resultado)
                {
                    if (matriculaInfo.listaFamiliar.Count() != 4)
                    {
                        resultado = false;                        
                        resultado = bus_forma_pago.GrabarDB(lista_forma_pago_rep_eco_dual, ref IdDocumentoBancario, ref mensaje);
                        if (resultado)
                        {
                            resultado = false;                           
                            resultado = bus_forma_pagp_x_estudiante_x_matricula.GrabarDB(Info_rep_eco_dual_Estu_Matri, ref mensaje);
                            if (resultado)
                            {
                                MessageBox.Show("Se ha grabado correctamente la Matricula # : " + txtIdMatricula.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimpiarControles();

                            }
                            else
                            {
                                Log_Error_bus.Log_Error(mensaje.ToString());
                                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se ha actualizado correctamente la Matricula # : " + txtIdMatricula.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();

                    }


                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Actualizar()
        {
            try
            {
                bool resultado = false;              
                
                resultado = negMatricula.ActualizarDB(matriculaInfo, ref mensaje);

                if (resultado)
                {
                    if (matriculaInfo.listaFamiliar.Count() != 4)
                    {

                        resultado = false;                        
                        Info_forma_pago_rep_eco_dual.IdDocumento_Bancario = IdDocumentoBancario;
                        resultado = bus_forma_pago.ActualizarDB(Info_forma_pago_rep_eco_dual, ref mensaje);
                        if (resultado)
                        {
                            resultado = false;                            
                            resultado = bus_forma_pagp_x_estudiante_x_matricula.GrabarDB(Info_rep_eco_dual_Estu_Matri, ref mensaje);
                            if (resultado)
                            {
                                MessageBox.Show("Se ha actualizado correctamente la Matricula # : " + txtIdMatricula.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimpiarControles();

                            }
                            else
                            {
                                Log_Error_bus.Log_Error(mensaje.ToString());
                                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se ha actualizado correctamente la Matricula # : " + txtIdMatricula.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();

                    }

                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Anular()
        {
            try
            {
                bool resultado = false;
                if (matriculaInfo.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular la Matricula # " + txtIdMatricula.Text.Trim() + " ?", "Anulación de Mantenimiento Matricula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        Aca_matricula_Bus negMatricula = new Aca_matricula_Bus();
                        Aca_Matricula_Info infoMatricula = new Aca_Matricula_Info();
                        string mensaje = string.Empty;


                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        infoMatricula.MotivoAnulacion = fr.motivoAnulacion;
                        infoMatricula.UsuarioAnulacion = param.IdUsuario;
                        resultado = negMatricula.AnularDB(infoMatricula, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show("Se ha anulado correctamente la Matricula # : " + txtIdMatricula.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La matricula # " + txtIdMatricula.Text.Trim() + " ya se encuentra anulada.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        #endregion

        #region "Validaciones"
        private bool validaciones()
        {
            bool resultado = true;
            try
            {
                if (cmbAnioLectivo.EditValue == null || cmbAnioLectivo.EditValue == "")
                {
                    MessageBox.Show("Seleccione el periodo lectivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbAnioLectivo.Focus();
                    return false;
                }

                if (ucAca_Estudiante.cmbEstudiante.EditValue == null || ucAca_Estudiante.cmbEstudiante.EditValue == "" || ucAca_Estudiante.cmbEstudiante.EditValue == "0")
                {
                    MessageBox.Show("Seleccione un estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucAca_Estudiante.cmbEstudiante.Focus();
                    return false;
                }

                if (ucAca_SedeJornadaSeccionCurso.cmbSede.EditValue == null || ucAca_SedeJornadaSeccionCurso.cmbSede.EditValue == "")
                {
                    MessageBox.Show("Seleccione Sede", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucAca_SedeJornadaSeccionCurso.cmbSede.Focus();
                    return false;
                }

                if (ucAca_SedeJornadaSeccionCurso.cmbJornada.EditValue == null || ucAca_SedeJornadaSeccionCurso.cmbJornada.EditValue == "")
                {
                    MessageBox.Show("Seleccione Jornada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucAca_SedeJornadaSeccionCurso.cmbJornada.Focus();
                    return false;
                }

                if (ucAca_SedeJornadaSeccionCurso.cmbSeccion.EditValue == null || ucAca_SedeJornadaSeccionCurso.cmbSeccion.EditValue == "")
                {
                    MessageBox.Show("Seleccione Sección", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucAca_SedeJornadaSeccionCurso.cmbSeccion.Focus();
                    return false;
                }

                if (ucAca_SedeJornadaSeccionCurso.cmbCurso.EditValue == null || ucAca_SedeJornadaSeccionCurso.cmbCurso.EditValue == "")
                {
                    MessageBox.Show("Seleccione curso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucAca_SedeJornadaSeccionCurso.cmbCurso.Focus();
                    return false;
                }

                if (ucAca_SedeJornadaSeccionCurso.cmbParalelo.EditValue == null || ucAca_SedeJornadaSeccionCurso.cmbParalelo.EditValue == "")
                {
                    MessageBox.Show("Seleccione paralelo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucAca_SedeJornadaSeccionCurso.cmbParalelo.Focus();
                    return false;
                }
                if (chkEstado.Checked == false)
                {
                    MessageBox.Show(" Debe seleccionar el estado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkEstado.Focus();
                    return false;
                }


                if (lista_forma_pago_x_estudiante_x_matricula.Count == 0)
                {
                    MessageBox.Show("El Representante Economico no tiene ingresada una forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    return false;
                }

                if (xtraTabPageSistemaDual.PageVisible == true)
                {

                    if (ucFa_ClienteCmb1.cmb_cliente.EditValue == null || ucFa_ClienteCmb1.cmb_cliente.EditValue == "")
                    {
                        MessageBox.Show("Por Favor Seleccione el Representante Dual ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucFa_ClienteCmb1.cmb_cliente.Focus();
                        return false;
                    }
                    if (cmbInstitucionFinanciera.EditValue == null || cmbInstitucionFinanciera.EditValue == "")
                    {
                        MessageBox.Show("Por Favor Seleccione la Institución Financiera", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbInstitucionFinanciera.Focus();
                        return false;
                    }
                    if (cmbTipoMecanismoPago.EditValue == null || cmbTipoMecanismoPago.EditValue == "")
                    {
                        MessageBox.Show("Por Favor Seleccione el Mecanismo de Pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbTipoMecanismoPago.Focus();
                        return false;
                    }
                    if (!string.IsNullOrEmpty(txtNumDocumentoBancario.Text.Trim()))
                    {
                        MessageBox.Show("Digite el numero de documento bancario del representante dual", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumDocumentoBancario.Focus();
                        return false;
                    }
                    if (dtFechaExpiracion.DateTime == DateTime.MinValue)
                    {
                        MessageBox.Show("Por Favor escoga la fecha de expiración ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtFechaExpiracion.Focus();
                        return false;
                    }
                    if (!string.IsNullOrEmpty(txtPorecentajeDual.Text.Trim()))
                    {
                        MessageBox.Show("Digite el porcetaje de pago del representante dual", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPorecentajeDual.Focus();
                        return false;
                    }
                   
                }
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }
        #endregion

        #region "Eventos"
        public FrmAcaMatricula_Mant()
        {
            InitializeComponent();
            event_FrmAcaMatricula_Mant_FormClosing += FrmAcaMatricula_Mant_event_FrmAcaMatricula_Mant_FormClosing;
            ucAca_Estudiante.event_UCAca_Estudiante_EditValueChanged += ucAca_Estudiante_event_UCAca_Estudiante_EditValueChanged;
            ucAca_SedeJornadaSeccionCurso.event_cmbSeccion_EditValueChanged += ucAca_SedeJornadaSeccionCurso_event_cmbSeccion_EditValueChanged;
        }

        void ucAca_SedeJornadaSeccionCurso_event_cmbSeccion_EditValueChanged(object sender, EventArgs e)
        {
            List<Aca_Curso_Info> Lista_ = new List<Aca_Curso_Info>();
            Lista_ = ucAca_SedeJornadaSeccionCurso.Lista_Curso;
            foreach (var item in Lista_)
            {
                if (item.es_sistema_dual == false)
                {

                    xtraTabPageSistemaDual.PageVisible = false;
                }
                else
                    xtraTabPageSistemaDual.PageVisible = true;

            }
        }

        void ucAca_Estudiante_event_UCAca_Estudiante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Cargar lista familiar
                lstFamiliar = new List<Aca_Familiar_Info>();
                lstFamiliar = ucAca_Estudiante.listaFamiliar;
                ucAca_Familiar_x_EstudianteRE.LimpiarControles();
                ucAca_Familiar_x_EstudianteRL.LimpiarControles();
                ucAca_Familiar_x_EstudianteMadre.LimpiarControles();
                ucAca_Familiar_x_EstudiantePadre.LimpiarControles();

                foreach (var item in lstFamiliar)
                {
                    switch (item.IdParentescoCat)
                    {
                        case "REP_ECO":
                            ucAca_Familiar_x_EstudianteRE.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);
                            ucAca_Familiar_x_EstudianteRE.Set_Info_Datos_Familiar(item);
                           
                            // busco los documentos bancarios
                            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                            {
                                lista_forma_pago_x_estudiante_x_matricula = new List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info>();
                                lista_forma_pago_x_estudiante_x_matricula = bus_forma_pagp_x_estudiante_x_matricula.Get_List_Matricula_Tipo_Documento(item.IdInstitucion, Convert.ToInt32(item.IdFamiliar));
                                gridControl_Dco_bancario.DataSource = lista_forma_pago_x_estudiante_x_matricula;
                            }

                            else
                            {
                                lista_forma_pago_x_estudiante_x_matricula = new List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info>();
                                lista_forma_pago_x_estudiante_x_matricula = bus_forma_pagp_x_estudiante_x_matricula.Get_List_Matricula_Tipo_Documento(item.IdInstitucion, Convert.ToInt32(item.IdFamiliar), Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue));

                                if (lista_forma_pago_x_estudiante_x_matricula.Count() == 0)
                                {
                                    // si el alumno no tiene guardos metodos de pago x matricula, se consulta todos los metodos de pagos del representante economico de ese alumno
                                    lista_forma_pago_x_estudiante_x_matricula = bus_forma_pagp_x_estudiante_x_matricula.Get_List_Matricula_Tipo_Documento(item.IdInstitucion, Convert.ToInt32(item.IdFamiliar));
                                    gridControl_Dco_bancario.DataSource = lista_forma_pago_x_estudiante_x_matricula;

                                }
                                else
                                {
                                    foreach (var item1 in lista_forma_pago_x_estudiante_x_matricula)
                                    {

                                        item1.check = true;
                                        gridControl_Dco_bancario.DataSource = lista_forma_pago_x_estudiante_x_matricula;
                                    }

                                }

                            }
                            break;
                        case "REP_LEGAL":
                            ucAca_Familiar_x_EstudianteRL.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);
                            ucAca_Familiar_x_EstudianteRL.Set_Info_Datos_Familiar(item);
                            break;
                        case "MADR":
                            ucAca_Familiar_x_EstudianteMadre.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);
                            ucAca_Familiar_x_EstudianteMadre.Set_Info_Datos_Familiar(item); break;
                        case "PADR":
                            ucAca_Familiar_x_EstudiantePadre.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);
                            ucAca_Familiar_x_EstudiantePadre.Set_Info_Datos_Familiar(item); break;
                        case "REP_ECO_DUAL":

                            fa_Cliente_Info clienteinfo = new fa_Cliente_Info();
                            fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
                            clienteinfo = bus_cliente.Get_info_Cliente_x_IdPersona(param.IdEmpresa, item.Persona_Info.IdPersona);
                            ucFa_ClienteCmb1.set_ClienteInfo(clienteinfo.IdCliente);
                            List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> lista_forma_pago_x_estudiante_x_matricula_dual = new List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info>();
                            lista_forma_pago_x_estudiante_x_matricula_dual = bus_forma_pagp_x_estudiante_x_matricula.Get_List_Matricula_Tipo_Documento(item.IdInstitucion, Convert.ToInt32(item.IdFamiliar));
                            foreach (var item1 in lista_forma_pago_x_estudiante_x_matricula_dual)
                            {
                                IdDocumentoBancario = item1.IdDocumento_Bancario;
                                cmbInstitucionFinanciera.EditValue = item1.Id_tb_banco_x_mgbanco;
                                cmbTipoMecanismoPago.EditValue = item1.Id_tipo_meca_pago;
                                txtNumDocumentoBancario.Text = item1.Numero_Documento;
                                dtFechaExpiracion.DateTime = (DateTime)item1.Fecha_Expiracion;
                                txtPorecentajeDual.EditValue = item.porcentaje_dual;
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void FrmAcaMatricula_Mant_event_FrmAcaMatricula_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmAcaMatricula_Mant_Load(object sender, EventArgs e)
        {


            CargarCombo();
            CargarGridMatriculaDocumentos();
            CargaDatosSistemaDual();

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Enabled_bntImprimir = false;
                    //ucAca_Estudiante.CargarListEstudiante();
                    LimpiarControles();
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    CargarMatricula();
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;

                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;
                    ucGe_Menu.Enabled_bntAnular = false;
                    CargarMatricula();

                    break;
            }
            cargarFormularios();
        }

        public void cargarFormularios()
        {
            try
            {
                foreach (DevExpress.XtraTab.XtraTabPage item in xtraTabControlMatricula.TabPages)
                {
                    xtraTabControlMatricula.SelectedTabPage = item;
                }
                xtraTabControlMatricula.SelectedTabPageIndex = 0;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmAcaMatricula_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaMatricula_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucAca_Familiar_x_EstudianteRE_Load(object sender, EventArgs e)
        {
            try
            {
                if (ucAca_Estudiante.cmbEstudiante.EditValue != null)
                {
                    ucAca_Familiar_x_EstudianteRE.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucAca_Familiar_x_EstudianteRL_Load(object sender, EventArgs e)
        {
            try
            {
                if (ucAca_Estudiante.cmbEstudiante.EditValue != null)
                {
                    ucAca_Familiar_x_EstudianteRL.IdEstudiante = Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmbInstitucionFinanciera_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                list_tipo_meca_pago = bus_tipo_meca_pago.Get_Lista_tipo_mecanismo_Pago_x_Banco(Convert.ToDecimal(cmbInstitucionFinanciera.EditValue));
                cmbTipoMecanismoPago.Properties.DataSource = list_tipo_meca_pago;
                cmbTipoMecanismoPago.Properties.DisplayMember = "nombre";
                cmbTipoMecanismoPago.Properties.ValueMember = "Id_tipo_meca_pago";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView_Dco_bancario_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "Col_check")
                {

                    for (int i = 0; i < gridView_Dco_bancario.RowCount; i++)
                    {
                        gridView_Dco_bancario.SetRowCellValue(i, Col_check, false);
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion
    }
}
