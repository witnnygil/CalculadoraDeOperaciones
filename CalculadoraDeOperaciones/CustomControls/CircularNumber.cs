using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace CalculadoraDeOperaciones.CustomControls
{
    public enum CircularNumberTheme
    {
        Custom,
        Blue,
        Green,
        Orange,
        Purple
    }

    [ToolboxItem(true)]
    [DefaultProperty(nameof(Text))]
    public class CircularNumber : Control
    {
        private CircularNumberTheme theme = CircularNumberTheme.Blue;

        private Color topColor =
            Color.FromArgb(48, 132, 218);

        private Color bottomColor =
            Color.FromArgb(20, 101, 190);

        private Color borderColor =
            Color.Transparent;

        private int borderThickness = 0;
        private int circleMargin = 1;
        private bool useGradient = true;

        public CircularNumber()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor,
                true
            );

            DoubleBuffered = true;

            BackColor = Color.Transparent;
            ForeColor = Color.White;

            Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );

            Text = "1";
            Size = new Size(52, 52);
            MinimumSize = new Size(24, 24);

            TabStop = false;

            ApplyTheme();
            UpdateStyles();
        }

        [Category("Appearance")]
        [Description("Color theme used by the circle.")]
        [DefaultValue(CircularNumberTheme.Blue)]
        public CircularNumberTheme Theme
        {
            get
            {
                return theme;
            }
            set
            {
                theme = value;
                ApplyTheme();
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Text displayed inside the circle.")]
        [DefaultValue("1")]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Color used at the top of the circle.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TopColor
        {
            get
            {
                return topColor;
            }
            set
            {
                topColor = value;
                theme = CircularNumberTheme.Custom;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Color used at the bottom of the circle.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BottomColor
        {
            get
            {
                return bottomColor;
            }
            set
            {
                bottomColor = value;
                theme = CircularNumberTheme.Custom;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Determines whether the circle uses a gradient.")]
        [DefaultValue(true)]
        public bool UseGradient
        {
            get
            {
                return useGradient;
            }
            set
            {
                useGradient = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Color of the circle border.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Thickness of the border. Use zero to hide it.")]
        [DefaultValue(0)]
        public int BorderThickness
        {
            get
            {
                return borderThickness;
            }
            set
            {
                borderThickness = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Space between the circle and the control boundaries.")]
        [DefaultValue(1)]
        public int CircleMargin
        {
            get
            {
                return circleMargin;
            }
            set
            {
                circleMargin = Math.Max(0, value);
                Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            /*
             * Allows Windows Forms to paint the control background
             * using the parent panel background.
             *
             * This prevents black rectangles and shadows from appearing.
             */
            base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Width <= 1 || Height <= 1)
                return;

            e.Graphics.SmoothingMode =
                SmoothingMode.AntiAlias;

            e.Graphics.PixelOffsetMode =
                PixelOffsetMode.HighQuality;

            e.Graphics.CompositingQuality =
                CompositingQuality.HighQuality;

            e.Graphics.TextRenderingHint =
                TextRenderingHint.ClearTypeGridFit;

            float side = Math.Min(
                ClientSize.Width,
                ClientSize.Height
            );

            side -= circleMargin * 2;

            if (side <= 0)
                return;

            float xPosition =
                (ClientSize.Width - side) / 2f;

            float yPosition =
                (ClientSize.Height - side) / 2f;

            RectangleF circleRectangle =
                new RectangleF(
                    xPosition,
                    yPosition,
                    side,
                    side
                );

            DrawCircleBackground(
                e.Graphics,
                circleRectangle
            );

            DrawCircleBorder(
                e.Graphics,
                circleRectangle
            );

            DrawText(
                e.Graphics,
                circleRectangle
            );
        }

        private void DrawCircleBackground(
            Graphics graphics,
            RectangleF rectangle)
        {
            if (useGradient)
            {
                using (LinearGradientBrush brush =
                       new LinearGradientBrush(
                           rectangle,
                           topColor,
                           bottomColor,
                           LinearGradientMode.Vertical))
                {
                    graphics.FillEllipse(
                        brush,
                        rectangle
                    );
                }
            }
            else
            {
                using (SolidBrush brush =
                       new SolidBrush(topColor))
                {
                    graphics.FillEllipse(
                        brush,
                        rectangle
                    );
                }
            }
        }

        private void DrawCircleBorder(
            Graphics graphics,
            RectangleF rectangle)
        {
            if (borderThickness <= 0 ||
                borderColor == Color.Transparent)
            {
                return;
            }

            float adjustment = borderThickness / 2f;

            RectangleF borderRectangle =
                new RectangleF(
                    rectangle.X + adjustment,
                    rectangle.Y + adjustment,
                    rectangle.Width - borderThickness,
                    rectangle.Height - borderThickness
                );

            if (borderRectangle.Width <= 0 ||
                borderRectangle.Height <= 0)
            {
                return;
            }

            using (Pen pen =
                   new Pen(borderColor, borderThickness))
            {
                graphics.DrawEllipse(
                    pen,
                    borderRectangle
                );
            }
        }

        private void DrawText(
            Graphics graphics,
            RectangleF rectangle)
        {
            using (SolidBrush textBrush =
                   new SolidBrush(ForeColor))
            {
                using (StringFormat format =
                       new StringFormat())
                {
                    format.Alignment =
                        StringAlignment.Center;

                    format.LineAlignment =
                        StringAlignment.Center;

                    format.Trimming =
                        StringTrimming.EllipsisCharacter;

                    format.FormatFlags =
                        StringFormatFlags.NoWrap;

                    graphics.DrawString(
                        Text,
                        Font,
                        textBrush,
                        rectangle,
                        format
                    );
                }
            }
        }

        private void ApplyTheme()
        {
            switch (theme)
            {
                case CircularNumberTheme.Blue:

                    topColor =
                        Color.FromArgb(48, 132, 218);

                    bottomColor =
                        Color.FromArgb(20, 101, 190);

                    break;

                case CircularNumberTheme.Green:

                    topColor =
                        Color.FromArgb(69, 169, 102);

                    bottomColor =
                        Color.FromArgb(42, 144, 78);

                    break;

                case CircularNumberTheme.Orange:

                    topColor =
                        Color.FromArgb(255, 178, 48);

                    bottomColor =
                        Color.FromArgb(243, 145, 8);

                    break;

                case CircularNumberTheme.Purple:

                    topColor =
                        Color.FromArgb(146, 91, 205);

                    bottomColor =
                        Color.FromArgb(113, 62, 176);

                    break;

                case CircularNumberTheme.Custom:
                default:
                    break;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }
}