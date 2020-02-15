using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace PrimePOS
{
    class CImage
    {
        public static Image ArrayTextToImage(object ArrayText)
        {
            try
            {
                //byte[] Array = Encoding.ASCII.GetBytes(DBText);
                byte[] Array = (byte[])ArrayText;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(Array, 0, Array.Length))
                {
                    ms.Write(Array, 0, Array.Length);

                    //Set image variable value using memory stream.
                    return Image.FromStream(ms, true);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static byte[] ImagePathToArray(string Path)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(Path);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
        }

        public static byte[] ImageToArray(Image image)
        {
            byte[] arr;
            Bitmap bitmap = new Bitmap(image);
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.ToArray();
            }
            return arr;
        }
    }
}
