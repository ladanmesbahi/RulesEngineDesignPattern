using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Utilities.Rules
{
    public class RetiredRule : ITaxCalculationRule
    {
        public async Task CalculateTax(TaxPayer taxPayer)
        {
            if (taxPayer.IsRetired)
                taxPayer.TaxAmount = 0;
        }
    }
}
