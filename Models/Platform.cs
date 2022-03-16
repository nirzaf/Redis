namespace CacheService.Models
{
    public class Platform
    {
        [Required]
        public string Id { get; set; } = $"platform:{Guid.NewGuid()}";
        
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}