using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRuntime
{
    public class FormBag  : DynamicObject
    {
        //DLR : Dynamic Language Runtime
        //CLR :Compile Dynamic Runtime
        Dictionary<string, object> bag;= 
        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            return base.TrySetMember(binder, value);
        }
        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            return base.TryGetMember(binder, out result);
        }
    }
}
