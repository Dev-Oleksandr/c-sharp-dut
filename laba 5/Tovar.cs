namespace firstProject
{
    public class Tovar
    {
        private string _name;
        private string _type;
        private string _description;
        private double _price;

        public string Name => _name;
        public string Type => _type;
        public string Description => _description;
        public double Price => _price;

        public Tovar(string name, string type, string description, double price)
        {
            _name = name;
            _type = type;
            _description = description;
            _price = price;
        }
    }
}