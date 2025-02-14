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
            int _opcion = 0;
            int _menu = 0;
            #endregion
            while (_menu == 0)
            {
                Console.WriteLine("1.- Cifrar Texto");
                Console.WriteLine("2.- Cifrar User y Password");
                Console.WriteLine("3.- Descifrar texto");
                Console.WriteLine("Opcion: ");
                Int32.TryParse(Console.ReadLine(), out _opcion);
                
                if (_opcion == 2)
                {
                    Console.WriteLine("User: ");
                    _user = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    _pass = Console.ReadLine();
                    Console.ReadKey();
                  
                    Console.WriteLine("=========================");
                    Console.WriteLine("User Encrypt: " + EncryptStr(_user));
                    Console.WriteLine("Password Encrypt: " + EncryptStr(_pass));
                    Console.WriteLine("=========================");
                    Console.WriteLine("User decrypt: " + DecryptStr(EncryptStr(_user)));
                    Console.WriteLine("Password decrypt: " + DecryptStr(EncryptStr(_pass)));
                    Console.WriteLine("Salir 1: ");
                    _menu =  Convert.ToInt32(Console.ReadLine());
                   
                }
                else if (_opcion == 1)
                {
                    Console.WriteLine("Texto a Convertir: ");
                    _user = Console.ReadLine();

                    Console.ReadKey();
                    Console.WriteLine("=========================");
                    Console.WriteLine("Texto Encriptado: " + EncryptStr(_user));
                    Console.WriteLine("=========================");
                    Console.WriteLine("Texto desencriptado: " + DecryptStr(EncryptStr(_user)));
                    Console.ReadKey();
                    Console.WriteLine("Salir 1: ");
                    _menu = Convert.ToInt32(Console.ReadLine());
                }
                else if(_opcion == 3)
                {
                    Console.WriteLine("Texto Encriptado: ");
                    _user = Console.ReadLine();

                    Console.ReadKey();
                    Console.WriteLine("=========================");
                    Console.WriteLine("Texto desencriptado: " + DecryptStr(_user));
                    Console.ReadKey();
                    Console.WriteLine("Salir 1: ");
                    _menu = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
            }

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
