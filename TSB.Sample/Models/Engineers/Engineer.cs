using System;
using TheStandardBox.Core.Attributes.Contollers;
using TheStandardBox.Core.Models.Controllers;
using TheStandardBox.Core.Models.Foundations.Standards;

namespace TSB.Sample.Models.Engineers
{
    [GeneratedController("api/engineers")]
    //[GeneratedController("api/engineers", 
    //    allowedActions: new AllowedAction[] { AllowedAction.GetAllEntities })]
    public class Engineer : IStandardEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}