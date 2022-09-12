using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace EnviodeCorreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(textCorreo.Text);
                mail.To.Add(textReceptor.Text);
                mail.Subject = (textAsunto.Text);
                mail.Body = memoMensaje.Text;

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(textCorreo.Text, textContrasenha.Text);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Correo Enviado", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtvalorQr.Text.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero),Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
            pictureImageQr.BackgroundImage = imagen;
            imagen.Save("imagen.png", ImageFormat.Png);
            btnGuardar.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //funcion para guardar el qr
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Image image = (Image)pictureImageQr.BackgroundImage.Clone();
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.AddExtension = true;
            //saveFileDialog.Filter = "Image PNG(*.png)|*.png";
            //saveFileDialog.ShowDialog();
            //if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            //{
            //    image.Save(saveFileDialog.FileName, ImageFormat.Png);
            //}
            //image.Dispose();

            Image img = (Image)pictureImageQr.BackgroundImage.Clone();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Image PNG(*.png)|*.png";
            saveFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(saveFileDialog.FileName)) 
            {
                img.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
            img.Dispose();
        }

        private void txtOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureImageQr.ImageLocation = open.FileName;
            }
        }

        private void btnLeerQr_Click(object sender, EventArgs e)
        {
            Bitmap imagen = new Bitmap(pictureImageQr.Image);
            BarcodeReader lectura = new BarcodeReader { AutoRotate = true };
            Result result = lectura.Decode(imagen);
            string texto = result.ToString().Trim();
            txtvalorQr.Text = texto;
        }

        private void pictureImageQr_Click(object sender, EventArgs e)
        {

        }

        private void txtvalorQr_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {   

            var ImageType = "Png";

            if (rbPng.Checked == true)
            {
                ImageType = rbPng.ToString();
            }
            else if(rbJpg.Checked == true)
            {
                ImageType = rbJpg.ToString();
            }
            else if (rbPmp.Checked == true)
            {
                ImageType = rbPmp.ToString();
            }

            //obtener formato de imagen de enumeracion
            //var imageformat = (BarCodeImageFormat)Enum.Parse(typeof(BarcodeImageFormat))
            var encodeType = EncodeHintType.CODE128_FORCE_CODESET_B;

            //obtener el tipo de codigo de barras seleccionado por el usuario
            Barcode barcode = new Barcode();
            barcode.Text = txtTexto.Text;
            barcode.BaseEncodeType = encodeType.ToString();
            barcode.BarCodeImageFormat = ImageType;

            if (!string.IsNullOrEmpty(txtvalorQr.Text))
            {
                switch (txtvalorQr.Text)
                {
                    case "Code128":
                        encodeType = EncodeHintType.CODE128_FORCE_CODESET_B;
                    break;
                    case "DATAMATRIX":
                        encodeType = EncodeHintType.DATA_MATRIX_SHAPE;
                        break;
                    case "PDF417":
                        encodeType = EncodeHintType.PDF417_COMPACTION;
                        break;
                    case "QR":
                        encodeType = EncodeHintType.QR_COMPACT;
                        break;
                }
            }

            try 
            {
                string imagePath = "";
                if (rbGOptions.Checked == true)
                {
                    //genere un codigo de barras con opciones adicionales y obtenga la ruta de la imagen
                    imagePath = GenerateBarcodeWithOptions(barcode);
                }
                else
                {
                    imagePath = GenerateBarcode(barcode);
                }
                //Uri fileUri = new Uri(Pat)

            }
            catch(Exception err)
            {

            }
        }

        private string GenerateBarcode(Barcode barcode)
        {
            throw new NotImplementedException();
        }

        private string GenerateBarcodeWithOptions(Barcode barcode)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        //    public void EnviarCorreo()
        //    {
        //        var smtpClient = new SmtpClient("servidorsmtp.com")

        //        {

        //            Port = 587,

        //            Credentials = new NetworkCredential(@"usuario", @"contraseña"),

        //            EnableSsl = true,

        //        };



        //        var mail = new MailMessage()

        //        {

        //            From = new MailAddress(“asdasd@gmail.com”),

        //            Subject = "Asunto",

        //            Body = “hola mundo”,

        //            IsBodyHtml = true,

        //            To =
        //                    {
        //                        new MailAddress(“afasdfds@gmail.com”),
        //                    } ,

        //            Bcc =

        //                    {

        //                        new MailAddress(“dsaadasd@gmail.com”)

        //                    },

        //            Attachments =

        //                    {

        //                        new Attachment(stream, "adjunto.pdf", "application/pdf")

        //                    },

        //        };



        //        smtpClient.Send(mail);


        //    }
    }
}
