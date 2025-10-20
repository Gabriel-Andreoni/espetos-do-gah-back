using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Actions;

public class DeleteApontamento
{
    public async Task Deletar(LevantamentoContext context)
    {
        await context.Levantamento.ExecuteDeleteAsync();
        await context.SaveChangesAsync();
    }
}