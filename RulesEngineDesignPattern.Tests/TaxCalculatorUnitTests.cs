﻿using RulesEngineDesignPattern.Entities;
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
    }
}