namespace Recipe_management.Entities
{
    public class Recipes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeOnly Time { get; set; }

    }
}
