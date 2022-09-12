using System;
using System.Collections.Generic;
using System.Numerics;

namespace KEP_Diffie_Hellman
{
    class DH
    {
        public static void GeneratePN(ref uint n, ref uint g)
        {
            n = FermaTest();
            g = GetPrimitiveRoot(n);
        }
        /// <summary>
        /// Вычисление открытого значения для генерация ключа.
        /// </summary>
        /// <param name="g">Основание (первообразный корень модуля n)</param>
        /// <param name="n">Модуль</param>
        /// <param name="xy">Закрытое значение</param>
        /// <returns></returns>
        public static uint GetOpenValue(uint g, uint n, uint xy)
        {
            return (uint)BigInteger.ModPow(g, xy, n);
        }
        /// <summary>
        /// Вычисление ключа.
        /// </summary>
        /// <param name="XY">Открытые значение</param>
        /// <param name="xy">Закрытые значение</param>
        /// <param name="n">Модуль</param>
        /// <returns></returns>
        public static uint GetKey(uint XY, uint xy, uint n)
        {
            return (uint)BigInteger.ModPow(XY, xy, n);
        }

        /// <summary>
        /// Тест ферма на простоту.
        /// </summary>
        /// <returns>Выдаёт простое число в диапазоне от 0 до 2^32 - 1</returns>
        private static uint FermaTest()
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            uint n = (uint)(rnd.Next(0, int.MaxValue) + rnd.Next(0, int.MaxValue));
            for (uint a = 1; a < 100; a++)
                while (BigInteger.ModPow(a, n - 1, n) != 1)
                    n = (uint)(rnd.Next(0, int.MaxValue) + rnd.Next(0, int.MaxValue));
            return n;
        }
        /// <summary>
        /// Вычисление первообразного корня по модулю p.
        /// </summary>
        /// <param name="p">Простой модуль p</param>
        /// <returns></returns>
        private static uint GetPrimitiveRoot(uint p)
        {
            var fact = new List<uint>();
            
            uint phi = p - 1, n = phi;
            for (uint i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    fact.Add(i);
                    while (n % i == 0)
                        n /= i;
                }
            if (n > 1)
                fact.Add(n);

            for (uint g = 2; g <= p; g++)
            {
                bool ok = true;
                for (int i = 0; i < fact.Count && ok; i++)
                    ok &= BigInteger.ModPow(g, phi / fact[i], p) != 1;
                if (ok) return g;
            }
            return 1;
        }
    }
}