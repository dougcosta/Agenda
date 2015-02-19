using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Agenda.Data;
using Agenda.Repositories;
using Agenda.Entities;
using System.Data.Entity;
using Agenda.Interfaces.Repositories;

namespace Agenda.Tests.Repositories
{
    [TestClass]
    public class AppointmentRepositoryTest
    {
        [TestMethod]
        public void Should_change_appointment()
        {
            var appointment = new Appointment();

            var appointmentsDbMoq = new Mock<DbSet<Appointment>>();

            var contextMoq = new Mock<AgendaContext>();
            contextMoq
                .Setup(s => s.Appointments)
                .Returns(appointmentsDbMoq.Object);

            var factoryMoq = new Mock<IContextFactory>();
            factoryMoq
                .Setup(s => s.Create())
                .Returns(contextMoq.Object);

            var repository = new AppointmentRepository(factoryMoq.Object);

            repository.Save(appointment);

            appointmentsDbMoq.Verify(v =>
                v.Add(appointment),
                Times.Once(),
                "The item was not changed");
        }

        [TestMethod]
        public void Should_save_changes()
        {
            var appointmentsDbMoq = new Mock<DbSet<Appointment>>();

            var contextMoq = new Mock<AgendaContext>();
            contextMoq
                .Setup(s => s.Appointments)
                .Returns(appointmentsDbMoq.Object);

            var factoryMoq = new Mock<IContextFactory>();
            factoryMoq
                .Setup(s => s.Create())
                .Returns(contextMoq.Object);

            var repository = new AppointmentRepository(factoryMoq.Object);

            var appointment = new Appointment();
            repository.Save(appointment);

            contextMoq.Verify(v =>
                v.SaveChanges(),
                Times.Once(),
                "The changes was not saved");
        }
    }
}
