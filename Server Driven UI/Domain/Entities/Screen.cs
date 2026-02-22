using System.ComponentModel;

namespace Server_Driven_UI.Domain.Entities
{
    public class Screen
    {
        public string ScreenId { get; set; }
        public List<Component> Components { get; set; } = new();
    }

    public class Component
    {
        public string Type { get; set; }  
        public string? Value { get; set; }
        public string? Title { get; set; }
        public string? Action { get; set; }
        public int? Size { get; set; }
        public string? Color { get; set; }
        public string? FontFamily { get; set; }
        public string? Align { get; set; }
        public string? prefixIcon { get; set; }
        public string? suffixIcon { get; set; }
    }
}
