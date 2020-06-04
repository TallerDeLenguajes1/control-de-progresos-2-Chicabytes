using System;
using System.Collections.Generic;

namespace ClasePj
{
    enum CaracteristicasMax
    {
        SaludMax = 100,
        VelocidadMax = 10,
        DestrezaMax = 5,
        FuerzaMax = 10,
        NivelMax = 10,
        ArmaduraMax = 10,
    }

    public class Personaje
    {
        private string tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;
        private int salud;
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }

        public void CargarDatos(string nombre, string apodo, DateTime fecha)
        {
            string[] tipos = { "Espadachin", "Mago", "Hechicero", "Bestia", "Caballero" };
            Random rand = new Random();

            Tipo = tipos[rand.Next(tipos.Length)];
            Nombre = nombre;
            Apodo = apodo;
            FechaNacimiento = fecha;
            Edad = DateTime.Now.Year - fecha.Year;
            Salud = Convert.ToInt32(CaracteristicasMax.SaludMax);
            Velocidad = rand.Next(Convert.ToInt32(CaracteristicasMax.DestrezaMax));
            Destreza = rand.Next(Convert.ToInt32(CaracteristicasMax.DestrezaMax));
            Fuerza = rand.Next(Convert.ToInt32(CaracteristicasMax.FuerzaMax));
            Nivel = rand.Next(Convert.ToInt32(CaracteristicasMax.NivelMax));
            Armadura = rand.Next(Convert.ToInt32(CaracteristicasMax.ArmaduraMax));
        }
    }

}