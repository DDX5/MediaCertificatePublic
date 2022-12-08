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
            JObject Document = JObject.FromObject(new{Metadata = new{Name = Certificate.Name,ID = Certificate.ID,Expiry = Certificate.Expiry},SecureDetails = new{SecureKey = Convert.ToBase64String(Certificate.GetKey("Media.Certificate.Utility.Access")),SecureIV = Convert.ToBase64String(Certificate.GetIV("Media.Certificate.Utility.Access"))}});
            File.WriteAllText(Location, Document.ToString());
        }

        public static MediaCertificate ReadCertificate(string Location)
        {
            JObject JSON = JObject.Parse(File.ReadAllText(Location));
            return new MediaCertificate(JSON);
        }
    }
}
