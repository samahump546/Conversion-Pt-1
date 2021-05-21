
namespace Conversion
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option4Label = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.choiceInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(151, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(539, 74);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversion";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(203, 83);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(487, 37);
            this.option1Label.TabIndex = 1;
            this.option1Label.Text = "1. Inches to Centimetres";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(203, 157);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(487, 37);
            this.option3Label.TabIndex = 2;
            this.option3Label.Text = "3. Yards to Metres";
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(203, 120);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(487, 37);
            this.option2Label.TabIndex = 3;
            this.option2Label.Text = "2. Feet to Centimetres";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option4Label
            // 
            this.option4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Label.Location = new System.Drawing.Point(203, 194);
            this.option4Label.Name = "option4Label";
            this.option4Label.Size = new System.Drawing.Size(487, 37);
            this.option4Label.TabIndex = 4;
            this.option4Label.Text = "4. Miles to Kilometres";
            this.option4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // choiceLabel
            // 
            this.choiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.Location = new System.Drawing.Point(97, 239);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(310, 37);
            this.choiceLabel.TabIndex = 5;
            this.choiceLabel.Text = "Enter Conversion Choice (1-4):";
            this.choiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valueLabel
            // 
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(97, 286);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(310, 37);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Enter Value To Be Converted:";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // choiceInput
            // 
            this.choiceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceInput.Location = new System.Drawing.Point(456, 239);
            this.choiceInput.Multiline = true;
            this.choiceInput.Name = "choiceInput";
            this.choiceInput.Size = new System.Drawing.Size(100, 37);
            this.choiceInput.TabIndex = 7;
            this.choiceInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valueInput
            // 
            this.valueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInput.Location = new System.Drawing.Point(456, 286);
            this.valueInput.Multiline = true;
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(100, 37);
            this.valueInput.TabIndex = 8;
            this.valueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(274, 343);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(249, 39);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertOutput
            // 
            this.convertOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertOutput.Location = new System.Drawing.Point(153, 404);
            this.convertOutput.Name = "convertOutput";
            this.convertOutput.Size = new System.Drawing.Size(487, 37);
            this.convertOutput.TabIndex = 10;
            this.convertOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertOutput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.choiceInput);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.option4Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option4Label;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox choiceInput;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label convertOutput;
    }
}

