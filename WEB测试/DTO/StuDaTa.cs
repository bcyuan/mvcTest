using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using 测试web.Models;

namespace WEB测试.DTO
{
    public class StuDaTa
    {
        public static List<ModelStu> GetData()
        {
            return new List<ModelStu>{
            new ModelStu{id=1,age=1,name="zs",pc=1},
            new ModelStu{id=2,age=1,name="zs",pc=2},
            new ModelStu{id=3,age=3,name="zs",pc=3},
            new ModelStu{id=4,age=3,name="ls",pc=1},
            new ModelStu{id=5,age=5,name="ls",pc=2},
            new ModelStu{id=6,age=5,name="ls",pc=2},
            new ModelStu{id=7,age=5,name="lr",pc=2}
            };

        }
    }
}