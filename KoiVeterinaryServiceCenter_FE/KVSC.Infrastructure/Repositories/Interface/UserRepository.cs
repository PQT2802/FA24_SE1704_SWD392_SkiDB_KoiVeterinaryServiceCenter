using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Login;
using KVSC.Infrastructure.Repositories.Implement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Interface
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
            var response = await _httpClient.PostAsJsonAsync("api/Auth/sign-in", loginRequest);
            var responseContent = await response.Content.ReadAsStringAsync();

            Debug.WriteLine($"Response Content: {responseContent}");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // This will ignore case sensitivity
            };

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                // Deserialize the error response using the options for case insensitivity
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                var error = new ResponseDto<LoginResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred during sign-in."
                };

                // Log the error details for inspection
                Debug.WriteLine($"Error Details: {JsonSerializer.Serialize(error.Errors)}");

                return error;
            }

            // If successful, deserialize the login response
            var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseContent, options);

            return new ResponseDto<LoginResponse>
            {
                IsSuccess = true,
                Data = loginResponse,
                Message = "Sign-in successful."
            };
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
    }
}
