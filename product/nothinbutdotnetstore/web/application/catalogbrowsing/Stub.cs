using System;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public static class Stub
    {
        public static TypeToStub with<TypeToStub>()
        {
            return (TypeToStub)Activator.CreateInstance(typeof(TypeToStub));
        }
    }


}