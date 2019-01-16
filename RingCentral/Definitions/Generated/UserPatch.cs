using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class UserPatch : Serializable
    {
        // patch operations list
        public PatchOperation[] Operations; // Required
        public string[] schemas; // Required
    }
}