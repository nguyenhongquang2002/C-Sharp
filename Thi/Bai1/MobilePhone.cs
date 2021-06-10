using T2009M.Practical;

namespace Thi.Bai1
{
    public class MobilePhone : Phone
    {
        public MobilePhone()
        {
        }
        
        public MobilePhone(string phoneName, string phoneType, float phonePrice) : base(phoneName, phoneType, phonePrice)
        {
            this.phoneType = "Mobile";
        }

        public void Display()
        {
            base.Display();
        }
        
        
    }
}