using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace EFAPIRelationships.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;

        [JsonIgnore]
        public Character Character { get; set; }
        public int CharacterId { get; set; }
    }
}
