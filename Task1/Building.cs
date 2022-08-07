using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        double length;
        double width;
        double height;
        public string Address { get; set; }
        public double Length
        {
            get 
            {
                return length;
            }
            set
            {
                if (value <= 0)
                {
                    length = -1;
                }
                else
                {
                    length = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    width = -1;
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    height = -1;
                }
                else
                {
                    height = value;
                }
            }
        }
        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public string GetInform()
        {
            return $"Адрес здания: {Address}\nГабариты здания, м (Длина х Ширина х Высота): {Length} x {Width} x {Height}";
        }
    }
}
