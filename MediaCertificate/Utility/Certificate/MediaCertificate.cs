using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MediaCertificateUtility.Utility.Certificate
{
    public class MediaCertificate
    {
        //Metadata
        public string Name;
        public string ID;
        public string Expiry;

        //Encryption Data
        private byte[] Key;
        private byte[] IV;

        public MediaCertificate(string name,string id,DateTime expiry)
        {
            Name = name;
            ID = id;
            Expiry = expiry.ToString("dd:MM:yyyy");
            Expiry += " 23:59:59";
        }
        public MediaCertificate(JObject JSON)
        {
            JToken Metadata = JSON.SelectToken("Metadata");
            JToken Secure = JSON.SelectToken("SecureDetails");
            Name = Metadata.Value<string>("Name");
            ID = Metadata.Value<string>("ID");
            Expiry = Metadata.Value<string>("Expiry");

            Key = Convert.FromBase64String(Secure.Value<string>("SecureKey"));
            IV = Convert.FromBase64String(Secure.Value<string>("SecureIV"));
        }

        public void GenerateSecureKeyAndIV(string Password)
        {
            //Create Your Own
        }

        //Usable Methods
        
        public ICryptoTransform GetEncryptor(string Password)
        {
            //Convert Expiry Into DateTime And Get Current DateTime
            CultureInfo Provider = CultureInfo.InvariantCulture;
            DateTime ExpiryDate = DateTime.ParseExact(Expiry,"dd:MM:yyyy HH:mm:ss",Provider);
            DateTime CurrentDate = DateTime.Now;
            //Check If Certificate Expired
            if(ExpiryDate < CurrentDate)
            {
                throw new Exception("Expired Certificate");
            }
            try
            {
                //Create Your Own
                return null;
            }
            catch(Exception ex)
            {
                //Error Has Occured
                throw ex;
            }
        }
        public ICryptoTransform GetDecryptor(string Password)
        {
            try
            {
                //Create Your Own
                retrun null;
            }
            catch (Exception ex)
            {
                //Error Has Occured
                throw ex;
            }
        }

        public byte[] GetKey(string AccessKey)
        {
            //Create Your Own
            return null;
        }
        public byte[] GetIV(string AccessKey)
        {
            //Create Your Own
            return null;
        }
    }
}
