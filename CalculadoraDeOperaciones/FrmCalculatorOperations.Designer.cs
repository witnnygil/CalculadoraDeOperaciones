using CalculadoraDeOperaciones.CustomControls;

namespace CalculadoraDeOperaciones
{
    partial class FrmCalculatorOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

        /// <summary>
        /// Releases the resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true to release managed resources; otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panelRedondeado1 = new RoundedPanel();
            CnStep1 = new CircularNumber();
            LblFirstNumber = new Label();
            TxtFirstNumber = new TextBox();
            panelRedondeado2 = new RoundedPanel();
            CnStep2 = new CircularNumber();
            LblSeconNumber = new Label();
            TxtSecondNumber = new TextBox();
            panelRedondeado3 = new RoundedPanel();
            CnStep3 = new CircularNumber();
            LblSelectOperation = new Label();
            BtnAdd = new OperationButton();
            BtnSubstract = new OperationButton();
            BtnMultiply = new OperationButton();
            BtnDivide = new OperationButton();
            panelRedondeado4 = new RoundedPanel();
            CnResult = new CircularNumber();
            LblResult = new Label();
            TxtResult = new TextBox();
            textBox3 = new TextBox();
            BtnClean = new Button();
            panelRedondeado1.SuspendLayout();
            panelRedondeado2.SuspendLayout();
            panelRedondeado3.SuspendLayout();
            panelRedondeado4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(161, 26);
            label1.Name = "label1";
            label1.Size = new Size(400, 40);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Operaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(155, 66);
            label2.Name = "label2";
            label2.Size = new Size(413, 19);
            label2.TabIndex = 1;
            label2.Text = "Ingresa dos números, selecciona la operación y obtén el resultado.";
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.FromArgb(250, 253, 255);
            panelRedondeado1.Controls.Add(CnStep1);
            panelRedondeado1.Controls.Add(LblFirstNumber);
            panelRedondeado1.Controls.Add(TxtFirstNumber);
            panelRedondeado1.Location = new Point(28, 105);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.Padding = new Padding(18);
            panelRedondeado1.Size = new Size(330, 100);
            panelRedondeado1.TabIndex = 2;
            panelRedondeado1.Theme = PanelTheme.Blue;
            // 
            // CnStep1
            // 
            CnStep1.BackColor = Color.Transparent;
            CnStep1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CnStep1.ForeColor = Color.White;
            CnStep1.Location = new Point(18, 11);
            CnStep1.MinimumSize = new Size(24, 24);
            CnStep1.Name = "CnStep1";
            CnStep1.Size = new Size(30, 30);
            CnStep1.TabIndex = 0;
            CnStep1.TabStop = false;
            // 
            // LblFirstNumber
            // 
            LblFirstNumber.AutoSize = true;
            LblFirstNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LblFirstNumber.ForeColor = Color.FromArgb(24, 103, 188);
            LblFirstNumber.Location = new Point(59, 16);
            LblFirstNumber.Name = "LblFirstNumber";
            LblFirstNumber.Size = new Size(115, 20);
            LblFirstNumber.TabIndex = 1;
            LblFirstNumber.Text = "Primer número";
            // 
            // TxtFirstNumber
            // 
            TxtFirstNumber.Font = new Font("Segoe UI", 12F);
            TxtFirstNumber.Location = new Point(19, 52);
            TxtFirstNumber.Name = "TxtFirstNumber";
            TxtFirstNumber.PlaceholderText = "Ej: 15";
            TxtFirstNumber.Size = new Size(292, 29);
            TxtFirstNumber.TabIndex = 2;
            // 
            // panelRedondeado2
            // 
            panelRedondeado2.BackColor = Color.FromArgb(250, 253, 250);
            panelRedondeado2.Controls.Add(CnStep2);
            panelRedondeado2.Controls.Add(LblSeconNumber);
            panelRedondeado2.Controls.Add(TxtSecondNumber);
            panelRedondeado2.Location = new Point(379, 105);
            panelRedondeado2.Name = "panelRedondeado2";
            panelRedondeado2.Padding = new Padding(18);
            panelRedondeado2.Size = new Size(330, 100);
            panelRedondeado2.TabIndex = 3;
            panelRedondeado2.Theme = PanelTheme.Green;
            // 
            // CnStep2
            // 
            CnStep2.BackColor = Color.Transparent;
            CnStep2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CnStep2.ForeColor = Color.White;
            CnStep2.Location = new Point(18, 11);
            CnStep2.MinimumSize = new Size(24, 24);
            CnStep2.Name = "CnStep2";
            CnStep2.Size = new Size(30, 30);
            CnStep2.TabIndex = 0;
            CnStep2.TabStop = false;
            CnStep2.Text = "2";
            CnStep2.Theme = CircularNumberTheme.Green;
            // 
            // LblSeconNumber
            // 
            LblSeconNumber.AutoSize = true;
            LblSeconNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LblSeconNumber.ForeColor = Color.FromArgb(40, 145, 73);
            LblSeconNumber.Location = new Point(59, 16);
            LblSeconNumber.Name = "LblSeconNumber";
            LblSeconNumber.Size = new Size(129, 20);
            LblSeconNumber.TabIndex = 1;
            LblSeconNumber.Text = "Segundo número";
            // 
            // TxtSecondNumber
            // 
            TxtSecondNumber.Font = new Font("Segoe UI", 12F);
            TxtSecondNumber.Location = new Point(19, 52);
            TxtSecondNumber.Name = "TxtSecondNumber";
            TxtSecondNumber.PlaceholderText = "Ej: 7";
            TxtSecondNumber.Size = new Size(292, 29);
            TxtSecondNumber.TabIndex = 2;
            // 
            // panelRedondeado3
            // 
            panelRedondeado3.BackColor = Color.FromArgb(255, 253, 248);
            panelRedondeado3.Controls.Add(CnStep3);
            panelRedondeado3.Controls.Add(LblSelectOperation);
            panelRedondeado3.Controls.Add(BtnAdd);
            panelRedondeado3.Controls.Add(BtnSubstract);
            panelRedondeado3.Controls.Add(BtnMultiply);
            panelRedondeado3.Controls.Add(BtnDivide);
            panelRedondeado3.Location = new Point(28, 220);
            panelRedondeado3.Name = "panelRedondeado3";
            panelRedondeado3.Padding = new Padding(18);
            panelRedondeado3.Size = new Size(681, 122);
            panelRedondeado3.TabIndex = 4;
            panelRedondeado3.Theme = PanelTheme.Orange;
            // 
            // CnStep3
            // 
            CnStep3.BackColor = Color.Transparent;
            CnStep3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CnStep3.ForeColor = Color.White;
            CnStep3.Location = new Point(18, 11);
            CnStep3.MinimumSize = new Size(24, 24);
            CnStep3.Name = "CnStep3";
            CnStep3.Size = new Size(30, 30);
            CnStep3.TabIndex = 0;
            CnStep3.TabStop = false;
            CnStep3.Text = "3";
            CnStep3.Theme = CircularNumberTheme.Orange;
            // 
            // LblSelectOperation
            // 
            LblSelectOperation.AutoSize = true;
            LblSelectOperation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LblSelectOperation.ForeColor = Color.FromArgb(237, 145, 8);
            LblSelectOperation.Location = new Point(59, 16);
            LblSelectOperation.Name = "LblSelectOperation";
            LblSelectOperation.Size = new Size(170, 20);
            LblSelectOperation.TabIndex = 1;
            LblSelectOperation.Text = "Selecciona la operación";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.Transparent;
            BtnAdd.BorderRadius = 10;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnAdd.ForeColor = Color.FromArgb(20, 20, 20);
            BtnAdd.IconTextSpacing = 10;
            BtnAdd.Location = new Point(19, 57);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(150, 45);
            BtnAdd.SymbolSize = 24F;
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Suma";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnSubstract
            // 
            BtnSubstract.BackColor = Color.Transparent;
            BtnSubstract.BorderRadius = 10;
            BtnSubstract.FlatStyle = FlatStyle.Flat;
            BtnSubstract.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSubstract.ForeColor = Color.FromArgb(20, 20, 20);
            BtnSubstract.IconTextSpacing = 10;
            BtnSubstract.Location = new Point(183, 57);
            BtnSubstract.Name = "BtnSubstract";
            BtnSubstract.Size = new Size(150, 45);
            BtnSubstract.Symbol = "−";
            BtnSubstract.SymbolSize = 24F;
            BtnSubstract.TabIndex = 3;
            BtnSubstract.Text = "Resta";
            BtnSubstract.UseVisualStyleBackColor = false;
            BtnSubstract.Click += BtnSubstract_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.Transparent;
            BtnMultiply.BorderRadius = 10;
            BtnMultiply.FlatStyle = FlatStyle.Flat;
            BtnMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnMultiply.ForeColor = Color.FromArgb(20, 20, 20);
            BtnMultiply.IconTextSpacing = 10;
            BtnMultiply.Location = new Point(347, 57);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(150, 45);
            BtnMultiply.Symbol = "×";
            BtnMultiply.SymbolSize = 24F;
            BtnMultiply.TabIndex = 4;
            BtnMultiply.Text = "Multiplicación";
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnMultiply_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.BackColor = Color.Transparent;
            BtnDivide.BorderRadius = 10;
            BtnDivide.FlatStyle = FlatStyle.Flat;
            BtnDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnDivide.ForeColor = Color.FromArgb(20, 20, 20);
            BtnDivide.IconTextSpacing = 10;
            BtnDivide.Location = new Point(511, 57);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(150, 45);
            BtnDivide.Symbol = "÷";
            BtnDivide.SymbolSize = 24F;
            BtnDivide.TabIndex = 5;
            BtnDivide.Text = "División";
            BtnDivide.UseVisualStyleBackColor = false;
            BtnDivide.Click += BtnDivide_Click;
            // 
            // panelRedondeado4
            // 
            panelRedondeado4.BackColor = Color.FromArgb(253, 250, 255);
            panelRedondeado4.Controls.Add(CnResult);
            panelRedondeado4.Controls.Add(LblResult);
            panelRedondeado4.Controls.Add(TxtResult);
            panelRedondeado4.Location = new Point(28, 357);
            panelRedondeado4.Name = "panelRedondeado4";
            panelRedondeado4.Padding = new Padding(18);
            panelRedondeado4.Size = new Size(681, 65);
            panelRedondeado4.TabIndex = 5;
            panelRedondeado4.Theme = PanelTheme.Purple;
            // 
            // CnResult
            // 
            CnResult.BackColor = Color.Transparent;
            CnResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CnResult.ForeColor = Color.White;
            CnResult.Location = new Point(18, 17);
            CnResult.MinimumSize = new Size(24, 24);
            CnResult.Name = "CnResult";
            CnResult.Size = new Size(30, 30);
            CnResult.TabIndex = 0;
            CnResult.TabStop = false;
            CnResult.Text = "=";
            CnResult.Theme = CircularNumberTheme.Purple;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LblResult.ForeColor = Color.FromArgb(123, 72, 184);
            LblResult.Location = new Point(59, 22);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(79, 20);
            LblResult.TabIndex = 1;
            LblResult.Text = "Resultado";
            // 
            // TxtResult
            // 
            TxtResult.Font = new Font("Segoe UI", 12F);
            TxtResult.Location = new Point(165, 18);
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(496, 29);
            TxtResult.TabIndex = 2;
            TxtResult.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            textBox3.Visible = false;
            // 
            // BtnClean
            // 
            BtnClean.Location = new Point(281, 437);
            BtnClean.Name = "BtnClean";
            BtnClean.Size = new Size(179, 42);
            BtnClean.TabIndex = 7;
            BtnClean.Text = "Limpiar";
            BtnClean.UseVisualStyleBackColor = true;
            BtnClean.Click += BtnClean_Click;
            // 
            // FrmCalculatorOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 252);
            ClientSize = new Size(737, 525);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panelRedondeado1);
            Controls.Add(panelRedondeado2);
            Controls.Add(panelRedondeado3);
            Controls.Add(panelRedondeado4);
            Controls.Add(BtnClean);
            Name = "FrmCalculatorOperations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Operaciones";
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            panelRedondeado2.ResumeLayout(false);
            panelRedondeado2.PerformLayout();
            panelRedondeado3.ResumeLayout(false);
            panelRedondeado3.PerformLayout();
            panelRedondeado4.ResumeLayout(false);
            panelRedondeado4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnClean;

        private RoundedPanel panelRedondeado1;
        private RoundedPanel panelRedondeado2;
        private RoundedPanel panelRedondeado3;
        private RoundedPanel panelRedondeado4;

        private CircularNumber CnStep1;
        private CircularNumber CnStep2;
        private CircularNumber CnStep3;
        private CircularNumber CnResult;

        private Label LblFirstNumber;
        private Label LblSeconNumber;
        private Label LblSelectOperation;
        private Label LblResult;

        private TextBox TxtFirstNumber;
        private TextBox TxtSecondNumber;
        private TextBox textBox3;
        private TextBox TxtResult;

        private OperationButton BtnAdd;
        private OperationButton BtnSubstract;
        private OperationButton BtnMultiply;
        private OperationButton BtnDivide;
    }
}
