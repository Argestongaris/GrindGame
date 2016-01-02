using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassResource
{
    //podstawowe zasoby, kumulowane x szt / s
    public class Resource
    {
        public string Name;
        public int ID;
        public int Value;               //1-999
        public int Power;               //quantity = Value * 10 ^ Power
        //jak zrobić mechanizm naliczania i zmieniania potęg?

        public Resource(int id, string name, int value, int power) 
        {
            this.Name = name;
            this.ID = id;
            this.Value = value;
            this.Power = power;
        }
    }

    //lista podstawowych zasobów
    public class BasicResources
    {
        public List<Resource> basic_resources {get; set;}

        public BasicResources() 
        {
            this.basic_resources = new List<Resource>();
        }
    }

    //dodatkowe zasoby, generowane działaniem gracza
    public class ClickResource : Resource
    {
        int ProduceTime;
        int[] ReqResources;

        public ClickResource(int id, string name, int value, int power, int produceTime, int[] reqResources) 
            : base(id, name, value, power)
        {
            // ? if (id >= 200)
                this.Name = name;
                this.ID = id;
                this.Value = value;
                this.Power = power;
                this.ProduceTime = produceTime;
                this.ReqResources = reqResources;
        }
    }

    //lista podstawowych zasobów
    public class ClickListResources
    {
        public List<ClickResource> click_resources {get; set;}

        public ClickListResources() 
        {
            this.click_resources = new List<ClickResource>();
        }
    }

}
