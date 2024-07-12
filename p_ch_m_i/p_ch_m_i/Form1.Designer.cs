using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_ch_m_i
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            btnSpravka = new Button();
            panel1 = new Panel();
            buttonSending = new Button();
            buttonPurchases = new Button();
            buttonSupplies = new Button();
            buttonProviders = new Button();
            buttonGoods = new Button();
            buttonOrders = new Button();
            panelLogo = new Panel();
            tabOform = new TabPage();
            btnCancel = new RoundedButton();
            btnOform = new RoundedButton();
            roundedPanel1 = new RoundedPanel();
            label3 = new Label();
            tbQuantity = new TextBox();
            label1 = new Label();
            cbProducts = new ComboBox();
            label2 = new Label();
            cbProviders = new ComboBox();
            tabSending = new TabPage();
            pnlSendings = new RoundedPanel();
            dgvSendings = new DataGridView();
            tabPurchases = new TabPage();
            pnlPurchases = new RoundedPanel();
            dgvPurchases = new DataGridView();
            tabSupplies = new TabPage();
            pnlSupplies = new RoundedPanel();
            dgvSupplies = new DataGridView();
            tabProviders = new TabPage();
            btnDeleteProvider = new RoundedButton();
            pnlProviders = new RoundedPanel();
            dgvProviders = new DataGridView();
            tabProducts = new TabPage();
            btnOformZakupku = new RoundedButton();
            btnDeleteProduct = new RoundedButton();
            pnlProducts = new RoundedPanel();
            dgvProducts = new DataGridView();
            tabOrders = new TabPage();
            pnlOrders = new RoundedPanel();
            dgvOrders = new DataGridView();
            tabControl = new TabControl();
            panelMenu.SuspendLayout();
            tabOform.SuspendLayout();
            roundedPanel1.SuspendLayout();
            tabSending.SuspendLayout();
            pnlSendings.SuspendLayout();
            ((ISupportInitialize)dgvSendings).BeginInit();
            tabPurchases.SuspendLayout();
            pnlPurchases.SuspendLayout();
            ((ISupportInitialize)dgvPurchases).BeginInit();
            tabSupplies.SuspendLayout();
            pnlSupplies.SuspendLayout();
            ((ISupportInitialize)dgvSupplies).BeginInit();
            tabProviders.SuspendLayout();
            pnlProviders.SuspendLayout();
            ((ISupportInitialize)dgvProviders).BeginInit();
            tabProducts.SuspendLayout();
            pnlProducts.SuspendLayout();
            ((ISupportInitialize)dgvProducts).BeginInit();
            tabOrders.SuspendLayout();
            pnlOrders.SuspendLayout();
            ((ISupportInitialize)dgvOrders).BeginInit();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnSpravka);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(buttonSending);
            panelMenu.Controls.Add(buttonPurchases);
            panelMenu.Controls.Add(buttonSupplies);
            panelMenu.Controls.Add(buttonProviders);
            panelMenu.Controls.Add(buttonGoods);
            panelMenu.Controls.Add(buttonOrders);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 482);
            panelMenu.TabIndex = 0;
            // 
            // btnSpravka
            // 
            btnSpravka.Cursor = Cursors.Hand;
            btnSpravka.Dock = DockStyle.Top;
            btnSpravka.FlatAppearance.BorderSize = 0;
            btnSpravka.FlatStyle = FlatStyle.Flat;
            btnSpravka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpravka.ForeColor = SystemColors.Control;
            btnSpravka.Location = new Point(0, 410);
            btnSpravka.Margin = new Padding(3, 2, 3, 2);
            btnSpravka.Name = "btnSpravka";
            btnSpravka.Padding = new Padding(26, 0, 0, 0);
            btnSpravka.Size = new Size(190, 45);
            btnSpravka.TabIndex = 8;
            btnSpravka.Text = "Справка";
            btnSpravka.TextAlign = ContentAlignment.MiddleLeft;
            btnSpravka.UseVisualStyleBackColor = true;
            btnSpravka.Click += btnSpravka_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 340);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 70);
            panel1.TabIndex = 7;
            // 
            // buttonSending
            // 
            buttonSending.Cursor = Cursors.Hand;
            buttonSending.Dock = DockStyle.Top;
            buttonSending.FlatAppearance.BorderSize = 0;
            buttonSending.FlatStyle = FlatStyle.Flat;
            buttonSending.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSending.ForeColor = SystemColors.Control;
            buttonSending.Location = new Point(0, 295);
            buttonSending.Margin = new Padding(3, 2, 3, 2);
            buttonSending.Name = "buttonSending";
            buttonSending.Padding = new Padding(26, 0, 0, 0);
            buttonSending.Size = new Size(190, 45);
            buttonSending.TabIndex = 6;
            buttonSending.Text = "Отправки";
            buttonSending.TextAlign = ContentAlignment.MiddleLeft;
            buttonSending.UseVisualStyleBackColor = true;
            buttonSending.Click += buttonSending_Click;
            // 
            // buttonPurchases
            // 
            buttonPurchases.Cursor = Cursors.Hand;
            buttonPurchases.Dock = DockStyle.Top;
            buttonPurchases.FlatAppearance.BorderSize = 0;
            buttonPurchases.FlatStyle = FlatStyle.Flat;
            buttonPurchases.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPurchases.ForeColor = SystemColors.Control;
            buttonPurchases.Location = new Point(0, 250);
            buttonPurchases.Margin = new Padding(3, 2, 3, 2);
            buttonPurchases.Name = "buttonPurchases";
            buttonPurchases.Padding = new Padding(26, 0, 0, 0);
            buttonPurchases.Size = new Size(190, 45);
            buttonPurchases.TabIndex = 5;
            buttonPurchases.Text = "Закупки";
            buttonPurchases.TextAlign = ContentAlignment.MiddleLeft;
            buttonPurchases.UseVisualStyleBackColor = true;
            buttonPurchases.Click += buttonPurchases_Click;
            // 
            // buttonSupplies
            // 
            buttonSupplies.Cursor = Cursors.Hand;
            buttonSupplies.Dock = DockStyle.Top;
            buttonSupplies.FlatAppearance.BorderSize = 0;
            buttonSupplies.FlatStyle = FlatStyle.Flat;
            buttonSupplies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupplies.ForeColor = SystemColors.Control;
            buttonSupplies.Location = new Point(0, 205);
            buttonSupplies.Margin = new Padding(3, 2, 3, 2);
            buttonSupplies.Name = "buttonSupplies";
            buttonSupplies.Padding = new Padding(26, 0, 0, 0);
            buttonSupplies.Size = new Size(190, 45);
            buttonSupplies.TabIndex = 4;
            buttonSupplies.Text = "Поставки";
            buttonSupplies.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupplies.UseVisualStyleBackColor = true;
            buttonSupplies.Click += buttonSupplies_Click;
            // 
            // buttonProviders
            // 
            buttonProviders.Cursor = Cursors.Hand;
            buttonProviders.Dock = DockStyle.Top;
            buttonProviders.FlatAppearance.BorderSize = 0;
            buttonProviders.FlatStyle = FlatStyle.Flat;
            buttonProviders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProviders.ForeColor = SystemColors.Control;
            buttonProviders.Location = new Point(0, 160);
            buttonProviders.Margin = new Padding(3, 2, 3, 2);
            buttonProviders.Name = "buttonProviders";
            buttonProviders.Padding = new Padding(26, 0, 0, 0);
            buttonProviders.Size = new Size(190, 45);
            buttonProviders.TabIndex = 3;
            buttonProviders.Text = "Поставщики";
            buttonProviders.TextAlign = ContentAlignment.MiddleLeft;
            buttonProviders.UseVisualStyleBackColor = true;
            buttonProviders.Click += buttonProviders_Click;
            // 
            // buttonGoods
            // 
            buttonGoods.Cursor = Cursors.Hand;
            buttonGoods.Dock = DockStyle.Top;
            buttonGoods.FlatAppearance.BorderSize = 0;
            buttonGoods.FlatStyle = FlatStyle.Flat;
            buttonGoods.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGoods.ForeColor = SystemColors.Control;
            buttonGoods.Location = new Point(0, 115);
            buttonGoods.Margin = new Padding(3, 2, 3, 2);
            buttonGoods.Name = "buttonGoods";
            buttonGoods.Padding = new Padding(26, 0, 0, 0);
            buttonGoods.Size = new Size(190, 45);
            buttonGoods.TabIndex = 2;
            buttonGoods.Text = "Товары";
            buttonGoods.TextAlign = ContentAlignment.MiddleLeft;
            buttonGoods.UseVisualStyleBackColor = true;
            buttonGoods.Click += buttonGoods_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.Cursor = Cursors.Hand;
            buttonOrders.Dock = DockStyle.Top;
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOrders.ForeColor = SystemColors.Control;
            buttonOrders.Location = new Point(0, 70);
            buttonOrders.Margin = new Padding(3, 2, 3, 2);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Padding = new Padding(26, 0, 0, 0);
            buttonOrders.Size = new Size(190, 45);
            buttonOrders.TabIndex = 1;
            buttonOrders.Text = "Заказы";
            buttonOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonOrders.UseVisualStyleBackColor = true;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(190, 70);
            panelLogo.TabIndex = 0;
            // 
            // tabOform
            // 
            tabOform.Controls.Add(btnCancel);
            tabOform.Controls.Add(btnOform);
            tabOform.Controls.Add(roundedPanel1);
            tabOform.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabOform.Location = new Point(4, 54);
            tabOform.Margin = new Padding(3, 2, 3, 2);
            tabOform.Name = "tabOform";
            tabOform.Size = new Size(749, 424);
            tabOform.TabIndex = 6;
            tabOform.Text = "Оформление закупки";
            tabOform.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.Crimson;
            btnCancel.BackgroundColor = Color.Crimson;
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 20;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(457, 419);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Отмена";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOform
            // 
            btnOform.Anchor = AnchorStyles.Top;
            btnOform.BackColor = Color.MediumSlateBlue;
            btnOform.BackgroundColor = Color.MediumSlateBlue;
            btnOform.BorderColor = Color.PaleVioletRed;
            btnOform.BorderRadius = 20;
            btnOform.BorderSize = 0;
            btnOform.FlatAppearance.BorderSize = 0;
            btnOform.FlatStyle = FlatStyle.Flat;
            btnOform.ForeColor = Color.White;
            btnOform.Location = new Point(256, 419);
            btnOform.Margin = new Padding(3, 2, 3, 2);
            btnOform.Name = "btnOform";
            btnOform.Size = new Size(148, 29);
            btnOform.TabIndex = 9;
            btnOform.Text = "Оформить";
            btnOform.TextColor = Color.White;
            btnOform.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top;
            roundedPanel1.BackColor = SystemColors.ButtonFace;
            roundedPanel1.BackgroundColor = SystemColors.ButtonFace;
            roundedPanel1.BorderColor = Color.PaleVioletRed;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderSize = 0;
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(tbQuantity);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(cbProducts);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(cbProviders);
            roundedPanel1.Location = new Point(167, 123);
            roundedPanel1.Margin = new Padding(3, 2, 3, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(521, 260);
            roundedPanel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 115);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 4;
            label3.Text = "Количество:";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(246, 116);
            tbQuantity.Margin = new Padding(3, 2, 3, 2);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(210, 23);
            tbQuantity.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 172);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Код поставщика:";
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(246, 56);
            cbProducts.Margin = new Padding(3, 2, 3, 2);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(210, 23);
            cbProducts.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 55);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Код товара:";
            // 
            // cbProviders
            // 
            cbProviders.FormattingEnabled = true;
            cbProviders.Location = new Point(246, 170);
            cbProviders.Margin = new Padding(3, 2, 3, 2);
            cbProviders.Name = "cbProviders";
            cbProviders.Size = new Size(210, 23);
            cbProviders.TabIndex = 5;
            // 
            // tabSending
            // 
            tabSending.Controls.Add(pnlSendings);
            tabSending.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabSending.Location = new Point(4, 54);
            tabSending.Margin = new Padding(3, 2, 3, 2);
            tabSending.Name = "tabSending";
            tabSending.Size = new Size(749, 424);
            tabSending.TabIndex = 5;
            tabSending.Text = "Отправки";
            tabSending.UseVisualStyleBackColor = true;
            // 
            // pnlSendings
            // 
            pnlSendings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSendings.BackColor = Color.MediumSlateBlue;
            pnlSendings.BackgroundColor = Color.MediumSlateBlue;
            pnlSendings.BorderColor = Color.PaleVioletRed;
            pnlSendings.BorderRadius = 20;
            pnlSendings.BorderSize = 0;
            pnlSendings.Controls.Add(dgvSendings);
            pnlSendings.Location = new Point(76, 38);
            pnlSendings.Margin = new Padding(3, 2, 3, 2);
            pnlSendings.Name = "pnlSendings";
            pnlSendings.Size = new Size(602, 304);
            pnlSendings.TabIndex = 4;
            // 
            // dgvSendings
            // 
            dgvSendings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 210, 252);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dgvSendings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSendings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSendings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSendings.BackgroundColor = Color.WhiteSmoke;
            dgvSendings.BorderStyle = BorderStyle.None;
            dgvSendings.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSendings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSendings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSendings.ColumnHeadersHeight = 50;
            dgvSendings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSendings.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSendings.EnableHeadersVisualStyles = false;
            dgvSendings.GridColor = SystemColors.Control;
            dgvSendings.Location = new Point(0, 2);
            dgvSendings.Margin = new Padding(3, 2, 3, 2);
            dgvSendings.MultiSelect = false;
            dgvSendings.Name = "dgvSendings";
            dgvSendings.RowHeadersWidth = 51;
            dgvSendings.RowTemplate.Height = 29;
            dgvSendings.Size = new Size(602, 302);
            dgvSendings.TabIndex = 3;
            // 
            // tabPurchases
            // 
            tabPurchases.Controls.Add(pnlPurchases);
            tabPurchases.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPurchases.Location = new Point(4, 54);
            tabPurchases.Margin = new Padding(3, 2, 3, 2);
            tabPurchases.Name = "tabPurchases";
            tabPurchases.Size = new Size(749, 424);
            tabPurchases.TabIndex = 4;
            tabPurchases.Text = "Закупки";
            tabPurchases.UseVisualStyleBackColor = true;
            // 
            // pnlPurchases
            // 
            pnlPurchases.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPurchases.BackColor = Color.MediumSlateBlue;
            pnlPurchases.BackgroundColor = Color.MediumSlateBlue;
            pnlPurchases.BorderColor = Color.PaleVioletRed;
            pnlPurchases.BorderRadius = 20;
            pnlPurchases.BorderSize = 0;
            pnlPurchases.Controls.Add(dgvPurchases);
            pnlPurchases.Location = new Point(76, 38);
            pnlPurchases.Margin = new Padding(3, 2, 3, 2);
            pnlPurchases.Name = "pnlPurchases";
            pnlPurchases.Size = new Size(593, 308);
            pnlPurchases.TabIndex = 4;
            // 
            // dgvPurchases
            // 
            dgvPurchases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(220, 210, 252);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dgvPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPurchases.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchases.BackgroundColor = Color.WhiteSmoke;
            dgvPurchases.BorderStyle = BorderStyle.None;
            dgvPurchases.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPurchases.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPurchases.ColumnHeadersHeight = 50;
            dgvPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPurchases.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPurchases.EnableHeadersVisualStyles = false;
            dgvPurchases.GridColor = SystemColors.Control;
            dgvPurchases.Location = new Point(0, 2);
            dgvPurchases.Margin = new Padding(3, 2, 3, 2);
            dgvPurchases.MultiSelect = false;
            dgvPurchases.Name = "dgvPurchases";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPurchases.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPurchases.RowHeadersWidth = 51;
            dgvPurchases.RowTemplate.Height = 29;
            dgvPurchases.Size = new Size(593, 305);
            dgvPurchases.TabIndex = 5;
            // 
            // tabSupplies
            // 
            tabSupplies.Controls.Add(pnlSupplies);
            tabSupplies.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabSupplies.Location = new Point(4, 54);
            tabSupplies.Margin = new Padding(3, 2, 3, 2);
            tabSupplies.Name = "tabSupplies";
            tabSupplies.Size = new Size(749, 424);
            tabSupplies.TabIndex = 3;
            tabSupplies.Text = "Поставки";
            tabSupplies.UseVisualStyleBackColor = true;
            // 
            // pnlSupplies
            // 
            pnlSupplies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSupplies.BackColor = Color.MediumSlateBlue;
            pnlSupplies.BackgroundColor = Color.MediumSlateBlue;
            pnlSupplies.BorderColor = Color.PaleVioletRed;
            pnlSupplies.BorderRadius = 20;
            pnlSupplies.BorderSize = 0;
            pnlSupplies.Controls.Add(dgvSupplies);
            pnlSupplies.Location = new Point(76, 38);
            pnlSupplies.Margin = new Padding(3, 2, 3, 2);
            pnlSupplies.Name = "pnlSupplies";
            pnlSupplies.Size = new Size(579, 316);
            pnlSupplies.TabIndex = 4;
            // 
            // dgvSupplies
            // 
            dgvSupplies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(220, 210, 252);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dgvSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvSupplies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSupplies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplies.BackgroundColor = Color.WhiteSmoke;
            dgvSupplies.BorderStyle = BorderStyle.None;
            dgvSupplies.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSupplies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvSupplies.ColumnHeadersHeight = 50;
            dgvSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvSupplies.DefaultCellStyle = dataGridViewCellStyle10;
            dgvSupplies.EnableHeadersVisualStyles = false;
            dgvSupplies.GridColor = SystemColors.Control;
            dgvSupplies.Location = new Point(0, 2);
            dgvSupplies.Margin = new Padding(3, 2, 3, 2);
            dgvSupplies.MultiSelect = false;
            dgvSupplies.Name = "dgvSupplies";
            dgvSupplies.RowHeadersWidth = 51;
            dgvSupplies.RowTemplate.Height = 29;
            dgvSupplies.Size = new Size(579, 314);
            dgvSupplies.TabIndex = 3;
            // 
            // tabProviders
            // 
            tabProviders.Controls.Add(btnDeleteProvider);
            tabProviders.Controls.Add(pnlProviders);
            tabProviders.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabProviders.Location = new Point(4, 54);
            tabProviders.Margin = new Padding(3, 2, 3, 2);
            tabProviders.Name = "tabProviders";
            tabProviders.Size = new Size(749, 424);
            tabProviders.TabIndex = 2;
            tabProviders.Text = "Поставщики";
            tabProviders.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProvider
            // 
            btnDeleteProvider.Anchor = AnchorStyles.Bottom;
            btnDeleteProvider.BackColor = Color.Crimson;
            btnDeleteProvider.BackgroundColor = Color.Crimson;
            btnDeleteProvider.BorderColor = Color.PaleVioletRed;
            btnDeleteProvider.BorderRadius = 18;
            btnDeleteProvider.BorderSize = 0;
            btnDeleteProvider.FlatAppearance.BorderSize = 0;
            btnDeleteProvider.FlatStyle = FlatStyle.Flat;
            btnDeleteProvider.ForeColor = Color.White;
            btnDeleteProvider.Location = new Point(317, 346);
            btnDeleteProvider.Margin = new Padding(3, 2, 3, 2);
            btnDeleteProvider.Name = "btnDeleteProvider";
            btnDeleteProvider.Size = new Size(128, 27);
            btnDeleteProvider.TabIndex = 8;
            btnDeleteProvider.Text = "Удалить";
            btnDeleteProvider.TextColor = Color.White;
            btnDeleteProvider.UseVisualStyleBackColor = false;
            // 
            // pnlProviders
            // 
            pnlProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProviders.BackColor = Color.MediumSlateBlue;
            pnlProviders.BackgroundColor = Color.MediumSlateBlue;
            pnlProviders.BorderColor = Color.PaleVioletRed;
            pnlProviders.BorderRadius = 20;
            pnlProviders.BorderSize = 0;
            pnlProviders.Controls.Add(dgvProviders);
            pnlProviders.Location = new Point(76, 38);
            pnlProviders.Margin = new Padding(3, 2, 3, 2);
            pnlProviders.Name = "pnlProviders";
            pnlProviders.Size = new Size(601, 293);
            pnlProviders.TabIndex = 3;
            // 
            // dgvProviders
            // 
            dgvProviders.AllowUserToAddRows = false;
            dgvProviders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(220, 210, 252);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dgvProviders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProviders.BackgroundColor = Color.WhiteSmoke;
            dgvProviders.BorderStyle = BorderStyle.None;
            dgvProviders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProviders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle12.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvProviders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvProviders.ColumnHeadersHeight = 50;
            dgvProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvProviders.DefaultCellStyle = dataGridViewCellStyle13;
            dgvProviders.EnableHeadersVisualStyles = false;
            dgvProviders.GridColor = SystemColors.Control;
            dgvProviders.Location = new Point(0, 2);
            dgvProviders.Margin = new Padding(3, 2, 3, 2);
            dgvProviders.MultiSelect = false;
            dgvProviders.Name = "dgvProviders";
            dgvProviders.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvProviders.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvProviders.RowHeadersWidth = 51;
            dgvProviders.RowTemplate.Height = 29;
            dgvProviders.Size = new Size(601, 291);
            dgvProviders.TabIndex = 5;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(btnOformZakupku);
            tabProducts.Controls.Add(btnDeleteProduct);
            tabProducts.Controls.Add(pnlProducts);
            tabProducts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabProducts.Location = new Point(4, 54);
            tabProducts.Margin = new Padding(3, 2, 3, 2);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3, 2, 3, 2);
            tabProducts.Size = new Size(749, 424);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Товары";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnOformZakupku
            // 
            btnOformZakupku.Anchor = AnchorStyles.Bottom;
            btnOformZakupku.BackColor = Color.MediumSlateBlue;
            btnOformZakupku.BackgroundColor = Color.MediumSlateBlue;
            btnOformZakupku.BorderColor = Color.PaleVioletRed;
            btnOformZakupku.BorderRadius = 18;
            btnOformZakupku.BorderSize = 0;
            btnOformZakupku.FlatAppearance.BorderSize = 0;
            btnOformZakupku.FlatStyle = FlatStyle.Flat;
            btnOformZakupku.ForeColor = Color.White;
            btnOformZakupku.Location = new Point(230, 332);
            btnOformZakupku.Margin = new Padding(3, 2, 3, 2);
            btnOformZakupku.Name = "btnOformZakupku";
            btnOformZakupku.Size = new Size(172, 27);
            btnOformZakupku.TabIndex = 7;
            btnOformZakupku.Text = "Оформить закупку";
            btnOformZakupku.TextColor = Color.White;
            btnOformZakupku.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom;
            btnDeleteProduct.BackColor = Color.Crimson;
            btnDeleteProduct.BackgroundColor = Color.Crimson;
            btnDeleteProduct.BorderColor = Color.PaleVioletRed;
            btnDeleteProduct.BorderRadius = 18;
            btnDeleteProduct.BorderSize = 0;
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(424, 332);
            btnDeleteProduct.Margin = new Padding(3, 2, 3, 2);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(128, 27);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Удалить";
            btnDeleteProduct.TextColor = Color.White;
            btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // pnlProducts
            // 
            pnlProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProducts.BackColor = Color.MediumSlateBlue;
            pnlProducts.BackgroundColor = Color.MediumSlateBlue;
            pnlProducts.BorderColor = Color.PaleVioletRed;
            pnlProducts.BorderRadius = 20;
            pnlProducts.BorderSize = 0;
            pnlProducts.Controls.Add(dgvProducts);
            pnlProducts.Location = new Point(76, 38);
            pnlProducts.Margin = new Padding(3, 2, 3, 2);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(614, 273);
            pnlProducts.TabIndex = 3;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(220, 210, 252);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.WhiteSmoke;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle16.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvProducts.ColumnHeadersHeight = 50;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle17;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = SystemColors.Control;
            dgvProducts.Location = new Point(0, 2);
            dgvProducts.Margin = new Padding(3, 2, 3, 2);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(614, 271);
            dgvProducts.TabIndex = 5;
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(pnlOrders);
            tabOrders.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabOrders.Location = new Point(4, 104);
            tabOrders.Margin = new Padding(3, 2, 3, 2);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(3, 2, 3, 2);
            tabOrders.Size = new Size(750, 374);
            tabOrders.TabIndex = 0;
            tabOrders.Text = "Заказы";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // pnlOrders
            // 
            pnlOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlOrders.BackColor = Color.MediumSlateBlue;
            pnlOrders.BackgroundColor = Color.MediumSlateBlue;
            pnlOrders.BorderColor = Color.PaleVioletRed;
            pnlOrders.BorderRadius = 20;
            pnlOrders.BorderSize = 0;
            pnlOrders.Controls.Add(dgvOrders);
            pnlOrders.Location = new Point(76, 38);
            pnlOrders.Margin = new Padding(3, 2, 3, 2);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(552, 234);
            pnlOrders.TabIndex = 2;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(220, 210, 252);
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.WhiteSmoke;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle20.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle20.SelectionForeColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dgvOrders.ColumnHeadersHeight = 50;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(242, 240, 252);
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(164, 150, 242);
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle21;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.GridColor = SystemColors.Control;
            dgvOrders.Location = new Point(0, 2);
            dgvOrders.Margin = new Padding(3, 2, 3, 2);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Control;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.Size = new Size(552, 231);
            dgvOrders.TabIndex = 4;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOrders);
            tabControl.Controls.Add(tabProducts);
            tabControl.Controls.Add(tabProviders);
            tabControl.Controls.Add(tabSupplies);
            tabControl.Controls.Add(tabPurchases);
            tabControl.Controls.Add(tabSending);
            tabControl.Controls.Add(tabOform);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl.ItemSize = new Size(100, 50);
            tabControl.Location = new Point(190, 0);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(758, 482);
            tabControl.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(948, 482);
            Controls.Add(tabControl);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(964, 460);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoPortal";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            tabOform.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            tabSending.ResumeLayout(false);
            pnlSendings.ResumeLayout(false);
            ((ISupportInitialize)dgvSendings).EndInit();
            tabPurchases.ResumeLayout(false);
            pnlPurchases.ResumeLayout(false);
            ((ISupportInitialize)dgvPurchases).EndInit();
            tabSupplies.ResumeLayout(false);
            pnlSupplies.ResumeLayout(false);
            ((ISupportInitialize)dgvSupplies).EndInit();
            tabProviders.ResumeLayout(false);
            pnlProviders.ResumeLayout(false);
            ((ISupportInitialize)dgvProviders).EndInit();
            tabProducts.ResumeLayout(false);
            pnlProducts.ResumeLayout(false);
            ((ISupportInitialize)dgvProducts).EndInit();
            tabOrders.ResumeLayout(false);
            pnlOrders.ResumeLayout(false);
            ((ISupportInitialize)dgvOrders).EndInit();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonOrders;
        private Panel panelLogo;
        private Button buttonPurchases;
        private Button buttonSupplies;
        private Button buttonProviders;
        private Button buttonGoods;
        private Button buttonSending;
        private TabPage tabOform;
        private Label label2;
        private Label label1;
        private TabPage tabSending;
        private RoundedPanel pnlSendings;
        private DataGridView dgvSendings;
        private TabPage tabPurchases;
        private RoundedPanel pnlPurchases;
        private TabPage tabSupplies;
        private RoundedPanel pnlSupplies;
        private DataGridView dgvSupplies;
        private TabPage tabProviders;
        private RoundedButton btnDeleteProvider;
        private RoundedPanel pnlProviders;
        private TabPage tabProducts;
        private RoundedButton btnDeleteProduct;
        private RoundedPanel pnlProducts;
        private TabPage tabOrders;
        private RoundedPanel pnlOrders;
        private TabControl tabControl;
        private Label label3;
        private RoundedPanel roundedPanel1;
        private TextBox tbQuantity;
        private ComboBox cbProducts;
        private ComboBox cbProviders;
        private RoundedButton btnOform;
        private Button btnSpravka;
        private Panel panel1;
        private RoundedButton btnOformZakupku;
        private RoundedButton btnCancel;
        private DataGridView dgvOrders;
        private DataGridView dgvPurchases;
        private DataGridView dgvProviders;
        private DataGridView dgvProducts;
    }
}