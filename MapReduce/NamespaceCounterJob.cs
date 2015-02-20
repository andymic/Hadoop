using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;

namespace MapReduce
{
    public class NamespaceCounterJob: HadoopJob<NamespaceMapper,NamespaceReducer>
    {
        public override HadoopJobConfiguration Configure( ExecutorContext context)
        {
            var config = new HadoopJobConfiguration();
            config.InputPath = "input/CodeFiles";
            config.OutputFolder = "output/CodeFiles";
            return config;
        }
    }
}
