namespace LLProject
{
    partial class frmstockinfo
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
            this.components = new System.ComponentModel.Container();
            this.txtItemname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtBalance = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPaid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtQuality = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbQuantity = new Bunifu.Framework.UI.BunifuDropdown();
            this.SuspendLayout();
            // 
            // txtItemname
            // 
            this.txtItemname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtItemname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItemname.ForeColor = System.Drawing.Color.Black;
            this.txtItemname.HintForeColor = System.Drawing.Color.Empty;
            this.txtItemname.HintText = "";
            this.txtItemname.isPassword = false;
            this.txtItemname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtItemname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtItemname.LineThickness = 2;
            this.txtItemname.Location = new System.Drawing.Point(386, 111);
            this.txtItemname.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemname.Name = "txtItemname";
            this.txtItemname.Size = new System.Drawing.Size(379, 33);
            this.txtItemname.TabIndex = 16;
            this.txtItemname.Tag = "";
            this.txtItemname.Text = "Item name";
            this.txtItemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(520, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Stock Info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 707);
            this.panel1.TabIndex = 14;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(608, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 40);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(386, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateStart
            // 
            this.dateStart.BackColor = System.Drawing.Color.SeaGreen;
            this.dateStart.BorderRadius = 0;
            this.dateStart.ForeColor = System.Drawing.Color.White;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateStart.FormatCustom = null;
            this.dateStart.Location = new System.Drawing.Point(386, 500);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(379, 36);
            this.dateStart.TabIndex = 25;
            this.dateStart.Value = new System.DateTime(2018, 9, 26, 17, 42, 21, 378);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBalance.HintForeColor = System.Drawing.Color.Empty;
            this.txtBalance.HintText = "";
            this.txtBalance.isPassword = false;
            this.txtBalance.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBalance.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBalance.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBalance.LineThickness = 2;
            this.txtBalance.Location = new System.Drawing.Point(386, 366);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(379, 33);
            this.txtBalance.TabIndex = 24;
            this.txtBalance.Text = "Balance";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaid.HintForeColor = System.Drawing.Color.Empty;
            this.txtPaid.HintText = "";
            this.txtPaid.isPassword = false;
            this.txtPaid.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPaid.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPaid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPaid.LineThickness = 2;
            this.txtPaid.Location = new System.Drawing.Point(386, 427);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(379, 33);
            this.txtPaid.TabIndex = 23;
            this.txtPaid.Text = "Paid";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPaid.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 2;
            this.txtPrice.Location = new System.Drawing.Point(386, 299);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(379, 33);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.Text = "Price";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtQuality
            // 
            this.txtQuality.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuality.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuality.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuality.HintText = "";
            this.txtQuality.isPassword = false;
            this.txtQuality.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuality.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuality.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuality.LineThickness = 2;
            this.txtQuality.Location = new System.Drawing.Point(386, 236);
            this.txtQuality.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(379, 33);
            this.txtQuality.TabIndex = 20;
            this.txtQuality.Text = "Quality";
            this.txtQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbQuantity
            // 
            this.cbQuantity.BackColor = System.Drawing.Color.Transparent;
            this.cbQuantity.BorderRadius = 3;
            this.cbQuantity.DisabledColor = System.Drawing.Color.Gray;
            this.cbQuantity.ForeColor = System.Drawing.Color.White;
            this.cbQuantity.Items = new string[0];
            this.cbQuantity.Location = new System.Drawing.Point(386, 176);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbQuantity.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbQuantity.selectedIndex = -1;
            this.cbQuantity.Size = new System.Drawing.Size(379, 35);
            this.cbQuantity.TabIndex = 19;
            // 
            // frmstockinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 707);
            this.Controls.Add(this.txtItemname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.cbQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmstockinfo";
            this.Text = "frmstockinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuDatepicker dateStart;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBalance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPaid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuality;
        private Bunifu.Framework.UI.BunifuDropdown cbQuantity;
    }
}