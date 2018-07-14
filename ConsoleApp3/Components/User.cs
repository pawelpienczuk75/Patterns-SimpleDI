using System;
using System.Collections.Generic;
using System.Text;

namespace CodersLab.DependencyInjection
{
	public class User
	{
		private readonly ILogger _logger;

		public User(ILogger logger)
		{
			_logger = logger;
		}

		public User LogIn()
		{
			_logger.Log("Logowanie użytkownika przez komponent wstrzyknięty!");

			return this;
		}
	}
}
