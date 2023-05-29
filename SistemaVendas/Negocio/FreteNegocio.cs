namespace SistemaVendas
{
    public class FreteNegocio
    {
        public decimal CalcularFrete(int distanciaKm)
        {
            if (distanciaKm <= 5)
            {
                return 0.00m;
            }
            if(distanciaKm < 15)
            {
                return 10.00m;
            }
            return 30.00m;
        }
    }
}