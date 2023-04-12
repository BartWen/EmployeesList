namespace EmployeesList
{
    partial class AddEditList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditList));
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSallary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateStartWork = new System.Windows.Forms.DateTimePicker();
            this.IdEmployee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbComentBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            
            // 
            // lbLastName
            // 
            resources.ApplyResources(this.lbLastName, "lbLastName");
            this.lbLastName.Name = "lbLastName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbSallary
            // 
            resources.ApplyResources(this.lbSallary, "lbSallary");
            this.lbSallary.Name = "lbSallary";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dtpDateStartWork
            // 
            this.dtpDateStartWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpDateStartWork, "dtpDateStartWork");
            this.dtpDateStartWork.Name = "dtpDateStartWork";
            
            // 
            // IdEmployee
            // 
            resources.ApplyResources(this.IdEmployee, "IdEmployee");
            this.IdEmployee.Name = "IdEmployee";
            this.IdEmployee.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // rtbComentBox
            // 
            resources.ApplyResources(this.rtbComentBox, "rtbComentBox");
            this.rtbComentBox.Name = "rtbComentBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnconfirm
            // 
            resources.ApplyResources(this.btnconfirm, "btnconfirm");
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbComentBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdEmployee);
            this.Controls.Add(this.dtpDateStartWork);
            this.Controls.Add(this.lbSallary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddEditList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblFirstName;
        private System.Windows.Forms.TextBox lbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lbSallary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateStartWork;
        private System.Windows.Forms.TextBox IdEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbComentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}