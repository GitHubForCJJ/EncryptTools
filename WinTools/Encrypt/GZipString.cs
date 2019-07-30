//-----------------------------------------------------------------------------------
// <copyright file="GZipString.cs" company="720U Enterprises">
// * copyright: (C) 2017 720U科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : fengguotao
// * fileName : GZipString.cs
// * history  : created by fengguotao 2017/3/14 17:26:17
// </copyright>
// <summary>
//   EastWestWalk.NetFrameWork.Common.Encrypt.GZipString
// </summary>
//-----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTools
{
    /// <summary>
    /// GZipString
    /// </summary>	
    public class GZipString
    {
        /// <summary>
        /// 将传入字符串以GZip算法压缩后，返回Base64编码字符
        /// </summary>
        /// <param name="rawString">需要压缩的字符串</param>
        /// <returns>压缩后的Base64编码的字符串</returns>
        public static string GZipCompressString(string rawString)
        {
            if (string.IsNullOrEmpty(rawString) || rawString.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                byte[] rawData = System.Text.Encoding.UTF8.GetBytes(rawString.ToString());
                byte[] zippedData = Compress(rawData);
                return Convert.ToBase64String(zippedData);
            }
        }

        /// <summary>
        /// 将传入字符串以GZip算法压缩后
        /// </summary>
        /// <param name="rawString">需要压缩的字符串</param>
        /// <returns>压缩后的Base64编码的字符串</returns>
        public static string CompressString(string rawString)
        {
            if (string.IsNullOrEmpty(rawString) || rawString.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                byte[] rawData = System.Text.Encoding.UTF8.GetBytes(rawString.ToString());
                byte[] zippedData = Compress(rawData);
                return System.Text.Encoding.UTF8.GetString(zippedData);
            }
        }

        /// <summary>
        /// GZip压缩
        /// </summary>
        /// <param name="rawData">数据包</param>
        /// <returns>压缩数据包</returns>
        public static byte[] Compress(byte[] rawData)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (GZipStream compressedzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
                {
                    compressedzipStream.Write(rawData, 0, rawData.Length);
                    compressedzipStream.Close();
                    return memoryStream.ToArray();
                }
            }
        }

        /// <summary>
        /// 将传入的二进制字符串资料以GZip算法解压缩
        /// </summary>
        /// <param name="gzipString">经GZip压缩后的二进制字符串</param>
        /// <returns>原始未压缩字符串</returns>
        public static string GZipDecompressString(string gzipString)
        {
            if (string.IsNullOrEmpty(gzipString) || gzipString.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                byte[] zippedData = Convert.FromBase64String(gzipString);
                return System.Text.Encoding.UTF8.GetString(Decompress(zippedData));
            }
        }

        /// <summary>
        /// 将传入的二进制字符串资料以GZip算法解压缩
        /// </summary>
        /// <param name="gzipString">经GZip压缩后的二进制字符串</param>
        /// <returns>原始未压缩字符串</returns>
        public static string DecompressString(string gzipString)
        {
            if (string.IsNullOrEmpty(gzipString) || gzipString.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                byte[] zippedData = System.Text.Encoding.UTF8.GetBytes(gzipString);
                return System.Text.Encoding.UTF8.GetString(Decompress(zippedData));
            }
        }

        /// <summary>
        /// GZIP解压
        /// </summary>
        /// <param name="gzipData">数据包</param>
        /// <returns>解压数据包</returns>
        public static byte[] Decompress(byte[] gzipData)
        {
            using (MemoryStream memoryStream = new MemoryStream(gzipData))
            {
                using (GZipStream compressedzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    MemoryStream outBuffer = new MemoryStream();
                    byte[] block = new byte[1024];
                    while (true)
                    {
                        int bytesRead = compressedzipStream.Read(block, 0, block.Length);
                        if (bytesRead <= 0)
                            break;
                        else
                            outBuffer.Write(block, 0, bytesRead);
                    }

                    compressedzipStream.Close();
                    return outBuffer.ToArray();
                }
            }
        }
    }
}
