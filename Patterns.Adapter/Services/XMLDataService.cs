using System;
using Patterns.Adapter.Interfaces;

namespace Patterns.Adapter.Services
{
    public class XMLDataService : IXMLDataService
    {
        public void Process(string xml)
        {
            var isValidXml = (!string.IsNullOrEmpty(xml) && xml.TrimStart().StartsWith("<"));

            if (!isValidXml)
                throw new NotSupportedException("Invalid xml");

            //perform an important process
        }
    }
}
