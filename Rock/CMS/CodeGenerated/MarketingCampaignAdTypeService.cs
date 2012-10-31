//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Cms
{
    /// <summary>
    /// MarketingCampaignAdType Service class
    /// </summary>
    public partial class MarketingCampaignAdTypeService : Service<MarketingCampaignAdType, MarketingCampaignAdTypeDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingCampaignAdTypeService"/> class
        /// </summary>
        public MarketingCampaignAdTypeService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingCampaignAdTypeService"/> class
        /// </summary>
        public MarketingCampaignAdTypeService(IRepository<MarketingCampaignAdType> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override MarketingCampaignAdType CreateNew()
        {
            return new MarketingCampaignAdType();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<MarketingCampaignAdTypeDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<MarketingCampaignAdTypeDto> QueryableDto( IQueryable<MarketingCampaignAdType> items )
        {
            return items.Select( m => new MarketingCampaignAdTypeDto()
                {
                    IsSystem = m.IsSystem,
                    Name = m.Name,
                    DateRangeType = m.DateRangeType,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }
    }
}
