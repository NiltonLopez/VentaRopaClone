//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pApp_Serv_WEB.Modelos
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class tblSede
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSede()
        {
            this.tblVentas = new HashSet<tblVenta>();
        }
    
        public int idSede { get; set; }
        public string NombreSede { get; set; }
        public string direccion { get; set; }
        public int idCiudadSede { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }


        [JsonIgnore]
        [IgnoreDataMember]
        public virtual tblCiudad tblCiudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<tblVenta> tblVentas { get; set; }
    }
}