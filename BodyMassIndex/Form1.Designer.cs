
namespace BodyMassIndex
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
            this.cmbAge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTall = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbBMI = new System.Windows.Forms.Label();
            this.lbIdealBodyWeight = new System.Windows.Forms.Label();
            this.lbBodySurfaceArea = new System.Windows.Forms.Label();
            this.lbLeanBodyWeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lbDesicion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAge
            // 
            this.cmbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAge.FormattingEnabled = true;
            this.cmbAge.Location = new System.Drawing.Point(85, 62);
            this.cmbAge.Name = "cmbAge";
            this.cmbAge.Size = new System.Drawing.Size(121, 28);
            this.cmbAge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight";
            // 
            // cmbWeight
            // 
            this.cmbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Location = new System.Drawing.Point(85, 96);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(121, 28);
            this.cmbWeight.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tall";
            // 
            // cmbTall
            // 
            this.cmbTall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTall.FormattingEnabled = true;
            this.cmbTall.Location = new System.Drawing.Point(85, 130);
            this.cmbTall.Name = "cmbTall";
            this.cmbTall.Size = new System.Drawing.Size(121, 28);
            this.cmbTall.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.Location = new System.Drawing.Point(98, 253);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 34);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbWeight);
            this.groupBox1.Controls.Add(this.cmbTall);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 216);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDesicion);
            this.groupBox2.Controls.Add(this.lbLeanBodyWeight);
            this.groupBox2.Controls.Add(this.lbBodySurfaceArea);
            this.groupBox2.Controls.Add(this.lbIdealBodyWeight);
            this.groupBox2.Controls.Add(this.lbBMI);
            this.groupBox2.Location = new System.Drawing.Point(342, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 206);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbBMI
            // 
            this.lbBMI.AutoSize = true;
            this.lbBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBMI.Location = new System.Drawing.Point(15, 22);
            this.lbBMI.Name = "lbBMI";
            this.lbBMI.Size = new System.Drawing.Size(191, 20);
            this.lbBMI.TabIndex = 6;
            this.lbBMI.Text = "Boy Kilo Endeksi (BMI)";
            // 
            // lbIdealBodyWeight
            // 
            this.lbIdealBodyWeight.AutoSize = true;
            this.lbIdealBodyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIdealBodyWeight.Location = new System.Drawing.Point(15, 56);
            this.lbIdealBodyWeight.Name = "lbIdealBodyWeight";
            this.lbIdealBodyWeight.Size = new System.Drawing.Size(183, 20);
            this.lbIdealBodyWeight.TabIndex = 7;
            this.lbIdealBodyWeight.Text = "İdeal Vücut Ağırlığınız";
            // 
            // lbBodySurfaceArea
            // 
            this.lbBodySurfaceArea.AutoSize = true;
            this.lbBodySurfaceArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBodySurfaceArea.Location = new System.Drawing.Point(15, 90);
            this.lbBodySurfaceArea.Name = "lbBodySurfaceArea";
            this.lbBodySurfaceArea.Size = new System.Drawing.Size(178, 20);
            this.lbBodySurfaceArea.TabIndex = 8;
            this.lbBodySurfaceArea.Text = "Vücut Yüzey Alanınız";
            // 
            // lbLeanBodyWeight
            // 
            this.lbLeanBodyWeight.AutoSize = true;
            this.lbLeanBodyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbLeanBodyWeight.Location = new System.Drawing.Point(15, 120);
            this.lbLeanBodyWeight.Name = "lbLeanBodyWeight";
            this.lbLeanBodyWeight.Size = new System.Drawing.Size(197, 20);
            this.lbLeanBodyWeight.TabIndex = 9;
            this.lbLeanBodyWeight.Text = "Yağsız Vücut Ağırlığınız";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(85, 28);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 28);
            this.cmbGender.TabIndex = 6;
            // 
            // lbDesicion
            // 
            this.lbDesicion.AutoSize = true;
            this.lbDesicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDesicion.Location = new System.Drawing.Point(15, 164);
            this.lbDesicion.Name = "lbDesicion";
            this.lbDesicion.Size = new System.Drawing.Size(78, 20);
            this.lbDesicion.TabIndex = 10;
            this.lbDesicion.Text = "Desicion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTall;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLeanBodyWeight;
        private System.Windows.Forms.Label lbBodySurfaceArea;
        private System.Windows.Forms.Label lbIdealBodyWeight;
        private System.Windows.Forms.Label lbBMI;
        private System.Windows.Forms.Label lbDesicion;
    }
}

