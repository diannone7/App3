﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public interface IGarbageDatabaseConnection
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
