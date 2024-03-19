using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.IOC
{
    public static class BusinessIOC
    {
        public static void AddBusinessServiceIOC(this IServiceCollection services)
        {


            services.AddSingleton<IEquipmentService, EquipmentManager>();
            services.AddSingleton<IEquipmentDal, EquipmentDal>();

            services.AddSingleton<IMeetingRoomService, MeetingRoomManager>();
            services.AddSingleton<IMeetingRoomDal, MeetingRoomDal>();

            services.AddSingleton<IReservationService, ReservationManager>();
            services.AddSingleton<IReservationDal, ReservationDal>();

            services.AddSingleton<IRuleService, RuleManager>();
            services.AddSingleton<IRuleDal, RuleDal>();

        }
    }
}
