namespace p_ch_m_i
{
    partial class formSpravka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSpravka));
            roundedPanel1 = new RoundedPanel();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Gainsboro;
            roundedPanel1.BackgroundColor = Color.Gainsboro;
            roundedPanel1.BorderColor = Color.PaleVioletRed;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderSize = 0;
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(49, 38);
            roundedPanel1.Margin = new Padding(3, 2, 3, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1095, 608);
            roundedPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(1032, 608);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // formSpravka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 686);
            Controls.Add(roundedPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formSpravka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label label1;
    }
}