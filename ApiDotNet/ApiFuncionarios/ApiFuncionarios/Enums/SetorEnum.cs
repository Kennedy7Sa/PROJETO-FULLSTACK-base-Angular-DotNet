using System.Text.Json.Serialization;

namespace ApiFuncionarios.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SetorEnum
    {
        TI,
        CONTABILIDADE
    }
}
