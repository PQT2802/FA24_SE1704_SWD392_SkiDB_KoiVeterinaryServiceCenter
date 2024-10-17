﻿using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs;
using System.Net.Http.Json;
using System.Text.Json;
using KVSC.Infrastructure.Repositories.Interface;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class PetRepository : IPetRepository
    {
        private readonly HttpClient _httpClient;

        public PetRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        
        

        public async Task<ResponseDto<PetList>> GetPetsByOwnerIdAsync(string ownerId)
        {
            try
            {
                // Construct the request URL
                var url = $"https://localhost:7283/api/Pet/owner-pet/{ownerId}";

                // Send the request and get the response
                var response = await _httpClient.GetAsync(url);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Check if the response indicates failure
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<PetList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred while retrieving the pets."
                    };
                }

                // If successful, deserialize the response into PetList
                var petList = await response.Content.ReadFromJsonAsync<PetList>(options);

                return new ResponseDto<PetList>
                {
                    IsSuccess = true,
                    Data = petList,
                    Message = "Pets retrieved successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<PetList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<PetList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }



        public async Task<ResponseDto<PetList>> GetPetList()
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.GetAsync("api/Pet/All-pet");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Check if the response indicates failure
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response using the options for case insensitivity
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<PetList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred while retrieving pet information."
                    };
                }

                // If successful, deserialize the response
                var petList = await response.Content.ReadFromJsonAsync<PetList>(options);

                return new ResponseDto<PetList>
                {
                    IsSuccess = true,
                    Data = petList,
                    Message = "Pet data retrieval successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<PetList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<PetList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<AddPetResponse>> AddPetAsync(AddPetRequest request)
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.PostAsJsonAsync("api/Pet/Create-pet", request);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response using the options for case insensitivity
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<AddPetResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during pet addition."
                    };
                }

                // If successful, deserialize the response
                var addingResponse = await response.Content.ReadFromJsonAsync<AddPetResponse>(options);

                return new ResponseDto<AddPetResponse>
                {
                    IsSuccess = true,
                    Data = addingResponse,
                    Message = "Pet added successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<AddPetResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<AddPetResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<UpdatePetResponse>> UpdatePetAsync(UpdatePetRequest request)
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.PutAsJsonAsync($"api/Pet/Update-pet?id={request.Id}", request);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response using the options for case insensitivity
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<UpdatePetResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during pet update."
                    };
                }

                // If successful, deserialize the response
                var updateResponse = await response.Content.ReadFromJsonAsync<UpdatePetResponse>(options);

                return new ResponseDto<UpdatePetResponse>
                {
                    IsSuccess = true,
                    Data = updateResponse,
                    Message = "Pet updated successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<UpdatePetResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<UpdatePetResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<DeletePetResponse>> DeletePetAsync(DeletePetRequest request)
        {
            try
            {
                var url = $"api/Pet/Delete-pet/{request.Id}";

                // Call the API DELETE with the pet ID in the URL
                var response = await _httpClient.DeleteAsync(url);

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize lỗi trả về từ API
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent);

                    return new ResponseDto<DeletePetResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during pet deletion."
                    };
                }

                // If successful, return success message
                return new ResponseDto<DeletePetResponse>
                {
                    IsSuccess = true,
                    Data = null,
                    Message = "Pet deleted successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<DeletePetResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<DeletePetResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}