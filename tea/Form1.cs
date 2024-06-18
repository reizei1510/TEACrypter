using System.Text;

namespace tea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string str = tbStr.Text;
            if (tbStr.Text != "")
            {
                uint[] key = GenerateRandomKey();
                lbKey.Text = KeyToString(key);

                tbEncryptedStr.Text = CryptStr(str, key);
                tbDecryptedStr.Text = CryptStr(tbEncryptedStr.Text, key, decrypt: true);
            }
        }

        string CryptStr(string str, uint[] key, bool decrypt = false)
        {
            string strBits = StrToBits(str);
            uint[][] data = BitsToBlocks(strBits);

            TEACrypter crypter = new TEACrypter();
            foreach (uint[] block in data)
            {
                crypter.Crypt(block, key, decrypt);
            }

            string strCryptedBits = BlocksToBits(data);
            string strCrypted = BitsToStr(strCryptedBits);

            return strCrypted;
        }

        string StrToBits(string str)
        {
            StringBuilder sbBits = new StringBuilder();
            foreach (char c in str)
            {
                string charBits = Convert.ToString(c, 2).PadLeft(8, '0');
                sbBits.Append(charBits);
            }
            if (sbBits.Length % 64 != 0)
            {
                sbBits.Insert(0, new string('0', 64 - sbBits.Length % 64));
            }

            return sbBits.ToString();
        }

        uint[][] BitsToBlocks(string strBits)
        {
            uint[][] data = new uint[strBits.Length / 64][];
            for (int i = 0; i <= data.GetUpperBound(0); i++)
            {
                data[i] = new uint[2];
            }
            for (int i = 0; i < strBits.Length; i += 64)
            {
                data[i / 64][0] = Convert.ToUInt32(strBits[i..(i + 32)], 2);
                data[i / 64][1] = Convert.ToUInt32(strBits[(i + 32)..(i + 64)], 2);
            }

            return data;
        }

        string BlocksToBits(uint[][] data)
        {
            StringBuilder sbBits = new StringBuilder();
            foreach (uint[] block in data)
            {
                foreach (uint cell in block)
                {
                    string strBlock = Convert.ToString(cell, 2);
                    sbBits.Append(new string('0', 32 - strBlock.Length));
                    sbBits.Append(strBlock);
                }
            }

            return sbBits.ToString();
        }

        string BitsToStr(string strBits)
        {
            StringBuilder sbStr = new StringBuilder();
            for (int i = 0; i < strBits.Length; i += 8)
            {
                int asciiValue = Convert.ToInt32(strBits[i..(i + 8)], 2);
                if (asciiValue != 0)
                {
                    sbStr.Append(Convert.ToChar(asciiValue));
                }
            }

            return sbStr.ToString();
        }

        uint[] GenerateRandomKey()
        {
            Random random = new Random();
            return new[] {
                (uint)(random.Next(0, int.MaxValue) + random.Next(0, int.MaxValue)),
                (uint)(random.Next(0, int.MaxValue) + random.Next(0, int.MaxValue)),
                (uint)(random.Next(0, int.MaxValue) + random.Next(0, int.MaxValue)),
                (uint)(random.Next(0, int.MaxValue) + random.Next(0, int.MaxValue))
            };
        }

        string KeyToString(uint[] key)
        {
            string strKey = "";
            for (int i = 0; i < key.Length; i++)
            {
                string keyBits = Convert.ToString(key[i], 16);
                strKey += keyBits + " ";
            }

            return strKey;
        }
    }
}
