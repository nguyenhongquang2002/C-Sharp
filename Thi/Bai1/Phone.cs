using System;

namespace T2009M.Practical
{
    public class Phone
    {
        protected string phoneName;
        protected string phoneType;
        protected float phonePrice;

        public Phone()
        {
            
        }

        public Phone(string phoneName, string phoneType, float phonePrice)
        {
            this.phoneName = phoneName;
            this.phoneType = phoneType;
            this.phonePrice = phonePrice;
        }
        public string PhoneName
        {
            get => phoneName;
            set => phoneName = value;
        }

        public string PhoneType
        {
            get => phoneType;
            set => phoneType = value;
        }

        public float PhonePrice
        {
            get => phonePrice;
            set => phonePrice = value;
        }

        public void Display()
        {
            Console.WriteLine("Phone: " + PhoneName);
            Console.WriteLine("Type: " + PhoneType);
            Console.WriteLine("Price: " + PhonePrice);
        }
    }
}