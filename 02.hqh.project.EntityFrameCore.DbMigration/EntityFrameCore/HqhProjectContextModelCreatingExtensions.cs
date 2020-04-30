using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace hqh.project.EntityFrameCore.DbMigration.EntityFrameCore
{
    /// <summary>
    ///表配置类
    /// </summary>
    public static class HqhProjectContextModelCreatingExtensions
    {
        public static  void Builder(this ModelBuilder builder)
        {
            builder.Entity<User>(b=> {
                b.ToTable("t_user");
                b.HasKey("Id");
                b.Property(p => p.Id).ValueGeneratedOnAdd();
            });
            /* Configure your own tables/entities inside here */
            Check.NotNull(builder, nameof(builder));
        }
    }
}
