using System;
namespace MiPrimerApp
{
    public class Alumno
    {
        private string name;
        private string lastName;
        private int edad;
        private string school;
        private string semestre;

        public Alumno(string name, string lastName, int edad, string school, string semestre)
        {
            this.name = name;
            this.lastName = lastName;
            this.edad = edad;
            this.school = school;
            this.semestre = semestre;
        }

        public override string ToString()
        {
            return "Nombre: "+name+" "+lastName+ "\nEdad: "+edad+ "\nEscuela: "+school+"\nSemestre: "+semestre; 
        }
    }
}
