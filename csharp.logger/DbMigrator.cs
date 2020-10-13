using System;

namespace csharp.logger {
    public class DbMigrator {
        private readonly IILogger _logger;

        public DbMigrator(IILogger logger) {
            _logger = logger;
        }

        public void Migrate() {
            _logger.LogInfo($"Migration started at {DateTime.Now}");
            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}
