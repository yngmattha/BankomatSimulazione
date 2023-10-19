using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimulazione.Repository
{
    public class Scelta
    {
        public int Menu()
        {
            Console.WriteLine("Seleziona la banca a cui accedere:");
            var s = Console.ReadLine();
            int r = int.Parse(s);
            return r;
        }
    }
}
