﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
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

                //vet2 vs cus1 vao truoc hom nay 1 ngay 
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Hello! I’m the veterinarian. How can I assist with your koi fish?",
                    Timestamp = DateTime.UtcNow.AddDays(-1)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    Content = "Hi, Doctor! My koi fish seems sluggish and isn’t eating. I’m really worried.",
                    Timestamp = DateTime.UtcNow.AddDays(-1).AddMinutes(1)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "I see. Can you tell me the water temperature and the condition of the water?",
                    Timestamp = DateTime.UtcNow.AddDays(-1).AddMinutes(2)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    Content = "The water temperature is 20°C, and the water seems clear, but I noticed a bit of green algae.",
                    Timestamp = DateTime.UtcNow.AddDays(-1).AddMinutes(3)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Content = "Algae can affect water quality. I recommend checking the pH and ammonia levels. You can use a water testing kit for this.",
                    Timestamp = DateTime.UtcNow.AddDays(-1).AddMinutes(4)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    RecipientId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    Content = "Thank you, Doctor! I’ll check and get back if I need more help.",
                    Timestamp = DateTime.UtcNow.AddDays(-1).AddMinutes(5)
                },
                //==============cuoc hoi thoai của cus3 và vet1 vao ngay 30/10=============================

                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                    RecipientId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer
                    Content = "Hello! I am a veterinarian specializing in Koi fish. What can I assist you with today?",
                    Timestamp = DateTime.UtcNow.AddDays(-2).AddMinutes(1) // 09:00 AM
                },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer
                     RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     Content = "Hi, Doctor! I would like to ask about the diet for my Koi fish. They seem to be picky eaters.",
                     Timestamp = DateTime.UtcNow.AddDays(-2).AddMinutes(2)// 09:05 AM
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer
                     Content = "It could be due to poor water conditions or unsuitable food. Could you let me know the water temperature and what type of food you are using?",
                     Timestamp = DateTime.UtcNow.AddDays(-2).AddMinutes(3) // 09:10 AM
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer
                     RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     Content = "The water temperature is 24 degrees Celsius, and I'm feeding them XYZ brand pellets.",
                     Timestamp = DateTime.UtcNow.AddDays(-2).AddMinutes(4) // 09:15 AM
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer
                     Content = "The temperature is fine, but you might want to try switching to a different food, like ABC, to see if they respond better.",
                     Timestamp = DateTime.UtcNow.AddDays(-2).AddMinutes(5) // 09:20 AM
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer
                     RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     Content = "Thank you, Doctor! I will try changing the food. Hopefully, they will eat better.",
                     Timestamp = DateTime.UtcNow.AddDays(-2).AddMinutes(6) // 09:25 AM
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer
                     Content = "You're welcome! If you have any more questions, feel free to ask.",
                     Timestamp = DateTime.UtcNow.AddDays(-2).AddMinutes(7) // 09:30 AM
                 },
                 //vet1 cus 1 3ngay trc
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     Content = "Hello! I’m Dr. Smith, the veterinarian. I see you have an appointment regarding your Koi fish. How can I assist you today?",
                     Timestamp = DateTime.UtcNow.AddDays(-3)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     Content = "Hello, doctor! My Koi fish has been acting strange lately, staying at the bottom of the tank and losing color.",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(5)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     Content = "I see. Those can be signs of stress or possibly an infection. Have you noticed any other symptoms, such as loss of appetite or unusual swimming behavior?",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(10)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     Content = "Yes, actually! It hasn’t been eating as much as it used to, and sometimes it seems to swim sideways.",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(15)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     Content = "That sounds concerning. Reduced appetite and unusual swimming can indicate a range of issues, from water quality problems to internal infections.",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(20)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     Content = "Could it be something with the tank setup? I haven’t changed anything, though.",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(25)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     Content = "It’s possible. Even minor changes in water temperature or pH can stress Koi. I’d suggest we test the water, and I can also examine your fish for any signs of disease.",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(30)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     RecipientId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     Content = "Thank you, doctor. I’ll bring in a water sample as well. Hopefully, we can find what’s wrong.",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(35)
                 },
                 new Message
                 {
                     Id = Guid.NewGuid(),
                     SenderId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Veterinarian
                     RecipientId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer
                     Content = "Sounds good. Don’t worry, we’ll do everything we can to help your Koi recover.",
                     Timestamp = DateTime.UtcNow.AddDays(-3).AddMinutes(40)
                 }
            );
        }
    }
}
