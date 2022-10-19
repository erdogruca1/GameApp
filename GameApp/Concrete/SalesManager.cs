using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
	class SalesManager : ISalesService
	{

		public SalesManager(Compaign compaign)
		{
			compaign = compaign;
		}

		public void SellTo(Gamer gamer, Game game)
		{
			Console.WriteLine(gamer.FirstName + "adlı kullanıcı" + game.Name + "adlı oyunu" + game.Price + " fiyatıyla aldı ");
		}
	}
}
