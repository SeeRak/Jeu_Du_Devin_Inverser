namespace Jeu_Du_Devin_inverser
{
    partial class Jeu_Du_Devin_inverser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu_Du_Devin_inverser));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ButtonPetit = new System.Windows.Forms.Button();
            this.ButtonExact = new System.Windows.Forms.Button();
            this.ButtonGrand = new System.Windows.Forms.Button();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Messages ";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(68, 104);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            this.TextBoxMessage.Size = new System.Drawing.Size(256, 20);
            this.TextBoxMessage.TabIndex = 1;
            // 
            // ButtonPetit
            // 
            this.ButtonPetit.Location = new System.Drawing.Point(33, 181);
            this.ButtonPetit.Name = "ButtonPetit";
            this.ButtonPetit.Size = new System.Drawing.Size(75, 23);
            this.ButtonPetit.TabIndex = 2;
            this.ButtonPetit.Text = "Trop Petit";
            this.ButtonPetit.UseVisualStyleBackColor = true;
            this.ButtonPetit.Click += new System.EventHandler(this.ButtonPetit_Click);
            // 
            // ButtonExact
            // 
            this.ButtonExact.Location = new System.Drawing.Point(157, 181);
            this.ButtonExact.Name = "ButtonExact";
            this.ButtonExact.Size = new System.Drawing.Size(75, 23);
            this.ButtonExact.TabIndex = 3;
            this.ButtonExact.Text = "Exact";
            this.ButtonExact.UseVisualStyleBackColor = true;
            this.ButtonExact.Click += new System.EventHandler(this.ButtonExact_Click);
            // 
            // ButtonGrand
            // 
            this.ButtonGrand.Location = new System.Drawing.Point(279, 181);
            this.ButtonGrand.Name = "ButtonGrand";
            this.ButtonGrand.Size = new System.Drawing.Size(75, 23);
            this.ButtonGrand.TabIndex = 4;
            this.ButtonGrand.Text = "Trop Grand";
            this.ButtonGrand.UseVisualStyleBackColor = true;
            this.ButtonGrand.Click += new System.EventHandler(this.ButtonGrand_Click);
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(157, 234);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(75, 23);
            this.buttonNouveau.TabIndex = 5;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(279, 233);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // Jeu_Du_Devin_inverser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 291);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.ButtonGrand);
            this.Controls.Add(this.ButtonExact);
            this.Controls.Add(this.ButtonPetit);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jeu_Du_Devin_inverser";
            this.Text = "devin_inverse";
            this.Load += new System.EventHandler(this.Jeu_Du_Devin_inverser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button ButtonPetit;
        private System.Windows.Forms.Button ButtonExact;
        private System.Windows.Forms.Button ButtonGrand;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonQuitter;
    }
}

