using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassResource
{
    class Quest
    {
        int ID;                 //Quest's ID
        bool Status;            //Was the quest done
        string Name;            //Quest's name
        string Description;     //Info about quest
        int Time;               //how long quest takes
        int[] Reward;           //list of items' ID and quantity from Resources lists
        int[] ReqiredResource;  //list of ID, quantity, wearings(0/1) of items needed for quest 
        //warunki dostępności?
        //kolejność wykonywania?
        //możliwość zignorowania?

        public Quest(int id, bool status, string name, string description, int time, int[] reward, int[] requiredResource)
        {
            this.ID = id;
            this.Status = status;
            this.Name = name;
            this.Description = description;
            this.Time = time;
            this.Reward = reward;
            this.ReqiredResource = requiredResource;
        }

    }
}
