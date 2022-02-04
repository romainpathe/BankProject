using System.Collections.Generic;

namespace Bank
{
    public class Bank
    {
        public string Code { get; }
        public string Name { get; }
        public List<Agency> AgencyList { get; }

        public Bank()
        {
            
        }
        
        public Bank(string code, string name)
        {
            Code =  code;
            Name = name;
            AgencyList = new List<Agency>();
            AgencyList.Add(new Agency("Agence1","A1",067965904,new Address("Adress1","Adress2",new City("Nanterre","92000"))));
            AgencyList.Add(new Agency("Agence2","A2",067965904,new Address("Adress1","Adress2",new City("Nanterre","92000"))));
        }

        public override string ToString()
        {
            return "Nom: " + Name + "\nCode: " + Code + "\nListe des agences: " + AgencyList;
        }
    }
}