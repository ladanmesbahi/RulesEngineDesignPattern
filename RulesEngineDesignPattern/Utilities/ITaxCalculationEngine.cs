using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Utilities
{
    public interface ITaxCalculationEngine
    {
        Task CalculateTax(TaxPayer taxPayer);
    }
}
