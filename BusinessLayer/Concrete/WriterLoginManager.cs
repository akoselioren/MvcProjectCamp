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
    public class WriterLoginManager : IWriterLoginService
    {
        IWriterDal _iwriterdal;

        public WriterLoginManager(IWriterDal iwriterdal)
        {
            _iwriterdal = iwriterdal;
        }

        public Writer GetWriter(string username, string password)
        {
            return _iwriterdal.Get(x => x.WriterMail == username && x.WriterPassword == password);
        }
    }
}
