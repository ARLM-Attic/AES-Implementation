using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace AESConsole
{
    class Program
    {
        static CryptoProject test;

        static void Main(string[] args)
        {

            byte[] plainText = new byte[] { 0x32, 0x43, 0xf6, 0xa8, 0x88, 0x5a, 0x30, 0x8d, 0x31, 0x31, 0x98, 0xa2, 0xe0, 0x37, 0x07, 0x34 };
            byte[] plainText2 = new byte[] { 0x6b, 0xc1, 0xbe, 0xe2, 0x2e, 0x40, 0x9f, 0x96, 0xe9, 0x3d, 0x7e, 0x11, 0x73, 0x93, 0x17, 0x2a };
            byte[] Key = new byte[] { 0x2b, 0x7e, 0x15, 0x16, 0x28, 0xae, 0xd2, 0xa6, 0xab, 0xf7, 0x15, 0x88, 0x09, 0xcf, 0x4f, 0x3c };

            //Console.WriteLine("Enter a test string");

            // 01 -- if lth mod k = k-1
            // 02 02-- if lth mod k = k - 2

            //s = Console.ReadLine();
            //Console.WriteLine(s.Length);
            //padLength = blockLength % s.Length;
            //Console.WriteLine(padLength);

            //Encoding.Default.GetBytes(s, 0, 15, str, 0);
            Console.WriteLine("Performing test...");
            //Console.WriteLine(str.Length);

            /*if (padLength != 0)
            {

            }

            foreach (byte value in str)
            {
                Console.WriteLine(Convert.ToString(value, 16));
            }*/

            test = new CryptoProject(Key);
            //test.intialAES();
            /*test.outputBytes();
            byte[] outArr = test.getOutput();
            string st = "0x";
            foreach (byte value in outArr)
            {
                st += Convert.ToString(value, 16);
            }
            Console.WriteLine(st);
            */
            Console.Write("Before Encryption: ");
            string st = "0x";
            foreach (byte value in plainText2)
            {
                st += Convert.ToString(value, 16);
            }
            Console.WriteLine(st);
            byte[] encrypted = new byte[16];
            byte[] decrypted = new byte[16];

            test.Encrypt(plainText2, encrypted);
            Console.Write("After Encryption: ");
            string outSt = "0x";

            foreach (byte value in encrypted)
            {
                outSt += Convert.ToString(value, 16);
            }
            Console.WriteLine(outSt);

            test.Decrypt(encrypted, decrypted);

            Console.Write("After Decryption: ");
            outSt = "0x";
            foreach (byte value in decrypted)
            {
                outSt += Convert.ToString(value, 16);
            }
            Console.WriteLine(outSt);

        }
    }
}