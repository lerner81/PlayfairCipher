namespace PlayfairCipher
{
    partial class Translator
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
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.ouputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.translateBtn = new System.Windows.Forms.Button();
            this.secretWordBox = new System.Windows.Forms.RichTextBox();
            this.controlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(173, 123);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(600, 96);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            // 
            // ouputTextBox
            // 
            this.ouputTextBox.Location = new System.Drawing.Point(173, 230);
            this.ouputTextBox.Name = "ouputTextBox";
            this.ouputTextBox.Size = new System.Drawing.Size(600, 98);
            this.ouputTextBox.TabIndex = 2;
            this.ouputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cipher \"Secret\" Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output Text:";
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.Navy;
            this.controlBox.Controls.Add(this.closeBtn);
            this.controlBox.Controls.Add(this.clearBtn);
            this.controlBox.Controls.Add(this.translateBtn);
            this.controlBox.Location = new System.Drawing.Point(13, 447);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(784, 73);
            this.controlBox.TabIndex = 6;
            this.controlBox.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(685, 30);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(160, 30);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // translateBtn
            // 
            this.translateBtn.Location = new System.Drawing.Point(38, 30);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(75, 23);
            this.translateBtn.TabIndex = 0;
            this.translateBtn.Text = "Translate Text";
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // secretWordBox
            // 
            this.secretWordBox.Location = new System.Drawing.Point(173, 86);
            this.secretWordBox.Name = "secretWordBox";
            this.secretWordBox.Size = new System.Drawing.Size(160, 21);
            this.secretWordBox.TabIndex = 7;
            this.secretWordBox.Text = "";
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 532);
            this.Controls.Add(this.secretWordBox);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ouputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Translator";
            this.Text = "Code Translator";
            this.controlBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox ouputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.RichTextBox secretWordBox;
    }
}

