using System.Xml.Linq;
using Newtonsoft.Json;
using Patterns.Adapter.Interfaces;
using Patterns.Adapter.Services;

namespace Patterns.Adapter.Adapters
{
    public class JsonDataServiceAdapter : XMLDataService, IJsonDataService
    {
        public new void Process(string json)
        {
            XNode node = JsonConvert.DeserializeXNode(json, "Root");

            base.Process(node.ToString());
        }
    }
}
