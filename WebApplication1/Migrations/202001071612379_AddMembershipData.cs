namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MEMBERSHIPTYPES(Id,Name,DurationInMonths,SignUpFree,DiscountRate) values(1,'Pay As You Go',0,0,0)");
            Sql("INSERT INTO MEMBERSHIPTYPES(Id,Name,DurationInMonths,SignUpFree,DiscountRate) values(2,'Monthly',30,1,10)");
            Sql("INSERT INTO MEMBERSHIPTYPES(Id,Name,DurationInMonths,SignUpFree,DiscountRate) values(3,'Quarterly',90,3,15)");
            Sql("INSERT INTO MEMBERSHIPTYPES(Id,Name,DurationInMonths,SignUpFree,DiscountRate) values(4,'Annual',200,12,20)");

        }

        public override void Down()
        {
        }
    }
}
