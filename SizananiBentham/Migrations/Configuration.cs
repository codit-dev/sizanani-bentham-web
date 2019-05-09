namespace SizananiBentham.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SizananiBentham.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(SizananiBentham.Models.ApplicationDbContext context)
        {
            #region Add Articles
            context.Articles.AddOrUpdate(
                new Article
                {
                    Id = new Guid("a5cb55e6-07dd-42c4-ab6c-ca59e4e3aa66"),
                    Title = "Medical malpractice in South Africa on the rise",
                    Author = "CNBC Africa",
                    PublishDate = DateTime.ParseExact("15/mar/2016 00:00", "d/MMM/yyyy HH:mm", CultureInfo.InvariantCulture),
                    Body = "<p>Patients are more aware of their rights and that’s why there’s a significant increase in malpractice cases in the health sector and exponential increase in the cost of indemnity insurance for private specialists.</p>          <p>Earlier this month South Africa’s Health Minister Aaron Motsoaledi demanded that health officials at hospitals throughout the country inform the department of any mistakes that could cause harm to patients, to avoid litigation.</p>             <p>“If you look at the figures, it differs from place to place but generally they say that litigation has increased by about 25 per cent per year over the last five years so there definitely is an explosion if you could call it that,” said Johann Roux, an Attorney and leads the Personal Injury Department at De Broglio Attorneys.</p>                         <p>Roux reckons that patients are predominantly more aware of their rights these days compared to before.</p>                     <p>“These days they say ‘that shouldn’t have happened, that is not what was expected’, people are becoming more aware of their rights and another thing I think is lacking in our country which also leads to an escalation in litigation is that we don’t have a proper complaints procedure for patients,” said Roux.</p>                     <p>In 2014 the cost of indemnity insurance for private specialists in neurosurgery had increased by 573 per cent in a period of eight years.</p>                 <p>Last year Minister Motsoaledi put a plan on the table to limit pay-outs to victims of medical malpractice, which meant that instead of a lump sum, the minister wants them to be paid in instalments.</p>                   <p>The reforms would be in an effort to put a cap on the millions of rands the country pays to cases of negligence and would require changes to the law.</p>                     <p>Last year the provision for medical malpractice lawsuits breached 25 billion rand, aside from this, the health department has consistently recorded one of the poorest audit records of all auditor - general state departments.</p>                   <p>“I have heard some rumours of them[government] wanting to place caps on claim and so on and I would be very against that, if you see the patients that we deal with, the majority of the money that we get for compensation is to give them future medical treatment,” said Roux.</p>                 <p>He adds: “If you place caps on that, how do you go to a very poor indigent client and say, ‘listen your child needs physiotherapy and occupational therapy for the rest of their life but there’s a cap so here’s 24 000 rand to last you for the next year and leave them destitute basically”.</p>                <p>Roux also says that some of the private hospitals are now importing nurses from countries like India because they cannot fill the positions and aside from that, because of the red tape in the country, visa regulation and registration with the HPCSA highly skilled practitioners he knows around the world can’t come in the country to help despite how much they want to.</p>",
                    CommentsEnabled = false,
                    ImageFilePath = "/Content/images/article-media/2016/3/15/a5cb55e6-07dd-42c4-ab6c-ca59e4e3aa66/a5cb55e6-07dd-42c4-ab6c-ca59e4e3aa66.jpg"
                }
            );
            #endregion

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
