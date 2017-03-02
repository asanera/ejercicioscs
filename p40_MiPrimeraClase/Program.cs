using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p40_MiPrimeraClase
{
    public class Persona
    {
        //Campos de la clase Alumnos
        string nombre;
        string apellidos;
        public int numDNI;
        char letraDNI;
        byte anyo;
        byte mes;
        byte dia;

        //Constructor tipico: actualiza los campos
        public Persona(string nombre, string apellidos, int numDNI, char letraDNI, byte anyo, byte mes, byte dia)
         
        {  
              //el nombre de esta(this) clase
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.numDNI = numDNI; 
            this.letraDNI = letraDNI;
            this.anyo = anyo;
            this.mes = mes;
            this.dia = dia;

        }
        public void Cumpleanyo()
        {
            anyo++;
        }
        public void PresentaPersona()
        {
            int año;
            if (anyo < 15) 
                año =2000 +15;
            else
                año =1900 + anyo;
            Console.Write("{0}\t {1}\t {2}\t {3} ",nombre, apellidos, numDNI, año);
        }
    }
    class Program
    {
        static void Main(string[] args)//-->Punto de entrada
        {
            //Declarando e inicializando un objeto 
            Persona luis, p1 ,alvaroSanchez = new Persona("Alvaro","Sanchez Cabrera",12345678,'G',98,3,13);
            p1=new Persona("lolo","Guti",4343242,'M',00,1,23);
            luis = p1;
            p1.PresentaPersona();
            
            Console.ReadLine();

        }
    }
}
