using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Member
{
    public class Role
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string Name { get; set; } = "";
        [MaxLength(20)]
        public string Description { get; set; } = "";
        public virtual List<MemberRole> MemberRole { get; set; } = new List<MemberRole>();

        public virtual List<Permission> AllowedPermissions { get; set; } = new List<Permission>();
        public virtual List<Permission> DeniedPermissions { get; set; } = new List<Permission>();
    }

    public class Permission
    {
        public int Id { get; set; }
        public Permissions PermissionName { get; set; }
    }
}
