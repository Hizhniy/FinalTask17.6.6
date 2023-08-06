namespace FinalTask17._6._6
{

    // Обычный аккаунт
    public class AccountSalary : IAccount
    {        
        public string? Type { get; set; }

        public double Balance { get; set; }
             
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;            
        }
    }
}
