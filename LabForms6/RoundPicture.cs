﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForms6
{
    public class RoundPicture : PictureBox
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
    }
}
