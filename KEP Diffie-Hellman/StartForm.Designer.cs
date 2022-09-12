
namespace KEP_Diffie_Hellman
{
    partial class StartForm
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
            this.button_participantA = new System.Windows.Forms.Button();
            this.button_participantB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_participantA
            // 
            this.button_participantA.Location = new System.Drawing.Point(12, 12);
            this.button_participantA.Name = "button_participantA";
            this.button_participantA.Size = new System.Drawing.Size(200, 35);
            this.button_participantA.TabIndex = 0;
            this.button_participantA.Text = "Участник А";
            this.button_participantA.UseVisualStyleBackColor = true;
            this.button_participantA.Click += new System.EventHandler(this.OnClickButtonParticipantA);
            // 
            // button_participantB
            // 
            this.button_participantB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_participantB.Location = new System.Drawing.Point(266, 12);
            this.button_participantB.Name = "button_participantB";
            this.button_participantB.Size = new System.Drawing.Size(200, 36);
            this.button_participantB.TabIndex = 1;
            this.button_participantB.Text = "Участник В";
            this.button_participantB.UseVisualStyleBackColor = true;
            this.button_participantB.Click += new System.EventHandler(this.OnClickButtonParticipantB);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(478, 64);
            this.Controls.Add(this.button_participantB);
            this.Controls.Add(this.button_participantA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "ИТФИ ННГУ | Протокол обмена ключами Диффи-Хеллмана";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_participantA;
        private System.Windows.Forms.Button button_participantB;
    }
}