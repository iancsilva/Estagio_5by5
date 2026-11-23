using System.Security.Cryptography;

public class Senha
{
    public string Valor { get; set; }
    public Senha? Proxima { get; set; } = null;

    public Senha(bool ehPrioritario)
    {
        if (ehPrioritario) { this.Valor = $"P{Random.Shared.Next()}"; }
        else { this.Valor = $"N{Random.Shared.Next()}"; }
    }

}