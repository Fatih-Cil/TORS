using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RuleManager : IRuleService
    {
        IRuleDal _ruleDal;

        public RuleManager(IRuleDal ruleDal)
        {
            _ruleDal=ruleDal;
        }

        public void AddRule(Rule rule)
        {
            _ruleDal.Add(rule);
        }

        public List<Rule> GetAll()
        {
            return _ruleDal.GetAll();
        }

        public Rule GetById(int id)
        {
            return _ruleDal.Get(x=>x.Id == id);
        }

        public void RemoveRule(Rule rule)
        {
            _ruleDal.Delete(rule);
        }

        public void UpdateRule(Rule rule)
        {
           _ruleDal.Update(rule);
        }
    }
}
