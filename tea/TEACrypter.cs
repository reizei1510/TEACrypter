namespace tea
{
    internal class TEACrypter
    {
        public void Crypt(uint[] data, uint[] key, bool decrypt = false)
        {
            uint sum = 0;
            uint delta = 0x9e3779b9;

            if (decrypt)
            {
                sum = delta << 5;
                for (int i = 0; i < 32; i++)
                {
                    data[1] -= ((data[0] << 4) + key[2]) ^ (data[0] + sum) ^ ((data[0] >> 5) + key[3]);
                    data[0] -= ((data[1] << 4) + key[0]) ^ (data[1] + sum) ^ ((data[1] >> 5) + key[1]);
                    sum -= delta;
                }
            }
            else
            {
                for (int i = 0; i < 32; i++)
                {
                    sum += delta;
                    data[0] += ((data[1] << 4) + key[0]) ^ (data[1] + sum) ^ ((data[1] >> 5) + key[1]);
                    data[1] += ((data[0] << 4) + key[2]) ^ (data[0] + sum) ^ ((data[0] >> 5) + key[3]);
                }
            }
        }
    }
}
