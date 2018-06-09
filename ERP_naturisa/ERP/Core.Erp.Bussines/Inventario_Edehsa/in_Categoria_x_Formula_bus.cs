using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.Inventario_Edehsa;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario_Edehsa;
using System.Data;
using NCalc;

namespace Core.Erp.Business.Inventario_Edehsa
{
    public class in_Categoria_x_Formula_bus
    {
        #region Declaración de Variables

        string mensaje = "";
        in_Categoria_x_Formula_Data odata = new in_Categoria_x_Formula_Data();
        List<in_Categoria_x_Formula_Info> Categoria_x_FormulaList = new List<in_Categoria_x_Formula_Info>();

        bool bTiene_alto = false;
        bool bTiene_ancho = false;
        bool bTiene_ceja = false;
        bool bTiene_logitud = false;
        bool bTiene_espesor = false;
        bool bTiene_diametro = false;
        string sFormula_x_Categoria = "";

        #endregion

        public List<in_Categoria_x_Formula_Info> Get_List_Categoria_x_Formula(int IdEmpresa, int idcategoria)
        {
            try
            {
                return odata.Get_list_Categoria_x_Formula(IdEmpresa, idcategoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCatergori_x_Formula", ex.Message), ex) { EntityType = typeof(in_Categoria_x_Formula_bus) };
            }

        }

        public double CalcularPesoTeorico(int IdEmpresa, int idcategoria, double alto = 0, double ancho = 0, double ceja = 0, double longitud = 0, double espesor = 0, double diametro = 0)
        {

            try
            {
                double valorPesoTeorico = 0;

                Categoria_x_FormulaList = this.Get_List_Categoria_x_Formula(IdEmpresa, idcategoria);

                bTiene_alto = (bool)Categoria_x_FormulaList[0].tiene_alto;
                bTiene_ancho = (bool)Categoria_x_FormulaList[0].tiene_ancho;
                bTiene_ceja = (bool)Categoria_x_FormulaList[0].tiene_ceja;
                bTiene_logitud = (bool)Categoria_x_FormulaList[0].tiene_longitud;
                bTiene_espesor = (bool)Categoria_x_FormulaList[0].tiene_espesor;
                bTiene_diametro = (bool)Categoria_x_FormulaList[0].tiene_diametro;

                ///BLOQUE DE OBTNER FORMULA /////
                sFormula_x_Categoria = Categoria_x_FormulaList[0].formula;
                //EXPRESION uso de LIBRERIA NCALC
                Expression pesoTeorico = new Expression(sFormula_x_Categoria);

                if (bTiene_alto == true) { pesoTeorico.Parameters["Alto"] = alto; }
                if (bTiene_ancho == true) { pesoTeorico.Parameters["Ancho"] = ancho; }
                if (bTiene_ceja == true) { pesoTeorico.Parameters["Ceja"] = ceja; }
                if (bTiene_logitud == true) { pesoTeorico.Parameters["Longitud"] = longitud; }
                if (bTiene_espesor == true) { pesoTeorico.Parameters["Espesor"] = espesor; }
                if (bTiene_diametro == true) { pesoTeorico.Parameters["Diametro"] = diametro; }

                valorPesoTeorico = Convert.ToDouble(pesoTeorico.Evaluate());

                return valorPesoTeorico;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_Categoria_x_Formula_bus) };

            }
        }


    }

}
