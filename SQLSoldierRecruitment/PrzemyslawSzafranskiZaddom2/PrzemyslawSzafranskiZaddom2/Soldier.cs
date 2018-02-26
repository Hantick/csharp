using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzemyslawSzafranskiZaddom2
{
    public class Soldier:Human
    {
        public int WeaponDMG { get; set; }

        readonly int soldierBonusDMG = 20;
        readonly int soldierBonusCondition = 15;

        string CLASSNAME = "Żołnierz";
        public Soldier()
        {
            Name = "Nieznany żołnierz";
            HealthPoints = GenerateHumanHP();
            Damage = GenerateHumanDMG() + soldierBonusDMG;
            Condition = GenerateHumanCondition() + soldierBonusCondition;
        }
        public Soldier(string soldierName)
        {
            if (soldierName == null || soldierName == "") { Name = "Nieznany żołnierz"; }
            else Name = soldierName;
            //Generowanie wartości HP,DMG i kondycji żołnierza
            HealthPoints = GenerateHumanHP();
            Damage = GenerateHumanDMG()+ soldierBonusDMG;
            Condition = GenerateHumanCondition()+soldierBonusCondition;

        }
        /// <summary>
        /// Metoda generująca damage broni zolnierza
        /// </summary>
        /// <returns></returns>
        protected int GenerateSoldierWeaponDMG()
        {
            System.Random x = new Random();
            return (HealthPoints/ x.Next(2, 5)) * Damage;
        }

        public string GetName()
        {
            return Name;
        }
        public int GetHP()
        {
            return HealthPoints;
        }
        public int GetDMG()
        {
            return Damage;
        }
        public string GetCondition()
        {
            return Condition;
        }
        /* public string PromoteSoldier()
         {
             new Marine(Name,HealthPoints,Damage,Condition);

             return "Awansowano żołnierza " + Name + " na Marine!";
         }*/
    }
}
