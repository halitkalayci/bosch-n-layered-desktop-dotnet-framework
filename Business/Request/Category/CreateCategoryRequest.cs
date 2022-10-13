using Core.Entities;

namespace Business.Request
{
    public class CreateCategoryRequest : IValidatableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
