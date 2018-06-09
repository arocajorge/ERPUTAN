using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Categoria_Linea : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        List<in_categorias_Info> CategoriaList = new List<in_categorias_Info>();
        in_categorias_Info CategoriaInfo = new in_categorias_Info();
        in_categorias_bus CategBus = new in_categorias_bus();

        List<in_linea_info> LineaList = new List<in_linea_info>();
        in_linea_info LineaInfo = new in_linea_info();
        in_linea_Bus lineaBus = new in_linea_Bus();


        List<in_grupo_info> GrupoList = new List<in_grupo_info>();
        in_grupo_Bus GrupoBus = new in_grupo_Bus();
        in_grupo_info GrupoInfo = new in_grupo_info();


        List<in_subgrupo_info> SubGrupoList = new List<in_subgrupo_info>();
        in_subgrupo_Bus SubGrupoBus = new in_subgrupo_Bus();


        public delegate void delegate_cmb_subgrupo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_subgrupo_EditValueChanged event_cmb_subgrupo_EditValueChanged;

        public delegate void delegate_cmb_categoria_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_categoria_EditValueChanged event_delegate_cmb_categoria_EditValueChanged;

        private Boolean Cargar_todos = true;
        public Boolean Visible_Todos_cmb_Categoria { get { return this.Cargar_todos; } set { this.Cargar_todos = value; } }

        public in_subgrupo_info SubGrupoInfo { get; set; }

        string sIdCategoria = "";
        int iIdLinea = 0;
        int iIdGrupo = 0;
        int iIdSubGrupo = 0;



        public UCIn_Categoria_Linea()
        {
            InitializeComponent();
            event_cmb_subgrupo_EditValueChanged += UCIn_Categoria_Linea_event_cmb_subgrupo_EditValueChanged;
            event_delegate_cmb_categoria_EditValueChanged += UCIn_Categoria_Linea_event_delegate_cmb_categoria_EditValueChanged;
        }

        void UCIn_Categoria_Linea_event_delegate_cmb_categoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCIn_Categoria_Linea_event_cmb_subgrupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCIn_Categoria_Linea_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());             
            }
        }

        private void cargar_combos()
        {
            try
            {
                CategoriaList = CategBus.Get_List_categorias(param.IdEmpresa);
                
                if (Visible_Todos_cmb_Categoria == true)
                {
                    in_categorias_Info Categoria_info = new in_categorias_Info();
                    Categoria_info.IdCategoria = "000";
                    Categoria_info.ca_Categoria = "TODOS";
                    CategoriaList.Add(Categoria_info);
                }
                CategoriaList.OrderByDescending(v => v.IdCategoria);
                
                cmb_categoria.Properties.DataSource = CategoriaList;
                //cmb_categoria.EditValue = CategoriaList.FirstOrDefault().IdCategoria;
                //sIdCategoria = cmb_categoria.EditValue.ToString();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmb_linea_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_grupo.EditValue = null;
                if (cmb_linea.EditValue == null)
                    return;
                iIdLinea = Convert.ToInt32(cmb_linea.EditValue);
                GrupoList = GrupoBus.Get_List_Grupo(param.IdEmpresa, sIdCategoria, iIdLinea);
                cmb_grupo.Properties.DataSource = GrupoList;


                set_item_Grupo_Linea_NoDisponible();


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());           
            }
        }

        private void cmb_categoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_linea.EditValue = null;
                if (cmb_categoria.EditValue == null)
                    return;
                sIdCategoria = cmb_categoria.EditValue.ToString();
                LineaList = lineaBus.Get_List_Linea(param.IdEmpresa, sIdCategoria);
                
                cmb_linea.Properties.DataSource = LineaList;
                event_delegate_cmb_categoria_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                 
            }
        }

        private void cmb_grupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_subgrupo.EditValue = null;
                if (cmb_grupo.EditValue == null)
                    return;
                iIdGrupo =Convert.ToInt32(cmb_grupo.EditValue);
                SubGrupoList = SubGrupoBus.ObtenerListSubGrupo(param.IdEmpresa, sIdCategoria, iIdLinea, iIdGrupo);
                cmb_subgrupo.Properties.DataSource = SubGrupoList;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public string get_item_Categria()
        {
            try
            {
                return Convert.ToString(cmb_categoria.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public void set_item_Catgoria(string IdCategoria)
        {
            try
            {
                cmb_categoria.EditValue = IdCategoria;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public int get_item_Linea()
        {
            try
            {
                return Convert.ToInt32(cmb_linea.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }
        }

        public void set_item_Linea(int IdLinea)
        {
            try
            {
                cmb_linea.EditValue = IdLinea;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public int get_item_Grupo()
        {
            try
            {
                return Convert.ToInt32(cmb_grupo.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                return 0;
            }
        }

        public void set_item_Grupo(int IdGrupo)
        {
            try
            {
                cmb_grupo.EditValue = IdGrupo;
                //cmb_grupo.EditValue = 1;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public int get_item_SubGrupo()
        {
            try
            {
                return Convert.ToInt32(cmb_subgrupo.EditValue);
                //return 1;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                return 0;
            }
        }

        public void set_item_SubGrupo(int IdSubGrupo)
        {
            try
            {
                cmb_subgrupo.EditValue = IdSubGrupo;
                //cmb_subgrupo.EditValue = 1;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_item_Grupo_Linea_NoDisponible()
        {
            set_item_Grupo(1);

            cmb_subgrupo.EditValue = null;
            if (cmb_grupo.EditValue == null)
                return;
            iIdGrupo = Convert.ToInt32(cmb_grupo.EditValue);
            SubGrupoList = SubGrupoBus.ObtenerListSubGrupo(param.IdEmpresa, sIdCategoria, iIdLinea, iIdGrupo);
            cmb_subgrupo.Properties.DataSource = SubGrupoList;
            set_item_SubGrupo(1);

        }
        private void cmb_subgrupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_subgrupo.EditValue == null)
                    return;

                    string IdCategoria = "";
                    int IdLinea = 0;
                    int IdGrupo = 0;
                    int IdSubGrupo = 0;

                    IdCategoria = Convert.ToString(cmb_categoria.EditValue);
                    IdLinea = Convert.ToInt32(cmb_linea.EditValue);
                    IdGrupo = Convert.ToInt32(cmb_grupo.EditValue);
                    IdSubGrupo = Convert.ToInt32(cmb_subgrupo.EditValue);

                    SubGrupoInfo = new in_subgrupo_info();
                    SubGrupoInfo = SubGrupoBus.ObtenerInfoSubGrupo(param.IdEmpresa, IdCategoria, IdLinea, IdGrupo, IdSubGrupo);
                    event_cmb_subgrupo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_categorias_Info Get_info_categoria()
        {
            try
            {
                in_categorias_Info info = new in_categorias_Info();

                if (cmb_categoria.EditValue == null) return null;

                info = CategoriaList.FirstOrDefault(q => q.IdCategoria == Convert.ToString(cmb_categoria.EditValue));

                return info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public in_linea_info Get_info_linea()
        {
            try
            {
                in_linea_info info = new in_linea_info();

                if (cmb_linea.EditValue == null) return null;

                info = LineaList.FirstOrDefault(q => q.IdCategoria == Convert.ToString(cmb_categoria.EditValue) && q.IdLinea == Convert.ToInt32(cmb_linea.EditValue));

                return info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public in_grupo_info Get_info_grupo()
        {
            try
            {
                in_grupo_info info = new in_grupo_info();

                if (cmb_subgrupo.EditValue == null) return null;

                info = GrupoList.FirstOrDefault(q => q.IdCategoria == Convert.ToString(cmb_categoria.EditValue) && q.IdLinea == Convert.ToInt32(cmb_linea.EditValue) && q.IdGrupo == Convert.ToInt32(cmb_grupo.EditValue));

                return info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public in_subgrupo_info Get_info_subgrupo()
        {
            try
            {
                in_subgrupo_info info = new in_subgrupo_info();

                if (cmb_grupo.EditValue == null) return null;

                info = SubGrupoList.FirstOrDefault(q => q.IdCategoria == Convert.ToString(cmb_categoria.EditValue) && q.IdLinea == Convert.ToInt32(cmb_linea.EditValue) && q.IdGrupo == Convert.ToInt32(cmb_grupo.EditValue) && q.IdSubgrupo == Convert.ToInt32(cmb_subgrupo.EditValue));

                return info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public void inicializar_controles()
        {
            try
            {
                cmb_subgrupo.EditValue = null;
                cmb_grupo.EditValue = null;
                cmb_linea.EditValue = null;
                cmb_categoria.EditValue = null;
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
