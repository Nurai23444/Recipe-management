namespace Recipe_management.Entities
{
    public class ReceipeTag
    {
        public int Id { get; set; }
        public Recipes Recipe { get; set; }
        public Tags Tags { get; set; }
        public int RecipeId { get; set; }
        public int TagsId { get; set; }
    }
}
