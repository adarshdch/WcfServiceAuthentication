using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceConsumer
{
	class Program
	{
		static void Main(string[] args)
		{
			try{
				using(var client = new WindowsAuthWcfServiceRef.Service1Client())
				{
					Console.WriteLine("Please enter your name: ");
					var input = Console.ReadLine();
					Console.WriteLine(String.Format("Greeting from WCF Service: {0}", client.Greet(input)));

					Console.ReadKey();
				}

			}
			catch(Exception e)
			{
				Console.WriteLine("Exception occured: " + e.Message);
				Console.ReadKey();
			}
		}
	}
}
