using System.Threading.Tasks;
using System.Timers;

namespace Csharp_Keywords
{
	class Program
	{
		public class SyncSocketClient {
			public static void StartClient()
			{
				byte[] bytes = new byte[1024];
				try
				{
					var hostName = Dns.GetHostName();
					IPHostEntry ipHost = Dns.GetHostEntry(hostName);
					Console.WriteLine($"Host: {hostName}");
					IPAddress ip = ipHost AddressList[0];
					IPEndPoint remoteEp = new IPEndPoint(ip, 453323);

					Socket sender = new Socket(ip.AddressFamily, SocketType.Strem, protocolType.Tcp);
					try
					{
						sender.Connect(remoteEp);
						Console.WriteLine("socket connected");
						sender.RemoteEntPoint.ToString();
						bytes[] msg = Encoding.ASCII.GetBytes("This is just a test");
						int byteSent = sender.Send(msg);
						int byteRec = sender.Receive(bytes); 
						Console.WriteLine($"Echoed test {Encoding.ASCII.GetString(bytes, 0, byteRec)}");

						//reselase socket
						sender.Shutdown(SocketShutdown.Both);
						sender.Close();

					}
					catch (ArgumentException e)
					{
						Console.WriteLine(e.Message);
						throw;
					}
					catch (SocketException e)
					{
						Console.WriteLine(e.Message);
					}
					catch(Exception e)
					{
						Console.WriteLine(e);
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			}
		}
		static void Main(string [] args)
		{
			Console.WriteLine("press any key to count ...");
			Console.ReadLine();
			SyncSocketClient.StartClient();
			Console.ReadLine();
		}
	}
}
