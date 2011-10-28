//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using Rock.Models;

namespace Rock.Models.Cms
{
    [Table( "cmsSite" )]
    public partial class Site : ModelWithAttributes, IAuditable
    {
		[DataMember]
		public Guid Guid { get; set; }
		
		[DataMember]
		public bool System { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Name { get; set; }
		
		[DataMember]
		public string Description { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Theme { get; set; }
		
		[DataMember]
		public int? DefaultPageId { get; set; }
		
		[MaxLength( 150 )]
		[DataMember]
		public string FaviconUrl { get; set; }
		
		[MaxLength( 150 )]
		[DataMember]
		public string AppleTouchIconUrl { get; set; }
		
		[MaxLength( 25 )]
		[DataMember]
		public string FacebookAppId { get; set; }
		
		[MaxLength( 50 )]
		[DataMember]
		public string FacebookAppSecret { get; set; }
		
		[MaxLength( 10 )]
		[DataMember]
		public string LoginPageReference { get; set; }
		
		[MaxLength( 10 )]
		[DataMember]
		public string RegistrationPageReference { get; set; }
		
		[DataMember]
		public DateTime? CreatedDateTime { get; set; }
		
		[DataMember]
		public DateTime? ModifiedDateTime { get; set; }
		
		[DataMember]
		public int? CreatedByPersonId { get; set; }
		
		[DataMember]
		public int? ModifiedByPersonId { get; set; }
		
		[NotMapped]
		public override string AuthEntity { get { return "Cms.Site"; } }

		public virtual ICollection<Page> Pages { get; set; }

		public virtual ICollection<SiteDomain> SiteDomains { get; set; }

		public virtual Page DefaultPage { get; set; }

		public virtual Crm.Person CreatedByPerson { get; set; }

		public virtual Crm.Person ModifiedByPerson { get; set; }

        public static Site Read(int id)
        {
            return new Rock.Services.Cms.SiteService().GetSite( id );
        }
    }

    public partial class SiteConfiguration : EntityTypeConfiguration<Site>
    {
        public SiteConfiguration()
        {
			this.HasOptional( p => p.DefaultPage ).WithMany( p => p.Sites ).HasForeignKey( p => p.DefaultPageId );
			this.HasOptional( p => p.CreatedByPerson ).WithMany().HasForeignKey( p => p.CreatedByPersonId );
			this.HasOptional( p => p.ModifiedByPerson ).WithMany().HasForeignKey( p => p.ModifiedByPersonId );
		}
    }
}
