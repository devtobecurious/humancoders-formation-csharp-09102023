using DiscoverSerialisation;
using System.Xml.Serialization;

List<GameSetting> settings = new List<GameSetting>()
{
    new() { NbCols = 1, NbRows = 1 }
};

XmlSerializer serialiser = new XmlSerializer(typeof(List<GameSetting>));
using var writer = new FileStream(Path.Combine(Environment.CurrentDirectory, "messettings.xml"), FileMode.OpenOrCreate);
serialiser.Serialize(writer, settings);

using var reader = new FileStream(Path.Combine(Environment.CurrentDirectory, "messettings.xml"), FileMode.Open);
var maList = serialiser.Deserialize(reader) as List<GameSetting>;
