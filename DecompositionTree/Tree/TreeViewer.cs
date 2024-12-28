using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DecompositionTree
{
    public class TreeViewer : PictureBox
    {
        public new Image Image;
        Point mouseDown;
        int StartX = 0;
        int StartY = 0;
        int ImageX = 0;
        int ImageY = 0;

        bool IsMousePressed = false;
        float ZoomLVL = 1;

        public TreeViewer() : base()
        {
            Image = new Bitmap(Width, Height);

            Paint += new PaintEventHandler(TreeViewer_Paint);
            MouseDown += new MouseEventHandler(TreeViewer_MouseDown);
            MouseMove += new MouseEventHandler(TreeViewer_MouseMove);
            MouseUp += new MouseEventHandler(TreeViewer_MouseUp);
        }

        #region Перемещение изображения
        private void TreeViewer_MouseDown(object sender, EventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left)
            {
                if (!IsMousePressed)
                {
                    IsMousePressed = true;
                    mouseDown = mouse.Location;
                    StartX = ImageX;
                    StartY = ImageY;
                }
            }
        }

        private void TreeViewer_MouseMove(object sender, EventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left)
            {
                Point mousePosNow = mouse.Location;

                int deltaX = mousePosNow.X - mouseDown.X;
                int deltaY = mousePosNow.Y - mouseDown.Y;

                ImageX = (int)(StartX + (deltaX / ZoomLVL));
                ImageY = (int)(StartY + (deltaY / ZoomLVL));

                Refresh();
            }
        }

        private void TreeViewer_MouseUp(object sender, EventArgs e)
        {
            IsMousePressed = false;
        }
        #endregion
        
        //Перерисовка элемента
        private void TreeViewer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.ScaleTransform(ZoomLVL, ZoomLVL);
            e.Graphics.DrawImage(Image, ImageX, ImageY);
        }

        //Масштабирование
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            float oldzoom = ZoomLVL;

            if (e.Delta > 0)
                ZoomLVL += 0.1F;
            else if (e.Delta < 0)
                ZoomLVL = Math.Max(ZoomLVL - 0.1F, 0.01F);

            MouseEventArgs mouse = e as MouseEventArgs;
            Point mousePosNow = mouse.Location;

            int x = mousePosNow.X;
            int y = mousePosNow.Y;

            int oldimagex = (int)(x / oldzoom);
            int oldimagey = (int)(y / oldzoom);

            int newimagex = (int)(x / ZoomLVL);
            int newimagey = (int)(y / ZoomLVL);

            ImageX = newimagex - oldimagex + ImageX;
            ImageY = newimagey - oldimagey + ImageY;

            Refresh();
        }
    }
}
