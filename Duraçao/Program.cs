using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duraçao {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int resto, segundos, minutos, horas, tempo;

            Console.Write("Digite a duraçao em segundos: ");
            tempo = int.Parse(Console.ReadLine());

            horas = tempo / 3600;
            resto = tempo % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
