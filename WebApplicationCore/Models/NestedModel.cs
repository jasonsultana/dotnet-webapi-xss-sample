namespace WebApplicationCore.Models
{
    public class NestedModel
    {
        public SimpleModel Inner { get; set; } = new SimpleModel();
    }
}