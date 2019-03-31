using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NormalizeImage
{
    public sealed class Webp : IDisposable
    {
        public Bitmap Load(string pathFileName)
        {
            try
            {
                //Считаывание webp файла
                byte[] rawWebP = File.ReadAllBytes(pathFileName);

                return Decode(rawWebP);
            }
            catch (Exception ex) { throw new Exception(ex.Message + "\r\nIn Webp.Load"); }
        }
        public Bitmap Decode(byte[] rawWebP)
        {
            int imgWidth;
            int imgHeight;
            int outputSize;
            Bitmap bmp = null;
            BitmapData bmpData = null;
            GCHandle pinnedWebP = GCHandle.Alloc(rawWebP, GCHandleType.Pinned);

            try
            {
                //Получение размера изображения
                IntPtr ptrData = pinnedWebP.AddrOfPinnedObject();
                if (UnsafeNativeMethods.WebPGetInfo(ptrData, rawWebP.Length, out imgWidth, out imgHeight) == 0)
                    throw new Exception("Can´t get information of WebP");

                //Создание BitmapData
                bmp = new Bitmap(imgWidth, imgHeight, PixelFormat.Format24bppRgb);
                bmpData = bmp.LockBits(new Rectangle(0, 0, imgWidth, imgHeight), ImageLockMode.WriteOnly, bmp.PixelFormat);

                //Декодирование webp
                outputSize = bmpData.Stride * imgHeight;
                if (UnsafeNativeMethods.WebPDecodeBGRInto(ptrData, rawWebP.Length, bmpData.Scan0, outputSize, bmpData.Stride) == 0)
                    throw new Exception("Can´t decode WebP");

                return bmp;
            }
            catch (Exception ex) { throw new Exception(ex.Message + "\r\nIn Webp.Decode"); }
            finally
            {
                //Освобождение BitmapData
                if (bmpData != null)
                    bmp.UnlockBits(bmpData);

                //Освобождение памяти
                if (pinnedWebP.IsAllocated)
                    pinnedWebP.Free();
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
    [SuppressUnmanagedCodeSecurityAttribute]
    internal sealed partial class UnsafeNativeMethods
    {
        public static int WebPGetInfo(IntPtr data, int data_size, out int width, out int height)
        {
            switch (IntPtr.Size)
            {
                case 4:
                    return WebPGetInfo_x86(data, (UIntPtr)data_size, out width, out height);
                case 8:
                    return WebPGetInfo_x64(data, (UIntPtr)data_size, out width, out height);
                default:
                    throw new InvalidOperationException("Invalid platform. Can not find proper function");
            }
        }
        [DllImport("libwebp_x86.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "WebPGetInfo")]
        private static extern int WebPGetInfo_x86([InAttribute()] IntPtr data, UIntPtr data_size, out int width, out int height);
        [DllImport("libwebp_x64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "WebPGetInfo")]
        private static extern int WebPGetInfo_x64([InAttribute()] IntPtr data, UIntPtr data_size, out int width, out int height);

        public static int WebPDecodeBGRInto(IntPtr data, int data_size, IntPtr output_buffer, int output_buffer_size, int output_stride)
        {
            switch (IntPtr.Size)
            {
                case 4:
                    return WebPDecodeBGRInto_x86(data, (UIntPtr)data_size, output_buffer, output_buffer_size, output_stride);
                case 8:
                    return WebPDecodeBGRInto_x64(data, (UIntPtr)data_size, output_buffer, output_buffer_size, output_stride);
                default:
                    throw new InvalidOperationException("Invalid platform. Can not find proper function");
            }
        }
        [DllImport("libwebp_x86.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "WebPDecodeBGRInto")]
        private static extern int WebPDecodeBGRInto_x86([InAttribute()] IntPtr data, UIntPtr data_size, IntPtr output_buffer, int output_buffer_size, int output_stride);
        [DllImport("libwebp_x64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "WebPDecodeBGRInto")]
        private static extern int WebPDecodeBGRInto_x64([InAttribute()] IntPtr data, UIntPtr data_size, IntPtr output_buffer, int output_buffer_size, int output_stride);

    }
}
