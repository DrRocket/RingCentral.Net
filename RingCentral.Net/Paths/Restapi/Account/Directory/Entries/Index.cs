using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public RestClient rc;
        public string entryId;
        public Restapi.Account.Directory.Index parent;

        public Index(Restapi.Account.Directory.Index parent, string entryId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.entryId = entryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && entryId != null)
            {
                return $"{parent.Path()}/entries/{entryId}";
            }

            return $"{parent.Path()}/entries";
        }

        /// <summary>
        /// Operation: Get Company Directory Entries
        /// Http Get /restapi/v1.0/account/{accountId}/directory/entries
        /// </summary>
        public async Task<RingCentral.DirectoryResource> List(ListDirectoryEntriesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.DirectoryResource>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Get Corporate Directory Entry
        /// Http Get /restapi/v1.0/account/{accountId}/directory/entries/{entryId}
        /// </summary>
        public async Task<RingCentral.ContactResource> Get()
        {
            if (this.entryId == null)
            {
                throw new System.ArgumentNullException("entryId");
            }

            return await rc.Get<RingCentral.ContactResource>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Restapi.Account.Directory.Entries.Index Entries(string entryId = null)
        {
            return new Restapi.Account.Directory.Entries.Index(this, entryId);
        }
    }
}