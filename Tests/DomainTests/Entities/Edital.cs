using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ValueObjects;
using Xunit.Abstractions;

namespace Tests.DomainTests.Entities
{
    public class EditalTest
    {
        private static Edital CreateEditalEntity()
        {
            return new Edital(
                titulo: "",
                descricao: "",
                requisitos: [],
                dataAbertura: DateTime.Now,
                dataFechamento: DateTime.Now
            );
        }

        [Fact]
        public void ShouldCreateEdital()
        {
            var edital = CreateEditalEntity();

            Assert.NotNull(edital);
            Assert.IsType<Edital>(edital);
        }

        [Fact]
        public void ShouldCloseEditalAndReturnFechado()
        {
            //Arrange
            var edital = CreateEditalEntity();
            var expected = StatusEdital.Fechado;

            //Act
            edital.Fechar();

            //Assert
            Assert.Equal(expected, edital.Status);
        }

        [Fact]
        public void ShouldReturnInvalidOperationException()
        {
            //Arrange
            var edital = CreateEditalEntity();

            //Act
            edital.Status = StatusEdital.Fechado;

            //Assert
            Assert.Throws<InvalidOperationException>(() => edital.Fechar());
        }
    }
}
