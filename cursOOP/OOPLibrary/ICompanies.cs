namespace OOPLibrary
{
    public interface ICompanies
    {
        bool FinancialStatus { get; set; }

        void MakeLoan(string name, int CUI);
        void PayLoan(string name, int CUI);
    }
}