using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassResource
{
    public static class ProgSettings
    {
        public const int ResourcesMinID = 1;
        public const int ResourcesMaxID = 199;
        public const int ClickResourcesMinID = 200;
        public const int ClickResourcesMaxID = 1000;


    }
    public static class GameMath
    {
        public bool UIntPlus(UInt64 a_value, UInt64 b_value)
        {   bool a_flag = false;
            bool b_flag = false;
            UInt64 temp = UInt64.MaxValue/2;
            if (a_value > temp)
            {
                a_value = a_value - temp;
                a_flag = true;
            }

            if (b_value > temp)
            {
                b_value = b_value - temp;
                b_flag = true;
            }

            if (a_flag && b_flag) {
                return true;
            } 
            else 
            {
                if (a_value + b_value > temp)
                {
                    if (a_flag || b_flag)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UIntMinus(UInt64 a_value, UInt64 b_value)
        {
            if (a_value > b_value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UInt64[] UIntDodaj(UInt64 a_value, UInt64 a_multiplier, UInt64 b_value, UInt64 b_multiplier)
        {   
            UInt64[] ending= new UInt64[2];
            if (UIntPlus(a_value, b_value))
            {
                bool a_flag = false;
                bool b_flag = false;
                UInt64 temp = UInt64.MaxValue / 2;
                if (a_value > temp)
                {
                    a_value = a_value - temp;
                    a_flag = true;
                }

                if (b_value > temp)
                {
                    b_value = b_value - temp;
                    b_flag = true;
                }

                if (a_flag && b_flag)
                {
                    if (UIntPlus(a_multiplier, b_multiplier))
                    {
                        ending[0] = UInt64.MaxValue;
                        ending[1] = UInt64.MaxValue;
                    }
                    else
                    {
                        ending[1] = a_multiplier + b_multiplier + 1;
                    }
                }
                else
                {
                    if (a_value + b_value > temp)
                    {
                        if (a_flag || b_flag)
                        {
                            ending[1] = a_multiplier + b_multiplier + 1;
                            ending[0] = a_value + b_value - temp;
                        }
                    }
                    else
                    {
                        ending[1] = a_multiplier + b_multiplier + 1;
                        ending[0] = a_value + b_value;
                    }
                }
            }
            else
            {
                ending[1] = a_multiplier + b_multiplier + 1;
                ending[0] = a_value + b_value;
            }
            return ending;
        }


        public UInt64[] UIntOdejmij(UInt64 a_value, UInt64 a_multiplier, UInt64 b_value, UInt64 b_multiplier)
        {
            UInt64[] ending = new UInt64[2];
            if (UIntMinus(a_value, b_value))
            {
                if (UIntMinus(a_multiplier, b_multiplier))
                {
                    ending[0] = 0;
                    ending[1] = 0;
                }
                else
                {
                    ending[0] = a_value - b_value;
                    ending[1] = a_multiplier - b_multiplier;
                }
            }
            else
            {
                if (UIntMinus(a_multiplier, b_multiplier))
                {
                    ending[0] = 0;
                    ending[1] = 0;
                }
                else
                {
                    if ((a_multiplier - b_multiplier) > 0)
                    {
                        ending[0] = b_value - a_value;
                        ending[1] = a_multiplier - b_multiplier - 1;
                    }
                    else
                    {
                        ending[0] = 0;
                        ending[1] = 0;
                    }
                }
            }
            return ending;
        }
    }
}
