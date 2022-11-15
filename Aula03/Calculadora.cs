public static class Calculadora
{
    public static int Somar(int a, int b)
    {
        var resultado = a + b;
        return resultado;
    }


    public static string Somar(string a, string b){
        return a + b;
    }

    public static bool Somar(bool a, bool b){
        return a || b;
    }
    
}