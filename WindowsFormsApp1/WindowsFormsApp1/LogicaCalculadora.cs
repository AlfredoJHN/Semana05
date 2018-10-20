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
        /// Esta función es la cara de la interfaz para hacer el cálculo de las operaciones.
        /// </summary>
        /// <param name="operandoA">Hilera de caracteres que representa el primer operando.</param>
        /// <param name="operandoB">Hilera de caracteres que representa el segundo operando.</param>
        /// <param name="Operador">Hilera de caracteres que representa el operador.</param>
        /// <returns>Hilera de caracteres que representa el resultado de la operación.</returns>
        public string Operar(string operandoA, string operandoB, string Operador)
        {
            string ResultadoConvertido;
            double operando1 = Convert.ToDouble(operandoA);
            double operando2 = Convert.ToDouble(operandoB);
            EnumeradoOperadores OperadorEnumerado;
            double? Resultado = Operar(operando1, operando2, OperadorEnumerado);
            if (Resultado != null)
            {
                ResultadoConvertido = Resultado.ToString();
            }
            else
            {
                ResultadoConvertido = "Error";
            }
            return ResultadoConvertido;
        }

        private EnumeradoOperadores ConvertirStringEnumeradoOperadores(string Operador)
        {
            EnumeradoOperadores Resultado;
            switch (Operador)
            {
                case "Suma":
                case "Plus":
                    Resultado = EnumeradoOperadores.Suma;
                    break;
                case "Resta":
                case "Minus":
                    Resultado = EnumeradoOperadores.Resta;
                    break;
                case "División":
                case "Divide":
                    Resultado = EnumeradoOperadores.División;
                    break;
                case "Multiplicación":
                case "Multiply":
                    Resultado = EnumeradoOperadores.Multiplicación;
                    break;
                default:
                    Resultado = EnumeradoOperadores.Desconocido;
                    break;
            }
            return Resultado;
        }
        private double? Operar(double operandoA, double operandoB,
                              EnumeradoOperadores Operador)
        {
            double? Resultado = 0.0; //double? -> puede asignar valores null
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
                    if (operandoA != 0)
                    {
                        Resultado = operandoA / operandoB;
                    }
                    else
                        Resultado = null;
                    break;
                case EnumeradoOperadores.Desconocido:
                    Resultado = null;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "No se ha seleccionado ningún operador");
                    break;
            }
            return Resultado;
        }
    }
}
