namespace Lab15
{
    public class Serpientes:Animal
    {
        public string Veneno {  get; set; }
        public string Longitud { get; set; }

        public Serpientes()
        {
            Veneno = string.Empty;
            Longitud = string.Empty;
        }
    }
}
