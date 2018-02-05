using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Game.Component.Network {
    using _PlayData = PlayData;

    public struct PlayData {
        public int[] connIds;
        public InputData[] inputDatas;
    }

    public struct InputData {
        public Vector3 mousePos;
        public bool isDown;
    }

    public static class CustomMsgType {
        public static short Init = MsgType.Highest + 1;
        public static short PlayData = MsgType.Highest + 2;
        public static short AddConnection = MsgType.Highest + 3;
        public static short Report = MsgType.Highest + 4;
        public static short DelConnection = MsgType.Highest + 5;
    }

    namespace Message {
        public class Empty : MessageBase {}

        public class Init : MessageBase {
            public int seed;
            public int[] connIds;
        }

        public class PlayData : MessageBase {
            public _PlayData playData;
        }

        public class Report : MessageBase {
            public int playFrame;
            public InputData inputData;
            public string comparison;
        }
    }
}


