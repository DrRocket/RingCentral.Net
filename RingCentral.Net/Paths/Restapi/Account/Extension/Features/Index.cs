using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Features
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/features";
        }

        /// <summary>
        /// Operation: Get User Features
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/features
        /// </summary>
        public async Task<RingCentral.FeatureList> Get(ReadUserFeaturesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.FeatureList>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Features.Index Features()
        {
            return new Restapi.Account.Extension.Features.Index(this);
        }
    }
}