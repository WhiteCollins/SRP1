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


/*
Código Original:
La clase Persona (o Person) tenía varios datos como nombre, edad, dirección y correo electrónico.
Además de almacenar datos, la clase Persona también hacía cosas como enviar correos electrónicos e imprimir datos.
Esta combinación de responsabilidades en una sola clase hace que el código sea más complicado de mantener y cambiar.

Código Refactorizado:
Separamos las responsabilidades en diferentes clases.
La clase Person ahora solo almacena y gestiona los datos de una persona (nombre, edad, dirección, correo electrónico).
Creamos una interfaz IEmail y una clase Email que se encarga exclusivamente de enviar correos electrónicos.
Creamos una interfaz IImprimirDatos y una clase ImprimirDatos que se encarga exclusivamente de imprimir los datos de una persona.
Ahora, si necesitamos cambiar la manera de enviar correos electrónicos o imprimir datos, solo necesitamos modificar las clases correspondientes (Email o ImprimirDatos), sin tocar la clase Person.
*/
