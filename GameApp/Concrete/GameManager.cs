using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
	class GameManager : IGameService
	{
		List<Game> games = new List<Game>() { };
		public void Add(Game game)
		{
			games.Add(game);
			Console.WriteLine(game.Name + "oyun kaydedildi");
		}
	}
}
