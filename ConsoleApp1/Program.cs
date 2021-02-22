using AutoMapper;
using ConsoleApp1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{
			IRepository<User> repo = new UserRepository();
			// Создание конфигурации сопоставления
			var config = new MapperConfiguration(cfg => cfg.CreateMap<User, IndexUserViewModel>());
			// Настройка AutoMapper
			var mapper = new Mapper(config);
			// сопоставление
			var users = mapper.Map<List<IndexUserViewModel>>(repo.GetAll());



			DataService service = new DataService();
			string result = "";
			var collection = new Dictionary<int, IEnumerable<int>>();
			for (int i = 0; i < 10000; i++)
			{
				collection.Add(i, Enumerable.Range(1, 10000));
				IEnumerable<int> col = Enumerable.Range(1, 10000);
				for (int j = 0; j < 65; j++)
				{
					
					result = j == 0 ? $"{i};{j};" : $"{result}{j};";
				}
				result = $"{result}\r";
				//service.WritekData(result);
				//Console.WriteLine(result);
			}
			Console.ReadLine();
			foreach (var item in collection)
			{
				
				Console.WriteLine(item.);
			}
		}


	}
}
