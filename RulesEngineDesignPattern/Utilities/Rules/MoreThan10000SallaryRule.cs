using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Utilities.Rules
{
    public class MoreThan10000SallaryRule : ITaxCalculationRule
    {
        public async Task CalculateTax(TaxPayer taxPayer)
        {
            if (taxPayer.Sallary > 10000)
                taxPayer.TaxPercentage += 20;
        }
    }
}
