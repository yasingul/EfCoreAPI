using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SolidPrinciples
{
    /* Liskov's Substution Principle'a göre alt nesneler türetildikleri sınıfların özelliklerini alabilmeli.
       Bazı durumlarda gereksiz kod kullanımı olacağı için bu ayrımı yapmamız gerekecek.*/ 
    public abstract class Player    //Ana sınıf
    {
        public virtual string KickTheBall() //Alt sınıfların ortak kullandığı özellik.
        {
            return "kick the ball";
        }
    }
    public interface IKeepTheBall   //Alt sınıfları ayıran özellik. 
    {
        string Keep();
    }
    public class Striker : Player 
    {
        public override string KickTheBall()
        {
            return "Striker kick the ball";
        }
    }
    public class Goalkeeper : Player, IKeepTheBall
    {
        public override string KickTheBall()
        {
            return "Goalkeeper kick the ball";
        }
        public string Keep()
        {
            return "Goalkeeper keep the ball";
        }
    }
}
