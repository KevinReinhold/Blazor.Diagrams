using Blazor.Diagrams.Core.Geometry;
using SharedDemo.Performance.Models;
using SharedDemo.Performance.Models.ConnectorTypes;

namespace SharedDemo.Performance.Services
{
    public static class FunctionBlockGenerator
    {
        public static FunctionBlock CreateSmallBlock(Point position)
        {
            var fb = new FunctionBlock()
            {
                ClusterNodeId = "A",
                Connectors = new()
                {
                    new FunctionBlockConnector<FbConfig>()
                    {
                        Description = "FC",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "FbConfing",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 0
                    },
                    new FunctionBlockConnector<FbConfig>()
                    {
                        Description = "FC",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "FbConfing",
                        RowIndex = 0
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "FE",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "FbEnabled",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 1
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "FE",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "FbEnabled",
                        RowIndex = 1
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "TS",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "ToggleState",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 4
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "State",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "State",
                        RowIndex = 4
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "DS",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "DirectSet",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 5
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "SO",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "SwitchOn",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 6
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "SO",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "SwitchOff",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 7
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "DS",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "DominantState",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 9
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "DS",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "DominantState",
                        RowIndex = 9
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "MS",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "MovementState",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 11
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "AM",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "AutomaticMode",
                        RowIndex = 11
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "TE",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "TimerEnabled",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 13
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "TE",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "TimerEnabled",
                        RowIndex = 13
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "TD",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "TimerDuration",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 14
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "TD",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "TimerDuration",
                        RowIndex = 14
                    }
                },
                ImageName = "fb_switch.png",
                Name = "Switch",
                Position = position,
                RunMode = new()
                {
                    Mode = FunctionBlockRunModeType.Never
                }
            };

            return fb;
        }

        public static FunctionBlock CreateLargeBlock(Point position)
        {
            var fb = new FunctionBlock()
            {
                ClusterNodeId = "X",
                Connectors = new()
                {
                    new FunctionBlockConnector<FbConfig>()
                    {
                        Description = "FC",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "FbConfing",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 0
                    },
                    new FunctionBlockConnector<FbConfig>()
                    {
                        Description = "FC",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "FbConfing",
                        RowIndex = 0
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "FE",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "FbEnabled",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 1
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "FE",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "FbEnabled",
                        RowIndex = 1
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "DE",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "DriverEnabled",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 2
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "DE",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "DriverEnabled",
                        RowIndex = 2
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Cn",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Connected",
                        RowIndex = 4
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "FZ",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "FixedZone",
                        RowIndex = 5
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "ZId",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "ZoneId",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 6
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "CZId",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentZoneId",
                        RowIndex = 6
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "ZName",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "ZoneName",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 7
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "CZN",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentZoneName",
                        RowIndex = 7
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "ZNext",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "ZoneNext",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 8
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "CZGT",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentZoneGroupedTo",
                        RowIndex = 8
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "ZPre",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "ZonePrevious",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 9
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "NOZ",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "NumberOfZones",
                        RowIndex = 9
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "RG",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "RemoveGrouping",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 10
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "NOP",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "NumberOfPlayers",
                        RowIndex = 10
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "PM",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "PartyMode",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 11
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "PM",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "PartyMode",
                        RowIndex = 11
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "TPP",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "TogglePlayerPause",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 13
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Play",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Play",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 14
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Play",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Playing",
                        RowIndex = 14
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Pause",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Pause",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 15
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "DT",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "DurationTime",
                        RowIndex = 15
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Stop",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Stop",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 16
                    },
                    new FunctionBlockConnector<double>()
                    {
                        Description = "DTP",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "DurationTimePercent",
                        RowIndex = 16
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Next",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Next",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 17
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "CA",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentAlbum",
                        RowIndex = 17
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Prev",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Previous",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 18
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "CAr",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentArtist",
                        RowIndex = 18
                    },
                    new FunctionBlockConnector<double>()
                    {
                        Description = "TP",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "TrackPosition",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 19
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "CT",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentTitle",
                        RowIndex = 19
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "TN",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "TrackNumber",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 20
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "CCU",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentCoverUrl",
                        RowIndex = 20
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "Playlist",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Playlist",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 21
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "CI",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentInformation",
                        RowIndex = 21
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "Radio",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Radio",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 22
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "NA",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "NextAlbum",
                        RowIndex = 22
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "AI",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "AudioIn",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 23
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "NAr",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "NextArtist",
                        RowIndex = 23
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "NT",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "NextTitle",
                        RowIndex = 24
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "NCU",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "NextCoverUrl",
                        RowIndex = 25
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "TrackNr",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CurrentTrackNumber",
                        RowIndex = 26
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "Tracks",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "NumberOfTracks",
                        RowIndex = 27
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Mute",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Mute",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 29
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Mute",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Mute",
                        RowIndex = 29
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Vol",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Volume",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 30
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Vol",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Volume",
                        RowIndex = 30
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "VUp",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "VolumeUp",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 31
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "VDown",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "VolumeDown",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 32
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "SE",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "SubEnabled",
                        RowIndex = 33
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "VSub",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "VolumeSub",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 34
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "VSub",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "VolumeSub",
                        RowIndex = 34
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "REQ",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "ResetEQ",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 36
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Bala",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Balance",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 37
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Bala",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Balance",
                        RowIndex = 37
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Bass",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Bass",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 38
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Bass",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Bass",
                        RowIndex = 38
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Treble",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Treble",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 39
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "Treble",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Treble",
                        RowIndex = 39
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Loud",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Loudness",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 40
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Loud",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Loudness",
                        RowIndex = 40
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "CFade",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "CrossFade",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 42
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "CFade",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "CrossFade",
                        RowIndex = 42
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "RA",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "RepeatAll",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 43
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "RA",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "RepeatAll",
                        RowIndex = 43
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "RO",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "RepeatOne",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 44
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "RO",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "RepeatOne",
                        RowIndex = 44
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Shuf",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "Shuffle",
                        PoolingMode = FunctionBlockPoolingMode.Or,
                        RowIndex = 45
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "Shuf",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "Shuffle",
                        RowIndex = 45
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "SNR",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "ShuffleNoRepeat",
                        RowIndex = 46
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "PM",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "PlayMode",
                        RowIndex = 47
                    },
                    new FunctionBlockConnector<long>()
                    {
                        Description = "ST",
                        EventEnabled = false,
                        IsInput = true,
                        LoggingEnabled = false,
                        Name = "SleepTimer",
                        PoolingMode = FunctionBlockPoolingMode.Any,
                        RowIndex = 49
                    },
                    new FunctionBlockConnector<bool>()
                    {
                        Description = "ST",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "SleepTimer",
                        RowIndex = 49
                    },
                    new FunctionBlockConnector<string>()
                    {
                        Description = "ST",
                        EventEnabled = false,
                        IsInput = false,
                        LoggingEnabled = false,
                        Name = "SleepTimerRemainingDuration",
                        RowIndex = 50
                    }
                },
                ImageName = "fb_sonos.png",
                Name = "Controller",
                Position = position,
                RunMode = new()
                {
                    Mode = FunctionBlockRunModeType.Change
                }
            };

            return fb;
        }
    }
}
