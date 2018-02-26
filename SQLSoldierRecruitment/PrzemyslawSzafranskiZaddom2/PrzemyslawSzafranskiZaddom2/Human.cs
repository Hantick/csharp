using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzemyslawSzafranskiZaddom2
{
   public abstract class Human
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }
        public string Condition { get; set; }
        public string ClassName { get; set; }

        protected string CLASSNAME = "Człowiek";
        readonly int  MAXHUMANHP = 100;
        readonly int MAXHUMANDMG = 20;
        readonly int MAXHUMANCONDITION = 50;

        protected string IntroduceHuman()
        {
            string humanInfo = ClassName + Name + " HP: "+HealthPoints+" DMG: " + Damage+" Kondycja: "+Condition;
            return humanInfo;
        }
        /// <summary>
        /// Metoda zwracająca ocene kondycji czlowieka
        /// </summary>
        /// <returns></returns>
        protected string GenerateHumanCondition()
        {
            System.Random condition = new Random();
            if (condition.Next(1, MAXHUMANCONDITION) < 20)
            {
                return "Słaba";
            }
            else if (condition.Next(1, MAXHUMANCONDITION) > 30)
            {
                return "Dobra";
            }
            else return "W normie";
        }
        /// <summary>
        /// Metoda zwracająca HP człowieka
        /// </summary>
        /// <returns></returns>
        protected int GenerateHumanHP()
        {
            System.Random x = new Random();
            return x.Next(30, MAXHUMANHP);
        }
        /// <summary>
        /// Metoda zwracająca DMG człowieka
        /// </summary>
        /// <returns></returns>
        protected int GenerateHumanDMG()
        {
            System.Random dmg = new Random();
            return dmg.Next(5, MAXHUMANDMG);
        }
    }
}
