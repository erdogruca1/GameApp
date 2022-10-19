using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
	 interface IGamerService
	{
		void Add(Gamer gamer);
		void Upddate(Gamer gamer);
		void Delete(Gamer gamer);
	}
}
