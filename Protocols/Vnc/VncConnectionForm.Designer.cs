﻿namespace EasyConnect.Protocols.Vnc
{
    partial class VncConnectionForm
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
            this._vncConnection = new VncSharp.RemoteDesktop();
            this.SuspendLayout();
            // 
            // _vncConnection
            // 
            this._vncConnection.AutoScroll = true;
            this._vncConnection.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this._vncConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this._vncConnection.Location = new System.Drawing.Point(0, 0);
            this._vncConnection.Name = "_vncConnection";
            this._vncConnection.Size = new System.Drawing.Size(284, 262);
            this._vncConnection.TabIndex = 0;
            // 
            // VncConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this._vncConnection);
            this.Name = "VncConnectionForm";
            this.Text = "VncConnectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private VncSharp.RemoteDesktop _vncConnection;
    }
}