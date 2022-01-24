using Microsoft.EntityFrameworkCore;
using Rovers.API.Domain.Models;

namespace Rovers.API.Domain.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Rover> Rovers { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rover>().HasData(new Rover
            { 
                RoverId = 1,
                Name = "Curiosity",
                NasaURL = "https://www.nasa.gov/mission_pages/msl/overview/index.html",
                History = "Curiosity är en obemannad motoriserad landfarkost (strövare) som sköts upp på uppdrag av NASA den 26 november 2011. Enligt plan landade strövaren på Mars vid kratern Gale den 5 augusti 2012 kl. 05:31 UTC. Strövaren är tre gånger så tung och dubbelt så bred som de tidigare Mars Exploration Rovers (MER) Spirit och Opportunity som landade på Mars 2004. Efter landningen har Curiosity analyserat ett flertal prover från marsjorden och från stenar. Strövaren förväntades vid uppskjutningen arbeta i minst ett marsår (cirka två jordår) och planerades att bli den strövare som täckte en större del av planetytan än någon tidigare strövare. Uppdraget var att undersöka Mars tidigare och dåvarande förmåga att hysa liv. Curiosity är 2020 fortfarande aktiv, vilket innebär att den har överlevt långt längre än vad man först trodde eller planerade för.",
                Weight = 900, //KG
                Cameras = 7
            });

            modelBuilder.Entity<Rover>().HasData(new Rover 
            { 
                RoverId = 2,
                Name = "Opportunity",
                NasaURL = "https://www.nasa.gov/mission_pages/mer/overview/index.html",
                History = "Opportunity, också känd som MER-B (Mars Exploration Rover – B) eller MER-1, med smeknamnet Oppy, var NASAs andra rymdsond i Mars-utforskningsprogrammet Mars Exploration Rover Mission. MER-B sköts iväg 8 juli 2003 och landade i området Meridiani planum på planeten Mars den 25 januari 2004. Den är tvillingfarkost till MER-A, Spirit.NASA förklarade den 13 februari 2019 uppdraget för avslutat då man inte sedan juni 2018 haft kontakt med farkosten. Detta efter att en större sandstorm dragit fram över området där den befann sig. Syftet med sonden var bland annat att utforska eventuell förekomst av vatten på planetens yta. Rymdsonden uppskattades kunna fungera i 90 dagar, men sonden fungerade i över femton år.",
                Weight = 180, //KG
                Cameras = 5
            });

            modelBuilder.Entity<Rover>().HasData(new Rover 
            { 
                RoverId = 3,
                Name = "Spirit",
                NasaURL = "https://www.nasa.gov/mission_pages/mer/overview/index.html",
                History = "Spirit, också känd som MER-A (Mars Exploration Rover – A) eller MER-2, var NASAs första sond i Marsutforskningsprogrammet Mars Exploration Rover Mission. Den sköts upp med en Delta II-raket från Cape Canaveral Air Force Station, den 10 juni 2003 och landade på Mars yta, den 3 januari 2004. Den är tvillingfarkost till MER-B, kallad Opportunity. Uppdraget var tänkt att pågå i 90 dagar, men tack vare att solcellerna då och då blåstes rena av starka vindar på Mars, överlevde Spirit i 2 269 dagar.Under sin tid på Mars tillryggalade den totalt 7,73 kilometer. Syftet med sonden var bland annat att utforska eventuell förekomst av vatten på planetens yta. Under Spirits frammars framkom det starka bevis för att Mars en gång har varit mycket våtare än vad den är idag.",
                Weight = 180, //KG
                Cameras = 5
            });
        }
    }
}