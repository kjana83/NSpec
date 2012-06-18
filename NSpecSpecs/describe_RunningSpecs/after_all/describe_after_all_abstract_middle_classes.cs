﻿using NUnit.Framework;

namespace NSpecSpecs.describe_RunningSpecs.after_all
{
    abstract class AbstractDerivedClass1 : DerivedClass
    {
        void after_all()
        {
            log.Add("AbstractDerivedClass1 after_all");
        }
    }

    abstract class AbstractDerivedClass2 : AbstractDerivedClass1
    {
    }

    abstract class AbstractDerivedClass3 : AbstractDerivedClass2
    {
        void after_all()
        {
            log.Add("AbstractDerivedClass3 after_all");
        }
    }

    class DerivedClass2 : AbstractDerivedClass3
    {
        void after_all()
        {
            log.Add("DerivedClass2 after_all");
        }

        void running_example()
        {
            it["works"] = () => log.Add("DerivedClass2 running_example it works");
        }
    }

    public class describe_after_all_abstract_middle_classes
    {
        [Test]
        [Ignore]
        public void after_alls_are_run_in_the_correct_order_when_abstract_middle_classes_are_present()
        {
            //Run(typeof(DerivedClass2));

            //TODO: must implement logic for abstract classes.
            //SpecClass.log.should_be(new[]
            //    {
            //        "context_b beforeEach",
            //        "context_b it 1",
            //        "context_b afterEach",
            //        "DerivedClass after_each",
            //        "SpecClass after_each",
            //        "context_b beforeEach",
            //        "context_b it 2",
            //        "context_b afterEach",
            //        "DerivedClass after_each",
            //        "SpecClass after_each",
            //        "context_b afterAll",
            //        "DerivedClass after_all",
            //        "SpecClass after_all"
            //    });
        }

    }
}