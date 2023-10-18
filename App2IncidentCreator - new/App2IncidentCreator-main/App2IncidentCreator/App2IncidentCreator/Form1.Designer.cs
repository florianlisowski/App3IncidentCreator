namespace App2IncidentCreator
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
            this.btnDos = new System.Windows.Forms.Button();
            this.btnIncident = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerID = new System.Windows.Forms.TextBox();
            this.lblServerId = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtReportedDate = new System.Windows.Forms.TextBox();
            this.lblReportedDate = new System.Windows.Forms.Label();
            this.txtIncidentDate = new System.Windows.Forms.TextBox();
            this.txtIncidentID = new System.Windows.Forms.TextBox();
            this.lblIncidentDate = new System.Windows.Forms.Label();
            this.lblIncidentId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtService1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.LightGray;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDos.Location = new System.Drawing.Point(740, 663);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(173, 60);
            this.btnDos.TabIndex = 69;
            this.btnDos.Text = "DOS";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnIncident
            // 
            this.btnIncident.BackColor = System.Drawing.Color.LightGray;
            this.btnIncident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncident.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIncident.Location = new System.Drawing.Point(398, 663);
            this.btnIncident.Name = "btnIncident";
            this.btnIncident.Size = new System.Drawing.Size(173, 60);
            this.btnIncident.TabIndex = 68;
            this.btnIncident.Text = "Incident";
            this.btnIncident.UseVisualStyleBackColor = false;
            this.btnIncident.Click += new System.EventHandler(this.btnIncident_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(778, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Outcome";
            // 
            // txtOutcome
            // 
            this.txtOutcome.Location = new System.Drawing.Point(880, 427);
            this.txtOutcome.Multiline = true;
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.Size = new System.Drawing.Size(287, 188);
            this.txtOutcome.TabIndex = 66;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.BackColor = System.Drawing.Color.LightSalmon;
            this.radNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNo.Location = new System.Drawing.Point(487, 591);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(53, 24);
            this.radNo.TabIndex = 65;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = false;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.BackColor = System.Drawing.Color.LightSalmon;
            this.radYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYes.Location = new System.Drawing.Point(398, 591);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(61, 24);
            this.radYes.TabIndex = 64;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = false;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.BackColor = System.Drawing.Color.LightSalmon;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(256, 595);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(92, 20);
            this.lblIsActive.TabIndex = 63;
            this.lblIsActive.Text = "Is Active?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Service";
            // 
            // txtServerID
            // 
            this.txtServerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerID.Location = new System.Drawing.Point(383, 450);
            this.txtServerID.Name = "txtServerID";
            this.txtServerID.Size = new System.Drawing.Size(306, 27);
            this.txtServerID.TabIndex = 60;
            // 
            // lblServerId
            // 
            this.lblServerId.AutoSize = true;
            this.lblServerId.BackColor = System.Drawing.Color.LightSalmon;
            this.lblServerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerId.Location = new System.Drawing.Point(256, 453);
            this.lblServerId.Name = "lblServerId";
            this.lblServerId.Size = new System.Drawing.Size(89, 20);
            this.lblServerId.TabIndex = 59;
            this.lblServerId.Text = "Server ID";
            // 
            // txtService
            // 
            this.txtService.BackColor = System.Drawing.Color.LightSalmon;
            this.txtService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtService.Location = new System.Drawing.Point(240, 408);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(945, 237);
            this.txtService.TabIndex = 58;
            this.txtService.Text = "Denial Of Service";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(880, 327);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(306, 27);
            this.txtDepartment.TabIndex = 57;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(736, 330);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(107, 20);
            this.lblDepartment.TabIndex = 56;
            this.lblDepartment.Text = "Department";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(880, 268);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(306, 27);
            this.txtSurname.TabIndex = 55;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(736, 266);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(83, 20);
            this.lblSurname.TabIndex = 54;
            this.lblSurname.Text = "Surname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(880, 212);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(306, 27);
            this.txtFirstName.TabIndex = 53;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(736, 212);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 20);
            this.lblFirstName.TabIndex = 52;
            this.lblFirstName.Text = "First Name";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(880, 158);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(306, 27);
            this.txtStaffID.TabIndex = 51;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffId.Location = new System.Drawing.Point(736, 155);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(74, 20);
            this.lblStaffId.TabIndex = 50;
            this.lblStaffId.Text = "Staff ID";
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(383, 330);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(306, 27);
            this.txtComments.TabIndex = 49;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(236, 330);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(98, 20);
            this.lblComments.TabIndex = 48;
            this.lblComments.Text = "Comments";
            // 
            // txtReportedDate
            // 
            this.txtReportedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportedDate.Location = new System.Drawing.Point(383, 271);
            this.txtReportedDate.Name = "txtReportedDate";
            this.txtReportedDate.Size = new System.Drawing.Size(306, 27);
            this.txtReportedDate.TabIndex = 47;
            // 
            // lblReportedDate
            // 
            this.lblReportedDate.AutoSize = true;
            this.lblReportedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportedDate.Location = new System.Drawing.Point(236, 271);
            this.lblReportedDate.Name = "lblReportedDate";
            this.lblReportedDate.Size = new System.Drawing.Size(131, 20);
            this.lblReportedDate.TabIndex = 46;
            this.lblReportedDate.Text = "Reported Date";
            // 
            // txtIncidentDate
            // 
            this.txtIncidentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentDate.Location = new System.Drawing.Point(383, 212);
            this.txtIncidentDate.Name = "txtIncidentDate";
            this.txtIncidentDate.Size = new System.Drawing.Size(306, 27);
            this.txtIncidentDate.TabIndex = 45;
            // 
            // txtIncidentID
            // 
            this.txtIncidentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentID.Location = new System.Drawing.Point(383, 155);
            this.txtIncidentID.Name = "txtIncidentID";
            this.txtIncidentID.Size = new System.Drawing.Size(306, 27);
            this.txtIncidentID.TabIndex = 44;
            // 
            // lblIncidentDate
            // 
            this.lblIncidentDate.AutoSize = true;
            this.lblIncidentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentDate.Location = new System.Drawing.Point(236, 212);
            this.lblIncidentDate.Name = "lblIncidentDate";
            this.lblIncidentDate.Size = new System.Drawing.Size(121, 20);
            this.lblIncidentDate.TabIndex = 43;
            this.lblIncidentDate.Text = "Incident Date";
            // 
            // lblIncidentId
            // 
            this.lblIncidentId.AutoSize = true;
            this.lblIncidentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentId.Location = new System.Drawing.Point(236, 158);
            this.lblIncidentId.Name = "lblIncidentId";
            this.lblIncidentId.Size = new System.Drawing.Size(100, 20);
            this.lblIncidentId.TabIndex = 42;
            this.lblIncidentId.Text = "Incident ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(543, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 46);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Incident Creator";
            // 
            // txtService1
            // 
            this.txtService1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtService1.Location = new System.Drawing.Point(383, 529);
            this.txtService1.Name = "txtService1";
            this.txtService1.Size = new System.Drawing.Size(306, 27);
            this.txtService1.TabIndex = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 816);
            this.Controls.Add(this.txtService1);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnIncident);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutcome);
            this.Controls.Add(this.radNo);
            this.Controls.Add(this.radYes);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerID);
            this.Controls.Add(this.lblServerId);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtReportedDate);
            this.Controls.Add(this.lblReportedDate);
            this.Controls.Add(this.txtIncidentDate);
            this.Controls.Add(this.txtIncidentID);
            this.Controls.Add(this.lblIncidentDate);
            this.Controls.Add(this.lblIncidentId);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnIncident;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerID;
        private System.Windows.Forms.Label lblServerId;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtReportedDate;
        private System.Windows.Forms.Label lblReportedDate;
        private System.Windows.Forms.TextBox txtIncidentDate;
        private System.Windows.Forms.TextBox txtIncidentID;
        private System.Windows.Forms.Label lblIncidentDate;
        private System.Windows.Forms.Label lblIncidentId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtService1;
    }
}

