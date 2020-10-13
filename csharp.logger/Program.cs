using System;

namespace csharp.logger {
    class Program {
        static void Main(string[] args) {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }
}
