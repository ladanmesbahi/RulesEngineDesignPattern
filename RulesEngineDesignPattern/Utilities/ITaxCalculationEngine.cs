using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Utilities
{
    public interface ITaxCalculationEngine
    {
        Task CalculateTaxPercentage(TaxPayer taxPayer);
    }
}
