﻿using FluentAssertions;
using System.Threading.Tasks;

namespace ZaminEducation.Test.Unit.Services.YouTubeCourse
{
    public partial class YoutubeServiceAndCourseServiceTest
    {
        [Fact]
        public async ValueTask ShouldDeleteCourseAndPlaylistById()
        {
            // given
            var dependencies = await CreateAllDependencies();

            // when
            var deletedPlayList = await youTubeService.DeleteRangeAsync(dependencies.CourseId);

            var deletedCourse = await courseService.DeleteAsync(c => c.Id == dependencies.CourseId);

            // then
            deletedCourse.Should().BeTrue();
            deletedPlayList.Should().BeTrue();
        }

        [Fact]
        public async ValueTask ShouldDeleteVideoById()
        {
            // given
            var dependencies = await CreateAllDependencies();

            // when
            var actualVideo = await youTubeService.CreateAsync("https://www.youtube.com/watch?v=JxjXechMs4c", dependencies.CourseId);

            var isDeleted = await youTubeService.DeleteAsync(actualVideo.Id);
            // then

            isDeleted.Should().BeTrue();
        }
    }
}
