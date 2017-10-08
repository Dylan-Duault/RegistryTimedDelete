namespace AutoKeyRemover
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextKey = new System.Windows.Forms.TextBox();
            this.ComboTime = new System.Windows.Forms.ComboBox();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextKey
            // 
            this.TextKey.Location = new System.Drawing.Point(12, 12);
            this.TextKey.Name = "TextKey";
            this.TextKey.Size = new System.Drawing.Size(448, 20);
            this.TextKey.TabIndex = 0;
            this.TextKey.Text = "Software\\Allavsoft\\Video Downloader Converter\\Setting";
            // 
            // ComboTime
            // 
            this.ComboTime.FormattingEnabled = true;
            this.ComboTime.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "15",
            "30",
            "60"});
            this.ComboTime.Location = new System.Drawing.Point(12, 38);
            this.ComboTime.Name = "ComboTime";
            this.ComboTime.Size = new System.Drawing.Size(121, 21);
            this.ComboTime.TabIndex = 1;
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Location = new System.Drawing.Point(139, 38);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(496, 23);
            this.BtnStartStop.TabIndex = 2;
            this.BtnStartStop.Text = "Start";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextValue
            // 
            this.TextValue.Location = new System.Drawing.Point(466, 12);
            this.TextValue.Name = "TextValue";
            this.TextValue.Size = new System.Drawing.Size(169, 20);
            this.TextValue.TabIndex = 3;
            this.TextValue.Text = "TRIAL_TASK_COUNT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 71);
            this.Controls.Add(this.TextValue);
            this.Controls.Add(this.BtnStartStop);
            this.Controls.Add(this.ComboTime);
            this.Controls.Add(this.TextKey);
            this.Name = "Form1";
            this.Text = "RegistryTimedDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextKey;
        private System.Windows.Forms.ComboBox ComboTime;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TextValue;
    }
}

