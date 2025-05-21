using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace SingletonTest;

public sealed class Singleton
{
	private static Singleton instance = null;
	private static readonly object Padlock = new object();
	private static readonly ILogger logger = LoggerFactory.Create(builder => builder.AddConsole())
		.CreateLogger<Singleton>();

	public static Singleton Instance
	{
		get
		{
			String ? message = "Singleton instance requested.";
			logger.Log(LogLevel.Information, message);
			
			if (instance == null)
			{
				lock (Padlock)
				{
					if (instance == null)
					{
						instance = new Singleton();
					}
				}
			}

			return instance;
		}
	}

	private Singleton()
	{
		logger.Log(LogLevel.Information, "Singleton instance created.");
	}

}