using System;
using System.Collections.Generic;

namespace Client
{
    public class RSA
    {

        private int p; //destroy
        private int q; //destroy
        private int phi; //destroy
        private int n;
        private int e;
        private int d;

        private struct ExtendedEuclideanResult
        {
            public int u1;
            public int u2;
            public int gcd;
        }

        public RSA()
        {
            InitKeyData();
        }

        private void InitKeyData()
        {
            Random random = new Random();

            this.p = 31;
            this.q = 23;
            this.n = (int)(this.p * this.q);
            this.phi = (int)((p - 1) * (q - 1));
            List<int> possibleE = GetAllPossibleE(this.phi);

            do
            {
                this.e = possibleE[random.Next(0, possibleE.Count)];
                this.d = ExtendedEuclide(this.e % this.phi, this.phi).u1;
            } while (this.d < 0);
        }

        public int GetNKey()
        {
            return this.n;
        }

        public void SetNKey(int n)
        {
            this.n = n;
        }

        public int GetDKey()
        {
            return this.d;
        }

        public void SetDKey(int d)
        {
            this.d = d;
        }

        public int GetEKey()
        {
            return this.e;
        }

        public void SetEKey(int e)
        {
            this.e = e;
        }

        public string encode(string text)
        {
            string outStr = "";
            List<int> list = new List<int>();
            foreach (char c in text)
                list.Add(Convert.ToInt32(c));

            foreach (int value in list)
            {
                int encryptedValue = ModuloPow(value, this.e, this.n);
                outStr += encryptedValue + "|";
            }

            return outStr;
        }

        public string decode(string text)
        {
            string outStr = "";
            int[] arr = GetDecArrayFromText(text);

            List<String> list = new List<string>();

            int j = 0;
            foreach (int i in arr)
            {
                int decryptedValue = ModuloPow(i, this.d, this.n);
                list.Add(Convert.ToChar(decryptedValue).ToString());
                j++;
            }

            foreach (string s in list)
                outStr += s;

            return outStr;
        }

        private int[] GetDecArrayFromText(string text)
        {
            int i = 0;
            foreach (char c in text)
            {
                if (c == '|')
                {
                    i++;
                }
            }

            int[] result = new int[i];
            i = 0;

            string tmp = "";

            foreach (char c in text)
            {
                if (c != '|')
                {
                    tmp += c;
                }
                else
                {
                    result[i] = int.Parse(tmp);
                    i++;
                    tmp = "";
                }
            }

            return result;
        }

        static int ModuloPow(int value, int pow, int modulo)
        {
            int result = value;
            for (int i = 0; i < pow - 1; i++)
            {
                result = (result * value) % modulo;
            }
            return result;
        }

        /// Получить все варианты для e
        static List<int> GetAllPossibleE(int phi)
        {
            List<int> result = new List<int>();

            for (ushort i = 2; i < phi; i++)
            {
                if (ExtendedEuclide(i, phi).gcd == 1)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// u1 * a + u2 * b = u3
        /// </summary>
        /// <param name="a">Число a</param>
        /// <param name="b">Модуль числа</param>
        private static ExtendedEuclideanResult ExtendedEuclide(int a, int b)
        {
            int u1 = 1;
            int u3 = a;
            int v1 = 0;
            int v3 = b;

            while (v3 > 0)
            {
                int q0 = u3 / v3;
                int q1 = u3 % v3;

                int tmp = v1 * q0;
                int tn = u1 - tmp;
                u1 = v1;
                v1 = tn;

                u3 = v3;
                v3 = q1;
            }

            int tmp2 = u1 * (a);
            tmp2 = u3 - (tmp2);
            int res = tmp2 / (b);

            ExtendedEuclideanResult result = new ExtendedEuclideanResult()
            {
                u1 = u1,
                u2 = res,
                gcd = u3
            };

            return result;
        }
    }
}
