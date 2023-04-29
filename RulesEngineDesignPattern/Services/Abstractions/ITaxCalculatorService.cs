using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Services.Abstractions
{
    public interface ITaxCalculatorService
    {
        Task CalculateTax(TaxPayer taxPayer);
    }
}
