namespace FinalTask17._6._6
{

    // Обычный аккаунт
    public class AccountGeneral : IAccount
    {
        public string? Type { get; set; }

        public double Balance { get; set; }

        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000) Interest -= Balance * 0.2;
            if (Balance >= 1000) Interest -= Balance * 0.4; // по идее, можно else или должно быть >=10000, чтобы логичнее выглядело
        }
    }
}
