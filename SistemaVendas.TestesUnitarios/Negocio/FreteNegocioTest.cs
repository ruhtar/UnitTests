using Xunit;

namespace SistemaVendas.TestesUnitarios.Negocio
{
    public class FreteNegocioTest
    {
        [Theory(DisplayName = "Deve calcular o frete até 5 Km com sucesso")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void CalculaFreteAte5Km(int distanciaKm)
        {
            var valor = new FreteNegocio().CalcularFrete(distanciaKm);
            
            Assert.Equal(0.00m, valor);
        }
        [Theory(DisplayName = "Deve calcular o frete até 15 Km com sucesso")]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        public void CalculaFreteAte15Km(int distanciaKm)
        {
            var valor = new FreteNegocio().CalcularFrete(distanciaKm);
            
            Assert.Equal(10.00m, valor);
        }
        
        [Theory(DisplayName = "Deve calcular o frete até 15 Km com sucesso")]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(19)]
        [InlineData(20)]
        public void CalculaFreteComMaisDe15Km(int distanciaKm)
        {
            var valor = new FreteNegocio().CalcularFrete(distanciaKm);
            
            Assert.Equal(30.00m, valor);
        }
    }
}
