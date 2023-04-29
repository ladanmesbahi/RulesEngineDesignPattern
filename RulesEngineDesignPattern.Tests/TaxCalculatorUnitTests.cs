using RulesEngineDesignPattern.Entities;
using RulesEngineDesignPattern.Services.Abstractions;
using RulesEngineDesignPattern.Services.Implementations;

namespace RulesEngineDesignPattern.Tests
{
    public class TaxCalculatorUnitTests
    {
        private readonly ITaxCalculatorService _service = new TaxCalculatorService();

        [Fact]
        public async Task PayerIsRetired_NoTaxShouldBePayed()
        {
            var taxPayer = new TaxPayer
            {
                IsRetired = true,
            };
            await _service.CalculateTax(taxPayer);

            Assert.Equal(taxPayer.TaxAmount, 0);
        }

        [Fact]
        public async Task PayerIsSingle_TaxShouldBe10PercentOfSallary()
        {
            var taxPayer = new TaxPayer
            {
                IsSingle = true,
                Sallary = 4500
            };

            await _service.CalculateTax(taxPayer);

            Assert.Equal(taxPayer.TaxAmount, 450);
        }

        [Fact]
        public async Task SallaryIsHigherThan10000_TaxShouldBe20PercentOfSallary()
        {
            var taxPayer = new TaxPayer
            {
                Sallary = 15000
            };

            await _service.CalculateTax(taxPayer);

            Assert.Equal(taxPayer.TaxAmount, 3000);
        }
    }
}
