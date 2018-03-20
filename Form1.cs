using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ImageCreator.Properties;

namespace ImageCreator
{
    public partial class Form1 : Form
    {
        public int CurrentHeaderIndex = -1;
        public int CurrentIndex = 0;
        public int Headers = 0;

        public Form1()
        {
            globalKeyboardHook gkh = new globalKeyboardHook();
            InitializeComponent();
            Initialize();
            gkh.HookedKeys.Add(Keys.F7);
            gkh.KeyDown += new KeyEventHandler(CaptureScreen);
        }

        public void Initialize()
        {
            PopulateComboBox(NumberColorBox);
            PopulateComboBox(PriceColorBox);
            PopulateComboBox(HeaderColor);
            PopulateComboBox(BackColorBox);
            DetailsCornerBox.Text = "Top Right";
            NumberCornerBox.Text = "Top Right";
        }

        public void PopulateComboBox(ComboBox a)
        {
            foreach (KnownColor color1 in Enum.GetValues(typeof(KnownColor)) as KnownColor[])
            {
                Color color2 = Color.FromKnownColor(color1);
                a.Items.Add((object)color2);
            }

            a.Items.Add((object)Color.Transparent);
            a.Text = "Red";
        }

        private void NewHeader_Click(object sender, EventArgs e)
        {

            DataGridViewRow hRow = new DataGridViewRow();
            DataGridViewTextBoxCell header = new DataGridViewTextBoxCell();
            Headers++;
            hRow.Tag = new Header();
            header.Value = "new header";
            hRow.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            hRow.Cells.Add(header);
            Arrange.Rows.Add(hRow);
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog Path = new SaveFileDialog();
            Path.InitialDirectory = @Application.StartupPath;
            Path.RestoreDirectory = true;
            if (Path.ShowDialog() == DialogResult.OK)
            {
                string path = Path.FileName;
                pictureBox1.Image.Save(path);
            }

        }

        private void PreviewImage_Click(object sender, EventArgs e)
        {
            int rowmax = Convert.ToInt32(ImageWidthUpDown.Value);
            int padding = Convert.ToInt32(ImagePaddingUpDown.Value);

            int pOff_x = int.Parse(PriceLocationTextBox.Text.Split(',')[0]);
            int pOff_y = int.Parse(PriceLocationTextBox.Text.Split(',')[1]);
            int nOff_x = int.Parse(NumberLocationTextBox.Text.Split(',')[0]);
            int nOff_y = int.Parse(NumberLocationTextBox.Text.Split(',')[1]);

            Color pColor = (Color)PriceColorBox.SelectedItem;
            Color nColor = (Color)NumberColorBox.SelectedItem;
            Color hColor = (Color)HeaderColor.SelectedItem;
            Color bColor = (Color)BackColorBox.SelectedItem;

            int Count = -1;
            int Height = 0;
            int mHeight = 0;
            int mWidth = 0;

            bool NEW_ROW = false;

            List<Size> RowSize = new List<Size>();

            Item iRow;

            foreach (DataGridViewRow Row in Arrange.Rows)
            {
                if (Row.Tag == null || Row.Tag == default(object))
                {
                    continue;
                }

                if (Row.Tag.GetType() == typeof(Header))
                {
                    NEW_ROW = true;
                    continue;
                }

                if (Row.Tag.GetType() == typeof(Item))
                {
                    iRow = (Item)Row.Tag;

                    if ((mWidth + iRow.Image.Width + padding > rowmax) || NEW_ROW)
                    {
                        NEW_ROW = false;
                        Height += mHeight;
                        RowSize.Add(new Size(mWidth, mHeight));
                        mWidth = 0;
                        mHeight = 0;
                    }

                    if (mHeight < (iRow.Image.Height + padding))
                    {
                        mHeight = iRow.Image.Height + padding;
                    }

                    mWidth += iRow.Image.Width + padding;
                }
            }

            int Border = 0;
            Height += mHeight;
            RowSize.Add(new Size(mWidth, mHeight));
            mWidth = 0;
            mHeight = 0;

            if (useHeading.Checked)
            {
                Height += Headers * 50;

            }

            if (addBorder.Checked)
            {
                Height += 72;
                Border += 72;
            }

            Bitmap Final = new Bitmap(rowmax + padding + Border, Height + padding);
            Graphics _g = Graphics.FromImage(Final);
            _g.Clear(bColor);

            mHeight = 0;
            Count = 0;
            int iNumber = 1;

            int gX = 0;
            int gY = padding + Border / 2;

            Font Title = new Font("Arial", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            Font Number = new Font("Arial", 25F, FontStyle.Bold, GraphicsUnit.Pixel);
            Font Price = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Pixel);

            foreach (DataGridViewRow Row in Arrange.Rows)
            {
                if (Row.Tag == null || Row.Tag == default(object))
                {
                    continue;
                }

                if (Row.Tag.GetType() == typeof(Header))
                {
                    if (useHeading.Checked)
                    {
                        gY += mHeight;
                        gX = (int)(Final.Width - _g.MeasureString(Row.Cells[0].Value.ToString(), Title).Width) / 2;
                        _g.DrawString((string)Row.Cells[0].Value, Title, new SolidBrush(hColor), new Point(gX, gY));
                        gY += 50;
                        gY -= mHeight;
                    }

                    NEW_ROW = true;
                }

                if (Row.Tag.GetType() == typeof(Item))
                {
                    iRow = (Item)Row.Tag;

                    if ((mWidth + iRow.Image.Width + padding > rowmax) || NEW_ROW)
                    {
                        NEW_ROW = false;
                        Count++;
                        gY += mHeight;
                        gX = padding + (rowmax - RowSize[Count].Width) / 2 + Border / 2;
                        mWidth = 0;
                        mHeight = 0;
                    }

                    _g.DrawImage(iRow.Image, new Point(gX, gY));
                    mWidth += iRow.Image.Width + padding;
                    gX += iRow.Image.Width + padding;

                    if ((iRow.Image.Height + padding) > mHeight)
                    {
                        mHeight = ((Item)Row.Tag).Image.Height + padding;
                    }

                    SizeF f = _g.MeasureString("#" + iNumber.ToString(), Number);
                    _g.DrawString("#" + iNumber, Number, new SolidBrush(nColor), AppliedOffset(NumberCornerBox.Text, f, gX - padding, gY, nOff_x, nOff_y, iRow.Image.Width, iRow.Image.Height));

                    if (Row.Cells[2].Value != null)
                    {
                        f = _g.MeasureString((string)Row.Cells[2].Value, Price);
                        _g.DrawString((string)Row.Cells[2].Value, Price, new SolidBrush(pColor), AppliedOffset(DetailsCornerBox.Text, f, gX - padding, gY, pOff_x, pOff_y, iRow.Image.Width, iRow.Image.Height));
                    }

                    ++iNumber;
                }
            }


            if (addBorder.Checked)
            {
                gX = Resources.Top_Left.Width;
                gY = 0;

                for (int i = gX; i < Final.Width; i += Resources.Top.Width)
                {
                    _g.DrawImage(Resources.Top, new Point(gX, gY));
                    gX += Resources.Top.Width;
                }

                gX = Resources.Bottom_Left.Width;
                gY = Final.Height - Resources.Bottom.Height;

                for (int i = gX; i < Final.Width; i += Resources.Bottom.Width)
                {
                    _g.DrawImage(Resources.Bottom, new Point(gX, gY));
                    gX += Resources.Bottom.Width;
                }

                gX = 0;
                gY = Resources.Top_Left.Height;

                for (int i = gY; i < Final.Height; i += Resources.Left.Height)
                {
                    _g.DrawImage(Resources.Left, new Point(gX, gY));
                    gY += Resources.Left.Height;
                }

                gX = Final.Width - Resources.Right.Width;
                gY = Resources.Top_Right.Height;

                for (int i = gY; i < Final.Height; i += Resources.Right.Height)
                {
                    _g.DrawImage(Resources.Right, new Point(gX, gY));
                    gY += Resources.Right.Height;
                }

                _g.DrawImage(Resources.Top_Left, new Point(0, 0));
                _g.DrawImage(Resources.Top_Right, new Point(Final.Width - Resources.Top_Right.Width, 0));
                _g.DrawImage(Resources.Bottom_Left, new Point(0, Final.Height - Resources.Bottom_Left.Height));
                _g.DrawImage(Resources.Bottom_Right, new Point(Final.Width - Resources.Bottom_Right.Width, Final.Height - Resources.Bottom_Right.Height));
            }

            pictureBox1.Image = Final;
            _g.Dispose();
        }

        private void addImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CurrentHeaderIndex < 0 || Arrange.Rows[CurrentHeaderIndex].Tag == default(object) || Arrange.Rows[CurrentHeaderIndex].Tag.GetType() != typeof(Header))
            {
                return;
            }

            Header temp = (Header)Arrange.Rows[CurrentHeaderIndex].Tag;
            OpenFileDialog Path = new OpenFileDialog();
            Path.InitialDirectory = @Application.StartupPath;
            Path.Multiselect = true;
            Path.RestoreDirectory = true;
            string[] images;

            if (Path.ShowDialog() == DialogResult.OK)
            {
                images = Path.FileNames;

                foreach (string image in images)
                {
                    temp.Count++;
                    Item item = new Item();
                    DataGridViewRow iRow = new DataGridViewRow();
                    DataGridViewTextBoxCell hCell = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell iCell = new DataGridViewTextBoxCell();
                    item.Path = image;
                    item.Image = Image.FromFile(image);
                    item.Parent = Arrange.Rows[CurrentHeaderIndex];
                    iCell.Value = System.IO.Path.GetFileName(image);
                    iRow.Tag = item;
                    iRow.Cells.Add(hCell);
                    iRow.Cells.Add(iCell);
                    Arrange.Rows.Insert(CurrentHeaderIndex + temp.Count, iRow);
                }
            }
        }

        private void Arrange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            try
            {
                index = Arrange.SelectedCells[0].RowIndex;
            }
            catch
            {
                CurrentHeaderIndex = -1;
                return;
            }
            if (Arrange.Rows[index].Tag != default(object) && Arrange.Rows[index].Tag.GetType() == typeof(Item))
            {
                pictureBox2.Image = ((Item)Arrange.Rows[index].Tag).Image;
                CurrentHeaderIndex = -1;
            }
            else if (Arrange.Rows[index].Tag != default(object) && Arrange.Rows[index].Tag.GetType() == typeof(Header))
            {
                CurrentHeaderIndex = index;
            }

        }

        private void CreateNewImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            Arrange.Rows.Clear();
        }

        private void removeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                index = Arrange.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (Arrange.Rows[index].Tag != default(object) && Arrange.Rows[index].Tag.GetType() == typeof(Item))
            {
                ((Header)(((Item)Arrange.Rows[index].Tag).Parent.Tag)).Count--;
                Arrange.Rows.RemoveAt(index);
                pictureBox2.Image = null;
            }
        }

        private void removeHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                index = Arrange.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }

            if (Arrange.Rows[index].Tag != default(object) && Arrange.Rows[index].Tag.GetType() == typeof(Header))
            {
                Header pHeader = (Header)Arrange.Rows[index].Tag;
                for (int i = 0; i < pHeader.Count; i++)
                {
                    Arrange.Rows.RemoveAt(index + 1);
                }
                Arrange.Rows.RemoveAt(index);
                pictureBox2.Image = null;
            }
        }

        public PointF AppliedOffset(string type, SizeF size, int x, int y, int off_X, int off_Y, int width, int height)
        {
            switch (type)
            {
                case "Top Right":
                    return new PointF(x - off_X - size.Width, y + off_Y);
                case "Top Left":
                    return new PointF(x - width + off_X, y + off_Y);
                case "Bottom Left":
                    return new PointF(x - width + off_X, y + height - off_Y - size.Height);
                case "Bottom Right":
                    return new PointF(x - off_X - size.Width, y + height - off_Y - size.Height);
            }

            return new PointF(x, y);
        }

        public void CaptureScreen(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F7)
            {
                return;
            }

            Point CropA = new Point(0, 0);
            Point CropB = new Point(0, 0);
            Rectangle firstcrop = new Rectangle(0, 0, 1, 1);

            Bitmap BMP = new Bitmap(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            System.Drawing.Graphics GFX = System.Drawing.Graphics.FromImage(BMP);
            GFX.CopyFromScreen(System.Windows.Forms.Screen.PrimaryScreen.Bounds.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y, 0, 0, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size, System.Drawing.CopyPixelOperation.SourceCopy);
            DataContainer.img1 = BMP;
            DataContainer.imgwi = BMP.Width;
            Point MousePos = System.Windows.Forms.Control.MousePosition;

            double imagerapport = (Convert.ToDouble(BMP.Width) / BMP.Height);
            //int lolppp = Convert.ToInt32(Math.Floor(imagerapport));

            if (imagerapport < 1.6) { DataContainer.screensize = 1; } // 4/3
            else if (imagerapport == 1.6) { DataContainer.screensize = 2; }  //16/10
            else if (imagerapport > 1.6) { DataContainer.screensize = 3; }  //16/9
            //richTextBox3.AppendText("\ng :"+ imagerapport.ToString());

            if (MousePos.X < (DataContainer.img1.Width / 2))
            {
                CropA.X = MousePos.X - 10;
                CropB.X = MousePos.X + Convert.ToInt32(DataContainer.img1.Width * 24.45 / 100) + 140;

            }
            else
            {
                CropA.X = MousePos.X - Convert.ToInt32(DataContainer.img1.Width * 24.45 / 100) - 140;
                CropB.X = MousePos.X + 10;
            }
            //CropX.X = MousePos.X - Convert.ToInt32(DataContainer.img1.Width * 24.45 / 100);
            //richTextBox3.AppendText(CropA.X.ToString() +";"+CropB.X.ToString() +"\n");

            //if ((MousePos.Y + 500) < DataContainer.img1.Height) { firstcrop = new Rectangle(CropA.X, 0, Math.Abs(CropA.X - CropB.X), (MousePos.Y + 500)); }
            firstcrop = new Rectangle(CropA.X, 0, Math.Abs(CropA.X - CropB.X), DataContainer.img1.Height);
            Bitmap firstc = cropImage(DataContainer.img1, firstcrop);
            firstc = FindHeight(firstc);
            firstc = FindWidth(firstc);
            pictureBox1.Image = firstc;
            //firstc.Save(@Application.StartupPath + "\\" + DateTime.Now.ToString().Replace(':','.') + ".jpeg", ImageFormat.Jpeg); 
        }

        public Bitmap FindHeight(Bitmap image)
        {
            Bitmap returnMap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
            BitmapData bitmapData1 = image.LockBits(new Rectangle(0, 0,
                                     image.Width, image.Height),
                                     ImageLockMode.ReadOnly,
                                     PixelFormat.Format32bppArgb);
            BitmapData bitmapData2 = returnMap.LockBits(new Rectangle(0, 0,
                                     returnMap.Width, returnMap.Height),
                                     ImageLockMode.ReadOnly,
                                     PixelFormat.Format32bppArgb);
            int a = 0;

            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;
                byte* imagePointer2 = (byte*)bitmapData2.Scan0;

                // y position of bottom coin
                Int32 bottompos = 0;
                bool bottomposfound = false;

                // y position of top yellow text
                Int32 toppos = 10000;
                for (int i = 0; i < bitmapData1.Height; i++)
                {


                    for (int j = 0; j < bitmapData1.Width; j++)
                    {
                        // write the logic implementation here
                        a = (imagePointer1[0] + imagePointer1[1] + imagePointer1[2]) / 3;
                        //imagePointer2[0] = (byte)a;
                        //imagePointer2[1] = (byte)a;
                        //imagePointer2[2] = (byte)a;

                        //top pixel green (set)
                        if ((-1 < imagePointer1[0] && imagePointer1[0] < 1) && (237 < imagePointer1[1] && imagePointer1[1] < 241) && (0 < imagePointer1[2] && imagePointer1[2] < 4))
                        {
                            //get only first iteration of yellow pixel
                            if (toppos > i) { toppos = i; }
                        }

                        //top pixel (yellow title)
                        if ((-1 < imagePointer1[0] && imagePointer1[0] < 1) && (254 < imagePointer1[1] && imagePointer1[1] < 256) && (254 < imagePointer1[2] && imagePointer1[2] < 256))
                        {
                            //get only first iteration of yellow pixel
                            if (toppos > i) { toppos = i; }
                        }
                        //orange (legendary title)
                        if ((45 < imagePointer1[0] && imagePointer1[0] < 49) && (98 < imagePointer1[1] && imagePointer1[1] < 102) && (189 < imagePointer1[2] && imagePointer1[2] < 193))
                        {

                            //get only first iteration of pixel
                            if (toppos > i) { toppos = i; }
                        }
                        //blue (rare)
                        if ((250 < imagePointer1[0] && imagePointer1[0] < 256) && (100 < imagePointer1[1] && imagePointer1[1] < 110) && (100 < imagePointer1[2] && imagePointer1[2] < 110))
                        {

                            //get only first iteration of pixel
                            if (toppos > i) { toppos = i; }
                        }

                        // bottom pixel in coin on the item panel
                        if ((19 < imagePointer1[0] && imagePointer1[0] < 23) && (144 < imagePointer1[1] && imagePointer1[1] < 151) && (218 < imagePointer1[2] && imagePointer1[2] < 228))
                        {

                            /*
                            imagePointer2[0] = 0;
                            imagePointer2[1] = 0;
                            imagePointer2[2] = 255;
                            imagePointer2[3] = imagePointer1[3];
                            richTextBox3.AppendText(j.ToString() + ";" + i.ToString() + "\n");
                            */

                            if (bottomposfound == false)
                            {
                                bottompos = i;
                                bottomposfound = true;
                            }
                        }

                        /* else
                        {
                            imagePointer2[0] = (byte)a;
                            imagePointer2[1] = (byte)a;
                            imagePointer2[2] = (byte)a;
                            imagePointer2[3] = imagePointer1[3];
                        }
                        */

                        imagePointer2[0] = imagePointer1[0];
                        imagePointer2[1] = imagePointer1[1];
                        imagePointer2[2] = imagePointer1[2];
                        imagePointer2[3] = imagePointer1[3];

                        //4 bytes per pixel
                        imagePointer1 += 4;
                        imagePointer2 += 4;
                    }//end for j

                    //if (pixcount > 452) { richTextBox3.AppendText(pixcount +";"+i.ToString() + "\n"); }
                    //4 bytes per pixel
                    imagePointer1 += bitmapData1.Stride - (bitmapData1.Width * 4);
                    imagePointer2 += bitmapData1.Stride - (bitmapData1.Width * 4);
                }

                //end for i
                double tpp = image.Height * 13 / 1200;
                double btt = image.Height * 13 / 1200;

                if (toppos < 10000) { toppos = toppos - (Convert.ToInt32(Math.Floor(tpp))); }
                else { toppos = 0; }
                if (bottompos > 0) { bottompos = bottompos + (Convert.ToInt32(Math.Floor(btt))); }
                else { bottompos = image.Height; }
                //richTextBox3.AppendText(toppos+ ";" + bottompos + "\n");

                Rectangle crop2 = new Rectangle(0, toppos, returnMap.Width, Math.Abs(bottompos - toppos));
                Bitmap returnMap2 = cropImage(returnMap, crop2);

                image.UnlockBits(bitmapData1);
                returnMap.UnlockBits(bitmapData2);
                return returnMap2;
            }
            //returnMap.Dispose();
        }

        public Bitmap FindWidth(Bitmap imagez)
        {
            Bitmap returnMapz = new Bitmap(imagez.Width, imagez.Height, PixelFormat.Format32bppArgb);
            BitmapData bitmapData3 = imagez.LockBits(new Rectangle(0, 0,
                                     imagez.Width, imagez.Height),
                                     ImageLockMode.ReadOnly,
                                     PixelFormat.Format32bppArgb);
            BitmapData bitmapData4 = returnMapz.LockBits(new Rectangle(0, 0,
                                     returnMapz.Width, returnMapz.Height),
                                     ImageLockMode.ReadOnly,
                                     PixelFormat.Format32bppArgb);
            int a = 0;
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData3.Scan0;
                byte* imagePointer2 = (byte*)bitmapData4.Scan0;

                // y position of bottom coin
                Int32 leftpos = 100000;

                // y position of top yellow text

                for (int i = 0; i < bitmapData3.Height; i++)
                {


                    for (int j = 0; j < bitmapData3.Width; j++)
                    {
                        // write the logic implementation here
                        a = (imagePointer1[0] + imagePointer1[1] + imagePointer1[2]) / 3;


                        //imagePointer2[0] = (byte)a;
                        //imagePointer2[1] = (byte)a;
                        //imagePointer2[2] = (byte)a;

                        //left pixel : almost black then white
                        if ((imagePointer1[0] < 140) && (imagePointer1[1] < 50) && (imagePointer1[2] < 50) &&
                            (254 < imagePointer1[4] && imagePointer1[4] < 256) && (103 < imagePointer1[5] && imagePointer1[5] < 107) && (103 < imagePointer1[6] && imagePointer1[6] < 107))
                        {

                            /*
                            imagePointer2[0] = 0;
                            imagePointer2[1] = 0;
                            imagePointer2[2] = 255;
                            imagePointer2[3] = imagePointer1[3];
                            richTextBox3.AppendText(j.ToString() + ";" + i.ToString() + "\n");
                         */
                            //get only first iteration of yellow pixel
                            if (leftpos > j)
                            {
                                leftpos = j;
                            }
                        }

                        imagePointer2[0] = imagePointer1[0];
                        imagePointer2[1] = imagePointer1[1];
                        imagePointer2[2] = imagePointer1[2];
                        imagePointer2[3] = imagePointer1[3];

                        //4 bytes per pixel
                        imagePointer1 += 4;
                        imagePointer2 += 4;
                    }//end for j

                    //if (pixcount > 452) { richTextBox3.AppendText(pixcount +";"+i.ToString() + "\n"); }
                    //4 bytes per pixel
                    imagePointer1 += bitmapData3.Stride - (bitmapData3.Width * 4);
                    imagePointer2 += bitmapData4.Stride - (bitmapData3.Width * 4);
                }

                //end for i

                double lpp = DataContainer.imgwi * 29 / 1920;
                double rpp = DataContainer.imgwi * 446 / 1920;

                if (DataContainer.screensize == 1) //4/3
                {
                    lpp = DataContainer.imgwi * 29 / 1600;
                    rpp = DataContainer.imgwi * 446 / 1600;
                }
                if (DataContainer.screensize == 3)  //16/9
                {
                    lpp = DataContainer.imgwi * 28 / 1920;
                    rpp = DataContainer.imgwi * 401 / 1920;
                }

                if (leftpos < 10000) { leftpos = leftpos - (Convert.ToInt32(Math.Floor(lpp))); }
                else { leftpos = 0; }
                if (leftpos < 0) { leftpos = 0; }
                Int32 rightpos = leftpos + Convert.ToInt32(Math.Floor(rpp));
                if (rightpos > returnMapz.Width) { rightpos = returnMapz.Width; }


                //richTextBox3.AppendText("left" + leftpos + ";" +rightpos+  "\n");
                Rectangle crop2 = new Rectangle(leftpos, 0, Math.Abs(rightpos - leftpos), returnMapz.Height);
                //Bitmap returnMap2 = cropImage(returnMapz, crop2);
                returnMapz = returnMapz.Clone(crop2, returnMapz.PixelFormat);


                imagez.UnlockBits(bitmapData3);
                //returnMapz.UnlockBits(bitmapData4);
                //richTextBox3.AppendText("\nok findwidth");
                return returnMapz;

            }
        }

        private Bitmap cropImage(Bitmap imga, Rectangle cropArea)
        {
            Bitmap bmpCrop = imga; //DataContainer.img1;
            //if ((cropArea.Width > 0) && (cropArea.Height > 0) ) { 
            bmpCrop = imga.Clone(cropArea, imga.PixelFormat); //}
            //imga.Dispose();
            return (bmpCrop);
        }
    }

    public class Item
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Path { get; set; }
        public Image Image { get; set; }
        public DataGridViewRow Parent { get; set; }
    }

    public class Header
    {
        public int Count { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public static class DataContainer
    {
        public static string imgdir;
        public static string imageshackurl;
        public static string imgpathlol;
        public static Bitmap img1, imgcropped;
        public static int imgwi;
        public static int screensize = 1;
        public static Rectangle Prevclip;
    }
}
