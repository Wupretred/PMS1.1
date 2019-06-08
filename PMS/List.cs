namespace PMS
{
    public class List
    {
        public List(string name, string attr)
        {
            this.name = name;
            this.attr = attr;
        }

        public string name { set; get; }
        public string attr { set; get; }
    }
}