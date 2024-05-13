﻿
namespace GameZone.Models
{
    public class Game:BaseEntitiy
    {
        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(500)] //string requird by defualt in .net from .net6
        
        public string Cover { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        public Category? category { get; set; }

        public ICollection<GameDevice> Device { get; set; } = new List<GameDevice>();


    }
}