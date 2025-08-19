using System;
using System.IO;
using QRCoder; 

class Program
{
    static void Main(string[] args)
    {
        string textoParaQRCode = "https://wa.me/5511987654321";

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(textoParaQRCode, QRCodeGenerator.ECCLevel.Q);

        PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);

        string caminhoArquivo = "meu_qrcode.png";
        File.WriteAllBytes(caminhoArquivo, qrCodeAsPngByteArr);

        Console.WriteLine($"QR Code salvo em: {Path.GetFullPath(caminhoArquivo)}");
    }
}