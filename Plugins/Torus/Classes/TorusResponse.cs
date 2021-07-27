using System;

namespace Torus.Classes
{
    [Serializable]
    public class TorusResponse
    {
        [Serializable]
        public class Value
        {
            public string privateKey;
            public string publicAddress;
        }

        [Serializable]
        public class Reason
        {
            public string name;
            public string message;
        }

        public string status;
        public Value value;
        public Reason reason;
    }
}