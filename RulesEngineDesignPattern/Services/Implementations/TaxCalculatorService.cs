using RulesEngineDesignPattern.Entities;
using RulesEngineDesignPattern.Services.Abstractions;
using RulesEngineDesignPattern.Utilities;

namespace RulesEngineDesignPattern.Services.Implementations
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        public async Task CalculateTax(TaxPayer taxPayer)
        {
            var ruleType = typeof(ITaxCalculationRule);
            var rules = this.GetType().Assembly.GetTypes()
                .Where(r => r.IsAssignableFrom(ruleType) && !r.IsInterface)
                .Select(r => Activator.CreateInstance(r) as ITaxCalculationRule);

            var engine = new TaxCalculationEngine(rules);
            engine.CalculateTax(taxPayer);
        }
    }
}
