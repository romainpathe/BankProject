namespace Bank
{
    public class Agency
    {
        private readonly string _code;
        private readonly int _phoneNumber;
        private readonly Address _address;
        

        public string Code => _code;

        public int PhoneNumber => _phoneNumber;
        
        public Address Address => _address;

        public Agency(string code, int phoneNumber, Address address)
        {
            this._code = code;
            this._phoneNumber = phoneNumber;
            this._address = address;
        }


        public override string ToString()
        {
            return "Agency Code: " + _code + "\nTéléphone: " + _phoneNumber + "\nAddress: " + _address;
        }
    }
}