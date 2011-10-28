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
    [Table( "cmsBlog" )]
    public partial class Blog : ModelWithAttributes, IAuditable
    {
		[DataMember]
		public Guid Guid { get; set; }
		
		[MaxLength( 75 )]
		[DataMember]
		public string Name { get; set; }
		
		[MaxLength( 200 )]
		[DataMember]
		public string Subtitle { get; set; }
		
		[MaxLength( 2000 )]
		[DataMember]
		public string Description { get; set; }
		
		[DataMember]
		public bool ModerateComments { get; set; }
		
		[MaxLength( 250 )]
		[DataMember]
		public string PublicPublishingPoint { get; set; }
		
		[MaxLength( 250 )]
		[DataMember]
		public string PublicFeedAddress { get; set; }
		
		[MaxLength( 250 )]
		[DataMember]
		public string CopyrightStatement { get; set; }
		
		[DataMember]
		public bool AllowComments { get; set; }
		
		[DataMember]
		public DateTime? CreatedDateTime { get; set; }
		
		[DataMember]
		public DateTime? ModifiedDateTime { get; set; }
		
		[DataMember]
		public int? CreatedByPersonId { get; set; }
		
		[DataMember]
		public int? ModifiedByPersonId { get; set; }
		
		[NotMapped]
		public override string AuthEntity { get { return "Cms.Blog"; } }

		public virtual ICollection<BlogCategory> BlogCategorys { get; set; }

		public virtual ICollection<BlogPost> BlogPosts { get; set; }

		public virtual ICollection<BlogTag> BlogTags { get; set; }

		public virtual Crm.Person CreatedByPerson { get; set; }

		public virtual Crm.Person ModifiedByPerson { get; set; }

        public static Blog Read(int id)
        {
            return new Rock.Services.Cms.BlogService().GetBlog( id );
        }
    }

    public partial class BlogConfiguration : EntityTypeConfiguration<Blog>
    {
        public BlogConfiguration()
        {
			this.HasOptional( p => p.CreatedByPerson ).WithMany().HasForeignKey( p => p.CreatedByPersonId );
			this.HasOptional( p => p.ModifiedByPerson ).WithMany().HasForeignKey( p => p.ModifiedByPersonId );
		}
    }
}
