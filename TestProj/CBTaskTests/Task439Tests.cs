using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryProj.CBTasks.FTask439;
using NUnit.Framework;

namespace TestProj.CBTaskTests
{
    [TestFixture]
    public class Task439Tests
    {

        [Test]
        public void Task439TestsCorrectResults()
        {
            // arrange
            var initData = Enumerable.Range(1, 6).Select(x => new DbEntity(x));
            var db = new RelationDb(initData);

            var ids = new[] {5, 3};
            var expected = new[] {5, 4};


            // act
            foreach (var id in ids)
            {
                _ = db.PeekFromTable(id);
            }


            // assert
            var counts = db.LookUpCounts;

            Assert.True(counts.SequenceEqual(expected));
        }
    }
}
