using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using developwithpassion.specifications.rhino;
using Machine.Specifications;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.specs
{

    public abstract class concern : Observes
    {

    }

    public class when_calling_with : concern
    {

        private Because b = () => result = Stub.with<TypeToStub>();

        private It should_be_same_type = () => result.ShouldBeOfType(typeof (TypeToStub));
        
        private static TypeToStub result;


        private class TypeToStub
            {
                
            }
    }
}
