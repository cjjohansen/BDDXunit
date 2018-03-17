using System.Reflection;
using AutoFixture.Kernel;
using Scheduling.Domain;

namespace xBehave.Tests
{
    public class ShiftIdArg : ISpecimenBuilder
    {
        private readonly ShiftId value;

        public ShiftIdArg(ShiftId value)
        {
            this.value = value;
        }

        public object Create(object request, ISpecimenContext context)
        {
            if (!(request is ParameterInfo pi))
                return new NoSpecimen();

            if (pi.Member.DeclaringType != typeof(Shift) ||
                pi.ParameterType != typeof(ShiftId))
                return new NoSpecimen();

            return value;
        }
    }
}