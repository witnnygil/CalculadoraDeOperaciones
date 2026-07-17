using CalculadoraDeOperaciones.CustomControls;
using System.Drawing;

namespace CalculadoraDeOperaciones
{
    public partial class FrmCalculatorOperations
    {
        private void ApplyAppearance()
        {
            BackColor = Color.FromArgb(252, 252, 252);

            ConfigureCircularNumbers();
            ConfigurePanels();
            ConfigureLabels();
            ConfigureOperationButtons();
        }

        private void ConfigureCircularNumbers()
        {
            ConfigureCircularNumber(
                CnStep1,
                "1",
                CircularNumberTheme.Blue
            );

            ConfigureCircularNumber(
                CnStep2,
                "2",
                CircularNumberTheme.Green
            );

            ConfigureCircularNumber(
                CnStep3,
                "3",
                CircularNumberTheme.Orange
            );

            ConfigureCircularNumber(
                CnResult,
                "=",
                CircularNumberTheme.Purple
            );
        }

        private static void ConfigureCircularNumber(
            CircularNumber circularNumber,
            string text,
            CircularNumberTheme theme)
        {
            circularNumber.Text = text;
            circularNumber.Theme = theme;
            circularNumber.Size = new Size(30, 30);
            circularNumber.ForeColor = Color.White;

            circularNumber.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold
            );

            circularNumber.BorderThickness = 0;
            circularNumber.BackColor = Color.Transparent;
            circularNumber.UseGradient = true;
        }

        private void ConfigurePanels()
        {
            ConfigurePanel(
                panelRedondeado1,
                PanelTheme.Blue
            );

            ConfigurePanel(
                panelRedondeado2,
                PanelTheme.Green
            );

            ConfigurePanel(
                panelRedondeado3,
                PanelTheme.Orange
            );

            ConfigurePanel(
                panelRedondeado4,
                PanelTheme.Purple
            );
        }

        private static void ConfigurePanel(
            RoundedPanel panel,
            PanelTheme theme)
        {
            panel.Theme = theme;
            panel.BorderRadius = 16;
            panel.BorderThickness = 1;
            panel.Padding = new Padding(22);
        }

        private void ConfigureLabels()
        {
            LblFirstNumber.ForeColor =
                Color.FromArgb(24, 103, 188);

            LblSeconNumber.ForeColor =
                Color.FromArgb(40, 145, 73);

            LblSelectOperation.ForeColor =
                Color.FromArgb(237, 145, 8);

            LblResult.ForeColor =
                Color.FromArgb(123, 72, 184);
        }

        private void ConfigureOperationButtons()
        {
            BtnAdd.SymbolColor =
                Color.FromArgb(31, 116, 204);

            BtnSubstract.SymbolColor =
                Color.FromArgb(235, 61, 61);

            BtnMultiply.SymbolColor =
                Color.FromArgb(54, 160, 91);

            BtnDivide.SymbolColor =
                Color.FromArgb(127, 74, 183);
        }
    }
}