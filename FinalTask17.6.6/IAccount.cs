namespace FinalTask17._6._6
{
    public interface IAccount
    {
        // тип учетной записи
        public string? Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        void CalculateInterest();
    }
}