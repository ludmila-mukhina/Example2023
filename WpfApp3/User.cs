//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public System.DateTime DateBirthday { get; set; }
        public int Role { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
