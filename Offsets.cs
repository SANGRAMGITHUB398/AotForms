namespace AotForms
{
    internal static class Offsets
    {
        public static void LoadOffsets(bool forMax)
        {
            if (forMax)
            {
                // --- FF MAX SECTION ---
                InitBase = 0xB29057C;
                StaticClass = 0x5C;
                CurrentMatch = 0x50;
                MatchStatus = 0x74;
                GameTimer = 0x10;
                FixedDeltaTime = 0x24;
                SpeedJoystickOffsets = 0x44;
                PlayerRotation = 0xFC;
                LocalPlayer = 0x7C;
                Player_IsDead = 0x4C;
                Player_Data = 0x44;
                CurrentHP = 0x2B8;
                Player_Name = 0x27C;
                IsBot = 0x284;
                DictionaryEntities = 0x68;
                Player_ShadowBase = 0x15BC;
                PlayerAttributes = 0x44C;
                AimbotVisible = 0x434;
                XPose = 0x78;
                BotOffset = 0x58;
                DisableAFK = 0x6B2;
                AvatarManager = 0x450;
                Avatar = 0x94;
                Avatar_IsVisible = 0x7C;
                Avatar_Data = 0x10;
                Avatar_Data_IsTeam = 0x4D;
                AvatarPropManager = 0x458;
                FollowCamera = 0x3E0;
                Camera = 0x14;
                AimRotation = 0x398;
                MainCameraTransform = 0x200;
                ViewMatrix = 0xBC;
                Weapon = 0x38C;
                ActiveWeapon = 0x38C;
                WeaponOnHand = 0x4C;
                WeaponID = 0x08;
                WeaponRecoil = 0x0C;
                WeaponData = 0x64;
                WeaponInfo = 0x64;
                WeaponName = 0x58;
                UnkPlayerWeaponInfoClass = 0x44C;
                NoReload = 0x91;
                AimAssist = 0x3B8;
                sAim1 = 0x4D0;
                sAim2 = 0x8DC;
                sAim3 = 0x38;
                sAim4 = 0x2C;
            }
            else
            {
                // --- FF NORMAL SECTION ---
                InitBase = 0xA3F438C;
                StaticClass = 0x5C;
                CurrentMatch = 0x50;
                MatchStatus = 0x08;
                GameTimer = 0x10;
                FixedDeltaTime = 0x24;
                SpeedJoystickOffsets = 0x44;
                LocalPlayer = 0x7C;
                PlayerRotation = 0xFC;
                Player_IsDead = 0x4C;
                Player_Data = 0x44;
                CurrentHP = 0x2C8;
                Player_Name = 0x28C;
                IsBot = 0x294;
                DictionaryEntities = 0x68;
                Player_ShadowBase = 0x15E8;
                PlayerAttributes = 0x45C;
                DisableAFK = 0x6B2;
                XPose = 0x78;
                BotOffset = 0x58;
                AimbotVisible = 0x444;
                AvatarManager = 0x460;
                Avatar = 0x94;
                Avatar_IsVisible = 0x7C;
                Avatar_Data = 0x10;
                Avatar_Data_IsTeam = 0x51;
                AvatarPropManager = 0xBC;
                FollowCamera = 0x3F0;
                Camera = 0x14;
                AimRotation = 0x3A8;
                MainCameraTransform = 0x1FC;
                ViewMatrix = 0xBC;
                Weapon = 0x39C;
                ActiveWeapon = 0x39C;
                WeaponOnHand = 0x4C;
                WeaponData = 0x64;
                WeaponID = 0x08;
                WeaponName = 0x64;
                WeaponInfo = 0x64;
                WeaponRecoil = 0x91;
                UnkPlayerWeaponInfoClass = 0x444;
                NoReload = 0x91;
                AimAssist = 0x3C8;
                sAim1 = 0x4E0;
                sAim2 = 0x8F0;
                sAim3 = 0x38;
                sAim4 = 0x2C;
            }
        }
    }
}
