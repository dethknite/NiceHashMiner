﻿using NHM.Common.Enums;
using NHM.MinerPluginToolkitV1.Configs;
using System.Collections.Generic;

namespace LolMiner
{
    internal static class PluginInternalSettings
    {
        static string _urlPort => $"{MinerCommandLineSettings.POOL_URL_TEMPLATE}:{MinerCommandLineSettings.POOL_PORT_TEMPLATE}";
        static string _url => MinerCommandLineSettings.POOL_URL_TEMPLATE;
        static string _username => MinerCommandLineSettings.USERNAME_TEMPLATE;
        static string _apiPort => MinerCommandLineSettings.API_PORT_TEMPLATE;
        static string _devices => MinerCommandLineSettings.DEVICES_TEMPLATE;
        static string _extraLaunchParameters => MinerCommandLineSettings.EXTRA_LAUNCH_PARAMETERS_TEMPLATE;

        // $"--pool {urlWithPort} --user {_username} --tls 0 --apiport {_apiPort} {_disableWatchdogParam} --devices {_devices} {_extraLaunchParameters}";
        internal static MinerCommandLineSettings MinerCommandLineSettings = new MinerCommandLineSettings
        {
            DevicesSeparator = ",",
            AlgorithmCommandLine = new Dictionary<string, string>
            {
                {
                    $"{AlgorithmType.ZHash}",
                    $"--coin AUTO144_5 --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.BeamV3}",
                    $"--algo BEAM-III --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.DaggerHashimoto}",
                    $"--algo ETHASH --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters} --ethstratum ETHV1"
                },
                {
                    $"{AlgorithmType.Autolykos}",
                    $"--algo AUTOLYKOS2 --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.ZelHash}",
                    $"--coin ZEL --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.EtcHash}",
                    $"--algo ETCHASH --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters} --ethstratum ETHV1"
                },
                {
                    $"{AlgorithmType.CuckooCycle}",
                    $"--algo C29AE --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.NexaPow}",
                    $"--algo NEXA --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.Alephium}",
                    $"--algo ALEPH --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.FishHash}",
                    $"--algo FISHHASH --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.PyrinHash}",
                    $"--algo PYRIN --pool {_urlPort} --user {_username} --tls 0 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                }
            },
            AlgorithmCommandLineSSL = new Dictionary<string, string>
            {
                {
                    $"{AlgorithmType.ZHash}",
                    $"--coin AUTO144_5 --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.BeamV3}",
                    $"--algo BEAM-III --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.DaggerHashimoto}",
                    $"--algo ETHASH --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters} --ethstratum ETHV1"
                },
                {
                    $"{AlgorithmType.Autolykos}",
                    $"--algo AUTOLYKOS2 --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.ZelHash}",
                    $"--coin ZEL --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.EtcHash}",
                    $"--algo ETCHASH --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters} --ethstratum ETHV1"
                },
                {
                    $"{AlgorithmType.CuckooCycle}",
                    $"--algo C29AE --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.NexaPow}",
                    $"--algo NEXA --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.Alephium}",
                    $"--algo ALEPH --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.FishHash}",
                    $"--algo FISHHASH --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                },
                {
                    $"{AlgorithmType.PyrinHash}",
                    $"--algo PYRIN --pool {_url}:443 --user {_username} --tls 1 --apiport {_apiPort} --disablewatchdog 1 --devices {_devices} {_extraLaunchParameters}"
                }
            }
        };

        internal static MinerSystemEnvironmentVariables MinerSystemEnvironmentVariables = new MinerSystemEnvironmentVariables
        {
            DefaultSystemEnvironmentVariables = new Dictionary<string, string>
            {
                {"GPU_MAX_ALLOC_PERCENT", "100"},
                {"GPU_SINGLE_ALLOC_PERCENT", "100"},
                {"GPU_MAX_HEAP_SIZE", "100"},
                {"GPU_FORCE_64BIT_PTR", "1"},
                {"GPU_USE_SYNC_OBJECTS", "1"}
            }
        };


    }
}
