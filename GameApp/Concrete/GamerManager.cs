using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
	class GamerManager : IGamerService
	{
		IUserValidationService userValidationService;
		private NewEStateUserValidationManager newEStateUserValidationManager;

		public GamerManager(IUserValidationService userValidationService)
		{
			this.UserValidationService = userValidationService;
		}

		public GamerManager(NewEStateUserValidationManager newEStateUserValidationManager)
		{
			this.newEStateUserValidationManager = newEStateUserValidationManager;
		}

		public IUserValidationService UserValidationService { get; }

		public void Add(Gamer gamer)
		{
			if (userValidationService.Validate(gamer))
			{
				Console.WriteLine(gamer.FirstName + "Kayıt oldu");
			}
			else
			{
				Console.WriteLine("Kayıt başarısız");
			}
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("Kayıt silindi");
		}

		public void Upddate(Gamer gamer)
		{
			Console.WriteLine("Kayıt güncellendi");
		}
	}
}
