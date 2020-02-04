using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_PaisProvinciaCiudad : UserControl
    {
        #region "Variable"
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        FrmGe_Pais_Mant frm_Pais = new FrmGe_Pais_Mant();
        frmGe_Provinvia_Mant frm_Provi = new frmGe_Provinvia_Mant();
        frmGe_Ciudad_Mant frm_Ciu = new frmGe_Ciudad_Mant();
        frmGe_Parroquia_Mant frm_parro = new frmGe_Parroquia_Mant();

        tb_pais_Info InfoPais = new tb_pais_Info();
        tb_provincia_Info InfoProvincia = new tb_provincia_Info();
        tb_ciudad_Info InfoCiudad = new tb_ciudad_Info();
        List<tb_pais_Info> lstInfoPais = new List<tb_pais_Info>();
        List<tb_provincia_Info> lstInfoProvincia = new List<tb_provincia_Info>();
        List<tb_ciudad_Info> lstInfoCiudad = new List<tb_ciudad_Info>();
        tb_pais_Bus busPais = new tb_pais_Bus();
        tb_Provincia_Bus busProv = new tb_Provincia_Bus();
        tb_Ciudad_Bus busCiudad = new tb_Ciudad_Bus();
        tb_parroquia_Bus BusParroquia = new tb_parroquia_Bus();
        List<tb_parroquia_Info> lstInfoParroquia = new List<tb_parroquia_Info>();
        tb_parroquia_Info InfoParroquia = new tb_parroquia_Info();

        



        #endregion

        public UCGe_PaisProvinciaCiudad()
        {
            try
            {
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        #region "Metodos"
        public void CargarComboPais()
        {
            try
            {
                // Pais
                lstInfoPais = busPais.Get_List_pais();
                cmbPais.Properties.DataSource = lstInfoPais;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void CargarComboProvincia(string IdPais)
        {
            try
            {
                //Provincia
                lstInfoProvincia = busProv.Get_List_Provincia(IdPais);
                cmbProvincia.Properties.DataSource = lstInfoProvincia;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void CargarComboCiudad(string IdProvincia)
        {
            try
            {
                lstInfoCiudad = busCiudad.Get_List_Ciudad(IdProvincia);
                cmbCiudad.Properties.DataSource = lstInfoCiudad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void CargarComboParroquia(string IdCiudad_Canton)
        {
            try
            {
                lstInfoParroquia = BusParroquia.Get_List_Parroquias(IdCiudad_Canton);
                cmbParroquia.Properties.DataSource = lstInfoParroquia;


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion     

        public Boolean Visible_combo_parroquia
        {
            get
            {

                return panelParroquia.Visible;
            }
            set
            {
                panelParroquia.Visible = value;
            }
        }

        #region Visual

        #endregion

        private void nuevoPais_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Evento_btns(Cl_Enumeradores.eTipo_action.grabar, Cl_Enumeradores.eTipoUbicacion_Geo.Pais);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }      

        private void nuevoProvincia_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Evento_btns(Cl_Enumeradores.eTipo_action.grabar, Cl_Enumeradores.eTipoUbicacion_Geo.Provincia);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void nuevoCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Evento_btns(Cl_Enumeradores.eTipo_action.grabar, Cl_Enumeradores.eTipoUbicacion_Geo.Ciudad);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void modificarPais_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPais.EditValue != null)
                {
                    get_Info_Pais();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.actualizar, Cl_Enumeradores.eTipoUbicacion_Geo.Pais);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void modificarProvinica_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProvincia.EditValue != null)
                {
                    get_Info_Provincia();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.actualizar, Cl_Enumeradores.eTipoUbicacion_Geo.Provincia);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void modificarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCiudad.EditValue != null)
                {
                    get_Info_Ciudad();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.actualizar, Cl_Enumeradores.eTipoUbicacion_Geo.Ciudad);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void consultarPais_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPais.EditValue != null)
                {
                    get_Info_Pais();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.consultar, Cl_Enumeradores.eTipoUbicacion_Geo.Pais);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void consultarProvincia_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProvincia.EditValue != null)
                {
                    get_Info_Provincia();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.consultar, Cl_Enumeradores.eTipoUbicacion_Geo.Provincia);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void consultarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCiudad.EditValue != null)
                {
                    get_Info_Ciudad();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.consultar, Cl_Enumeradores.eTipoUbicacion_Geo.Ciudad);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones_Pais.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmbPais.Properties.ReadOnly = true;

                cmb_Acciones_provi.Enabled = false;
                cmbProvincia.Properties.ReadOnly = true;

                cmb_Acciones_ciudad.Enabled = false;
                cmbCiudad.Properties.ReadOnly = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void Inicializar_Catalogos()
        {
            try
            {
                cmbPais.EditValue = null;
                cmbProvincia.EditValue = null;
                cmbCiudad.EditValue = null;
                cmbParroquia.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        void Menu_Evento_btns(Cl_Enumeradores.eTipo_action Accion, Cl_Enumeradores.eTipoUbicacion_Geo Cod_Ubicacion)
        {
            try
            {
                switch (Cod_Ubicacion)
                {
                    case Cl_Enumeradores.eTipoUbicacion_Geo.Pais:
                        frm_Pais = new FrmGe_Pais_Mant();
                        frm_Pais.setAccion(Accion);
                        if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        {
                            frm_Pais.SeInfo(InfoPais);                            
                        }
                        frm_Pais.Show();
                        frm_Pais.event_FrmGe_Pais_Mant_FormClosing += new FrmGe_Pais_Mant.delegate_FrmGe_Pais_Mant_FormClosing(frm_Pais_event_FrmGe_Pais_Mant_FormClosing);
                        
                        break;

                    case Cl_Enumeradores.eTipoUbicacion_Geo.Provincia:
                        frm_Provi = new frmGe_Provinvia_Mant();
                        frm_Provi.setAccion(Accion);
                        if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        {
                            frm_Provi.SeInfo(InfoProvincia);                            
                        }
                        frm_Provi.Show();
                        frm_Provi.event_frmGe_Provinvia_Mant_FormClosing += new frmGe_Provinvia_Mant.delegate_frmGe_Provinvia_Mant_FormClosing(frm_Provi_event_frmGe_Provinvia_Mant_FormClosing);
                        break;

                    case Cl_Enumeradores.eTipoUbicacion_Geo.Ciudad:
                        frm_Ciu = new frmGe_Ciudad_Mant();
                            frm_Ciu.setAccion(Accion);
                        if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        {
                            frm_Ciu.SeInfo(InfoCiudad);
                        }
                        frm_Ciu.Show();
                        frm_Ciu.event_frmGe_Ciudad_Mant_FormClosing += new frmGe_Ciudad_Mant.delegate_frmGe_Ciudad_Mant_FormClosing(frm_Ciu_event_frmGe_Ciudad_Mant_FormClosing);
                        break;

                    case Cl_Enumeradores.eTipoUbicacion_Geo.Parroquia:

                        frm_parro = new frmGe_Parroquia_Mant();
                        frm_parro.setAccion(Accion);
                        if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        {
                            frm_parro.SeInfo(InfoParroquia);
                        }
                        frm_parro.Show();
                        frm_parro.event_frmGe_Parroquia_Mant_FormClosing += frm_parro_event_frmGe_Parroquia_Mant_FormClosing;
                        break;

                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        void frm_parro_event_frmGe_Parroquia_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                CargarComboParroquia(Convert.ToString(cmbCiudad.EditValue));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_Ciu_event_frmGe_Ciudad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarComboCiudad(Convert.ToString(cmbCiudad.EditValue));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        void frm_Provi_event_frmGe_Provinvia_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarComboProvincia(Convert.ToString(cmbPais.EditValue));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        void frm_Pais_event_FrmGe_Pais_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarComboPais();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public tb_pais_Info get_Info_Pais()
        {
            try
            {
                InfoPais = new tb_pais_Info();
                if (cmbPais.EditValue != null)
                    InfoPais = lstInfoPais.First(v => v.IdPais == Convert.ToString(cmbPais.EditValue));
                else
                    return null;
                return InfoPais;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
                return null;
            }
        }

        public tb_provincia_Info get_Info_Provincia()
        {
            try
            {
                if (cmbProvincia.EditValue != null)
                    InfoProvincia = lstInfoProvincia.First(v => v.IdProvincia == Convert.ToString(cmbProvincia.EditValue));
                else
                    return null;
                return InfoProvincia;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
                return null;
            }
        }

        public tb_ciudad_Info get_Info_Ciudad()
        {
            try
            {
                if (cmbCiudad.EditValue != null)
                    InfoCiudad = lstInfoCiudad.FirstOrDefault(v => v.IdCiudad == Convert.ToString(cmbCiudad.EditValue));
                else
                    return null;
                return InfoCiudad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
                return null;
            }
        }


        public tb_parroquia_Info get_Info_Parroquia()
        {
            try
            {
                if (cmbParroquia.EditValue != null)
                    InfoParroquia = lstInfoParroquia.FirstOrDefault(v => v.IdParroquia == Convert.ToString(cmbParroquia.EditValue));
                else
                    return null;
                return InfoParroquia;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public void set_InfoPais(string IdPais)
        {
            try
            {
                cmbPais.EditValue = IdPais;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void set_InfoProvincia(string IdProvincia)
        {
            try
            {
                cmbProvincia.EditValue = IdProvincia;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void set_InfoCiudad(string IdCiudad)
        {
            try
            {
                cmbCiudad.EditValue = IdCiudad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        public void set_InfoParroquia(string IdParroquia)
        {
            try
            {
                cmbParroquia.EditValue = IdParroquia;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCGe_PaisProvinciaCiudad_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboPais();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
                
            }
        }

        private void nueva_parroquia_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Evento_btns(Cl_Enumeradores.eTipo_action.grabar, Cl_Enumeradores.eTipoUbicacion_Geo.Parroquia);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificar_parroquia_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCiudad.EditValue != null)
                {
                    get_Info_Ciudad();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.actualizar, Cl_Enumeradores.eTipoUbicacion_Geo.Parroquia);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultar_parroquia_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbCiudad.EditValue != null)
                {
                    get_Info_Ciudad();
                    Menu_Evento_btns(Cl_Enumeradores.eTipo_action.consultar, Cl_Enumeradores.eTipoUbicacion_Geo.Parroquia);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Acciones_parroquia_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones_Parroquia.Show(cmb_Acciones_parroquia, new Point(0, cmb_Acciones_parroquia.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Acciones_provi_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones_Provincia.Show(cmb_Acciones_parroquia, new Point(0, cmb_Acciones_parroquia.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Acciones_ciudad_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones_Ciudad.Show(cmb_Acciones_ciudad, new Point(0, cmb_Acciones_ciudad.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        

        private void cmbPais_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPais.EditValue != null)
                {
                    CargarComboProvincia(Convert.ToString(cmbPais.EditValue));
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void cmbProvincia_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbProvincia.EditValue != null)
                {
                    CargarComboCiudad(Convert.ToString(cmbProvincia.EditValue));
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        private void cmbCiudad_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCiudad.EditValue != null)
                {
                    CargarComboParroquia(Convert.ToString(cmbCiudad.EditValue));
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
       

        
    }
}
