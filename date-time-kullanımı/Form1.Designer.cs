namespace date_time_kullanımı
{
    partial class Form1
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
            this.btnToday = new System.Windows.Forms.Button();
            this.btnMaxValue = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnMinValue = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblMesaj2 = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToday.Location = new System.Drawing.Point(178, 149);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(98, 49);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "TODAY";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnMaxValue
            // 
            this.btnMaxValue.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaxValue.Location = new System.Drawing.Point(178, 73);
            this.btnMaxValue.Name = "btnMaxValue";
            this.btnMaxValue.Size = new System.Drawing.Size(98, 49);
            this.btnMaxValue.TabIndex = 2;
            this.btnMaxValue.Text = "MAX VALUE";
            this.btnMaxValue.UseVisualStyleBackColor = true;
            this.btnMaxValue.Click += new System.EventHandler(this.btnMaxValue_Click);
            // 
            // btnNow
            // 
            this.btnNow.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNow.Location = new System.Drawing.Point(60, 149);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(98, 49);
            this.btnNow.TabIndex = 3;
            this.btnNow.Text = "NOW";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnMinValue
            // 
            this.btnMinValue.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinValue.Location = new System.Drawing.Point(60, 73);
            this.btnMinValue.Name = "btnMinValue";
            this.btnMinValue.Size = new System.Drawing.Size(98, 49);
            this.btnMinValue.TabIndex = 4;
            this.btnMinValue.Text = "MİN VALUE";
            this.btnMinValue.UseVisualStyleBackColor = true;
            this.btnMinValue.Click += new System.EventHandler(this.btnMinValue_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(57, 254);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(18, 19);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "...";
            // 
            // lblMesaj2
            // 
            this.lblMesaj2.AutoSize = true;
            this.lblMesaj2.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj2.Location = new System.Drawing.Point(57, 292);
            this.lblMesaj2.Name = "lblMesaj2";
            this.lblMesaj2.Size = new System.Drawing.Size(18, 19);
            this.lblMesaj2.TabIndex = 6;
            this.lblMesaj2.Text = "...";
            // 
            // btnGoster
            // 
            this.btnGoster.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(60, 341);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(98, 49);
            this.btnGoster.TabIndex = 7;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(374, 402);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblMesaj2);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnMinValue);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.btnMaxValue);
            this.Controls.Add(this.btnToday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnMaxValue;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnMinValue;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblMesaj2;
        private System.Windows.Forms.Button btnGoster;
    }
}

