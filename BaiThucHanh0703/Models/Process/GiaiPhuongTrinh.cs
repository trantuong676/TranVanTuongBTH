namespace BaiThucHanh0703.Models.Process
{
    public class GiaiPhuongTrinh
    {
        public string GiaiPhuongTrinhB1(double a, double b)
        {
            double x = -b/a;
            return "Nghiem cua phuong trinh x= " +x;
        }
        public string GiaiPhuongTrinhB2(string heSoA, string heSoB, string heSoC)
        {
             //khai bao bien
            double delta, x1, x2, a =0, b=0, c=0; //luu gia tri, neu ko gan thi khi so sanh se bao loi
            string kq;
            //Giai phuong trinh
            if(a==0) kq = "Khong phai phuong trinh bac 2";
            else{
                //tinh delta
                delta = Math.Pow(b,2) - 4*a*c;
                // Giai phuong trinh
                if(delta<0) kq ="Phuong trinh vo nghiem";
                else if(delta==0)
                {
                    x1 = -b/(2*a);
                    kq ="Phuong trinh co nghiem kep = "+ x1;
                }
                else 
                {
                    x1= (-b + Math.Sqrt(delta))/(2*a);
                    x2= (-b - Math.Sqrt(delta))/(2*a);
                    kq = "Phuong trinh co 2 nghiem phan biet: x1= "+ x1 + ", x2= "+x2;
                }
            }
            return kq;
        }
        
    }
}