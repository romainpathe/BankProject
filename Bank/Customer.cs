using System.Collections.Generic;

namespace Bank
{
    public class Customer
    {
        private static int _id = 0;
        private readonly string _code;
        private readonly string _lastname;
        private readonly string _firstname;
        private List<BankAccount> _accounts;

        public Customer()
        {
            this._lastname = "";
            this._firstname = "";
            this._code = "306-"+_id;
            _id++;
        }

        public Customer(string lastname,string firstname)
        {
            this._lastname = lastname;
            this._firstname  = lastname;  
            this._code="306-"+_id;
            _id++;
        }

        public string Lastname => _lastname;

        public string Firstname => _firstname;

        public string Code => _code;
        
        public List<BankAccount> Accounts => _accounts;

        public override string ToString()
        {
            return "Nom et prénom: "+this._lastname + " " + this._firstname + "\nCode unique: " + this._code;
        }

    }
}