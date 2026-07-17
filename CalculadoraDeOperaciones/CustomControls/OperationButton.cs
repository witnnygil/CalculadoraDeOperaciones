using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace CalculadoraDeOperaciones.CustomControls
{
    [ToolboxItem(true)]
    [DefaultProperty(nameof(Text))]
    public class OperationButton : Button
    {
        private string symbol = "+";

        private Color symbolColor = Color.FromArgb(32, 116, 204);

        private Color backgroundColor = Color.White;

        private Color hoverBackgroundColor = Color.FromArgb(247, 250, 254);

        private Color pressedBackgroundColor = Color.FromArgb(235, 242, 250);

        private Color borderColor = Color.FromArgb(210, 214, 220);

        private Color hoverBorderColor = Color.FromArgb(170, 190, 215);

        private int borderRadius = 12;
        private int borderThickness = 1;
        private int iconTextSpacing = 22;

        private float symbolSize = 30F;

        private Size imageSize = new Size(36, 36);

        private bool isMouseOver;
        private bool isMousePressed;
        private bool isKeyPressed;

        public OperationButton()
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

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;

            UseVisualStyleBackColor = false;

            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(20, 20, 20);

            Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );

            Text = "Operation";
            Size = new Size(122, 37);

            Cursor = Cursors.Hand;
            TabStop = true;

            UpdateStyles();
        }

        [Category("Icon")]
        [Description(
            "Symbol displayed to the left of the text. " +
            "It is ignored when the Image property contains an image."
        )]
        [DefaultValue("+")]
        public string Symbol
        {
            get => symbol;
            set
            {
                symbol = value ?? string.Empty;
                Invalidate();
            }
        }

        [Category("Icon")]
        [Description("Color used to draw the symbol.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SymbolColor
        {
            get => symbolColor;
            set
            {
                symbolColor = value;
                Invalidate();
            }
        }

        [Category("Icon")]
        [Description("Font size used to draw the symbol.")]
        [DefaultValue(30F)]
        public float SymbolSize
        {
            get => symbolSize;
            set
            {
                symbolSize = Math.Max(6F, value);
                Invalidate();
            }
        }

        [Category("Icon")]
        [Description(
            "Size used to draw the image assigned " +
            "to the Image property."
        )]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Size ImageSize
        {
            get => imageSize;
            set
            {
                imageSize = new Size(
                    Math.Max(1, value.Width),
                    Math.Max(1, value.Height)
                );

                Invalidate();
            }
        }

        [Category("Icon")]
        [Description("Spacing between the icon and the text.")]
        [DefaultValue(22)]
        public int IconTextSpacing
        {
            get => iconTextSpacing;
            set
            {
                iconTextSpacing = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Normal background color of the button.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Background color displayed when the pointer is over the button.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverBackgroundColor
        {
            get => hoverBackgroundColor;
            set
            {
                hoverBackgroundColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Background color displayed while the button is pressed.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PressedBackgroundColor
        {
            get => pressedBackgroundColor;
            set
            {
                pressedBackgroundColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Normal border color of the button.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Border color displayed when the pointer is over the button.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverBorderColor
        {
            get => hoverBorderColor;
            set
            {
                hoverBorderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Radius of the button corners.")]
        [DefaultValue(12)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Thickness of the button border.")]
        [DefaultValue(1)]
        public int BorderThickness
        {
            get => borderThickness;
            set
            {
                borderThickness = Math.Max(0, value);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 1 || Height <= 1)
                return;

            e.Graphics.SmoothingMode =
                SmoothingMode.AntiAlias;

            e.Graphics.PixelOffsetMode =
                PixelOffsetMode.HighQuality;

            e.Graphics.CompositingQuality =
                CompositingQuality.HighQuality;

            e.Graphics.InterpolationMode =
                InterpolationMode.HighQualityBicubic;

            e.Graphics.TextRenderingHint =
                TextRenderingHint.ClearTypeGridFit;

            DrawOuterBackground(e.Graphics);

            RectangleF rectangle = new RectangleF(
                0.5F,
                0.5F,
                Width - 1.5F,
                Height - 1.5F
            );

            using GraphicsPath path =
                CreateRoundedPath(
                    rectangle,
                    borderRadius
                );

            Color currentBackgroundColor =
                GetCurrentBackgroundColor();

            Color currentBorderColor =
                isMouseOver
                    ? hoverBorderColor
                    : borderColor;

            using (SolidBrush backgroundBrush =
                   new SolidBrush(currentBackgroundColor))
            {
                e.Graphics.FillPath(
                    backgroundBrush,
                    path
                );
            }

            if (borderThickness > 0)
            {
                using Pen borderPen =
                    new Pen(
                        currentBorderColor,
                        borderThickness
                    );

                borderPen.Alignment =
                    PenAlignment.Inset;

                e.Graphics.DrawPath(
                    borderPen,
                    path
                );
            }

            DrawContent(e.Graphics);

            if (Focused && ShowFocusCues)
            {
                Rectangle focusRectangle =
                    Rectangle.Inflate(
                        ClientRectangle,
                        -7,
                        -7
                    );

                ControlPaint.DrawFocusRectangle(
                    e.Graphics,
                    focusRectangle
                );
            }
        }

        private void DrawOuterBackground(
            Graphics graphics)
        {
            Color outerColor =
                Parent?.BackColor ??
                SystemColors.Control;

            using SolidBrush outerBrush =
                new SolidBrush(outerColor);

            graphics.FillRectangle(
                outerBrush,
                ClientRectangle
            );
        }

        private Color GetCurrentBackgroundColor()
        {
            if (!Enabled)
            {
                return Color.FromArgb(
                    245,
                    245,
                    245
                );
            }

            if (isMousePressed ||
                isKeyPressed)
            {
                return pressedBackgroundColor;
            }

            if (isMouseOver)
                return hoverBackgroundColor;

            return backgroundColor;
        }

        private void DrawContent(
            Graphics graphics)
        {
            Color currentTextColor =
                Enabled
                    ? ForeColor
                    : SystemColors.GrayText;

            Color currentIconColor =
                Enabled
                    ? symbolColor
                    : SystemColors.GrayText;

            TextFormatFlags textOptions =
                TextFormatFlags.NoPadding |
                TextFormatFlags.SingleLine |
                TextFormatFlags.VerticalCenter;

            Size textSize =
                TextRenderer.MeasureText(
                    Text,
                    Font,
                    Size.Empty,
                    textOptions
                );

            bool useImage =
                Image != null;

            int iconWidth;
            int iconHeight;

            Font? symbolFont = null;

            if (useImage)
            {
                iconWidth =
                    imageSize.Width;

                iconHeight =
                    imageSize.Height;
            }
            else
            {
                symbolFont = new Font(
                    "Segoe UI Symbol",
                    symbolSize,
                    FontStyle.Bold,
                    GraphicsUnit.Point
                );

                Size measuredSymbolSize =
                    TextRenderer.MeasureText(
                        symbol,
                        symbolFont,
                        Size.Empty,
                        textOptions
                    );

                iconWidth =
                    measuredSymbolSize.Width;

                iconHeight =
                    measuredSymbolSize.Height;
            }

            bool hasIcon =
                useImage ||
                !string.IsNullOrWhiteSpace(symbol);

            int spacing =
                hasIcon
                    ? iconTextSpacing
                    : 0;

            int contentWidth =
                textSize.Width +
                spacing +
                (hasIcon ? iconWidth : 0);

            int xPosition =
                (ClientSize.Width -
                 contentWidth) / 2;

            int centerY =
                (ClientSize.Height / 2) - 5;

            if (hasIcon)
            {
                Rectangle iconRectangle =
                    new Rectangle(
                        xPosition,
                        centerY - iconHeight / 2,
                        iconWidth,
                        iconHeight
                    );

                if (useImage && Image != null)
                {
                    graphics.DrawImage(
                        Image,
                        iconRectangle
                    );
                }
                else if (symbolFont != null)
                {
                    TextRenderer.DrawText(
                        graphics,
                        symbol,
                        symbolFont,
                        iconRectangle,
                        currentIconColor,
                        TextFormatFlags.HorizontalCenter |
                        TextFormatFlags.VerticalCenter |
                        TextFormatFlags.NoPadding |
                        TextFormatFlags.SingleLine
                    );
                }

                xPosition +=
                    iconWidth +
                    spacing;
            }

            Rectangle textRectangle =
                new Rectangle(
                    xPosition,
                    0,
                    textSize.Width + 4,
                    ClientSize.Height
                );

            TextRenderer.DrawText(
                graphics,
                Text,
                Font,
                textRectangle,
                currentTextColor,
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPadding |
                TextFormatFlags.SingleLine |
                TextFormatFlags.EndEllipsis
            );

            symbolFont?.Dispose();
        }

        private static GraphicsPath CreateRoundedPath(
            RectangleF rectangle,
            float radius)
        {
            GraphicsPath path =
                new GraphicsPath();

            float maximumRadius =
                Math.Min(
                    rectangle.Width,
                    rectangle.Height
                ) / 2F;

            radius = Math.Max(0, radius);
            radius = Math.Min(
                radius,
                maximumRadius
            );

            if (radius <= 0)
            {
                path.AddRectangle(rectangle);
                path.CloseFigure();

                return path;
            }

            float diameter =
                radius * 2F;

            path.StartFigure();

            path.AddArc(
                rectangle.Left,
                rectangle.Top,
                diameter,
                diameter,
                180,
                90
            );

            path.AddArc(
                rectangle.Right - diameter,
                rectangle.Top,
                diameter,
                diameter,
                270,
                90
            );

            path.AddArc(
                rectangle.Right - diameter,
                rectangle.Bottom - diameter,
                diameter,
                diameter,
                0,
                90
            );

            path.AddArc(
                rectangle.Left,
                rectangle.Bottom - diameter,
                diameter,
                diameter,
                90,
                90
            );

            path.CloseFigure();

            return path;
        }

        protected override void OnMouseEnter(
            EventArgs e)
        {
            base.OnMouseEnter(e);

            isMouseOver = true;
            Invalidate();
        }

        protected override void OnMouseLeave(
            EventArgs e)
        {
            base.OnMouseLeave(e);

            isMouseOver = false;
            isMousePressed = false;

            Invalidate();
        }

        protected override void OnMouseDown(
            MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                isMousePressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(
            MouseEventArgs e)
        {
            base.OnMouseUp(e);

            isMousePressed = false;
            Invalidate();
        }

        protected override void OnKeyDown(
            KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Space)
            {
                isKeyPressed = true;
                Invalidate();
            }
        }

        protected override void OnKeyUp(
            KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.Space)
            {
                isKeyPressed = false;
                Invalidate();
            }
        }

        //protected override void OnImageChanged(
        //    EventArgs e)
        //{
        //    base.OnImageChanged(e);
        //    Invalidate();
        //}

        protected override void OnTextChanged(
            EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnFontChanged(
            EventArgs e)
        {
            base.OnFontChanged(e);
            Invalidate();
        }

        protected override void OnForeColorChanged(
            EventArgs e)
        {
            base.OnForeColorChanged(e);
            Invalidate();
        }

        protected override void OnEnabledChanged(
            EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected override void OnResize(
            EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}