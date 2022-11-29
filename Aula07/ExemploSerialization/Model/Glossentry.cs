namespace ExemploSerialization.Model
{
    public class Glossentry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public Glossdef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }


}
