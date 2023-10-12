using System.ComponentModel.DataAnnotations.Schema;

namespace DiscoverEFCore
{
    internal class Elfe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public string Name { get; set; }
    }
}
