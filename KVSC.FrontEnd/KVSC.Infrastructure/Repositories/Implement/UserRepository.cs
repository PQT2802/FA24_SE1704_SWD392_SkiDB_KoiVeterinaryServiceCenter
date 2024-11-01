using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service.AddService;
using KVSC.Infrastructure.DTOs.Service.UpdateService;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.DeleteUser;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class UserRepository : IUserRepository
    {
        private readonly HttpClient _httpClient;
        public UserRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDto<LoginResponse>> SignIn(LoginRequest loginRequest)
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.PostAsJsonAsync("api/Auth/sign-in", loginRequest);

                /// must have
                
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

                    return new ResponseDto<LoginResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                       Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during sign-in."
                    };
                }

                // If successful, deserialize the login response
                var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>(options);
                Console.WriteLine(JsonSerializer.Serialize(loginResponse, new JsonSerializerOptions { WriteIndented = true }));

                return new ResponseDto<LoginResponse>
                {
                    IsSuccess = true,
                    Data = loginResponse,
                    Message = "Sign-in successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<LoginResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<LoginResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<LoginResponse>> GoogleSignIn(GoogleSignInRequest googleSignInRequest)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Auth/google-sign-in", googleSignInRequest);
            var responseContent = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);
                return new ResponseDto<LoginResponse>
                {
                    IsSuccess = false,
                   Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "Google sign-in failed."
                };
            }

            var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseContent, options);

            return new ResponseDto<LoginResponse>
            {
                IsSuccess = true,
                Data = loginResponse,
                Message = "Sign-in successful."
            };
        }

        public async Task<ResponseDto<SignUpResponse>> SignUp(SignUpRequest signUpRequest)
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.PostAsJsonAsync("api/Auth/sign-up", signUpRequest); // Chỉnh sửa endpoint

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

                    return new ResponseDto<SignUpResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during sign-up."
                    };
                }

                // If successful, deserialize the login response
                var signUpResponse = await response.Content.ReadFromJsonAsync<SignUpResponse>(options);


                return new ResponseDto<SignUpResponse>
                {
                    IsSuccess = true,
                    Data = signUpResponse, // Cập nhật dữ liệu trả về
                    Message = "Sign-up successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<SignUpResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<SignUpResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<UserInfo>> GetUserInforByToken(string token)
        {
            try
            {
                // Set the request with authorization token in headers
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Send the request and get the response
                var response = await _httpClient.GetAsync("api/User/user-infor");

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

                    return new ResponseDto<UserInfo>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get infor."
                    };
                }

                // If successful, deserialize the UserInfo response
                var userInfo = await response.Content.ReadFromJsonAsync<UserInfo>(options);
                Console.WriteLine(JsonSerializer.Serialize(userInfo, new JsonSerializerOptions { WriteIndented = true }));

                return new ResponseDto<UserInfo>
                {
                    IsSuccess = true,
                    Data = userInfo,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<UserInfo>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<UserInfo>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<UserList>> GetUserList(string fullName, string email, string phoneNumber, string address, int role, int pageNumber, int pageSize)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/User/users/search?fullName={fullName}&email={email}&phoneNumber={phoneNumber}&address={address}&role={role}&pageNumber={pageNumber}&pageSize={pageSize}");
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>(options);
                    return new ResponseDto<UserList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during fetching user data."
                    };
                }

                var userList = await response.Content.ReadFromJsonAsync<UserList>(options);
                return new ResponseDto<UserList>
                {
                    IsSuccess = true,
                    Data = userList,
                    Message = "User data fetched successfully."
                };
            }
            catch (HttpRequestException ex)
            {
                return new ResponseDto<UserList>
                {
                    IsSuccess = false,
                    Message = $"Request error: {ex.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<UserList>
                {
                    IsSuccess = false,
                    Message = $"Unexpected error: {ex.Message}"
                };
            }
        }
        
        public async Task<ResponseDto<RoleList>> GetRoleList()
        {
            try
            {
                // Gửi yêu cầu GET đến API để lấy danh sách vai trò
                var response = await _httpClient.GetAsync("api/User/roleList");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Kiểm tra xem phản hồi có thành công hay không
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<RoleList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get role list."
                    };
                }

                // Nếu thành công, deserialize phản hồi để lấy danh sách vai trò
                var roleList = await response.Content.ReadFromJsonAsync<RoleList>(options);

                return new ResponseDto<RoleList>
                {
                    IsSuccess = true,
                    Data = roleList,
                    Message = "Get role list successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Xử lý lỗi yêu cầu HTTP
                return new ResponseDto<RoleList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                return new ResponseDto<RoleList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<UpdateUserResponse>> UpdateUser(UpdateUserRequest request, IFormFile imageFile)
        {
            try
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var response = await _httpClient.PutAsJsonAsync("api/User", request);

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<UpdateUserResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during updating."
                    };
                }

                var updateResponse = await response.Content.ReadFromJsonAsync<UpdateUserResponse>(options);
                //==================================phan them anh==========================================
                if(imageFile != null) { 
                    // Tạo form data để gửi
                    var formContent = new MultipartFormDataContent();
                    var fileContent = new StreamContent(imageFile.OpenReadStream());
                    fileContent.Headers.ContentType = new MediaTypeHeaderValue(imageFile.ContentType);

                    // Thêm file vào form data
                    formContent.Add(fileContent, "ImageFile", imageFile.FileName);
                    formContent.Add(new StringContent(updateResponse.Extensions.Data.Id.ToString()), "Id");

                    // Gọi API cập nhật ảnh
                    var uploadResponse = await _httpClient.PostAsync("api/User/upload/img", formContent);

                    if (uploadResponse.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        var uploadResponseContent = await uploadResponse.Content.ReadAsStringAsync();
                        var uploadErrorResponse = JsonSerializer.Deserialize<ErrorResponse>(uploadResponseContent, options);

                        return new ResponseDto<UpdateUserResponse>
                        {
                            IsSuccess = false,
                            Data = null,
                            Errors = uploadErrorResponse?.Errors ?? new List<ErrorDetail>(),
                            Message = "An error occurred while uploading the image."
                        };
                    }
                }
                //==================================ket thuc them anh==========================================
                return new ResponseDto<UpdateUserResponse>
                {
                    IsSuccess = true,
                    Data = updateResponse,
                    Message = "Update user successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<UpdateUserResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<UpdateUserResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<DeleteUserResponse>> DeleteUser(DeleteUserRequest request)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"api/User?Id={request.Id}");

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent);

                    return new ResponseDto<DeleteUserResponse>
                    {
                        IsSuccess = false,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "Failed to delete user."
                    };
                }

                return new ResponseDto<DeleteUserResponse>
                {
                    IsSuccess = true,
                    Message = "User deleted successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<DeleteUserResponse>
                {
                    IsSuccess = false,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<DeleteUserResponse>
                {
                    IsSuccess = false,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<GetUserResponse>> GetUserDetail(Guid id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/User?Id={id}");

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetUserResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get user info."
                    };
                }

                var user = await response.Content.ReadFromJsonAsync<GetUserResponse>(options);

                return new ResponseDto<GetUserResponse>
                {
                    IsSuccess = true,
                    Data = user,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<GetUserResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<GetUserResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<GetVeterinarianResponse>> GetVeter(Guid id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/User/veterinarian/{id}");

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetVeterinarianResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during getting veterinarian info."
                    };
                }

                var veterinarian = await response.Content.ReadFromJsonAsync<GetVeterinarianResponse>(options);

                return new ResponseDto<GetVeterinarianResponse>
                {
                    IsSuccess = true,
                    Data = veterinarian,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<GetVeterinarianResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<GetVeterinarianResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<UpdateUserResponse>> UpdateVeterinarianQualificationsAsync(GetVeterinarianRequest updatedProfile)
        {
            try
            {
                // Define the endpoint
                var url = $"api/User/{updatedProfile.UserId}";

                // Serialize the profile data into JSON
                var jsonContent = JsonSerializer.Serialize(new
                {
                    licenseNumber = updatedProfile.LicenseNumber,
                    specialty = updatedProfile.Specialty,
                    qualifications = updatedProfile.Qualifications
                });
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Send PUT request
                var response = await _httpClient.PutAsync(url, content);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize lỗi trả về từ API
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<UpdateUserResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during updating."
                    };
                }
                // Nếu thành công, lấy dữ liệu phản hồi
                var updateResponse = await response.Content.ReadFromJsonAsync<UpdateUserResponse>(options);
                return new ResponseDto<UpdateUserResponse>
                {
                    IsSuccess = true,
                    Data = updateResponse,
                    Message = "Update service successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<UpdateUserResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<UpdateUserResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<AddMoney>> TopUpWallet(string token, decimal amount)
        {
            try
            {
                // Set the request with authorization token in headers
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Construct the request URL with the depositMoney parameter
                var requestUrl = $"api/Payment/create-payment-url?depositMoney={amount}";

                // Send the request and get the response
                var response = await _httpClient.PostAsync(requestUrl, null);

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

                    return new ResponseDto<AddMoney>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during the payment process."
                    };
                }

                // If successful, deserialize the AddMoney response
                var data = await response.Content.ReadFromJsonAsync<AddMoney>(options);

                return new ResponseDto<AddMoney>
                {
                    IsSuccess = true,
                    Data = data,
                    Message = "Payment URL created successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<AddMoney>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<AddMoney>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}
