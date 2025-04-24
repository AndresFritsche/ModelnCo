using System;

namespace ModelnCoAPI.Data;

public class DbInitializer
{
    public void InitiDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<ModelnCoContext>()
            ??throw new InvalidOperationException("Failed to retrieve store context");

        SeedData(context);
        
    }

    private void SeedData(ModelnCoContext context)
    {
        throw new NotImplementedException();
    }
}
