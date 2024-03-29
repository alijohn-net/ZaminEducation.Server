﻿using System.Linq.Expressions;
using ZaminEducation.Domain.Entities.Commons;
using ZaminEducation.Service.DTOs.Commons;

namespace ZaminEducation.Service.Interfaces;

public interface IAttachmentService
{
    ValueTask<Attachment> UploadAsync(AttachmentForCreationDto dto);
    ValueTask<Attachment> UpdateAsync(long id, Stream stream);
    ValueTask<bool> DeleteAsync(Expression<Func<Attachment, bool>> expression);
    ValueTask<Attachment> GetAsync(Expression<Func<Attachment, bool>> expression);
    ValueTask<Attachment> CreateAsync(string fileName, string filePath);
}
