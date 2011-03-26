﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NSpec;
using NSpec.Domain;

namespace NSpecSpecs
{
    [TestFixture]
    public class describe_implicit_befores : when_running_specs
    {
        private class SpecClass : nspec
        {
            public void method_level_context()
            {
                List<int> ints = new List<int>();
                ints.Add(5);

                it["should have two entries"] = () =>
                {
                    ints.Add(16);
                    ints.Count.should_be(1);
                };

                specify = () => ints.Count.should_be(1);
            }
        }

        private Context classContext;
        private Context methodContext;

        [SetUp]
        public void setup()
        {
            Run(typeof(SpecClass));
        }

        [Test]
        public void should_give_each_specify_a_new_instance_of_spec()
        {
            Assert.Inconclusive("I dont think this is possible....");
            TheMethodContextExamples().First().Exception.should_be(null);
            TheMethodContextExamples().Last().Exception.should_be(null);
        }

        private IEnumerable<Example> TheMethodContextExamples()
        {
            return classContext.Contexts.First().AllExamples();
        }
    }
}
