using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Task = ConsoleApp1.parameters.Task;

namespace ConsoleApp1
{

    public class EmiJson
    {
        Task t = null;
        public EmiJson(Task t)
        {
            this.t = t;
        }

        public string Serialise()
        {
            return JsonSerializer.Serialize(this.t);
        }
    }
}
