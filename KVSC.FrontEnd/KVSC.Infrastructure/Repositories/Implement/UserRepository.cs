using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
                var response = await _httpClient.PostAsJsonAsync("api/Auth/sign-in", signUpRequest);

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
                        Message = "An error occurred during sign-in."
                    };
                }

                // If successful, deserialize the login response
                var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>(options);

                return new ResponseDto<SignUpResponse>
                {
                    IsSuccess = true,
                    Data = null,
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
                var jsonData = JsonSerializer.Serialize(userInfo, new JsonSerializerOptions { WriteIndented = true });
                Console.WriteLine(jsonData);

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
    }
}
