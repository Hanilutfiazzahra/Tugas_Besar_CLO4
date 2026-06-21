using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Json;
using Tugas_Besar_CLO4.Entities;

namespace Tugas_Besar_CLO4.Services
{
    public static class ApiService
    {
        private static readonly HttpClient client =
            new HttpClient();

        static ApiService()
        {
            client.BaseAddress =
                new Uri("http://localhost:62241/");
        }

        public static async Task<AuthResponse> Login(
            LoginRequest request)
        {
            HttpResponseMessage response =
                await client.PostAsJsonAsync(
                    "api/auth/login",
                    request
                );

            if (response.IsSuccessStatusCode == false)
            {
                ErrorResponse? error =
                    await response.Content
                        .ReadFromJsonAsync<ErrorResponse>();

                if (error != null)
                {
                    throw new Exception(error.Message);
                }

                throw new Exception("Login gagal.");
            }

            AuthResponse? hasil =
                await response.Content
                    .ReadFromJsonAsync<AuthResponse>();

            if (hasil == null)
            {
                throw new Exception(
                    "Respons login dari API tidak dapat dibaca."
                );
            }

            return hasil;
        }

        public static async Task<AuthResponse> Register(
            RegisterRequest request)
        {
            HttpResponseMessage response =
                await client.PostAsJsonAsync(
                    "api/auth/register/customer",
                    request
                );

            if (response.IsSuccessStatusCode == false)
            {
                ErrorResponse? error =
                    await response.Content
                        .ReadFromJsonAsync<ErrorResponse>();

                if (error != null)
                {
                    throw new Exception(error.Message);
                }

                throw new Exception("Register gagal.");
            }

            AuthResponse? hasil =
                await response.Content
                    .ReadFromJsonAsync<AuthResponse>();

            if (hasil == null)
            {
                throw new Exception(
                    "Respons register dari API tidak dapat dibaca."
                );
            }

            return hasil;
        }

        public static async Task Logout()
        {
            HttpResponseMessage response =
                await client.PostAsync(
                    "api/auth/logout",
                    null
                );

            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception("Logout gagal.");
            }
        }
    }
}