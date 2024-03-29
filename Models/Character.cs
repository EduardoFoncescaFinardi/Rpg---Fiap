﻿namespace Rpg___Fiap.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Froddo";
        public int HitPoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}
