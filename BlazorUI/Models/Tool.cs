namespace BlazorMyToolsMag33.Models
{
    public class Tool
    {
        public int Id { get; set; }

        public string ToolName { get; set; }

        public int ToolCategoryId { get; set; }

        public int PersonId { get; set; }

        public int PlaceId { get; set; }
        public string ToolCategoryName { get; set; }

        public string PersonName { get; set; }

        public string PlaceName { get; set; }
    }
}
