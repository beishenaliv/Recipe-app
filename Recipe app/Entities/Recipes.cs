namespace Recipe_app.Entities
{
    public class Recipes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Users Users { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public List<Instructions> Instructions { get; set; }
    }
}
