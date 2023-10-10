
namespace testForms4._5
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
            this.nameInput = new System.Windows.Forms.RichTextBox();
            this.ageInput = new System.Windows.Forms.RichTextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(366, 117);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(236, 27);
            this.nameInput.TabIndex = 0;
            this.nameInput.Text = "";
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(366, 191);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(236, 28);
            this.ageInput.TabIndex = 1;
            this.ageInput.Text = "";
            this.ageInput.TextChanged += new System.EventHandler(this.ageInput_TextChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(404, 263);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(169, 39);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Ajouter une personne";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(300, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nom";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(300, 194);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(23, 106);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.nameInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameInput;
        private System.Windows.Forms.RichTextBox ageInput;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelResult;
    }
}

