using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Champions : List<Champion>
    { }
    public class Champion
    {
        public decimal Attack { get; set; }

        public decimal Defense { get; set; }

        public decimal Magic { get; set; }

        public decimal Difficulty { get; set; }

        public decimal Hp { get; set; }

        public decimal HpUpPerLevel { get; set; }

        public decimal Mp { get; set; }

        public decimal MpUpPerLevel { get; set; }

        public decimal MoveSpeed { get; set; }

        public decimal Armor { get; set; }

        public decimal ArmorPerLevel { get; set; }

        public decimal SpellBlock { get; set; }

        public decimal SpellBlockPerLevel { get; set; }

        public decimal AttackRange { get; set; }

        public decimal HpRegen { get; set; }

        public decimal HpRegenPerLevel { get; set; }

        public decimal MpRegen { get; set; }

        public decimal MpRegenPerLevel { get; set; }

        public decimal AttackDamage { get; set; }

        public decimal AttackDamagePerLevel { get; set; }

        public decimal AttackSpeedOffset { get; set; }

        public int ChampionId { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

    }

}
