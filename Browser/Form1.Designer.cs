namespace Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBack = new System.Windows.Forms.ToolStripButton();
            this.toolForward = new System.Windows.Forms.ToolStripButton();
            this.tooUpdate = new System.Windows.Forms.ToolStripButton();
            this.tbRequest = new System.Windows.Forms.ToolStripTextBox();
            this.tooGo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1035, 598);
            this.webBrowser1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBack,
            this.toolForward,
            this.tooUpdate,
            this.tbRequest,
            this.tooGo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1035, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBack
            // 
            this.toolBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBack.Image = global::Browser.Properties.Resources.back;
            this.toolBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBack.Name = "toolBack";
            this.toolBack.Size = new System.Drawing.Size(23, 22);
            this.toolBack.Text = "Назад";
            this.toolBack.Click += new System.EventHandler(this.toolBack_Click);
            // 
            // toolForward
            // 
            this.toolForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolForward.Image = global::Browser.Properties.Resources.forward;
            this.toolForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolForward.Name = "toolForward";
            this.toolForward.Size = new System.Drawing.Size(23, 22);
            this.toolForward.Text = "Вперёд";
            this.toolForward.Click += new System.EventHandler(this.toolForward_Click);
            // 
            // tooUpdate
            // 
            this.tooUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooUpdate.Image = global::Browser.Properties.Resources.update;
            this.tooUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooUpdate.Name = "tooUpdate";
            this.tooUpdate.Size = new System.Drawing.Size(23, 22);
            this.tooUpdate.Text = "Обновить";
            this.tooUpdate.Click += new System.EventHandler(this.tooUpdate_Click);
            // 
            // tbRequest
            // 
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(800, 25);
            this.tbRequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRequest_KeyDown);
            // 
            // tooGo
            // 
            this.tooGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooGo.Image = global::Browser.Properties.Resources.go;
            this.tooGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooGo.Name = "tooGo";
            this.tooGo.Size = new System.Drawing.Size(23, 22);
            this.tooGo.Text = "Перейти";
            this.tooGo.Click += new System.EventHandler(this.tooGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 598);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Webbrowser";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBack;
        private System.Windows.Forms.ToolStripButton toolForward;
        private System.Windows.Forms.ToolStripButton tooUpdate;
        private System.Windows.Forms.ToolStripTextBox tbRequest;
        private System.Windows.Forms.ToolStripButton tooGo;
    }
}

