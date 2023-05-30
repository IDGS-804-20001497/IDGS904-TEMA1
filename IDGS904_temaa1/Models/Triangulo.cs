using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Models
{
    public class Triangulo
    {

        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }

        public bool Valido{ get; set; }

        public string Tipo { get; set; }

        public double Area { get; set; }

        public string Error { get; set; }


        
        private double CalcularLado(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private bool EsValido(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado3 + lado1 > lado2;
        }

        private string GetTipo(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        public string CalcularT()
        {
            string result;
            bool tria;
            string tipo="";

            double lado1 = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1), 2));
            double lado2 = Math.Sqrt(Math.Pow((x3 - x2), 2)+Math.Pow((y3 - y2), 2));
            double lado3 = Math.Sqrt(Math.Pow((x3 - x1), 2)+Math.Pow((y3 - y1), 2));

            if (lado1+lado2>lado3 || lado1+lado2>lado3 || lado3+lado2>lado1) {
                result = "Es un triángulo";
                tria=true;
                ;
            }
            else {
                result = "No es un triángulo";
                tria=false;
            }


            if (tria) {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    tipo= "Equilátero";
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                {
                    tipo= "Isósceles";
                }
                else
                {
                    tipo= "Escaleno";
                }
            }

            double area = Math.Sqrt(0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));



            return result + " Su tipo es:  "+tipo + "Y su área es: " +area;
        }



    }
}