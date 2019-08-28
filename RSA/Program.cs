using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a message: hex ");
            //Console.Write("--> ");
            //BigInteger mess = BigInteger.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber);
            User A = new User();
            #region На сайті
            //A.ReceiveKey();
            //Console.WriteLine("Mesage: " + mess.ToString("X"));
            //Console.WriteLine(A.Encrypt(mess).ToString("X"));
            #endregion
            #region на компі
            A.GenerateKeyPair();
            A.ReceiveKey();
            A.SendKey();
            A.Sign(BigInteger.Parse("13A3E39A2EEDB2F9", System.Globalization.NumberStyles.HexNumber));
            //Console.WriteLine(A.Sign(1111).ToString("X"));
            //Console.Write("Ciphertext: ");
            Console.WriteLine(BigInteger.Parse("1CC89014A058A196BF967F36F35EECBE", System.Globalization.NumberStyles.HexNumber));
            Console.WriteLine(BigInteger.Parse("9497E6740842438F04D830E3E14E714F", System.Globalization.NumberStyles.HexNumber));
            //BigInteger mes = BigInteger.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine(A.Decrypt(mes).ToString("X"));
            #endregion
            #region протокол
            //User B = new User();
            //B.GenerateKeyPair();//отримувач
            //do
            //{
            //    A.GenerateKeyPair();
            //} while (A.n > B.n);
            //Console.WriteLine("B");
            //B.SendKey();
            //Console.WriteLine(new string('_',50));
            //Console.WriteLine("A");
            //A.ReceiveKey();
            //Console.WriteLine(new string('_', 50));
            //Console.WriteLine("A");
            //A.SendKey();
            //Console.WriteLine(new string('_', 50));
            //Console.WriteLine("B");
            //B.ReceiveKey();
            //Console.WriteLine(new string('_', 50));
            //Console.WriteLine("Message: "+B.Decrypt(A.Encrypt(mess)).ToString("X"));
            //Console.WriteLine("Verification: "+B.Verify(A.Sign(mess), A.Encrypt(mess)));
            #endregion

            Console.ReadKey();
        }

    }
}
