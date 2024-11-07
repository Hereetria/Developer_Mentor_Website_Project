﻿using DtoLayer.Dtos.ArticleTagDtos;
using EntityLayer.Entities;
using Humanizer;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Repositories.Concrete
{
    public class GenericJunctionRepository<TResultDto, TCreateDto, TUpdateDto> : IGenericJunctionRepository<TResultDto, TCreateDto, TUpdateDto>
    where TResultDto : class
    where TCreateDto : class
    where TUpdateDto : class
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _baseUrl;
        protected readonly string _baseEndpoint;

        protected GenericJunctionRepository(HttpClient httpClient, IConfiguration configuration, string baseEndpoint)
        {
            _httpClient = httpClient;

            var apiBaseUrl = configuration["ApiBaseUrl"];
            if (string.IsNullOrEmpty(apiBaseUrl))
            {
                throw new ArgumentNullException(nameof(apiBaseUrl), "API base URL is not configured.");
            }

            _baseUrl = apiBaseUrl;

            _baseEndpoint = baseEndpoint;
        }

        public async Task<List<TResultDto>> GetAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}/{_baseEndpoint}");
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadFromJsonAsync<List<TResultDto>>();

                return result ?? new List<TResultDto>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"GetAll failed: {ex.Message}", ex);
            }
        }
        public async Task CreateAsync(TCreateDto createDto)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/{_baseEndpoint}", createDto);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Create failed: {ex.Message}", ex);
            }
        }

        public async Task UpdateAsync(TUpdateDto updateDto)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/{_baseEndpoint}", updateDto);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Update failed: {ex.Message}", ex);
            }
        }

        protected async Task DeleteAsync(Dictionary<string, object> queryParams)
        {
            try
            {
                var query = string.Join("&", queryParams.Select(kvp => $"{kvp.Key}={kvp.Value}"));
                var url = $"{_baseUrl}/{_baseEndpoint}?{query}";

                var response = await _httpClient.DeleteAsync(url);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Delete failed: {ex.Message}", ex);
            }
        }


        protected async Task<List<TRelatedEntity>> GetRelatedEntitiesByIdAsync<TRelatedEntity>(string methodName, int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}/{_baseEndpoint}/{}/{id}");
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadFromJsonAsync<List<TRelatedEntity>>();

                return result ?? new List<TRelatedEntity>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"GetAll failed: {ex.Message}", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("The data retrieved is not in the expected format.", ex);
            }
        }
    }
}