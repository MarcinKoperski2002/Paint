using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projekt3PO
{
    partial class Projekt3PO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projekt3PO));
            mkpbDrawing = new PictureBox();
            mkbtnNew = new Button();
            mkbtnPencil = new Button();
            mkbtnErase = new Button();
            mkbtnBlueViolet = new Button();
            mkbtnDarkMagenta = new Button();
            mkbtnEditColors = new Button();
            mkbtnOrange = new Button();
            mkbtnLightSkyBlue = new Button();
            mkbtnRoyalBlue = new Button();
            mkbtnKhaki = new Button();
            mkbtnGold = new Button();
            mkbtnWheat = new Button();
            mkbtnDarkGreen = new Button();
            mkbtnLightGreen = new Button();
            mkbtnTurquoise = new Button();
            mkbtnLightSeaGreen = new Button();
            mkbtnBlack = new Button();
            mkbtnGray = new Button();
            mkbtnDarkRed = new Button();
            mkbtnCrimson = new Button();
            mkbtnWhite = new Button();
            mkbtnLightGray = new Button();
            mkbtnCoral = new Button();
            mkbtnPink = new Button();
            mkpbColor = new PictureBox();
            mkbtnOpen = new Button();
            mkbtnSave = new Button();
            mkbtnPrinter = new Button();
            mkbtnPaste = new Button();
            mkbtnCopy = new Button();
            mkbtnUndo = new Button();
            mkbtnCut = new Button();
            mkbtnPainting = new Button();
            mkbtnSelectColors = new Button();
            mkbtnLine = new Button();
            mkbtnRectangle = new Button();
            mkbtnCircle = new Button();
            mkbtnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)mkpbDrawing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mkpbColor).BeginInit();
            SuspendLayout();
            // 
            // mkpbDrawing
            // 
            mkpbDrawing.BackColor = SystemColors.ControlLightLight;
            mkpbDrawing.Location = new Point(12, 121);
            mkpbDrawing.Name = "mkpbDrawing";
            mkpbDrawing.Size = new Size(1240, 628);
            mkpbDrawing.TabIndex = 0;
            mkpbDrawing.TabStop = false;
            mkpbDrawing.Paint += mkpbDrawing_Paint;
            mkpbDrawing.MouseClick += mkpbDrawing_MouseClick;
            mkpbDrawing.MouseDown += mkpbDrawing_MouseDown;
            mkpbDrawing.MouseMove += mkpbDrawing_MouseMove;
            mkpbDrawing.MouseUp += mkpbDrawing_MouseUp;
            // 
            // mkbtnNew
            // 
            mkbtnNew.Image = Properties.Resources.add;
            mkbtnNew.Location = new Point(12, 12);
            mkbtnNew.Name = "mkbtnNew";
            mkbtnNew.Size = new Size(48, 48);
            mkbtnNew.TabIndex = 1;
            mkbtnNew.UseVisualStyleBackColor = true;
            mkbtnNew.Click += mkbtnNew_Click;
            // 
            // mkbtnPencil
            // 
            mkbtnPencil.Image = Properties.Resources.pencil;
            mkbtnPencil.Location = new Point(282, 12);
            mkbtnPencil.Name = "mkbtnPencil";
            mkbtnPencil.Size = new Size(48, 48);
            mkbtnPencil.TabIndex = 6;
            mkbtnPencil.UseVisualStyleBackColor = true;
            mkbtnPencil.Click += mkbtnPencil_Click;
            // 
            // mkbtnErase
            // 
            mkbtnErase.Image = Properties.Resources.rubber;
            mkbtnErase.Location = new Point(282, 66);
            mkbtnErase.Name = "mkbtnErase";
            mkbtnErase.Size = new Size(48, 48);
            mkbtnErase.TabIndex = 5;
            mkbtnErase.UseVisualStyleBackColor = true;
            mkbtnErase.Click += mkbtnErase_Click;
            // 
            // mkbtnBlueViolet
            // 
            mkbtnBlueViolet.BackColor = Color.BlueViolet;
            mkbtnBlueViolet.Location = new Point(1096, 66);
            mkbtnBlueViolet.Name = "mkbtnBlueViolet";
            mkbtnBlueViolet.Size = new Size(48, 48);
            mkbtnBlueViolet.TabIndex = 12;
            mkbtnBlueViolet.UseVisualStyleBackColor = false;
            mkbtnBlueViolet.Click += mkbtnBlueViolet_Click;
            // 
            // mkbtnDarkMagenta
            // 
            mkbtnDarkMagenta.BackColor = Color.DarkMagenta;
            mkbtnDarkMagenta.Location = new Point(1096, 12);
            mkbtnDarkMagenta.Name = "mkbtnDarkMagenta";
            mkbtnDarkMagenta.Size = new Size(48, 48);
            mkbtnDarkMagenta.TabIndex = 13;
            mkbtnDarkMagenta.UseVisualStyleBackColor = false;
            mkbtnDarkMagenta.Click += mkbtnDarkMagenta_Click;
            // 
            // mkbtnEditColors
            // 
            mkbtnEditColors.Image = Properties.Resources.painting;
            mkbtnEditColors.Location = new Point(1150, 13);
            mkbtnEditColors.Name = "mkbtnEditColors";
            mkbtnEditColors.Size = new Size(102, 102);
            mkbtnEditColors.TabIndex = 32;
            mkbtnEditColors.UseVisualStyleBackColor = true;
            mkbtnEditColors.Click += mkbtnEditColors_Click;
            // 
            // mkbtnOrange
            // 
            mkbtnOrange.BackColor = Color.Orange;
            mkbtnOrange.Location = new Point(826, 12);
            mkbtnOrange.Name = "mkbtnOrange";
            mkbtnOrange.Size = new Size(48, 48);
            mkbtnOrange.TabIndex = 34;
            mkbtnOrange.UseVisualStyleBackColor = false;
            mkbtnOrange.Click += mkbtnOrange_Click;
            // 
            // mkbtnLightSkyBlue
            // 
            mkbtnLightSkyBlue.BackColor = Color.LightSkyBlue;
            mkbtnLightSkyBlue.Location = new Point(1042, 66);
            mkbtnLightSkyBlue.Name = "mkbtnLightSkyBlue";
            mkbtnLightSkyBlue.Size = new Size(48, 48);
            mkbtnLightSkyBlue.TabIndex = 33;
            mkbtnLightSkyBlue.UseVisualStyleBackColor = false;
            mkbtnLightSkyBlue.Click += mkbtnLightSkyBlue_Click;
            // 
            // mkbtnRoyalBlue
            // 
            mkbtnRoyalBlue.BackColor = Color.RoyalBlue;
            mkbtnRoyalBlue.Location = new Point(1042, 12);
            mkbtnRoyalBlue.Name = "mkbtnRoyalBlue";
            mkbtnRoyalBlue.Size = new Size(48, 48);
            mkbtnRoyalBlue.TabIndex = 36;
            mkbtnRoyalBlue.UseVisualStyleBackColor = false;
            mkbtnRoyalBlue.Click += mkbtnRoyalBlue_Click;
            // 
            // mkbtnKhaki
            // 
            mkbtnKhaki.BackColor = Color.Khaki;
            mkbtnKhaki.Location = new Point(826, 66);
            mkbtnKhaki.Name = "mkbtnKhaki";
            mkbtnKhaki.Size = new Size(48, 48);
            mkbtnKhaki.TabIndex = 35;
            mkbtnKhaki.UseVisualStyleBackColor = false;
            mkbtnKhaki.Click += mkbtnKhaki_Click;
            // 
            // mkbtnGold
            // 
            mkbtnGold.BackColor = Color.Gold;
            mkbtnGold.Location = new Point(880, 12);
            mkbtnGold.Name = "mkbtnGold";
            mkbtnGold.Size = new Size(48, 48);
            mkbtnGold.TabIndex = 42;
            mkbtnGold.UseVisualStyleBackColor = false;
            mkbtnGold.Click += mkbtnGold_Click;
            // 
            // mkbtnWheat
            // 
            mkbtnWheat.BackColor = Color.Wheat;
            mkbtnWheat.Location = new Point(880, 66);
            mkbtnWheat.Name = "mkbtnWheat";
            mkbtnWheat.Size = new Size(48, 48);
            mkbtnWheat.TabIndex = 41;
            mkbtnWheat.UseVisualStyleBackColor = false;
            mkbtnWheat.Click += mkbtnWheat_Click;
            // 
            // mkbtnDarkGreen
            // 
            mkbtnDarkGreen.BackColor = Color.DarkGreen;
            mkbtnDarkGreen.Location = new Point(934, 12);
            mkbtnDarkGreen.Name = "mkbtnDarkGreen";
            mkbtnDarkGreen.Size = new Size(48, 48);
            mkbtnDarkGreen.TabIndex = 40;
            mkbtnDarkGreen.UseVisualStyleBackColor = false;
            mkbtnDarkGreen.Click += mkbtnDarkGreen_Click;
            // 
            // mkbtnLightGreen
            // 
            mkbtnLightGreen.BackColor = Color.LightGreen;
            mkbtnLightGreen.Location = new Point(934, 66);
            mkbtnLightGreen.Name = "mkbtnLightGreen";
            mkbtnLightGreen.Size = new Size(48, 48);
            mkbtnLightGreen.TabIndex = 39;
            mkbtnLightGreen.UseVisualStyleBackColor = false;
            mkbtnLightGreen.Click += mkbtnLightGreen_Click;
            // 
            // mkbtnTurquoise
            // 
            mkbtnTurquoise.BackColor = Color.Turquoise;
            mkbtnTurquoise.Location = new Point(988, 12);
            mkbtnTurquoise.Name = "mkbtnTurquoise";
            mkbtnTurquoise.Size = new Size(48, 48);
            mkbtnTurquoise.TabIndex = 38;
            mkbtnTurquoise.UseVisualStyleBackColor = false;
            mkbtnTurquoise.Click += mkbtnTurquoise_Click;
            // 
            // mkbtnLightSeaGreen
            // 
            mkbtnLightSeaGreen.BackColor = Color.LightSeaGreen;
            mkbtnLightSeaGreen.Location = new Point(988, 66);
            mkbtnLightSeaGreen.Name = "mkbtnLightSeaGreen";
            mkbtnLightSeaGreen.Size = new Size(48, 48);
            mkbtnLightSeaGreen.TabIndex = 37;
            mkbtnLightSeaGreen.UseVisualStyleBackColor = false;
            mkbtnLightSeaGreen.Click += mkbtnLightSeaGreen_Click;
            // 
            // mkbtnBlack
            // 
            mkbtnBlack.BackColor = Color.Black;
            mkbtnBlack.Location = new Point(610, 12);
            mkbtnBlack.Name = "mkbtnBlack";
            mkbtnBlack.Size = new Size(48, 48);
            mkbtnBlack.TabIndex = 46;
            mkbtnBlack.UseVisualStyleBackColor = false;
            mkbtnBlack.Click += mkbtnBlack_Click;
            // 
            // mkbtnGray
            // 
            mkbtnGray.BackColor = Color.Gray;
            mkbtnGray.Location = new Point(664, 12);
            mkbtnGray.Name = "mkbtnGray";
            mkbtnGray.Size = new Size(48, 48);
            mkbtnGray.TabIndex = 45;
            mkbtnGray.UseVisualStyleBackColor = false;
            mkbtnGray.Click += mkbtnGray_Click;
            // 
            // mkbtnDarkRed
            // 
            mkbtnDarkRed.BackColor = Color.DarkRed;
            mkbtnDarkRed.Location = new Point(718, 12);
            mkbtnDarkRed.Name = "mkbtnDarkRed";
            mkbtnDarkRed.Size = new Size(48, 48);
            mkbtnDarkRed.TabIndex = 44;
            mkbtnDarkRed.UseVisualStyleBackColor = false;
            mkbtnDarkRed.Click += mkbtnDarkRed_Click;
            // 
            // mkbtnCrimson
            // 
            mkbtnCrimson.BackColor = Color.Crimson;
            mkbtnCrimson.Location = new Point(772, 12);
            mkbtnCrimson.Name = "mkbtnCrimson";
            mkbtnCrimson.Size = new Size(48, 48);
            mkbtnCrimson.TabIndex = 43;
            mkbtnCrimson.UseVisualStyleBackColor = false;
            mkbtnCrimson.Click += mkbtnCrimson_Click;
            // 
            // mkbtnWhite
            // 
            mkbtnWhite.BackColor = Color.White;
            mkbtnWhite.Location = new Point(610, 66);
            mkbtnWhite.Name = "mkbtnWhite";
            mkbtnWhite.Size = new Size(48, 48);
            mkbtnWhite.TabIndex = 50;
            mkbtnWhite.UseVisualStyleBackColor = false;
            mkbtnWhite.Click += mkbtnWhite_Click;
            // 
            // mkbtnLightGray
            // 
            mkbtnLightGray.BackColor = Color.LightGray;
            mkbtnLightGray.Location = new Point(664, 66);
            mkbtnLightGray.Name = "mkbtnLightGray";
            mkbtnLightGray.Size = new Size(48, 48);
            mkbtnLightGray.TabIndex = 49;
            mkbtnLightGray.UseVisualStyleBackColor = false;
            mkbtnLightGray.Click += mkbtnLightGray_Click;
            // 
            // mkbtnCoral
            // 
            mkbtnCoral.BackColor = Color.Coral;
            mkbtnCoral.Location = new Point(718, 66);
            mkbtnCoral.Name = "mkbtnCoral";
            mkbtnCoral.Size = new Size(48, 48);
            mkbtnCoral.TabIndex = 48;
            mkbtnCoral.UseVisualStyleBackColor = false;
            mkbtnCoral.Click += mkbtnCoral_Click;
            // 
            // mkbtnPink
            // 
            mkbtnPink.BackColor = Color.Pink;
            mkbtnPink.Location = new Point(772, 67);
            mkbtnPink.Name = "mkbtnPink";
            mkbtnPink.Size = new Size(48, 48);
            mkbtnPink.TabIndex = 47;
            mkbtnPink.UseVisualStyleBackColor = false;
            mkbtnPink.Click += mkbtnPink_Click;
            // 
            // mkpbColor
            // 
            mkpbColor.BackColor = Color.Black;
            mkpbColor.BorderStyle = BorderStyle.Fixed3D;
            mkpbColor.Location = new Point(569, 13);
            mkpbColor.Name = "mkpbColor";
            mkpbColor.Size = new Size(35, 101);
            mkpbColor.TabIndex = 51;
            mkpbColor.TabStop = false;
            // 
            // mkbtnOpen
            // 
            mkbtnOpen.Image = Properties.Resources.folder;
            mkbtnOpen.Location = new Point(66, 12);
            mkbtnOpen.Name = "mkbtnOpen";
            mkbtnOpen.Size = new Size(48, 48);
            mkbtnOpen.TabIndex = 52;
            mkbtnOpen.UseVisualStyleBackColor = true;
            mkbtnOpen.Click += mkbtnOpen_Click;
            // 
            // mkbtnSave
            // 
            mkbtnSave.Image = Properties.Resources.save;
            mkbtnSave.Location = new Point(120, 12);
            mkbtnSave.Name = "mkbtnSave";
            mkbtnSave.Size = new Size(48, 48);
            mkbtnSave.TabIndex = 53;
            mkbtnSave.UseVisualStyleBackColor = true;
            mkbtnSave.Click += mkbtnSave_Click;
            // 
            // mkbtnPrinter
            // 
            mkbtnPrinter.Image = Properties.Resources.printer;
            mkbtnPrinter.Location = new Point(174, 12);
            mkbtnPrinter.Name = "mkbtnPrinter";
            mkbtnPrinter.Size = new Size(48, 48);
            mkbtnPrinter.TabIndex = 56;
            mkbtnPrinter.UseVisualStyleBackColor = true;
            mkbtnPrinter.Click += mkbtnPrinter_Click;
            // 
            // mkbtnPaste
            // 
            mkbtnPaste.Image = Properties.Resources.paste;
            mkbtnPaste.Location = new Point(66, 66);
            mkbtnPaste.Name = "mkbtnPaste";
            mkbtnPaste.Size = new Size(48, 48);
            mkbtnPaste.TabIndex = 55;
            mkbtnPaste.UseVisualStyleBackColor = true;
            mkbtnPaste.Click += mkbtnPaste_Click;
            // 
            // mkbtnCopy
            // 
            mkbtnCopy.Image = Properties.Resources.copy;
            mkbtnCopy.Location = new Point(12, 66);
            mkbtnCopy.Name = "mkbtnCopy";
            mkbtnCopy.Size = new Size(48, 48);
            mkbtnCopy.TabIndex = 54;
            mkbtnCopy.UseVisualStyleBackColor = true;
            mkbtnCopy.Click += mkbtnCopy_Click;
            // 
            // mkbtnUndo
            // 
            mkbtnUndo.Image = Properties.Resources.undo_button;
            mkbtnUndo.Location = new Point(120, 66);
            mkbtnUndo.Name = "mkbtnUndo";
            mkbtnUndo.Size = new Size(48, 48);
            mkbtnUndo.TabIndex = 57;
            mkbtnUndo.UseVisualStyleBackColor = true;
            mkbtnUndo.Click += mkbtnUndo_Click;
            // 
            // mkbtnCut
            // 
            mkbtnCut.Image = Properties.Resources.cutting;
            mkbtnCut.Location = new Point(174, 66);
            mkbtnCut.Name = "mkbtnCut";
            mkbtnCut.Size = new Size(48, 48);
            mkbtnCut.TabIndex = 58;
            mkbtnCut.UseVisualStyleBackColor = true;
            mkbtnCut.Click += mkbtnCut_Click;
            // 
            // mkbtnPainting
            // 
            mkbtnPainting.Image = Properties.Resources.paint_bucket;
            mkbtnPainting.Location = new Point(336, 12);
            mkbtnPainting.Name = "mkbtnPainting";
            mkbtnPainting.Size = new Size(48, 48);
            mkbtnPainting.TabIndex = 60;
            mkbtnPainting.UseVisualStyleBackColor = true;
            mkbtnPainting.Click += mkbtnPainting_Click;
            // 
            // mkbtnSelectColors
            // 
            mkbtnSelectColors.Image = Properties.Resources.color_picker;
            mkbtnSelectColors.Location = new Point(336, 66);
            mkbtnSelectColors.Name = "mkbtnSelectColors";
            mkbtnSelectColors.Size = new Size(48, 48);
            mkbtnSelectColors.TabIndex = 59;
            mkbtnSelectColors.UseVisualStyleBackColor = true;
            mkbtnSelectColors.Click += mkbtnSelectColors_Click;
            // 
            // mkbtnLine
            // 
            mkbtnLine.Image = Properties.Resources.horizontal_line_remove_button;
            mkbtnLine.Location = new Point(444, 12);
            mkbtnLine.Name = "mkbtnLine";
            mkbtnLine.Size = new Size(48, 48);
            mkbtnLine.TabIndex = 64;
            mkbtnLine.UseVisualStyleBackColor = true;
            mkbtnLine.Click += mkbtnLine_Click;
            // 
            // mkbtnRectangle
            // 
            mkbtnRectangle.Image = Properties.Resources.square_outline;
            mkbtnRectangle.Location = new Point(444, 66);
            mkbtnRectangle.Name = "mkbtnRectangle";
            mkbtnRectangle.Size = new Size(48, 48);
            mkbtnRectangle.TabIndex = 63;
            mkbtnRectangle.UseVisualStyleBackColor = true;
            mkbtnRectangle.Click += mkbtnRectangle_Click;
            // 
            // mkbtnCircle
            // 
            mkbtnCircle.Image = Properties.Resources.circle_outline;
            mkbtnCircle.Location = new Point(498, 66);
            mkbtnCircle.Name = "mkbtnCircle";
            mkbtnCircle.Size = new Size(48, 48);
            mkbtnCircle.TabIndex = 65;
            mkbtnCircle.UseVisualStyleBackColor = true;
            mkbtnCircle.Click += mkbtnCircle_Click;
            // 
            // mkbtnSelect
            // 
            mkbtnSelect.Image = Properties.Resources.select_all;
            mkbtnSelect.Location = new Point(498, 12);
            mkbtnSelect.Name = "mkbtnSelect";
            mkbtnSelect.Size = new Size(48, 48);
            mkbtnSelect.TabIndex = 66;
            mkbtnSelect.UseVisualStyleBackColor = true;
            mkbtnSelect.Click += mkbtnSelect_Click;
            // 
            // Projekt3PO
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1264, 761);
            Controls.Add(mkbtnSelect);
            Controls.Add(mkbtnCircle);
            Controls.Add(mkbtnLine);
            Controls.Add(mkbtnRectangle);
            Controls.Add(mkbtnPainting);
            Controls.Add(mkbtnSelectColors);
            Controls.Add(mkbtnCut);
            Controls.Add(mkbtnUndo);
            Controls.Add(mkbtnPrinter);
            Controls.Add(mkbtnPaste);
            Controls.Add(mkbtnCopy);
            Controls.Add(mkbtnSave);
            Controls.Add(mkbtnOpen);
            Controls.Add(mkpbColor);
            Controls.Add(mkbtnWhite);
            Controls.Add(mkbtnLightGray);
            Controls.Add(mkbtnCoral);
            Controls.Add(mkbtnPink);
            Controls.Add(mkbtnBlack);
            Controls.Add(mkbtnGray);
            Controls.Add(mkbtnDarkRed);
            Controls.Add(mkbtnCrimson);
            Controls.Add(mkbtnGold);
            Controls.Add(mkbtnWheat);
            Controls.Add(mkbtnDarkGreen);
            Controls.Add(mkbtnLightGreen);
            Controls.Add(mkbtnTurquoise);
            Controls.Add(mkbtnLightSeaGreen);
            Controls.Add(mkbtnRoyalBlue);
            Controls.Add(mkbtnKhaki);
            Controls.Add(mkbtnOrange);
            Controls.Add(mkbtnLightSkyBlue);
            Controls.Add(mkbtnEditColors);
            Controls.Add(mkbtnDarkMagenta);
            Controls.Add(mkbtnBlueViolet);
            Controls.Add(mkbtnPencil);
            Controls.Add(mkbtnErase);
            Controls.Add(mkbtnNew);
            Controls.Add(mkpbDrawing);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Projekt3PO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projekt3PO";
            FormClosing += Projekt3PO_FormClosing;
            ((System.ComponentModel.ISupportInitialize)mkpbDrawing).EndInit();
            ((System.ComponentModel.ISupportInitialize)mkpbColor).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox mkpbDrawing;
        private Button mkbtnNew;
        private Button mkbtnPencil;
        private Button mkbtnErase;
        private Button mkbtnBlueViolet;
        private Button mkbtnDarkMagenta;
        private Button mkbtnEditColors;
        private Button mkbtnOrange;
        private Button mkbtnLightSkyBlue;
        private Button mkbtnRoyalBlue;
        private Button mkbtnKhaki;
        private Button mkbtnGold;
        private Button mkbtnWheat;
        private Button mkbtnDarkGreen;
        private Button mkbtnLightGreen;
        private Button mkbtnTurquoise;
        private Button mkbtnLightSeaGreen;
        private Button mkbtnBlack;
        private Button mkbtnGray;
        private Button mkbtnDarkRed;
        private Button mkbtnCrimson;
        private Button mkbtnWhite;
        private Button mkbtnLightGray;
        private Button mkbtnCoral;
        private Button mkbtnPink;
        private PictureBox mkpbColor;
        private Button mkbtnOpen;
        private Button mkbtnSave;
        private Button mkbtnPrinter;
        private Button mkbtnPaste;
        private Button mkbtnCopy;
        private Button mkbtnUndo;
        private Button mkbtnCut;
        private Button mkbtnPainting;
        private Button mkbtnSelectColors;
        private Button mkbtnLine;
        private Button mkbtnRectangle;
        private Button mkbtnCircle;
        private Button mkbtnSelect;
    }
}