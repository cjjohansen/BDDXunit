using System;
using AutoFixture;
using FluentAssertions;
using NodaTime;
using Scheduling.Domain;
using Xunit;
using Xunit.Abstractions;

namespace BDDXUnit.Tests
{
    public class ShiftFeatures
    {
        private readonly ITestOutputHelper _testOutput;

        public ShiftFeatures( ITestOutputHelper testOutput )
        {
            _testOutput = testOutput;
        }
       

        /// <summary>
        /// Can force autofixture to use fixed value valueobjects. by using Register
        /// </summary>
        [ Fact]
        public void can_approve_shift()
        {

            var shiftId1 = new ShiftId( 19 );
            var localDate1 = new LocalDate( 2018, 3, 21 );

            var shiftId2 = new ShiftId( 20 );
            var localDate2 = new LocalDate( 2018, 3, 22 );

            var fixture = new Fixture();
          
            fixture.Register(()=> shiftId1);
            fixture.Register(()=> localDate1);
            var shift = fixture.Create<Shift>();
           
            fixture.Register( () => shiftId2 );
            fixture.Register(() => localDate2);
            var shift2 = fixture.Create<Shift>();

            shift.Id.Should().Be(shiftId1);
            shift.OpeningDate.Should().Be( localDate1 );
            shift2.Id.Should().Be( shiftId2 );
            shift2.OpeningDate.Should().Be( localDate2 );
        }
    }
}
