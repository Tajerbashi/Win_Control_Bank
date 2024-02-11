using Account.Common.Library.Utilities;

namespace Account.Infrastructure.Library.Services.BCK
{
    public sealed class BackupService
    {
        public BackupService()
        {
            
        }

        public string BackupDatabase(string path, string name, string DatabaseName)
        {
            return ($@"Backup DataBase {DatabaseName} TO DISK ='{path}\{name}_{DateTimeUtility.ToPersion(DateTime.Now)}.bak';");
        }
        public string RestoreDatabase(string path, string name, string DatabaseName)
        {
            return ($@"Backup DataBase {DatabaseName} TO DISK ='{path}\{name}_{DateTimeUtility.ToPersion(DateTime.Now)}.bak';");
        }
    }
}
