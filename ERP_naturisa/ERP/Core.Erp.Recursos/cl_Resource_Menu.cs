using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Recursos
{
   public class cl_Resource_Menu
    {
       

           private static global::System.Resources.ResourceManager resourceMan;

           private static global::System.Globalization.CultureInfo resourceCulture;

           [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
           internal cl_Resource_Menu()
           {
           }


           /// <summary>
           ///   Returns the cached ResourceManager instance used by this class.
           /// </summary>
           [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
           internal static global::System.Resources.ResourceManager ResourceManager
           {
               get
               {
                   if (object.ReferenceEquals(resourceMan, null))
                   {
                       global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Core.Erp.Recursos.Resource_Menu", typeof(Resource_Menu).Assembly);
                       resourceMan = temp;
                   }
                   return resourceMan;
               }
           }

           /// <summary>
           ///   Overrides the current thread's CurrentUICulture property for all
           ///   resource lookups using this strongly typed resource class.
           /// </summary>
           [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
           internal static global::System.Globalization.CultureInfo Culture
           {
               get
               {
                   return resourceCulture;
               }
               set
               {
                   resourceCulture = value;
               }
           }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdImage"></param>
        /// <returns></returns>
           public static System.Drawing.Bitmap GetImagen(string IdImage)
           {
               try
               {
                   object obj = ResourceManager.GetObject(IdImage, resourceCulture);
                   return ((System.Drawing.Bitmap)(obj));
               }
               catch (Exception ex)
               {
                   return new System.Drawing.Bitmap(5, 5);
                   
               }
              
                   
               
           }



       }


    
}
