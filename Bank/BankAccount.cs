namespace Bank
{
    public class BankAccount
    {
        //static attributes
        private static int _id = 0;
        // instance Attributs
        private string _iban;
        private string _libelle;
        private double _solde;
        private Customer _client;
        private string _codeAgence;
        private Agency _agency;

        // Constructor
        public BankAccount()
        {
            _iban = _agency.Code + _id + "U"+ _client.Lastname[0] + _client.Firstname[0] + (_id/3);
            _libelle = "";
            _solde = 0;
            _client = new Customer();
            _id++;
        }
        public BankAccount(string libelle, double solde, Customer client, Agency agency)
        {
            _iban = "";
            _libelle = libelle;
            _solde = solde;
            _client = client;
            _agency = agency;
            _id++;
        }
        
        // Properties
        public string Iban
        {
            get { return _iban; }
        }
        
        public string Libelle
        {
            get { return _libelle; }
        }
        
        public double Solde
        {
            get { return _solde; }
        }
        
        public Customer Client
        {
            get { return _client; }
        }
        
        public Agency Agency
        {
            get { return _agency; }
            set { _agency = value; }
        }
        
        // Methods
        public void Deposit(double amount)
        {
            _solde += amount;
        }
        
        public bool Withdraw(double amount)
        {
            if (_solde - amount >= 0)
            {
                _solde -= amount;
                return true;
            }

            return false;
        }
        
        public void InternalVirement(BankAccount account, double amount)
        {
            if (account.Client == this.Client)
            {
                if (Withdraw(amount))
                {
                    account.Deposit(amount);
                }
            }
        }
        
        public void ExternalVirement(BankAccount account, double amount)
        {
            if (Withdraw(amount))
            {
                account.Deposit(amount);
            }
        }
        
        
        
        
    }
}