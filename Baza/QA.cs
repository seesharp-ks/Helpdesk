//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace helpdesk.Baza
{
    using System;
    using System.Collections.Generic;
    
    public partial class QA
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Nullable<int> AuthorID { get; set; }
    
        public virtual Account Account { get; set; }
    }
}