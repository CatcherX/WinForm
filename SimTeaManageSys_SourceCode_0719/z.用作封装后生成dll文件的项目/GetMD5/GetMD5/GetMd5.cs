using System.Security.Cryptography;
using System.Text;

namespace GetMD5
{
    /// <summary>
    /// 获取MD5的类
    /// </summary>
    public class GetMd5
    {
        /// <summary>
        /// 获得32位的MD5加密
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <returns>返回值</returns>
        public static string GetMd5_32(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(input));
            var sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

    }
}
