using System;
using System.Collections.Generic;
using System.Text;

    static public class Helper
    {
        public static DateTime FechaAleatoria(int anios)
        {
            Random gen = new Random();
            DateTime start = DateTime.Today.AddDays(-anios);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }

