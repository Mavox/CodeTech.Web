using Microsoft.AspNetCore.Components;
using System;
using System.Globalization;

namespace CodeTech.Web.App.Pages
{
    public partial class Uid : ComponentBase
    {
        public Uid()
        {
            GenerateGuid();
        }

        static string errorMessage = "Invalid GUID";
        Guid? guid;
        public string GuidNormalFormat
        {
            get
            {
                return guid?.ToString() ?? errorMessage;
            }
            set
            {
                try
                {
                    guid = new Guid(value);
                }
                catch
                {
                    guid = null;
                }
            }
        }

        public string GuidHexaDecimalFormat
        {
            get
            {
                var bytes = guid?.ToByteArray();
                return bytes != null ? BitConverter.ToString(bytes).Replace("-", string.Empty) : errorMessage;
            }
            set
            {
                try
                {
                    if (value.Length % 2 == 0)
                    {

                        byte[] data = new byte[value.Length / 2];
                        for (int index = 0; index < data.Length; index++)
                        {
                            string byteValue = value.Substring(index * 2, 2);
                            data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                        }

                        guid = new Guid(data);
                    }
                }
                catch
                {
                    guid = null;
                }
            }
        }

        public string GuidBase64Format
        {
            get
            {
                return guid != null ? Convert.ToBase64String(guid.Value.ToByteArray()) : errorMessage;
            }
            set
            {
                try
                {
                    var bytes = Convert.FromBase64String(value);
                    guid = new Guid(bytes);
                }
                catch
                {
                    guid = null;
                }
            }
        }

        public void GenerateGuid()
        {
            this.guid = Guid.NewGuid();
        }
    }
}
