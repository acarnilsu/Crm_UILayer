﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;
        public Role GetByID(int id)
        {
            return _roleDal.GetByID(id);
        }

        public void TDelete(Role t)
        {
            _roleDal.Delete(t);
        }

        public List<Role> TGetListAll()
        {
            return _roleDal.GetListAll();
        }

        public void TInsert(Role t)
        {
            _roleDal.Insert(t);
        }

        public void TUpdate(Role t)
        {
            _roleDal.Update(t);
        }
    }
}
