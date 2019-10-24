using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Blog.AutoFacModule.Solucation.AutoFac.Register
{
    public class AutofacModuleRegister : Autofac.Module
    {
        //重写Autofac管道Load方法，在这里注册注入
        protected override void Load(ContainerBuilder builder)
        {
            //必须是Service结束的
            builder.RegisterAssemblyTypes(GetAssemblyByName("BlogService")).Where(a => a.Name.EndsWith("Service")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(GetAssemblyByName("BlogRepository")).Where(a => a.Name.EndsWith("Repository")).AsImplementedInterfaces();
            //单一注册
            //  builder.RegisterType<PersonService>().Named<IPersonService>(typeof(PersonService).Name);
        }
        /// <summary>
        /// 根据程序集名称获取程序集
        /// </summary>
        /// <param name="AssemblyName">程序集名称</param>
        public static Assembly GetAssemblyByName(String AssemblyName)
        {
            return Assembly.Load(AssemblyName);
        }
    }
}
