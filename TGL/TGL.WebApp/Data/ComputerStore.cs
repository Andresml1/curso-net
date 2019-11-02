﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class ComputerStore
    {
        public TGLContext Context { get; set; }
        public Computer computer { get; set; }

        public ComputerStore(TGLContext context)
        {
            Context = context;
        }

        internal void EditComputer(Computer computer)
        {
            Computer currentComputer = GetComputerById(computer.Id);
            currentComputer.Brand = computer.Brand;
            currentComputer.Cpu = computer.Cpu;
            currentComputer.Ram = computer.Ram;
            currentComputer.Model = computer.Model;
            Context.Computer.Update(currentComputer);
            Context.SaveChanges();
        }


        internal Computer GetComputerById(Guid id)
        {
            return Context.Computer.FirstOrDefault(x => x.Id == id);

        }

        internal void AddComputer(Computer computer)
        {

            Context.Computer.Add(computer);
            Context.SaveChanges();
        }

        internal void DeleteComputer(Guid id)
        {
            var student = Context.Student.FirstOrDefault(x => x.Id == id);
            Context.Computer.Remove(computer);
            Context.SaveChanges();
        }

        public List<Computer> GetComputers()
        {
            return Context.Computer.ToList();
        }
    }
}
