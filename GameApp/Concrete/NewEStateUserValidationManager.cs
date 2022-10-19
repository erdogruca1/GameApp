using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
	 class NewEStateUserValidationManager: IValidationService
	{
		public bool Validate(Gamer gamer)
		{
			return true;
		}
	}
}
