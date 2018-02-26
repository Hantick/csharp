using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzemyslawSzafranskiZaddom2
{
    public class Marine:Soldier
    {
        /// <summary>
        /// Marine miał w domysle powstawac poprzez promocje zolnierza, ale braklo mi na zrobienie tego czasu
        /// </summary>
        string CLASSNAME = "Marine";
        public Marine(string name)
        {
            if (name == null || name == "")
                Name = "Nieznany Marine";
            else Name = name;
            HealthPoints = GenerateHumanHP() + 30;
            Damage = GenerateHumanDMG() + 50;
            Condition = GenerateHumanCondition() + 30;
        }
        
    }
}
