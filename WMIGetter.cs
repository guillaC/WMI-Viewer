using System;
using System.Collections.Generic;
using System.Management;

namespace WMI_view
{
    static class WMIGetter
    {
        public static Dictionary<String, Dictionary<String, String>> select(string request)
        {
            Dictionary<String, Dictionary<String, String>> result = new Dictionary<String, Dictionary<String, String>>();
            System.Management.ObjectQuery aObjectQuery = new System.Management.ObjectQuery(request);
            ManagementObjectSearcher aManagementObjectSearcher = new ManagementObjectSearcher(new ManagementScope(), aObjectQuery); 
            ManagementObjectCollection aManagementObjectCollection = aManagementObjectSearcher.Get();
            foreach (ManagementObject mo in aManagementObjectCollection)
            {
                Dictionary<String, String> pResult = new Dictionary<String, String>();
                foreach (PropertyData prop in mo.Properties)
                {
                    if (!pResult.ContainsKey(prop.Name))
                    {
                        if (prop.Value != null)
                        {
                            pResult.Add(prop.Name, prop.Value.ToString());
                        } else
                        {
                            pResult.Add(prop.Name, ""); 
                        }
                    }
                }
                if (!result.ContainsKey(mo.Path.ToString())) result.Add(mo.Path.ToString(), pResult);
            }
            return result;
        }
    }
}