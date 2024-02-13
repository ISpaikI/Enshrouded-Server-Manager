﻿namespace Enshrouded_Server_Manager.Services;

public interface IBackupService
{
    void Save(string saveFileDirectory, string profileName, string serverConfigFileName, string serverConfigDirectory);
    void StartAutoBackup(string saveFileDirectory, string profileName, int interval, int maximumBackups, string serverConfigFileName, string serverConfigDirectory);
    int GetBackupCount(string profileName);
    long GetDiskConsumption(string profileName);
}