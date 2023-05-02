//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPrinciple.FactoryPattern
//{
//    public class Client
//    {
//        public static void Main()
//        {
//            SamsungFactory samsungFactory = new SamsungFactory();
//            RedmiFactory redmiFactory = new RedmiFactory();

//            var samsungPhone = samsungFactory.CreateMobile(MobileType.SamsungGalaxy);
//            var redmiPhone = redmiFactory.CreateMobile(MobileType.RedmiPro);

//            samsungPhone.MobileDescription();
//            redmiPhone.MobileDescription();
//        }
//    }
//}
