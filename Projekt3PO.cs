using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Projekt3PO
{
    public partial class Projekt3PO : Form
    {
        public Projekt3PO()
        {
            InitializeComponent();

            mkpbDrawing.Width = 1240;
            mkpbDrawing.Height = 628;
            mkbm = new Bitmap(mkpbDrawing.Width, mkpbDrawing.Height);
            mkg = Graphics.FromImage(mkbm);
            mkg.Clear(Color.White);
            mkpbDrawing.Image = mkbm;
        }

        Bitmap mkbm;
        Graphics mkg;
        bool mkpaint = false;
        Point mkpx, mkpy;
        Pen mkp = new Pen(Color.Black, 3);
        Pen mkErase = new Pen(Color.White, 10);
        int mkindex;
        int mkx, mky, mksX, mksY, mkcX, mkcY;

        ColorDialog mkcd = new ColorDialog();
        Color mkNewColor;

        private void mkpbDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            mkpaint = true;
            mkpy = e.Location;

            mkcX = e.X;
            mkcY = e.Y;

            mkDrawingSaved = false;
        }

        private void mkpbDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (mkpaint)
            {
                if (mkindex == 1)
                {
                    mkpx = e.Location;
                    mkg.DrawLine(mkp, mkpx, mkpy);
                    mkpy = mkpx;
                }
                if (mkindex == 2)
                {
                    mkpx = e.Location;
                    mkg.DrawLine(mkErase, mkpx, mkpy);
                    mkpy = mkpx;
                }
            }

            mkpbDrawing.Refresh();

            mkx = e.X;
            mky = e.Y;
            mksX = e.X - mkcX;
            mksY = e.Y - mkcY;
        }

        private void mkpbDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            mkpaint = false;

            mksX = mkx - mkcX;
            mksY = mky - mkcY;

            if (mkindex == 3)
            {
                mkg.DrawEllipse(mkp, mkcX, mkcY, mksX, mksY);
            }
            if (mkindex == 4)
            {
                mkg.DrawRectangle(mkp, mkcX, mkcY, mksX, mksY);
            }
            if (mkindex == 5)
            {
                mkg.DrawLine(mkp, mkcX, mkcY, mkx, mky);
            }
        }

        private void mkbtnPencil_Click(object sender, EventArgs e)
        {
            mkindex = 1;
        }

        private void mkbtnErase_Click(object sender, EventArgs e)
        {
            mkindex = 2;
        }

        private void mkbtnCircle_Click(object sender, EventArgs e)
        {
            mkindex = 3;
        }

        private void mkbtnRectangle_Click(object sender, EventArgs e)
        {
            mkindex = 4;
        }

        private void mkbtnLine_Click(object sender, EventArgs e)
        {
            mkindex = 5;
        }

        private void mkbtnCurveLine_Click(object sender, EventArgs e)
        {
            mkindex = 6;
        }

        private void mkbtnPainting_Click(object sender, EventArgs e)
        {
            mkindex = 7;
        }

        private void mkbtnSelect_Click(object sender, EventArgs e)
        {
            mkindex = 4;
        }

        private void mkbtnSelectColors_Click(object sender, EventArgs e)
        {
            mkpbDrawing.MouseClick += new MouseEventHandler(mkSelectColors!);
        }

        private void mkSelectColors(object sender, MouseEventArgs e)
        {
            Bitmap mkbm = new Bitmap(mkpbDrawing.Image);
            Color mkSelectColor = mkbm.GetPixel(e.X, e.Y);

            mkpbColor.BackColor = mkSelectColor;
            mkp.Color = mkSelectColor;

            mkpbDrawing.MouseClick -= mkSelectColors!;
        }

        static Point mkSetPoint(PictureBox mkpb, Point mkpt)
        {
            float mkpX = 1f * mkpb.Image.Width / mkpb.Width;
            float mkpY = 1f * mkpb.Image.Height / mkpb.Height;
            return new Point((int)(mkpt.X + mkpX), (int)(mkpt.Y + mkpY));
        }

        private void mkpbDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            if (mkindex == 7)
            {
                Point mkpoint = mkSetPoint(mkpbDrawing, e.Location);
                mkFill(mkbm, mkpoint.X, mkpoint.Y, mkNewColor);
            }
        }

        private void mkpbDrawing_Paint(object sender, PaintEventArgs e)
        {
            Graphics mkg = e.Graphics;

            if (mkpaint)
            {
                if (mkindex == 3)
                {
                    mkg.DrawEllipse(mkp, mkcX, mkcY, mksX, mksY);
                }
                if (mkindex == 4)
                {
                    mkg.DrawRectangle(mkp, mkcX, mkcY, mksX, mksY);
                }
                if (mkindex == 5)
                {
                    mkg.DrawLine(mkp, mkcX, mkcY, mkx, mky);
                }
            }

            mkDrawingModified = true;
        }


        private void mkValidate(Bitmap mkbm, Stack<Point> mksp, int mkx, int mky, Color mkOldColorValidate, Color mkNewColorValidate)
        {
            Color mkcx = mkbm.GetPixel(mkx, mky);
            if (mkcx == mkOldColorValidate)
            {
                mksp.Push(new Point(mkx, mky));
                mkbm.SetPixel(mkx, mky, mkNewColorValidate);
            }
        }

        public void mkFill(Bitmap mkbm, int mkx, int mky, Color mkNewColorFill)
        {
            Color mkOldColor = mkbm.GetPixel(mkx, mky);
            Stack<Point> mkpixel = new Stack<Point>();
            mkpixel.Push(new Point(mkx, mky));
            mkbm.SetPixel(mkx, mky, mkNewColorFill);
            if (mkOldColor == mkNewColorFill) return;

            while (mkpixel.Count > 0)
            {
                Point mkpt = (Point)mkpixel.Pop();
                if (mkpt.X > 0 && mkpt.Y > 0 && mkpt.X < mkbm.Width - 1 && mkpt.Y < mkbm.Height - 1)
                {
                    mkValidate(mkbm, mkpixel, mkpt.X - 1, mkpt.Y, mkOldColor, mkNewColorFill);
                    mkValidate(mkbm, mkpixel, mkpt.X, mkpt.Y - 1, mkOldColor, mkNewColorFill);
                    mkValidate(mkbm, mkpixel, mkpt.X + 1, mkpt.Y, mkOldColor, mkNewColorFill);
                    mkValidate(mkbm, mkpixel, mkpt.X, mkpt.Y + 1, mkOldColor, mkNewColorFill);
                }
            }
        }

        private void mkbtnEditColors_Click(object sender, EventArgs e)
        {
            mkcd.ShowDialog();
            mkNewColor = mkcd.Color;
            mkpbColor.BackColor = mkcd.Color;
            mkp.Color = mkcd.Color;
        }

        private void mkbtnBlack_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Black;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnGray_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Gray;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnDarkRed_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.DarkRed;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnCrimson_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Crimson;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnOrange_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Orange;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnGold_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Gold;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnDarkGreen_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.DarkGreen;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnTurquoise_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Turquoise;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnRoyalBlue_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.RoyalBlue;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnDarkMagenta_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.DarkMagenta;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnWhite_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.White;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnLightGray_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.LightGray;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnCoral_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Coral;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnPink_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Pink;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnKhaki_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Khaki;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnWheat_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.Wheat;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnLightGreen_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.LightGreen;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnLightSeaGreen_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.LightSeaGreen;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnLightSkyBlue_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.LightSkyBlue;
            mkpbColor.BackColor = mkp.Color;
        }

        private void mkbtnBlueViolet_Click(object sender, EventArgs e)
        {
            mkp.Color = Color.BlueViolet;
            mkpbColor.BackColor = mkp.Color;
        }

        private bool mkDrawingModified = false;
        private bool mkDrawingSaved = true;

        private void mkbtnNew_Click(object sender, EventArgs e)
        {
            if (!mkDrawingSaved)
            {
                DialogResult mkResult = MessageBox.Show("Czy chcesz zapisaæ zmiany przed zamkniêciem?", "Zapisywanie zmian",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (mkResult == DialogResult.Yes)
                {
                    mkSave();
                }
                else if (mkResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            mkNewForm();
        }

        private void mkNewForm()
        {
            this.Close();
            Application.Restart();
        }

        private void mkbtnOpen_Click(object sender, EventArgs e)
        {
            if (!mkDrawingSaved)
            {
                DialogResult mkResult = MessageBox.Show("Czy chcesz zapisaæ zmiany przed otwarciem nowego pliku?", "Zapisywanie zmian",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (mkResult == DialogResult.Yes)
                {
                    mkSave();
                }
                else if (mkResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            mkOpen();
        }

        private void mkOpen()
        {
            OpenFileDialog mkOpenFileDialog = new OpenFileDialog();
            mkOpenFileDialog.Filter = "Pliki graficzne (*.jpg)|*.jpg|Wszystkie pliki (*.*)|*.*";

            if (mkOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string mkSelectedFile = mkOpenFileDialog.FileName;

                Image mkImage = Image.FromFile(mkSelectedFile);

                int mkNewWidth = (int)(((double)mkpbDrawing.Height / (double)mkImage.Height) * mkImage.Width);
                int mkNewHeight = mkpbDrawing.Height;

                Image mkScaledImage = new Bitmap(mkImage, mkNewWidth, mkNewHeight);

                mkpbDrawing.Image = mkScaledImage;

                mkDrawingSaved = true;
                mkDrawingModified = false;
            }
        }

        private void mkbtnSave_Click(object sender, EventArgs e)
        {
            mkSave();
        }

        private void mkSave()
        {
            var mksfd = new SaveFileDialog();
            mksfd.Filter = "Plik obrazów (*.jpg)|*.jpg";
            if (mksfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap mkbtm = mkbm.Clone(new Rectangle(0, 0, mkpbDrawing.Width, mkpbDrawing.Height), mkbm.PixelFormat);
                mkbtm.Save(mksfd.FileName, ImageFormat.Jpeg);
            }

            mkDrawingModified = false;
            mkDrawingSaved = true;
        }

        private void mkbtnPrinter_Click(object sender, EventArgs e)
        {
            PrintDocument mkPrintDocument = new PrintDocument();
            mkPrintDocument.PrintPage += new PrintPageEventHandler(mkPrinter);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = mkPrintDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                mkPrintDocument.Print();
            }
        }

        private void mkPrinter(object sender, PrintPageEventArgs e)
        {
            Graphics mkg = e.Graphics!;
            Bitmap mkbm = new Bitmap(mkpbDrawing.Width, mkpbDrawing.Height);
            mkpbDrawing.DrawToBitmap(mkbm, new Rectangle(0, 0, mkpbDrawing.Width, mkpbDrawing.Height));
            mkg.DrawImage(mkbm, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void mkbtnCopy_Click(object sender, EventArgs e)
        {

        }

        private void mkbtnPaste_Click(object sender, EventArgs e)
        {

        }

        private void mkbtnUndo_Click(object sender, EventArgs e)
        {

        }

        private void mkbtnCut_Click(object sender, EventArgs e)
        {

        }

        private void Projekt3PO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mkDrawingSaved)
            {
                DialogResult mkResult = MessageBox.Show("Czy chcesz zapisaæ zmiany przed otwarciem nowego pliku?", "Zapisywanie zmian",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (mkResult == DialogResult.Yes)
                {
                    mkSave();
                }
                else if (mkResult == DialogResult.Cancel)
                {
                    return;
                }

                Application.Exit();
            }
        }
    }
}