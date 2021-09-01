//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            int n = 100;
            for (int i=1; i <= n; i++)
            {
                string stringTemp = i.ToString();
                var train = new Train(stringTemp);
            }
            
            var t1 = new Train("Last Train to London");
            var t2 = new Train("Last Train to London");
            var t3 = new Train("Runaway train");
            Console.WriteLine($"La cantidad de entidades de tren creadas fue {Train.Count}");
            Console.WriteLine($"t1==t2 = {t1 == t2} y t2==t3 = {t2 == t3}");
        }
    }
}