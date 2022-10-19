﻿using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
	 interface IUserValidationService
	{
		bool Validate(Gamer gamer);
	}
}
