using System;
using System.Collections.Generic;
using System.Linq;
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
                        }
                        else
                        {
                            pResult.Add(prop.Name, "");
                        }
                    }
                }
                if (!result.ContainsKey(mo.Path.ToString())) result.Add(mo.Path.ToString(), pResult);
            }
            return result;
        }

        public static List<List<String>> getProperties(string pClass)
        {
            List<List<String>> result = new List<List<String>>();
            ManagementClass processClass = new ManagementClass(pClass);
            processClass.Options.UseAmendedQualifiers = true;
            PropertyDataCollection properties = processClass.Properties;
            foreach (PropertyData prop in properties)
            {
                List<String> pResult = new List<String>();
                pResult.Add(prop.Name);
                pResult.Add(prop.Type.ToString());
                pResult.Add(prop.Origin);
                foreach (QualifierData q in prop.Qualifiers)
                {
                    if (q.Name.Equals("Description")) pResult.Add((String)processClass.GetPropertyQualifierValue(prop.Name, q.Name));
                }
                result.Add(pResult);
            }
            return result;
        }

        public static List<List<String>> getMethods(string pClass)
        {
            List<List<String>> result = new List<List<String>>();
            ManagementClass processClass = new ManagementClass(pClass);
            processClass.Options.UseAmendedQualifiers = true;
            MethodDataCollection methods = processClass.Methods;
            foreach (MethodData method in methods)
            {
                List<String> pResult = new List<string>();
                pResult.Add(method.Name);
                pResult.Add(method.Qualifiers["Description"].Value.ToString());
                String ineP = "";
                String outP = "";

                if (method.InParameters != null)
                {
                    foreach (PropertyData parameter in method.InParameters.Properties)
                    {
                        ineP += "[" + parameter.Type.ToString() + "] " + parameter.Name + "; ";
                    }
                }

                if (method.OutParameters != null)
                {
                    foreach (PropertyData parameter in method.OutParameters.Properties)
                    {
                        outP += "[" +parameter.Type.ToString() + "] " + parameter.Name + "; ";
                    }
                }

                pResult.Add(ineP);
                pResult.Add(outP);
                result.Add(pResult);
            }
            return result;
        }
    }
}