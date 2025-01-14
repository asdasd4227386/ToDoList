
namespace WindowsFormsApp1
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
            this.BTNDel = new System.Windows.Forms.Button();
            this.BTNImportant = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.BTNComplete = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.labelNAME = new System.Windows.Forms.Label();
            this.labelPOINTS = new System.Windows.Forms.Label();
            this.labelCOMPLETED = new System.Windows.Forms.Label();
            this.labelTODO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNDel
            // 
            this.BTNDel.Location = new System.Drawing.Point(189, 329);
            this.BTNDel.Name = "BTNDel";
            this.BTNDel.Size = new System.Drawing.Size(148, 32);
            this.BTNDel.TabIndex = 2;
            this.BTNDel.Text = "Törlés";
            this.BTNDel.UseVisualStyleBackColor = true;
            // 
            // BTNImportant
            // 
            this.BTNImportant.Location = new System.Drawing.Point(361, 329);
            this.BTNImportant.Name = "BTNImportant";
            this.BTNImportant.Size = new System.Drawing.Size(148, 32);
            this.BTNImportant.TabIndex = 3;
            this.BTNImportant.Text = "Megjelölés fontosként";
            this.BTNImportant.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(547, 140);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(211, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNAdd.Location = new System.Drawing.Point(547, 197);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(210, 114);
            this.BTNAdd.TabIndex = 6;
            this.BTNAdd.Text = "Feladat hozzáadása";
            this.BTNAdd.UseVisualStyleBackColor = true;
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(547, 358);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(210, 49);
            this.BTNExit.TabIndex = 10;
            this.BTNExit.Text = "Kilépés";
            this.BTNExit.UseVisualStyleBackColor = true;
            // 
            // BTNComplete
            // 
            this.BTNComplete.Location = new System.Drawing.Point(18, 329);
            this.BTNComplete.Name = "BTNComplete";
            this.BTNComplete.Size = new System.Drawing.Size(148, 32);
            this.BTNComplete.TabIndex = 1;
            this.BTNComplete.Text = "Feladat teljesítése";
            this.BTNComplete.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 72);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(494, 239);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // labelNAME
            // 
            this.labelNAME.AutoSize = true;
            this.labelNAME.Location = new System.Drawing.Point(27, 402);
            this.labelNAME.Name = "labelNAME";
            this.labelNAME.Size = new System.Drawing.Size(33, 13);
            this.labelNAME.TabIndex = 7;
            this.labelNAME.Text = "Név: ";
            // 
            // labelPOINTS
            // 
            this.labelPOINTS.AutoSize = true;
            this.labelPOINTS.Location = new System.Drawing.Point(192, 397);
            this.labelPOINTS.Name = "labelPOINTS";
            this.labelPOINTS.Size = new System.Drawing.Size(59, 13);
            this.labelPOINTS.TabIndex = 8;
            this.labelPOINTS.Text = "Pontszám: ";
            // 
            // labelCOMPLETED
            // 
            this.labelCOMPLETED.AutoSize = true;
            this.labelCOMPLETED.Location = new System.Drawing.Point(360, 394);
            this.labelCOMPLETED.Name = "labelCOMPLETED";
            this.labelCOMPLETED.Size = new System.Drawing.Size(117, 13);
            this.labelCOMPLETED.TabIndex = 9;
            this.labelCOMPLETED.Text = "Végrehajtott feladatok: ";
            // 
            // labelTODO
            // 
            this.labelTODO.AutoSize = true;
            this.labelTODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTODO.Location = new System.Drawing.Point(187, 16);
            this.labelTODO.Name = "labelTODO";
            this.labelTODO.Size = new System.Drawing.Size(154, 46);
            this.labelTODO.TabIndex = 11;
            this.labelTODO.Text = "To - Do";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTODO);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.labelCOMPLETED);
            this.Controls.Add(this.labelPOINTS);
            this.Controls.Add(this.labelNAME);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNImportant);
            this.Controls.Add(this.BTNDel);
            this.Controls.Add(this.BTNComplete);
            this.Controls.Add(this.listView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNDel;
        private System.Windows.Forms.Button BTNImportant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Button BTNComplete;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label labelNAME;
        private System.Windows.Forms.Label labelPOINTS;
        private System.Windows.Forms.Label labelCOMPLETED;
        private System.Windows.Forms.Label labelTODO;
    }
}

