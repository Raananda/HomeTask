using AuditUtil.Models;
using Shared.Dtos;
using Shared.Enums;
using System.Net.Http.Json;
using System.Text.Json;

namespace AuditUtil;

public static class Audit
{
    static readonly HttpClient client = new();

    public static async Task CreatePlanChanged(string planName, int simId, string user)
    {
        try
        {

            // Create Json Data
            PlanChangedData planChangedData = new PlanChangedData
            {
                planName = planName,
                simId = simId,
                user = user
            };

            string jsonString = JsonSerializer.Serialize(planChangedData);


            // Create Dto
            AuditDto auditDto = new AuditDto();
            auditDto.ActionType = ActionType.PlanChanged;
            auditDto.EntityType = EntityType.SIM;
            auditDto.DateTime = DateTime.Now;
            auditDto.JsonData = jsonString;


            // Post Dto to AuditService
            using HttpResponseMessage response = await client.PostAsJsonAsync("http://localhost:5005/Api/Audit", auditDto);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}