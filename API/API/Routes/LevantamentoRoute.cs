using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

public static class LevantamentoRoute
{
    public static void LevantamentoRoutes(this WebApplication app)
    {
        var route = app.MapGroup("levantamentos");

        route.MapPost("", async (LevantamentoRequest req, LevantamentoContext context) =>
        {
            var levantamento = new LevantamentoModel(
                    req.dataLevantamento,
                    req.carneVendida,
                    req.franbaconVendido,
                    req.linguicaVendida,
                    req.carvao,
                    req.precoCarvao,
                    req.qntCarneDespesa,
                    req.precoCarneDespesa,
                    req.qntFranbaconDespesa,
                    req.precoFranbaconDespesa,
                    req.qntLinguicaDespesa,
                    req.precoLinguicaDespesa
                );

            await context.AddAsync(levantamento);
            await context.SaveChangesAsync();
        });

        route.MapGet("", async (LevantamentoContext context) =>
        {
            var levantamentos = await context.Levantamento.ToListAsync();
            
            return Results.Ok(levantamentos);
        });
    }
}