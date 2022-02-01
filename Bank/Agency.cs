namespace Bank
{
    public class Agency
    {
        private static int _id = 0;
        private readonly Bank _bank;
        

        public string Code { get;}
        public int PhoneNumber { get; }
        public Address Address { get; }

        public Agency(string code, int phoneNumber, Address address, Bank bank)
        {
            this.Code = bank.Code+"-"+_id;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this._bank = bank;
            _id++;
        }


        public override string ToString()
        {
            return "Agency Code: " + Code + "\nTéléphone: " + PhoneNumber + "\nAddress: " + Address;
        }
    }
}