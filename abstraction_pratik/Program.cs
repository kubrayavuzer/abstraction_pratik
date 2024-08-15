using abstraction_pratik;
class Program
{
    static void Main(string[] args)
    {
        //yazılım geliştirici nesnesi oluşturma

        YazilimGelistirici yazilimgelistirici = new YazilimGelistirici("ahmet", "mehmet", "yazılım");

        yazilimgelistirici.Gorev();

        //proje yöneticisi nesnesi oluşturma

        ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi("hasan", "hüseyin", "proje yöneticisi");
        projeYoneticisi.Gorev();

        //satış temsilcisi nesnesi oluşturma

        SatisDanismani satisDanismani = new SatisDanismani("ayşe", "hülya", "satış danışmanı");
        satisDanismani.Gorev();

    }

}

