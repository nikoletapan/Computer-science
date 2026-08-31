namespace test5
{
    // Creation of my student during exam

    abstract class MagicSnowflake
    {
        public string DesignName { get; set; }
        public int MagicPower { get; set; }
        public int CreationTime { get; set; }

        public static int TotalMagicPower = 0;

        protected MagicSnowflake(string designName, int magicPower, int creationTime)
        {
            DesignName = designName;
            MagicPower = magicPower;
            CreationTime = creationTime;
            TotalMagicPower += magicPower;
        }
        public abstract string GetSpell();
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Snowflake '{DesignName}' with magic power of {MagicPower}.");
        }
    }
    class CoveringSnowflake : MagicSnowflake
    {
        public double CoverageArea { get; set; }

        public CoveringSnowflake(string designName, int magicPower, int creationTime, double coverageArea) : base(designName, magicPower, creationTime)
        {
            CoverageArea = coverageArea;
        }
        public override string GetSpell()
        {
            return $"Covering {CoverageArea} m^2 with snow :DDD";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Covering: {CoverageArea} m^2");
        }
    }
    class GlowingSnowflake : MagicSnowflake
    {
        public string GlowColor { get; set; }

        public GlowingSnowflake(string designName, int magicPower, int creationTime, string glowColor)
            : base(designName, magicPower, creationTime)
        {
            GlowColor = glowColor;
        }
        public override string GetSpell()
        {
            return $"It's glowing with {GlowColor} colour at night :3";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Colour: {GlowColor}");
        }
    }
    class Program
    {
        static void Main()
        {
            List<MagicSnowflake> snowflakes = new List<MagicSnowflake>()
        {
            new CoveringSnowflake("Icy flakes", 80, 15, 120),
            new CoveringSnowflake("Snowy carpet", 65, 10, 90),
            new GlowingSnowflake("Night star", 95, 20, "blue"),
            new GlowingSnowflake("Moonlight", 70, 12, "white"),
            new GlowingSnowflake("Northern lights", 85, 18, "blue")
        };


            MagicSnowflake strongest = snowflakes
                .OrderByDescending(s => s.MagicPower)
                .First();

            Console.WriteLine(".*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*. Strongest snowflake .*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.");
            strongest.DisplayInfo();

            var covering = snowflakes.OfType<CoveringSnowflake>();
            double averageArea = covering.Any() ? covering.Average(s => s.CoverageArea) : 0;

            Console.WriteLine($"\nAverage area: {averageArea:F2} m^2");

            var blueGlowing = snowflakes
                .OfType<GlowingSnowflake>()
                .Where(s => s.GlowColor.ToLower() == "blue");

            Console.WriteLine("\nSnowflakes which glow in blue:");
            foreach (var snowflake in blueGlowing)
            {
                snowflake.DisplayInfo();
            }
            Console.WriteLine($"\nTotal magic power: {MagicSnowflake.TotalMagicPower}");
            Console.WriteLine("\n.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*. MARRY EARLY CHRISTMAS EVERYONE .*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.");
            Console.WriteLine(".*'*.*'*.*'*.*'*.*'*. I HOPE YOU RECEIEVE ALL THE PRESENTS YOU WISHED FOR THIS YEAR .*'*.*'*.*'*.*'*.*'*.*'*.*'*.*'*.");
            Console.WriteLine("              *                   *                   *");
            Console.WriteLine("             ***                 ***                 ***");
            Console.WriteLine("            *****               *****               *****");
            Console.WriteLine("           *******             *******             *******");
            Console.WriteLine("          *********           *********           *********");
            Console.WriteLine("         ***********         ***********         ***********");
            Console.WriteLine("        *************       *************       *************");
            Console.WriteLine("       ***************     ***************     ***************");
            Console.WriteLine("      *****************   *****************   *****************");
            Console.WriteLine("             ****               ****                ****");
            Console.WriteLine("             ****               ****                ****");
        }
    }
}
