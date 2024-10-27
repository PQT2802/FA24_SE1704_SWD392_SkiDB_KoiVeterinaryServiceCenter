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
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Xin chào! Tôi là bác sĩ thú y, bạn cần tôi giúp gì về cá koi của bạn?",
                    Timestamp = DateTime.Now
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    Content = "Chào bác sĩ! Con koi của tôi có dấu hiệu lờ đờ và không ăn. Tôi rất lo lắng.",
                    Timestamp = DateTime.Now.AddMinutes(1)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Tôi hiểu. Bạn có thể cho tôi biết nhiệt độ nước và tình trạng nước trong hồ không?",
                    Timestamp = DateTime.Now.AddMinutes(2)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    Content = "Nhiệt độ nước là 20 độ C và nước có vẻ trong, nhưng tôi thấy một ít tảo xanh.",
                    Timestamp = DateTime.Now.AddMinutes(3)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Tảo có thể ảnh hưởng đến chất lượng nước. Tôi khuyên bạn nên kiểm tra pH và amoniac trong nước. Có thể sử dụng bộ thử nghiệm nước để làm điều này.",
                    Timestamp = DateTime.Now.AddMinutes(4)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    Content = "Cảm ơn bác sĩ! Tôi sẽ kiểm tra và liên lạc lại nếu cần thêm giúp đỡ.",
                    Timestamp = DateTime.Now.AddMinutes(5)
                }
            );
        }
    }
}
