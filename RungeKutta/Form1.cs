﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RungeKutta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class FilaRunge
        {
            public double xi;
            public double yi;
            public double k1;
            public double k2;
            public double k3;
            public double k4;
            public double nextXi;
            public double nextYi;

        }

        private void btnGenerateRunge_Click(object sender, EventArgs e)
        {
            GenerateRungeResolution();
        }

        /// GenerateRungeResolution es el metodo que realiza la ejecucion central de la resolucion
        private void GenerateRungeResolution() {

            // Declaro las variables h y la condicion de corte que en el programa del aeropuerto van a estar hardcodeados o seran resultado de algun calculo previo
            double h = double.Parse(txtH.Text);
            double yFinal = double.Parse(txtFinalY.Text);

            // Declaro la fila que almacenara los valores que luego iran al dgv
            FilaRunge filaActual = new FilaRunge();
          
            // como no uso un ciclo for para detectar la primera iteracion declaro un counter en valor 0
            int counter = 0;

            do {
                // Si el counter es cero el x e y seran iguales a los iniciales
                if (counter == 0)
                {
                    filaActual.xi = Convert.ToDouble(txtXinicial.Text);
                    filaActual.yi = Convert.ToDouble(txtYinicial.Text);

                    // sumo al counter, esto se hara una sola vez porque una sola vez valdra cero para que entre en este if y no gasto recursos sumandole siempre
                    counter++;
                }
                else
                {   
                    // Si no es la primera vuelta entonces el valor xi e yi sera igual a los que corresponden a Xsiguiente e Ysiguiente en la fila anterior
                    filaActual.xi = filaActual.nextXi;
                    filaActual.yi = filaActual.nextYi;
                }

                // Obtengo todos los K
                filaActual.k1 = ObtainK1(filaActual.xi,filaActual.yi);
                filaActual.k2 = ObtainK23(filaActual.xi, filaActual.yi, h, filaActual.k1);
                filaActual.k3 = ObtainK23(filaActual.xi, filaActual.yi, h, filaActual.k2);
                filaActual.k4 = ObtainK4(filaActual.xi,filaActual.yi,h,filaActual.k3);

                // Obtengo los valores siguientes de X e Y
                filaActual.nextXi = ObtainNextX(filaActual.xi, h);
                filaActual.nextYi = ObtainNextY(filaActual.yi,h,filaActual.k1,filaActual.k2,filaActual.k3,filaActual.k4);

                // Lo agrego al DGV
                addToDGV(filaActual);

              // Este while chequea que se haya alcanzado la condicion del ejercicio sino seguimos aplicando metodo runge kutta
            } while (filaActual.yi < int.Parse(txtFinalY.Text));

            // obtengo la solucion que podria ser tiempo por ejemplo en nuestra simulacion
            double solution = filaActual.yi;

        }

        private void addToDGV(FilaRunge fila)
        {
            // Pasamos a string los valores de la fila para agregarlo al DGV
            string[] row = {
                    fila.xi.ToString(),
                    fila.yi.ToString(),
                    fila.k1.ToString(),
                    fila.k2.ToString(),
                    fila.k3.ToString(),
                    fila.k4.ToString(),
                    fila.nextXi.ToString(),
                    fila.nextYi.ToString()
                            };

    
            dgvRunge.Rows.Add(row);
        }

        private double calculateK( double x,double y) {

            // Reemplazar en el k por la formula de beto, aca uso una de superior para que funcione el metodo nomas
            // Lo abstrai en un metodo asi podemos variar el calculo del K sin romper los demas metodos
            double k = 2 * x * y + 6;

            return k;
        }

        private Tuple<double, double> calculateMidPoint(double x, double y,double h, double k)
        {
            // Con esto calculo los puntos medios para obtener posteriormente k2 y k3
            double xMidPoint = x + (h / 2);
            double yMidPoint = y + (h / 2 * k);

            Tuple<double, double> midPoints = new Tuple<double, double>(xMidPoint, yMidPoint);

            return midPoints;
        }

        private double ObtainNextX(double x, double h)
        {
            // Siguiente valor de X
            double x1plus1 = x + h;
            return x1plus1;
        }

        private double ObtainNextY(double y, double h, double k1, double k2, double k3, double k4)
        {
            // Siguiente valor de Y
            double y1plus1 = y + ((h / 6) * (k1 + 2*k2 + 2*k3 +k4));
            return y1plus1;
        }



        private double ObtainK1(double x, double y) {

            // K1 directamente aplica formula 
            double k1 = calculateK(x, y);

            return k1;
        }

        private double ObtainK23(double x, double y, double h, double k)
        {
            //K2 y K3 se calculan de la misma forma nomas que varia el k que le estas mandando por eso lo unifique en un solo metodo ObtainK23

            // Calculo el punto medio
            Tuple<double, double> midPoints = calculateMidPoint(x, y, h, k);

            double kx = calculateK(midPoints.Item1, midPoints.Item2);

            return kx;
        }

       


        private double ObtainK4(double x, double y, double h, double k3)
        {

            //Obtengo los valores siguientes y los uso para calcular el k4

            double x1plus1 = ObtainNextX(x,h);
            double yplushk3 = y + (h*k3);

            double k4 = calculateK(x1plus1,yplushk3);

            return k4;
        }
    }
}
