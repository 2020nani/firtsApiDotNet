using System.ComponentModel;

namespace firstApi.domain.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluida")]
        Concluida = 3
    }
}
