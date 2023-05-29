using System;
using Xunit;

namespace SistemaVendas.TestesUnitarios
{
    public class FreteNegocioTest
    {
        [Fact]
        public void Test1()
        {
            var valor = new FreteNegocio().CalcularFrete(3);
        }
    }
}
