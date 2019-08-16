﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InputshareLib.Input.Hotkeys
{
    public class ClientHotkey : Hotkey
    {
        public ClientHotkey(WindowsVirtualKey key, HotkeyModifiers mods, Guid targetClient) : base(key, mods)
        {
            TargetClient = targetClient;
        }

        public Guid TargetClient { get; }
    }
}
