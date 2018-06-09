using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Turno_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<ro_turno_x_tb_dia_Info> ListaGrabarDetTurno = new List<ro_turno_x_tb_dia_Info>();
        ro_turno_Bus busTurno = new ro_turno_Bus();
        BindingList<ro_turno_x_tb_dia_Info> BindListDetTurno = new BindingList<ro_turno_x_tb_dia_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; List<string> DiasDeLaSeman = new List<string>();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        string mensaje = "";
        ro_turno_Info ItemGrabar = new ro_turno_Info();
        public delegate void delegate_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Turno_Mant_FormClosing event_frmRo_Turno_Mant_FormClosing;
        ro_turno_x_tb_dia_Bus busDetalle = new ro_turno_x_tb_dia_Bus();
        #endregion

        public frmRo_Turno_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            try
            {
                System.Globalization.CultureInfo Cultura = new System.Globalization.CultureInfo("es-EC");
                DiasDeLaSeman = Cultura.DateTimeFormat.DayNames.ToList(); 
                BindListDetTurno = new BindingList<ro_turno_x_tb_dia_Info>((from q in DiasDeLaSeman select new ro_turno_x_tb_dia_Info { Dia = q.ToUpper()}).ToList());
                gridControlDetalleTurno.DataSource = BindListDetTurno;
                this.event_frmRo_Turno_Mant_FormClosing += frmRo_Turno_Mant_event_frmRo_Turno_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está Seguro que desea Anular el turno?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    oFrm.ShowDialog();
                    ItemGrabar.MotiAnula = oFrm.motivoAnulacion;
                    ItemGrabar.IdUsuarioUltAnu = param.IdUsuario;
                    ItemGrabar.Fecha_UltAnu = DateTime.Now;
                    if (busTurno.AnularTurno(ItemGrabar, ref mensaje))
                    {
                        ItemGrabar.Estado = "I";
//                        MessageBox.Show("Anulado Exitosamente");
                        MessageBox.Show("El registro ha sido anulado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lblEstado.Visible = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frmRo_Turno_Mant_event_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              Accion = iAccion;
                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtDia.Text = "0";
                        this.lblEstado.Visible = false;
                        checkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
          
        }
        
        public void SetInfo(ro_turno_Info info)
        {
            try
            {
                ItemGrabar = info;
                txtDia.Text = info.IdTurno.ToString();
                txt_descTurno.Text = info.tu_descripcion;
                info.Detalle = busDetalle.ConsultaDetallexTurno(param.IdEmpresa, info.IdTurno);
                if (info.Estado == "A")
                {
                    lblEstado.Visible = false;
                    checkEstado.Checked = true;
                }
                else
                {
                    lblEstado.Visible = true;
                    checkEstado.Checked = false;
                }

                if (info.es_jornada_desfasada != null)
                    chek_jornada_desfasada.Checked =Convert.ToBoolean( info.es_jornada_desfasada);

                BindListDetTurno = new BindingList<ro_turno_x_tb_dia_Info>(info.Detalle);
                gridControlDetalleTurno.DataSource = BindListDetTurno;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }       
        }

        private Boolean getInfo()
        {
            Boolean resul = false;
            ListaGrabarDetTurno = new List<ro_turno_x_tb_dia_Info>();
            txt_descTurno.Focus();
            try
            {
                foreach (var item in BindListDetTurno)
                {
                    ro_turno_x_tb_dia_Info info = new ro_turno_x_tb_dia_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.Activo = item.Activo;
                    
                    switch (item.Dia)
                    {
                        case "LUNES":
                            info.idDia = 2;
                            break;
                        case "MARTES":
                            info.idDia = 3;
                            break;
                        case "MIÉRCOLES":
                            info.idDia = 4;
                            break;
                        case "JUEVES":
                            info.idDia = 5;
                            break;
                        case "VIERNES":
                            info.idDia =6;
                            break;
                        case "SÁBADO":
                            info.idDia =7;
                            break;
                        case "DOMINGO":
                            info.idDia = 1;
                            break;
                        default:
                            break;
                    }
                    ListaGrabarDetTurno.Add(info);
                }

                try
                {
                    var l = ListaGrabarDetTurno.FindAll(var => var.Activo == true);
                    if (l.Count < 1)
                    { 
                        MessageBox.Show("Active minimo un día para ese turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return resul;
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show("Active minimo un día para ese turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return resul;
                }
                if (String.IsNullOrEmpty(txt_descTurno.Text) || string.IsNullOrWhiteSpace(txt_descTurno.Text))
                {
                    MessageBox.Show("Ingrese la descripción del turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return resul;
                }
                ItemGrabar.IdEmpresa = param.IdEmpresa;
                ItemGrabar.tu_descripcion = txt_descTurno.Text;
                ItemGrabar.es_jornada_desfasada = chek_jornada_desfasada.Checked;
                if (checkEstado.Checked == true)
                {
                    ItemGrabar.Estado = "A";
                }
                else
                {
                    ItemGrabar.Estado = "I";

                }
                ItemGrabar.Detalle = ListaGrabarDetTurno;
                resul = true;
                return resul;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public Boolean grabar()
        {
            Boolean resul = false;
            decimal Id=0;
            string mensaje ="";
            try
            {
                if (getInfo())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            ItemGrabar.IdUsuario = param.IdUsuario;
                            ItemGrabar.Fecha_Transac = DateTime.Now;
                            if (busTurno.GuardarTurno(ItemGrabar, ref Id, ref mensaje))
                            { MessageBox.Show("Grabado exitosamente el Turno #" + Id, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); resul = true;
                          //  set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            //    ItemGrabar.IdTurno = Id; SetInfo(ItemGrabar);
                            limpiar();
                            }
                    
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                             ItemGrabar.IdUsuarioUltMod = param.IdUsuario;
                            ItemGrabar.Fecha_UltMod = DateTime.Now;
                            if (busTurno.ModificarTurno(ItemGrabar, mensaje))
                            { MessageBox.Show("Actualizado exitosamente el Turno #" + txtDia.Text, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); resul = true;
                            //set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                //SetInfo(ItemGrabar);
                            limpiar();
                            }
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            if (MessageBox.Show("¿Está seguro que desea anular el reg #: " + ItemGrabar.IdTurno + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                                oFrm.ShowDialog();
                                ItemGrabar.MotiAnula = oFrm.motivoAnulacion;
                                ItemGrabar.IdUsuarioUltAnu = param.IdUsuario;
                                ItemGrabar.Fecha_UltAnu = DateTime.Now;
                                if (busTurno.AnularTurno(ItemGrabar, ref mensaje))
                                {
                                    MessageBox.Show("Anulado exitosamente el Turno #" + txtDia.Text, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); resul = true;
                                    set_Accion(Cl_Enumeradores.eTipo_action.consultar); SetInfo(ItemGrabar);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                   
                }
                return resul;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public void limpiar()
        {
            txt_descTurno.Text="";
            BindListDetTurno = new BindingList<ro_turno_x_tb_dia_Info>((from q in DiasDeLaSeman select new ro_turno_x_tb_dia_Info { Dia = q.ToUpper() }).ToList());
            gridControlDetalleTurno.DataSource = BindListDetTurno;
            lblEstado.Visible = false;
        }
        private void frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmRo_Turno_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }
        
        private void toolStripButtonAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está Seguro que desea Anular el turno?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (busTurno.AnularTurno(ItemGrabar, ref mensaje))
                    {
                        ItemGrabar.Estado = "I";
                        MessageBox.Show("El registro ha sido anulado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEstado.Visible = true;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Turno_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Turno_Mant_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

    }
}
