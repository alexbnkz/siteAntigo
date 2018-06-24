using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.alexbnkz.Base;
using WhatsAppApi;
using System.Security.Cryptography;
using System.Text;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class Default : System.Web.UI.Page
    {
        public SisTrufasDataAccess Base = new SisTrufasDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            //string pw = "Android9589";
            //WhatsAppApi.Register.WhatsRegisterV2.RequestCode("5521995891097", out pw, "sms", null);

            //pw = "Android9589";
            //WhatsAppApi.Register.WhatsRegisterV2.RequestCode("5521969476360", out pw, "sms", null);

            //pw = "Android9589";
            //WhatsAppApi.Register.WhatsRegisterV2.RequestCode("5521985333757", out pw, "sms", null);

            //pw = "Android9589";
            //WhatsAppApi.Register.WhatsRegisterV2.RequestCode("5521992000936", out pw, "sms", null);

            //SendWhats();
        }

        private string SendWhats()
        {            
            // Moto G dual chip
            // 353334061452427
            // 353334061452435

            string imei = "353334061452435"; //My IMEI 

            //string imei = "00c9caf9c2ca86b624d3defcf199d4f1"; //My IMEI 

            //WhatsApp me = new WhatsApp(sender, imei, nickname, true);

           

            WhatsApp me = null;
            using (MD5 md5Hash = MD5.Create())
            {
                String corrected = new string(imei.ToCharArray());

                string hash1 = GetMd5Hash(md5Hash, "353334061452427"); // IMEI SIM CLARO
                string hash2 = GetMd5Hash(md5Hash, "353334061452435"); // IMEI SIM TIM
                string hash3 = GetMd5Hash(md5Hash, "Android9589"); // Senha WART

                me = new WhatsApp("5521995891097", hash1, "API Test", true);
                me.Connect();
                me.Login();

                //Response.Write(me.Login(null) + " | ");

                //Response.Write(me.Login(md5Hash.ComputeHash(Encoding.Unicode.GetBytes(hash3))) + " | ");

                //    byte[] b = { 
                //                   getByte("00"), getByte("c9"), getByte("ca"), getByte("f9"), 
                //                   getByte("c2"), getByte("ca"), getByte("86"), getByte("b6"), 
                //                   getByte("24"), getByte("d3"), getByte("de"), getByte("fc"), 
                //                   getByte("f1"), getByte("99"), getByte("d4"), getByte("f1") };

                //    me.Login(b);
            }

            //using (MD5 md5Hash = MD5.Create())
            //{
            //    string hash1 = GetMd5Hash(md5Hash, "353334061452427");
            //    string hash2 = GetMd5Hash(md5Hash, "353334061452435");
            //    //string hashs = "00c9caf9c2ca86b624d3defcf199d4f1";

            //    //me.Login(md5Hash.ComputeHash(Encoding.UTF8.GetBytes(imei)));
            //}

            Response.Write(me.ConnectionStatus + " | ");// I get a Connection!

            Response.Write(me.SendMessage("5521969476360", "Amor! Retorna")); // Send Message

            //No Message received :(
           me.Disconnect();

            return "";
        }

        byte getByte(string s)
        {
            return Convert.ToByte(int.Parse(s, System.Globalization.NumberStyles.HexNumber));
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


        static byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (Aes algo = Aes.Create())
            {
                using (ICryptoTransform decryptor = algo.CreateDecryptor(key, iv))
                {
                    return Crypt(data, decryptor);
                }
            }
        }

        static byte[] Crypt(byte[] data, ICryptoTransform cryptor)
        {
            var ms = new System.IO.MemoryStream();
            using (System.IO.Stream cs = new CryptoStream(ms, cryptor, CryptoStreamMode.Write))
            {
                cs.Write(data, 0, data.Length);
            }
            return ms.ToArray();
        }
    }
}