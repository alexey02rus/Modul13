using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed class MultiBuilding: Building
    {
        int storeys;
        public int Storeys
        {
            get
            {
                return storeys;
            }
            set
            {
                if (value <=1 || value >100)
                {
                    storeys = -1;
                }
                else
                {
                    storeys = value;
                }
            }
        }
        public MultiBuilding(string address, double length, double width, double height, int storeys)
            :base(address, length, width, height)
        {
            Storeys = storeys;
        }
        public new string GetInform()
        {
            return $"{base.GetInform()}\nЭтажность: {Storeys}";
        }
    }
}
