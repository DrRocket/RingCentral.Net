namespace RingCentral
{
    public class PagingOnlyGroupDevices
    {
        /// <summary>
        /// Link to the list of devices assigned to the paging only group
        /// </summary>
        public string uri;

        /// <summary>
        /// List of paging devices assigned to this group
        /// </summary>
        public PagingDeviceInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}