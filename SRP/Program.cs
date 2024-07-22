using System;

namespace SRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //implemantacion de la clase persona
        }
    }

    public class Person
    {
        public string nombre;
        public int edad;
        public string direccion;
        public string correoEletronico;

        public Person(string nombre, int edad, string direccion, string correoEletronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoEletronico = correoEletronico;
        }

        public string Nombre{get { return nombre; }set { nombre = value; }}
        public int Edad{get { return edad; }set { edad = value; }}

        public string Direccion{get { return direccion; } set { direccion = value; } }
        public string CorreoEletronico{get { return correoEletronico; }set { correoEletronico = value; }}
    }

    public interface IEmail
    {
        void EnviarCorreo(string correo);
    }

    public class Email : IEmail
    {
        public void EnviarCorreo(string correo)
        {
            Console.WriteLine("Enviando correo a: " + correo);
        }
    }

    public interface IImprimirDatos
    {
        void ImprimirDatos(Person persona);
    }

    public class ImprimirDatos : IImprimirDatos
    {
        public void ImprimirDatos(Person persona)
        {
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Edad: " + persona.Edad);
            Console.WriteLine("Direccion: " + persona.Direccion);
            Console.WriteLine("Correo: " + persona.CorreoEletronico);
        }
    }
}
