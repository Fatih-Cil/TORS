using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRuleService
    {
        List<Rule> GetAll();
        Rule GetById(int id);
        void AddRule(Rule rule);
        void RemoveRule(Rule rule);
        void UpdateRule(Rule rule);
    }
}
