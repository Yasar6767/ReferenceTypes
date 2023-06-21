using System;

namespace ReferenceTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Magaza magaza1 = new Magaza();
            Magaza magaza2 = new Magaza();

            magaza1.Name = "Boyner";
            magaza1 = magaza2;

            Gıyım gıyım = new Gıyım();
            gıyım.Mont = "DeriMont";
            gıyım.Pantolon = "Mavi";
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.Spor = "Adidas";
            ayakkabi.Name = "Akatlar";
            Kozmetik  kozmetik = new Kozmetik();
            kozmetik.Ruj = "Avon Mat Ruj";
            kozmetik.Krem = "Nıvea";

            Magaza magaza3 = kozmetik;
            magaza3.Name = "JackJones";


            Console.WriteLine(((Kozmetik)magaza3).Krem);

            MagazaManager magazaManager = new MagazaManager();

            magazaManager.Add(kozmetik);
            magazaManager.Add(ayakkabi);
        }

    }
    class Magaza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amblem { get; set; }
    }
    class Gıyım:Magaza
    {
        public string Pantolon { get; set; }
        public string TShirt {get; set; }
        public string Gomlek { get; set; }
        public string Mont { get; set; }


    }

    class Ayakkabi:Magaza
    {
        public string Spor { get; set; }
        public string Klasik { get; set; }
        public string Ortepedik { get; set; }
    }

    class Kozmetik:Magaza
    {
        public string Krem { get; set; }
        public string Ruj { get; set; }
        public string Deodorant { get; set; }
    }

    class MagazaManager 
    {
        public void Add(Magaza magaza) 
        {
            Console.WriteLine(magaza.Name);
        }
    }
}
