namespace API.Models;

public class LevantamentoModel
{
    public Guid ID {get; private set;}
    public string DataLevantamento { get; private set; }
    
    // Espetos Vendidos
    
    public int CarneVendida { get; private set; }
    public decimal PrecoVendidoCarne { get; private set; }
    public int FranbaconVendido { get; private set; }
    public decimal PrecoVendidoFranbacon { get; private set; }
    public int LinguicaVendida { get; private set; }
    public decimal PrecoVendidoLinguica { get; private set; }
    
    // Despesas
    
    public int Carvao { get; private set; }
    public decimal PrecoCarvao { get; private set; }
    
    public int QntCarneDespesa { get; private set; }
    public decimal PrecoCarneDespesa { get; private set; }
    
    public int QntFranbaconDespesa { get; private set; }
    public decimal PrecoFranbaconDespesa { get; private set; }
    
    public int QntLinguicaDespesa { get; private set; }
    public decimal  PrecoLinguicaDespesa { get; private set; }


    public LevantamentoModel(
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
        )
    {
        ID = Guid.NewGuid();
        DataLevantamento = dataLevantamento;
        CarneVendida = carneVendida;
        PrecoVendidoCarne = precoVendidoCarne;
        FranbaconVendido = franbaconVendido;
        PrecoVendidoFranbacon = precoVendidoFranbacon;
        LinguicaVendida = linguicaVendida;
        PrecoVendidoLinguica = precoVendidoLinguica;
        Carvao = carvao;
        PrecoCarvao = precoCarvao;
        QntCarneDespesa = qntCarneDespesa;
        PrecoCarneDespesa = precoCarneDespesa;
        QntFranbaconDespesa = qntFranbaconDespesa;
        PrecoFranbaconDespesa = precoFranbaconDespesa;
        QntLinguicaDespesa =  qntLinguicaDespesa;
        PrecoLinguicaDespesa =  precoLinguicaDespesa;
    }
}