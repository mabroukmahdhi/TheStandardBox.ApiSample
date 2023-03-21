using TheStandardBox.Data.Tests.Unit.Services.Foundations.Standards;
using TSB.Sample.Models.Engineers;

namespace TSB.Sample.Tests.Unit.Services.Engineers
{
    public class EngineerServiceTests : StandardServiceTests<Engineer>
    {
        //protected override InvalidEntityException CreateInvalidEntityExceptionOnAdd()
        //{
        //    var invalidEngineerException =
        //        base.CreateInvalidEntityExceptionOnAdd();

        //    invalidEngineerException.AddData(nameof(Engineer.Name), "Text is required");

        //    return invalidEngineerException;
        //}
    }
}