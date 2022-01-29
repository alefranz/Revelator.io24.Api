﻿using System.Text;

namespace Revelator.io24.Api.Helpers
{
    public static class PackageHelper
    {
        public static byte[] GetHeader()
        {
            return new byte[] { 0x55, 0x43, 0x00, 0x01 };
        }

        public static byte[] GetDeviceCustomBytes()
        {
            //Seems to always be this from the device (and inversed pair from service).
            //Not sure what this is.
            //66:00:68:00 -> Incomming from service
            //68:00:66:00 -> Outgoing to service
            return new byte[] { 0x68, 0x00, 0x66, 0x00 };
        }

        public static bool IsUcNetPackage(byte[] data, int index = 0)
        {
            if (data is null || data.Length - index < 4)
                return false;

            return data[index] == 0x55 && data[index + 1] == 0x43 && data[index + 2] == 0x00 && data[index + 3] == 0x01;
        }

        public static string GetMessageType(byte[] data)
        {
            return Encoding.ASCII.GetString(data[6..8]);
        }

        public static void ApplyBytes(byte[] message, byte[] data, int index, int? length = null)
        {
            var len = length ?? data.Length;
            for (int i = 0; i < len; i++)
            {
                message[index + i] = data[i];
            }
        }

        public static IEnumerable<byte[]> ChuncksByIndicator(byte[] data)
        {
            var indexes = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                if (PackageHelper.IsUcNetPackage(data, i))
                    indexes.Add(i);
            }

            if (indexes.Count == 0)
                yield break;

            indexes.Add(data.Length);

            for (int i = 1; i < indexes.Count; i++)
            {
                var startI = indexes[i - 1];
                var stopI = indexes[i];

                yield return data[startI..stopI];
            }
        }
    }
}
