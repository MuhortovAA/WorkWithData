using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
	public class DataService
	{

		private string FileName = "";
		public DataService()
		{
			FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", $"gtrm_{DateTime.Now.ToString("yyyyMMddHHmmss")}.txt");
			CheckFile();
		}
		private void CheckFile()
		{
			if (File.Exists(FileName))
			{
				File.Delete(FileName);
			}
			else
			{
			}
		}
		public void WriteData(string ResString)
		{
			using (StreamWriter outputFile = new StreamWriter(FileName, true))
			{
				outputFile.WriteLine(ResString);
			}

			//if (File.Exists(AppPath))
			//{

			//}
			//else
			//{

			//}
			//using (FileStream fs = File.OpenWrite(AppPath))
			//{
			//	string output = ResString;
			//	byte[] bytes = Encoding.Default.GetBytes(output);
			//	fs.Write(bytes, 0, bytes.Length);
			//}
		}
	}
}
