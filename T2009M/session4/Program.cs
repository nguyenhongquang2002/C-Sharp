/*namespace T2009M.session4
{
    public delegate void ShowString(string s);// khai bao 1 delegate dai dien cho cac ham return void vaf tham so: string
    public class Program
    {
        public static ShowString ss = new ShowString(DemoDelegate.ShowMsg);
       public static void Main(string[] args)
        {
            // DemoDelegate.ShowMsg("xin chao cac ban");
            // DemoDelegate dd = new DemoDelegate();
            // dd.ShowInfo("xin chao cac ban");
            // ShowString ss = new ShowString(DemoDelegate.ShowMsg);// truyen vao ten cua ham
            DemoDelegate dd = new DemoDelegate(); // nap them vao vao danh sach thuc hien
            ss += DemoDelegate.ShowMsg;
            ss += DemoDelegate.ShowMsg;
            ss("xin chao cac ban");// chay delegate
        }
    }
}*/