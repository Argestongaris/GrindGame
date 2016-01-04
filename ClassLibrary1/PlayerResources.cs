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
        public UInt64 Value;               //1-999
        public UInt64 Multiplier;               //
        //jak zrobić mechanizm naliczania i zmieniania potęg?

        public Resource(int id, string name, UInt64 value, UInt64 multiplier) 
        {
            this.Name = name;
            this.ID = id;
            this.Value = value;
            this.Multiplier = multiplier;
        }

         private Resource Validate(int id, string name, UInt64 value, UInt64 multiplier) 
         {
             if ((id<=ProgSettings.ResourcesMaxID) && (id>=ProgSettings.ResourcesMinID) && (name!=string.Empty) )
	        {
		 
	        }
         }
    }

    //lista podstawowych zasobów
    public class AllResources
    {
        public List<Resource> all_resources {get; set;}

        public AllResources() 
        {
            this.all_resources = new List<Resource>();
        }
    }

    //dodatkowe zasoby, generowane działaniem gracza
    public class ClickResource : Resource
    {
        int ProduceTime;
        int[] ReqResources;

        public ClickResource(int id, string name, UInt64 value, UInt64 multiplier, int produceTime, int[] reqResources) 
            : base(id, name, value, multiplier)
        {
                if (id < 200)
                {
                    id=0;
                }
                this.Name = name;
                this.ID = id;
                this.Value = value;
                this.Multiplier = multiplier;
                this.ProduceTime = produceTime;
                this.ReqResources = reqResources;
        }

      //  private ClickResource Validate(int id, string name, int value, int power, int produceTime, int[] reqResources) 
      //      : base(id, name, value, power)
    }

    //lista podstawowych zasobów
    /*public class ClickListResources
    {
        public List<ClickResource> click_resources {get; set;}

        public ClickListResources() 
        {
            this.click_resources = new List<ClickResource>();
        }
    }*/

}
