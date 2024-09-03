using System;
using System.Collections.Generic;

public class Solution
{
    /// <summary>
    /// Verifica se existe uma subarray de pelo menos dois elementos consecutivos em `nums`
    /// cuja soma dos elementos seja um múltiplo de `k`.
    /// </summary>
    /// <param name="nums">Array de inteiros a ser analisado.</param>
    /// <param name="k">Número inteiro usado para verificar se a soma de uma subarray é múltiplo.</param>
    /// <returns>Retorna `true` se existir uma subarray cuja soma seja múltiplo de `k`, caso contrário `false`.</returns>
    public bool SubarraySum(int[] nums, int k)
    {
       
        var restos = new Dictionary<int, int>();
        restos[0] = -1;

        int somaPrefixada = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            somaPrefixada += nums[i];

            int resto = somaPrefixada % k;
            if (resto < 0) resto += k;

            if (restos.ContainsKey(resto))
            {
                if (i - restos[resto] > 1) 
                {
                    return true;
                }
            }
            else
            {
                restos[resto] = i;
            }
        }

        return false;
    }

  
    public static void Main(string[] args)
    {
        var solution = new Solution();

      
        int[] nums = { 23, 2, 6, 4, 7 };
        int k = 6;
        bool result = solution.SubarraySum(nums, k);

 
        Console.WriteLine($"Resultado: {result}");
    }
}
