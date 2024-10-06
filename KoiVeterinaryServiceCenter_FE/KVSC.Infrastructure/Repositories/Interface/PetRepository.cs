using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Login;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.Repositories.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public class PetRepository : IPetRepository
    {
        private readonly HttpClient _httpClient;
        public PetRepository(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<ResponseDto<List<PetType>>> GetListPetTypeAsync()
        {
            try
            {
                // Directly deserializing the response
                var petListResponse = await _httpClient.GetFromJsonAsync<List<PetType>>("api/Pet/pet-type-list");

                if (petListResponse == null)
                {
                    return new ResponseDto<List<PetType>>
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = "No data returned from the API."
                    };
                }

                return new ResponseDto<List<PetType>>
                {
                    IsSuccess = true,
                    Data = petListResponse,
                    Message = "Get list successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP exceptions (like 404, 500, etc.)
                return new ResponseDto<List<PetType>>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<List<PetType>>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}
