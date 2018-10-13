using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class LogicaCalculadora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operandoA"></param>
        /// <param name="operandoBm"></param>
        /// <param name="Operador"></param>
        /// <returns></returns>
        public string Operar(string operandoA, string operandoB, string Operador)
        {
            double operando1 = Convert.ToDouble(operandoA);
            double operando2 = Convert.ToDouble(operandoB);
            double Resultado = Operar(operando1, operando2, Operador);
            string ResultadoConvertido = Resultado.ToString();
            return ResultadoConvertido;
        }
        private double Operar(double operandoA, double operandoB,
                              EnumeradoOperadores Operador)
        {
            double Resultado = 0.0;
            switch (Operador)
            {
                case EnumeradoOperadores.Suma:
                    Resultado = operandoA + operandoB;
                    break;
                case EnumeradoOperadores.Resta:
                    Resultado = operandoA - operandoB;
                    break;
                case EnumeradoOperadores.Multiplicación:
                    Resultado = operandoA * operandoB;
                    break;
                case EnumeradoOperadores.División:
                    Resultado = operandoA / operandoB;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "No se ha seleccionado un operador");
                    break;
            }
            return Resultado;
        }
    }
}
