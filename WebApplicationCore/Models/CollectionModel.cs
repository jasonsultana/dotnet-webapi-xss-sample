using System;

namespace WebApplicationCore.Models
{
    public class CollectionModel
    {
        public SimpleModel[] Children { get; set; } = Array.Empty<SimpleModel>();
    }
}