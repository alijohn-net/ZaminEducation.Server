﻿
using System.Linq.Expressions;
using ZaminEducation.Domain.Entities.Courses;
using ZaminEducation.Service.DTOs.Courses;

namespace ZaminEducation.Service.Interfaces
{
    public interface ICourseModuleService
    {
        ValueTask<CourseModule> CreateAsync(CourseModuleForCreationDto dto);
        ValueTask<CourseModule> UpdateAsync(Expression<Func<CourseModule, bool>> expression, CourseModuleForCreationDto dto);
        ValueTask<bool> DeleteAsync(Expression<Func<CourseModule, bool>> expression);
        Task<ICollection<CourseModule>> CreateRangeAsync(long courseId, IEnumerable<string> moduleNames);
        ValueTask<IEnumerable<CourseModule>> GetAllAsync(long courseId, Expression<Func<CourseModule, bool>> expression);
    }
}
