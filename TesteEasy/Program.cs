using System;

public class Solution
{
    /// <summary>
    /// Verifica se existe uma subarray de pelo menos dois elementos consecutivos em `nums`
    /// cuja soma dos elementos seja um múltiplo de `k`.
    /// </summary>
    /// <param name="nums">Array de inteiros a ser analisado.</param>
    /// <param name="k">Número inteiro usado para verificar se a soma de uma subarray é múltiplo.</param>
    /// <returns>Retorna `true` se existir uma subarray cuja soma seja múltiplo de `k`, caso contrário `false`.</returns>
    public bool CheckSubarraySum(int[] nums, int k)
    {     
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int sum = nums[i];
         
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum += nums[j];       
                if (sum % k == 0)                
                    return true;
                
            }
        }        
        return false;
    }


    public static void Main(string[] args)
    {
        var solution = new Solution();
   
        int[] nums = { 23, 2, 6, 4, 7 };
        int k = 6;
        bool result = solution.CheckSubarraySum(nums, k);

        Console.WriteLine($"Resultado: {result}");
    }
}
