

namespace DtoLayer.Dtos.FeatureDtos
{
    public class UpdateEngagementDto
    {
        public  int FeatureId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public int MembershipId { get; set; }
    }
}