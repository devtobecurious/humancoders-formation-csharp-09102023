using SdA.Game.Infrastructures.Interfaces;
using SdA.Game.Infrastructures.Settings;
using SdA.Game.Infrastructures.Settings.Exceptions;

namespace SdA.Tests.Settings.Services
{
    public class IGameSettingServiceUnitTest
    {
        [Fact]
        public void TestGetAllWillThrowWhenFilePathIsEmpty()
        {
            // Arrange
            // > Mock
            IGetGameSetting service = new XmlDeserializeGameSettingService("");

            // Act
            // > on lance la méthode

            Assert.Throws<DatabaseFilePathRequiredException>(
                () =>
                {
                    // Assert
                    // > on controle
                    var list = service.GetAll();
                }
            );


        }
    }
}