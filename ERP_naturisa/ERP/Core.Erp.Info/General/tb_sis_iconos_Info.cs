using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Core.Erp.Info.General
{
   public class tb_sis_iconos_Info
    {
        public string IdIcono { get; set; }
        public Byte[] Icono { get; set; }
        public Image Icono_image { get; set; }
        public string descripcion { get; set; }
        public string Extencion { get; set; }
        public string FullName { get; set; }
        public decimal Length { get; set; }
        public string DirectoryName { get; set; }

       
       public tb_sis_iconos_Info()
       {

       }
    }
}
