namespace BankOCR;

public class AccountFixer
{
    public AccountFixer()
    {
    }

    public string TryToFixAccountNr(Account account)
    {
        return account.FinalNumber;
    }
}