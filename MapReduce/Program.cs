using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;
using Microsoft.Hadoop.WebHDFS;
using Microsoft.Hadoop.WebHCat;

namespace MapReduce
{
    class Program
    {
        static void Main(string[] args)
        {
            var hadoop = Hadoop.Connect();
            var result = hadoop.MapReduceJob.ExecuteJob<NamespaceCounterJob>();
        }
    }
}
