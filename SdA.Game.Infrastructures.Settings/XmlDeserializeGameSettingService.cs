using SdA.Game.Infrastructures.Interfaces;
using SdA.Game.Infrastructures.Settings.Exceptions;
using SdA.Game.Settings.Models;
using System.Xml.Serialization;

namespace SdA.Game.Infrastructures.Settings
{
    public class XmlDeserializeGameSettingService : IGetGameSetting
    {
        private readonly XmlSerializer serializer;
        private readonly string filePath;

        public XmlDeserializeGameSettingService(string filePath)
        {
            this.serializer = new XmlSerializer(typeof(List<GameSetting>));
            this.filePath = filePath;
        }

        public IEnumerable<GameSetting> GetAll()
        {
            if (string.IsNullOrWhiteSpace(this.filePath))
            {
                throw new DatabaseFilePathRequiredException();
            }

            using var reader = new FileStream(Path.Combine(Environment.CurrentDirectory, this.filePath), FileMode.Open);
            var maList = this.serializer.Deserialize(reader) as List<GameSetting>;

            return maList;
        }
    }
}