using firstApi.domain.Enums;

namespace firstApi.domain.Models
{
    public class TarefasModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa StatusTarefa { get; set; }


    }
}
