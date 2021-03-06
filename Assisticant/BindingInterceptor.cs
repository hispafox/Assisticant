﻿using Assisticant.Metas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assisticant
{
    public class BindingInterceptor
    {
        public static BindingInterceptor Current = new BindingInterceptor();

        public virtual object GetValue(MemberSlot member) { return member.GetValue(); }
        public virtual void SetValue(MemberSlot member, object value) { member.SetValue(value); }
        public virtual void UpdateValue(MemberSlot member) { member.UpdateValue(); }
        public virtual void Execute(MethodCommand command, object parameter) { command.ContinueExecute(parameter); }
        public virtual bool CanExecute(MethodCommand command, object parameter) { return command.ContinueCanExecute(parameter); }
    }
}
