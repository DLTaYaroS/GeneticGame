﻿using System;
using System.Collections.Generic;
using System.Linq;
using GeneticGame.Figure.BotFigure;
namespace GeneticGame
{
    class FigureStorage
    {
        public List<Bot> Bots { get; set; }
        public List<Eat> Eats { get; set; }
        public Eat EatExistInCoord(Coord coord)
        {
            return Eats.FirstOrDefault(e => e.ModelCoord.Equals(coord));           
        }
        public FigureStorage()
        {
            Bots = new List<Bot>();
            Eats = new List<Eat>();
        }
        public void RemoveEat(Eat eat)
        {
            DataManager.GetInstance().mapa.Clean(eat.Figure);
            Eats.Remove(eat);
        }
        public void RemoveBots(IEnumerable<Bot> bots)
        { 
            foreach(Bot bot in bots)
            {
                Bots.Remove(bot);
                DataManager.GetInstance().mapa.Clean(bot.Figure);
            }
        }
        public void AddBots(IEnumerable<Bot> bots)
        {
            Bots.AddRange(bots);
        }
        public void AddEat(Eat eat)
        {
            Eats.Add(eat);
        }
    }
}