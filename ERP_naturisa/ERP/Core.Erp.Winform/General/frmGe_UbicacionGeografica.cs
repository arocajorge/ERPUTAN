using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace Core.Erp.Winform.General
{
    public partial class frmGe_UbicacionGeografica : DevExpress.XtraEditors.XtraForm
    {
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        vwtb_Ubicacion_Geografica_Bus busUbica = new vwtb_Ubicacion_Geografica_Bus();
        List<vwtb_Ubicacion_Geografica_Info> lstUnica = new List<vwtb_Ubicacion_Geografica_Info>();
        vwtb_Ubicacion_Geografica_Info infoUbica = new vwtb_Ubicacion_Geografica_Info();
        FrmGe_Pais_Mant frm_Pais = new FrmGe_Pais_Mant();
        frmGe_Provinvia_Mant frm_Provi = new frmGe_Provinvia_Mant();
        frmGe_Ciudad_Mant frm_Ciu = new frmGe_Ciudad_Mant();
        tb_pais_Bus bus_Pais = new tb_pais_Bus();
        tb_Provincia_Bus bus_Provi = new tb_Provincia_Bus();
        tb_Ciudad_Bus bus_Ciu = new tb_Ciudad_Bus();

        public frmGe_UbicacionGeografica()
        {
            InitializeComponent();
        }

        private void frmGe_UbicacionGeografica_Load(object sender, EventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void CargarData()
        {
            try
            {
                lstUnica = busUbica.Get_List_Ubicacion_Geo();
                treeListUbicacionGeo.DataSource = lstUnica;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      

        private void btnNuevo_Pais_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Pais = new FrmGe_Pais_Mant();
                frm_Pais.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm_Pais.Show();
                frm_Pais.event_FrmGe_Pais_Mant_FormClosing += new FrmGe_Pais_Mant.delegate_FrmGe_Pais_Mant_FormClosing(frm_Pais_event_FrmGe_Pais_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_Pais_event_FrmGe_Pais_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Provincia_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Provi = new frmGe_Provinvia_Mant();
                frm_Provi.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm_Provi.Show();
                frm_Provi.event_frmGe_Provinvia_Mant_FormClosing += new frmGe_Provinvia_Mant.delegate_frmGe_Provinvia_Mant_FormClosing(frm_Provi_event_frmGe_Provinvia_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_Provi_event_frmGe_Provinvia_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Ciudad_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Ciu = new frmGe_Ciudad_Mant();
                frm_Ciu.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm_Ciu.Show();
                frm_Ciu.event_frmGe_Ciudad_Mant_FormClosing += new frmGe_Ciudad_Mant.delegate_frmGe_Ciudad_Mant_FormClosing(frm_Ciu_event_frmGe_Ciudad_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_Ciu_event_frmGe_Ciudad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificar_Pais_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarSeleccion_Form(Cl_Enumeradores.eTipoUbicacion_Geo.Pais, Cl_Enumeradores.eTipo_action.actualizar);           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnModificar_Provincia_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarSeleccion_Form(Cl_Enumeradores.eTipoUbicacion_Geo.Provincia, Cl_Enumeradores.eTipo_action.actualizar);     
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Ciudad_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarSeleccion_Form(Cl_Enumeradores.eTipoUbicacion_Geo.Ciudad, Cl_Enumeradores.eTipo_action.actualizar);     

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Pais_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarSeleccion_Form(Cl_Enumeradores.eTipoUbicacion_Geo.Pais , Cl_Enumeradores.eTipo_action.consultar);   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Provinica_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarSeleccion_Form(Cl_Enumeradores.eTipoUbicacion_Geo.Provincia, Cl_Enumeradores.eTipo_action.consultar);   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Ciudad_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarSeleccion_Form(Cl_Enumeradores.eTipoUbicacion_Geo.Ciudad, Cl_Enumeradores.eTipo_action.consultar);   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ValidarSeleccion_Form(Cl_Enumeradores.eTipoUbicacion_Geo Cod_Ubicacion, Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                if (infoUbica != null)
                {
                    switch (Cod_Ubicacion)
                    {
                        case Cl_Enumeradores.eTipoUbicacion_Geo.Pais:
                            if (infoUbica.Nivel == 1)
                            {
                                frm_Pais = new FrmGe_Pais_Mant();
                                frm_Pais.setAccion(Accion);
                                frm_Pais.SeInfo(bus_Pais.Get_Info_pais(infoUbica.IdPais));
                                frm_Pais.Show();
                                frm_Pais.event_FrmGe_Pais_Mant_FormClosing += new FrmGe_Pais_Mant.delegate_FrmGe_Pais_Mant_FormClosing(frm_Pais_event_FrmGe_Pais_Mant_FormClosing);
                            }
                            else
                            {
                                MessageBox.Show("Ubiquese en un Pais para poderlo Modificar");
                            }
                            break;

                        case Cl_Enumeradores.eTipoUbicacion_Geo.Provincia:
                            if (infoUbica.Nivel == 2)
                            {
                                frm_Provi = new frmGe_Provinvia_Mant();
                                frm_Provi.setAccion(Accion);
                                frm_Provi.SeInfo(bus_Provi.Get_Info_Provincia(infoUbica.IdProvincia));
                                frm_Provi.Show();
                                frm_Provi.event_frmGe_Provinvia_Mant_FormClosing += new frmGe_Provinvia_Mant.delegate_frmGe_Provinvia_Mant_FormClosing(frm_Provi_event_frmGe_Provinvia_Mant_FormClosing);
                            }
                            else
                            {
                                MessageBox.Show("Ubiquese en una Provincia para poderlo Modificar");
                            }
                            break;

                        case Cl_Enumeradores.eTipoUbicacion_Geo.Ciudad:
                            if (infoUbica.Nivel == 3)
                            {
                                frm_Ciu = new frmGe_Ciudad_Mant();
                                frm_Ciu.setAccion(Accion);
                                frm_Ciu.SeInfo(bus_Ciu.Get_Info_Ciudad(infoUbica.IdCiudad));
                                frm_Ciu.Show();
                                frm_Ciu.event_frmGe_Ciudad_Mant_FormClosing += new frmGe_Ciudad_Mant.delegate_frmGe_Ciudad_Mant_FormClosing(frm_Ciu_event_frmGe_Ciudad_Mant_FormClosing);
                            }
                            else
                            {
                                MessageBox.Show("Ubiquese en una Ciudad para poderlo Modificar");
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void treeListUbicacionGeo_BeforeFocusNode(object sender, DevExpress.XtraTreeList.BeforeFocusNodeEventArgs e)
       {
            try
            {
                TreeListNode nodeSeleccionado = (TreeListNode)e.Node;
                infoUbica = new vwtb_Ubicacion_Geografica_Info();

                infoUbica = (vwtb_Ubicacion_Geografica_Info)this.treeListUbicacionGeo.GetDataRecordByNode(nodeSeleccionado);             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void treeListUbicacionGeo_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {                
                TreeListHitInfo hitInfo = treeListUbicacionGeo.CalcHitInfo(e.Location);
                if (e.Button == MouseButtons.Right && hitInfo.HitInfoType == HitInfoType.Cell)
                    hitInfo.Node.Selected = !hitInfo.Node.Selected;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoNodo_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Evento_btns(Cl_Enumeradores.eTipo_action.grabar);         
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarNodo_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Evento_btns(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarNodo_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Evento_btns(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Menu_Evento_btns(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                if (infoUbica != null)
                {
                    switch (infoUbica.Nivel)
                    {
                        case 1:
                                frm_Pais = new FrmGe_Pais_Mant();
                                frm_Pais.setAccion(Accion);
                                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                                    frm_Pais.SeInfo(bus_Pais.Get_Info_pais(infoUbica.IdPais));
                                frm_Pais.Show();
                                frm_Pais.event_FrmGe_Pais_Mant_FormClosing += new FrmGe_Pais_Mant.delegate_FrmGe_Pais_Mant_FormClosing(frm_Pais_event_FrmGe_Pais_Mant_FormClosing);
                                break;

                        case 2:
                                frm_Provi = new frmGe_Provinvia_Mant();
                                frm_Provi.setAccion(Accion);
                                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                                    frm_Provi.SeInfo(bus_Provi.Get_Info_Provincia(infoUbica.IdProvincia));
                                else
                                    frm_Provi.IdPais = infoUbica.IdPais;
                                frm_Provi.Show();
                                frm_Provi.event_frmGe_Provinvia_Mant_FormClosing += new frmGe_Provinvia_Mant.delegate_frmGe_Provinvia_Mant_FormClosing(frm_Provi_event_frmGe_Provinvia_Mant_FormClosing);
                         
                                 break;

                        case 3:                            
                                frm_Ciu = new frmGe_Ciudad_Mant();
                                frm_Ciu.setAccion(Accion);
                                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                                    frm_Ciu.SeInfo(bus_Ciu.Get_Info_Ciudad(infoUbica.IdCiudad));
                                else
                                {
                                    frm_Ciu.IdProvincia = infoUbica.IdProvincia;
                                    frm_Ciu.IdPais = infoUbica.IdPais;
                                }
                                frm_Ciu.Show();
                                frm_Ciu.event_frmGe_Ciudad_Mant_FormClosing += new frmGe_Ciudad_Mant.delegate_frmGe_Ciudad_Mant_FormClosing(frm_Ciu_event_frmGe_Ciudad_Mant_FormClosing);
                            
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}