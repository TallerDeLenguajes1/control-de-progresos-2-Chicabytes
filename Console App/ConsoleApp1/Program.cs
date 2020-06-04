using System;
using System.Collections.Generic;
using ClasePj;
using static Helper;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantPj = new Random().Next(100);
            List<Personaje> ListaPJ = new List<Personaje>;
            string[] nombres = {"Choco Mayor", "Choco Medio", "Choco Menor"};
            string[] apodos = { "Chicabytes", "MatiHer", "tntFran" };
            Personaje PJnuevo;
            for(int i=0; i<cantPj;i++)
            {
                DateTime fechaAleatoria = Helper.FechaAleatoria(300);
                string nombre = nombres[new Random().Next(3)];
                string apodo = apodos[new Random().Next(3)];
                PJnuevo = new Personaje();
                PJnuevo.CargarDatos(nombre, apodo, fechaAleatoria);
                ListaPJ.Add(PJnuevo);
            }
            
        }
    }
}
