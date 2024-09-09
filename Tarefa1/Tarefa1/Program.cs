using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Tarefa1;

public class Program
{
    public static void Main()
    {
        #region 1 - Declarações
        string texto = "ABCPTX";
        bool teste = true;
        if (!texto.Contains("PTX"))
        {
            teste = false;
        }
        Console.WriteLine($"o valor da bool teste é {teste}");
        #endregion

        #region 2 - Propriedades e metodos extensivos
        Console.WriteLine($"o index de PTX no texto é {texto.IndexOf("PTX")}");
        string separar = "(?=[P])";
        string[] textoS = Regex.Split(texto, separar);
        foreach (string s in textoS)
        {
            Console.WriteLine($"strings separadas:{s}");
        }

        for (int i = 0; i < textoS.Length; i++)
        {
            if (textoS[i].IndexOf('X') != -1)
            {
                textoS[i] = textoS[i].Replace('X', ' ');
            }
        }
        #endregion

        #region 3 - Listas e Operações 
        var NovaLista = textoS.ToList().Where(X => X == "PT ").ToList();

        string x = String.Join(",", NovaLista);
        Console.WriteLine($"o valor da lista apos o filtro é:{x}");
        #endregion

        #region 4 – Tipos
        string strValor = "7";
        int intValor = 0;
        if (!int.TryParse(strValor, out intValor))
        {
            Console.WriteLine("conversão deu ruim");
        }
        else
        {
            Console.WriteLine($"conversão deu bom para inteiro: {intValor}");
        }

        string strDecimal = "3.14";
        decimal decimalValor = 0;
        if (!decimal.TryParse(strDecimal, out decimalValor))
        {
            Console.WriteLine("conversão deu ruim");
        }
        else
        {
            Console.WriteLine($"conversão deu bom para decimal: {decimalValor}");
        }

        string strDouble = "3.14";
        double doubleValor = 0;
        if (!double.TryParse(strDouble, out doubleValor))
        {
            Console.WriteLine("conversão deu ruim");
        }
        else
        {
            Console.WriteLine($"conversão deu bom para double: {doubleValor}");
        }

        string strFloat = "3.14";
        float floatValor = 0;
        if (!float.TryParse(strFloat, out floatValor))
        {
            Console.WriteLine("conversão deu ruim");
        }
        else
        {
            Console.WriteLine($"conversão deu bom para float: {floatValor}");
        }

        decimal decimalDeclarado = 3.14M;
        double doubleDeclarado = 3.14;
        float floatDeclarado = 3.14F;
        Console.WriteLine($"Decimal: {decimalDeclarado}, Double: {doubleDeclarado}, Float: {floatDeclarado}");
        #endregion

        #region 7 - Tipos de Loop e Listas
        int index = 0;
        var listaValores = new List<Valores>
        {
            new Valores("1", 1, 1.11M, 1.12, 1.13F),
            new Valores("2", 2, 2.21M, 2.22, 2.23F),
            new Valores("3", 3, 3.31M, 3.32, 3.33F),
            new Valores("4", 4, 4.41M, 4.42, 4.43F),
            new Valores("5", 5, 5.51M, 5.52, 5.53F)
        };

        listaValores.Add(new Valores("6", 6, 6.61M, 6.62, 6.63F));

        foreach (var valor in listaValores)
        {
            Console.WriteLine($"StrValor: {valor.StrValor}, IntValor: {valor.IntValor}, DecimalValor: {valor.DecimalValor}, DoubleValor: {valor.DoubleValor}, FloatValor: {valor.FloatValor}");
        }

        for (int i = 0; i < listaValores.Count; i++)
        {
            var valor = listaValores[i];
            Console.WriteLine($"[For] StrValor: {valor.StrValor}, IntValor: {valor.IntValor}, DecimalValor: {valor.DecimalValor}, DoubleValor: {valor.DoubleValor}, FloatValor: {valor.FloatValor}");
        }

        while (index < listaValores.Count)
        {
            var valor = listaValores[index];
            Console.WriteLine($"[While] StrValor: {valor.StrValor}, IntValor: {valor.IntValor}, DecimalValor: {valor.DecimalValor}, DoubleValor: {valor.DoubleValor}, FloatValor: {valor.FloatValor}");
            index++;
        }
        #endregion

        #region 8

        var novaClasse = new NovaClasse("Leonardo", 19, "Estudante");
        novaClasse.ExibirInformacoes();

        #endregion

        #region 9
        TiposEnum tipo = TiposEnum.Tipo2;
        switch (tipo)
        {
            case TiposEnum.Tipo1:
                Console.WriteLine($"{TiposEnum.Tipo1} selecionado.");
                break;
            case TiposEnum.Tipo2:
                Console.WriteLine($"{TiposEnum.Tipo2} selecionado.");
                break;
            case TiposEnum.Tipo3:
                Console.WriteLine($"{TiposEnum.Tipo3} selecionado.");
                break;
            default:
                Console.WriteLine("Tipo padrão selecionado.");
                break;
        }
        #endregion
    }
}

#region 5 - Classes
public class Valores
{
    public string StrValor { get; set; }
    public int IntValor { get; set; }
    public decimal DecimalValor { get; set; }
    public double DoubleValor { get; set; }
    public float FloatValor { get; set; }

    public Valores(string strValor, int intValor, decimal decimalValor, double doubleValor, float floatValor)
    {
        StrValor = strValor;
        IntValor = intValor;
        DecimalValor = decimalValor;
        DoubleValor = doubleValor;
        FloatValor = floatValor;
    }
}
#endregion

#region 6 - Metodos
public class Conversor
{
    public int ConverterParaInt(string valor)
    {
        int intValor;
        if (int.TryParse(valor, out intValor))
        {
            return intValor;
        }
        throw new Exception("Falha na conversão para int.");
    }

    public decimal ConverterParaDecimal(string valor)
    {
        decimal decimalValor;
        if (decimal.TryParse(valor, out decimalValor))
        {
            return decimalValor;
        }
        throw new Exception("Falha na conversão para decimal.");
    }

    public double ConverterParaDouble(string valor)
    {
        double doubleValor;
        if (double.TryParse(valor, out doubleValor))
        {
            return doubleValor;
        }
        throw new Exception("Falha na conversão para double.");
    }

    public float ConverterParaFloat(string valor)
    {
        float floatValor;
        if (float.TryParse(valor, out floatValor))
        {
            return floatValor;
        }
        throw new Exception("Falha na conversão para float.");
    }
}
#endregion


#region 9
public enum TiposEnum
{
    Tipo1 = 1,
    Tipo2 = 2,
    Tipo3 = 3
}
#endregion