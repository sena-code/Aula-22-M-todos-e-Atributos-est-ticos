namespace Aula22
{
    public static class Conversor
    {
        public static float Dolar = 5.30f;
        public static float Euro = 5.92f;
        public static float DolarforReal(float valor)
        {
            return valor * Dolar;
        }
        public static float EuroforReal(float valor)
        {
            return valor * Euro;
        }
        public static float RealforDolar(float valor)
        {
            return valor / Dolar;
        }
        public static float RealforEuro(float valor)
        {
            return valor / Euro;
        }


    }
}