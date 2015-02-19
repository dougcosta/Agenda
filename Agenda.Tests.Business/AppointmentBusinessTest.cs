using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agenda.Interfaces.Repositories;
using Moq;
using Agenda.Business;
using Agenda.Entities;

namespace Agenda.Tests.Business
{
    [TestClass]
    public class AppointmentBusinessTest
    {
        [TestMethod]
        public void Should_save_appointment()
        {
            var repositoryMoq = new Mock<ISaveRespository>();

            var business = new AppointmentBusiness(repositoryMoq.Object);

            var appointment = new Appointment();
            business.Save(appointment);

            repositoryMoq
                .Verify(v => v.Save(appointment), Times.Once(),
                "The item was not saved");
        }
    }
}
