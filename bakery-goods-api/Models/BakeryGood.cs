namespace bakery_goods_api.Models {
    public class BakeryGood {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BakeryGood(int id, string name, string desc)
        {
            Id = id;
            Name = name;
            Description = desc;
        }
    }
}