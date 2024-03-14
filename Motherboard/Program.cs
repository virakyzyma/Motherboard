namespace Motherboard
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Processor processor = new Processor() { Cores = 5, HHz = 4f };
                Videocard videocard = new Videocard() { Size = 2 };
                RAM ram = new RAM() { Size = 16 };
                HDD hdd = new HDD() { Size = 1 };
                Motherboard motherboard = new Motherboard(processor, ram, hdd, videocard);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
        public class Motherboard
        {
            public Motherboard(Processor processor, RAM ram, HDD hdd, Videocard videocard)
            {
                this.processor = processor;
                this.ram = ram;
                this.hdd = hdd;
                this.videocard = videocard;
            }
            private Processor processor;
            public Processor Processor
            {
                get => processor;
                set => processor = value;
            }
            private RAM ram;
            public RAM RAM
            {
                get => ram;
                set => ram = value;
            }
            private HDD hdd;
            public HDD HDD
            {
                get => hdd;
                set => hdd = value;
            }
            private Videocard videocard;
            public Videocard Videocard
            {
                get => videocard;
                set => videocard = value;
            }
        }
        public class Processor
        {
            private float hhz;
            public float HHz
            {
                get => hhz;
                set => hhz = value >= 1 && value <= 4 ? value : throw new Exception("Invalid processor clock speed");
            }
            private int cores;
            public int Cores
            {
                get => cores;
                set => cores = value >= 1 && value <= 10 ? value : throw new Exception("Invalid number of cores");
            }
        }
        public class RAM
        {
            private int size;
            public int Size
            {
                get => size;
                set => size = value >= 1 && value <= 140 ? value : throw new Exception("Invalid RAM value");
            }
        }
        public class HDD
        {
            private int size;
            public int Size
            {
                get => size;
                set => size = value >= 100 && value <= 13_000 ? value : throw new Exception("Invalid hard drive size value");
            }
        }
        public class Videocard
        {
            private int size;
            public int Size
            {
                get => size;
                set => size = value >= 1 && value <= 20 ? value : throw new Exception("Invalid video memory size");
            }
        }
    }
}