﻿namespace WinFwk.UITools.Settings
{
    partial class UISettingsModule
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
            this.components = new System.ComponentModel.Container();
            this.pgUiSettings = new System.Windows.Forms.PropertyGrid();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // pgUiSettings
            // 
            this.pgUiSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgUiSettings.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pgUiSettings.Location = new System.Drawing.Point(0, 49);
            this.pgUiSettings.Name = "pgUiSettings";
            this.pgUiSettings.Size = new System.Drawing.Size(413, 321);
            this.pgUiSettings.TabIndex = 0;
            this.pgUiSettings.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgUiSettings_PropertyValueChanged);
            this.pgUiSettings.Leave += new System.EventHandler(this.pgUiSettings_Leave);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.Image = global::WinFwk.Properties.Resources.disk;
            this.btnSaveSettings.Location = new System.Drawing.Point(370, 3);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSaveSettings.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnSaveSettings, "Save");
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Image = global::WinFwk.Properties.Resources.open_folder;
            this.btnLoad.Location = new System.Drawing.Point(324, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(40, 40);
            this.btnLoad.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnLoad, "Load");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UISettingsModule
            // 
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.pgUiSettings);
            this.Name = "UISettingsModule";
            this.Size = new System.Drawing.Size(413, 370);
            this.Load += new System.EventHandler(this.UIConfigModule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid pgUiSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
