using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace CalculadoraDeOperaciones.CustomControls
{
    public enum PanelTheme
    {
        Custom,
        Blue,
        Green,
        Orange,
        Purple
    }

    [ToolboxItem(true)]
    public class RoundedPanel : Panel
    {
        private int borderRadius = 16;
        private int borderThickness = 1;

        private Color borderColor = Color.FromArgb(205, 228, 248);
        private Color endBackgroundColor = Color.FromArgb(244, 249, 255);

        private PanelTheme theme = PanelTheme.Custom;

        public RoundedPanel()
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

            BackColor = Color.FromArgb(250, 253, 255);
            Padding = new Padding(20);

            UpdateStyles();
        }

        [Category("Appearance")]
        [Description("Color theme used by the panel.")]
        [DefaultValue(PanelTheme.Custom)]
        public PanelTheme Theme
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
        [Description("Radius of the panel corners.")]
        [DefaultValue(16)]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Thickness of the panel border.")]
        [DefaultValue(1)]
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
        [Description("Color of the panel border.")]
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
                theme = PanelTheme.Custom;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Second background color used to create a smooth gradient.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color EndBackgroundColor
        {
            get
            {
                return endBackgroundColor;
            }
            set
            {
                endBackgroundColor = value;
                theme = PanelTheme.Custom;
                Invalidate();
            }
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Width <= 1 || Height <= 1)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            // Paints the outer corners using the parent container color.
            // This prevents them from appearing black.
            Color outerColor = Parent != null
                ? Parent.BackColor
                : SystemColors.Control;

            using (SolidBrush outerBrush =
                   new SolidBrush(outerColor))
            {
                e.Graphics.FillRectangle(
                    outerBrush,
                    ClientRectangle
                );
            }

            RectangleF rectangle = new RectangleF(
                0.5f,
                0.5f,
                Width - 1.5f,
                Height - 1.5f
            );

            using (GraphicsPath path =
                   CreateRoundedPath(rectangle, borderRadius))
            {
                using (LinearGradientBrush background =
                       new LinearGradientBrush(
                           rectangle,
                           BackColor,
                           endBackgroundColor,
                           LinearGradientMode.Vertical))
                {
                    e.Graphics.FillPath(background, path);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Width <= 1 || Height <= 1 || borderThickness <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float adjustment = borderThickness / 2f;

            RectangleF rectangle = new RectangleF(
                adjustment,
                adjustment,
                Width - borderThickness - 1f,
                Height - borderThickness - 1f
            );

            using (GraphicsPath path =
                   CreateRoundedPath(rectangle, borderRadius))
            {
                using (Pen pen =
                       new Pen(borderColor, borderThickness))
                {
                    pen.Alignment = PenAlignment.Inset;

                    e.Graphics.DrawPath(
                        pen,
                        path
                    );
                }
            }
        }

        private void ApplyTheme()
        {
            switch (theme)
            {
                case PanelTheme.Blue:
                    BackColor =
                        Color.FromArgb(250, 253, 255);

                    endBackgroundColor =
                        Color.FromArgb(244, 249, 255);

                    borderColor =
                        Color.FromArgb(203, 228, 248);
                    break;

                case PanelTheme.Green:
                    BackColor =
                        Color.FromArgb(250, 253, 250);

                    endBackgroundColor =
                        Color.FromArgb(245, 251, 247);

                    borderColor =
                        Color.FromArgb(207, 233, 214);
                    break;

                case PanelTheme.Orange:
                    BackColor =
                        Color.FromArgb(255, 253, 248);

                    endBackgroundColor =
                        Color.FromArgb(255, 250, 240);

                    borderColor =
                        Color.FromArgb(246, 217, 157);
                    break;

                case PanelTheme.Purple:
                    BackColor =
                        Color.FromArgb(253, 250, 255);

                    endBackgroundColor =
                        Color.FromArgb(249, 246, 255);

                    borderColor =
                        Color.FromArgb(224, 210, 244);
                    break;

                case PanelTheme.Custom:
                default:
                    break;
            }
        }

        private static GraphicsPath CreateRoundedPath(
            RectangleF rectangle,
            float radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (rectangle.Width <= 0 ||
                rectangle.Height <= 0)
            {
                return path;
            }

            float maximumRadius =
                Math.Min(
                    rectangle.Width,
                    rectangle.Height
                ) / 2f;

            radius = Math.Max(0, radius);
            radius = Math.Min(radius, maximumRadius);

            if (radius <= 0)
            {
                path.AddRectangle(rectangle);
                path.CloseFigure();

                return path;
            }

            float diameter = radius * 2f;

            RectangleF topLeftArc =
                new RectangleF(
                    rectangle.Left,
                    rectangle.Top,
                    diameter,
                    diameter
                );

            RectangleF topRightArc =
                new RectangleF(
                    rectangle.Right - diameter,
                    rectangle.Top,
                    diameter,
                    diameter
                );

            RectangleF bottomRightArc =
                new RectangleF(
                    rectangle.Right - diameter,
                    rectangle.Bottom - diameter,
                    diameter,
                    diameter
                );

            RectangleF bottomLeftArc =
                new RectangleF(
                    rectangle.Left,
                    rectangle.Bottom - diameter,
                    diameter,
                    diameter
                );

            path.StartFigure();

            path.AddArc(
                topLeftArc,
                180,
                90
            );

            path.AddArc(
                topRightArc,
                270,
                90
            );

            path.AddArc(
                bottomRightArc,
                0,
                90
            );

            path.AddArc(
                bottomLeftArc,
                90,
                90
            );

            path.CloseFigure();

            return path;
        }
    }
}
