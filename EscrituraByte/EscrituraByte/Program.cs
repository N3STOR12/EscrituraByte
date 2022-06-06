﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EscrituraByte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nbytes = 0, car;
            try
            {
                fs = new FileStream("text.txt",FileMode.Create,FileAccess.Write);
                Console.Write("Escriba el texto quer desea almacenar en el archivo: ");
                while ((car = Console.Read()) != '\r' && (nbytes <buffer.Length))
                {
                    buffer[nbytes] = (byte)car;
                    nbytes++;   
                }
                fs.Write(buffer, 0, nbytes);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
