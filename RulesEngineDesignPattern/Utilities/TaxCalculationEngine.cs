using RulesEngineDesignPattern.Entities;

namespace RulesEngineDesignPattern.Utilities
{
    public class TaxCalculationEngine : ITaxCalculationEngine
    {
        private readonly List<ITaxCalculationRule> _rules = new List<ITaxCalculationRule>();
        public TaxCalculationEngine(IEnumerable<ITaxCalculationRule> rules)
        {
            _rules.AddRange(rules);
        }
        public async Task CalculateTaxPercentage(TaxPayer taxPayer)
        {
            _rules.ForEach(r => r.CalculateTax(taxPayer));
        }
    }
}
