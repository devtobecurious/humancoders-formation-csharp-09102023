using Microsoft.EntityFrameworkCore;
using SdA.Game.Infrastructures.Interfaces;
using SdA.Game.Settings.Models;

namespace SdA.Game.Infrastructures.Settings
{
    public class SqlServerEfCoreGameSettingService : IGetGameSetting
    {
        private readonly DbContext context;

        public SqlServerEfCoreGameSettingService(DbContext context)
        {
            this.context = context;
        }

        public IEnumerable<GameSetting> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
