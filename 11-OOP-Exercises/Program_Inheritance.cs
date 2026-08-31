namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop l1 = new Laptop("Asus", 5);
            l1.TurnOn();
            l1.ShowBattery();

            SmartPhone s1 = new SmartPhone("X MP", 12000);
            s1.TurnOn();
            s1.TakePhoto();
        }
    }
    class Device
    {
        public string Brand { get; set; }

        public Device(string brand)
        {
            Brand = brand;
        }
        public void TurnOn()
        {
            Console.WriteLine("Устройството е включено");
        }
    }
    class Laptop : Device
    {
        public int BatteryLife { get; set; }
        public Laptop(string brand, int batteryLife) : base(brand)
        {
            BatteryLife = batteryLife;
        }
        public void ShowBattery()
        {
            Console.WriteLine($"Животът на батерията е {BatteryLife} часа");
        }
    }
    class SmartPhone : Device
    {
        public int CameraMegaPixels {  get; set; }
        public SmartPhone(string brand, int cameraMegaPixels) : base(brand)
        {
            CameraMegaPixels = cameraMegaPixels;
        }

        public void TakePhoto()
        {
            Console.WriteLine($"Снимката е направена с {Brand}");
        }
    }
}
