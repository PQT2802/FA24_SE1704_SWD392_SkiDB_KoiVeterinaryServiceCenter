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
                    Content = "Hello, how are you?",
                    Timestamp = DateTime.Now
                },
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "I'm good, thank you! How about you?",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    Content = "I'm good too. Are you free today?",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "I have some time, do you need anything?",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    Content = "I want to ask you about the new project.",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "Sure! What do you need to know?",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    Content = "Do you have detailed information about the progress?",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "I’ll send you a summary.",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    Content = "Thank you, I’ll review it right away.",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "You're welcome, always happy to help.",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "Hello! I’m the veterinarian. How can I assist with your koi fish?",
    Timestamp = DateTime.Now
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
    Content = "Hi, Doctor! My koi fish seems sluggish and isn’t eating. I’m really worried.",
    Timestamp = DateTime.Now.AddMinutes(1)
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "I see. Can you tell me the water temperature and the condition of the water?",
    Timestamp = DateTime.Now.AddMinutes(2)
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
    Content = "The water temperature is 20°C, and the water seems clear, but I noticed a bit of green algae.",
    Timestamp = DateTime.Now.AddMinutes(3)
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    Content = "Algae can affect water quality. I recommend checking the pH and ammonia levels. You can use a water testing kit for this.",
    Timestamp = DateTime.Now.AddMinutes(4)
},
new Message
{
    Id = Guid.NewGuid(),
    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
    Content = "Thank you, Doctor! I’ll check and get back if I need more help.",
    Timestamp = DateTime.Now.AddMinutes(5)
}
            );
        }
    }
}
