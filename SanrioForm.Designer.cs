namespace WindowsFormsApp2
{
    partial class NewSanrioGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSanrioGUI));
            this.PushMe_Click1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PushMe_Click1
            // 
            this.PushMe_Click1.BackColor = System.Drawing.Color.LightPink;
            this.PushMe_Click1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PushMe_Click1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushMe_Click1.Location = new System.Drawing.Point(31, 134);
            this.PushMe_Click1.Name = "PushMe_Click1";
            this.PushMe_Click1.Size = new System.Drawing.Size(179, 71);
            this.PushMe_Click1.TabIndex = 0;
            this.PushMe_Click1.Text = "Click Me to Play!";
            this.PushMe_Click1.UseVisualStyleBackColor = false;
            this.PushMe_Click1.Click += new System.EventHandler(this.Open_NewWin);
            // 
            // NewSanrioGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 588);
            this.Controls.Add(this.PushMe_Click1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSanrioGUI";
            this.Text = "Sanrio GUI 1.5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PushMe_Click1;
    }
}

