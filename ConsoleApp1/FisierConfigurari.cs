using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public static class FisierConfigurari
    {
        private static string Title = ConfigurationManager.AppSettings.Get("App Title");
        private static string FileNameConf = ConfigurationManager.AppSettings.Get("File Name");

        public  static  string GetTitle() {
            return Title;
        }
        public  static string GetFileNameConf() {
            return FileNameConf;
        }
       
        
        
      
    }
}
