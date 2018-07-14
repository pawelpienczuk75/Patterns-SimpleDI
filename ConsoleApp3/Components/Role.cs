using System;
using System.Collections.Generic;
using System.Text;

namespace CodersLab.DependencyInjection
{
	public class Role
	{
		public ILogger Logger { get; set; }

		public Role RemoveUserFromRole(string message)
		{
			Logger.Log($"Usunięcie Użytkownika {message} z Roli.");
			return this;
		}
	}
}
