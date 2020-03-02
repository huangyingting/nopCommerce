using FluentMigrator;
using Nop.Data.Migrations;
using Nop.Plugin.Tax.FixedOrByCountryStateZip.Domain;

namespace Nop.Plugin.Shipping.FixedByWeightByTotal.Data
{
    [NopMigration("2020/02/03 09:27:23:6455432")]
    [Tags(NopMigrationTags.Schema)]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            _migrationManager.BuildTable<TaxRate>(Create);
        }
    }
}