﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace BlogApp.Migrations
{
    [Migration(3)]
    public class _003_AddContentToPosts : Migration
    {
        public override void Up()
        {
            Create.Column("content").OnTable("posts").AsCustom("TEXT");
        }

        public override void Down()
        {
            Delete.Column("content").FromTable("posts");
        }
    }
}