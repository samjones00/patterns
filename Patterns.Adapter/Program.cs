using Patterns.Adapter.Adapters;

namespace Patterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = "{\"name\":\"sam\"}";

            var adapter = new JsonDataServiceAdapter();
            adapter.Process(data);
        }
    }
}
