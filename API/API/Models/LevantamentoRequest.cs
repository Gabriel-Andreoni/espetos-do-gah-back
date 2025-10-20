namespace API.Models;

public record LevantamentoRequest(
    string dataLevantamento,
    int carneVendida,
    int franbaconVendido,
    int linguicaVendida,
    int carvao,
    decimal precoCarvao,
    int qntCarneDespesa,
    decimal precoCarneDespesa,
    int qntFranbaconDespesa,
    decimal precoFranbaconDespesa,
    int qntLinguicaDespesa,
    decimal precoLinguicaDespesa
    );