using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
	class CompaignManager : ICompaignService
	{
		public void Add(Compaign compaign)
		{
			Console.WriteLine(compaign.Name + "adlı" + compaign.DiscountRate + "indirim oranlı kampanya eklendi");
		}

		public void CalculateDiscount(Compaign compaign, Game game)
		{
			double newPrice = (game.Price / 100) * compaign.DiscountRate;
			newPrice = game.Price - newPrice;
			game.Price = newPrice;
			Console.WriteLine("ürünün kampanyalı fiyatı" + game.Price.ToString());
		}

		public void Delete(Compaign compaign)
		{
			Console.WriteLine(compaign.Name + "Silindi");
		}

		public void Update(Compaign compaign)
		{
			Console.WriteLine(compaign.Name + "Güncellendi");
		}
	}
}
