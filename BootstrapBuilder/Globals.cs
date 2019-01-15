using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapBuilder
{
    public static class Globals
    {      
        private static readonly Dictionary<string, object> globals = new Dictionary<string, object>();

        public static void addGlobalVar(string key, object val)
        {
            if (!(globals.ContainsKey(key)))
            {
                globals.Add(key, val);
            }
            else
            {
                globals[key] = val;
            }

        }
        public static object GetValue(string key)
        {
            try
            {
                return globals[key];
            }
            catch (Exception e)
            {
                return string.Format("Object not exist");
            }
        }
    }
}
