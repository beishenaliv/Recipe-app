namespace Recipe_app.Entities
{
    public class Instructions
    {
        public int Id { get; set; }
        public int RecipesId { get; set; }
        public int StepNumber { get; set; }
        public string Description { get; set; }
        public Recipes Recipes { get; set; }

    }
}
