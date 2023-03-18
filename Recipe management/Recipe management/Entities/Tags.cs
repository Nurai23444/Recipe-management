namespace Recipe_management.Entities
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RecipeTags> ResipeTags { get; set }
    }
}
