namespace API.Models;

public record LevantamentoRequest(
    string dataLevantamento,
    int carneVendida,
    decimal precoVendidoCarne,
    int franbaconVendido,
    decimal precoVendidoFranbacon,
    int linguicaVendida,
    decimal precoVendidoLinguica,
    int carvao,
    decimal precoCarvao,
    int qntCarneDespesa,
    decimal precoCarneDespesa,
    int qntFranbaconDespesa,
    decimal precoFranbaconDespesa,
    int qntLinguicaDespesa,
    decimal precoLinguicaDespesa
    );