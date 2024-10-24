using Google.Cloud.Storage.V1;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Implement.Repositories;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;

namespace KVSC.Infrastructure.KVSC.Infrastructure.Common
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly KVSCContext _context;

        public IUserRepository UserRepository { get; private set; }
        public IPetRepository PetRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public IFirebaseRepository FirebaseRepository { get; private set; }
        public IProductCategoryRepository ProductCategoryRepository { get; private set; }
        public IPetServiceRepository PetServiceRepository { get; private set; }
        public IPetServiceCategoryRepository PetServiceCategoryRepository { get; private set; }
        public IComboServiceRepository ComboServiceRepository { get; private set; }
        public IAppointmentRepository AppointmentRepository { get; private set; }
        public IPetTypeRepository PetTypeRepository { get; private set; }
        public IPetHabitatRepository PetHabitatRepository { get; private set; }
        public IMessageRepository MessageRepository { get; private set; }
        public IServiceReportRepository ServiceReportRepository { get; private set; }
        public IPrescriptionRepository PrescriptionRepository { get; private set; }

        public IVeterinarianScheduleRepository VeterinarianScheduleRepository {  get; private set; }
        public IRatingRepository RatingRepository {  get; private set; }
        public UnitOfWork(KVSCContext context, StorageClient storageClient)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
            PetRepository = new PetRepository(_context);
            ProductRepository = new ProductRepository(_context);
            FirebaseRepository = new FirebaseRepository(storageClient);
            ProductCategoryRepository = new ProductCategoryRepository(_context);
            PetServiceRepository = new PetServiceRepository(_context);
            PetServiceCategoryRepository = new PetServiceCategoryRepository(_context);
            ComboServiceRepository = new ComboServiceRepository(_context);
            AppointmentRepository = new AppointmentRepository(_context);
            PetTypeRepository = new PetTypeRepository(_context);
            PetHabitatRepository = new PetHabitatRepository(_context);
            MessageRepository = new MessageRepository(_context);
            ServiceReportRepository = new ServiceReportRepository(_context);
            PrescriptionRepository = new PrescriptionRepository(_context);
            VeterinarianScheduleRepository = new VeterinarianScheduleRepository(_context);

            RatingRepository = new RatingRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
