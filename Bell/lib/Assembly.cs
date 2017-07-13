using System.Reflection;

namespace RcisSchoolBell.lib
{
   public class Assemblyinfo: Assembly
    {
        #region Assembly Attribute Accessors

         public static  string AssemblyTitle
        {
            get
            {
                var attributes = GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(GetExecutingAssembly().CodeBase);
            }
        }

         public static  string AssemblyVersion
        {
            get
            {
                return GetExecutingAssembly().GetName().Version.ToString();
            }
        }

         public static  string AssemblyDescription
        {
            get
            {
                var attributes = GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

         public static  string AssemblyProduct
        {
            get
            {
                var attributes = GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

         public static  string AssemblyCopyright
        {
            get
            {
                var attributes = GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

         public static  string AssemblyCompany
        {
            get
            {
                var attributes = GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
