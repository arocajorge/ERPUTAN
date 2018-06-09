using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Data;
using Core.Erp.Business.General;
///
///katiuska unific 08012014 1441
///
///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Business.Roles
{
    public class ro_calculos_formula_IESS_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_calculos_formula_IESS_Data data = new ro_calculos_formula_IESS_Data();
        public object Eval(string sExpression, string Declaracion, ref string msg,string Parametros)
        {
            try
            {
                if (sExpression != "")
                {
                
              
                    CSharpCodeProvider c = new CSharpCodeProvider();
                    CompilerParameters cp = new CompilerParameters();

                    cp.ReferencedAssemblies.Add("system.dll");
                    cp.CompilerOptions = "/optimize";
                    cp.CompilerOptions = "/t:library";
                    cp.GenerateInMemory = true;
                    cp.GenerateExecutable = false;
                    StringBuilder sb = new StringBuilder("");
                    sb.Append("using System;\n");

                    sb.Append("namespace CSCodeEvaler{ \n");
                    sb.Append("public class CSCodeEvaler{ \n");
                    sb.Append("public Double EvalCode(" + Parametros + "){\n");
                    sb.Append(" " + Declaracion + " \n");
                    sb.Append("return " + sExpression + "; \n");
                    //sb.Append("return rs; \n");
                    sb.Append("} \n");
                    sb.Append("} \n");
                    sb.Append("}\n");

                    CompilerResults cr = c.CompileAssemblyFromSource(cp, sb.ToString());
                    if (cr.Errors.Count > 0)
                    {
                        return "0";
                    }

                    System.Reflection.Assembly a = cr.CompiledAssembly;
                    InstanciaDeFuncion = a.CreateInstance("CSCodeEvaler.CSCodeEvaler");

                    Type t = InstanciaDeFuncion.GetType();
                        mi = t.GetMethod("EvalCode");
                
                
                    return Funcion;
                }
                else
                {
                    msg ="Ingrese una formula correcta para poder evaluarla";
                    return null;
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eval", ex.Message), ex) { EntityType = typeof(ro_calculos_formula_IESS_bus) };

            }
            
        }
        
        object InstanciaDeFuncion;
        object Funcion;
        MethodInfo mi;
      
      
        }
}
