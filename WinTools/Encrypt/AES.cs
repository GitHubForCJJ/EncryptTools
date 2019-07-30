//-----------------------------------------------------------------------------------
// <copyright file="AES.cs" company="720U Enterprises">
// * copyright: (C) 2017 720U科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : rongbo
// * fileName : AES.cs
// * history  : created by rongbo 2017/3/13 14:11:33
// </copyright>
// <summary>
//   EastWestWalk.NetFrameWork.Common.Encrypt.AES
// </summary>
//-----------------------------------------------------------------------------------

using System;
using System.Security.Cryptography;
using System.Text;

namespace WinTools
{
    /// <summary>
    /// AES
    /// </summary>	
    public class AES
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="toEncrypt">数据字符</param>
        /// <returns>密文</returns>
        public static string Encrypt(string toEncrypt)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);

            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="toDecrypt">密文</param>
        /// <returns>结果</returns>
        public static string Decrypt(string toDecrypt)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }
    }
}