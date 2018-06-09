using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Core.Erp.Info.General
{
  public class cl_Control_De_Erro
    {



        public void VerificarCarpete()
        {
            string ruta = "C:\\LogError";

            if (!(Directory.Exists(ruta)))
            {
                string activeDir = @"c:\";
                string newPath = System.IO.Path.Combine(activeDir, "LogError");
                System.IO.Directory.CreateDirectory(newPath);

            }
        }

        public Boolean capturalog(string msj, string transaccion)
        {

            string newFileName = System.IO.Path.GetRandomFileName();
            string fecha = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();


            string activeDir = @"c:\";
            string newPath = System.IO.Path.Combine(activeDir, "LogError");
            string nameTEx = fecha + "_ERP.txt";
            newPath = System.IO.Path.Combine(newPath, nameTEx);
            string texto;
            VerificarCarpete();
            if (!System.IO.File.Exists(newPath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(newPath))
                {
                    string fic = @"c:\\LogError\\" + nameTEx;
                    texto = msj;
                   // fs.Close();


                }




                System.IO.StreamWriter sw = new System.IO.StreamWriter(newPath);
                sw.WriteLine(transaccion);
                sw.WriteLine(msj);

                sw.Close();
            }

            return true;
        }




      public cl_Control_De_Erro()
      {

      }
    }
}
