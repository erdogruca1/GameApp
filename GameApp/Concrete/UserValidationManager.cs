using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
	 class UserValidationManager: IUserValidationSerivce
	{
		public bool Validate(Gamer gamer)
		{
			if (gamer.BirthYear == 1999 && gamer.FirstName == "Muhammet" && gamer.LastName== "Erdoğruca"&& gamer.IdentityNumber == 12345)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
