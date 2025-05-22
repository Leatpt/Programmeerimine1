using KooliProjekt.Services;
using KooliProjekt.Controllers;
using Xunit;
using Moq;
using KooliProjekt.Data;
using Microsoft.AspNetCore.Mvc;
using KooliProjekt.Models;

namespace KooliProjekt.UnitTests.ControllerTests
{
    public class EventsControllerTests
    {
        private readonly Mock<IEventService> _eventServiceMock;
        private readonly EventsController _controller;

        public EventsControllerTests()
        {
            _eventServiceMock = new Mock<IEventService>();
            _controller = new EventsController(_eventServiceMock.Object);
        }

        [Fact]
        public async Task Index_should_return_view_and_data()
        {
            // Arrange
            var page = 1;
            var expectedEvents = new List<Event>
            {
                new() {Id = 1, Name = "Test Event 1"},
                new() {Id = 1, Name = "Test Event 1"}
            };
            var pagedResult = new PagedResult<Event> 
            { 
                Results = expectedEvents,
                CurrentPage = 1,
                PageCount = 1,
                PageSize = 5,
                RowCount = 2,
            };

            _eventServiceMock
                .Setup(x => x.List(page, It.IsAny<int>(), null))
                .ReturnsAsync(pagedResult);
            // Act
            var result = await _controller.Index(page) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.True(result.ViewName == "Index" ||
                        string.IsNullOrEmpty(result.ViewName));
            var model = Assert.IsType<EventIndexModel>(result.Model);
            Assert.Equal(pagedResult, model.Data);

        }
    }
}
