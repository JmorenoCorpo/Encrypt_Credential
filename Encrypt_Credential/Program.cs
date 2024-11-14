using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corponet;

namespace Encrypt_Credential
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string _user = string.Empty;
            string _pass = string.Empty;
            #endregion


            Console.WriteLine("User: ");
            _user = Console.ReadLine();
            Console.WriteLine("Password: ");
            _pass = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("=========================");
            Console.WriteLine("User Encrypt: " + EncryptStr(_user));
            Console.WriteLine("Password Encrypt: " + EncryptStr(_pass));
            Console.ReadKey();
            Console.WriteLine("=========================");
            Console.WriteLine("User decrypt: " + DecryptStr(EncryptStr(_user)));
            Console.WriteLine("Password decrypt: " + DecryptStr(EncryptStr(_pass)));
            Console.ReadKey();

        }

        private static string EncryptStr(string _txt)
        {
            string _resul = string.Empty;
            _resul = Corponet.Tools.Utils.EncryptAES(_txt);
            return _resul;
        }

        private static string DecryptStr(string _txt)
        {
            string _resul = string.Empty;
            _resul = Corponet.Tools.Utils.DecryptAES(_txt);
            return _resul;
        }
    }
}
