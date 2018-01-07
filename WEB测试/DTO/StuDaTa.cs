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
            new ModelStu{id=1,age=2,name="zs",pc=1},
            new ModelStu{id=2,age=1,name="zs",pc=2},
            new ModelStu{id=3,age=1,name="zs",pc=3},
            new ModelStu{id=4,age=1,name="ls",pc=1},
            new ModelStu{id=5,age=2,name="ls",pc=2},
            new ModelStu{id=6,age=2,name="ls",pc=2},
            new ModelStu{id=7,age=2,name="lr",pc=2},
            new ModelStu{id=8,age=2,name="zs",pc=1},
            new ModelStu{id=9,age=3,name="zs",pc=2},
            new ModelStu{id=10,age=3,name="zs",pc=3},
            new ModelStu{id=11,age=3,name="ls",pc=1},
            new ModelStu{id=12,age=5,name="ls",pc=2},
            new ModelStu{id=13,age=5,name="ls",pc=2},
            new ModelStu{id=14,age=5,name="lr",pc=2}
            };

        }
    }
}