using System.Reflection;
using AutoFixture.Kernel;
using NodaTime;
using Scheduling.Domain;

namespace xBehave.Tests
{
    public class LocalDateArg : ISpecimenBuilder
    {
        private readonly LocalDate value;

        public LocalDateArg( LocalDate value )
        {
            this.value = value;
        }

        public object Create( object request, ISpecimenContext context )
        {
            if ( !( request is ParameterInfo pi ) )
                return new NoSpecimen();

            if ( pi.Member.DeclaringType != typeof( Shift ) ||
                 pi.ParameterType != typeof( LocalDate ) )
                return new NoSpecimen();

            return value;
        }
    }
}