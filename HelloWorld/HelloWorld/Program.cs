using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DownLoadWeb();
            Console.ReadKey();
        }

        private static void DownLoadWeb()
        {
            var client = new HttpClient();

        }
    }
}
