using System;

namespace BilibiliUtility
{
    public static class AvBvHelper
    {
        private const int Xor = 177451812;

        private const long Add = 8728348608;

        private static readonly byte[] Table = { 102, 90, 111, 100, 82, 57, 88, 81, 68, 83, 85, 109, 50, 49, 121, 67, 107, 114, 54,
                                                 122, 66, 113, 105, 118, 101, 89, 97, 104, 56, 98, 116, 52, 120, 115, 87, 112, 72, 110,
                                                 74, 69, 55, 106, 76, 53, 86, 71, 51, 103, 117, 77, 84, 75, 78, 80, 65, 119, 99, 70 };

        public static unsafe string Av2Bv(long av)
        {
            new Span<byte>().IndexOf<byte>(123);
            fixed (byte* table = Table)
            {
                byte* result = stackalloc byte[12] { 66, 86, 49, 0, 0, 52, 0, 49, 0, 55, 0, 0 };
                av = (av ^ Xor) + Add;
                result[11] = table[av / 1 % 58];
                result[10] = table[av / 58 % 58];
                result[3] = table[av / 3364 % 58];
                result[8] = table[av / 195112 % 58];
                result[4] = table[av / 11316496 % 58];
                result[6] = table[av / 656356768 % 58];
                return new string((sbyte*)result);
            }
        }

        public static unsafe int Bv2Av(string bv)
        {
            fixed (byte* b = Table)
            {
                Span<byte> table = new Span<byte>(b, 58);
                long sum = 0;
                sum += table.IndexOf((byte)bv[11]);
                sum += table.IndexOf((byte)bv[10]) * 58;
                sum += table.IndexOf((byte)bv[3]) * 3364;
                sum += table.IndexOf((byte)bv[8]) * 195112;
                sum += table.IndexOf((byte)bv[4]) * 11316496;
                sum += table.IndexOf((byte)bv[6]) * 656356768;
                return (int)((sum - Add) ^ Xor);
            }
        }
    }
}
