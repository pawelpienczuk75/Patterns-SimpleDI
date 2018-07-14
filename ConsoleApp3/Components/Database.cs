using System;
using System.Collections.Generic;
using System.Text;

namespace CodersLab.DependencyInjection
{
	public class Database
	{
		private ILogger _logger;

		public void SetLogger(ILogger logger)
		{
			_logger = logger;
		}

		public Database Open()
		{
			if (_logger != null)
			{
				_logger.Log("Otwarcie Połączenia z Bazą.");
			}
			else
			{
				Console.WriteLine("Nie przekazano obiektu dz. po interfejsie ILogger");
			}

			return this;
		}
	}
}
