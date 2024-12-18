using System.ComponentModel.DataAnnotations;

namespace IntershipWebAPI.Model
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
