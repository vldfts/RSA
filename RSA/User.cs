using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace RSA
{
    class User : Realization
    {
        private BigInteger p { get; set; }
        private BigInteger q { get; set; }
        public BigInteger d { get; set; }
        public BigInteger n { get; private set; }
        public BigInteger n1 { get; set; }
        public BigInteger e { get; private set; }
        public BigInteger e1 { get; private set; }
        public BigInteger k { get; private set; }
        public BigInteger s { get; private set; }
        public void GenerateKeyPair()
        {

            p = GetSimple(32, 4);
            q = GetSimple(32, 4);
            n = p * q;
            e = 65537;
            d = ModInverse(e, (p - 1) * (q - 1));
        }
        public BigInteger Encrypt(BigInteger message)
        {
            return BigInteger.ModPow(message, e1, n1);
        }
        public BigInteger Decrypt(BigInteger cipher)
        {
            return BigInteger.ModPow(cipher, d, n);
        }
        public BigInteger Sign(BigInteger message)
        {
            s= BigInteger.ModPow(message, d, n);
            Console.WriteLine((s-n));
            return BigInteger.ModPow(s, e1, n1);
        }
        public bool Verify(BigInteger signedMessage, BigInteger cryptMess)
        {
            if (Decrypt(cryptMess) == Encrypt(Decrypt(signedMessage))) 
                return true;
            return false;
        }
        public void SendKey()
        {
            Console.WriteLine("Send key:");
            Console.WriteLine("N= " + n.ToString("X"));
            Console.WriteLine("E= " + e.ToString("X"));
        }
        public void ReceiveKey()
        {
            Console.WriteLine("Receive key:");
            Console.Write("N= ");
            //n1 = BigInteger.Parse(Console.ReadLine());
            n1 = BigInteger.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber);
            Console.Write("E= ");
            //e1= BigInteger.Parse(Console.ReadLine());
            e1 = BigInteger.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber);
        }

    }
}