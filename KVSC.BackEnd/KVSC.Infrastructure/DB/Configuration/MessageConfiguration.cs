using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Domain.Entities;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData
            (
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    Content = "Chào bạn, bạn có khỏe không?",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    Content = "Mình cũng tốt, hôm nay bạn có rảnh không?",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Mình có chút thời gian, bạn cần gì không?",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    Content = "Mình muốn hỏi bạn về dự án mới.",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Chắc chắn rồi! Bạn cần biết gì?",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    Content = "Bạn có thông tin chi tiết về tiến độ không?",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Tôi sẽ gửi cho bạn một bản tóm tắt.",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    Content = "Cảm ơn bạn, tôi sẽ xem xét ngay.",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Không có gì, mình luôn sẵn lòng giúp đỡ.",
                    Timestamp = DateTime.Now
                }
            );
        }
    }
}
