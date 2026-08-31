namespace exam_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Decoration> decorations = new List<Decoration>();
            decorations.Add(new TableDecoration("свещи", "червен", 12, "елф"));
            decorations.Add(new TableDecoration("салфетка", "златен", 18, "специален гост"));
            decorations.Add(new TreeDecoration("топка", "зелен", 5, 75));
            decorations.Add(new TreeDecoration("звезда", "жълт", 9, 199));
            Decoration maxTimeDecoration = decorations.MaxBy(d => d.SetupTime);
            Console.WriteLine("Украса с най-дълго време за подреждане:");
            maxTimeDecoration.DisplayInfo();
            int minHeight = decorations.OfType<TreeDecoration>().Min(t => t.HangingHeight);
            Console.WriteLine($"Най-ниска височина на окачване: {minHeight} см");
            List<TableDecoration> specialGuestDecorations = decorations.OfType<TableDecoration>().Where(t => t.PlaceSetting == "специален гост").ToList();
            Console.WriteLine("Украси за масата за специален гост:");
            foreach (var а in specialGuestDecorations)
            {
                а.DisplayInfo();
            }
            Console.WriteLine($"Общо време за подреждане: {Decoration.TotalSetupTime} мин");
        }
    }
    public abstract class Decoration
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int SetupTime { get; set; }
        public static int TotalSetupTime = 0;
        protected Decoration(string name, string color, int setupTime)
        {
            Name = name;
            Color = color;
            SetupTime = setupTime;
            TotalSetupTime += setupTime;
        }
        public abstract string GetPlacementInstruction();
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Украса {Name} в цвят {Color}.");
        }
    }
    class TableDecoration : Decoration
    {
        public string PlaceSetting { get; set; }
        public TableDecoration(string name, string color, int setupTime, string placeSetting) : base(name, color, setupTime)
        {
            PlaceSetting = placeSetting;
        }
        public override string GetPlacementInstruction()
        {
            return $"Поставете на масaта за {PlaceSetting}.";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"За: {PlaceSetting}");
        }
    }
    class TreeDecoration : Decoration
    {
        public int HangingHeight { get; set; }
        public TreeDecoration(string name, string color, int setupTime, int hangingHeight) : base(name, color, setupTime)
        {
            HangingHeight = hangingHeight;
        }
        public override string GetPlacementInstruction()
        {
            return $"Окачете на височина: {HangingHeight} см.";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Височина: {HangingHeight} см.");
        }
    }

}
