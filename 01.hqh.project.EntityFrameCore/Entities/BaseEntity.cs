using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace hqh.project.EntityFrameCore
{
    public class BaseEntity<PrimaryKey> : IEntity<PrimaryKey>
    {
        public PrimaryKey Id { get; set; }

        public object[] GetKeys()
        {
            throw new NotImplementedException();
        }
    }
}
