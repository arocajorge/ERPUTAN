using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Data.Inventario_Edehsa;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario_Edehsa
{
    public class in_Categoria_x_Formula_Data
    {

        string mensaje = "";
        public List<in_Categoria_x_Formula> Get_List_Categoria_x_Formula()
        {
            try
            {
                List<in_Categoria_x_Formula> lM = new List<in_Categoria_x_Formula>();
                EntitiesInventarioEdehsa OEUser = new EntitiesInventarioEdehsa();
                //Core.Erp.Data.Inventario_Edehsa.
                var select_ = from TI in OEUser.in_Categoria_x_Formula
                              select TI;


                foreach (var item in select_)
                {
                    in_Categoria_x_Formula dat_ = new in_Categoria_x_Formula();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCategoria = item.IdCategoria;
                    dat_.tiene_longitud = item.tiene_longitud;
                    dat_.tiene_espesor = item.tiene_espesor;
                    dat_.tiene_ancho = item.tiene_ancho;
                    dat_.tiene_alto = item.tiene_alto;
                    dat_.tiene_ceja = item.tiene_ceja;
                    dat_.tiene_diametro = item.tiene_diametro;
                    dat_.densidad = item.densidad;
                    dat_.formula = item.formula;
                    dat_.estado = item.estado;
            
                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }



        public in_Categoria_x_Formula Get_Info_Categoria_x_Formula(int IdCategoria, int IdEmpresa)
        {
            try
            {
                in_Categoria_x_Formula categoria_x_formula = new in_Categoria_x_Formula();
                EntitiesInventarioEdehsa OEt = new EntitiesInventarioEdehsa();
                var categoriaxformula = OEt.in_Categoria_x_Formula.First(var =>
                    var.IdCategoria == IdCategoria && var.IdEmpresa == IdEmpresa);

                categoria_x_formula.formula = categoriaxformula.formula;
                categoria_x_formula.tiene_longitud = categoriaxformula.tiene_longitud;
                categoria_x_formula.tiene_espesor = categoriaxformula.tiene_espesor;
                categoria_x_formula.tiene_ancho = categoriaxformula.tiene_ancho;
                categoria_x_formula.tiene_alto = categoriaxformula.tiene_alto;
                categoria_x_formula.tiene_ceja = categoriaxformula.tiene_ceja;
                categoria_x_formula.tiene_diametro = categoriaxformula.tiene_diametro;
                categoria_x_formula.estado = categoriaxformula.estado;


                return categoria_x_formula;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public List<in_Categoria_x_Formula_Info> Get_list_Categoria_x_Formula(int idEmpresa, int idCategoria)
        {
            try
            {
                List<in_Categoria_x_Formula_Info> lM = new List<in_Categoria_x_Formula_Info>();
                EntitiesInventarioEdehsa OECate_x_formula_Info = new EntitiesInventarioEdehsa();
                var selectCate_x_formula_Info = from C in OECate_x_formula_Info.in_Categoria_x_Formula
                                                where C.IdEmpresa == idEmpresa
                                                 && C.IdCategoria == idCategoria
                                                select C;

                foreach (var item in selectCate_x_formula_Info)
                {
                    //in_Categoria_x_Formula_Info 
                    in_Categoria_x_Formula_Info info = new in_Categoria_x_Formula_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdCategoria = item.IdCategoria;
                    info.descripcion_corta = item.descripcion_corta;
                    info.tiene_longitud = item.tiene_longitud;
                    info.tiene_espesor = item.tiene_espesor;
                    info.tiene_ancho = item.tiene_ancho;
                    info.tiene_alto = item.tiene_alto;
                    info.tiene_ceja = item.tiene_ceja;
                    info.tiene_diametro = item.tiene_diametro;
                    info.formula = item.formula;
                    info.densidad = item.densidad;
                    info.estado = item.estado;
                    //prd.estado = (item.estado eq 1) ? "ACTIVO" : "*ANULADO*";

                    // prd.Sestado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    lM.Add(info);
                    //lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public int GetId(int idempresa)
        {
            try
            {
                int Id;
                EntitiesInventarioEdehsa OEPin_Categoria_x_Formula = new EntitiesInventarioEdehsa();
                var select = from q in OEPin_Categoria_x_Formula.in_Categoria_x_Formula
                             where q.IdEmpresa == idempresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    EntitiesInventarioEdehsa OEPin_Categoria_x_Formula1 = new EntitiesInventarioEdehsa();
                    var select_pv = (from q in OEPin_Categoria_x_Formula1.in_Categoria_x_Formula
                                     where q.IdEmpresa == idempresa
                                     select q.IdCategoria).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }

        }

        public decimal GetSecuencia(int IdEmpresa)
        {
            try
            {
                decimal Secuencia;
                EntitiesBanco OETalonario = new EntitiesBanco();
                var select = (from q in OETalonario.ba_Talonario_cheques_x_banco
                              where q.IdEmpresa == IdEmpresa
                              select q.secuencia).Max();

                if (select == null)
                {
                    Secuencia = 1;
                }
                else
                {
                    Secuencia = Convert.ToDecimal(select.ToString()) + 1;
                }
                return Secuencia;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }



        public Boolean GrabarDB(in_Categoria_x_Formula_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesInventarioEdehsa context = new EntitiesInventarioEdehsa())
                {

                    var address = new in_Categoria_x_Formula();
                    int idpv = GetId(info.IdEmpresa);
                    id = idpv;
                    address.IdEmpresa = info.IdEmpresa;


                    address.IdCategoria = info.IdCategoria;
                    address.tiene_longitud = info.tiene_longitud;
                    address.tiene_espesor = info.tiene_espesor;
                    address.tiene_ancho = info.tiene_ancho;
                    address.tiene_alto = info.tiene_alto;
                    address.tiene_ceja = info.tiene_ceja;
                    address.tiene_diametro = info.tiene_diametro;
                    address.densidad = info.densidad;
                    address.formula = info.formula;
                    address.estado = info.estado;


                    context.in_Categoria_x_Formula.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro de la Categoria, sus dimensiones y formula: "
                        //+ info.tp_descripcion 
                        + " exitosamente.";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(mensaje);
            }
        }

    }
}
