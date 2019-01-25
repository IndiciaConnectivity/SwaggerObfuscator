using System;

namespace ObfuscateSwagger
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    class Program
    {
        private const string file = "v1.json";
        static void Main(string[] args)
        {
            JObject deserializeObject = (JObject) JsonConvert.DeserializeObject(System.IO.File.ReadAllText(file));

            var paths = deserializeObject["paths"];
            for (int i = 0; i < paths.Count(); i++)
            {
                var path = paths.ElementAt(i);
                JProperty prop = path as JProperty;
                path.Rename(Helpers.RandomString());

                var children = path.Children();
                for (int j = 0; j < children.Count(); j++)
                {
                    var httpMethod = children.ElementAt(j);
                    var token = httpMethod["operationId"] as JToken;
                    token.Rename(Helpers.RandomString());
                }

            }

            var serialize = JsonConvert.SerializeObject(deserializeObject, Formatting.Indented);
        }
    }



    public static class Helpers
    {
        private readonly static Random random = new Random(123);
        private const string AllLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";

        public static string RandomString(int length = 12)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var index = random.Next(AllLetters.Length);
                sb.Append(AllLetters[index]);
            }

            return sb.ToString();
        }
        public static void Rename(this JToken token, string newName)
        {
            if (token == null)
                throw new ArgumentNullException("token", "Cannot rename a null token");

            JProperty property;

            if (token.Type == JTokenType.Property)
            {
                if (token.Parent == null)
                    throw new InvalidOperationException("Cannot rename a property with no parent");

                property = (JProperty)token;
            }
            else
            {
                if (token.Parent == null || token.Parent.Type != JTokenType.Property)
                    throw new InvalidOperationException("This token's parent is not a JProperty; cannot rename");

                property = (JProperty)token.Parent;
            }

            var newProperty = new JProperty(newName, property.Value);
            property.Replace(newProperty);
        }
    }
}