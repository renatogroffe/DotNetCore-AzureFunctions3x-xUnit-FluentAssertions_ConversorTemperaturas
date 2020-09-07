using System;

namespace ServerlessTemperatura
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(double temperatura)
        {
            return (temperatura - 32) / 1.8; // Simulação proposital de falha
            //return Math.Round((temperatura - 32) / 1.8, 2);
        }
    }
}