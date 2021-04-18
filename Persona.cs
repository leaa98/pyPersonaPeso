using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyPersonaPeso
{
    class Persona
    {
        private String nombre;
        private int edad;
        private char sexo;
        private double peso, altura;

        public Persona(string nombre, int edad, double altura, char sexo, double peso) {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.sexo = sexo;
            this.peso = peso;
        }
         
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int pEdad
        {
            set { edad = value; }
            get { return edad; }
        }

        public char pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public double pPeso
        {
            set { peso = value; }
            get { return peso; }
        }
        public double pAltura
        {
            set { altura = value; }
            get { return altura; }
        }



        public int calcularIMC() {
            double calc = peso / (altura * altura);
            if (calc < 20){
                return -1;
            }else if (calc >= 20 & (calc) <= 25){
                return 0;
            }else {
                return 1;
            }
        }

        public bool esMayorDeEdad() {
            if (edad >= 21)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
