using MediaCertificateUtility.Utility.Certificate;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MediaCertificateUtility.Utility
{
    internal class FileUtility
    {
        public static bool CanWrite(string fileName)
        {
            bool canCreate = false;
            try
            {
                using (File.Create(fileName)) { }
                File.Delete(fileName);
                canCreate = true;
            }
            catch
            {
                canCreate = false;
            }
            return canCreate;
        }


        public static void WriteMCF(MediaCertificate Certificate,string Location)
        {
            //Create Your Own
            
        }

        public static MediaCertificate ReadCertificate(string Location)
        {
            //Create Your Own
        }
    }
}
