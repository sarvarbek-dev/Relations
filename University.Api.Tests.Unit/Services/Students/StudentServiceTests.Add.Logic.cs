using FluentAssertions;
using Force.DeepCloner;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Api.Models.Student;
using Xunit;

namespace University.Api.Tests.Unit.Services.Students
{
    public partial class StudentServiceTests
    {
        [Fact]

        public async Task ShouldAddStudentAsync()
        {
            //given
            DateTimeOffset randomDateTime = GetRandomDateTime();
            StudentModel randomStudent = CreateRandomStudent(randomDateTime);
            StudentModel inputStudent = randomStudent;
            StudentModel storageStudent = inputStudent;
            StudentModel expectedStudent = storageStudent.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertStudentAsync(inputStudent)).ReturnsAsync(storageStudent);

            //when
            StudentModel actualStudent = await this.studentService.AddStudentAsync(inputStudent);

            //then
            actualStudent.Should().BeEquivalentTo(expectedStudent);

            this.storageBrokerMock.Verify(broker => 
                broker.InsertStudentAsync(inputStudent), Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
        }
    }
}
