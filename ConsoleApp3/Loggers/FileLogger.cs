using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodersLab.DependencyInjection
{
    public class FileLogger : ILogger
    {
	    public void Log(string message)
	    {
		    var path = @"C:\tmp\Log.txt";

		    File.AppendAllLines(path, new [] { message });
	    }
    }
}
