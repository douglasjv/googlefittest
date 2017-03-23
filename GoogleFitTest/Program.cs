using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Fitness.v1;
using Google.Apis.Services;

namespace GoogleFitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var credential = {...};

            var service = new FitnessService(new BaseClientService.Initializer()
            {
                ApplicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                HttpClientInitializer = credential
            });
        }
    }
}
