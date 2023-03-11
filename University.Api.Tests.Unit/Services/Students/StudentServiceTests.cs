using FluentAssertions.Equivalency.Steps;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;
using University.Api.Brokers.Loggings;
using University.Api.Brokers.Storages;
using University.Api.Models.Student;
using University.Api.Services.Students;

namespace University.Api.Tests.Unit.Services.Students
{
    public partial class StudentServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly IStudentService studentService;

        public StudentServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();
            this.studentService = new StudentService(
                storageBroker: this.storageBrokerMock.Object,
                loggingBroker: this.loggingBrokerMock.Object);
        }

        private static DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();

        private static StudentModel CreateRandomStudent(DateTimeOffset dates) =>
            CreateStudentFiller(dates).Create();

        private static Filler<StudentModel> CreateStudentFiller(DateTimeOffset dates)
        {
            var filler = new Filler<StudentModel>();
            filler.Setup().OnType<DateTimeOffset>().Use(dates);

            return filler;
        }
    }
}