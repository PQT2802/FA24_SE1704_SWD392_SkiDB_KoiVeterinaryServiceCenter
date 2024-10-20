﻿using KVSC.Infrastructure.Interface.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IPetRepository PetRepository { get; }

        IProductRepository ProductRepository { get; }
        IFirebaseRepository FirebaseRepository { get; }
        IProductCategoryRepository ProductCategoryRepository { get; }

        IPetServiceRepository PetServiceRepository { get; }
        IPetServiceCategoryRepository PetServiceCategoryRepository { get; }
        IComboServiceRepository ComboServiceRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }

        IPetTypeRepository PetTypeRepository { get; }
        IPetHabitatRepository PetHabitatRepository { get; }


        IServiceReportRepository ServiceReportRepository { get; }
        IPrescriptionRepository PrescriptionRepository { get; }
        IMessageRepository MessageRepository { get; }

        int Complete();
    }
}
