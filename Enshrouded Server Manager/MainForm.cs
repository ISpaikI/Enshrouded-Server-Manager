﻿using Enshrouded_Server_Manager.Events;
using Enshrouded_Server_Manager.Helpers;
using Enshrouded_Server_Manager.Models;
using Enshrouded_Server_Manager.Presenters;
using Enshrouded_Server_Manager.Services;
using Enshrouded_Server_Manager.Views;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;

namespace Enshrouded_Server_Manager;
public partial class MainForm : Form, IMainFormView
{
    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();
    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    private Panel _pnlUpdateServerfiles;
    private Label _lblUpdateServerfiles;

    public MainForm()
    {
        InitializeComponent();

        // TODO: Configure all of these services for dependency injection
        // There should only EVER be one instance of the EventAggregator (singleton)
        EventAggregator eventAggregator = new EventAggregator();

        // Initialize Services
        var messageBox = new MessageBoxService();
        var fileSystemManager = new FileSystemService();
        var discordOutputService = new DiscordService();
        var enshroudedServer = new EnshroudedServerService(fileSystemManager);
        var versionManager = new VersionManagementService(fileSystemManager, eventAggregator);
        var backupService = new BackupService(fileSystemManager, enshroudedServer, eventAggregator, discordOutputService);
        var profileManager = new ProfileService(fileSystemManager, messageBox);
        var processManager = new SystemProcessService();
        var httpClient = new HttpClientService(new WebClient());
        var serverSettingsService = new ServerSettingsService(fileSystemManager, eventAggregator, messageBox, enshroudedServer);
        var steamCMDInstaller = new SteamCMDInstallerService(fileSystemManager, processManager, messageBox, httpClient);

        adminPanelView.Tag = new AdminPanelPresenter(adminPanelView, eventAggregator, steamCMDInstaller, fileSystemManager, versionManager, processManager, serverSettingsService, enshroudedServer, profileManager, discordOutputService, backupService);

        // Load the profiles for each view the first time they are created
        BindingList<ServerProfile> profiles = new BindingList<ServerProfile>(profileManager.LoadServerProfiles(JsonSettings.Default, true));

        // Initialize Presenters
        serverSettingsView.Tag = new ServerSettingsPresenter(serverSettingsView, eventAggregator, serverSettingsService, fileSystemManager, enshroudedServer);
        manageProfilesView.Tag = new ManageProfilesPresenter(manageProfilesView, eventAggregator, profileManager, serverSettingsService, fileSystemManager, messageBox, enshroudedServer, profiles);
        autoBackupView.Tag = new AutoBackupPresenter(autoBackupView, eventAggregator, processManager, profileManager, fileSystemManager, messageBox, backupService, profiles);
        discordNotificationsView.Tag = new DiscordNotificationsPresenter(discordNotificationsView, eventAggregator, discordOutputService, messageBox, profileManager, fileSystemManager);
        infoPanelView.Tag = new InfoPanelPresenter(infoPanelView, eventAggregator, processManager);
        this.Tag = new MainFormPresenter(this, versionManager);

        // Profile Selector should be created last, because it publishes the selected profile on startup
        profileSelectorView.Tag = new ProfileSelectorPresenter(profileSelectorView, manageProfilesView, eventAggregator, profileManager, serverSettingsService, fileSystemManager, messageBox, enshroudedServer, profiles);

        _pnlUpdateServerfiles = new Panel();
        _lblUpdateServerfiles = new Label();

        eventAggregator.Subscribe<ServerInstallStartedMessage>(m => OnServerInstallStarted());
        eventAggregator.Subscribe<ServerInstallStoppedMessage>(m => OnServerInstallStopped());

        InitializeServerUpdateOverlay();
    }

    public event EventHandler ViewCreditsButtonClicked
    {
        add => btnOpenCredits.Click += value;
        remove => btnOpenCredits.Click -= value;
    }

    public string CurrentVersionText
    {
        get => lblVersion.Text;
        set => lblVersion.Text = value;
    }

    public void ToggleCredits()
    {
        creditsPanelView.Visible = !creditsPanelView.Visible;
        infoPanelView.Visible = !infoPanelView.Visible;
    }

    private void OnServerInstallStopped()
    {
        _pnlUpdateServerfiles.Visible = false;
    }

    private void OnServerInstallStarted()
    {
        _pnlUpdateServerfiles.Visible = true;
    }

    private void pbxFormHeader_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, Constants.BUTTON_DOWN, Constants.CAPTION, 0);
        }
    }

    private void lblCloseButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void lblMinimizeButton_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void InitializeServerUpdateOverlay()
    {
        // calculate the top left corner for the panel based on header height
        int pX = pbxLeftBorder.Width;
        int pY = pnlTopBorder.Location.Y + pnlTopBorder.Height;
        // calculate the width of the panel based off the left edge to the start of the infoPanel border
        int pWidth = pnlInfoPanel.Location.X + pnlRightPanel.Location.X - pX;
        // calculate the height of the panel based off the height of the form minus the offset of the top of the panel
        int pHeight = Height - pY - pbxBottomBorder.Height;

        // Label
        _lblUpdateServerfiles.AutoSize = false;
        _lblUpdateServerfiles.Dock = DockStyle.Fill;
        _lblUpdateServerfiles.Location = new Point(0, 0);
        _lblUpdateServerfiles.TextAlign = ContentAlignment.MiddleCenter;
        _lblUpdateServerfiles.Text = "Updating Server Files...";
        _lblUpdateServerfiles.Visible = true;

        // Panel
        _pnlUpdateServerfiles.SuspendLayout();

        _pnlUpdateServerfiles.BackColor = Color.FromArgb(0, 0, 18);
        _pnlUpdateServerfiles.Controls.Add(_lblUpdateServerfiles);
        _pnlUpdateServerfiles.Location = new Point(pX, pY);
        _pnlUpdateServerfiles.Size = new Size(pWidth, pHeight);
        _pnlUpdateServerfiles.Visible = false;

        this.Controls.Add(_pnlUpdateServerfiles);

        _pnlUpdateServerfiles.BringToFront();
        _pnlUpdateServerfiles.ResumeLayout(false);
        _pnlUpdateServerfiles.PerformLayout();

    }
}