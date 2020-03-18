// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using EntityFrameworkCore.Jet.FunctionalTests.TestUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.TestUtilities;

namespace EntityFrameworkCore.Jet.FunctionalTests
{
    public class ConferencePlannerJetTest : ConferencePlannerTestBase<ConferencePlannerJetTest.ConferencePlannerJetFixture
    >
    {
        public ConferencePlannerJetTest(ConferencePlannerJetFixture fixture)
            : base(fixture)
        {
        }

        protected override void UseTransaction(DatabaseFacade facade, IDbContextTransaction transaction)
            => facade.UseTransaction(transaction.GetDbTransaction());

        public class ConferencePlannerJetFixture : ConferencePlannerFixtureBase
        {
            protected override ITestStoreFactory TestStoreFactory => JetTestStoreFactory.Instance;
        }
    }
}
