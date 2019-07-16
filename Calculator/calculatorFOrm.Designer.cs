namespace Calculator
{
    partial class CalculatorForm
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
            this.displayValue = new System.Windows.Forms.TextBox();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayValue
            // 
            this.displayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValue.Location = new System.Drawing.Point(12, 12);
            this.displayValue.Name = "displayValue";
            this.displayValue.ReadOnly = true;
            this.displayValue.Size = new System.Drawing.Size(218, 64);
            this.displayValue.TabIndex = 0;
            this.displayValue.Text = "0";
            this.displayValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DivideButton
            // 
            this.DivideButton.AutoSize = true;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(180, 98);
            this.DivideButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DivideButton.Size = new System.Drawing.Size(50, 50);
            this.DivideButton.TabIndex = 1;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.AutoSize = true;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(180, 154);
            this.MultiplyButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MultiplyButton.Size = new System.Drawing.Size(50, 50);
            this.MultiplyButton.TabIndex = 2;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.AutoSize = true;
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(180, 210);
            this.SubtractButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubtractButton.Size = new System.Drawing.Size(50, 50);
            this.SubtractButton.TabIndex = 3;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.AutoSize = true;
            this.AdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.Location = new System.Drawing.Point(179, 266);
            this.AdditionButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AdditionButton.Size = new System.Drawing.Size(50, 50);
            this.AdditionButton.TabIndex = 4;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.AutoSize = true;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(180, 322);
            this.EqualsButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EqualsButton.Size = new System.Drawing.Size(50, 50);
            this.EqualsButton.TabIndex = 5;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.AutoSize = true;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(124, 154);
            this.NineButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.NineButton.Name = "NineButton";
            this.NineButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NineButton.Size = new System.Drawing.Size(50, 50);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.AutoSize = true;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(68, 154);
            this.EightButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.EightButton.Name = "EightButton";
            this.EightButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EightButton.Size = new System.Drawing.Size(50, 50);
            this.EightButton.TabIndex = 7;
            this.EightButton.Text = "8";
            this.EightButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.AutoSize = true;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(12, 154);
            this.SevenButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SevenButton.Size = new System.Drawing.Size(50, 50);
            this.SevenButton.TabIndex = 8;
            this.SevenButton.Text = "7";
            this.SevenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.AutoSize = true;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(124, 210);
            this.SixButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.SixButton.Name = "SixButton";
            this.SixButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SixButton.Size = new System.Drawing.Size(50, 50);
            this.SixButton.TabIndex = 9;
            this.SixButton.Text = "6";
            this.SixButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.AutoSize = true;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(68, 210);
            this.FiveButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FiveButton.Size = new System.Drawing.Size(50, 50);
            this.FiveButton.TabIndex = 10;
            this.FiveButton.Text = "5";
            this.FiveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.AutoSize = true;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(12, 210);
            this.FourButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.FourButton.Name = "FourButton";
            this.FourButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FourButton.Size = new System.Drawing.Size(50, 50);
            this.FourButton.TabIndex = 11;
            this.FourButton.Text = "4";
            this.FourButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.AutoSize = true;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(124, 266);
            this.ThreeButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ThreeButton.Size = new System.Drawing.Size(50, 50);
            this.ThreeButton.TabIndex = 12;
            this.ThreeButton.Text = "3";
            this.ThreeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.AutoSize = true;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(68, 266);
            this.TwoButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TwoButton.Size = new System.Drawing.Size(50, 50);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.AutoSize = true;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(12, 266);
            this.OneButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.OneButton.Name = "OneButton";
            this.OneButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OneButton.Size = new System.Drawing.Size(50, 50);
            this.OneButton.TabIndex = 14;
            this.OneButton.Text = "1";
            this.OneButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.AutoSize = true;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(12, 322);
            this.ZeroButton.MinimumSize = new System.Drawing.Size(106, 50);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ZeroButton.Size = new System.Drawing.Size(106, 50);
            this.ZeroButton.TabIndex = 15;
            this.ZeroButton.Text = "0";
            this.ZeroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.AutoSize = true;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(124, 322);
            this.DotButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.DotButton.Name = "DotButton";
            this.DotButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DotButton.Size = new System.Drawing.Size(50, 50);
            this.DotButton.TabIndex = 16;
            this.DotButton.Text = ".";
            this.DotButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DotButton.UseVisualStyleBackColor = true;
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.AutoSize = true;
            this.ClearEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntryButton.Location = new System.Drawing.Point(12, 98);
            this.ClearEntryButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClearEntryButton.Size = new System.Drawing.Size(51, 50);
            this.ClearEntryButton.TabIndex = 17;
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.UseVisualStyleBackColor = true;
            this.ClearEntryButton.Click += new System.EventHandler(this.ClearEntryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(68, 98);
            this.ClearButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClearButton.Size = new System.Drawing.Size(50, 50);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(124, 98);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(50, 50);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeleteButton.Size = new System.Drawing.Size(51, 50);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "del";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 380);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.displayValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayValue;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ClearEntryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

