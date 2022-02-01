namespace Bank
{
    public class Customer
    {
        private static int num =1;
        private string lastname;
        private string firstname;
        private string code;

        public Customer()
        {
            this.lastname = "";
            this.firstname = "";
            this.code = "";
        }

        public Customer(string l,string p)
        {
            this.lastname = l;
            this.firstname  = p;  
            this.code="306 "+num;
            num++;
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }

        public string Firstname
        {
            get 
            { 
                return this.firstname; 
            }
            set 
            { 
                this.firstname = value; 
            }
        }

        public string Code
        {
            get => this.code;
        }

        public override string ToString()
        {
            return this.lastname + " " + this.firstname + " " + this.code;
        }

    }
}