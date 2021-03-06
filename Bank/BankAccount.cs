namespace Bank
{
    public class BankAccount
    {
        //static attributes
        private static int _id = 0;
        // instance Attributes
        private string _name;
        private string _iban;
        private int _libelle;
        private double _solde;
        private Customer _client;
        private string _codeAgence;
        private Agency _agency;

        // Constructor
        public BankAccount()
        {
            _iban = _agency.Code + _id + "UFR" + _client.Lastname[0] + _client.Firstname[0] + (_id/3)+_client.Code;
            _libelle = 1;
            _solde = 0;
            _client = new Customer();
            _id++;
        }
        public BankAccount(int libelle, double solde, Customer client, Agency agency)
        {
            _iban = _agency.Code + _id + "UFR" + _client.Lastname[0] + _client.Firstname[0] + (_id/3)+_client.Code;
            _libelle = libelle;
            if (libelle == 1)
            {
                _name = "Compte courant";
            }
            else if (libelle == 2)
            {
                _name = "Compte épargne";
            }else if (libelle == 3)
            {
                _name = "PEL";
            }
            else
            {
                _name = "Custom";
            }
            _solde = solde;
            _client = client;
            _agency = agency;
            _id++;
        }
        
        // Properties
        public string Name
        {
            get { return _name; }
        }
        public string Iban
        {
            get { return _iban; }
        }
        
        public int Libelle
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
        
        public (bool, string) Withdraw(double amount)
        {
            if (_solde - amount >= 0 && _libelle != 3)
            {
                _solde -= amount;
                return (true, "");
            }
            if (_solde - amount < 0)
            {
                return (false, "Solde insuffisant.");
            }
            return (false, "Compte PEL, pas de retrait !");
        }
        
        public string InternalVirement(BankAccount account, double amount)
        {
            if (account.Client == this.Client)
            {
                var (success, msg) = Withdraw(amount);

                if (!success) return msg;
                account.Deposit(amount);
                return "";
            }
            return "Les deux comptes ne sont pas du même client.";
        }
        
        public string ExternalVirement(BankAccount account, double amount)
        {
            var (success, msg) = Withdraw(amount);

            if (!success) return msg;
            account.Deposit(amount);
            return "";
        }
        
        public string Transfer(BankAccount account, double amount)
        {
            if (account.Client == this.Client)
            {
                return InternalVirement(account, amount);
            }
            return ExternalVirement(account, amount);
        }
        
        
        
        
    }
}