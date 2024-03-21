namespace buttonByeBye
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
            this.TROLL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Button();
            this.taunt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TROLL
            // 
            this.TROLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TROLL.Location = new System.Drawing.Point(191, 277);
            this.TROLL.Name = "TROLL";
            this.TROLL.Size = new System.Drawing.Size(110, 110);
            this.TROLL.TabIndex = 0;
            this.TROLL.Text = "yes";
            this.TROLL.UseVisualStyleBackColor = true;
            this.TROLL.Click += new System.EventHandler(this.TROLL_Click);
            this.TROLL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TROLL_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Papasa ba ikaw ng I.T?";
            // 
            // no
            // 
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(359, 277);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(110, 110);
            this.no.TabIndex = 3;
            this.no.Text = "no";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // taunt
            // 
            this.taunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taunt.Location = new System.Drawing.Point(12, 48);
            this.taunt.Name = "taunt";
            this.taunt.Size = new System.Drawing.Size(658, 94);
            this.taunt.TabIndex = 4;
            this.taunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.taunt);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TROLL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TROLL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label taunt;
    }
}

