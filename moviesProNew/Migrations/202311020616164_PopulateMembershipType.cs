namespace moviesProNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipType (Id, SignUpFee, DurationInMonths, Discountrate) Values (1, 100, 2, 10)");
            Sql("Insert Into MembershipType (Id, SignUpFee, DurationInMonths, Discountrate) Values (2, 99, 2, 10)");
        }

        public override void Down()
        {
        }
    }
}
