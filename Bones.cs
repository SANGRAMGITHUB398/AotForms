namespace AotForms
{
    internal static class Bones
    {
        public static void LoadBones(bool forMax)
        {
            if (forMax)
            {
                // --- BONES MAX SECTION ---
                Head = 0x3E8;
                Hip = 0x3EC;
                Spine = 0x3F0;
                Root = 0x3FC;
                RightCalf = 0x400;
                LeftCalf = 0x404;
                RightFoot = 0x408;
                LeftFoot = 0x40C;
                LeftWrist = 0x3E4;
                RightWrist = 0x410;
                LeftHand = 0x414;
                LeftShoulder = 0x41C;
                RightShoulder = 0x420;
                RightWristJoint = 0x424;
                LeftWristJoint = 0x428;
                LeftElbow = 0x42C;
                RightElbow = 0x430;
            }
            else
            {
                // --- BONES NORMAL SECTION ---
                Head = 0x3F8;
                Hip = 0x3FC;
                Spine = 0x400;
                Root = 0x40C;
                RightCalf = 0x410;
                LeftCalf = 0x414;
                RightFoot = 0x418;
                LeftFoot = 0x41C;
                LeftWrist = 0x3F4;
                RightWrist = 0x420;
                LeftHand = 0x424;
                LeftShoulder = 0x42C;
                RightShoulder = 0x430;
                RightWristJoint = 0x434;
                LeftWristJoint = 0x438;
                LeftElbow = 0x43C;
                RightElbow = 0x440;
            }
        }
    }
}
