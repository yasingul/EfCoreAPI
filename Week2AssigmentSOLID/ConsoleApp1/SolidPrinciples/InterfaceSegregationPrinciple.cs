using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SolidPrinciples
{
    /*  Batman ve Superman'in benzer özelliklerinin olmasının yanı sıra 
        farklı özellikleri olduğundan ötürü bu farklılıkları farklı interfacelere 
        dönüştürerek prensibimize uymuş olduk. */
    public interface ISuperHero //ikisinin de güçleri ve kostümleri var o yüzden aynı interface'e yerleştirdik.
    {
        string Costume();
        string Power();
    }
    public interface IBatCave //Batman'i Superman'den ayıran özellikleri belirtiriz.
    {
        string UseBatMobiles();
        string IHaveServant();
    }
    public interface IFly   //Superman'i Batman'den ayıran özellikleri ekleyebiliriz.
    {
        string FlyToEveryWhere();
    }
    public class Batman : ISuperHero, IBatCave
    {
        public string Costume()
        {
            return "My costume is dark";
        }

        public string IHaveServant()
        {
            return "My servant is Alfred.";
        }

        public string Power()
        {
            return "My power is money!";
        }

        public string UseBatMobiles()
        {
            return "I can use BatCar, BatMoto and BatWing";
        }
    }
    public class SuperMan : ISuperHero, IFly
    {
        public string Costume()
        {
            return "My costume is red and blue.";
        }

        public string FlyToEveryWhere()
        {
            return "I can fly.";
        }

        public string Power()
        {
            return "I have super strenght, fly, laser and more.";
        }
    }
}
