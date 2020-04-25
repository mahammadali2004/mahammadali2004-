using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public static class Extentions
    {
        public static bool IsEmail(this string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }

            catch (Exception) {
                return false;
                    }

        
        }

        public static string HashPassword(this string password) {
            byte[] bytePassword = Encoding.ASCII.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashBytePassword = md5.ComputeHash(bytePassword);
            return Encoding.ASCII.GetString(hashBytePassword);
        }

    }


}

