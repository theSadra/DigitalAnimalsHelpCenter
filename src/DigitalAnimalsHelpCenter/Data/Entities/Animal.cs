using System.ComponentModel.DataAnnotations;

namespace DigitalAnimalsHelpCenter.Data.Entities
{
    public class Animal
    {
        [Key]
        public Guid GUID { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

    }
}
