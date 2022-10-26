using System.IO;
using System.Linq;
using Chaves.Data.Enums;
using Chaves.Service.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using File = System.IO.File;

namespace Chaves.Service.Helpers
{
    internal static class SwitchServicesSources
    {
        public static ServicesSources? Verify(SourcePath source)
        {
            try
            {
                var firstLine = File.ReadAllLines(source.Src).First();

                var jsonText = new JsonTextReader(File.OpenText(@"Jsons\ServiceColumnName.json"));
                var json = (JObject)JToken.ReadFrom(jsonText);

                if (firstLine.Equals(json["Google"].Value<string>()))
                    return ServicesSources.Google;
                else if (firstLine.Equals(json["Norton"].Value<string>()))
                    return ServicesSources.Norton;

            }
            catch (FileNotFoundException)
            {
                return null;
            }

            return null;
        }
    }
}
