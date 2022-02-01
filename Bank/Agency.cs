namespace Bank
{
    public class Agency
    {
        private static int _id = 0;
        private readonly Bank _bank;
        

        public string Code { get;}
        public string Name { get;}
        public int PhoneNumber { get; }
        public Address Address { get; }

        public Agency(string name, string code, int phoneNumber, Address address, Bank bank)
        {
            this.Name = name;
            this.Code = bank.Code+"-"+_id;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this._bank = bank;
            _id++;
        }


        public override string ToString()
        {
            return "Information de l'agence "+Name+":\nCode de l'agence: " + Code + "\nTéléphone: " + PhoneNumber + "\nAddress: " + Address;
        }
    }
}