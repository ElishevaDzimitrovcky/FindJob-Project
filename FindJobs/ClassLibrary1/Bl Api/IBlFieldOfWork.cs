﻿using Bl.Bl_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Bl_Api
{
    public interface IBlFieldOfWork
    {
        List<BlFieldOfWork> GetAll();
    }
}
