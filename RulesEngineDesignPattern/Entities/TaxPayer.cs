namespace RulesEngineDesignPattern.Entities
{
    public class TaxPayer
    {
        public bool IsRetired { get; set; }
        public bool IsSingle { get; set; }
        public double Sallary { get; set; }
        public int TaxPercentage { get; set; }
        public double TaxAmount { get; private set; }
        public async Task CalculateTax()
        {
            TaxAmount = Sallary * TaxPercentage / 100;
        }
    }
}
