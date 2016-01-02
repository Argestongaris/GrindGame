using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassResource
{
    class Phenomenons
    {
        int ID;                 //phenomenon's ID
        string Name;            //short name of phenomenon (vulcanic eruption, earthquake)
        string Description;     //long description 
        int[] Efect;            //list of ID, quantity affecting resources lists
        //+x sztuk, +x% do produkcji
        int Time;               //How long phenomenon will last
    }
}
