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

    public partial class tblCliente : Base
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCliente()
        {
            this.tblVentas = new HashSet<tblVenta>();
        }
    
        public string idCliente { get; set; }
        public string NombreCliente { get; set; }
        public System.DateTime fechaNacimientoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string EmailCliente { get; set; }
        public int TipoDocumentoCliente { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual tblTipoDocuman tblTipoDocuman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<tblVenta> tblVentas { get; set; }
    }
}
