namespace Recipe_app.Entities
{
    public class Ingredients
    {
        public int Id { get; set; }
        public int RecipesId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Recipes Recipes { get; set; }

    }
}
