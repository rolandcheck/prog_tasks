using System.Collections.Generic;
using System.Linq;

namespace LibraryProj.CBTasks.FTask439
{
    public class RelationDb
    {
        private readonly List<DbEntity> _entities;

        public List<int> LookUpCounts { get; private set; } = new List<int>();

        public RelationDb(IEnumerable<DbEntity> initData = null)
        {
            _entities = initData?.ToList() ?? new List<DbEntity>();
        }

        public DbEntity PeekFromTable(int id)
        {
            for (var i = 0; i < _entities.Count; i++)
            {
                var dbEntity = _entities[i];
                if (dbEntity.Id == id)
                {
                    LookUpCounts.Add(i + 1); // + 1 because index is 0-based

                    // if found push this elem into begging of the 'table'

                    _entities.RemoveAt(i);
                    _entities.Insert(0, dbEntity);
                    return dbEntity;
                }
            }

            // if not found
            LookUpCounts.Add(_entities.Count);

            return null;
        }

    }

    public class DbEntity
    {
        public DbEntity(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
