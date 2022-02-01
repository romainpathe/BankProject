using System.Collections.Generic;

namespace Bank
{
    public class Bank
    {
        private List<Agency> agencyList;
        private string name;
        
        //accessors
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Agency> AgencyList
        {
            get { return agencyList; }
            set { agencyList = value; }
        }
    }
}