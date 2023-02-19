using byteBank.Funcionarios;

internal static class SistemaInternoHelpers
{


    public static bool Logar(Gerente_de_Contas funcionario, string senha)
    {
        bool autenticado = funcionario.Autenticar(senha);
        if (autenticado)
        {
            Console.WriteLine("Boas vindas ao sistema!");
        }
        else
        {
            Console.WriteLine("Senha incorreta!");
        }

        return autenticado;
    }
}