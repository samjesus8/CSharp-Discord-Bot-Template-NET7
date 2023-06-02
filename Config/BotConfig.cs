using Newtonsoft.Json;

namespace DiscordBotTemplateNet7.Config
{
    internal class BotConfig
    {
        public string Token { get; set; }
        public string Prefix { get; set; }

        public async Task ReadJSON()
        {
            using (StreamReader sr = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}/config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONStruct obj = JsonConvert.DeserializeObject<JSONStruct>(json);

                this.Token = obj.token;
                this.Prefix = obj.prefix;
            }
        }
    }

    internal sealed class JSONStruct
    {
        public string token { get; set; }
        public string prefix { get; set; }
    }
}
