﻿using Domain.DTO;
using Domain.Entities;

namespace CalifornianHealthApp.Services
{
    public class Repository : IRepository
    {

        public Repository()
        {
        }

        public List<Consultant> FetchConsultants()
        {
            //List<Consultant> cons = _context.consultants.ToList();
            return null;
        }

        public List<ConsultantCalendar> FetchConsultantCalendars()
        {
            //Should the consultant detail and the calendar (available dates) be clubbed together?
            //Is this the reason the calendar is slow to load? Rethink how we can rewrite this?

            return null/*_context.consultantCalendars.ToList()*/;
        }

        public bool CreateAppointment(Appointment model)
        {
            //Should we double check here before confirming the appointment?
            //_context.appointments.Add(model);
            return true;
        }
    }
}