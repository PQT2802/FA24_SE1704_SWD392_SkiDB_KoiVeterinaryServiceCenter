USE [KoiCenterDB]
GO
/*==========================================Category==========================*/
INSERT INTO [dbo].[PetServiceCategory]
           ([Id]
           ,[Name]
           ,[Description]
           ,[ServiceType]
           ,[ApplicableTo]
           ,[CreatedDate]
           ,[ModifiedDate]
           ,[IsDeleted])
     VALUES
           ('83d70177-2e40-49c9-a0bf-27ce80cce340' -- Category 1
           ,'Health Check' 
           ,'A standard health check for Koi fish to monitor their overall well-being and prevent diseases.' 
           ,'Health' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),
           
           ('fe3df183-1f42-4301-a1fb-35e6211c8816' -- Category 2
           ,'Feeding Service' 
           ,'Specialized feeding service for Koi fish, ensuring proper nutrition and dietary requirements.' 
           ,'Feeding' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),
           
           ('75efc332-0e1b-4d35-a609-4897d83c173e' -- Category 3
           ,'Water Quality Testing' 
           ,'Testing water quality parameters to ensure a healthy environment for Koi.' 
           ,'Testing' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),

           ('a5e47a8f-f6e1-4c7a-8955-4a928744f9bf' -- Category 4
           ,'Fungal Treatment' 
           ,'Treatment services for Koi suffering from fungal infections.' 
           ,'Treatment' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),

           ('da91046c-71d1-429b-ade3-5e8ff9f701a6' -- Category 5
           ,'Parasite Treatment' 
           ,'Services to treat and prevent parasites in Koi fish.' 
           ,'Treatment' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),

           ('82b86176-d076-4576-b0f3-60220ca3e5ba'-- Category 6
           ,'Pond Maintenance' 
           ,'Regular maintenance services for Koi ponds to ensure optimal conditions.' 
           ,'Maintenance' 
           ,'Ponds' 
           ,GETDATE() 
           ,NULL 
           ,0),

           ('3d3bb172-c3d0-4d0f-ac50-713708bc6498' -- Category 7
           ,'Koi Breeding Assistance' 
           ,'Guidance and assistance in breeding Koi fish.' 
           ,'Breeding' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),

           ('15c55a94-06fb-4dac-8b32-7c1d7af085a3' -- Category 8
           ,'Koi Transportation' 
           ,'Safe transportation services for Koi fish.' 
           ,'Transportation' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),

           ('fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51' -- Category 9
           ,'Emergency Care' 
           ,'Emergency medical services for Koi in distress.' 
           ,'Emergency' 
           ,'Koi Fish' 
           ,GETDATE() 
           ,NULL 
           ,0),

           ('ca3801df-081c-4db5-a416-b04791797d92' -- Category 10
           ,'Educational Workshops' 
           ,'Workshops on Koi care and pond management.' 
           ,'Education' 
           ,'Koi Enthusiasts' 
           ,GETDATE() 
           ,NULL 
           ,0);
GO

/*==========================Service===========================*/

INSERT INTO [dbo].[PetService]
           ([Id]
           ,[PetServiceCategoryId]
           ,[BasePrice]
           ,[Duration]
           ,[ImageUrl]
          
           ,[AvailableFrom]
           ,[AvailableTo]
           ,[TravelCost]
           ,[CreatedDate]
           ,[ModifiedDate]
           ,[IsDeleted]
           ,[Name])
     VALUES
           ('f6a59f70-c0db-45b4-a598-045a005d42ed' -- Service 1
           ,'3d3bb172-c3d0-4d0f-ac50-713708bc6498' 
           ,150.00 
           ,'3 hours' 
           ,'https://example.com/image7.jpg' 
           
           ,'2024-10-01T08:00:00Z' 
           ,'2024-10-31T20:00:00Z' 
           ,30.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Emergency Care'),

           ('7d80bd0a-7780-4c4c-981b-48d7f8784405' -- Service 2
           ,'da91046c-71d1-429b-ade3-5e8ff9f701a6' 
           ,100.00 
           ,'2 hours' 
           ,'https://example.com/image5.jpg' 
        
           ,'2024-10-01T08:00:00Z' 
           ,'2024-10-31T20:00:00Z' 
           ,25.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Parasite Treatment'),

           ('2d95b900-9b04-4f6f-94ec-7d47d2a89ec8' -- Service 3
           ,'75efc332-0e1b-4d35-a609-4897d83c173e' 
           ,20.00 
           ,'45 minutes' 
           ,'https://example.com/image3.jpg' 
      
           ,'2024-10-03T08:00:00Z' 
           ,'2024-10-25T20:00:00Z' 
           ,5.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Water Quality Testing'),

           ('39ebc58b-6731-491d-949d-82f387dce82e' -- Service 4
           ,'a5e47a8f-f6e1-4c7a-8955-4a928744f9bf' 
           ,29.99 
           ,'30 minutes' 
           ,'https://example.com/image.jpg' 
          
           ,'2024-10-03T22:10:20.3800000' 
           ,'2024-10-04T02:10:20.3800000' 
           ,10.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Koi Feeding Service'),

           ('33e71556-d924-4101-bd1f-8707ca0e6f87' -- Service 5
           ,'fe3df183-1f42-4301-a1fb-35e6211c8816' 
           ,30.00 
           ,'1 hour' 
           ,'https://example.com/image2.jpg' 
          
           ,'2024-10-05T08:00:00Z' 
           ,'2024-10-20T20:00:00Z' 
           ,15.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Koi Feeding Service'),

           ('2d547de7-d7a0-4c27-a26c-9cf3a7099817' -- Service 6
           ,'a5e47a8f-f6e1-4c7a-8955-4a928744f9bf' 
           ,75.00 
           ,'1.5 hours' 
           ,'https://example.com/image4.jpg' 
           
           ,'2024-10-10T08:00:00Z' 
           ,'2024-10-15T20:00:00Z' 
           ,20.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Fungal Treatment'),

           ('8c0ce681-03e2-4ed8-83b2-abc3db694c5b' -- Service 7
           ,'15c55a94-06fb-4dac-8b32-7c1d7af085a3' 
           ,40.00 
           ,'1 hour' 
           ,'https://example.com/image8.jpg' 
         
           ,'2024-10-03T08:00:00Z' 
           ,'2024-10-28T20:00:00Z' 
           ,12.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Educational Workshops'),

           ('7253ea62-e419-40dc-bc70-e069611587dd' -- Service 8
           ,'83d70177-2e40-49c9-a0bf-27ce80cce340' 
           ,1.00 
           ,'string' 
           ,'string' 
         
           ,'2024-10-04T14:02:32.9240000' 
           ,'2024-11-03T14:02:32.9240000' 
           ,0.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'string'),

           ('c33e3a86-0230-468b-8c06-ee91b7e8cc21' -- Service 9
           ,'82b86176-d076-4576-b0f3-60220ca3e5ba' 
           ,60.00 
           ,'1 hour' 
           ,'https://example.com/image6.jpg' 
          
           ,'2024-10-05T08:00:00Z' 
           ,'2024-10-30T20:00:00Z' 
           ,15.00 
           ,GETDATE() 
           ,NULL 
           ,0 
           ,'Pond Maintenance');
GO



-- Insert sample data into PetHabitat table
INSERT INTO [KoiCenterDB].[dbo].[PetHabitat]
    ([Id], [HabitatType], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES
    (NEWID(), 'Pond', GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Aquarium', GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Outdoor Water Garden', GETDATE(), 'Admin', GETDATE(), 'Admin', 0);

-- Retrieve the generated GUIDs for PetHabitat
SELECT [Id], [HabitatType] 
FROM [KoiCenterDB].[dbo].[PetHabitat];



	INSERT INTO [KoiCenterDB].[dbo].[PetType]
    ([Id], [GeneralType], [SpecificType], [PetHabitatId], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES
    (NEWID(), 'Fish', 'Koi Fish', '/* Pond Habitat Id here */', GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Fish', 'Goldfish', '/* Aquarium Habitat Id here */', GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Fish', 'Shubunkin', '/* Outdoor Water Garden Habitat Id here */', GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Fish', 'Butterfly Koi', '/* Pond Habitat Id here */', GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Fish', 'Comet Goldfish', '/* Aquarium Habitat Id here */', GETDATE(), 'Admin', GETDATE(), 'Admin', 0);


INSERT INTO [KoiCenterDB].[dbo].[Pet]
    ([Id], [Name], [Age], [Gender], [ImageUrl], [Color], [Length], [Weight], [LastHealthCheck], [HealthStatus], [OwnerId], [PetTypeId], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES
    (NEWID(), 'Koi A', 2, 'Male', 'https://example.com/koi_a.jpg', 'Orange', 30.5, 2.1, '2023-10-01', 1, 'DD0E9F37-D587-401D-932E-7F098EB60B3E', NULL, GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Koi B', 3, 'Female', 'https://example.com/koi_b.jpg', 'White', 35.0, 2.4, '2023-09-15', 2, '45A9DC1C-FB8A-4607-9A7E-D6B1359384D7', NULL, GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Koi C', 1, 'Male', 'https://example.com/koi_c.jpg', 'Black', 25.2, 1.9, '2023-09-20', 1, 'BCA84E29-DE4D-475B-A3AD-A02E937EFA14', NULL, GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Koi D', 4, 'Female', 'https://example.com/koi_d.jpg', 'Gold', 40.3, 3.0, '2023-08-25', 3, 'DD0E9F37-D587-401D-932E-7F098EB60B3E', NULL, GETDATE(), 'Admin', GETDATE(), 'Admin', 0),
    (NEWID(), 'Koi E', 2, 'Male', 'https://example.com/koi_e.jpg', 'Red', 32.8, 2.2, '2023-10-05', 1, '45A9DC1C-FB8A-4607-9A7E-D6B1359384D7', NULL, GETDATE(), 'Admin', GETDATE(), 'Admin', 0);
























