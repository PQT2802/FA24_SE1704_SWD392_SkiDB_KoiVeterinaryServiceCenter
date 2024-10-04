//using FirebaseAdmin;
//using Google.Apis.Auth.OAuth2;
//using Google.Cloud.Storage.V1;
//using Microsoft.Extensions.DependencyInjection;
//using System.IO;

//namespace KVSC.WebAPI.Extentions
//{
//    public static class FirebaseServiceExtensions
//    {
//        public static IServiceCollection AddFirebaseServices(this IServiceCollection services)
//        {
//            var credentialPath = Path.Combine(Directory.GetCurrentDirectory(), "koiveterinaryservicecent-925db-firebase-adminsdk-vus2r-78a95364f3.json");
//            FirebaseApp.Create(new AppOptions()
//            {
//                Credential = GoogleCredential.FromFile(credentialPath)
//            });

//            // Register the Google Cloud Storage client and any Firebase related services
//            services.AddSingleton(StorageClient.Create(GoogleCredential.FromFile(credentialPath)));

//            return services;
//        }
//    }
//}
