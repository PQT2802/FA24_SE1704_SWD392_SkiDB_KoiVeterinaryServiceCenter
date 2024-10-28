﻿using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;
using KVSC.Infrastructure.DTOs.Service.DeleteService;
using KVSC.Infrastructure.DTOs.Service.GetServiceDetail;
using KVSC.Infrastructure.DTOs.Service.UpdateService;

using KVSC.Infrastructure.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using PetServiceDto = KVSC.Infrastructure.DTOs.Service.ServiceDetail.PetServiceDto;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class PetServiceRepository : IPetServiceRepository
    {
        private readonly HttpClient _httpClient;

        public PetServiceRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }





        public async Task<ResponseDto<PetServiceDto>> GetPetServiceByIdAsync(Guid id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/PetService?Id={id}");
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Response: {responseContent}");  // Log raw API response for debugging

                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    return new ResponseDto<PetServiceDto>
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = "The response content is empty."
                    };
                }

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var errorResponse = JsonSerializer.Deserialize<ApiResponseDto<object>>(responseContent, options);
                    return new ResponseDto<PetServiceDto>
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = errorResponse?.Extensions?.Message ?? "An error occurred while processing the request."
                    };
                }

                var apiResponse = JsonSerializer.Deserialize<ApiResponseDto<PetServiceDto>>(responseContent, options);

                return new ResponseDto<PetServiceDto>
                {
                    IsSuccess = true,
                    Data = apiResponse?.Extensions?.Data,
                    Message = apiResponse?.Extensions?.Message
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<PetServiceDto>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (JsonException jsonEx)
            {
                return new ResponseDto<PetServiceDto>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Error parsing JSON response: {jsonEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<PetServiceDto>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }




        public async Task<ResponseDto<AddServiceResponse>> AddPetService(AddServiceRequest request, IFormFile imageFile)
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.PostAsJsonAsync("api/PetService", request);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response using the options for case insensitivity
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<AddServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during adding."
                    };
                }
                // If successful, deserialize the login response
                var addingResponse = await response.Content.ReadFromJsonAsync<AddServiceResponse>(options);

                //==================================phan them anh==========================================

                // Tạo form data để gửi
                var formContent = new MultipartFormDataContent();
                var fileContent = new StreamContent(imageFile.OpenReadStream());
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(imageFile.ContentType);

                // Thêm file vào form data
                formContent.Add(fileContent, "ImageFile", imageFile.FileName);
                formContent.Add(new StringContent(addingResponse.Extensions.Data.Id.ToString()), "PetServiceId");

                // Gọi API cập nhật ảnh
                var uploadResponse = await _httpClient.PostAsync("api/PetService/upload/img", formContent);

                if (uploadResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var uploadResponseContent = await uploadResponse.Content.ReadAsStringAsync();
                    var uploadErrorResponse = JsonSerializer.Deserialize<ErrorResponse>(uploadResponseContent, options);

                    return new ResponseDto<AddServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = uploadErrorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred while uploading the image."
                    };
                }
                //==================================ket thuc them anh==========================================

                return new ResponseDto<AddServiceResponse>
                {
                    IsSuccess = true,
                    Data = addingResponse,
                    Message = "Add service successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<AddServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<AddServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<UpdateServiceResponse>> UpdatePetService(UpdateServiceRequest request, IFormFile imageFile)
        {
            try
            {

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Gọi API PUT với dữ liệu request
                var response = await _httpClient.PutAsJsonAsync("api/PetService", request);

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize lỗi trả về từ API
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<UpdateServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during updating."
                    };
                }

                // Nếu thành công, lấy dữ liệu phản hồi
                var updateResponse = await response.Content.ReadFromJsonAsync<UpdateServiceResponse>(options);

                //==================================phan them anh==========================================

                // Tạo form data để gửi
                var formContent = new MultipartFormDataContent();
                var fileContent = new StreamContent(imageFile.OpenReadStream());
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(imageFile.ContentType);

                // Thêm file vào form data
                formContent.Add(fileContent, "ImageFile", imageFile.FileName);
                formContent.Add(new StringContent(updateResponse.Extensions.Data.Id.ToString()), "PetServiceId");

                // Gọi API cập nhật ảnh
                var uploadResponse = await _httpClient.PostAsync("api/PetService/upload/img", formContent);

                if (uploadResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var uploadResponseContent = await uploadResponse.Content.ReadAsStringAsync();
                    var uploadErrorResponse = JsonSerializer.Deserialize<ErrorResponse>(uploadResponseContent, options);

                    return new ResponseDto<UpdateServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = uploadErrorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred while uploading the image."
                    };
                }
                //==================================ket thuc them anh==========================================

                return new ResponseDto<UpdateServiceResponse>
                {
                    IsSuccess = true,
                    Data = updateResponse,
                    Message = "Update service successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<UpdateServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<UpdateServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<DeleteServiceResponse>> DeletePetService(DeleteServiceRequest request)
        {
            try
            {
                var url = $"api/PetService?Id={request.Id}";

                // Call the API DELETE with the service ID in the URL
                var response = await _httpClient.DeleteAsync(url);

                if (response.StatusCode != System.Net.HttpStatusCode.OK) // Kiểm tra mã trạng thái
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize lỗi trả về từ API
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent);

                    return new ResponseDto<DeleteServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during deletion."
                    };
                }

                // Nếu thành công, trả về thông điệp thành công
                return new ResponseDto<DeleteServiceResponse>
                {
                    IsSuccess = true,
                    Data = null,
                    Message = "Delete service successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<DeleteServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<DeleteServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<KoiServiceList>> GetKoiServiceList()
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.GetAsync("api/PetService/all");

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

                    return new ResponseDto<KoiServiceList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get infor."
                    };
                }

                // If successful, deserialize the UserInfo response
                var koiServiceList = await response.Content.ReadFromJsonAsync<KoiServiceList>(options);

                return new ResponseDto<KoiServiceList>
                {
                    IsSuccess = true,
                    Data = koiServiceList,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<KoiServiceList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<KoiServiceList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<GetPetServiceResponse>> GetPetServiceDetail(Guid id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/PetService?Id={id}");

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetPetServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get infor."
                    };
                }

                var petService = await response.Content.ReadFromJsonAsync<GetPetServiceResponse>(options);

                return new ResponseDto<GetPetServiceResponse>
                {
                    IsSuccess = true,
                    Data = petService,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<GetPetServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<GetPetServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

    }
}