//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lowes.Catalog.Importer
{
    using System;
    using System.Collections.Generic;
    
    public partial class spatialcategory
    {
        public spatialcategory()
        {
            this.groups = new HashSet<group>();
        }
    
        public string name { get; set; }
    
        public virtual ICollection<group> groups { get; set; }
    }
}
