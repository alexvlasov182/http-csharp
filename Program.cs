using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace http
{
  class Program
  {
    HttpClient client = new HttpClient();
    static async Task Main(string[] args)
    {
      Program program = new Program();
      await program.GetTodoItems();
    }

    private async Task GetTodoItems()
    {
      string response = await client.GetStringAsync("https://api.publicapis.org/entries");
      Console.WriteLine(response);
    }
  }
}
