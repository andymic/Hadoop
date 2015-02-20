using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;
using System.Text.RegularExpressions;

namespace MapReduce
{
    public class NamespaceMapper: MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            var reg = new Regex(@"(using)\s[/a-za-z0-9_\.]*\;");
            var matches = reg.Matches(inputLine);

            foreach(Match match in matches)
            {
                context.EmitKeyValue(match.Value, "1");
            }
        }
    }
}
