using System;
using System.Collections.Generic;
using System.Text;

namespace hqh.project.Dtos
{
    public class EntityDto<PrimaryKey> where PrimaryKey:struct
    {
        public PrimaryKey? Id { get; set; }
    }

    public class IntEntityDto: EntityDto<int>
    {

    }
}
