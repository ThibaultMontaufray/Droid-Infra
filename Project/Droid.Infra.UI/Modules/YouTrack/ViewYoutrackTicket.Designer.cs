namespace Droid.Infra.UI.Modules.YouTrack.View
{
    partial class ViewYoutrackTicket
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.labelUpdatedBy = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelProject = new System.Windows.Forms.Label();
            this.labelProjectValue = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelAssigneeValue = new System.Windows.Forms.Label();
            this.labelAssignee = new System.Windows.Forms.Label();
            this.labelAffectedVersionValue = new System.Windows.Forms.Label();
            this.labelAffectedVersion = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(4, 4);
            this.labelCreatedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(75, 18);
            this.labelCreatedBy.TabIndex = 0;
            this.labelCreatedBy.Text = "Created by";
            // 
            // labelUpdatedBy
            // 
            this.labelUpdatedBy.AutoSize = true;
            this.labelUpdatedBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdatedBy.Location = new System.Drawing.Point(87, 4);
            this.labelUpdatedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdatedBy.Name = "labelUpdatedBy";
            this.labelUpdatedBy.Size = new System.Drawing.Size(79, 18);
            this.labelUpdatedBy.TabIndex = 1;
            this.labelUpdatedBy.Text = "Updated by";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(4, 31);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 23);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "TITLE";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(7, 57);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(512, 124);
            this.textBoxDescription.TabIndex = 4;
            // 
            // labelProject
            // 
            this.labelProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProject.Location = new System.Drawing.Point(526, 15);
            this.labelProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(141, 18);
            this.labelProject.TabIndex = 5;
            this.labelProject.Text = "Project";
            // 
            // labelProjectValue
            // 
            this.labelProjectValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProjectValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectValue.Location = new System.Drawing.Point(671, 14);
            this.labelProjectValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjectValue.Name = "labelProjectValue";
            this.labelProjectValue.Size = new System.Drawing.Size(225, 18);
            this.labelProjectValue.TabIndex = 6;
            this.labelProjectValue.Text = "_______";
            // 
            // labelPriority
            // 
            this.labelPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriority.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriority.Location = new System.Drawing.Point(526, 43);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(141, 18);
            this.labelPriority.TabIndex = 7;
            this.labelPriority.Text = "Priority";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(526, 71);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(141, 18);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Type";
            // 
            // labelState
            // 
            this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelState.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(526, 102);
            this.labelState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(141, 18);
            this.labelState.TabIndex = 11;
            this.labelState.Text = "State";
            // 
            // labelAssigneeValue
            // 
            this.labelAssigneeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAssigneeValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssigneeValue.Location = new System.Drawing.Point(675, 131);
            this.labelAssigneeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAssigneeValue.Name = "labelAssigneeValue";
            this.labelAssigneeValue.Size = new System.Drawing.Size(219, 18);
            this.labelAssigneeValue.TabIndex = 14;
            this.labelAssigneeValue.Text = "_______";
            // 
            // labelAssignee
            // 
            this.labelAssignee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAssignee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignee.Location = new System.Drawing.Point(526, 131);
            this.labelAssignee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAssignee.Name = "labelAssignee";
            this.labelAssignee.Size = new System.Drawing.Size(141, 18);
            this.labelAssignee.TabIndex = 13;
            this.labelAssignee.Text = "Assignee";
            // 
            // labelAffectedVersionValue
            // 
            this.labelAffectedVersionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAffectedVersionValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffectedVersionValue.Location = new System.Drawing.Point(675, 162);
            this.labelAffectedVersionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAffectedVersionValue.Name = "labelAffectedVersionValue";
            this.labelAffectedVersionValue.Size = new System.Drawing.Size(219, 18);
            this.labelAffectedVersionValue.TabIndex = 16;
            this.labelAffectedVersionValue.Text = "_______";
            // 
            // labelAffectedVersion
            // 
            this.labelAffectedVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAffectedVersion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffectedVersion.Location = new System.Drawing.Point(526, 162);
            this.labelAffectedVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAffectedVersion.Name = "labelAffectedVersion";
            this.labelAffectedVersion.Size = new System.Drawing.Size(141, 18);
            this.labelAffectedVersion.TabIndex = 15;
            this.labelAffectedVersion.Text = "Affected version";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(676, 35);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(221, 26);
            this.comboBoxPriority.TabIndex = 17;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(676, 68);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(221, 26);
            this.comboBoxType.TabIndex = 18;
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(676, 99);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(221, 26);
            this.comboBoxState.TabIndex = 19;
            // 
            // panelMessages
            // 
            this.panelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessages.Location = new System.Drawing.Point(8, 187);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(889, 6);
            this.panelMessages.TabIndex = 20;
            // 
            // ViewYoutrackTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelAffectedVersionValue);
            this.Controls.Add(this.labelAffectedVersion);
            this.Controls.Add(this.labelAssigneeValue);
            this.Controls.Add(this.labelAssignee);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelProjectValue);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUpdatedBy);
            this.Controls.Add(this.labelCreatedBy);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewYoutrackTicket";
            this.Size = new System.Drawing.Size(900, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label labelUpdatedBy;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label labelProjectValue;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelAssigneeValue;
        private System.Windows.Forms.Label labelAssignee;
        private System.Windows.Forms.Label labelAffectedVersionValue;
        private System.Windows.Forms.Label labelAffectedVersion;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Panel panelMessages;
    }
}
