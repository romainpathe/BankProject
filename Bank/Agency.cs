namespace Bank
{
    public class Agency
    {
        private string code;
        private int phoneNumber;
        private Address address;
        

        public string Code => code;

        public int PhoneNumber => phoneNumber;
        
        public Address Address => address;

        public Agency(string code, int phoneNumber, Address address)
        {
            this.code = code;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }


        public override string ToString()
        {
            return "Agency Code: " + code + "\nTéléphone: " + phoneNumber + "\nAddress: " + address;
        }
    }
}