﻿namespace Enshrouded_Server_Manager.Views;

partial class AdminPanelHorizontalView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnStopServer = new Button();
        btnOpenLogFolder = new Button();
        btnOpenSavegameFolder = new Button();
        btnOpenBackupFolder = new Button();
        btnUpdateServer = new Button();
        btnSaveBackup = new Button();
        btnWindowsFirewall = new Button();
        btnInstallSteamCMD = new Button();
        btnStartServer = new Button();
        btnInstallServer = new Button();
        SuspendLayout();
        // 
        // btnStopServer
        // 
        btnStopServer.Cursor = Cursors.Hand;
        btnStopServer.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnStopServer.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnStopServer.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnStopServer.FlatStyle = FlatStyle.Flat;
        btnStopServer.ForeColor = SystemColors.Control;
        btnStopServer.Location = new Point(8, 3);
        btnStopServer.Name = "btnStopServer";
        btnStopServer.Size = new Size(80, 45);
        btnStopServer.TabIndex = 70;
        btnStopServer.Text = "Stop\r\nServer";
        btnStopServer.UseCompatibleTextRendering = true;
        btnStopServer.UseVisualStyleBackColor = true;
        btnStopServer.Visible = false;
        // 
        // btnOpenLogFolder
        // 
        btnOpenLogFolder.Cursor = Cursors.Hand;
        btnOpenLogFolder.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnOpenLogFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnOpenLogFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnOpenLogFolder.FlatStyle = FlatStyle.Flat;
        btnOpenLogFolder.ForeColor = SystemColors.Control;
        btnOpenLogFolder.Location = new Point(656, 5);
        btnOpenLogFolder.Name = "btnOpenLogFolder";
        btnOpenLogFolder.Size = new Size(80, 45);
        btnOpenLogFolder.TabIndex = 65;
        btnOpenLogFolder.Text = "Log\r\nFolder";
        btnOpenLogFolder.UseCompatibleTextRendering = true;
        btnOpenLogFolder.UseVisualStyleBackColor = true;
        // 
        // btnOpenSavegameFolder
        // 
        btnOpenSavegameFolder.Cursor = Cursors.Hand;
        btnOpenSavegameFolder.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnOpenSavegameFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnOpenSavegameFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnOpenSavegameFolder.FlatStyle = FlatStyle.Flat;
        btnOpenSavegameFolder.ForeColor = SystemColors.Control;
        btnOpenSavegameFolder.Location = new Point(566, 5);
        btnOpenSavegameFolder.Name = "btnOpenSavegameFolder";
        btnOpenSavegameFolder.Size = new Size(80, 45);
        btnOpenSavegameFolder.TabIndex = 64;
        btnOpenSavegameFolder.Text = "Savegame Folder";
        btnOpenSavegameFolder.UseCompatibleTextRendering = true;
        btnOpenSavegameFolder.UseVisualStyleBackColor = true;
        // 
        // btnOpenBackupFolder
        // 
        btnOpenBackupFolder.Cursor = Cursors.Hand;
        btnOpenBackupFolder.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnOpenBackupFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnOpenBackupFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnOpenBackupFolder.FlatStyle = FlatStyle.Flat;
        btnOpenBackupFolder.ForeColor = SystemColors.Control;
        btnOpenBackupFolder.Location = new Point(476, 5);
        btnOpenBackupFolder.Name = "btnOpenBackupFolder";
        btnOpenBackupFolder.Size = new Size(80, 45);
        btnOpenBackupFolder.TabIndex = 63;
        btnOpenBackupFolder.Text = "Backup Folder";
        btnOpenBackupFolder.UseCompatibleTextRendering = true;
        btnOpenBackupFolder.UseVisualStyleBackColor = true;
        // 
        // btnUpdateServer
        // 
        btnUpdateServer.Cursor = Cursors.Hand;
        btnUpdateServer.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnUpdateServer.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnUpdateServer.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnUpdateServer.FlatStyle = FlatStyle.Flat;
        btnUpdateServer.ForeColor = SystemColors.Control;
        btnUpdateServer.Location = new Point(98, 3);
        btnUpdateServer.Name = "btnUpdateServer";
        btnUpdateServer.Size = new Size(80, 45);
        btnUpdateServer.TabIndex = 60;
        btnUpdateServer.Text = "Update Server";
        btnUpdateServer.UseCompatibleTextRendering = true;
        btnUpdateServer.UseVisualStyleBackColor = true;
        btnUpdateServer.Visible = false;
        btnUpdateServer.EnabledChanged += btnUpdateServer_EnabledChanged;
        // 
        // btnSaveBackup
        // 
        btnSaveBackup.Cursor = Cursors.Hand;
        btnSaveBackup.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnSaveBackup.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnSaveBackup.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnSaveBackup.FlatStyle = FlatStyle.Flat;
        btnSaveBackup.ForeColor = SystemColors.Control;
        btnSaveBackup.Location = new Point(386, 5);
        btnSaveBackup.Name = "btnSaveBackup";
        btnSaveBackup.Size = new Size(80, 45);
        btnSaveBackup.TabIndex = 62;
        btnSaveBackup.Text = "Save Backup";
        btnSaveBackup.UseCompatibleTextRendering = true;
        btnSaveBackup.UseVisualStyleBackColor = true;
        // 
        // btnWindowsFirewall
        // 
        btnWindowsFirewall.Cursor = Cursors.Hand;
        btnWindowsFirewall.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnWindowsFirewall.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnWindowsFirewall.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnWindowsFirewall.FlatStyle = FlatStyle.Flat;
        btnWindowsFirewall.ForeColor = SystemColors.Control;
        btnWindowsFirewall.Location = new Point(282, 5);
        btnWindowsFirewall.Name = "btnWindowsFirewall";
        btnWindowsFirewall.Size = new Size(80, 45);
        btnWindowsFirewall.TabIndex = 67;
        btnWindowsFirewall.TabStop = false;
        btnWindowsFirewall.Text = "Windows Firewall";
        btnWindowsFirewall.UseVisualStyleBackColor = true;
        // 
        // btnInstallSteamCMD
        // 
        btnInstallSteamCMD.Cursor = Cursors.Hand;
        btnInstallSteamCMD.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnInstallSteamCMD.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnInstallSteamCMD.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnInstallSteamCMD.FlatStyle = FlatStyle.Flat;
        btnInstallSteamCMD.ForeColor = SystemColors.Control;
        btnInstallSteamCMD.Location = new Point(196, 5);
        btnInstallSteamCMD.Name = "btnInstallSteamCMD";
        btnInstallSteamCMD.Size = new Size(80, 45);
        btnInstallSteamCMD.TabIndex = 61;
        btnInstallSteamCMD.TabStop = false;
        btnInstallSteamCMD.Text = "Install SteamCMD";
        btnInstallSteamCMD.UseVisualStyleBackColor = true;
        // 
        // btnStartServer
        // 
        btnStartServer.Cursor = Cursors.Hand;
        btnStartServer.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnStartServer.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnStartServer.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnStartServer.FlatStyle = FlatStyle.Flat;
        btnStartServer.ForeColor = SystemColors.Control;
        btnStartServer.Location = new Point(8, 5);
        btnStartServer.Name = "btnStartServer";
        btnStartServer.Size = new Size(80, 45);
        btnStartServer.TabIndex = 71;
        btnStartServer.Text = "Start\r\nServer";
        btnStartServer.UseCompatibleTextRendering = true;
        btnStartServer.UseVisualStyleBackColor = true;
        btnStartServer.Visible = false;
        // 
        // btnInstallServer
        // 
        btnInstallServer.Cursor = Cursors.Hand;
        btnInstallServer.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 137);
        btnInstallServer.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 42, 73);
        btnInstallServer.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 42, 73);
        btnInstallServer.FlatStyle = FlatStyle.Flat;
        btnInstallServer.ForeColor = SystemColors.Control;
        btnInstallServer.Location = new Point(98, 5);
        btnInstallServer.Name = "btnInstallServer";
        btnInstallServer.Size = new Size(80, 45);
        btnInstallServer.TabIndex = 72;
        btnInstallServer.Text = "Install Server";
        btnInstallServer.UseVisualStyleBackColor = true;
        btnInstallServer.Visible = false;
        // 
        // AdminPanelHorizontalView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(0, 0, 18);
        Controls.Add(btnInstallServer);
        Controls.Add(btnStartServer);
        Controls.Add(btnStopServer);
        Controls.Add(btnOpenLogFolder);
        Controls.Add(btnWindowsFirewall);
        Controls.Add(btnOpenSavegameFolder);
        Controls.Add(btnInstallSteamCMD);
        Controls.Add(btnOpenBackupFolder);
        Controls.Add(btnSaveBackup);
        Controls.Add(btnUpdateServer);
        Name = "AdminPanelHorizontalView";
        Size = new Size(744, 55);
        ResumeLayout(false);
    }

    #endregion
    private Button btnStopServer;
    private Button btnOpenLogFolder;
    private Button btnOpenSavegameFolder;
    private Button btnOpenBackupFolder;
    private Button btnUpdateServer;
    private Button btnSaveBackup;
    private Button btnWindowsFirewall;
    private Button btnInstallSteamCMD;
    private Button btnStartServer;
    private Button btnInstallServer;
}
