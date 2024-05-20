namespace Lab15
{
    public class Aves:Animal
    {
        public string Vuela { get; set; }
        public string Incubacion { get; set; }

        public Aves() 
        {
            Vuela = string.Empty;
            Incubacion = string.Empty;
        }
    }
}
