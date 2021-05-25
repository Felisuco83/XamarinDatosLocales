using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace XamarinDatosLocales.Helpers
{
    public class HelperFiles
    {
        public string ReadFile(string resourceName)
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(HelperFiles)).Assembly;
            Stream stream = assembly.GetManifestResourceStream(resourceName);
            using (StreamReader reader = new StreamReader(stream))
            {
                string data = reader.ReadToEnd();
                return data;
            }
        }
    }
}
