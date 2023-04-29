using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Utilities.Rules
{
    public class SingleRule : ITaxCalculationRule
    {
        public async Task CalculateTax(TaxPayer taxPayer)
        {
            if (taxPayer.IsSingle)
                taxPayer.TaxPercentage += 10;
        }
    }
}
