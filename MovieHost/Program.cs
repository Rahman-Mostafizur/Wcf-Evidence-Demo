using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MovieHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using(ServiceHost host = new ServiceHost(typeof(MovieService.MovieRepository)))
            {
                host.Open();

                Console.WriteLine("Service staretd at " + DateTime.Now);

                Console.ReadLine();

            }


        }
    }
}
