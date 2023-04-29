using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Utilities
{
    public interface ITaxCalculationRule
    {
        Task CalculateTax(TaxPayer taxPayer);
    }
}
