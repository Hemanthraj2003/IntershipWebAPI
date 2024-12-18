using System.ComponentModel.DataAnnotations;

namespace IntershipWebAPI.Model
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
