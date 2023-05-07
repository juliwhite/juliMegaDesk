namespace MegaDesk_White
{
    partial class addNewForm
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
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDepth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDrawers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDeskMaterial = new System.Windows.Forms.ComboBox();
            this.comboRushDays = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDepth = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button.Location = new System.Drawing.Point(1050, 700);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(150, 60);
            this.button.TabIndex = 0;
            this.button.Text = "Close";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(100, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(100, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width (Range: 24in - 96in)";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(650, 60);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(500, 53);
            this.textName.TabIndex = 3;
            // 
            // textWidth
            // 
            this.textWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWidth.Location = new System.Drawing.Point(650, 150);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(100, 53);
            this.textWidth.TabIndex = 4;
            this.textWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthCharValidation);
            this.textWidth.Validating += new System.ComponentModel.CancelEventHandler(this.textWidth_Validating);
            this.textWidth.Validated += new System.EventHandler(this.textWidth_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(100, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Depth (Range: 12in - 48in)";
            // 
            // textDepth
            // 
            this.textDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepth.Location = new System.Drawing.Point(650, 250);
            this.textDepth.Name = "textDepth";
            this.textDepth.Size = new System.Drawing.Size(100, 53);
            this.textDepth.TabIndex = 7;
            this.textDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthCharValidation);
            this.textDepth.Validating += new System.ComponentModel.CancelEventHandler(this.textDepth_Validating);
            this.textDepth.Validated += new System.EventHandler(this.textDepth_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(100, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number Drawers";
            // 
            // comboDrawers
            // 
            this.comboDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDrawers.FormattingEnabled = true;
            this.comboDrawers.Location = new System.Drawing.Point(650, 350);
            this.comboDrawers.Name = "comboDrawers";
            this.comboDrawers.Size = new System.Drawing.Size(121, 54);
            this.comboDrawers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(100, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(100, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rush Order";
            // 
            // comboDeskMaterial
            // 
            this.comboDeskMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDeskMaterial.FormattingEnabled = true;
            this.comboDeskMaterial.Location = new System.Drawing.Point(650, 450);
            this.comboDeskMaterial.Name = "comboDeskMaterial";
            this.comboDeskMaterial.Size = new System.Drawing.Size(250, 54);
            this.comboDeskMaterial.TabIndex = 12;
            // 
            // comboRushDays
            // 
            this.comboRushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRushDays.FormattingEnabled = true;
            this.comboRushDays.Location = new System.Drawing.Point(650, 550);
            this.comboRushDays.Name = "comboRushDays";
            this.comboRushDays.Size = new System.Drawing.Size(250, 54);
            this.comboRushDays.TabIndex = 13;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submitButton.Location = new System.Drawing.Point(890, 700);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 60);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorProviderWidth
            // 
            this.errorProviderWidth.ContainerControl = this;
            this.errorProviderWidth.RightToLeftChanged += new System.EventHandler(this.textWidth_Validated);
            // 
            // errorProviderDepth
            // 
            this.errorProviderDepth.ContainerControl = this;
            // 
            // addNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1268, 912);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.comboRushDays);
            this.Controls.Add(this.comboDeskMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboDrawers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDepth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Name = "addNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            this.Load += new System.EventHandler(this.addNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDrawers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboDeskMaterial;
        private System.Windows.Forms.ComboBox comboRushDays;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ErrorProvider errorProviderWidth;
        private System.Windows.Forms.ErrorProvider errorProviderDepth;
    }
}