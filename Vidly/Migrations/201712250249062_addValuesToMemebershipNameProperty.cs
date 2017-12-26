namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addValuesToMemebershipNameProperty : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set MembershipTypes.Name = \'Pay As You Go\' Where MembershipTypes.id = 1 ");
            Sql("UPDATE MembershipTypes Set MembershipTypes.Name = \'Monthly\' Where MembershipTypes.id = 2 ");
            Sql("UPDATE MembershipTypes Set MembershipTypes.Name = \'Quarterly\' Where MembershipTypes.id = 3 ");
            Sql("UPDATE MembershipTypes Set MembershipTypes.Name = \'Yearly\' Where MembershipTypes.id = 4 ");
        }
        
        public override void Down()
        {
        }
    }
}
