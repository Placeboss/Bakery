//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bakery
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int id_order { get; set; }
        public string product { get; set; }
        public string amount { get; set; }
        public int price { get; set; }
        public int id_seller { get; set; }
    
        public virtual seller seller { get; set; }
    }
}
