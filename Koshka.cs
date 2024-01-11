namespace New_Project
{
    public class Koshka<TPoroda> where TPoroda : Poroda
    {
        public TPoroda Poroda { get; set; }
        public Koshka(TPoroda poroda)
        {
            this.Poroda = poroda;
        }
    }
}